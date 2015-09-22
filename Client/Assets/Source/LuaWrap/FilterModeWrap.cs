using System;
using UnityEngine;
using LuaInterface;

public class FilterModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Point", GetPoint),
		new LuaMethod("Bilinear", GetBilinear),
		new LuaMethod("Trilinear", GetTrilinear),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.FilterMode", typeof(UnityEngine.FilterMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPoint(IntPtr L)
	{
		LuaScriptMgr.Push(L, FilterMode.Point);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBilinear(IntPtr L)
	{
		LuaScriptMgr.Push(L, FilterMode.Bilinear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTrilinear(IntPtr L)
	{
		LuaScriptMgr.Push(L, FilterMode.Trilinear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		FilterMode o = (FilterMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

