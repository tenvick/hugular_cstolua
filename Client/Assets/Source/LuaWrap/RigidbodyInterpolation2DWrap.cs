using System;
using UnityEngine;
using LuaInterface;

public class RigidbodyInterpolation2DWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("Interpolate", GetInterpolate),
		new LuaMethod("Extrapolate", GetExtrapolate),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.RigidbodyInterpolation2D", typeof(UnityEngine.RigidbodyInterpolation2D), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyInterpolation2D.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInterpolate(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyInterpolation2D.Interpolate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetExtrapolate(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyInterpolation2D.Extrapolate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		RigidbodyInterpolation2D o = (RigidbodyInterpolation2D)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

