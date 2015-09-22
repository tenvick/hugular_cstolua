using System;
using LuaInterface;

public class UnityEngine_Rendering_ShadowCastingModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Off", GetOff),
		new LuaMethod("On", GetOn),
		new LuaMethod("TwoSided", GetTwoSided),
		new LuaMethod("ShadowsOnly", GetShadowsOnly),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.ShadowCastingMode", typeof(UnityEngine.Rendering.ShadowCastingMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOff(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ShadowCastingMode.Off);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOn(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ShadowCastingMode.On);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTwoSided(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ShadowCastingMode.TwoSided);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetShadowsOnly(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.ShadowCastingMode o = (UnityEngine.Rendering.ShadowCastingMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

