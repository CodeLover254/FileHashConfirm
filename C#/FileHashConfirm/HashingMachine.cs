using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace FileHashConfirm
{
    public class HashingMachine
    {
        
        /// <summary>
        /// A asyncronous method that runs a task to calculate the hashes
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static async Task<string[]> GetFileChecksumAsync(string file)
        {
            var results = await Task.Run(() => CalculateHashes(file));
            return results;
        }

        /// <summary>
        /// A method that calls required methods to calculate 
        /// different hashes
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private static string[] CalculateHashes(string file)
        {
            string md5Checksum = GetMd5Checksum(file);
            string sha1Checksum = GetSha1Checksum(file);
            string sha256Checksum = GetSha256Checksum(file);
            return new [] { md5Checksum, sha1Checksum, sha256Checksum };
        }

       /// <summary>
       /// A method to compute the md5 hash
       /// </summary>
       /// <param name="file"></param>
       /// <returns></returns>
        private static string GetMd5Checksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                using (MD5 md5 = MD5.Create())
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", String.Empty).ToLower();
                }
            }
        }

        /// <summary>
        /// A method to compute the sha1 hash
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private static string GetSha1Checksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                using (SHA1 sha1 = SHA1.Create())
                {
                    return BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", String.Empty).ToLower(); ;
                }
            }
        }

      /// <summary>
      /// A method to compute the sha256 hash
      /// </summary>
      /// <param name="file"></param>
      /// <returns></returns>
        private static string GetSha256Checksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    return BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", String.Empty).ToLower(); ;
                }
            }
        }
    }
}
