using System;
using UnityEngine;
using LuaInterface;

public class ContactPointWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateContactPoint),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("point", get_point, null),
			new LuaField("normal", get_normal, null),
			new LuaField("thisCollider", get_thisCollider, null),
			new LuaField("otherCollider", get_otherCollider, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ContactPoint", typeof(ContactPoint), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateContactPoint(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		ContactPoint obj = new ContactPoint();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(ContactPoint);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_point(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name point");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index point on a nil value");
			}
		}

		ContactPoint obj = (ContactPoint)o;
		LuaScriptMgr.Push(L, obj.point);
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

		ContactPoint obj = (ContactPoint)o;
		LuaScriptMgr.Push(L, obj.normal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_thisCollider(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name thisCollider");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index thisCollider on a nil value");
			}
		}

		ContactPoint obj = (ContactPoint)o;
		LuaScriptMgr.Push(L, obj.thisCollider);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_otherCollider(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name otherCollider");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index otherCollider on a nil value");
			}
		}

		ContactPoint obj = (ContactPoint)o;
		LuaScriptMgr.Push(L, obj.otherCollider);
		return 1;
	}
}

