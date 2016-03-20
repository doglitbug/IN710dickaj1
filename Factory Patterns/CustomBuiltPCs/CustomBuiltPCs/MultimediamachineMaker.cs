﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CustomBuiltPCs
{
    /// <summary>
    /// Make a multimedia computer
    /// </summary>
    public class MultimediaMachineMaker : IMachineMaker
    {
        public virtual CPU makeCPU()
        {
            return new CPUHighEnd();
        }

        public virtual RAM makeRAM()
        {
            return new MultimediaRAM();
        }

        public virtual GFX makeGFX()
        {
            return new GFXHighEnd();
        }

        public virtual Monitor makeMonitor()
        {
            return new WidescreenMonitor();
        }
    }
}

