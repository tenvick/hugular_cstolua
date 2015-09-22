using System;
using LuaInterface;

public class UnityEngine_Rendering_AmbientModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Skybox", GetSkybox),
		new LuaMethod("Trilight", GetTrilight),
		new LuaMethod("Flat", GetFlat),
		new LuaMethod("Custom", GetCustom),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.AmbientMode", typeof(UnityEngine.Rendering.AmbientMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSkybox(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.AmbientMode.Skybox);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTrilight(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.AmbientMode.Trilight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFlat(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.AmbientMode.Flat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCustom(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.AmbientMode.Custom);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.AmbientMode o = (UnityEngine.Rendering.AmbientMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

