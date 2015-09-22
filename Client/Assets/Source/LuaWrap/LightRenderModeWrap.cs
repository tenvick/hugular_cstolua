using System;
using UnityEngine;
using LuaInterface;

public class LightRenderModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Auto", GetAuto),
		new LuaMethod("ForcePixel", GetForcePixel),
		new LuaMethod("ForceVertex", GetForceVertex),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.LightRenderMode", typeof(UnityEngine.LightRenderMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAuto(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightRenderMode.Auto);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetForcePixel(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightRenderMode.ForcePixel);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetForceVertex(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightRenderMode.ForceVertex);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		LightRenderMode o = (LightRenderMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

