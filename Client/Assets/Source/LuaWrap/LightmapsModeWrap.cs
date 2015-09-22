using System;
using UnityEngine;
using LuaInterface;

public class LightmapsModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("NonDirectional", GetNonDirectional),
		new LuaMethod("CombinedDirectional", GetCombinedDirectional),
		new LuaMethod("SeparateDirectional", GetSeparateDirectional),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.LightmapsMode", typeof(UnityEngine.LightmapsMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNonDirectional(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightmapsMode.NonDirectional);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCombinedDirectional(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightmapsMode.CombinedDirectional);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSeparateDirectional(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightmapsMode.SeparateDirectional);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		LightmapsMode o = (LightmapsMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

