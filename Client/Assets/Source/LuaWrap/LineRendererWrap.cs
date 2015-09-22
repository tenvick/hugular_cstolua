using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class LineRendererWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("SetWidth", SetWidth),
			new LuaMethod("SetColors", SetColors),
			new LuaMethod("SetVertexCount", SetVertexCount),
			new LuaMethod("SetPosition", SetPosition),
			new LuaMethod("New", _CreateLineRenderer),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("useWorldSpace", get_useWorldSpace, set_useWorldSpace),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.LineRenderer", typeof(LineRenderer), regs, fields, typeof(Renderer));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLineRenderer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LineRenderer obj = new LineRenderer();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LineRenderer.New");
		}

		return 0;
	}

	static Type classType = typeof(LineRenderer);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useWorldSpace(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LineRenderer obj = (LineRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useWorldSpace");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useWorldSpace on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useWorldSpace);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useWorldSpace(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LineRenderer obj = (LineRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useWorldSpace");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useWorldSpace on a nil value");
			}
		}

		obj.useWorldSpace = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetWidth(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		LineRenderer obj = (LineRenderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "LineRenderer");
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		obj.SetWidth(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetColors(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		LineRenderer obj = (LineRenderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "LineRenderer");
		Color arg0 = LuaScriptMgr.GetColor(L, 2);
		Color arg1 = LuaScriptMgr.GetColor(L, 3);
		obj.SetColors(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetVertexCount(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		LineRenderer obj = (LineRenderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "LineRenderer");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.SetVertexCount(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPosition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		LineRenderer obj = (LineRenderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "LineRenderer");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 3);
		obj.SetPosition(arg0,arg1);
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

