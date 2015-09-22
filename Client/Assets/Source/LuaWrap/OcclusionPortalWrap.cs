using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class OcclusionPortalWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateOcclusionPortal),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("open", get_open, set_open),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.OcclusionPortal", typeof(OcclusionPortal), regs, fields, typeof(Component));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateOcclusionPortal(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			OcclusionPortal obj = new OcclusionPortal();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: OcclusionPortal.New");
		}

		return 0;
	}

	static Type classType = typeof(OcclusionPortal);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_open(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		OcclusionPortal obj = (OcclusionPortal)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name open");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index open on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.open);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_open(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		OcclusionPortal obj = (OcclusionPortal)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name open");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index open on a nil value");
			}
		}

		obj.open = LuaScriptMgr.GetBoolean(L, 3);
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

