using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UGUILocalizeWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateUGUILocalize),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("key", get_key, set_key),
			new LuaField("value", null, set_value),
		};

		LuaScriptMgr.RegisterLib(L, "UGUILocalize", typeof(UGUILocalize), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUGUILocalize(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UGUILocalize class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UGUILocalize);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_key(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UGUILocalize obj = (UGUILocalize)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name key");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index key on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.key);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_key(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UGUILocalize obj = (UGUILocalize)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name key");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index key on a nil value");
			}
		}

		obj.key = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UGUILocalize obj = (UGUILocalize)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name value");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index value on a nil value");
			}
		}

		obj.value = LuaScriptMgr.GetString(L, 3);
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

