using System;
using UnityEngine;
using LuaInterface;

public class ParticleSystemRenderModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Billboard", GetBillboard),
		new LuaMethod("Stretch", GetStretch),
		new LuaMethod("HorizontalBillboard", GetHorizontalBillboard),
		new LuaMethod("VerticalBillboard", GetVerticalBillboard),
		new LuaMethod("Mesh", GetMesh),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.ParticleSystemRenderMode", typeof(UnityEngine.ParticleSystemRenderMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBillboard(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleSystemRenderMode.Billboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStretch(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleSystemRenderMode.Stretch);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHorizontalBillboard(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleSystemRenderMode.HorizontalBillboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVerticalBillboard(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleSystemRenderMode.VerticalBillboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMesh(IntPtr L)
	{
		LuaScriptMgr.Push(L, ParticleSystemRenderMode.Mesh);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ParticleSystemRenderMode o = (ParticleSystemRenderMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

