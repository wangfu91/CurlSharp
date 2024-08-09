namespace CurlSharp
{
    /// <summary>
    ///     Members of this enumeration should be passed to
    ///     <see cref="CurlShare.SetOpt" /> when it is called with the
    ///     <c>CurlShare</c> or <c>Unshare</c> options
    ///     provided in the <see cref="CurlShareOption" /> enumeration.
    /// </summary>
    public enum CurlLockData
    {
        /// <summary>
        ///     Not used.
        /// </summary>
        None = 0,

        /// <summary>
        ///     Used internally by libcurl.
        /// </summary>
        Share = 1,

        /// <summary>
        ///     Cookie data will be shared across the <see cref="CurlEasy" /> objects
        ///     using this shared object.
        /// </summary>
        Cookie = 2,

        /// <summary>
        ///     Cached Dns hosts will be shared across the <see cref="CurlEasy" />
        ///     objects using this shared object.
        /// </summary>
        Dns = 3,

        /// <summary>
        ///     Not supported yet.
        /// </summary>
        SslSession = 4,

        /// <summary>
        ///     Not supported yet.
        /// </summary>
        Connect = 5,

        /// <summary>
        /// The Public Suffix List stored in the share object is made available to all easy handle bound to the later. 
        /// Since the Public Suffix List is periodically refreshed, this avoids updates in too many different contexts.
        /// </summary>
        DataPsl = 6,

        /// <summary>
        /// The in-memory HSTS cache.
        /// It is not supported to share the HSTS between multiple concurrent threads.
        /// </summary>
        DataHsts = 7,
    };
}