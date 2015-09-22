using System;
using UnityEngine;
using LuaInterface;

public class AnimationCullingTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("AlwaysAnimate", GetAlwaysAnimate),
		new LuaMethod("BasedOnRenderers", GetBasedOnRenderers),
		new LuaMethod("BasedOnClipBounds", GetBasedOnClipBounds),
		new LuaMethod("BasedOnUserBounds", GetBasedOnUserBounds),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimationCullingType", typeof(UnityEngine.AnimationCullingType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAlwaysAnimate(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimationCullingType.AlwaysAnimate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBasedOnRenderers(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimationCullingType.BasedOnRenderers);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBasedOnClipBounds(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimationCullingType.BasedOnClipBounds);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBasedOnUserBounds(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimationCullingType.BasedOnUserBounds);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AnimationCullingType o = (AnimationCullingType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

