using System;
using UnityEngine;
using LuaInterface;

public class ApplicationInstallModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Unknown", GetUnknown),
		new LuaMethod("Store", GetStore),
		new LuaMethod("DeveloperBuild", GetDeveloperBuild),
		new LuaMethod("Adhoc", GetAdhoc),
		new LuaMethod("Enterprise", GetEnterprise),
		new LuaMethod("Editor", GetEditor),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ApplicationInstallMode", typeof(UnityEngine.ApplicationInstallMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUnknown(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationInstallMode.Unknown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStore(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationInstallMode.Store);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDeveloperBuild(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationInstallMode.DeveloperBuild);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAdhoc(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationInstallMode.Adhoc);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnterprise(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationInstallMode.Enterprise);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEditor(IntPtr L)
	{
		LuaScriptMgr.Push(L, ApplicationInstallMode.Editor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ApplicationInstallMode o = (ApplicationInstallMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

