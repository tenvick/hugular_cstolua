using System;
using UnityEngine;
using LuaInterface;

public class RigidbodyInterpolationWrap
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
		LuaScriptMgr.RegisterLib(L, "UnityEngine.RigidbodyInterpolation", typeof(UnityEngine.RigidbodyInterpolation), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyInterpolation.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInterpolate(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyInterpolation.Interpolate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetExtrapolate(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyInterpolation.Extrapolate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		RigidbodyInterpolation o = (RigidbodyInterpolation)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

