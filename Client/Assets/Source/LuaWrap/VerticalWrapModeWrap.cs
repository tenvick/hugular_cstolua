using System;
using UnityEngine;
using LuaInterface;

public class VerticalWrapModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Truncate", GetTruncate),
		new LuaMethod("Overflow", GetOverflow),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.VerticalWrapMode", typeof(UnityEngine.VerticalWrapMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTruncate(IntPtr L)
	{
		LuaScriptMgr.Push(L, VerticalWrapMode.Truncate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOverflow(IntPtr L)
	{
		LuaScriptMgr.Push(L, VerticalWrapMode.Overflow);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		VerticalWrapMode o = (VerticalWrapMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

