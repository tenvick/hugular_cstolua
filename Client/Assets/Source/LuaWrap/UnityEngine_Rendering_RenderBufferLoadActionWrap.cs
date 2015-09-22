using System;
using LuaInterface;

public class UnityEngine_Rendering_RenderBufferLoadActionWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Load", GetLoad),
		new LuaMethod("DontCare", GetDontCare),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.RenderBufferLoadAction", typeof(UnityEngine.Rendering.RenderBufferLoadAction), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLoad(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.RenderBufferLoadAction.Load);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDontCare(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.RenderBufferLoadAction.DontCare);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.RenderBufferLoadAction o = (UnityEngine.Rendering.RenderBufferLoadAction)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

