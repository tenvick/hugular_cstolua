using System;
using UnityEngine;
using LuaInterface;

public class ForceMode2DWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Force", GetForce),
		new LuaMethod("Impulse", GetImpulse),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ForceMode2D", typeof(UnityEngine.ForceMode2D), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetForce(IntPtr L)
	{
		LuaScriptMgr.Push(L, ForceMode2D.Force);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetImpulse(IntPtr L)
	{
		LuaScriptMgr.Push(L, ForceMode2D.Impulse);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ForceMode2D o = (ForceMode2D)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

