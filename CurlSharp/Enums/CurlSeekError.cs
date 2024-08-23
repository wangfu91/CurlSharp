using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlSharp.Enums
{
    /// <summary>
    /// These are the return codes for the seek callback.
    /// </summary>
    public enum CurlSeekError
    {
        Ok = 0,

        /// <summary>
        /// Fail the entire transfer
        /// </summary>
        Fail = 1,

        /// <summary>
        /// Tell libcurl seeking cannot be done, so libcurl might try other means instead
        /// </summary>
        CantSeek = 2,
    }
}
