using System;
using UnityEngine;
using LuaInterface;

public class UnityEngine_Rendering_RenderTargetIdentifierWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateUnityEngine_Rendering_RenderTargetIdentifier),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.RenderTargetIdentifier", typeof(UnityEngine.Rendering.RenderTargetIdentifier), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Rendering_RenderTargetIdentifier(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			UnityEngine.Rendering.RenderTargetIdentifier obj = new UnityEngine.Rendering.RenderTargetIdentifier(arg0);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(RenderTexture)))
		{
			RenderTexture arg0 = (RenderTexture)LuaScriptMgr.GetUnityObject(L, 1, typeof(RenderTexture));
			UnityEngine.Rendering.RenderTargetIdentifier obj = new UnityEngine.Rendering.RenderTargetIdentifier(arg0);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.BuiltinRenderTextureType)))
		{
			UnityEngine.Rendering.BuiltinRenderTextureType arg0 = (UnityEngine.Rendering.BuiltinRenderTextureType)LuaScriptMgr.GetNetObject(L, 1, typeof(UnityEngine.Rendering.BuiltinRenderTextureType));
			UnityEngine.Rendering.RenderTargetIdentifier obj = new UnityEngine.Rendering.RenderTargetIdentifier(arg0);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			UnityEngine.Rendering.RenderTargetIdentifier obj = new UnityEngine.Rendering.RenderTargetIdentifier(arg0);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 0)
		{
			UnityEngine.Rendering.RenderTargetIdentifier obj = new UnityEngine.Rendering.RenderTargetIdentifier();
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.RenderTargetIdentifier.New");
		}

		return 0;
	}

	static Type classType = typeof(UnityEngine.Rendering.RenderTargetIdentifier);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}
}

