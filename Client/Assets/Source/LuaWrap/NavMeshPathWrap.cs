using System;
using UnityEngine;
using LuaInterface;

public class NavMeshPathWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetCornersNonAlloc", GetCornersNonAlloc),
			new LuaMethod("ClearCorners", ClearCorners),
			new LuaMethod("New", _CreateNavMeshPath),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("corners", get_corners, null),
			new LuaField("status", get_status, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.NavMeshPath", typeof(NavMeshPath), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNavMeshPath(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			NavMeshPath obj = new NavMeshPath();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NavMeshPath.New");
		}

		return 0;
	}

	static Type classType = typeof(NavMeshPath);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_corners(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshPath obj = (NavMeshPath)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name corners");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index corners on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.corners);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_status(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		NavMeshPath obj = (NavMeshPath)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name status");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index status on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.status);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCornersNonAlloc(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		NavMeshPath obj = (NavMeshPath)LuaScriptMgr.GetNetObjectSelf(L, 1, "NavMeshPath");
		Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
		int o = obj.GetCornersNonAlloc(objs0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearCorners(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		NavMeshPath obj = (NavMeshPath)LuaScriptMgr.GetNetObjectSelf(L, 1, "NavMeshPath");
		obj.ClearCorners();
		return 0;
	}
}

