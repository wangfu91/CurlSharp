using System;

namespace CurlSharp
{
    /// <summary>
    /// Status code returned from <see cref="CurlEasy" /> functions.
    /// https://curl.se/libcurl/c/libcurl-errors.html
    /// </summary>
    public enum CurlCode
    {
        /// <summary>
        /// All fine. Proceed as usual.
        /// </summary>
        Ok = 0,

        /// <summary>
        /// The URL you passed to libcurl used a protocol that this libcurl
        /// does not support. The support might be a compile-time option that
        /// wasn't used, it can be a misspelled protocol string or just a
        /// protocol libcurl has no code for.
        /// </summary>
        UnsupportedProtocol = 1,

        /// <summary>
        /// Early initialization code failed. This is likely to be an internal error or problem, 
        /// or a resource problem where something fundamental could not get done at init time.
        /// </summary>
        FailedInit = 2,

        /// <summary>
        /// The URL was not properly formatted.
        /// </summary>
        UrlMalformat = 3,

        /// <summary>
        /// A requested feature, protocol or option was not found built-in in this libcurl due to a build-time decision.
        /// This means that a feature or option was not enabled or explicitly disabled when libcurl was built 
        /// and in order to get it to function you have to get a rebuilt libcurl.
        /// </summary>
        NotBuiltIn = 4,

        /// <summary>
        /// Couldn't resolve proxy. The given proxy host could not be resolved.
        /// </summary>
        CouldntResolveProxy = 5,

        /// <summary>
        /// Couldn't resolve host. The given remote host was not resolved.
        /// </summary>
        CouldntResolveHost = 6,

        /// <summary>
        /// Failed to connect to host or proxy.
        /// </summary>
        CouldntConnect = 7,

        /// <summary>
        /// The server sent data libcurl could not parse. This error code was known as CURLE_FTP_WEIRD_SERVER_REPLY before 7.51.0.
        /// </summary>
        WeirdServerReply = 8,

        /// <summary>
        /// We were denied access to the resource given in the URL. For FTP, this occurs while trying to change to the remote directory.
        /// </summary>
        RemoteAccessDenied = 9,

        /// <summary>
        /// While waiting for the server to connect back when an active FTP session is used, an error code was sent over the control connection or similar.
        /// </summary>
        FtpAcceptFailed = 10,

        /// <summary>
        /// After having sent the FTP password to the server, libcurl expects
        /// a proper reply. This error code indicates that an unexpected code
        /// was returned.
        /// </summary>
        FtpWeirdPassReply = 11,

        /// <summary>
        /// During an active FTP session while waiting for the server to connect, 
        /// the CURLOPT_ACCEPTTIMEOUT_MS (or the internal default) timeout expired.
        /// </summary>
        FtpAcceptTimeout = 12,

        /// <summary>
        /// libcurl failed to get a sensible result back from the server as
        /// a response to either a PASV or a EPSV command. The server is flawed.
        /// </summary>
        FtpWeirdPasvReply = 13,

        /// <summary>
        /// FTP servers return a 227-line as a response to a PASV command.
        /// If libcurl fails to parse that line, this return code is
        /// passed back.
        /// </summary>
        FtpWeird227Format = 14,

        /// <summary>
        /// An internal failure to lookup the host used for the new connection.
        /// </summary>
        FtpCantGetHost = 15,

        /// <summary>
        /// A problem was detected in the HTTP2 framing layer. 
        /// This is somewhat generic and can be one out of several problems, see the error buffer for details.
        /// </summary>
        Http2 = 16,

        /// <summary>
        /// Received an error when trying to set the transfer mode to binary or ASCII.
        /// </summary>
        FtpCouldntSetType = 17,

        /// <summary>
        /// A file transfer was shorter or larger than expected. This
        /// happens when the server first reports an expected transfer size,
        /// and then delivers data that doesn't match the previously
        /// given size.
        /// </summary>
        PartialFile = 18,

        /// <summary>
        /// This was either a weird reply to a 'RETR' command or a zero byte
        /// transfer complete.
        /// </summary>
        FtpCouldntRetrFile = 19,

        /// <summary>
        ///     After a completed file transfer, the FTP server did not respond a
        ///     proper "transfer successful" code.
        /// </summary>
        [Obsolete]
        FtpWriteError = 20,

        /// <summary>
        /// When sending custom "QUOTE" commands to the remote server, 
        /// one of the commands returned an error code that was 400 or higher (for FTP)
        /// or otherwise indicated unsuccessful completion of the command.
        /// </summary>
        QuoteError = 21,

        /// <summary>
        /// This is returned if <see cref="CurlOption.FailOnError" />
        /// is set TRUE and the HTTP server returns an error code that
        /// is >= 400.
        /// </summary>
        HttpReturnedError = 22,

        /// <summary>
        ///     An error occurred when writing received data to a local file,
        ///     or an error was returned to libcurl from a write callback.
        /// </summary>
        WriteError = 23,

        /// <summary>
        ///     Malformat user. User name badly specified. *Not currently used*
        /// </summary>
        [Obsolete]
        MalformatUser = 24,

        /// <summary>
        /// Failed starting the upload. For FTP, the server typically denied the STOR command.
        /// The error buffer usually contains the server's explanation for this.
        /// </summary>
        UploadFailed = 25,

        /// <summary>
        ///     Aborted by callback. An internal callback returned "abort"
        ///     to libcurl.
        /// </summary>
        AbortedByCallback = 42,

        /// <summary>
        ///     Internal error. A function was called in a bad order.
        /// </summary>
        BadCallingOrder = 44,

        /// <summary>
        ///     Unrecognized transfer encoding.
        /// </summary>
        BadContentEncoding = 61,

        /// <summary>
        ///     Attempting FTP resume beyond file size.
        /// </summary>
        BadDownloadResume = 36,

        /// <summary>
        ///     Internal error. A function was called with a bad parameter.
        /// </summary>
        BadFunctionArgument = 43,

        /// <summary>
        ///     Bad password entered. An error was signaled when the password was
        ///     entered. This can also be the result of a "bad password" returned
        ///     from a specified password callback.
        /// </summary>
        BadPasswordEntered = 46,

        /// <summary>
        ///     Maximum file size exceeded.
        /// </summary>
        FilesizeExceeded = 63,

        /// <summary>
        ///     A file given with FILE:// couldn't be opened. Most likely
        ///     because the file path doesn't identify an existing file. Did
        ///     you check file permissions?
        /// </summary>
        FileCouldntReadFile = 37,

        /// <summary>
        ///     The FTP SIZE command returned error. SIZE is not a kosher FTP
        ///     command, it is an extension and not all servers support it. This
        ///     is not a surprising error.
        /// </summary>
        FtpCouldntGetSize = 32,

        /// <summary>
        ///     libcurl failed to set ASCII transfer type (TYPE A).
        /// </summary>
        FtpCouldntSetAscii = 29,

        /// <summary>
        ///     The FTP REST command returned error. This should never happen
        ///     if the server is sane.
        /// </summary>
        FtpCouldntUseRest = 31,

        /// <summary>
        ///     The FTP PORT command returned error. This mostly happen when
        ///     you haven't specified a good enough address for libcurl to use.
        ///     See <see cref="CurlOption.FtpPort" />.
        /// </summary>
        FtpPortFailed = 30,

        /// <summary>
        ///     Requested FTP Ssl level failed.
        /// </summary>
        FtpSslFailed = 64,

        /// <summary>
        ///     Function not found. A required LDAP function was not found.
        /// </summary>
        FunctionNotFound = 41,

        /// <summary>
        ///     Nothing was returned from the server, and under the circumstances,
        ///     getting nothing is considered an error.
        /// </summary>
        GotNothing = 52,

        /// <summary>
        ///     This is an odd error that mainly occurs due to internal confusion.
        /// </summary>
        HttpPostError = 34,

        /// <summary>
        ///     The HTTP server does not support or accept range requests.
        /// </summary>
        HttpRangeError = 33,


        /// <summary>
        ///     Interface error. A specified outgoing interface could not be
        ///     used. Set which interface to use for outgoing connections'
        ///     source IP address with <see cref="CurlOption.Interface" />.
        /// </summary>
        InterfaceFailed = 45,

        /// <summary>
        ///     LDAP cannot bind. LDAP bind operation failed.
        /// </summary>
        LdapCannotBind = 38,

        [Obsolete]
        /// <summary>
        ///     Invalid LDAP URL.
        /// </summary>
        LdapInvalidUrl = 62,

        /// <summary>
        ///     LDAP search failed.
        /// </summary>
        LdapSearchFailed = 39,

        /// <summary>
        ///     Library not found. The LDAP library was not found.
        /// </summary>
        LibraryNotFound = 40,

        /// <summary>
        ///     This is not an error. This used to be another error code in an
        ///     old libcurl version and is currently unused.
        /// </summary>
        Obsolete = 50,

        /// <summary>
        ///     Operation timeout. The specified time-out period was reached
        ///     according to the conditions.
        /// </summary>
        OperationTimeouted = 28,

        /// <summary>
        ///     Out of memory. A memory allocation request failed. This is serious
        ///     badness and things are severely messed up if this ever occurs.
        /// </summary>
        OutOfMemory = 27,

        /// <summary>
        ///     There was a problem reading a local file or an error returned by
        ///     the read callback.
        /// </summary>
        ReadError = 26,

        /// <summary>
        ///     Failure with receiving network data.
        /// </summary>
        RecvError = 56,

        /// <summary>
        ///     Failed sending network data.
        /// </summary>
        SendError = 55,

        /// <summary>
        ///     Sending the data requires a rewind that failed.
        /// </summary>
        SendFailRewind = 65,

        /// <summary>
        ///     CurlShare is in use.
        /// </summary>
        ShareInUse = 57,

        /// <summary>
        /// Peer's certificate or fingerprint was not verified fine.
        /// </summary>
        PeerFailedVerification = 60,

        /// <summary>
        ///     There's a problem with the local client certificate.
        /// </summary>
        SslCertProblem = 58,

        /// <summary>
        ///     Couldn't use specified cipher.
        /// </summary>
        SslCipher = 59,

        /// <summary>
        /// A problem occurred somewhere in the Ssl/TLS handshake. You really
        /// want to use the <see cref="CurlEasy.CurlDebugCallback" /> delegate and read
        /// the message there as it pinpoints the problem slightly more. It
        /// could be certificates (file formats, paths, permissions),
        /// passwords, and others.
        /// </summary>
        SslConnectError = 35,

        /// <summary>
        ///     Failed to initialize Ssl engine.
        /// </summary>
        SslEngineInitFailed = 66,

        /// <summary>
        ///     The specified crypto engine wasn't found.
        /// </summary>
        SslEngineNotFound = 53,

        /// <summary>
        ///     Failed setting the selected Ssl crypto engine as default!
        /// </summary>
        SslEngineSetFailed = 54,

        /// <summary>
        ///    The remote server's Ssl certificate was deemed not OK.
        /// </summary>
        [Obsolete]
        SslPeerCertificate = 51,

        /// <summary>
        ///     A telnet option string was improperly formatted.
        /// </summary>
        TelnetOptionSyntax = 49,

        /// <summary>
        ///     Too many redirects. When following redirects, libcurl hit the
        ///     maximum amount. Set your limit with
        ///     <see cref="CurlOption.MaxRedirs" />.
        /// </summary>
        TooManyRedirects = 47,

        /// <summary>
        ///     An option set with <see cref="CurlOption.TelnetOptions" />
        ///     was not recognized/known. Refer to the appropriate documentation.
        /// </summary>
        UnknownTelnetOption = 48,

        /// <summary>
        /// The remote server denied curl to login (Added in 7.13.1)
        /// </summary>
        LoginDenied = 67,


        /// <summary>
        /// File not found on TFTP server.
        /// </summary>
        TFtpNotFound = 68,

        /// <summary>
        /// Permission problem on TFTP server.
        /// </summary>
        TFtpPerm = 69,

        /// <summary>
        /// Out of disk space on the server.
        /// </summary>
        RemoteDiskFull = 70,

        /// <summary>
        /// Illegal TFTP operation.
        /// </summary>
        TFtpIllegal = 71,

        /// <summary>
        /// Unknown TFTP transfer ID.
        /// </summary>
        TFtpUnknownId = 72,

        /// <summary>
        /// File already exists and is not overwritten.
        /// </summary>
        RemoteFileExists = 73,

        /// <summary>
        /// This error should never be returned by a properly functioning TFTP server.
        /// </summary>
        TFtpNoSuchUser = 74,

        // Obsolete error (75-76)
        // Not used in modern versions.

        /// <summary>
        /// Problem with reading the SSL CA cert (path? access rights?)
        /// </summary>
        SslCaCertBadFile = 77,

        /// <summary>
        /// The resource referenced in the URL does not exist.
        /// </summary>
        RemoteFileNotFound = 78,

        /// <summary>
        /// An unspecified error occurred during the SSH session.
        /// </summary>
        Ssh = 79,

        /// <summary>
        /// Failed to shut down the SSL connection.
        /// </summary>
        SshShutdownFailed = 80,

        /// <summary>
        /// Socket is not ready for send/recv. Wait until it is ready and try again.
        /// This return code is only returned from curl_easy_recv and curl_easy_send (Added in 7.18.2)
        /// </summary>
        Again = 81,

        /// <summary>
        /// Failed to load CRL file (Added in 7.19.0)
        /// </summary>
        SslCrlBadFile = 82,

        /// <summary>
        /// Issuer check failed (Added in 7.19.0)
        /// </summary>
        SslIssuerError = 83,

        /// <summary>
        /// The FTP server does not understand the PRET command at all or does not support the given argument. 
        /// Be careful when using CURLOPT_CUSTOMREQUEST, a custom LIST command is sent with the PRET command 
        /// before PASV as well. (Added in 7.20.0)
        /// </summary>
        FtpPretFailed = 84,

        /// <summary>
        /// Mismatch of RTSP CSeq numbers.
        /// </summary>
        RtspCseqError = 85,

        /// <summary>
        /// Mismatch of RTSP Session Identifiers.
        /// </summary>
        RtslSessionError = 86,

        /// <summary>
        /// Unable to parse FTP file list (during FTP wildcard downloading).
        /// </summary>
        FtpBadFileList = 87,

        /// <summary>
        /// Chunk callback reported error.
        /// </summary>
        ChunkFailed = 88,

        /// <summary>
        /// (For internal use only, is never returned by libcurl) 
        /// No connection available, the session is queued. (added in 7.30.0)
        /// </summary>
        NoConnectionAvailable = 89,

        /// <summary>
        /// Failed to match the pinned key specified with CURLOPT_PINNEDPUBLICKEY.
        /// </summary>
        SslPinnedPubKeyNotMatch = 90,

        /// <summary>
        /// Status returned failure when asked with CURLOPT_SSL_VERIFYSTATUS.
        /// </summary>
        SslInvalidCertStatus = 91,

        /// <summary>
        /// Stream error in the HTTP/2 framing layer.
        /// </summary>
        Http2Stream = 92,

        /// <summary>
        /// An API function was called from inside a callback.
        /// </summary>
        RecursiveApiCall = 93,

        /// <summary>
        /// An authentication function returned an error.
        /// </summary>
        AuthError = 94,

        /// <summary>
        /// A problem was detected in the HTTP/3 layer.
        /// This is somewhat generic and can be one out of several problems, see the error buffer for details.
        /// </summary>
        Http3 = 95,

        /// <summary>
        /// QUIC connection error. This error may be caused by an SSL library error. QUIC is the protocol used for HTTP/3 transfers.
        /// </summary>
        QuicConnectError = 96,

        /// <summary>
        /// Proxy handshake error. CURLINFO_PROXY_ERROR provides extra details on the specific problem.
        /// </summary>
        Proxy = 97,

        /// <summary>
        /// SSL Client Certificate required.
        /// </summary>
        SslClientCert = 98,

        /// <summary>
        /// An internal call to poll() or select() returned error that is not recoverable.
        /// </summary>
        UnrecoverablePoll = 99,

        /// <summary>
        /// A value or data field grew larger than allowed.
        /// </summary>
        TooLarge = 100,

        /// <summary>
        /// ECH was attempted but failed.
        /// </summary>
        EchRequired = 101,

    };
}