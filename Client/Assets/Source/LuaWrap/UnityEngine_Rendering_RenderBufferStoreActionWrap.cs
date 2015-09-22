using System;
using LuaInterface;

public class UnityEngine_Rendering_RenderBufferStoreActionWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Store", GetStore),
		new LuaMethod("DontCare", GetDontCare),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.RenderBufferStoreAction", typeof(UnityEngine.Rendering.RenderBufferStoreAction), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStore(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.RenderBufferStoreAction.Store);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDontCare(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.RenderBufferStoreAction.DontCare);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.RenderBufferStoreAction o = (UnityEngine.Rendering.RenderBufferStoreAction)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

