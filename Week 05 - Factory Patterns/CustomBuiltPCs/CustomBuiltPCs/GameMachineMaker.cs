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
    /// Make a high end gaming computer
    /// </summary>
    public class GameMachineMaker : IMachineMaker
    {
        public virtual CPU makeCPU()
        {
            return new CPUHighEnd();
        }

        public virtual RAM makeRAM()
        {
            return new GameRAM();
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