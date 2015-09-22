using System;
using UnityEngine;
using LuaInterface;

public class NavMeshObstacleShapeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Capsule", GetCapsule),
		new LuaMethod("Box", GetBox),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.NavMeshObstacleShape", typeof(UnityEngine.NavMeshObstacleShape), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCapsule(IntPtr L)
	{
		LuaScriptMgr.Push(L, NavMeshObstacleShape.Capsule);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBox(IntPtr L)
	{
		LuaScriptMgr.Push(L, NavMeshObstacleShape.Box);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		NavMeshObstacleShape o = (NavMeshObstacleShape)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

