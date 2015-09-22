using System;
using LuaInterface;

public class UnityEngineInternal_LightmapTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("NoLightmap", GetNoLightmap),
		new LuaMethod("StaticLightmap", GetStaticLightmap),
		new LuaMethod("DynamicLightmap", GetDynamicLightmap),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngineInternal.LightmapType", typeof(UnityEngineInternal.LightmapType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNoLightmap(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.LightmapType.NoLightmap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStaticLightmap(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.LightmapType.StaticLightmap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDynamicLightmap(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.LightmapType.DynamicLightmap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngineInternal.LightmapType o = (UnityEngineInternal.LightmapType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

