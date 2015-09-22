using System;
using UnityEngine;
using LuaInterface;

public class AnimationPlayModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Stop", GetStop),
		new LuaMethod("Queue", GetQueue),
		new LuaMethod("Mix", GetMix),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimationPlayMode", typeof(UnityEngine.AnimationPlayMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStop(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimationPlayMode.Stop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetQueue(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimationPlayMode.Queue);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMix(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimationPlayMode.Mix);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AnimationPlayMode o = (AnimationPlayMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

