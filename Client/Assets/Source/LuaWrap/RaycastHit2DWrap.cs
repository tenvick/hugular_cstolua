using System;
using UnityEngine;
using LuaInterface;

public class RaycastHit2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("CompareTo", CompareTo),
			new LuaMethod("New", _CreateRaycastHit2D),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("centroid", get_centroid, set_centroid),
			new LuaField("point", get_point, set_point),
			new LuaField("normal", get_normal, set_normal),
			new LuaField("distance", get_distance, set_distance),
			new LuaField("fraction", get_fraction, set_fraction),
			new LuaField("collider", get_collider, null),
			new LuaField("rigidbody", get_rigidbody, null),
			new LuaField("transform", get_transform, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.RaycastHit2D", typeof(RaycastHit2D), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateRaycastHit2D(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		RaycastHit2D obj = new RaycastHit2D();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(RaycastHit2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_centroid(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name centroid");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index centroid on a nil value");
			}
		}

		RaycastHit2D obj = (RaycastHit2D)o;
		LuaScriptMgr.Push(L, obj.centroid);
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

		RaycastHit2D obj = (RaycastHit2D)o;
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

		RaycastHit2D obj = (RaycastHit2D)o;
		LuaScriptMgr.Push(L, obj.normal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_distance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name distance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index distance on a nil value");
			}
		}

		RaycastHit2D obj = (RaycastHit2D)o;
		LuaScriptMgr.Push(L, obj.distance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fraction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fraction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fraction on a nil value");
			}
		}

		RaycastHit2D obj = (RaycastHit2D)o;
		LuaScriptMgr.Push(L, obj.fraction);
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

		RaycastHit2D obj = (RaycastHit2D)o;
		LuaScriptMgr.Push(L, obj.collider);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rigidbody(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
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

		RaycastHit2D obj = (RaycastHit2D)o;
		LuaScriptMgr.Push(L, obj.rigidbody);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transform(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
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

		RaycastHit2D obj = (RaycastHit2D)o;
		LuaScriptMgr.Push(L, obj.transform);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_centroid(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name centroid");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index centroid on a nil value");
			}
		}

		RaycastHit2D obj = (RaycastHit2D)o;
		obj.centroid = LuaScriptMgr.GetVector2(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_point(IntPtr L)
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

		RaycastHit2D obj = (RaycastHit2D)o;
		obj.point = LuaScriptMgr.GetVector2(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_normal(IntPtr L)
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

		RaycastHit2D obj = (RaycastHit2D)o;
		obj.normal = LuaScriptMgr.GetVector2(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_distance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name distance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index distance on a nil value");
			}
		}

		RaycastHit2D obj = (RaycastHit2D)o;
		obj.distance = (float)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fraction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fraction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fraction on a nil value");
			}
		}

		RaycastHit2D obj = (RaycastHit2D)o;
		obj.fraction = (float)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareTo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		RaycastHit2D obj = (RaycastHit2D)LuaScriptMgr.GetNetObjectSelf(L, 1, "RaycastHit2D");
		RaycastHit2D arg0 = (RaycastHit2D)LuaScriptMgr.GetNetObject(L, 2, typeof(RaycastHit2D));
		int o = obj.CompareTo(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

