using System;
using UnityEngine;
using LuaInterface;

public class AnimatorClipInfoWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateAnimatorClipInfo),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("clip", get_clip, null),
			new LuaField("weight", get_weight, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimatorClipInfo", typeof(AnimatorClipInfo), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAnimatorClipInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		AnimatorClipInfo obj = new AnimatorClipInfo();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(AnimatorClipInfo);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clip(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clip");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clip on a nil value");
			}
		}

		AnimatorClipInfo obj = (AnimatorClipInfo)o;
		LuaScriptMgr.Push(L, obj.clip);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_weight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name weight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index weight on a nil value");
			}
		}

		AnimatorClipInfo obj = (AnimatorClipInfo)o;
		LuaScriptMgr.Push(L, obj.weight);
		return 1;
	}
}

