using System;
using UnityEngine;
using LuaInterface;

public class DisplayWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Activate", Activate),
			new LuaMethod("SetParams", SetParams),
			new LuaMethod("SetRenderingResolution", SetRenderingResolution),
			new LuaMethod("MultiDisplayLicense", MultiDisplayLicense),
			new LuaMethod("RelativeMouseAt", RelativeMouseAt),
			new LuaMethod("New", _CreateDisplay),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("displays", get_displays, set_displays),
			new LuaField("renderingWidth", get_renderingWidth, null),
			new LuaField("renderingHeight", get_renderingHeight, null),
			new LuaField("systemWidth", get_systemWidth, null),
			new LuaField("systemHeight", get_systemHeight, null),
			new LuaField("colorBuffer", get_colorBuffer, null),
			new LuaField("depthBuffer", get_depthBuffer, null),
			new LuaField("main", get_main, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Display", typeof(Display), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDisplay(IntPtr L)
	{
		LuaDLL.luaL_error(L, "Display class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(Display);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_displays(IntPtr L)
	{
		LuaScriptMgr.PushArray(L, Display.displays);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderingWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Display obj = (Display)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name renderingWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index renderingWidth on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.renderingWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderingHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Display obj = (Display)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name renderingHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index renderingHeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.renderingHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_systemWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Display obj = (Display)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name systemWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index systemWidth on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.systemWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_systemHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Display obj = (Display)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name systemHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index systemHeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.systemHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colorBuffer(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Display obj = (Display)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name colorBuffer");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index colorBuffer on a nil value");
			}
		}

		LuaScriptMgr.PushValue(L, obj.colorBuffer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depthBuffer(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Display obj = (Display)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name depthBuffer");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index depthBuffer on a nil value");
			}
		}

		LuaScriptMgr.PushValue(L, obj.depthBuffer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_main(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, Display.main);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_displays(IntPtr L)
	{
		Display.displays = LuaScriptMgr.GetArrayObject<Display>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Activate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Display obj = (Display)LuaScriptMgr.GetNetObjectSelf(L, 1, "Display");
			obj.Activate();
			return 0;
		}
		else if (count == 4)
		{
			Display obj = (Display)LuaScriptMgr.GetNetObjectSelf(L, 1, "Display");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			obj.Activate(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Display.Activate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetParams(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 5);
		Display obj = (Display)LuaScriptMgr.GetNetObjectSelf(L, 1, "Display");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
		int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
		obj.SetParams(arg0,arg1,arg2,arg3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRenderingResolution(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Display obj = (Display)LuaScriptMgr.GetNetObjectSelf(L, 1, "Display");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		obj.SetRenderingResolution(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MultiDisplayLicense(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		bool o = Display.MultiDisplayLicense();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RelativeMouseAt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		Vector3 o = Display.RelativeMouseAt(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

