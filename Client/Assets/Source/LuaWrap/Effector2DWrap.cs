using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class Effector2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateEffector2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("useColliderMask", get_useColliderMask, set_useColliderMask),
			new LuaField("colliderMask", get_colliderMask, set_colliderMask),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Effector2D", typeof(Effector2D), regs, fields, typeof(Behaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateEffector2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Effector2D obj = new Effector2D();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Effector2D.New");
		}

		return 0;
	}

	static Type classType = typeof(Effector2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useColliderMask(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Effector2D obj = (Effector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useColliderMask");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useColliderMask on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useColliderMask);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colliderMask(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Effector2D obj = (Effector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name colliderMask");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index colliderMask on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.colliderMask);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useColliderMask(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Effector2D obj = (Effector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useColliderMask");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useColliderMask on a nil value");
			}
		}

		obj.useColliderMask = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_colliderMask(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Effector2D obj = (Effector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name colliderMask");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index colliderMask on a nil value");
			}
		}

		obj.colliderMask = (int)LuaScriptMgr.GetNumber(L, 3);
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

