using System;
using UnityEngine;
using LuaInterface;

public class LogTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Error", GetError),
		new LuaMethod("Assert", GetAssert),
		new LuaMethod("Warning", GetWarning),
		new LuaMethod("Log", GetLog),
		new LuaMethod("Exception", GetException),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.LogType", typeof(UnityEngine.LogType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetError(IntPtr L)
	{
		LuaScriptMgr.Push(L, LogType.Error);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAssert(IntPtr L)
	{
		LuaScriptMgr.Push(L, LogType.Assert);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWarning(IntPtr L)
	{
		LuaScriptMgr.Push(L, LogType.Warning);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLog(IntPtr L)
	{
		LuaScriptMgr.Push(L, LogType.Log);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetException(IntPtr L)
	{
		LuaScriptMgr.Push(L, LogType.Exception);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		LogType o = (LogType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

