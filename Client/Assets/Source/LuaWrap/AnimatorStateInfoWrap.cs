using System;
using UnityEngine;
using LuaInterface;

public class AnimatorStateInfoWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("IsName", IsName),
			new LuaMethod("IsTag", IsTag),
			new LuaMethod("New", _CreateAnimatorStateInfo),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("fullPathHash", get_fullPathHash, null),
			new LuaField("shortNameHash", get_shortNameHash, null),
			new LuaField("normalizedTime", get_normalizedTime, null),
			new LuaField("length", get_length, null),
			new LuaField("tagHash", get_tagHash, null),
			new LuaField("loop", get_loop, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimatorStateInfo", typeof(AnimatorStateInfo), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAnimatorStateInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		AnimatorStateInfo obj = new AnimatorStateInfo();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(AnimatorStateInfo);

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

		AnimatorStateInfo obj = (AnimatorStateInfo)o;
		LuaScriptMgr.Push(L, obj.fullPathHash);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shortNameHash(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shortNameHash");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shortNameHash on a nil value");
			}
		}

		AnimatorStateInfo obj = (AnimatorStateInfo)o;
		LuaScriptMgr.Push(L, obj.shortNameHash);
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

		AnimatorStateInfo obj = (AnimatorStateInfo)o;
		LuaScriptMgr.Push(L, obj.normalizedTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_length(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name length");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index length on a nil value");
			}
		}

		AnimatorStateInfo obj = (AnimatorStateInfo)o;
		LuaScriptMgr.Push(L, obj.length);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tagHash(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name tagHash");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index tagHash on a nil value");
			}
		}

		AnimatorStateInfo obj = (AnimatorStateInfo)o;
		LuaScriptMgr.Push(L, obj.tagHash);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loop(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name loop");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index loop on a nil value");
			}
		}

		AnimatorStateInfo obj = (AnimatorStateInfo)o;
		LuaScriptMgr.Push(L, obj.loop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AnimatorStateInfo obj = (AnimatorStateInfo)LuaScriptMgr.GetNetObjectSelf(L, 1, "AnimatorStateInfo");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		bool o = obj.IsName(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsTag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AnimatorStateInfo obj = (AnimatorStateInfo)LuaScriptMgr.GetNetObjectSelf(L, 1, "AnimatorStateInfo");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		bool o = obj.IsTag(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

