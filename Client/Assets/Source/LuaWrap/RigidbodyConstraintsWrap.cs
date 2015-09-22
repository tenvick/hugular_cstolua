using System;
using UnityEngine;
using LuaInterface;

public class RigidbodyConstraintsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("FreezePositionX", GetFreezePositionX),
		new LuaMethod("FreezePositionY", GetFreezePositionY),
		new LuaMethod("FreezePositionZ", GetFreezePositionZ),
		new LuaMethod("FreezeRotationX", GetFreezeRotationX),
		new LuaMethod("FreezeRotationY", GetFreezeRotationY),
		new LuaMethod("FreezeRotationZ", GetFreezeRotationZ),
		new LuaMethod("FreezePosition", GetFreezePosition),
		new LuaMethod("FreezeRotation", GetFreezeRotation),
		new LuaMethod("FreezeAll", GetFreezeAll),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.RigidbodyConstraints", typeof(UnityEngine.RigidbodyConstraints), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFreezePositionX(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.FreezePositionX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFreezePositionY(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.FreezePositionY);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFreezePositionZ(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.FreezePositionZ);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFreezeRotationX(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.FreezeRotationX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFreezeRotationY(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.FreezeRotationY);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFreezeRotationZ(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.FreezeRotationZ);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFreezePosition(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.FreezePosition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFreezeRotation(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.FreezeRotation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFreezeAll(IntPtr L)
	{
		LuaScriptMgr.Push(L, RigidbodyConstraints.FreezeAll);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		RigidbodyConstraints o = (RigidbodyConstraints)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

