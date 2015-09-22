using System;
using UnityEngine;
using LuaInterface;

public class Ray2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetPoint", GetPoint),
			new LuaMethod("ToString", ToString),
			new LuaMethod("New", _CreateRay2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__tostring", Lua_ToString),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("origin", get_origin, set_origin),
			new LuaField("direction", get_direction, set_direction),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Ray2D", typeof(Ray2D), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateRay2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			Ray2D obj = new Ray2D(arg0,arg1);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 0)
		{
			Ray2D obj = new Ray2D();
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Ray2D.New");
		}

		return 0;
	}

	static Type classType = typeof(Ray2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_origin(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name origin");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index origin on a nil value");
			}
		}

		Ray2D obj = (Ray2D)o;
		LuaScriptMgr.Push(L, obj.origin);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_direction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name direction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index direction on a nil value");
			}
		}

		Ray2D obj = (Ray2D)o;
		LuaScriptMgr.Push(L, obj.direction);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_origin(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name origin");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index origin on a nil value");
			}
		}

		Ray2D obj = (Ray2D)o;
		obj.origin = LuaScriptMgr.GetVector2(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_direction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name direction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index direction on a nil value");
			}
		}

		Ray2D obj = (Ray2D)o;
		obj.direction = LuaScriptMgr.GetVector2(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = LuaScriptMgr.GetLuaObject(L, 1);

		if (obj != null)
		{
			LuaScriptMgr.Push(L, obj.ToString());
		}
		else
		{
			LuaScriptMgr.Push(L, "Table: UnityEngine.Ray2D");
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPoint(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Ray2D obj = (Ray2D)LuaScriptMgr.GetNetObjectSelf(L, 1, "Ray2D");
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		Vector2 o = obj.GetPoint(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Ray2D obj = (Ray2D)LuaScriptMgr.GetNetObjectSelf(L, 1, "Ray2D");
			string o = obj.ToString();
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			Ray2D obj = (Ray2D)LuaScriptMgr.GetNetObjectSelf(L, 1, "Ray2D");
			string arg0 = LuaScriptMgr.GetLuaString(L, 2);
			string o = obj.ToString(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Ray2D.ToString");
		}

		return 0;
	}
}

