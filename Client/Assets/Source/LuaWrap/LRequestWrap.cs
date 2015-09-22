using System;
using LuaInterface;

public class LRequestWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateLRequest),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("onCompleteFn", get_onCompleteFn, set_onCompleteFn),
			new LuaField("onEndFn", get_onEndFn, set_onEndFn),
		};

		LuaScriptMgr.RegisterLib(L, "LRequest", typeof(LRequest), regs, fields, typeof(CRequest));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLRequest(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			LRequest obj = new LRequest(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 3)
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			string arg2 = LuaScriptMgr.GetString(L, 3);
			LRequest obj = new LRequest(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LRequest.New");
		}

		return 0;
	}

	static Type classType = typeof(LRequest);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onCompleteFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LRequest obj = (LRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onCompleteFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onCompleteFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onCompleteFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEndFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LRequest obj = (LRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onEndFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onEndFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onEndFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onCompleteFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LRequest obj = (LRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onCompleteFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onCompleteFn on a nil value");
			}
		}

		obj.onCompleteFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEndFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LRequest obj = (LRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onEndFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onEndFn on a nil value");
			}
		}

		obj.onEndFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}
}

