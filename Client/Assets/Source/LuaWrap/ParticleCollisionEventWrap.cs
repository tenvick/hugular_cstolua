using System;
using UnityEngine;
using LuaInterface;

public class ParticleCollisionEventWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateParticleCollisionEvent),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("intersection", get_intersection, null),
			new LuaField("normal", get_normal, null),
			new LuaField("velocity", get_velocity, null),
			new LuaField("collider", get_collider, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ParticleCollisionEvent", typeof(ParticleCollisionEvent), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateParticleCollisionEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		ParticleCollisionEvent obj = new ParticleCollisionEvent();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(ParticleCollisionEvent);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_intersection(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name intersection");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index intersection on a nil value");
			}
		}

		ParticleCollisionEvent obj = (ParticleCollisionEvent)o;
		LuaScriptMgr.Push(L, obj.intersection);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_normal(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name normal");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index normal on a nil value");
			}
		}

		ParticleCollisionEvent obj = (ParticleCollisionEvent)o;
		LuaScriptMgr.Push(L, obj.normal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_velocity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name velocity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index velocity on a nil value");
			}
		}

		ParticleCollisionEvent obj = (ParticleCollisionEvent)o;
		LuaScriptMgr.Push(L, obj.velocity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_collider(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name collider");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index collider on a nil value");
			}
		}

		ParticleCollisionEvent obj = (ParticleCollisionEvent)o;
		LuaScriptMgr.Push(L, obj.collider);
		return 1;
	}
}

