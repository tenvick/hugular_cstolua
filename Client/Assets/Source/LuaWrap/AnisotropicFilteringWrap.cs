using System;
using UnityEngine;
using LuaInterface;

public class AnisotropicFilteringWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Disable", GetDisable),
		new LuaMethod("Enable", GetEnable),
		new LuaMethod("ForceEnable", GetForceEnable),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnisotropicFiltering", typeof(UnityEngine.AnisotropicFiltering), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDisable(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnisotropicFiltering.Disable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnable(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnisotropicFiltering.Enable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetForceEnable(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnisotropicFiltering.ForceEnable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AnisotropicFiltering o = (AnisotropicFiltering)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

