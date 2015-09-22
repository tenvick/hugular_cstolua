using System;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ActivateMonosWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateActivateMonos),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("monos", get_monos, set_monos),
			new LuaField("activateGameObj", get_activateGameObj, set_activateGameObj),
		};

		LuaScriptMgr.RegisterLib(L, "ActivateMonos", typeof(ActivateMonos), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateActivateMonos(IntPtr L)
	{
		LuaDLL.luaL_error(L, "ActivateMonos class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(ActivateMonos);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_monos(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ActivateMonos obj = (ActivateMonos)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name monos");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index monos on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.monos);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activateGameObj(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ActivateMonos obj = (ActivateMonos)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name activateGameObj");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index activateGameObj on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.activateGameObj);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_monos(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ActivateMonos obj = (ActivateMonos)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name monos");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index monos on a nil value");
			}
		}

		obj.monos = (List<MonoBehaviour>)LuaScriptMgr.GetNetObject(L, 3, typeof(List<MonoBehaviour>));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_activateGameObj(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ActivateMonos obj = (ActivateMonos)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name activateGameObj");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index activateGameObj on a nil value");
			}
		}

		obj.activateGameObj = (List<GameObject>)LuaScriptMgr.GetNetObject(L, 3, typeof(List<GameObject>));
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

