using System;
using LuaInterface;

public class UnityEngine_Events_PersistentListenerModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("EventDefined", GetEventDefined),
		new LuaMethod("Void", GetVoid),
		new LuaMethod("Object", GetObject),
		new LuaMethod("Int", GetInt),
		new LuaMethod("Float", GetFloat),
		new LuaMethod("String", GetString),
		new LuaMethod("Bool", GetBool),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Events.PersistentListenerMode", typeof(UnityEngine.Events.PersistentListenerMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEventDefined(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Events.PersistentListenerMode.EventDefined);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVoid(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Events.PersistentListenerMode.Void);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetObject(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Events.PersistentListenerMode.Object);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInt(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Events.PersistentListenerMode.Int);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFloat(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Events.PersistentListenerMode.Float);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetString(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Events.PersistentListenerMode.String);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBool(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Events.PersistentListenerMode.Bool);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Events.PersistentListenerMode o = (UnityEngine.Events.PersistentListenerMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

