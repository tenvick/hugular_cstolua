using System;
using UnityEngine;
using LuaInterface;

public class DeviceTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Unknown", GetUnknown),
		new LuaMethod("Handheld", GetHandheld),
		new LuaMethod("Console", GetConsole),
		new LuaMethod("Desktop", GetDesktop),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.DeviceType", typeof(UnityEngine.DeviceType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUnknown(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceType.Unknown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHandheld(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceType.Handheld);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetConsole(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceType.Console);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDesktop(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceType.Desktop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		DeviceType o = (DeviceType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

