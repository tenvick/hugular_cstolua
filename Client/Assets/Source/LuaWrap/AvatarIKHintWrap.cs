using System;
using UnityEngine;
using LuaInterface;

public class AvatarIKHintWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("LeftKnee", GetLeftKnee),
		new LuaMethod("RightKnee", GetRightKnee),
		new LuaMethod("LeftElbow", GetLeftElbow),
		new LuaMethod("RightElbow", GetRightElbow),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AvatarIKHint", typeof(UnityEngine.AvatarIKHint), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftKnee(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarIKHint.LeftKnee);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightKnee(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarIKHint.RightKnee);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftElbow(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarIKHint.LeftElbow);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightElbow(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarIKHint.RightElbow);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AvatarIKHint o = (AvatarIKHint)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

