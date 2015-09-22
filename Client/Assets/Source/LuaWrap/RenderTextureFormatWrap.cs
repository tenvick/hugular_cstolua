using System;
using UnityEngine;
using LuaInterface;

public class RenderTextureFormatWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("ARGB32", GetARGB32),
		new LuaMethod("Depth", GetDepth),
		new LuaMethod("ARGBHalf", GetARGBHalf),
		new LuaMethod("Shadowmap", GetShadowmap),
		new LuaMethod("RGB565", GetRGB565),
		new LuaMethod("ARGB4444", GetARGB4444),
		new LuaMethod("ARGB1555", GetARGB1555),
		new LuaMethod("Default", GetDefault),
		new LuaMethod("ARGB2101010", GetARGB2101010),
		new LuaMethod("DefaultHDR", GetDefaultHDR),
		new LuaMethod("ARGBFloat", GetARGBFloat),
		new LuaMethod("RGFloat", GetRGFloat),
		new LuaMethod("RGHalf", GetRGHalf),
		new LuaMethod("RFloat", GetRFloat),
		new LuaMethod("RHalf", GetRHalf),
		new LuaMethod("R8", GetR8),
		new LuaMethod("ARGBInt", GetARGBInt),
		new LuaMethod("RGInt", GetRGInt),
		new LuaMethod("RInt", GetRInt),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.RenderTextureFormat", typeof(UnityEngine.RenderTextureFormat), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetARGB32(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.ARGB32);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDepth(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.Depth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetARGBHalf(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.ARGBHalf);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetShadowmap(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.Shadowmap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGB565(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.RGB565);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetARGB4444(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.ARGB4444);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetARGB1555(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.ARGB1555);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefault(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetARGB2101010(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.ARGB2101010);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefaultHDR(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.DefaultHDR);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetARGBFloat(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.ARGBFloat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGFloat(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.RGFloat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGHalf(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.RGHalf);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRFloat(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.RFloat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRHalf(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.RHalf);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetR8(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.R8);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetARGBInt(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.ARGBInt);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGInt(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.RGInt);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRInt(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderTextureFormat.RInt);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		RenderTextureFormat o = (RenderTextureFormat)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

