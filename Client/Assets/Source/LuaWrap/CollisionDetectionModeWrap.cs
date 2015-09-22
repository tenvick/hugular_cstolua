using System;
using UnityEngine;
using LuaInterface;

public class CollisionDetectionModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Discrete", GetDiscrete),
		new LuaMethod("Continuous", GetContinuous),
		new LuaMethod("ContinuousDynamic", GetContinuousDynamic),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.CollisionDetectionMode", typeof(UnityEngine.CollisionDetectionMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDiscrete(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionDetectionMode.Discrete);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetContinuous(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionDetectionMode.Continuous);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetContinuousDynamic(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionDetectionMode.ContinuousDynamic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		CollisionDetectionMode o = (CollisionDetectionMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

