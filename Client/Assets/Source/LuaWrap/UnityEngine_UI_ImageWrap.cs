using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UnityEngine_UI_ImageWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("OnBeforeSerialize", OnBeforeSerialize),
			new LuaMethod("OnAfterDeserialize", OnAfterDeserialize),
			new LuaMethod("SetNativeSize", SetNativeSize),
			new LuaMethod("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal),
			new LuaMethod("CalculateLayoutInputVertical", CalculateLayoutInputVertical),
			new LuaMethod("IsRaycastLocationValid", IsRaycastLocationValid),
			new LuaMethod("New", _CreateUnityEngine_UI_Image),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("sprite", get_sprite, set_sprite),
			new LuaField("overrideSprite", get_overrideSprite, set_overrideSprite),
			new LuaField("type", get_type, set_type),
			new LuaField("preserveAspect", get_preserveAspect, set_preserveAspect),
			new LuaField("fillCenter", get_fillCenter, set_fillCenter),
			new LuaField("fillMethod", get_fillMethod, set_fillMethod),
			new LuaField("fillAmount", get_fillAmount, set_fillAmount),
			new LuaField("fillClockwise", get_fillClockwise, set_fillClockwise),
			new LuaField("fillOrigin", get_fillOrigin, set_fillOrigin),
			new LuaField("eventAlphaThreshold", get_eventAlphaThreshold, set_eventAlphaThreshold),
			new LuaField("mainTexture", get_mainTexture, null),
			new LuaField("hasBorder", get_hasBorder, null),
			new LuaField("pixelsPerUnit", get_pixelsPerUnit, null),
			new LuaField("minWidth", get_minWidth, null),
			new LuaField("preferredWidth", get_preferredWidth, null),
			new LuaField("flexibleWidth", get_flexibleWidth, null),
			new LuaField("minHeight", get_minHeight, null),
			new LuaField("preferredHeight", get_preferredHeight, null),
			new LuaField("flexibleHeight", get_flexibleHeight, null),
			new LuaField("layoutPriority", get_layoutPriority, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.UI.Image", typeof(UnityEngine.UI.Image), regs, fields, typeof(UnityEngine.UI.MaskableGraphic));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_UI_Image(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UnityEngine.UI.Image class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UnityEngine.UI.Image);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sprite(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sprite");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sprite on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sprite);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_overrideSprite(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name overrideSprite");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index overrideSprite on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.overrideSprite);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index type on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.type);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preserveAspect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name preserveAspect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index preserveAspect on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.preserveAspect);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fillCenter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillCenter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillCenter on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fillCenter);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fillMethod(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillMethod");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillMethod on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fillMethod);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fillAmount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillAmount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillAmount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fillAmount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fillClockwise(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillClockwise");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillClockwise on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fillClockwise);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fillOrigin(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillOrigin");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillOrigin on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fillOrigin);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_eventAlphaThreshold(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name eventAlphaThreshold");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index eventAlphaThreshold on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.eventAlphaThreshold);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mainTexture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mainTexture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mainTexture on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.mainTexture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasBorder(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name hasBorder");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index hasBorder on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.hasBorder);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pixelsPerUnit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pixelsPerUnit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pixelsPerUnit on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.pixelsPerUnit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minWidth on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.minWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preferredWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name preferredWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index preferredWidth on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.preferredWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flexibleWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name flexibleWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index flexibleWidth on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.flexibleWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minHeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.minHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preferredHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name preferredHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index preferredHeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.preferredHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flexibleHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name flexibleHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index flexibleHeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.flexibleHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layoutPriority(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name layoutPriority");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index layoutPriority on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.layoutPriority);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sprite(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sprite");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sprite on a nil value");
			}
		}

		obj.sprite = (Sprite)LuaScriptMgr.GetUnityObject(L, 3, typeof(Sprite));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_overrideSprite(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name overrideSprite");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index overrideSprite on a nil value");
			}
		}

		obj.overrideSprite = (Sprite)LuaScriptMgr.GetUnityObject(L, 3, typeof(Sprite));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index type on a nil value");
			}
		}

		obj.type = (UnityEngine.UI.Image.Type)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.Image.Type));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_preserveAspect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name preserveAspect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index preserveAspect on a nil value");
			}
		}

		obj.preserveAspect = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fillCenter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillCenter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillCenter on a nil value");
			}
		}

		obj.fillCenter = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fillMethod(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillMethod");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillMethod on a nil value");
			}
		}

		obj.fillMethod = (UnityEngine.UI.Image.FillMethod)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.UI.Image.FillMethod));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fillAmount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillAmount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillAmount on a nil value");
			}
		}

		obj.fillAmount = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fillClockwise(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillClockwise");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillClockwise on a nil value");
			}
		}

		obj.fillClockwise = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fillOrigin(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fillOrigin");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fillOrigin on a nil value");
			}
		}

		obj.fillOrigin = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_eventAlphaThreshold(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name eventAlphaThreshold");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index eventAlphaThreshold on a nil value");
			}
		}

		obj.eventAlphaThreshold = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBeforeSerialize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Image");
		obj.OnBeforeSerialize();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnAfterDeserialize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Image");
		obj.OnAfterDeserialize();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetNativeSize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Image");
		obj.SetNativeSize();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateLayoutInputHorizontal(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Image");
		obj.CalculateLayoutInputHorizontal();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateLayoutInputVertical(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Image");
		obj.CalculateLayoutInputVertical();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsRaycastLocationValid(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UnityEngine.UI.Image obj = (UnityEngine.UI.Image)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Image");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Camera arg1 = (Camera)LuaScriptMgr.GetUnityObject(L, 3, typeof(Camera));
		bool o = obj.IsRaycastLocationValid(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
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

