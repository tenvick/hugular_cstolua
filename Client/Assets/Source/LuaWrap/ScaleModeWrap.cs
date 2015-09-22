using System;
using UnityEngine;
using LuaInterface;

public class ScaleModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("StretchToFill", GetStretchToFill),
		new LuaMethod("ScaleAndCrop", GetScaleAndCrop),
		new LuaMethod("ScaleToFit", GetScaleToFit),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ScaleMode", typeof(UnityEngine.ScaleMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStretchToFill(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScaleMode.StretchToFill);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetScaleAndCrop(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScaleMode.ScaleAndCrop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetScaleToFit(IntPtr L)
	{
		LuaScriptMgr.Push(L, ScaleMode.ScaleToFit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ScaleMode o = (ScaleMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

