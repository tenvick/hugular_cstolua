using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class Collider2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("OverlapPoint", OverlapPoint),
			new LuaMethod("IsTouching", IsTouching),
			new LuaMethod("IsTouchingLayers", IsTouchingLayers),
			new LuaMethod("New", _CreateCollider2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("isTrigger", get_isTrigger, set_isTrigger),
			new LuaField("usedByEffector", get_usedByEffector, set_usedByEffector),
			new LuaField("offset", get_offset, set_offset),
			new LuaField("attachedRigidbody", get_attachedRigidbody, null),
			new LuaField("shapeCount", get_shapeCount, null),
			new LuaField("bounds", get_bounds, null),
			new LuaField("sharedMaterial", get_sharedMaterial, set_sharedMaterial),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Collider2D", typeof(Collider2D), regs, fields, typeof(Behaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCollider2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Collider2D obj = new Collider2D();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Collider2D.New");
		}

		return 0;
	}

	static Type classType = typeof(Collider2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isTrigger(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isTrigger");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isTrigger on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isTrigger);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_usedByEffector(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name usedByEffector");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index usedByEffector on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.usedByEffector);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_offset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name offset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index offset on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.offset);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_attachedRigidbody(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name attachedRigidbody");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index attachedRigidbody on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.attachedRigidbody);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shapeCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shapeCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shapeCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shapeCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bounds(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bounds");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bounds on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bounds);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sharedMaterial(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sharedMaterial");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sharedMaterial on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sharedMaterial);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isTrigger(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isTrigger");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isTrigger on a nil value");
			}
		}

		obj.isTrigger = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_usedByEffector(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name usedByEffector");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index usedByEffector on a nil value");
			}
		}

		obj.usedByEffector = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_offset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name offset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index offset on a nil value");
			}
		}

		obj.offset = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sharedMaterial(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Collider2D obj = (Collider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sharedMaterial");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sharedMaterial on a nil value");
			}
		}

		obj.sharedMaterial = (PhysicsMaterial2D)LuaScriptMgr.GetUnityObject(L, 3, typeof(PhysicsMaterial2D));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OverlapPoint(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Collider2D obj = (Collider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Collider2D");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		bool o = obj.OverlapPoint(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsTouching(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Collider2D obj = (Collider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Collider2D");
		Collider2D arg0 = (Collider2D)LuaScriptMgr.GetUnityObject(L, 2, typeof(Collider2D));
		bool o = obj.IsTouching(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsTouchingLayers(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Collider2D obj = (Collider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Collider2D");
			bool o = obj.IsTouchingLayers();
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			Collider2D obj = (Collider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Collider2D");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			bool o = obj.IsTouchingLayers(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Collider2D.IsTouchingLayers");
		}

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

