using System;
using UnityEngine;
using LuaInterface;

public class TextureWrapModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Repeat", GetRepeat),
		new LuaMethod("Clamp", GetClamp),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.TextureWrapMode", typeof(UnityEngine.TextureWrapMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRepeat(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureWrapMode.Repeat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClamp(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureWrapMode.Clamp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		TextureWrapMode o = (TextureWrapMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

