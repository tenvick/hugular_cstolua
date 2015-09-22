using System;
using UnityEngine;
using LuaInterface;

public class AnimatorControllerParameterTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Float", GetFloat),
		new LuaMethod("Int", GetInt),
		new LuaMethod("Bool", GetBool),
		new LuaMethod("Trigger", GetTrigger),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimatorControllerParameterType", typeof(UnityEngine.AnimatorControllerParameterType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFloat(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorControllerParameterType.Float);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInt(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorControllerParameterType.Int);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBool(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorControllerParameterType.Bool);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTrigger(IntPtr L)
	{
		LuaScriptMgr.Push(L, AnimatorControllerParameterType.Trigger);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AnimatorControllerParameterType o = (AnimatorControllerParameterType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

