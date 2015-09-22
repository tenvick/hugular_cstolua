using System;
using UnityEngine;
using LuaInterface;

public class NavMeshWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Raycast", Raycast),
			new LuaMethod("CalculatePath", CalculatePath),
			new LuaMethod("FindClosestEdge", FindClosestEdge),
			new LuaMethod("SamplePosition", SamplePosition),
			new LuaMethod("SetAreaCost", SetAreaCost),
			new LuaMethod("GetAreaCost", GetAreaCost),
			new LuaMethod("GetAreaFromName", GetAreaFromName),
			new LuaMethod("CalculateTriangulation", CalculateTriangulation),
			new LuaMethod("New", _CreateNavMesh),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("AllAreas", get_AllAreas, null),
			new LuaField("avoidancePredictionTime", get_avoidancePredictionTime, set_avoidancePredictionTime),
			new LuaField("pathfindingIterationsPerFrame", get_pathfindingIterationsPerFrame, set_pathfindingIterationsPerFrame),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.NavMesh", typeof(NavMesh), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNavMesh(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			NavMesh obj = new NavMesh();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NavMesh.New");
		}

		return 0;
	}

	static Type classType = typeof(NavMesh);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AllAreas(IntPtr L)
	{
		LuaScriptMgr.Push(L, NavMesh.AllAreas);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_avoidancePredictionTime(IntPtr L)
	{
		LuaScriptMgr.Push(L, NavMesh.avoidancePredictionTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pathfindingIterationsPerFrame(IntPtr L)
	{
		LuaScriptMgr.Push(L, NavMesh.pathfindingIterationsPerFrame);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_avoidancePredictionTime(IntPtr L)
	{
		NavMesh.avoidancePredictionTime = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pathfindingIterationsPerFrame(IntPtr L)
	{
		NavMesh.pathfindingIterationsPerFrame = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Raycast(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
		NavMeshHit arg2;
		int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
		bool o = NavMesh.Raycast(arg0,arg1,out arg2,arg3);
		LuaScriptMgr.Push(L, o);
		LuaScriptMgr.PushValue(L, arg2);
		return 2;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculatePath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
		NavMeshPath arg3 = (NavMeshPath)LuaScriptMgr.GetNetObject(L, 4, typeof(NavMeshPath));
		bool o = NavMesh.CalculatePath(arg0,arg1,arg2,arg3);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindClosestEdge(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		NavMeshHit arg1;
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
		bool o = NavMesh.FindClosestEdge(arg0,out arg1,arg2);
		LuaScriptMgr.Push(L, o);
		LuaScriptMgr.PushValue(L, arg1);
		return 2;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SamplePosition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		NavMeshHit arg1;
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
		bool o = NavMesh.SamplePosition(arg0,out arg1,arg2,arg3);
		LuaScriptMgr.Push(L, o);
		LuaScriptMgr.PushValue(L, arg1);
		return 2;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAreaCost(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		NavMesh.SetAreaCost(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAreaCost(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		float o = NavMesh.GetAreaCost(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAreaFromName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		int o = NavMesh.GetAreaFromName(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateTriangulation(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		NavMeshTriangulation o = NavMesh.CalculateTriangulation();
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}
}

