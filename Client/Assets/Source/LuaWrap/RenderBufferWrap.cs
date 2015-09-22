using System;
using UnityEngine;
using LuaInterface;

public class RenderBufferWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetNativeRenderBufferPtr", GetNativeRenderBufferPtr),
			new LuaMethod("New", _CreateRenderBuffer),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.RenderBuffer", typeof(RenderBuffer), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateRenderBuffer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		RenderBuffer obj = new RenderBuffer();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(RenderBuffer);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNativeRenderBufferPtr(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		RenderBuffer obj = (RenderBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "RenderBuffer");
		IntPtr o = obj.GetNativeRenderBufferPtr();
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

