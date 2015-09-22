using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ProjectorWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateProjector),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("nearClipPlane", get_nearClipPlane, set_nearClipPlane),
			new LuaField("farClipPlane", get_farClipPlane, set_farClipPlane),
			new LuaField("fieldOfView", get_fieldOfView, set_fieldOfView),
			new LuaField("aspectRatio", get_aspectRatio, set_aspectRatio),
			new LuaField("orthographic", get_orthographic, set_orthographic),
			new LuaField("orthographicSize", get_orthographicSize, set_orthographicSize),
			new LuaField("ignoreLayers", get_ignoreLayers, set_ignoreLayers),
			new LuaField("material", get_material, set_material),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Projector", typeof(Projector), regs, fields, typeof(Behaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateProjector(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Projector obj = new Projector();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Projector.New");
		}

		return 0;
	}

	static Type classType = typeof(Projector);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nearClipPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name nearClipPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index nearClipPlane on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.nearClipPlane);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_farClipPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name farClipPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index farClipPlane on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.farClipPlane);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fieldOfView(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fieldOfView");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fieldOfView on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fieldOfView);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_aspectRatio(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name aspectRatio");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index aspectRatio on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.aspectRatio);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_orthographic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name orthographic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index orthographic on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.orthographic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_orthographicSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name orthographicSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index orthographicSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.orthographicSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ignoreLayers(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ignoreLayers");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ignoreLayers on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.ignoreLayers);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

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
	static int set_nearClipPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name nearClipPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index nearClipPlane on a nil value");
			}
		}

		obj.nearClipPlane = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_farClipPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name farClipPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index farClipPlane on a nil value");
			}
		}

		obj.farClipPlane = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fieldOfView(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fieldOfView");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fieldOfView on a nil value");
			}
		}

		obj.fieldOfView = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_aspectRatio(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name aspectRatio");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index aspectRatio on a nil value");
			}
		}

		obj.aspectRatio = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_orthographic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name orthographic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index orthographic on a nil value");
			}
		}

		obj.orthographic = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_orthographicSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name orthographicSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index orthographicSize on a nil value");
			}
		}

		obj.orthographicSize = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ignoreLayers(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ignoreLayers");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ignoreLayers on a nil value");
			}
		}

		obj.ignoreLayers = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Projector obj = (Projector)o;

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

