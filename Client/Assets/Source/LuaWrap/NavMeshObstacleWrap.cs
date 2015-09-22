using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class NavMeshObstacleWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateNavMeshObstacle),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("height", get_height, set_height),
			new LuaField("radius", get_radius, set_radius),
			new LuaField("velocity", get_velocity, set_velocity),
			new LuaField("carving", get_carving, set_carving),
			new LuaField("carveOnlyStationary", get_carveOnlyStationary, set_carveOnlyStationary),
			new LuaField("carvingMoveThreshold", get_carvingMoveThreshold, set_carvingMoveThreshold),
			new LuaField("carvingTimeToStationary", get_carvingTimeToStationary, set_carvingTimeToStationary),
			new LuaField("shape", get_shape, set_shape),
			new LuaField("center", get_center, set_center),
			new LuaField("size", get_size, set_size),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.NavMeshObstacle", typeof(NavMeshObstacle), regs, fields, typeof(Behaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNavMeshObstacle(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			NavMeshObstacle obj = new NavMeshObstacle();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NavMeshObstacle.New");
		}

		return 0;
	}

	static Type classType = typeof(NavMeshObstacle);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name height");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index height on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.height);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_radius(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name radius");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index radius on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.radius);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_velocity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
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

		LuaScriptMgr.Push(L, obj.velocity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_carving(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name carving");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index carving on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.carving);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_carveOnlyStationary(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name carveOnlyStationary");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index carveOnlyStationary on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.carveOnlyStationary);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_carvingMoveThreshold(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name carvingMoveThreshold");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index carvingMoveThreshold on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.carvingMoveThreshold);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_carvingTimeToStationary(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name carvingTimeToStationary");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index carvingTimeToStationary on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.carvingTimeToStationary);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shape(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shape");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shape on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shape);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_center(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name center");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index center on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.center);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_size(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name size");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index size on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.size);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_height(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name height");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index height on a nil value");
			}
		}

		obj.height = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_radius(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name radius");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index radius on a nil value");
			}
		}

		obj.radius = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_velocity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
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

		obj.velocity = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_carving(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name carving");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index carving on a nil value");
			}
		}

		obj.carving = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_carveOnlyStationary(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name carveOnlyStationary");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index carveOnlyStationary on a nil value");
			}
		}

		obj.carveOnlyStationary = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_carvingMoveThreshold(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name carvingMoveThreshold");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index carvingMoveThreshold on a nil value");
			}
		}

		obj.carvingMoveThreshold = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_carvingTimeToStationary(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name carvingTimeToStationary");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index carvingTimeToStationary on a nil value");
			}
		}

		obj.carvingTimeToStationary = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shape(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shape");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shape on a nil value");
			}
		}

		obj.shape = (NavMeshObstacleShape)LuaScriptMgr.GetNetObject(L, 3, typeof(NavMeshObstacleShape));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_center(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name center");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index center on a nil value");
			}
		}

		obj.center = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_size(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshObstacle obj = (NavMeshObstacle)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name size");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index size on a nil value");
			}
		}

		obj.size = LuaScriptMgr.GetVector3(L, 3);
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

