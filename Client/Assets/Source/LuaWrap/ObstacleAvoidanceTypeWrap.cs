using System;
using UnityEngine;
using LuaInterface;

public class ObstacleAvoidanceTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("NoObstacleAvoidance", GetNoObstacleAvoidance),
		new LuaMethod("LowQualityObstacleAvoidance", GetLowQualityObstacleAvoidance),
		new LuaMethod("MedQualityObstacleAvoidance", GetMedQualityObstacleAvoidance),
		new LuaMethod("GoodQualityObstacleAvoidance", GetGoodQualityObstacleAvoidance),
		new LuaMethod("HighQualityObstacleAvoidance", GetHighQualityObstacleAvoidance),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ObstacleAvoidanceType", typeof(UnityEngine.ObstacleAvoidanceType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNoObstacleAvoidance(IntPtr L)
	{
		LuaScriptMgr.Push(L, ObstacleAvoidanceType.NoObstacleAvoidance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLowQualityObstacleAvoidance(IntPtr L)
	{
		LuaScriptMgr.Push(L, ObstacleAvoidanceType.LowQualityObstacleAvoidance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMedQualityObstacleAvoidance(IntPtr L)
	{
		LuaScriptMgr.Push(L, ObstacleAvoidanceType.MedQualityObstacleAvoidance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGoodQualityObstacleAvoidance(IntPtr L)
	{
		LuaScriptMgr.Push(L, ObstacleAvoidanceType.GoodQualityObstacleAvoidance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHighQualityObstacleAvoidance(IntPtr L)
	{
		LuaScriptMgr.Push(L, ObstacleAvoidanceType.HighQualityObstacleAvoidance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ObstacleAvoidanceType o = (ObstacleAvoidanceType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

