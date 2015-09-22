using System;
using UnityEngine;
using LuaInterface;

public class SkinQualityWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Auto", GetAuto),
		new LuaMethod("Bone1", GetBone1),
		new LuaMethod("Bone2", GetBone2),
		new LuaMethod("Bone4", GetBone4),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.SkinQuality", typeof(UnityEngine.SkinQuality), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAuto(IntPtr L)
	{
		LuaScriptMgr.Push(L, SkinQuality.Auto);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBone1(IntPtr L)
	{
		LuaScriptMgr.Push(L, SkinQuality.Bone1);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBone2(IntPtr L)
	{
		LuaScriptMgr.Push(L, SkinQuality.Bone2);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBone4(IntPtr L)
	{
		LuaScriptMgr.Push(L, SkinQuality.Bone4);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		SkinQuality o = (SkinQuality)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

