package org.limepietechnologies;
import java.io.*;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

public class HashingMachine {
    /**
     * Calculates hash values of a file
     * @param file
     * @return
     * @throws IOException
     */
    public static String[] getFileChecksum(File file) throws IOException, NoSuchAlgorithmException {
        MessageDigest sha1Digest = MessageDigest.getInstance("SHA-1");
        MessageDigest md5Digest = MessageDigest.getInstance("MD5");
        MessageDigest sha256Digest = MessageDigest.getInstance("SHA-256");
        return new String[] {generateFileHash(md5Digest,file),generateFileHash(sha1Digest,file),generateFileHash(sha256Digest,file)};
    }

    /**
     *  Reads a file and returns the hash given a specific digest algorithm
     * @param messageDigest
     * @param file
     * @return String
     * @throws IOException
     */
    private static String generateFileHash(MessageDigest messageDigest,File file) throws IOException {
        byte[] buffer = new byte[1024];
        InputStream stream = new FileInputStream(file);
        int bytes=0;
        while ((bytes=stream.read(buffer))!=-1){
            messageDigest.update(buffer,0,bytes);
        }
        stream.close();
        return byteArrayToHexString(messageDigest.digest());
    }

    /**
     * converts a byte array to a hex string
     * @param bytes
     * @return String
     */
    private static String byteArrayToHexString(byte[] bytes){
        StringBuilder builder=new StringBuilder(2 * bytes.length);
        for (int i = 0; i < bytes.length; i++) {
            String hexString = Integer.toHexString(0xff & bytes[i]);
            if(hexString.length() == 1) {
                builder.append('0');
            }
            builder.append(hexString);
        }
        return builder.toString();
    }
}
