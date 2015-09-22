using System;
using UnityEngine;
using LuaInterface;

public class LightShadowsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("Hard", GetHard),
		new LuaMethod("Soft", GetSoft),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.LightShadows", typeof(UnityEngine.LightShadows), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightShadows.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHard(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightShadows.Hard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSoft(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightShadows.Soft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		LightShadows o = (LightShadows)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

