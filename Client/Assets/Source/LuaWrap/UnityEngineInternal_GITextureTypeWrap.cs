using System;
using LuaInterface;

public class UnityEngineInternal_GITextureTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Charting", GetCharting),
		new LuaMethod("Albedo", GetAlbedo),
		new LuaMethod("Emissive", GetEmissive),
		new LuaMethod("Irradiance", GetIrradiance),
		new LuaMethod("Directionality", GetDirectionality),
		new LuaMethod("Baked", GetBaked),
		new LuaMethod("BakedDirectional", GetBakedDirectional),
		new LuaMethod("InputWorkspace", GetInputWorkspace),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngineInternal.GITextureType", typeof(UnityEngineInternal.GITextureType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCharting(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.GITextureType.Charting);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAlbedo(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.GITextureType.Albedo);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEmissive(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.GITextureType.Emissive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIrradiance(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.GITextureType.Irradiance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDirectionality(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.GITextureType.Directionality);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBaked(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.GITextureType.Baked);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBakedDirectional(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.GITextureType.BakedDirectional);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInputWorkspace(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngineInternal.GITextureType.InputWorkspace);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngineInternal.GITextureType o = (UnityEngineInternal.GITextureType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

