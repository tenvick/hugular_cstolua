using System;
using UnityEngine;
using LuaInterface;

public class WebCamFlagsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("FrontFacing", GetFrontFacing),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.WebCamFlags", typeof(UnityEngine.WebCamFlags), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFrontFacing(IntPtr L)
	{
		LuaScriptMgr.Push(L, WebCamFlags.FrontFacing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		WebCamFlags o = (WebCamFlags)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

