using System;
using UnityEngine;
using LuaInterface;

public class Collision2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateCollision2D),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("enabled", get_enabled, null),
			new LuaField("rigidbody", get_rigidbody, null),
			new LuaField("collider", get_collider, null),
			new LuaField("transform", get_transform, null),
			new LuaField("gameObject", get_gameObject, null),
			new LuaField("contacts", get_contacts, null),
			new LuaField("relativeVelocity", get_relativeVelocity, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Collision2D", typeof(Collision2D), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCollision2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Collision2D obj = new Collision2D();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Collision2D.New");
		}

		return 0;
	}

	static Type classType = typeof(Collision2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enabled(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collision2D obj = (Collision2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name enabled");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index enabled on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.enabled);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rigidbody(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collision2D obj = (Collision2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rigidbody");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rigidbody on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.rigidbody);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_collider(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collision2D obj = (Collision2D)o;

		if (obj == null)
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

		LuaScriptMgr.Push(L, obj.collider);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transform(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collision2D obj = (Collision2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name transform");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index transform on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.transform);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameObject(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collision2D obj = (Collision2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name gameObject");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index gameObject on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.gameObject);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contacts(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collision2D obj = (Collision2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name contacts");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index contacts on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.contacts);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_relativeVelocity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collision2D obj = (Collision2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name relativeVelocity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index relativeVelocity on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.relativeVelocity);
		return 1;
	}
}

