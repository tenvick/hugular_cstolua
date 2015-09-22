using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class SurfaceEffector2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateSurfaceEffector2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("speed", get_speed, set_speed),
			new LuaField("speedVariation", get_speedVariation, set_speedVariation),
			new LuaField("forceScale", get_forceScale, set_forceScale),
			new LuaField("useContactForce", get_useContactForce, set_useContactForce),
			new LuaField("useFriction", get_useFriction, set_useFriction),
			new LuaField("useBounce", get_useBounce, set_useBounce),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.SurfaceEffector2D", typeof(SurfaceEffector2D), regs, fields, typeof(Effector2D));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSurfaceEffector2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			SurfaceEffector2D obj = new SurfaceEffector2D();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: SurfaceEffector2D.New");
		}

		return 0;
	}

	static Type classType = typeof(SurfaceEffector2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_speed(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name speed");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index speed on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.speed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_speedVariation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name speedVariation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index speedVariation on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.speedVariation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forceScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceScale on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.forceScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useContactForce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useContactForce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useContactForce on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useContactForce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useFriction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useFriction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useFriction on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useFriction);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useBounce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useBounce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useBounce on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useBounce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_speed(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name speed");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index speed on a nil value");
			}
		}

		obj.speed = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_speedVariation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name speedVariation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index speedVariation on a nil value");
			}
		}

		obj.speedVariation = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forceScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceScale on a nil value");
			}
		}

		obj.forceScale = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useContactForce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useContactForce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useContactForce on a nil value");
			}
		}

		obj.useContactForce = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useFriction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useFriction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useFriction on a nil value");
			}
		}

		obj.useFriction = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useBounce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		SurfaceEffector2D obj = (SurfaceEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useBounce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useBounce on a nil value");
			}
		}

		obj.useBounce = LuaScriptMgr.GetBoolean(L, 3);
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

