using System;
using UnityEngine;
using LuaInterface;

public class PhysicMaterialCombineWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Average", GetAverage),
		new LuaMethod("Minimum", GetMinimum),
		new LuaMethod("Multiply", GetMultiply),
		new LuaMethod("Maximum", GetMaximum),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.PhysicMaterialCombine", typeof(UnityEngine.PhysicMaterialCombine), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAverage(IntPtr L)
	{
		LuaScriptMgr.Push(L, PhysicMaterialCombine.Average);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMinimum(IntPtr L)
	{
		LuaScriptMgr.Push(L, PhysicMaterialCombine.Minimum);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMultiply(IntPtr L)
	{
		LuaScriptMgr.Push(L, PhysicMaterialCombine.Multiply);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMaximum(IntPtr L)
	{
		LuaScriptMgr.Push(L, PhysicMaterialCombine.Maximum);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		PhysicMaterialCombine o = (PhysicMaterialCombine)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

