using System;
using UnityEngine;
using LuaInterface;

public class WindZoneModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Directional", GetDirectional),
		new LuaMethod("Spherical", GetSpherical),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.WindZoneMode", typeof(UnityEngine.WindZoneMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDirectional(IntPtr L)
	{
		LuaScriptMgr.Push(L, WindZoneMode.Directional);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSpherical(IntPtr L)
	{
		LuaScriptMgr.Push(L, WindZoneMode.Spherical);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		WindZoneMode o = (WindZoneMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

