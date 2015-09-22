using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class Texture3DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetPixels", GetPixels),
			new LuaMethod("SetPixels", SetPixels),
			new LuaMethod("Apply", Apply),
			new LuaMethod("New", _CreateTexture3D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("depth", get_depth, null),
			new LuaField("format", get_format, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Texture3D", typeof(Texture3D), regs, fields, typeof(Texture));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTexture3D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 5)
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			TextureFormat arg3 = (TextureFormat)LuaScriptMgr.GetNetObject(L, 4, typeof(TextureFormat));
			bool arg4 = LuaScriptMgr.GetBoolean(L, 5);
			Texture3D obj = new Texture3D(arg0,arg1,arg2,arg3,arg4);
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Texture3D.New");
		}

		return 0;
	}

	static Type classType = typeof(Texture3D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture3D obj = (Texture3D)o;

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
	static int get_format(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture3D obj = (Texture3D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name format");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index format on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.format);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixels(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Texture3D obj = (Texture3D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Texture3D");
			Color[] o = obj.GetPixels();
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 2)
		{
			Texture3D obj = (Texture3D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Texture3D");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			Color[] o = obj.GetPixels(arg0);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Texture3D.GetPixels");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixels(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Texture3D obj = (Texture3D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Texture3D");
			Color[] objs0 = LuaScriptMgr.GetArrayObject<Color>(L, 2);
			obj.SetPixels(objs0);
			return 0;
		}
		else if (count == 3)
		{
			Texture3D obj = (Texture3D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Texture3D");
			Color[] objs0 = LuaScriptMgr.GetArrayObject<Color>(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			obj.SetPixels(objs0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Texture3D.SetPixels");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Apply(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Texture3D obj = (Texture3D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Texture3D");
			obj.Apply();
			return 0;
		}
		else if (count == 2)
		{
			Texture3D obj = (Texture3D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Texture3D");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			obj.Apply(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Texture3D.Apply");
		}

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

