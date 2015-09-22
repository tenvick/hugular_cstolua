using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UnityEngine_UI_SliderWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Rebuild", Rebuild),
			new LuaMethod("OnPointerDown", OnPointerDown),
			new LuaMethod("OnDrag", OnDrag),
			new LuaMethod("OnMove", OnMove),
			new LuaMethod("FindSelectableOnLeft", FindSelectableOnLeft),
			new LuaMethod("FindSelectableOnRight", FindSelectableOnRight),
			new LuaMethod("FindSelectableOnUp", FindSelectableOnUp),
			new LuaMethod("FindSelectableOnDown", FindSelectableOnDown),
			new LuaMethod("OnInitializePotentialDrag", OnInitializePotentialDrag),
			new LuaMethod("SetDirection", SetDirection),
			new LuaMethod("New", _CreateUnityEngine_UI_Slider),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("fillRect", get_fillRect, set_fillRect),
			new LuaField("handleRect", get_handleRect, set_handleRect),
			new LuaField("direction", get_direction, set_direction),
			new LuaField("minValue", get_minValue, set_minValue),
			new LuaField("maxValue", get_maxValue, set_maxValue),
			new LuaField("wholeNumbers", get_wholeNumbers, set_wholeNumbers),
			new LuaField("value", get_value, set_value),
			new LuaField("normalizedValue", get_normalizedValue, set_normalizedValue),
			new LuaField("onValueChanged", get_onValueChanged, set_onValueChanged),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.UI.Slider", typeof(UnityEngine.UI.Slider), regs, fields, typeof(UnityEngine.UI.Selectable));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_UI_Slider(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UnityEngine.UI.Slider class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UnityEngine.UI.Slider);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fillRect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillRect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillRect on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fillRect);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_handleRect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

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
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

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
	static int get_minValue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minValue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minValue on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.minValue);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxValue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxValue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxValue on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.maxValue);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wholeNumbers(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wholeNumbers");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wholeNumbers on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.wholeNumbers);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

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
	static int get_normalizedValue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name normalizedValue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index normalizedValue on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.normalizedValue);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onValueChanged(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

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
	static int set_fillRect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillRect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillRect on a nil value");
			}
		}

		obj.fillRect = (RectTransform)LuaScriptMgr.GetUnityObject(L, 3, typeof(RectTransform));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_handleRect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

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
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

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

		obj.direction = (UnityEngine.UI.Slider.Direction)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.Slider.Direction));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_minValue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minValue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minValue on a nil value");
			}
		}

		obj.minValue = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxValue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxValue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxValue on a nil value");
			}
		}

		obj.maxValue = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wholeNumbers(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wholeNumbers");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wholeNumbers on a nil value");
			}
		}

		obj.wholeNumbers = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

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
	static int set_normalizedValue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name normalizedValue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index normalizedValue on a nil value");
			}
		}

		obj.normalizedValue = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onValueChanged(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)o;

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

		obj.onValueChanged = (UnityEngine.UI.Slider.SliderEvent)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.Slider.SliderEvent));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebuild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.UI.CanvasUpdate));
		obj.Rebuild(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnPointerDown(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnDrag(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMove(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.EventSystems.AxisEventData arg0 = (UnityEngine.EventSystems.AxisEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.AxisEventData));
		obj.OnMove(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnLeft(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnLeft();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnRight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnRight();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnUp();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnDown(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnDown();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInitializePotentialDrag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnInitializePotentialDrag(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDirection(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UnityEngine.UI.Slider obj = (UnityEngine.UI.Slider)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Slider");
		UnityEngine.UI.Slider.Direction arg0 = (UnityEngine.UI.Slider.Direction)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.UI.Slider.Direction));
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

