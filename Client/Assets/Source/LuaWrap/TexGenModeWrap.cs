using System;
using UnityEngine;
using LuaInterface;

public class TexGenModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("SphereMap", GetSphereMap),
		new LuaMethod("Object", GetObject),
		new LuaMethod("EyeLinear", GetEyeLinear),
		new LuaMethod("CubeReflect", GetCubeReflect),
		new LuaMethod("CubeNormal", GetCubeNormal),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.TexGenMode", typeof(UnityEngine.TexGenMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, TexGenMode.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSphereMap(IntPtr L)
	{
		LuaScriptMgr.Push(L, TexGenMode.SphereMap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetObject(IntPtr L)
	{
		LuaScriptMgr.Push(L, TexGenMode.Object);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEyeLinear(IntPtr L)
	{
		LuaScriptMgr.Push(L, TexGenMode.EyeLinear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCubeReflect(IntPtr L)
	{
		LuaScriptMgr.Push(L, TexGenMode.CubeReflect);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCubeNormal(IntPtr L)
	{
		LuaScriptMgr.Push(L, TexGenMode.CubeNormal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		TexGenMode o = (TexGenMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

