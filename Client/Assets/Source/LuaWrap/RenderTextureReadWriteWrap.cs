using System;
using UnityEngine;
using LuaInterface;

public class RenderTextureReadWriteWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Default", GetDefault),
		new LuaMethod("Linear", GetLinear),
		new LuaMethod("sRGB", GetsRGB),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.RenderTextureReadWrite", typeof(UnityEngine.RenderTextureReadWrite), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefault(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureReadWrite.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLinear(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureReadWrite.Linear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetsRGB(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureReadWrite.sRGB);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		RenderTextureReadWrite o = (RenderTextureReadWrite)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

