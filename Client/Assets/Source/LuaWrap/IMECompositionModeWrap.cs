using System;
using UnityEngine;
using LuaInterface;

public class IMECompositionModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Auto", GetAuto),
		new LuaMethod("On", GetOn),
		new LuaMethod("Off", GetOff),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.IMECompositionMode", typeof(UnityEngine.IMECompositionMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAuto(IntPtr L)
	{
		LuaScriptMgr.Push(L, IMECompositionMode.Auto);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOn(IntPtr L)
	{
		LuaScriptMgr.Push(L, IMECompositionMode.On);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOff(IntPtr L)
	{
		LuaScriptMgr.Push(L, IMECompositionMode.Off);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		IMECompositionMode o = (IMECompositionMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

