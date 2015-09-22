using System;
using LuaInterface;

public class UnityEngine_Rendering_CompareFunctionWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Disabled", GetDisabled),
		new LuaMethod("Never", GetNever),
		new LuaMethod("Less", GetLess),
		new LuaMethod("Equal", GetEqual),
		new LuaMethod("LessEqual", GetLessEqual),
		new LuaMethod("Greater", GetGreater),
		new LuaMethod("NotEqual", GetNotEqual),
		new LuaMethod("GreaterEqual", GetGreaterEqual),
		new LuaMethod("Always", GetAlways),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.CompareFunction", typeof(UnityEngine.Rendering.CompareFunction), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDisabled(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CompareFunction.Disabled);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNever(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CompareFunction.Never);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLess(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CompareFunction.Less);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEqual(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CompareFunction.Equal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLessEqual(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CompareFunction.LessEqual);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGreater(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CompareFunction.Greater);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNotEqual(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CompareFunction.NotEqual);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGreaterEqual(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CompareFunction.GreaterEqual);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAlways(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CompareFunction.Always);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.CompareFunction o = (UnityEngine.Rendering.CompareFunction)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

