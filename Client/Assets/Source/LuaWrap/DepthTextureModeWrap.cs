using System;
using UnityEngine;
using LuaInterface;

public class DepthTextureModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("Depth", GetDepth),
		new LuaMethod("DepthNormals", GetDepthNormals),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.DepthTextureMode", typeof(UnityEngine.DepthTextureMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, DepthTextureMode.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDepth(IntPtr L)
	{
		LuaScriptMgr.Push(L, DepthTextureMode.Depth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDepthNormals(IntPtr L)
	{
		LuaScriptMgr.Push(L, DepthTextureMode.DepthNormals);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		DepthTextureMode o = (DepthTextureMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

