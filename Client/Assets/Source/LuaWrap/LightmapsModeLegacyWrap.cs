using System;
using UnityEngine;
using LuaInterface;

public class LightmapsModeLegacyWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Single", GetSingle),
		new LuaMethod("Dual", GetDual),
		new LuaMethod("Directional", GetDirectional),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.LightmapsModeLegacy", typeof(UnityEngine.LightmapsModeLegacy), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSingle(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightmapsModeLegacy.Single);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDual(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightmapsModeLegacy.Dual);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDirectional(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightmapsModeLegacy.Directional);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		LightmapsModeLegacy o = (LightmapsModeLegacy)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

