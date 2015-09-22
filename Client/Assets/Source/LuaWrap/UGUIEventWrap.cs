using System;
using UnityEngine;
using LuaInterface;

public class UGUIEventWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("onCustomerHandle", onCustomerHandle),
			new LuaMethod("onPressHandle", onPressHandle),
			new LuaMethod("onClickHandle", onClickHandle),
			new LuaMethod("onDragHandle", onDragHandle),
			new LuaMethod("onDropHandle", onDropHandle),
			new LuaMethod("onSelectHandle", onSelectHandle),
			new LuaMethod("onCancelHandle", onCancelHandle),
			new LuaMethod("New", _CreateUGUIEvent),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("onCustomerFn", get_onCustomerFn, set_onCustomerFn),
			new LuaField("onPressFn", get_onPressFn, set_onPressFn),
			new LuaField("onClickFn", get_onClickFn, set_onClickFn),
			new LuaField("onDragFn", get_onDragFn, set_onDragFn),
			new LuaField("onDropFn", get_onDropFn, set_onDropFn),
			new LuaField("onSelectFn", get_onSelectFn, set_onSelectFn),
			new LuaField("onCancelFn", get_onCancelFn, set_onCancelFn),
		};

		LuaScriptMgr.RegisterLib(L, "UGUIEvent", typeof(UGUIEvent), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUGUIEvent(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UGUIEvent class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UGUIEvent);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onCustomerFn(IntPtr L)
	{
		LuaScriptMgr.Push(L, UGUIEvent.onCustomerFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPressFn(IntPtr L)
	{
		LuaScriptMgr.Push(L, UGUIEvent.onPressFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClickFn(IntPtr L)
	{
		LuaScriptMgr.Push(L, UGUIEvent.onClickFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDragFn(IntPtr L)
	{
		LuaScriptMgr.Push(L, UGUIEvent.onDragFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDropFn(IntPtr L)
	{
		LuaScriptMgr.Push(L, UGUIEvent.onDropFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSelectFn(IntPtr L)
	{
		LuaScriptMgr.Push(L, UGUIEvent.onSelectFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onCancelFn(IntPtr L)
	{
		LuaScriptMgr.Push(L, UGUIEvent.onCancelFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onCustomerFn(IntPtr L)
	{
		UGUIEvent.onCustomerFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPressFn(IntPtr L)
	{
		UGUIEvent.onPressFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClickFn(IntPtr L)
	{
		UGUIEvent.onClickFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDragFn(IntPtr L)
	{
		UGUIEvent.onDragFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDropFn(IntPtr L)
	{
		UGUIEvent.onDropFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSelectFn(IntPtr L)
	{
		UGUIEvent.onSelectFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onCancelFn(IntPtr L)
	{
		UGUIEvent.onCancelFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onCustomerHandle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object arg0 = LuaScriptMgr.GetVarObject(L, 1);
		object arg1 = LuaScriptMgr.GetVarObject(L, 2);
		UGUIEvent.onCustomerHandle(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onPressHandle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		bool arg1 = LuaScriptMgr.GetBoolean(L, 2);
		UGUIEvent.onPressHandle(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onClickHandle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		object arg1 = LuaScriptMgr.GetVarObject(L, 2);
		UGUIEvent.onClickHandle(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onDragHandle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
		UGUIEvent.onDragHandle(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onDropHandle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		object arg1 = LuaScriptMgr.GetVarObject(L, 2);
		UGUIEvent.onDropHandle(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onSelectHandle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		object arg1 = LuaScriptMgr.GetVarObject(L, 2);
		UGUIEvent.onSelectHandle(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onCancelHandle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		object arg1 = LuaScriptMgr.GetVarObject(L, 2);
		UGUIEvent.onCancelHandle(arg0,arg1);
		return 0;
	}
}

