using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class WindZoneWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateWindZone),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("mode", get_mode, set_mode),
			new LuaField("radius", get_radius, set_radius),
			new LuaField("windMain", get_windMain, set_windMain),
			new LuaField("windTurbulence", get_windTurbulence, set_windTurbulence),
			new LuaField("windPulseMagnitude", get_windPulseMagnitude, set_windPulseMagnitude),
			new LuaField("windPulseFrequency", get_windPulseFrequency, set_windPulseFrequency),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.WindZone", typeof(WindZone), regs, fields, typeof(Component));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateWindZone(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			WindZone obj = new WindZone();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: WindZone.New");
		}

		return 0;
	}

	static Type classType = typeof(WindZone);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.mode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_radius(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name radius");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index radius on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.radius);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_windMain(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name windMain");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index windMain on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.windMain);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_windTurbulence(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name windTurbulence");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index windTurbulence on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.windTurbulence);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_windPulseMagnitude(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name windPulseMagnitude");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index windPulseMagnitude on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.windPulseMagnitude);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_windPulseFrequency(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name windPulseFrequency");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index windPulseFrequency on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.windPulseFrequency);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mode on a nil value");
			}
		}

		obj.mode = (WindZoneMode)LuaScriptMgr.GetNetObject(L, 3, typeof(WindZoneMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_radius(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name radius");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index radius on a nil value");
			}
		}

		obj.radius = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_windMain(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name windMain");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index windMain on a nil value");
			}
		}

		obj.windMain = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_windTurbulence(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name windTurbulence");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index windTurbulence on a nil value");
			}
		}

		obj.windTurbulence = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_windPulseMagnitude(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name windPulseMagnitude");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index windPulseMagnitude on a nil value");
			}
		}

		obj.windPulseMagnitude = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_windPulseFrequency(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WindZone obj = (WindZone)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name windPulseFrequency");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index windPulseFrequency on a nil value");
			}
		}

		obj.windPulseFrequency = (float)LuaScriptMgr.GetNumber(L, 3);
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

