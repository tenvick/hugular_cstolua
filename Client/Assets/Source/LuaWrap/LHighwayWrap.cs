using System;
using LuaInterface;

public class LHighwayWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("LoadLuaTable", LoadLuaTable),
			new LuaMethod("New", _CreateLHighway),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("onAllCompleteFn", get_onAllCompleteFn, set_onAllCompleteFn),
			new LuaField("onProgressFn", get_onProgressFn, set_onProgressFn),
			new LuaField("onSharedCompleteFn", get_onSharedCompleteFn, set_onSharedCompleteFn),
			new LuaField("onCacheFn", get_onCacheFn, set_onCacheFn),
			new LuaField("cache", get_cache, set_cache),
			new LuaField("instance", get_instance, null),
		};

		LuaScriptMgr.RegisterLib(L, "LHighway", typeof(LHighway), regs, fields, typeof(CHighway));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLHighway(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LHighway obj = new LHighway();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LHighway.New");
		}

		return 0;
	}

	static Type classType = typeof(LHighway);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onAllCompleteFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onAllCompleteFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onAllCompleteFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onAllCompleteFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onProgressFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onProgressFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onProgressFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onProgressFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSharedCompleteFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onSharedCompleteFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onSharedCompleteFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onSharedCompleteFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onCacheFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onCacheFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onCacheFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onCacheFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cache(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cache");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cache on a nil value");
			}
		}

		LuaScriptMgr.PushVarObject(L, obj.cache);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, LHighway.instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onAllCompleteFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onAllCompleteFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onAllCompleteFn on a nil value");
			}
		}

		obj.onAllCompleteFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onProgressFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onProgressFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onProgressFn on a nil value");
			}
		}

		obj.onProgressFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSharedCompleteFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onSharedCompleteFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onSharedCompleteFn on a nil value");
			}
		}

		obj.onSharedCompleteFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onCacheFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onCacheFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onCacheFn on a nil value");
			}
		}

		obj.onCacheFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cache(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LHighway obj = (LHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cache");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cache on a nil value");
			}
		}

		obj.cache = LuaScriptMgr.GetVarObject(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadLuaTable(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		LHighway obj = (LHighway)LuaScriptMgr.GetNetObjectSelf(L, 1, "LHighway");
		LuaTable arg0 = LuaScriptMgr.GetLuaTable(L, 2);
		obj.LoadLuaTable(arg0);
		return 0;
	}
}

