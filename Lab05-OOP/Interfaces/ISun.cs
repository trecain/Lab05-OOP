using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Interfaces
{
    interface ISun
    {
        /// <summary>
        /// Interface for if animal bathes and sunbathes property
        /// </summary>
        bool SunBathes { get; set; }
        string Bathes();
    }
}
