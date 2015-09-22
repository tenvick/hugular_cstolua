using System;
using UnityEngine;
using LuaInterface;

public class ScreenOrientationWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Unknown", GetUnknown),
		new LuaMethod("Portrait", GetPortrait),
		new LuaMethod("PortraitUpsideDown", GetPortraitUpsideDown),
		new LuaMethod("LandscapeLeft", GetLandscapeLeft),
		new LuaMethod("LandscapeRight", GetLandscapeRight),
		new LuaMethod("AutoRotation", GetAutoRotation),
		new LuaMethod("Landscape", GetLandscape),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ScreenOrientation", typeof(UnityEngine.ScreenOrientation), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUnknown(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScreenOrientation.Unknown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPortrait(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScreenOrientation.Portrait);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPortraitUpsideDown(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScreenOrientation.PortraitUpsideDown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLandscapeLeft(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScreenOrientation.LandscapeLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLandscapeRight(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScreenOrientation.LandscapeRight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAutoRotation(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScreenOrientation.AutoRotation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLandscape(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScreenOrientation.Landscape);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ScreenOrientation o = (ScreenOrientation)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

