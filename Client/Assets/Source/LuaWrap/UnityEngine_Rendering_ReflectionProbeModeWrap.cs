using System;
using LuaInterface;

public class UnityEngine_Rendering_ReflectionProbeModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Baked", GetBaked),
		new LuaMethod("Realtime", GetRealtime),
		new LuaMethod("Custom", GetCustom),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.ReflectionProbeMode", typeof(UnityEngine.Rendering.ReflectionProbeMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBaked(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeMode.Baked);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRealtime(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeMode.Realtime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCustom(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeMode.Custom);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.ReflectionProbeMode o = (UnityEngine.Rendering.ReflectionProbeMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

