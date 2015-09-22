using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class PolygonCollider2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetPath", GetPath),
			new LuaMethod("SetPath", SetPath),
			new LuaMethod("GetTotalPointCount", GetTotalPointCount),
			new LuaMethod("CreatePrimitive", CreatePrimitive),
			new LuaMethod("New", _CreatePolygonCollider2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("points", get_points, set_points),
			new LuaField("pathCount", get_pathCount, set_pathCount),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.PolygonCollider2D", typeof(PolygonCollider2D), regs, fields, typeof(Collider2D));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePolygonCollider2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			PolygonCollider2D obj = new PolygonCollider2D();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: PolygonCollider2D.New");
		}

		return 0;
	}

	static Type classType = typeof(PolygonCollider2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_points(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PolygonCollider2D obj = (PolygonCollider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name points");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index points on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.points);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pathCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PolygonCollider2D obj = (PolygonCollider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pathCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pathCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.pathCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_points(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PolygonCollider2D obj = (PolygonCollider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name points");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index points on a nil value");
			}
		}

		obj.points = LuaScriptMgr.GetArrayObject<Vector2>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pathCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PolygonCollider2D obj = (PolygonCollider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pathCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pathCount on a nil value");
			}
		}

		obj.pathCount = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		PolygonCollider2D obj = (PolygonCollider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PolygonCollider2D");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		Vector2[] o = obj.GetPath(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		PolygonCollider2D obj = (PolygonCollider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PolygonCollider2D");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		Vector2[] objs1 = LuaScriptMgr.GetArrayObject<Vector2>(L, 3);
		obj.SetPath(arg0,objs1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTotalPointCount(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		PolygonCollider2D obj = (PolygonCollider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PolygonCollider2D");
		int o = obj.GetTotalPointCount();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreatePrimitive(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			PolygonCollider2D obj = (PolygonCollider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PolygonCollider2D");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			obj.CreatePrimitive(arg0);
			return 0;
		}
		else if (count == 3)
		{
			PolygonCollider2D obj = (PolygonCollider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PolygonCollider2D");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 3);
			obj.CreatePrimitive(arg0,arg1);
			return 0;
		}
		else if (count == 4)
		{
			PolygonCollider2D obj = (PolygonCollider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PolygonCollider2D");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 3);
			Vector2 arg2 = LuaScriptMgr.GetVector2(L, 4);
			obj.CreatePrimitive(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: PolygonCollider2D.CreatePrimitive");
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

