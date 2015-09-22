using System;
using UnityEngine;
using LuaInterface;

public class CollisionFlagsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("Sides", GetSides),
		new LuaMethod("Above", GetAbove),
		new LuaMethod("Below", GetBelow),
		new LuaMethod("CollidedSides", GetCollidedSides),
		new LuaMethod("CollidedAbove", GetCollidedAbove),
		new LuaMethod("CollidedBelow", GetCollidedBelow),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.CollisionFlags", typeof(UnityEngine.CollisionFlags), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionFlags.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSides(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionFlags.Sides);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAbove(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionFlags.Above);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBelow(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionFlags.Below);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCollidedSides(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionFlags.CollidedSides);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCollidedAbove(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionFlags.CollidedAbove);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCollidedBelow(IntPtr L)
	{
		LuaScriptMgr.Push(L, CollisionFlags.CollidedBelow);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		CollisionFlags o = (CollisionFlags)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

