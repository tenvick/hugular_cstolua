using System;
using UnityEngine;
using LuaInterface;

public class ParticleSystemSimulationSpaceWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Local", GetLocal),
		new LuaMethod("World", GetWorld),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ParticleSystemSimulationSpace", typeof(UnityEngine.ParticleSystemSimulationSpace), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLocal(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleSystemSimulationSpace.Local);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWorld(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleSystemSimulationSpace.World);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ParticleSystemSimulationSpace o = (ParticleSystemSimulationSpace)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

