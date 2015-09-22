using System;
using UnityEngine;
using LuaInterface;

public class RenderingPathWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("UsePlayerSettings", GetUsePlayerSettings),
		new LuaMethod("VertexLit", GetVertexLit),
		new LuaMethod("Forward", GetForward),
		new LuaMethod("DeferredLighting", GetDeferredLighting),
		new LuaMethod("DeferredShading", GetDeferredShading),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.RenderingPath", typeof(UnityEngine.RenderingPath), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUsePlayerSettings(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderingPath.UsePlayerSettings);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertexLit(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderingPath.VertexLit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetForward(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderingPath.Forward);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDeferredLighting(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderingPath.DeferredLighting);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDeferredShading(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderingPath.DeferredShading);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		RenderingPath o = (RenderingPath)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

