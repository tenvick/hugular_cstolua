using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UnityEngine_UI_MaskableGraphicWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("ParentMaskStateChanged", ParentMaskStateChanged),
			new LuaMethod("SetMaterialDirty", SetMaterialDirty),
			new LuaMethod("New", _CreateUnityEngine_UI_MaskableGraphic),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("maskable", get_maskable, set_maskable),
			new LuaField("material", get_material, set_material),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.UI.MaskableGraphic", typeof(UnityEngine.UI.MaskableGraphic), regs, fields, typeof(UnityEngine.UI.Graphic));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_UI_MaskableGraphic(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UnityEngine.UI.MaskableGraphic class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UnityEngine.UI.MaskableGraphic);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maskable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maskable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maskable on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.maskable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;

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
	static int set_maskable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maskable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maskable on a nil value");
			}
		}

		obj.maskable = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;

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
	static int ParentMaskStateChanged(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.MaskableGraphic");
		obj.ParentMaskStateChanged();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetMaterialDirty(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.UI.MaskableGraphic");
		obj.SetMaterialDirty();
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

