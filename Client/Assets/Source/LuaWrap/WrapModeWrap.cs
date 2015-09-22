using System;
using UnityEngine;
using LuaInterface;

public class WrapModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Once", GetOnce),
		new LuaMethod("Loop", GetLoop),
		new LuaMethod("PingPong", GetPingPong),
		new LuaMethod("Default", GetDefault),
		new LuaMethod("ClampForever", GetClampForever),
		new LuaMethod("Clamp", GetClamp),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.WrapMode", typeof(UnityEngine.WrapMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOnce(IntPtr L)
	{
		LuaScriptMgr.Push(L, WrapMode.Once);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLoop(IntPtr L)
	{
		LuaScriptMgr.Push(L, WrapMode.Loop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPingPong(IntPtr L)
	{
		LuaScriptMgr.Push(L, WrapMode.PingPong);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefault(IntPtr L)
	{
		LuaScriptMgr.Push(L, WrapMode.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClampForever(IntPtr L)
	{
		LuaScriptMgr.Push(L, WrapMode.ClampForever);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClamp(IntPtr L)
	{
		LuaScriptMgr.Push(L, WrapMode.Clamp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		WrapMode o = (WrapMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

