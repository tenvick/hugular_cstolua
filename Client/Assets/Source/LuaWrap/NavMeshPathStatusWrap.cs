using System;
using UnityEngine;
using LuaInterface;

public class NavMeshPathStatusWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("PathComplete", GetPathComplete),
		new LuaMethod("PathPartial", GetPathPartial),
		new LuaMethod("PathInvalid", GetPathInvalid),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.NavMeshPathStatus", typeof(UnityEngine.NavMeshPathStatus), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPathComplete(IntPtr L)
	{
		LuaScriptMgr.Push(L, NavMeshPathStatus.PathComplete);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPathPartial(IntPtr L)
	{
		LuaScriptMgr.Push(L, NavMeshPathStatus.PathPartial);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPathInvalid(IntPtr L)
	{
		LuaScriptMgr.Push(L, NavMeshPathStatus.PathInvalid);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		NavMeshPathStatus o = (NavMeshPathStatus)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

