using System;
using LuaInterface;

public class UnityEngine_Rendering_CameraEventWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("BeforeDepthTexture", GetBeforeDepthTexture),
		new LuaMethod("AfterDepthTexture", GetAfterDepthTexture),
		new LuaMethod("BeforeDepthNormalsTexture", GetBeforeDepthNormalsTexture),
		new LuaMethod("AfterDepthNormalsTexture", GetAfterDepthNormalsTexture),
		new LuaMethod("BeforeGBuffer", GetBeforeGBuffer),
		new LuaMethod("AfterGBuffer", GetAfterGBuffer),
		new LuaMethod("BeforeLighting", GetBeforeLighting),
		new LuaMethod("AfterLighting", GetAfterLighting),
		new LuaMethod("BeforeFinalPass", GetBeforeFinalPass),
		new LuaMethod("AfterFinalPass", GetAfterFinalPass),
		new LuaMethod("BeforeForwardOpaque", GetBeforeForwardOpaque),
		new LuaMethod("AfterForwardOpaque", GetAfterForwardOpaque),
		new LuaMethod("BeforeImageEffectsOpaque", GetBeforeImageEffectsOpaque),
		new LuaMethod("AfterImageEffectsOpaque", GetAfterImageEffectsOpaque),
		new LuaMethod("BeforeSkybox", GetBeforeSkybox),
		new LuaMethod("AfterSkybox", GetAfterSkybox),
		new LuaMethod("BeforeForwardAlpha", GetBeforeForwardAlpha),
		new LuaMethod("AfterForwardAlpha", GetAfterForwardAlpha),
		new LuaMethod("BeforeImageEffects", GetBeforeImageEffects),
		new LuaMethod("AfterImageEffects", GetAfterImageEffects),
		new LuaMethod("AfterEverything", GetAfterEverything),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.CameraEvent", typeof(UnityEngine.Rendering.CameraEvent), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeDepthTexture(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeDepthTexture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterDepthTexture(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterDepthTexture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeDepthNormalsTexture(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeDepthNormalsTexture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterDepthNormalsTexture(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterDepthNormalsTexture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeGBuffer(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeGBuffer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterGBuffer(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterGBuffer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeLighting(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeLighting);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterLighting(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterLighting);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeFinalPass(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeFinalPass);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterFinalPass(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterFinalPass);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeForwardOpaque(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeForwardOpaque);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterForwardOpaque(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterForwardOpaque);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeImageEffectsOpaque(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeImageEffectsOpaque);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterImageEffectsOpaque(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterImageEffectsOpaque);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeSkybox(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeSkybox);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterSkybox(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterSkybox);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeForwardAlpha(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeForwardAlpha);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterForwardAlpha(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterForwardAlpha);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBeforeImageEffects(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.BeforeImageEffects);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterImageEffects(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterImageEffects);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfterEverything(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CameraEvent.AfterEverything);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.CameraEvent o = (UnityEngine.Rendering.CameraEvent)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

