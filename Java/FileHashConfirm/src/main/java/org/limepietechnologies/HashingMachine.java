package org.limepietechnologies;

import com.google.common.hash.HashCode;
import com.google.common.hash.Hashing;
import com.google.common.io.ByteSource;
import com.google.common.io.Files;
import java.io.File;
import java.io.IOException;

public class HashingMachine {
    /**
     * Calculates hash values of a file
     * @param file
     * @return
     * @throws IOException
     */
    public static String[] getFileChecksum(File file) throws IOException{
        ByteSource byteSource = Files.asByteSource(file);
        HashCode md5HashCode = byteSource.hash(Hashing.md5());
        HashCode sha1HashCode = byteSource.hash(Hashing.sha1());
        HashCode sha256HashCode = byteSource.hash(Hashing.sha256());
        return new String[] {md5HashCode.toString(),sha1HashCode.toString(),sha256HashCode.toString()};
    }
}
