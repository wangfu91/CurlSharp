namespace CurlSharp
{
    /// <summary>
    ///     Contains return codes from many of the functions in the
    ///     <see cref="CurlShare" /> class.
    /// </summary>
    public enum CurlShareCode
    {
        /// <summary>
        ///     The function succeeded.
        /// </summary>
        Ok = 0,

        /// <summary>
        ///     A bad option was passed to <see cref="CurlShare.SetOpt" />.
        /// </summary>
        BadOption = 1,

        /// <summary>
        ///     An attempt was made to pass an option to
        ///     <see cref="CurlShare.SetOpt" /> while the CurlShare object is in use.
        /// </summary>
        InUse = 2,

        /// <summary>
        ///     The <see cref="CurlShare" /> object's internal handle is invalid.
        /// </summary>
        Invalid = 3,

        /// <summary>
        ///     Out of memory. This is a severe problem.
        /// </summary>
        NoMem = 4,

        /// <summary>
        /// The requested sharing could not be done because the library you use do not have that particular feature enabled. (Added in 7.23.0)
        /// </summary>
        NotBuiltIn = 5,
    };
}