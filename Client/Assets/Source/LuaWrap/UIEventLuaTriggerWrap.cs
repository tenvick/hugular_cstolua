using System;
using UnityEngine;
using System.Collections.Generic;
using LuaInterface;
using Object = UnityEngine.Object;

public class UIEventLuaTriggerWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("OnLuaTrigger", OnLuaTrigger),
			new LuaMethod("New", _CreateUIEventLuaTrigger),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("luaFn", get_luaFn, set_luaFn),
			new LuaField("trigger", get_trigger, set_trigger),
			new LuaField("target", get_target, set_target),
		};

		LuaScriptMgr.RegisterLib(L, "UIEventLuaTrigger", typeof(UIEventLuaTrigger), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIEventLuaTrigger(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UIEventLuaTrigger class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UIEventLuaTrigger);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventLuaTrigger obj = (UIEventLuaTrigger)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name luaFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index luaFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.luaFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_trigger(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventLuaTrigger obj = (UIEventLuaTrigger)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name trigger");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index trigger on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.trigger);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_target(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventLuaTrigger obj = (UIEventLuaTrigger)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name target");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index target on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.target);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventLuaTrigger obj = (UIEventLuaTrigger)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name luaFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index luaFn on a nil value");
			}
		}

		obj.luaFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_trigger(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventLuaTrigger obj = (UIEventLuaTrigger)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name trigger");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index trigger on a nil value");
			}
		}

		obj.trigger = (MonoBehaviour)LuaScriptMgr.GetUnityObject(L, 3, typeof(MonoBehaviour));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_target(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventLuaTrigger obj = (UIEventLuaTrigger)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name target");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index target on a nil value");
			}
		}

		obj.target = (List<MonoBehaviour>)LuaScriptMgr.GetNetObject(L, 3, typeof(List<MonoBehaviour>));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnLuaTrigger(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIEventLuaTrigger obj = (UIEventLuaTrigger)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UIEventLuaTrigger");
		obj.OnLuaTrigger();
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

