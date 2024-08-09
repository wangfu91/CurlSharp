namespace CurlSharp
{
    /// <summary>
    ///     A member of this enumeration is passed to the function
    ///     <see cref="Curl.GetVersionInfo" />
    /// </summary>
    public enum CurlVersion
    {
        /// <summary>
        ///     Capabilities associated with the initial version of libcurl.
        ///     7.10
        /// </summary>
        First = 0,

        /// <summary>
        ///     Capabilities associated with the second version of libcurl.
        ///     7.11.1
        /// </summary>
        Second = 1,

        /// <summary>
        ///     Capabilities associated with the third version of libcurl.
        ///     7.12.0
        /// </summary>
        Third = 2,

        /// <summary>
        /// 7.1.6.1
        /// </summary>
        Fourth = 3,

        /// <summary>
        /// 7.57.0
        /// </summary>
        Fifth = 4,

        /// <summary>
        /// 7.66.0
        /// </summary>
        Sixth = 5,

        /// <summary>
        /// 7.70.0
        /// </summary>
        Seventh = 6,

        /// <summary>
        /// 7.72.0
        /// </summary>
        Eighth = 7,

        /// <summary>
        /// 7.75.0
        /// </summary>
        Ninth = 8,

        /// <summary>
        /// 7.77.0
        /// </summary>
        Tenth = 9,

        /// <summary>
        /// 7.87.0
        /// </summary>
        Eleventh = 10,

        /// <summary>
        /// 8.8.0
        /// </summary>
        Twelfth = 11,

        /// <summary>
        /// Same as <c>Twelfth</c>. 
        /// </summary>
        Now = Twelfth,
    };
}