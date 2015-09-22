using System;
using UnityEngine;
using LuaInterface;

public class LightmapDataWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateLightmapData),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("lightmapFar", get_lightmapFar, set_lightmapFar),
			new LuaField("lightmapNear", get_lightmapNear, set_lightmapNear),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.LightmapData", typeof(LightmapData), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLightmapData(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LightmapData obj = new LightmapData();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LightmapData.New");
		}

		return 0;
	}

	static Type classType = typeof(LightmapData);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lightmapFar(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LightmapData obj = (LightmapData)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lightmapFar");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lightmapFar on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.lightmapFar);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lightmapNear(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LightmapData obj = (LightmapData)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lightmapNear");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lightmapNear on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.lightmapNear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lightmapFar(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LightmapData obj = (LightmapData)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lightmapFar");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lightmapFar on a nil value");
			}
		}

		obj.lightmapFar = (Texture2D)LuaScriptMgr.GetUnityObject(L, 3, typeof(Texture2D));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lightmapNear(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LightmapData obj = (LightmapData)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lightmapNear");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lightmapNear on a nil value");
			}
		}

		obj.lightmapNear = (Texture2D)LuaScriptMgr.GetUnityObject(L, 3, typeof(Texture2D));
		return 0;
	}
}

