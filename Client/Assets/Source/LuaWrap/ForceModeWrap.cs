using System;
using UnityEngine;
using LuaInterface;

public class ForceModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Force", GetForce),
		new LuaMethod("Acceleration", GetAcceleration),
		new LuaMethod("Impulse", GetImpulse),
		new LuaMethod("VelocityChange", GetVelocityChange),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ForceMode", typeof(UnityEngine.ForceMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetForce(IntPtr L)
	{
		LuaScriptMgr.Push(L, ForceMode.Force);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAcceleration(IntPtr L)
	{
		LuaScriptMgr.Push(L, ForceMode.Acceleration);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetImpulse(IntPtr L)
	{
		LuaScriptMgr.Push(L, ForceMode.Impulse);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVelocityChange(IntPtr L)
	{
		LuaScriptMgr.Push(L, ForceMode.VelocityChange);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ForceMode o = (ForceMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

