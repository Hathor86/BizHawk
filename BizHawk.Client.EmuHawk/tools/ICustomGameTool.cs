using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizHawk.Client.EmuHawk
{
    /// <summary>
    /// Interface to implements in order to make a custom tool for a specific game
    /// </summary>
    public interface ICustomGameTool : IToolForm
    {
        /// <summary>
        /// Load the custom tool
        /// </summary>
        /// <returns>True if load is successfull otherwise, false</returns>
        bool Load();
    }
}
