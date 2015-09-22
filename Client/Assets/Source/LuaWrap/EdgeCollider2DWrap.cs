using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class EdgeCollider2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Reset", Reset),
			new LuaMethod("New", _CreateEdgeCollider2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("edgeCount", get_edgeCount, null),
			new LuaField("pointCount", get_pointCount, null),
			new LuaField("points", get_points, set_points),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.EdgeCollider2D", typeof(EdgeCollider2D), regs, fields, typeof(Collider2D));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateEdgeCollider2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			EdgeCollider2D obj = new EdgeCollider2D();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: EdgeCollider2D.New");
		}

		return 0;
	}

	static Type classType = typeof(EdgeCollider2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_edgeCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		EdgeCollider2D obj = (EdgeCollider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name edgeCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index edgeCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.edgeCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pointCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		EdgeCollider2D obj = (EdgeCollider2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pointCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pointCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.pointCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_points(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		EdgeCollider2D obj = (EdgeCollider2D)o;

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
	static int set_points(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		EdgeCollider2D obj = (EdgeCollider2D)o;

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
	static int Reset(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		EdgeCollider2D obj = (EdgeCollider2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "EdgeCollider2D");
		obj.Reset();
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

