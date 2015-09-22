using System;
using System.Collections.Generic;
using LuaInterface;

public class CHighwayWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("LoadReq", LoadReq),
			new LuaMethod("InitProgressState", InitProgressState),
			new LuaMethod("SetReqDataFromData", SetReqDataFromData),
			new LuaMethod("GetInstance", GetInstance),
			new LuaMethod("New", _CreateCHighway),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("currentLoading", get_currentLoading, null),
			new LuaField("maxLoading", get_maxLoading, null),
			new LuaField("totalLoading", get_totalLoading, set_totalLoading),
			new LuaField("currentLoaded", get_currentLoaded, null),
			new LuaField("cache", get_cache, set_cache),
		};

		LuaScriptMgr.RegisterLib(L, "CHighway", typeof(CHighway), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCHighway(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			CHighway obj = new CHighway();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: CHighway.New");
		}

		return 0;
	}

	static Type classType = typeof(CHighway);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentLoading(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CHighway obj = (CHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name currentLoading");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index currentLoading on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.currentLoading);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxLoading(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CHighway obj = (CHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxLoading");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxLoading on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.maxLoading);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_totalLoading(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CHighway obj = (CHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name totalLoading");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index totalLoading on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.totalLoading);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentLoaded(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CHighway obj = (CHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name currentLoaded");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index currentLoaded on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.currentLoaded);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cache(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CHighway obj = (CHighway)o;

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
	static int set_totalLoading(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CHighway obj = (CHighway)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name totalLoading");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index totalLoading on a nil value");
			}
		}

		obj.totalLoading = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cache(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CHighway obj = (CHighway)o;

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
	static int LoadReq(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(CHighway), typeof(CRequest)))
		{
			CHighway obj = (CHighway)LuaScriptMgr.GetNetObjectSelf(L, 1, "CHighway");
			CRequest arg0 = (CRequest)LuaScriptMgr.GetLuaObject(L, 2);
			obj.LoadReq(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(CHighway), typeof(IList<CRequest>)))
		{
			CHighway obj = (CHighway)LuaScriptMgr.GetNetObjectSelf(L, 1, "CHighway");
			IList<CRequest> arg0 = (IList<CRequest>)LuaScriptMgr.GetLuaObject(L, 2);
			obj.LoadReq(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: CHighway.LoadReq");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitProgressState(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		CHighway obj = (CHighway)LuaScriptMgr.GetNetObjectSelf(L, 1, "CHighway");
		obj.InitProgressState();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetReqDataFromData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CRequest arg0 = (CRequest)LuaScriptMgr.GetNetObject(L, 1, typeof(CRequest));
		object arg1 = LuaScriptMgr.GetVarObject(L, 2);
		CHighway.SetReqDataFromData(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstance(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		CHighway o = CHighway.GetInstance();
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}
}

