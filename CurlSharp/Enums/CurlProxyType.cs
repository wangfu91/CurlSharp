namespace CurlSharp
{
    /// <summary>
    /// This enumeration contains values used to specify the proxy type when
    /// using the <see cref="CurlOption.Proxy" /> option when calling
    /// <see cref="CurlEasy.SetOpt" />
    /// </summary>
    public enum CurlProxyType
    {
        /// <summary>
        /// Ordinary HTTP proxy.
        /// </summary>
        Http = 0,

        /// <summary>
        /// Added in 7.19.4, force to use CONNECT HTTP/1.0
        /// </summary>
        Http_1_0 = 1,

        /// <summary>
        /// HTTPS but stick to HTTP/1 added in 7.52.0
        /// </summary>
        Https = 2,

        /// <summary>
        /// HTTPS and attempt HTTP/2 added in 8.2.0
        /// </summary>
        Https2 = 3,

        /// <summary>
        /// Use if the proxy supports SOCKS4 user authentication. If you're
        /// unfamiliar with this, consult your network administrator.
        /// </summary>
        Socks4 = 4,

        /// <summary>
        /// Use if the proxy supports SOCKS5 user authentication. If you're
        /// unfamiliar with this, consult your network administrator.
        /// </summary>
        Socks5 = 5,

        /// <summary>
        /// added in 7.18.0
        /// </summary>
        Socks4a = 6,

        /// <summary>
        /// Use the SOCKS5 protocol but pass along the
        /// hostname rather than the IP address.
        /// added in 7.18.0
        /// </summary>
        Socket5Hostname = 7
    };
}