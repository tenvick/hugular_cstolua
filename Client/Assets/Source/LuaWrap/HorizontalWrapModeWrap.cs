using System;
using UnityEngine;
using LuaInterface;

public class HorizontalWrapModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Wrap", GetWrap),
		new LuaMethod("Overflow", GetOverflow),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.HorizontalWrapMode", typeof(UnityEngine.HorizontalWrapMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWrap(IntPtr L)
	{
		LuaScriptMgr.Push(L, HorizontalWrapMode.Wrap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOverflow(IntPtr L)
	{
		LuaScriptMgr.Push(L, HorizontalWrapMode.Overflow);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		HorizontalWrapMode o = (HorizontalWrapMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

