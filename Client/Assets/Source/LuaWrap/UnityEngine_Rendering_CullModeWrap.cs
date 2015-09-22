using System;
using LuaInterface;

public class UnityEngine_Rendering_CullModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Off", GetOff),
		new LuaMethod("Front", GetFront),
		new LuaMethod("Back", GetBack),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.CullMode", typeof(UnityEngine.Rendering.CullMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOff(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CullMode.Off);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFront(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CullMode.Front);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBack(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.CullMode.Back);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.CullMode o = (UnityEngine.Rendering.CullMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

