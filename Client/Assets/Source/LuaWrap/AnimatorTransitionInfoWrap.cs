using System;
using UnityEngine;
using LuaInterface;

public class AnimatorTransitionInfoWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("IsName", IsName),
			new LuaMethod("IsUserName", IsUserName),
			new LuaMethod("New", _CreateAnimatorTransitionInfo),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("fullPathHash", get_fullPathHash, null),
			new LuaField("nameHash", get_nameHash, null),
			new LuaField("userNameHash", get_userNameHash, null),
			new LuaField("normalizedTime", get_normalizedTime, null),
			new LuaField("anyState", get_anyState, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimatorTransitionInfo", typeof(AnimatorTransitionInfo), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAnimatorTransitionInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		AnimatorTransitionInfo obj = new AnimatorTransitionInfo();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(AnimatorTransitionInfo);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fullPathHash(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fullPathHash");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fullPathHash on a nil value");
			}
		}

		AnimatorTransitionInfo obj = (AnimatorTransitionInfo)o;
		LuaScriptMgr.Push(L, obj.fullPathHash);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nameHash(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name nameHash");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index nameHash on a nil value");
			}
		}

		AnimatorTransitionInfo obj = (AnimatorTransitionInfo)o;
		LuaScriptMgr.Push(L, obj.nameHash);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_userNameHash(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name userNameHash");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index userNameHash on a nil value");
			}
		}

		AnimatorTransitionInfo obj = (AnimatorTransitionInfo)o;
		LuaScriptMgr.Push(L, obj.userNameHash);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_normalizedTime(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name normalizedTime");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index normalizedTime on a nil value");
			}
		}

		AnimatorTransitionInfo obj = (AnimatorTransitionInfo)o;
		LuaScriptMgr.Push(L, obj.normalizedTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anyState(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name anyState");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index anyState on a nil value");
			}
		}

		AnimatorTransitionInfo obj = (AnimatorTransitionInfo)o;
		LuaScriptMgr.Push(L, obj.anyState);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AnimatorTransitionInfo obj = (AnimatorTransitionInfo)LuaScriptMgr.GetNetObjectSelf(L, 1, "AnimatorTransitionInfo");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		bool o = obj.IsName(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsUserName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AnimatorTransitionInfo obj = (AnimatorTransitionInfo)LuaScriptMgr.GetNetObjectSelf(L, 1, "AnimatorTransitionInfo");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		bool o = obj.IsUserName(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

