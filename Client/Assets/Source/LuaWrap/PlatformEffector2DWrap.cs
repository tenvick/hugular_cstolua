using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class PlatformEffector2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreatePlatformEffector2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("useOneWay", get_useOneWay, set_useOneWay),
			new LuaField("useSideFriction", get_useSideFriction, set_useSideFriction),
			new LuaField("useSideBounce", get_useSideBounce, set_useSideBounce),
			new LuaField("sideAngleVariance", get_sideAngleVariance, set_sideAngleVariance),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.PlatformEffector2D", typeof(PlatformEffector2D), regs, fields, typeof(Effector2D));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePlatformEffector2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			PlatformEffector2D obj = new PlatformEffector2D();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: PlatformEffector2D.New");
		}

		return 0;
	}

	static Type classType = typeof(PlatformEffector2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useOneWay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PlatformEffector2D obj = (PlatformEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useOneWay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useOneWay on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useOneWay);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useSideFriction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PlatformEffector2D obj = (PlatformEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useSideFriction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useSideFriction on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useSideFriction);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useSideBounce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PlatformEffector2D obj = (PlatformEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useSideBounce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useSideBounce on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useSideBounce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sideAngleVariance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PlatformEffector2D obj = (PlatformEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sideAngleVariance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sideAngleVariance on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sideAngleVariance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useOneWay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PlatformEffector2D obj = (PlatformEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useOneWay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useOneWay on a nil value");
			}
		}

		obj.useOneWay = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useSideFriction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PlatformEffector2D obj = (PlatformEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useSideFriction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useSideFriction on a nil value");
			}
		}

		obj.useSideFriction = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useSideBounce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PlatformEffector2D obj = (PlatformEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useSideBounce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useSideBounce on a nil value");
			}
		}

		obj.useSideBounce = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sideAngleVariance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PlatformEffector2D obj = (PlatformEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sideAngleVariance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sideAngleVariance on a nil value");
			}
		}

		obj.sideAngleVariance = (float)LuaScriptMgr.GetNumber(L, 3);
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

