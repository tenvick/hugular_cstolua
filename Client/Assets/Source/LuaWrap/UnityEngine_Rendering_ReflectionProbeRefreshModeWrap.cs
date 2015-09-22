using System;
using LuaInterface;

public class UnityEngine_Rendering_ReflectionProbeRefreshModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("OnAwake", GetOnAwake),
		new LuaMethod("EveryFrame", GetEveryFrame),
		new LuaMethod("ViaScripting", GetViaScripting),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.ReflectionProbeRefreshMode", typeof(UnityEngine.Rendering.ReflectionProbeRefreshMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOnAwake(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeRefreshMode.OnAwake);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEveryFrame(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeRefreshMode.EveryFrame);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetViaScripting(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeRefreshMode.ViaScripting);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.ReflectionProbeRefreshMode o = (UnityEngine.Rendering.ReflectionProbeRefreshMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

