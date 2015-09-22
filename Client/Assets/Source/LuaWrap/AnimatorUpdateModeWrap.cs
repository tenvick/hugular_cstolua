using System;
using UnityEngine;
using LuaInterface;

public class AnimatorUpdateModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Normal", GetNormal),
		new LuaMethod("AnimatePhysics", GetAnimatePhysics),
		new LuaMethod("UnscaledTime", GetUnscaledTime),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimatorUpdateMode", typeof(UnityEngine.AnimatorUpdateMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNormal(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorUpdateMode.Normal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAnimatePhysics(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorUpdateMode.AnimatePhysics);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUnscaledTime(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorUpdateMode.UnscaledTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AnimatorUpdateMode o = (AnimatorUpdateMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

