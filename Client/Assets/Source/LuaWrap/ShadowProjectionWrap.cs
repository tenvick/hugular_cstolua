using System;
using UnityEngine;
using LuaInterface;

public class ShadowProjectionWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("CloseFit", GetCloseFit),
		new LuaMethod("StableFit", GetStableFit),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ShadowProjection", typeof(UnityEngine.ShadowProjection), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCloseFit(IntPtr L)
	{
		LuaScriptMgr.Push(L, ShadowProjection.CloseFit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStableFit(IntPtr L)
	{
		LuaScriptMgr.Push(L, ShadowProjection.StableFit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ShadowProjection o = (ShadowProjection)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

