using System;
using LuaInterface;

public class UnityEngine_Rendering_DefaultReflectionModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Skybox", GetSkybox),
		new LuaMethod("Custom", GetCustom),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.DefaultReflectionMode", typeof(UnityEngine.Rendering.DefaultReflectionMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSkybox(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.DefaultReflectionMode.Skybox);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCustom(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.DefaultReflectionMode.Custom);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.DefaultReflectionMode o = (UnityEngine.Rendering.DefaultReflectionMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

