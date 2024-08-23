using CurlSharp;
using System;
using System.IO;
using System.Text;

namespace TestConsoleApp
{
    internal class Program
    {
        private static BinaryWriter _writer;

        static void Main(string[] args)
        {
            Curl.GlobalInit(CurlInitFlag.Default);

            try
            {
                DownloadFileTest();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Curl.GlobalCleanup();
            }
        }

        private static void DownloadFileTest()
        {
            _writer = new BinaryWriter(new FileStream(@"D:\100MB.bin", FileMode.Create));
            using(var easy = new CurlEasy())
            {
                easy.CaInfo = "ca-bundle.crt";
                easy.SetOpt(CurlOption.Url, "https://ash-speed.hetzner.com/100MB.bin");
                easy.WriteFunction = OnWriteData;

                var res = easy.Perform();

                if(res != CurlCode.Ok)
                {
                    Console.WriteLine("Error: {0}", easy.StrError(res));
                }
            }           
        }

        private static int OnWriteData(byte[] buf, int size, int nmemb, object extraData)
        {
            var nBytes = size * nmemb;
            _writer.Write(buf, 0, nBytes);
            return nBytes;
        }
    }
}
