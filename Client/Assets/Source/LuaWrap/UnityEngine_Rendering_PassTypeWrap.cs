using System;
using LuaInterface;

public class UnityEngine_Rendering_PassTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Normal", GetNormal),
		new LuaMethod("Vertex", GetVertex),
		new LuaMethod("VertexLM", GetVertexLM),
		new LuaMethod("VertexLMRGBM", GetVertexLMRGBM),
		new LuaMethod("ForwardBase", GetForwardBase),
		new LuaMethod("ForwardAdd", GetForwardAdd),
		new LuaMethod("LightPrePassBase", GetLightPrePassBase),
		new LuaMethod("LightPrePassFinal", GetLightPrePassFinal),
		new LuaMethod("ShadowCaster", GetShadowCaster),
		new LuaMethod("Deferred", GetDeferred),
		new LuaMethod("Meta", GetMeta),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.PassType", typeof(UnityEngine.Rendering.PassType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNormal(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.Normal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertex(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.Vertex);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertexLM(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.VertexLM);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertexLMRGBM(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.VertexLMRGBM);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetForwardBase(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.ForwardBase);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetForwardAdd(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.ForwardAdd);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLightPrePassBase(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.LightPrePassBase);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLightPrePassFinal(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.LightPrePassFinal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetShadowCaster(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.ShadowCaster);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDeferred(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.Deferred);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMeta(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.PassType.Meta);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.PassType o = (UnityEngine.Rendering.PassType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

