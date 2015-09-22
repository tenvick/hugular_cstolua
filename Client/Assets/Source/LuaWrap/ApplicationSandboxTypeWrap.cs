using System;
using UnityEngine;
using LuaInterface;

public class ApplicationSandboxTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Unknown", GetUnknown),
		new LuaMethod("NotSandboxed", GetNotSandboxed),
		new LuaMethod("Sandboxed", GetSandboxed),
		new LuaMethod("SandboxBroken", GetSandboxBroken),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ApplicationSandboxType", typeof(UnityEngine.ApplicationSandboxType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUnknown(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationSandboxType.Unknown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNotSandboxed(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationSandboxType.NotSandboxed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSandboxed(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationSandboxType.Sandboxed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSandboxBroken(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationSandboxType.SandboxBroken);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ApplicationSandboxType o = (ApplicationSandboxType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

