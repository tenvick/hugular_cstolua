using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class CEventReceiveWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("OnPointerDown", OnPointerDown),
			new LuaMethod("OnPointerUp", OnPointerUp),
			new LuaMethod("OnBeginDrag", OnBeginDrag),
			new LuaMethod("OnDrag", OnDrag),
			new LuaMethod("OnDrop", OnDrop),
			new LuaMethod("OnPointerClick", OnPointerClick),
			new LuaMethod("OnSelect", OnSelect),
			new LuaMethod("OnCancel", OnCancel),
			new LuaMethod("New", _CreateCEventReceive),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "CEventReceive", typeof(CEventReceive), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCEventReceive(IntPtr L)
	{
		LuaDLL.luaL_error(L, "CEventReceive class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(CEventReceive);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CEventReceive obj = (CEventReceive)LuaScriptMgr.GetUnityObjectSelf(L, 1, "CEventReceive");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnPointerDown(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CEventReceive obj = (CEventReceive)LuaScriptMgr.GetUnityObjectSelf(L, 1, "CEventReceive");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnPointerUp(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBeginDrag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CEventReceive obj = (CEventReceive)LuaScriptMgr.GetUnityObjectSelf(L, 1, "CEventReceive");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnBeginDrag(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CEventReceive obj = (CEventReceive)LuaScriptMgr.GetUnityObjectSelf(L, 1, "CEventReceive");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnDrag(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrop(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CEventReceive obj = (CEventReceive)LuaScriptMgr.GetUnityObjectSelf(L, 1, "CEventReceive");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnDrop(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CEventReceive obj = (CEventReceive)LuaScriptMgr.GetUnityObjectSelf(L, 1, "CEventReceive");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnPointerClick(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSelect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CEventReceive obj = (CEventReceive)LuaScriptMgr.GetUnityObjectSelf(L, 1, "CEventReceive");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnSelect(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnCancel(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CEventReceive obj = (CEventReceive)LuaScriptMgr.GetUnityObjectSelf(L, 1, "CEventReceive");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnCancel(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

