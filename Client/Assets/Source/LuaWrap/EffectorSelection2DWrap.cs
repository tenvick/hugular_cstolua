using System;
using UnityEngine;
using LuaInterface;

public class EffectorSelection2DWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Rigidbody", GetRigidbody),
		new LuaMethod("Collider", GetCollider),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.EffectorSelection2D", typeof(UnityEngine.EffectorSelection2D), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRigidbody(IntPtr L)
	{
		LuaScriptMgr.Push(L, EffectorSelection2D.Rigidbody);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCollider(IntPtr L)
	{
		LuaScriptMgr.Push(L, EffectorSelection2D.Collider);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		EffectorSelection2D o = (EffectorSelection2D)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

