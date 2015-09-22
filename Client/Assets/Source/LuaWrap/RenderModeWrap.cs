using System;
using UnityEngine;
using LuaInterface;

public class RenderModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("ScreenSpaceOverlay", GetScreenSpaceOverlay),
		new LuaMethod("ScreenSpaceCamera", GetScreenSpaceCamera),
		new LuaMethod("WorldSpace", GetWorldSpace),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.RenderMode", typeof(UnityEngine.RenderMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetScreenSpaceOverlay(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderMode.ScreenSpaceOverlay);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetScreenSpaceCamera(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderMode.ScreenSpaceCamera);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWorldSpace(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderMode.WorldSpace);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		RenderMode o = (RenderMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

