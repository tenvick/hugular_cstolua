using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UnityEngine_UI_SelectableWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("IsInteractable", IsInteractable),
			new LuaMethod("FindSelectable", FindSelectable),
			new LuaMethod("FindSelectableOnLeft", FindSelectableOnLeft),
			new LuaMethod("FindSelectableOnRight", FindSelectableOnRight),
			new LuaMethod("FindSelectableOnUp", FindSelectableOnUp),
			new LuaMethod("FindSelectableOnDown", FindSelectableOnDown),
			new LuaMethod("OnMove", OnMove),
			new LuaMethod("OnPointerDown", OnPointerDown),
			new LuaMethod("OnPointerUp", OnPointerUp),
			new LuaMethod("OnPointerEnter", OnPointerEnter),
			new LuaMethod("OnPointerExit", OnPointerExit),
			new LuaMethod("OnSelect", OnSelect),
			new LuaMethod("OnDeselect", OnDeselect),
			new LuaMethod("Select", Select),
			new LuaMethod("New", _CreateUnityEngine_UI_Selectable),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("allSelectables", get_allSelectables, null),
			new LuaField("navigation", get_navigation, set_navigation),
			new LuaField("transition", get_transition, set_transition),
			new LuaField("colors", get_colors, set_colors),
			new LuaField("spriteState", get_spriteState, set_spriteState),
			new LuaField("animationTriggers", get_animationTriggers, set_animationTriggers),
			new LuaField("targetGraphic", get_targetGraphic, set_targetGraphic),
			new LuaField("interactable", get_interactable, set_interactable),
			new LuaField("image", get_image, set_image),
			new LuaField("animator", get_animator, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.UI.Selectable", typeof(UnityEngine.UI.Selectable), regs, fields, typeof(UnityEngine.EventSystems.UIBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_UI_Selectable(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UnityEngine.UI.Selectable class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UnityEngine.UI.Selectable);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_allSelectables(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, UnityEngine.UI.Selectable.allSelectables);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_navigation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name navigation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index navigation on a nil value");
			}
		}

		LuaScriptMgr.PushValue(L, obj.navigation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name transition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index transition on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.transition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colors(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name colors");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index colors on a nil value");
			}
		}

		LuaScriptMgr.PushValue(L, obj.colors);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spriteState(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name spriteState");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index spriteState on a nil value");
			}
		}

		LuaScriptMgr.PushValue(L, obj.spriteState);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animationTriggers(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name animationTriggers");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index animationTriggers on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.animationTriggers);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetGraphic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name targetGraphic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index targetGraphic on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.targetGraphic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_interactable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name interactable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index interactable on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.interactable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_image(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name image");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index image on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.image);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animator(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name animator");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index animator on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.animator);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_navigation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name navigation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index navigation on a nil value");
			}
		}

		obj.navigation = (UnityEngine.UI.Navigation)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.Navigation));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_transition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name transition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index transition on a nil value");
			}
		}

		obj.transition = (UnityEngine.UI.Selectable.Transition)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.Selectable.Transition));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_colors(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name colors");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index colors on a nil value");
			}
		}

		obj.colors = (UnityEngine.UI.ColorBlock)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.ColorBlock));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spriteState(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name spriteState");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index spriteState on a nil value");
			}
		}

		obj.spriteState = (UnityEngine.UI.SpriteState)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.SpriteState));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_animationTriggers(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name animationTriggers");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index animationTriggers on a nil value");
			}
		}

		obj.animationTriggers = (UnityEngine.UI.AnimationTriggers)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.AnimationTriggers));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_targetGraphic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name targetGraphic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index targetGraphic on a nil value");
			}
		}

		obj.targetGraphic = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObject(L, 3, typeof(UnityEngine.UI.Graphic));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_interactable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name interactable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index interactable on a nil value");
			}
		}

		obj.interactable = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_image(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name image");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index image on a nil value");
			}
		}

		obj.image = (UnityEngine.UI.Image)LuaScriptMgr.GetUnityObject(L, 3, typeof(UnityEngine.UI.Image));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsInteractable(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		bool o = obj.IsInteractable();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectable(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
		UnityEngine.UI.Selectable o = obj.FindSelectable(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnLeft(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnLeft();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnRight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnRight();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnUp();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnDown(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.UI.Selectable o = obj.FindSelectableOnDown();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMove(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.EventSystems.AxisEventData arg0 = (UnityEngine.EventSystems.AxisEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.AxisEventData));
		obj.OnMove(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnPointerDown(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnPointerUp(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerEnter(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnPointerEnter(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerExit(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
		obj.OnPointerExit(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSelect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnSelect(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDeselect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
		obj.OnDeselect(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Select(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Selectable");
		obj.Select();
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

