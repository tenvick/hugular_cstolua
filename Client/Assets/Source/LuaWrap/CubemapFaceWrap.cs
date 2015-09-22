using System;
using UnityEngine;
using LuaInterface;

public class CubemapFaceWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("PositiveX", GetPositiveX),
		new LuaMethod("NegativeX", GetNegativeX),
		new LuaMethod("PositiveY", GetPositiveY),
		new LuaMethod("NegativeY", GetNegativeY),
		new LuaMethod("PositiveZ", GetPositiveZ),
		new LuaMethod("NegativeZ", GetNegativeZ),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.CubemapFace", typeof(UnityEngine.CubemapFace), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPositiveX(IntPtr L)
	{
		LuaScriptMgr.Push(L, CubemapFace.PositiveX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNegativeX(IntPtr L)
	{
		LuaScriptMgr.Push(L, CubemapFace.NegativeX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPositiveY(IntPtr L)
	{
		LuaScriptMgr.Push(L, CubemapFace.PositiveY);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNegativeY(IntPtr L)
	{
		LuaScriptMgr.Push(L, CubemapFace.NegativeY);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPositiveZ(IntPtr L)
	{
		LuaScriptMgr.Push(L, CubemapFace.PositiveZ);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNegativeZ(IntPtr L)
	{
		LuaScriptMgr.Push(L, CubemapFace.NegativeZ);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		CubemapFace o = (CubemapFace)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

