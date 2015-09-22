using System;
using LuaInterface;

public class UnityEngine_Rendering_BuiltinRenderTextureTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("CurrentActive", GetCurrentActive),
		new LuaMethod("CameraTarget", GetCameraTarget),
		new LuaMethod("Depth", GetDepth),
		new LuaMethod("DepthNormals", GetDepthNormals),
		new LuaMethod("PrepassNormalsSpec", GetPrepassNormalsSpec),
		new LuaMethod("PrepassLight", GetPrepassLight),
		new LuaMethod("PrepassLightSpec", GetPrepassLightSpec),
		new LuaMethod("GBuffer0", GetGBuffer0),
		new LuaMethod("GBuffer1", GetGBuffer1),
		new LuaMethod("GBuffer2", GetGBuffer2),
		new LuaMethod("GBuffer3", GetGBuffer3),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.BuiltinRenderTextureType", typeof(UnityEngine.Rendering.BuiltinRenderTextureType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCurrentActive(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.CurrentActive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCameraTarget(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.CameraTarget);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDepth(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.Depth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDepthNormals(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.DepthNormals);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPrepassNormalsSpec(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.PrepassNormalsSpec);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPrepassLight(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.PrepassLight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPrepassLightSpec(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.PrepassLightSpec);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGBuffer0(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer0);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGBuffer1(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer1);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGBuffer2(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer2);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGBuffer3(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer3);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.BuiltinRenderTextureType o = (UnityEngine.Rendering.BuiltinRenderTextureType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

