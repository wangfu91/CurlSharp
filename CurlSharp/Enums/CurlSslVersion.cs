namespace CurlSharp
{
    /// <summary>
    ///     Contains values used to specify the Ssl version level when using
    ///     the <see cref="CurlOption.SslVersion" /> option in a call
    ///     to <see cref="CurlEasy.SetOpt" />
    /// </summary>
    public enum CurlSslVersion
    {
        /// <summary>
        ///     Use whatever version the Ssl library selects.
        /// </summary>
        Default = 0,

        /// <summary>
        ///     Use TLS version 1.
        /// </summary>
        Tlsv1 = 1,

        /// <summary>
        ///     Use Ssl version 2. This is not a good option unless it's the
        ///     only version supported by the remote server.
        /// </summary>
        Sslv2 = 2,

        /// <summary>
        ///     Use Ssl version 3. This is a preferred option.
        /// </summary>
        Sslv3 = 3,

        /// <summary>
        /// Use TLS version 1.0.
        /// </summary>
        TlsV1_0 = 4,

        /// <summary>
        /// Use TLS version 1.1.
        /// </summary>
        TlsV1_1 = 5,

        /// <summary>
        /// Use TLS version 1.2.
        /// </summary>
        TlsV1_2 = 6,

        /// <summary>
        /// Use TLS version 1.3.
        /// </summary>
        TlsV1_3 = 7,
    };
}