using System;
using UnityEngine;
using LuaInterface;

public class ColorSpaceWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Uninitialized", GetUninitialized),
		new LuaMethod("Gamma", GetGamma),
		new LuaMethod("Linear", GetLinear),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ColorSpace", typeof(UnityEngine.ColorSpace), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUninitialized(IntPtr L)
	{
		LuaScriptMgr.Push(L, ColorSpace.Uninitialized);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGamma(IntPtr L)
	{
		LuaScriptMgr.Push(L, ColorSpace.Gamma);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLinear(IntPtr L)
	{
		LuaScriptMgr.Push(L, ColorSpace.Linear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ColorSpace o = (ColorSpace)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

