using System;
using UnityEngine;
using LuaInterface;

public class UserAuthorizationWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("WebCam", GetWebCam),
		new LuaMethod("Microphone", GetMicrophone),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.UserAuthorization", typeof(UnityEngine.UserAuthorization), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWebCam(IntPtr L)
	{
		LuaScriptMgr.Push(L, UserAuthorization.WebCam);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMicrophone(IntPtr L)
	{
		LuaScriptMgr.Push(L, UserAuthorization.Microphone);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UserAuthorization o = (UserAuthorization)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

