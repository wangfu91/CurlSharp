// SSLGet.cs - demonstrate Ssl get capability
// usage: SSLGet url, e.g. SSLGet https://sourceforge.net

using System;
using System.Linq;
using System.Text;
using CurlSharp;

internal class SSLGet
{
    public static void Main(String[] args)
    {
        // SslGet(args);

        Http3Test();
    }

    private static void SslGet(string[] args)
    {
        try
        {
            Curl.GlobalInit(CurlInitFlag.All);

            using (var easy = new CurlEasy())
            {
                easy.SetOpt(CurlOption.Verbose, true);
                easy.SetOpt(CurlOption.SslVersion, CurlSslVersion.TlsV1_1);
                easy.DebugFunction = OnDebug;
                //easy.ProgressFunction = OnProgress;
                easy.WriteFunction = OnWriteData;
                easy.SslContextFunction = OnSslContext;
                easy.Url = args.Count() >= 1 ? args[0] : "https://tls12.browserleaks.com/";
                easy.CaInfo = "ca-bundle.crt";

                var result = easy.Perform();
                Console.WriteLine("Result curl code: {0}", result);
            }

            Curl.GlobalCleanup();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.ReadLine();
        }
    }

    private static void Http3Test()
    {
        try
        {
            Curl.GlobalInit(CurlInitFlag.All);

            using (var easy = new CurlEasy())
            {
                easy.SetOpt(CurlOption.Verbose, true);
                easy.SetOpt(CurlOption.SslVersion, CurlSslVersion.TlsV1_1);
                easy.SetOpt(CurlOption.HttpVersion, CurlHttpVersion.Http3_Only);
                easy.DebugFunction = OnDebug;
                easy.HeaderFunction = OnHeaders;
                //easy.ProgressFunction = OnProgress;
                easy.WriteFunction = OnWriteData;
                easy.SslContextFunction = OnSslContext;
                easy.Url = "https://http3.is/"; //"https://quic.nginx.org";
                easy.CaInfo = "ca-bundle.crt";

                var result = easy.Perform();
                Console.WriteLine("Result curl code: {0}", result);
            }

            Curl.GlobalCleanup();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.ReadLine();
        }
    }

    private static int OnHeaders(byte[] buf, int size, int nmemb, object extraData)
    {
        Console.WriteLine($"Header: {Encoding.UTF8.GetString(buf)}");
        return size * nmemb;
    }

    private static void OnDebug(CurlInfoType infoType, string message, int size, object extraData)
    {
        Console.WriteLine($"Debug: infoType= {infoType}, message={message}");
    }

    public static int OnProgress(object extraData, double dlTotal, double dlNow, double ulTotal, double ulNow)
    {
        Console.WriteLine($"Progress: {dlTotal} {dlNow} {ulTotal} {ulNow}");
        return 0; // standard return from PROGRESSFUNCTION
    }

    public static Int32 OnWriteData(Byte[] buf, Int32 size, Int32 nmemb, Object extraData)
    {
        Console.WriteLine(Encoding.UTF8.GetString(buf));
        return size*nmemb;
    }

    public static CurlCode OnSslContext(CurlSslContext ctx, Object extraData)
    {
        // To do anything useful with the CurlSslContext object, you'll need
        // to call the OpenSSL native methods on your own. So for this
        // demo, we just return what cURL is expecting.
        return CurlCode.Ok;
    }
}