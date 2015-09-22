using System;
using UnityEngine;
using LuaInterface;

public class MaterialGlobalIlluminationFlagsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("RealtimeEmissive", GetRealtimeEmissive),
		new LuaMethod("BakedEmissive", GetBakedEmissive),
		new LuaMethod("EmissiveIsBlack", GetEmissiveIsBlack),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.MaterialGlobalIlluminationFlags", typeof(UnityEngine.MaterialGlobalIlluminationFlags), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, MaterialGlobalIlluminationFlags.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRealtimeEmissive(IntPtr L)
	{
		LuaScriptMgr.Push(L, MaterialGlobalIlluminationFlags.RealtimeEmissive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBakedEmissive(IntPtr L)
	{
		LuaScriptMgr.Push(L, MaterialGlobalIlluminationFlags.BakedEmissive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEmissiveIsBlack(IntPtr L)
	{
		LuaScriptMgr.Push(L, MaterialGlobalIlluminationFlags.EmissiveIsBlack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		MaterialGlobalIlluminationFlags o = (MaterialGlobalIlluminationFlags)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

