using System;
using UnityEngine;
using LuaInterface;

public class AnimatorRecorderModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Offline", GetOffline),
		new LuaMethod("Playback", GetPlayback),
		new LuaMethod("Record", GetRecord),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimatorRecorderMode", typeof(UnityEngine.AnimatorRecorderMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOffline(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorRecorderMode.Offline);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPlayback(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorRecorderMode.Playback);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRecord(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorRecorderMode.Record);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AnimatorRecorderMode o = (AnimatorRecorderMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

