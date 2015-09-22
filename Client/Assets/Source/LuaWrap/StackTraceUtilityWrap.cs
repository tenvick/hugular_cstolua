using System;
using UnityEngine;
using LuaInterface;

public class StackTraceUtilityWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("ExtractStackTrace", ExtractStackTrace),
			new LuaMethod("ExtractStringFromException", ExtractStringFromException),
			new LuaMethod("New", _CreateStackTraceUtility),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.StackTraceUtility", typeof(StackTraceUtility), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateStackTraceUtility(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			StackTraceUtility obj = new StackTraceUtility();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: StackTraceUtility.New");
		}

		return 0;
	}

	static Type classType = typeof(StackTraceUtility);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExtractStackTrace(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		string o = StackTraceUtility.ExtractStackTrace();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExtractStringFromException(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		object arg0 = LuaScriptMgr.GetVarObject(L, 1);
		string o = StackTraceUtility.ExtractStringFromException(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

