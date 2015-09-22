using System;
using UnityEngine;
using LuaInterface;

public class AvatarIKGoalWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("LeftFoot", GetLeftFoot),
		new LuaMethod("RightFoot", GetRightFoot),
		new LuaMethod("LeftHand", GetLeftHand),
		new LuaMethod("RightHand", GetRightHand),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AvatarIKGoal", typeof(UnityEngine.AvatarIKGoal), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftFoot(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarIKGoal.LeftFoot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightFoot(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarIKGoal.RightFoot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftHand(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarIKGoal.LeftHand);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightHand(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarIKGoal.RightHand);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AvatarIKGoal o = (AvatarIKGoal)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

