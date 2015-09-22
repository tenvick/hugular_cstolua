using System;
using UnityEngine;
using LuaInterface;

public class ComputeBufferTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Default", GetDefault),
		new LuaMethod("Raw", GetRaw),
		new LuaMethod("Append", GetAppend),
		new LuaMethod("Counter", GetCounter),
		new LuaMethod("DrawIndirect", GetDrawIndirect),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ComputeBufferType", typeof(UnityEngine.ComputeBufferType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefault(IntPtr L)
	{
		LuaScriptMgr.Push(L, ComputeBufferType.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRaw(IntPtr L)
	{
		LuaScriptMgr.Push(L, ComputeBufferType.Raw);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAppend(IntPtr L)
	{
		LuaScriptMgr.Push(L, ComputeBufferType.Append);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCounter(IntPtr L)
	{
		LuaScriptMgr.Push(L, ComputeBufferType.Counter);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDrawIndirect(IntPtr L)
	{
		LuaScriptMgr.Push(L, ComputeBufferType.DrawIndirect);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ComputeBufferType o = (ComputeBufferType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

