using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CUALoans.Controller
{
    internal class Hash
    {
        public static string Md5(string key = "md5")
        {
            var md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.UTF8.GetBytes(key));

            var hashBytes = md5.Hash;
            var strb = new StringBuilder();
            foreach (var t in hashBytes)
                strb.Append(t.ToString("x2"));

            return strb.ToString();
        }

        public static string Sha1(string key = "sha1")
        {
            var sha1 = new SHA1CryptoServiceProvider();
            sha1.ComputeHash(Encoding.UTF8.GetBytes(key));

            var hashBytes = sha1.Hash;
            var strb = new StringBuilder();
            foreach (var t in hashBytes)
                strb.Append(t.ToString("X2"));

            return strb.ToString();
        }

        public static string Unique()
        {
            var seed = new Random().Next(1000);
            var rand = new Random().Next(seed);
            var currdt = DateTime.Now.ToString("yyyyMMddHmsms");
            return string.Format("{0}{1}", rand, currdt);
        }

        public static string AesEncrypt(string rawText = "rawtext", string key = "key")
        {
            string encry = null;
            var clearBytes = Encoding.Unicode.GetBytes(rawText);
            using (var encryptor = Aes.Create())
            {
                if (key != null)
                {
                    var
                        pdb = new
                            Rfc2898DeriveBytes
                            (key,
                                new byte[]
                                {
                                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                                });
                    if (encryptor != null)
                    {
                        encryptor.Key = pdb.GetBytes(32);
                        encryptor.IV = pdb.GetBytes(16);
                        using (var ms = new MemoryStream())
                        {
                            using (var
                                cs = new CryptoStream
                                (ms,
                                    encryptor.CreateEncryptor
                                        (),
                                    CryptoStreamMode.Write))
                            {
                                cs.Write
                                (clearBytes, 0,
                                    clearBytes.Length);
                                cs.Close();
                            }

                            encry = Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }

            return encry;
        }
    }
}