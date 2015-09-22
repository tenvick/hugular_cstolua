using System;
using LuaInterface;

public class UnityEngine_Rendering_ReflectionProbeUsageWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Off", GetOff),
		new LuaMethod("BlendProbes", GetBlendProbes),
		new LuaMethod("BlendProbesAndSkybox", GetBlendProbesAndSkybox),
		new LuaMethod("Simple", GetSimple),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.ReflectionProbeUsage", typeof(UnityEngine.Rendering.ReflectionProbeUsage), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOff(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeUsage.Off);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBlendProbes(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeUsage.BlendProbes);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBlendProbesAndSkybox(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeUsage.BlendProbesAndSkybox);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSimple(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeUsage.Simple);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.ReflectionProbeUsage o = (UnityEngine.Rendering.ReflectionProbeUsage)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

