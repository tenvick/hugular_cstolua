﻿using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class AreaEffector2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateAreaEffector2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("forceAngle", get_forceAngle, set_forceAngle),
			new LuaField("useGlobalAngle", get_useGlobalAngle, set_useGlobalAngle),
			new LuaField("forceMagnitude", get_forceMagnitude, set_forceMagnitude),
			new LuaField("forceVariation", get_forceVariation, set_forceVariation),
			new LuaField("drag", get_drag, set_drag),
			new LuaField("angularDrag", get_angularDrag, set_angularDrag),
			new LuaField("forceTarget", get_forceTarget, set_forceTarget),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AreaEffector2D", typeof(AreaEffector2D), regs, fields, typeof(Effector2D));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAreaEffector2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			AreaEffector2D obj = new AreaEffector2D();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AreaEffector2D.New");
		}

		return 0;
	}

	static Type classType = typeof(AreaEffector2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forceAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceAngle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.forceAngle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useGlobalAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useGlobalAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useGlobalAngle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useGlobalAngle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forceMagnitude(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceMagnitude");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceMagnitude on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.forceMagnitude);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forceVariation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceVariation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceVariation on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.forceVariation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drag on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.drag);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_angularDrag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name angularDrag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index angularDrag on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.angularDrag);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forceTarget(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceTarget");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceTarget on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.forceTarget);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forceAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceAngle on a nil value");
			}
		}

		obj.forceAngle = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useGlobalAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useGlobalAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useGlobalAngle on a nil value");
			}
		}

		obj.useGlobalAngle = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forceMagnitude(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceMagnitude");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceMagnitude on a nil value");
			}
		}

		obj.forceMagnitude = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forceVariation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceVariation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceVariation on a nil value");
			}
		}

		obj.forceVariation = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_drag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drag on a nil value");
			}
		}

		obj.drag = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_angularDrag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name angularDrag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index angularDrag on a nil value");
			}
		}

		obj.angularDrag = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forceTarget(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AreaEffector2D obj = (AreaEffector2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name forceTarget");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index forceTarget on a nil value");
			}
		}

		obj.forceTarget = (EffectorSelection2D)LuaScriptMgr.GetNetObject(L, 3, typeof(EffectorSelection2D));
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
