using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class LightmapSettingsWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateLightmapSettings),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("lightmaps", get_lightmaps, set_lightmaps),
			new LuaField("lightmapsMode", get_lightmapsMode, set_lightmapsMode),
			new LuaField("lightProbes", get_lightProbes, set_lightProbes),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.LightmapSettings", typeof(LightmapSettings), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLightmapSettings(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LightmapSettings obj = new LightmapSettings();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LightmapSettings.New");
		}

		return 0;
	}

	static Type classType = typeof(LightmapSettings);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lightmaps(IntPtr L)
	{
		LuaScriptMgr.PushArray(L, LightmapSettings.lightmaps);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lightmapsMode(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightmapSettings.lightmapsMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lightProbes(IntPtr L)
	{
		LuaScriptMgr.Push(L, LightmapSettings.lightProbes);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lightmaps(IntPtr L)
	{
		LightmapSettings.lightmaps = LuaScriptMgr.GetArrayObject<LightmapData>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lightmapsMode(IntPtr L)
	{
		LightmapSettings.lightmapsMode = (LightmapsMode)LuaScriptMgr.GetNetObject(L, 3, typeof(LightmapsMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lightProbes(IntPtr L)
	{
		LightmapSettings.lightProbes = (LightProbes)LuaScriptMgr.GetUnityObject(L, 3, typeof(LightProbes));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

