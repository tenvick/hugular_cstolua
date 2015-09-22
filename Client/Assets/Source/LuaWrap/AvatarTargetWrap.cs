using System;
using UnityEngine;
using LuaInterface;

public class AvatarTargetWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Root", GetRoot),
		new LuaMethod("Body", GetBody),
		new LuaMethod("LeftFoot", GetLeftFoot),
		new LuaMethod("RightFoot", GetRightFoot),
		new LuaMethod("LeftHand", GetLeftHand),
		new LuaMethod("RightHand", GetRightHand),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AvatarTarget", typeof(UnityEngine.AvatarTarget), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRoot(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarTarget.Root);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBody(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarTarget.Body);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftFoot(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarTarget.LeftFoot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightFoot(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarTarget.RightFoot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftHand(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarTarget.LeftHand);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightHand(IntPtr L)
	{
		LuaScriptMgr.Push(L, AvatarTarget.RightHand);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AvatarTarget o = (AvatarTarget)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

