using System;
using UnityEngine;
using LuaInterface;

public class ParticleRenderModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Billboard", GetBillboard),
		new LuaMethod("Stretch", GetStretch),
		new LuaMethod("SortedBillboard", GetSortedBillboard),
		new LuaMethod("HorizontalBillboard", GetHorizontalBillboard),
		new LuaMethod("VerticalBillboard", GetVerticalBillboard),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ParticleRenderMode", typeof(UnityEngine.ParticleRenderMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBillboard(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleRenderMode.Billboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStretch(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleRenderMode.Stretch);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSortedBillboard(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleRenderMode.SortedBillboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHorizontalBillboard(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleRenderMode.HorizontalBillboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVerticalBillboard(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleRenderMode.VerticalBillboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ParticleRenderMode o = (ParticleRenderMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

