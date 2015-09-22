using System;
using UnityEngine;
using LuaInterface;

public class RigidbodySleepMode2DWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("NeverSleep", GetNeverSleep),
		new LuaMethod("StartAwake", GetStartAwake),
		new LuaMethod("StartAsleep", GetStartAsleep),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.RigidbodySleepMode2D", typeof(UnityEngine.RigidbodySleepMode2D), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNeverSleep(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodySleepMode2D.NeverSleep);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStartAwake(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodySleepMode2D.StartAwake);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStartAsleep(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodySleepMode2D.StartAsleep);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		RigidbodySleepMode2D o = (RigidbodySleepMode2D)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

