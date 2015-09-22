using System;
using UnityEngine;
using LuaInterface;

public class LocationServiceStatusWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Stopped", GetStopped),
		new LuaMethod("Initializing", GetInitializing),
		new LuaMethod("Running", GetRunning),
		new LuaMethod("Failed", GetFailed),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.LocationServiceStatus", typeof(UnityEngine.LocationServiceStatus), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStopped(IntPtr L)
	{
		LuaScriptMgr.Push(L, LocationServiceStatus.Stopped);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInitializing(IntPtr L)
	{
		LuaScriptMgr.Push(L, LocationServiceStatus.Initializing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRunning(IntPtr L)
	{
		LuaScriptMgr.Push(L, LocationServiceStatus.Running);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFailed(IntPtr L)
	{
		LuaScriptMgr.Push(L, LocationServiceStatus.Failed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		LocationServiceStatus o = (LocationServiceStatus)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

