using System;
using UnityEngine;
using LuaInterface;

public class TransparencySortModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Default", GetDefault),
		new LuaMethod("Perspective", GetPerspective),
		new LuaMethod("Orthographic", GetOrthographic),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.TransparencySortMode", typeof(UnityEngine.TransparencySortMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefault(IntPtr L)
	{
		LuaScriptMgr.Push(L, TransparencySortMode.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPerspective(IntPtr L)
	{
		LuaScriptMgr.Push(L, TransparencySortMode.Perspective);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOrthographic(IntPtr L)
	{
		LuaScriptMgr.Push(L, TransparencySortMode.Orthographic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		TransparencySortMode o = (TransparencySortMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

