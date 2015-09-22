using System;
using LuaInterface;

public class UnityEngine_Rendering_ReflectionProbeTimeSlicingModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("AllFacesAtOnce", GetAllFacesAtOnce),
		new LuaMethod("IndividualFaces", GetIndividualFaces),
		new LuaMethod("NoTimeSlicing", GetNoTimeSlicing),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.ReflectionProbeTimeSlicingMode", typeof(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllFacesAtOnce(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.AllFacesAtOnce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIndividualFaces(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.IndividualFaces);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNoTimeSlicing(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.NoTimeSlicing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.ReflectionProbeTimeSlicingMode o = (UnityEngine.Rendering.ReflectionProbeTimeSlicingMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

