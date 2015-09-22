using System;
using UnityEngine;
using LuaInterface;

public class CompassWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateCompass),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("magneticHeading", get_magneticHeading, null),
			new LuaField("trueHeading", get_trueHeading, null),
			new LuaField("headingAccuracy", get_headingAccuracy, null),
			new LuaField("rawVector", get_rawVector, null),
			new LuaField("timestamp", get_timestamp, null),
			new LuaField("enabled", get_enabled, set_enabled),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Compass", typeof(Compass), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCompass(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Compass obj = new Compass();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Compass.New");
		}

		return 0;
	}

	static Type classType = typeof(Compass);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_magneticHeading(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Compass obj = (Compass)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name magneticHeading");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index magneticHeading on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.magneticHeading);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_trueHeading(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Compass obj = (Compass)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name trueHeading");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index trueHeading on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.trueHeading);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_headingAccuracy(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Compass obj = (Compass)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name headingAccuracy");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index headingAccuracy on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.headingAccuracy);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rawVector(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Compass obj = (Compass)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rawVector");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rawVector on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.rawVector);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timestamp(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Compass obj = (Compass)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name timestamp");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index timestamp on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.timestamp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enabled(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Compass obj = (Compass)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name enabled");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index enabled on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.enabled);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_enabled(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Compass obj = (Compass)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name enabled");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index enabled on a nil value");
			}
		}

		obj.enabled = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}
}

