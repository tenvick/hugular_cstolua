using System;
using UnityEngine;
using LuaInterface;

public class ControllerColliderHitWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateControllerColliderHit),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("controller", get_controller, null),
			new LuaField("collider", get_collider, null),
			new LuaField("rigidbody", get_rigidbody, null),
			new LuaField("gameObject", get_gameObject, null),
			new LuaField("transform", get_transform, null),
			new LuaField("point", get_point, null),
			new LuaField("normal", get_normal, null),
			new LuaField("moveDirection", get_moveDirection, null),
			new LuaField("moveLength", get_moveLength, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ControllerColliderHit", typeof(ControllerColliderHit), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateControllerColliderHit(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			ControllerColliderHit obj = new ControllerColliderHit();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ControllerColliderHit.New");
		}

		return 0;
	}

	static Type classType = typeof(ControllerColliderHit);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_controller(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ControllerColliderHit obj = (ControllerColliderHit)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name controller");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index controller on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.controller);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_collider(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ControllerColliderHit obj = (ControllerColliderHit)o;

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
	static int get_rigidbody(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ControllerColliderHit obj = (ControllerColliderHit)o;

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
	static int get_gameObject(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ControllerColliderHit obj = (ControllerColliderHit)o;

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
	static int get_transform(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ControllerColliderHit obj = (ControllerColliderHit)o;

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
	static int get_point(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ControllerColliderHit obj = (ControllerColliderHit)o;

		if (obj == null)
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

		LuaScriptMgr.Push(L, obj.point);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_normal(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ControllerColliderHit obj = (ControllerColliderHit)o;

		if (obj == null)
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

		LuaScriptMgr.Push(L, obj.normal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_moveDirection(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ControllerColliderHit obj = (ControllerColliderHit)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name moveDirection");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index moveDirection on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.moveDirection);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_moveLength(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ControllerColliderHit obj = (ControllerColliderHit)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name moveLength");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index moveLength on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.moveLength);
		return 1;
	}
}

