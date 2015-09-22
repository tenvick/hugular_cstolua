using System;
using UnityEngine;
using LuaInterface;

public class DeviceOrientationWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Unknown", GetUnknown),
		new LuaMethod("Portrait", GetPortrait),
		new LuaMethod("PortraitUpsideDown", GetPortraitUpsideDown),
		new LuaMethod("LandscapeLeft", GetLandscapeLeft),
		new LuaMethod("LandscapeRight", GetLandscapeRight),
		new LuaMethod("FaceUp", GetFaceUp),
		new LuaMethod("FaceDown", GetFaceDown),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.DeviceOrientation", typeof(UnityEngine.DeviceOrientation), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUnknown(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceOrientation.Unknown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPortrait(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceOrientation.Portrait);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPortraitUpsideDown(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceOrientation.PortraitUpsideDown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLandscapeLeft(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceOrientation.LandscapeLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLandscapeRight(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceOrientation.LandscapeRight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFaceUp(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceOrientation.FaceUp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFaceDown(IntPtr L)
	{
		LuaScriptMgr.Push(L, DeviceOrientation.FaceDown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		DeviceOrientation o = (DeviceOrientation)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

