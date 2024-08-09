namespace CurlSharp
{
    /// <summary>
    /// Contains return codes for many of the functions in the
    /// <see cref="CurlMulti" /> class.
    /// </summary>
    public enum CurlMultiCode
    {
        /// <summary>
        /// You should call <see cref="CurlMulti.Perform" /> again before calling
        /// <see cref="CurlMulti.Select" />.
        /// This is not really an error. 
        /// It means you should call curl_multi_perform again without doing select()
        /// or similar in between. Before version 7.20.0 (released on February 9 2010)
        /// this could be returned by curl_multi_perform, but in later versions 
        /// this return code is never used.
        /// </summary>
        CallMultiPerform = -1,

        /// <summary>
        /// The function succeded.
        /// </summary>
        Ok = 0,

        /// <summary>
        /// The internal <see cref="CurlMulti" /> is bad.
        /// </summary>
        BadHandle = 1,

        /// <summary>
        /// One of the <see cref="CurlEasy" /> handles associated with the
        /// <see cref="CurlMulti" /> object is bad.
        /// An easy handle was not good/valid. It could mean that it is not an easy handle at all,
        /// or possibly that the handle already is in use by this or another multi handle.
        /// </summary>
        BadEasyHandle = 2,

        /// <summary>
        /// Out of memory. This is a severe problem.
        /// </summary>
        OutOfMemory = 3,

        /// <summary>
        /// Internal error deep within the libcurl library.
        /// </summary>
        InternalError = 4,

        /// <summary>
        /// The passed-in socket is not a valid one that libcurl already knows about. (Added in 7.15.4)
        /// </summary>
        BadSocket = 5,

        /// <summary>
        /// curl_multi_setopt() with unsupported option (Added in 7.15.4)
        /// </summary>
        UnknownOption = 6,

        /// <summary>
        /// An easy handle already added to a multi handle was attempted to get added a second time. (Added in 7.32.1)
        /// </summary>
        AddedAlready = 7,

        /// <summary>
        /// An API function was called from inside a callback.
        /// </summary>
        RecursiveApiCall = 8,

        /// <summary>
        /// Wake up is unavailable or failed.
        /// </summary>
        WakeupFailure = 9,

        /// <summary>
        /// A function was called with a bad parameter.
        /// </summary>
        BadFunctionArgument = 10,

        /// <summary>
        /// A multi handle callback returned error.
        /// </summary>
        AbortedByCallback = 11,

        /// <summary>
        /// An internal call to poll() or select() returned error that is not recoverable.
        /// </summary>
        UnrecoverabePoll = 12,
    };
}