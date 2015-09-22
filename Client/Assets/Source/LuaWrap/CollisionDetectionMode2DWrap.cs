using System;
using UnityEngine;
using LuaInterface;

public class CollisionDetectionMode2DWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("Continuous", GetContinuous),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.CollisionDetectionMode2D", typeof(UnityEngine.CollisionDetectionMode2D), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionDetectionMode2D.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetContinuous(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionDetectionMode2D.Continuous);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		CollisionDetectionMode2D o = (CollisionDetectionMode2D)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

