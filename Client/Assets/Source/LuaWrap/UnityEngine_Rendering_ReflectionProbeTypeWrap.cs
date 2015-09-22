using System;
using LuaInterface;

public class UnityEngine_Rendering_ReflectionProbeTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Cube", GetCube),
		new LuaMethod("Card", GetCard),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.ReflectionProbeType", typeof(UnityEngine.Rendering.ReflectionProbeType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCube(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeType.Cube);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCard(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.ReflectionProbeType.Card);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.ReflectionProbeType o = (UnityEngine.Rendering.ReflectionProbeType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

