using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class BillboardAssetWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateBillboardAsset),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("width", get_width, set_width),
			new LuaField("height", get_height, set_height),
			new LuaField("bottom", get_bottom, set_bottom),
			new LuaField("imageCount", get_imageCount, null),
			new LuaField("vertexCount", get_vertexCount, null),
			new LuaField("indexCount", get_indexCount, null),
			new LuaField("material", get_material, set_material),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.BillboardAsset", typeof(BillboardAsset), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateBillboardAsset(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			BillboardAsset obj = new BillboardAsset();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: BillboardAsset.New");
		}

		return 0;
	}

	static Type classType = typeof(BillboardAsset);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name width");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index width on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.width);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name height");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index height on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.height);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bottom(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bottom");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bottom on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bottom);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_imageCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name imageCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index imageCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.imageCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_vertexCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name vertexCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index vertexCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.vertexCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_indexCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name indexCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index indexCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.indexCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

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
	static int set_width(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name width");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index width on a nil value");
			}
		}

		obj.width = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_height(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name height");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index height on a nil value");
			}
		}

		obj.height = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bottom(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bottom");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bottom on a nil value");
			}
		}

		obj.bottom = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardAsset obj = (BillboardAsset)o;

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

