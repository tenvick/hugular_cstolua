using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UnityEngine_UI_ScrollbarWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Rebuild", Rebuild),
			new LuaMethod("OnBeginDrag", OnBeginDrag),
			new LuaMethod("OnDrag", OnDrag),
			new LuaMethod("OnPointerDown", OnPointerDown),
			new LuaMethod("OnPointerUp", OnPointerUp),
			new LuaMethod("OnMove", OnMove),
			new LuaMethod("FindSelectableOnLeft", FindSelectableOnLeft),
			new LuaMethod("FindSelectableOnRight", FindSelectableOnRight),
			new LuaMethod("FindSelectableOnUp", FindSelectableOnUp),
			new LuaMethod("FindSelectableOnDown", FindSelectableOnDown),
			new LuaMethod("OnInitializePotentialDrag", OnInitializePotentialDrag),
			new LuaMethod("SetDirection", SetDirection),
			new LuaMethod("New", _CreateUnityEngine_UI_Scrollbar),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("handleRect", get_handleRect, set_handleRect),
			new LuaField("direction", get_direction, set_direction),
			new LuaField("value", get_value, set_value),
			new LuaField("size", get_size, set_size),
			new LuaField("numberOfSteps", get_numberOfSteps, set_numberOfSteps),
			new LuaField("onValueChanged", get_onValueChanged, set_onValueChanged),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.UI.Scrollbar", typeof(UnityEngine.UI.Scrollbar), regs, fields, typeof(UnityEngine.UI.Selectable));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_UI_Scrollbar(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UnityEngine.UI.Scrollbar class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UnityEngine.UI.Scrollbar);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_handleRect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name handleRect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index handleRect on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.handleRect);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_direction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name direction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index direction on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.direction);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name value");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index value on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.value);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_size(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name size");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index size on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.size);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_numberOfSteps(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name numberOfSteps");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index numberOfSteps on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.numberOfSteps);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onValueChanged(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onValueChanged");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onValueChanged on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.onValueChanged);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_handleRect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name handleRect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index handleRect on a nil value");
			}
		}

		obj.handleRect = (RectTransform)LuaScriptMgr.GetUnityObject(L, 3, typeof(RectTransform));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_direction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name direction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index direction on a nil value");
			}
		}

		obj.direction = (UnityEngine.UI.Scrollbar.Direction)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.Scrollbar.Direction));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name value");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index value on a nil value");
			}
		}

		obj.value = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_size(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name size");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index size on a nil value");
			}
		}

		obj.size = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_numberOfSteps(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name numberOfSteps");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index numberOfSteps on a nil value");
			}
		}

		obj.numberOfSteps = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onValueChanged(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onValueChanged");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onValueChanged on a nil value");
			}
		}

		obj.onValueChanged = (UnityEngine.UI.Scrollbar.ScrollEvent)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.Scrollbar.ScrollEvent));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebuild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.UI.CanvasUpdate));
		obj.Rebuild(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBeginDrag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnBeginDrag(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnDrag(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnPointerDown(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnPointerUp(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMove(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.EventSystems.AxisEventData arg0 = (UnityEngine.EventSystems.AxisEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.AxisEventData));
		obj.OnMove(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnLeft(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnLeft();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnRight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnRight();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnUp();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnDown(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnDown();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInitializePotentialDrag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnInitializePotentialDrag(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDirection(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UnityEngine.UI.Scrollbar obj = (UnityEngine.UI.Scrollbar)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Scrollbar");
		UnityEngine.UI.Scrollbar.Direction arg0 = (UnityEngine.UI.Scrollbar.Direction)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.UI.Scrollbar.Direction));
		bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
		obj.SetDirection(arg0,arg1);
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

