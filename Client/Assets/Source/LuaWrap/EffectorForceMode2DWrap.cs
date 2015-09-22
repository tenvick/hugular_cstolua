using System;
using UnityEngine;
using LuaInterface;

public class EffectorForceMode2DWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Constant", GetConstant),
		new LuaMethod("InverseLinear", GetInverseLinear),
		new LuaMethod("InverseSquared", GetInverseSquared),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.EffectorForceMode2D", typeof(UnityEngine.EffectorForceMode2D), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetConstant(IntPtr L)
	{
		LuaScriptMgr.Push(L, EffectorForceMode2D.Constant);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInverseLinear(IntPtr L)
	{
		LuaScriptMgr.Push(L, EffectorForceMode2D.InverseLinear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInverseSquared(IntPtr L)
	{
		LuaScriptMgr.Push(L, EffectorForceMode2D.InverseSquared);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		EffectorForceMode2D o = (EffectorForceMode2D)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

