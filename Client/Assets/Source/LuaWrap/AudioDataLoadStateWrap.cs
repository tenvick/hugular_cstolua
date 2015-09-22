using System;
using UnityEngine;
using LuaInterface;

public class AudioDataLoadStateWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Unloaded", GetUnloaded),
		new LuaMethod("Loading", GetLoading),
		new LuaMethod("Loaded", GetLoaded),
		new LuaMethod("Failed", GetFailed),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AudioDataLoadState", typeof(UnityEngine.AudioDataLoadState), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUnloaded(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioDataLoadState.Unloaded);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLoading(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioDataLoadState.Loading);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLoaded(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioDataLoadState.Loaded);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFailed(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioDataLoadState.Failed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AudioDataLoadState o = (AudioDataLoadState)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

