using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UnityEngine_UI_GraphicWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("SetAllDirty", SetAllDirty),
			new LuaMethod("SetLayoutDirty", SetLayoutDirty),
			new LuaMethod("SetVerticesDirty", SetVerticesDirty),
			new LuaMethod("SetMaterialDirty", SetMaterialDirty),
			new LuaMethod("Rebuild", Rebuild),
			new LuaMethod("SetNativeSize", SetNativeSize),
			new LuaMethod("Raycast", Raycast),
			new LuaMethod("PixelAdjustPoint", PixelAdjustPoint),
			new LuaMethod("GetPixelAdjustedRect", GetPixelAdjustedRect),
			new LuaMethod("CrossFadeColor", CrossFadeColor),
			new LuaMethod("CrossFadeAlpha", CrossFadeAlpha),
			new LuaMethod("RegisterDirtyLayoutCallback", RegisterDirtyLayoutCallback),
			new LuaMethod("UnregisterDirtyLayoutCallback", UnregisterDirtyLayoutCallback),
			new LuaMethod("RegisterDirtyVerticesCallback", RegisterDirtyVerticesCallback),
			new LuaMethod("UnregisterDirtyVerticesCallback", UnregisterDirtyVerticesCallback),
			new LuaMethod("RegisterDirtyMaterialCallback", RegisterDirtyMaterialCallback),
			new LuaMethod("UnregisterDirtyMaterialCallback", UnregisterDirtyMaterialCallback),
			new LuaMethod("New", _CreateUnityEngine_UI_Graphic),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("defaultGraphicMaterial", get_defaultGraphicMaterial, null),
			new LuaField("color", get_color, set_color),
			new LuaField("depth", get_depth, null),
			new LuaField("rectTransform", get_rectTransform, null),
			new LuaField("canvas", get_canvas, null),
			new LuaField("canvasRenderer", get_canvasRenderer, null),
			new LuaField("defaultMaterial", get_defaultMaterial, null),
			new LuaField("material", get_material, set_material),
			new LuaField("materialForRendering", get_materialForRendering, null),
			new LuaField("mainTexture", get_mainTexture, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.UI.Graphic", typeof(UnityEngine.UI.Graphic), regs, fields, typeof(UnityEngine.EventSystems.UIBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_UI_Graphic(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UnityEngine.UI.Graphic class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UnityEngine.UI.Graphic);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultGraphicMaterial(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.UI.Graphic.defaultGraphicMaterial);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_color(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name color");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index color on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.color);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name depth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index depth on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.depth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rectTransform(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rectTransform");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rectTransform on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.rectTransform);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canvas(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name canvas");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index canvas on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.canvas);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canvasRenderer(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name canvasRenderer");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index canvasRenderer on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.canvasRenderer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultMaterial(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name defaultMaterial");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index defaultMaterial on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.defaultMaterial);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name material");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index material on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.material);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_materialForRendering(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name materialForRendering");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index materialForRendering on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.materialForRendering);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mainTexture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

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
	static int set_color(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name color");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index color on a nil value");
			}
		}

		obj.color = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name material");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index material on a nil value");
			}
		}

		obj.material = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAllDirty(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		obj.SetAllDirty();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayoutDirty(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		obj.SetLayoutDirty();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetVerticesDirty(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		obj.SetVerticesDirty();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetMaterialDirty(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		obj.SetMaterialDirty();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebuild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.UI.CanvasUpdate));
		obj.Rebuild(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetNativeSize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		obj.SetNativeSize();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Raycast(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Camera arg1 = (Camera)LuaScriptMgr.GetUnityObject(L, 3, typeof(Camera));
		bool o = obj.Raycast(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PixelAdjustPoint(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Vector2 o = obj.PixelAdjustPoint(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixelAdjustedRect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		Rect o = obj.GetPixelAdjustedRect();
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeColor(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 5);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		Color arg0 = LuaScriptMgr.GetColor(L, 2);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		bool arg2 = LuaScriptMgr.GetBoolean(L, 4);
		bool arg3 = LuaScriptMgr.GetBoolean(L, 5);
		obj.CrossFadeColor(arg0,arg1,arg2,arg3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeAlpha(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		bool arg2 = LuaScriptMgr.GetBoolean(L, 4);
		obj.CrossFadeAlpha(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterDirtyLayoutCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		UnityEngine.Events.UnityAction arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UnityEngine.Events.UnityAction)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Events.UnityAction));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = () =>
			{
				func.Call();
			};
		}

		obj.RegisterDirtyLayoutCallback(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterDirtyLayoutCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		UnityEngine.Events.UnityAction arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UnityEngine.Events.UnityAction)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Events.UnityAction));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = () =>
			{
				func.Call();
			};
		}

		obj.UnregisterDirtyLayoutCallback(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterDirtyVerticesCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		UnityEngine.Events.UnityAction arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UnityEngine.Events.UnityAction)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Events.UnityAction));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = () =>
			{
				func.Call();
			};
		}

		obj.RegisterDirtyVerticesCallback(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterDirtyVerticesCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		UnityEngine.Events.UnityAction arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UnityEngine.Events.UnityAction)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Events.UnityAction));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = () =>
			{
				func.Call();
			};
		}

		obj.UnregisterDirtyVerticesCallback(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterDirtyMaterialCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		UnityEngine.Events.UnityAction arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UnityEngine.Events.UnityAction)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Events.UnityAction));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = () =>
			{
				func.Call();
			};
		}

		obj.RegisterDirtyMaterialCallback(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterDirtyMaterialCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.Graphic");
		UnityEngine.Events.UnityAction arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UnityEngine.Events.UnityAction)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Events.UnityAction));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = () =>
			{
				func.Call();
			};
		}

		obj.UnregisterDirtyMaterialCallback(arg0);
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

