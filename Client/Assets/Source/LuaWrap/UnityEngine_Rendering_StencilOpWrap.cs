using System;
using LuaInterface;

public class UnityEngine_Rendering_StencilOpWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Keep", GetKeep),
		new LuaMethod("Zero", GetZero),
		new LuaMethod("Replace", GetReplace),
		new LuaMethod("IncrementSaturate", GetIncrementSaturate),
		new LuaMethod("DecrementSaturate", GetDecrementSaturate),
		new LuaMethod("Invert", GetInvert),
		new LuaMethod("IncrementWrap", GetIncrementWrap),
		new LuaMethod("DecrementWrap", GetDecrementWrap),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.StencilOp", typeof(UnityEngine.Rendering.StencilOp), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetKeep(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.StencilOp.Keep);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetZero(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.StencilOp.Zero);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetReplace(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.StencilOp.Replace);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIncrementSaturate(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.StencilOp.IncrementSaturate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDecrementSaturate(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.StencilOp.DecrementSaturate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInvert(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.StencilOp.Invert);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIncrementWrap(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.StencilOp.IncrementWrap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDecrementWrap(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.StencilOp.DecrementWrap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.StencilOp o = (UnityEngine.Rendering.StencilOp)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

