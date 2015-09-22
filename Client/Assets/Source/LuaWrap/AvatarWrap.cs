using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class AvatarWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateAvatar),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("isValid", get_isValid, null),
			new LuaField("isHuman", get_isHuman, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Avatar", typeof(Avatar), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAvatar(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Avatar obj = new Avatar();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Avatar.New");
		}

		return 0;
	}

	static Type classType = typeof(Avatar);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isValid(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Avatar obj = (Avatar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isValid");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isValid on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isValid);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isHuman(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Avatar obj = (Avatar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isHuman");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isHuman on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isHuman);
		return 1;
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

