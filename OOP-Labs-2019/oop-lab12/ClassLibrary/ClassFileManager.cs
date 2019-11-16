using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;
using System.IO.Compression;

namespace ClassLibrary
{
    public class FileManager
    {
        public FileInfo[] Files { get; set; }

        public FileManager(FileInfo[] files)
        {
            Files = files;
        }

        public FileManager(string[] Path)
        {
            for (int i = 0; i < Path.Length; i++)
                Path[i] = Regex.Replace(Path[i], @"\r", @"");

            Files = new FileInfo[Path.Length];
            for (int i = 0; i < Path.Length; i++)
            {
                if (Path[i] != null)
                    Files[i] = new FileInfo(Path[i]);
            }
        }

        public void EncryptFile(string folderDestination = @"C:\Users\laptop\Desktop\Files\Зашифрованные файлы")
        {
            folderDestination = createFolder(folderDestination);

            try
            {
                foreach (var fileSource in Files)
                {
                    using (FileStream originalFile = fileSource.OpenRead())
                    {
                        string fileDestination = folderDestination + @"\" + fileSource.Name + ".crypto";
                        using (FileStream newFile = File.Create(fileDestination))
                        {
                            DESCryptoServiceProvider rmCrypto = new DESCryptoServiceProvider();
                            using (CryptoStream cryptStream = new CryptoStream(newFile, rmCrypto.CreateEncryptor(), CryptoStreamMode.Write))
                            {
                                originalFile.CopyTo(cryptStream);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DecryptFile(string folderDestination = @"C:\Users\laptop\Desktop\Files\Расшифрованные файлы")
        {
            folderDestination = createFolder(folderDestination);

            try
            {
                foreach (var fileSource in Files)
                {
                    if (Regex.IsMatch(fileSource.Name, @"^.+\.crypto$"))
                    {
                        using (FileStream cryptedFile = fileSource.OpenRead())
                        {
                            string fileDestination = folderDestination + @"\" + fileSource.Name;
                            fileDestination = Regex.Replace(fileDestination, @"(.+)\.crypto", "$1");

                            using (FileStream newFile = File.Create(fileDestination))
                            {
                                DESCryptoServiceProvider rmCrypto = new DESCryptoServiceProvider();
                                using (CryptoStream cryptStream = new CryptoStream(cryptedFile, rmCrypto.CreateDecryptor(), CryptoStreamMode.Read))
                                {
                                    byte[] data = new byte[1000];
                                    cryptStream.Read(data, 0, data.Length);
                                    Console.WriteLine(data);

                                    cryptStream.CopyTo(newFile);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private string createFolder(string folderDestination)
        {
            int i = 1;
            do
            {
                if (!Directory.Exists(folderDestination))
                    break;
                else if (i == 1)
                {
                    folderDestination += "(1)";
                    i++;
                }
                else
                {
                    folderDestination = Regex.Replace(folderDestination, @"^(.+)\(\d+\)$", $"$1({i++})");
                    Console.WriteLine(folderDestination);
                }

            } while (true);

            Directory.CreateDirectory(folderDestination);
            return folderDestination;
        }

        public void CompressFile(string folderDestination = @"C:\Users\laptop\Desktop\Files\Сжатые файлы")
        {
            folderDestination = createFolder(folderDestination);

            try
            {
                foreach (var fileSource in Files)
                {
                    using (FileStream originalFile = fileSource.OpenRead())
                    {
                        string fileDestination = folderDestination + @"\" + fileSource.Name + ".gzar";
                        using (FileStream newFile = File.Create(fileDestination))
                        {
                            using (GZipStream compressStream = new GZipStream(newFile, CompressionMode.Compress))
                            {
                                originalFile.CopyTo(compressStream);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DecompressFile(string folderDestination = @"C:\Users\laptop\Desktop\Files\Распакованные файлы")
        {
            folderDestination = createFolder(folderDestination);

            try
            {
                foreach (var fileSource in Files)
                {
                    if (Regex.IsMatch(fileSource.Name, @"^.+\.gzar$"))
                    {
                        using (FileStream compressedFile = fileSource.OpenRead())
                        {

                            string fileDestination = folderDestination + @"\" + fileSource.Name;
                            fileDestination = Regex.Replace(fileDestination, @"(.+)\.gzar", "$1");

                            using (FileStream newFile = File.Create(fileDestination))
                            {
                                using (GZipStream decompressionStream = new GZipStream(compressedFile, CompressionMode.Decompress))
                                {
                                    decompressionStream.CopyTo(newFile);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
