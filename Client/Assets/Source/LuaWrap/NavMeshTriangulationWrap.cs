using System;
using UnityEngine;
using LuaInterface;

public class NavMeshTriangulationWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateNavMeshTriangulation),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("vertices", get_vertices, set_vertices),
			new LuaField("indices", get_indices, set_indices),
			new LuaField("areas", get_areas, set_areas),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.NavMeshTriangulation", typeof(NavMeshTriangulation), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNavMeshTriangulation(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		NavMeshTriangulation obj = new NavMeshTriangulation();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(NavMeshTriangulation);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_vertices(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name vertices");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index vertices on a nil value");
			}
		}

		NavMeshTriangulation obj = (NavMeshTriangulation)o;
		LuaScriptMgr.PushArray(L, obj.vertices);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_indices(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name indices");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index indices on a nil value");
			}
		}

		NavMeshTriangulation obj = (NavMeshTriangulation)o;
		LuaScriptMgr.PushArray(L, obj.indices);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_areas(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name areas");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index areas on a nil value");
			}
		}

		NavMeshTriangulation obj = (NavMeshTriangulation)o;
		LuaScriptMgr.PushArray(L, obj.areas);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_vertices(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name vertices");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index vertices on a nil value");
			}
		}

		NavMeshTriangulation obj = (NavMeshTriangulation)o;
		obj.vertices = LuaScriptMgr.GetArrayObject<Vector3>(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_indices(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name indices");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index indices on a nil value");
			}
		}

		NavMeshTriangulation obj = (NavMeshTriangulation)o;
		obj.indices = LuaScriptMgr.GetArrayNumber<int>(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_areas(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name areas");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index areas on a nil value");
			}
		}

		NavMeshTriangulation obj = (NavMeshTriangulation)o;
		obj.areas = LuaScriptMgr.GetArrayNumber<int>(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}
}

