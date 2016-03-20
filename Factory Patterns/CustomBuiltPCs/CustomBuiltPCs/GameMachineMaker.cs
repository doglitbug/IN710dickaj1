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

public class GameMachineMaker : IMachineMaker
{
	public virtual Component makeCPU()
	{
        return new CPUHighEnd();
	}

	public virtual Component makeRAM()
	{
        return new GameRAM();
	}

	public virtual Component makeGFX()
	{
        return new GFXHighEnd();
	}

}
