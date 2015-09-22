using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class LensFlareWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateLensFlare),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("flare", get_flare, set_flare),
			new LuaField("brightness", get_brightness, set_brightness),
			new LuaField("fadeSpeed", get_fadeSpeed, set_fadeSpeed),
			new LuaField("color", get_color, set_color),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.LensFlare", typeof(LensFlare), regs, fields, typeof(Behaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLensFlare(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LensFlare obj = new LensFlare();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LensFlare.New");
		}

		return 0;
	}

	static Type classType = typeof(LensFlare);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flare(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LensFlare obj = (LensFlare)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name flare");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index flare on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.flare);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_brightness(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LensFlare obj = (LensFlare)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name brightness");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index brightness on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.brightness);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fadeSpeed(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LensFlare obj = (LensFlare)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fadeSpeed");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fadeSpeed on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fadeSpeed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_color(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LensFlare obj = (LensFlare)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name color");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index color on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.color);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_flare(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LensFlare obj = (LensFlare)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name flare");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index flare on a nil value");
			}
		}

		obj.flare = (Flare)LuaScriptMgr.GetUnityObject(L, 3, typeof(Flare));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_brightness(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LensFlare obj = (LensFlare)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name brightness");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index brightness on a nil value");
			}
		}

		obj.brightness = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fadeSpeed(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LensFlare obj = (LensFlare)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fadeSpeed");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fadeSpeed on a nil value");
			}
		}

		obj.fadeSpeed = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_color(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LensFlare obj = (LensFlare)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name color");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index color on a nil value");
			}
		}

		obj.color = LuaScriptMgr.GetColor(L, 3);
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

