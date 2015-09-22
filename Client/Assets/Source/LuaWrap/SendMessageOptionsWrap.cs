using System;
using UnityEngine;
using LuaInterface;

public class SendMessageOptionsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("RequireReceiver", GetRequireReceiver),
		new LuaMethod("DontRequireReceiver", GetDontRequireReceiver),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.SendMessageOptions", typeof(UnityEngine.SendMessageOptions), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRequireReceiver(IntPtr L)
	{
		LuaScriptMgr.Push(L, SendMessageOptions.RequireReceiver);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDontRequireReceiver(IntPtr L)
	{
		LuaScriptMgr.Push(L, SendMessageOptions.DontRequireReceiver);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		SendMessageOptions o = (SendMessageOptions)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

