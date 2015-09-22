using System;
using LuaInterface;

public class UnityEngine_Rendering_BlendModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Zero", GetZero),
		new LuaMethod("One", GetOne),
		new LuaMethod("DstColor", GetDstColor),
		new LuaMethod("SrcColor", GetSrcColor),
		new LuaMethod("OneMinusDstColor", GetOneMinusDstColor),
		new LuaMethod("SrcAlpha", GetSrcAlpha),
		new LuaMethod("OneMinusSrcColor", GetOneMinusSrcColor),
		new LuaMethod("DstAlpha", GetDstAlpha),
		new LuaMethod("OneMinusDstAlpha", GetOneMinusDstAlpha),
		new LuaMethod("SrcAlphaSaturate", GetSrcAlphaSaturate),
		new LuaMethod("OneMinusSrcAlpha", GetOneMinusSrcAlpha),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.BlendMode", typeof(UnityEngine.Rendering.BlendMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetZero(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.Zero);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOne(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.One);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDstColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.DstColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSrcColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.SrcColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOneMinusDstColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.OneMinusDstColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSrcAlpha(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.SrcAlpha);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOneMinusSrcColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.OneMinusSrcColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDstAlpha(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.DstAlpha);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOneMinusDstAlpha(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.OneMinusDstAlpha);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSrcAlphaSaturate(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.SrcAlphaSaturate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOneMinusSrcAlpha(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.BlendMode o = (UnityEngine.Rendering.BlendMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

