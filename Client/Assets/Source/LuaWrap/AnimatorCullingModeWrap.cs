using System;
using UnityEngine;
using LuaInterface;

public class AnimatorCullingModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("AlwaysAnimate", GetAlwaysAnimate),
		new LuaMethod("CullUpdateTransforms", GetCullUpdateTransforms),
		new LuaMethod("CullCompletely", GetCullCompletely),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimatorCullingMode", typeof(UnityEngine.AnimatorCullingMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAlwaysAnimate(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorCullingMode.AlwaysAnimate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCullUpdateTransforms(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorCullingMode.CullUpdateTransforms);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCullCompletely(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorCullingMode.CullCompletely);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AnimatorCullingMode o = (AnimatorCullingMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

