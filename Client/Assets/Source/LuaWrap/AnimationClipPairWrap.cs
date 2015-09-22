using System;
using UnityEngine;
using LuaInterface;

public class AnimationClipPairWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateAnimationClipPair),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("originalClip", get_originalClip, set_originalClip),
			new LuaField("overrideClip", get_overrideClip, set_overrideClip),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimationClipPair", typeof(AnimationClipPair), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAnimationClipPair(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			AnimationClipPair obj = new AnimationClipPair();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AnimationClipPair.New");
		}

		return 0;
	}

	static Type classType = typeof(AnimationClipPair);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_originalClip(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClipPair obj = (AnimationClipPair)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name originalClip");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index originalClip on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.originalClip);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_overrideClip(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClipPair obj = (AnimationClipPair)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name overrideClip");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index overrideClip on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.overrideClip);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_originalClip(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClipPair obj = (AnimationClipPair)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name originalClip");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index originalClip on a nil value");
			}
		}

		obj.originalClip = (AnimationClip)LuaScriptMgr.GetUnityObject(L, 3, typeof(AnimationClip));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_overrideClip(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClipPair obj = (AnimationClipPair)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name overrideClip");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index overrideClip on a nil value");
			}
		}

		obj.overrideClip = (AnimationClip)LuaScriptMgr.GetUnityObject(L, 3, typeof(AnimationClip));
		return 0;
	}
}

