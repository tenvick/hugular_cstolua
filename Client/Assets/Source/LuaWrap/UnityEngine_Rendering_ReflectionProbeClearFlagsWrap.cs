using System;
using LuaInterface;

public class UnityEngine_Rendering_ReflectionProbeClearFlagsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Skybox", GetSkybox),
		new LuaMethod("SolidColor", GetSolidColor),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.ReflectionProbeClearFlags", typeof(UnityEngine.Rendering.ReflectionProbeClearFlags), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSkybox(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeClearFlags.Skybox);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSolidColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeClearFlags.SolidColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.ReflectionProbeClearFlags o = (UnityEngine.Rendering.ReflectionProbeClearFlags)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

