using System;
using UnityEngine;
using LuaInterface;

public class ParticlePhysicsExtensionsWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetSafeCollisionEventSize", GetSafeCollisionEventSize),
			new LuaMethod("GetCollisionEvents", GetCollisionEvents),
			new LuaMethod("New", _CreateParticlePhysicsExtensions),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ParticlePhysicsExtensions", regs);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateParticlePhysicsExtensions(IntPtr L)
	{
		LuaDLL.luaL_error(L, "ParticlePhysicsExtensions class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(ParticlePhysicsExtensions);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSafeCollisionEventSize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		ParticleSystem arg0 = (ParticleSystem)LuaScriptMgr.GetUnityObject(L, 1, typeof(ParticleSystem));
		int o = ParticlePhysicsExtensions.GetSafeCollisionEventSize(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCollisionEvents(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		ParticleSystem arg0 = (ParticleSystem)LuaScriptMgr.GetUnityObject(L, 1, typeof(ParticleSystem));
		GameObject arg1 = (GameObject)LuaScriptMgr.GetUnityObject(L, 2, typeof(GameObject));
		ParticleCollisionEvent[] objs2 = LuaScriptMgr.GetArrayObject<ParticleCollisionEvent>(L, 3);
		int o = ParticlePhysicsExtensions.GetCollisionEvents(arg0,arg1,objs2);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

