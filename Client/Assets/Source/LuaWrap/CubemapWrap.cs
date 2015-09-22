using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class CubemapWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("SetPixel", SetPixel),
			new LuaMethod("GetPixel", GetPixel),
			new LuaMethod("GetPixels", GetPixels),
			new LuaMethod("SetPixels", SetPixels),
			new LuaMethod("Apply", Apply),
			new LuaMethod("SmoothEdges", SmoothEdges),
			new LuaMethod("New", _CreateCubemap),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("format", get_format, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Cubemap", typeof(Cubemap), regs, fields, typeof(Texture));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCubemap(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			TextureFormat arg1 = (TextureFormat)LuaScriptMgr.GetNetObject(L, 2, typeof(TextureFormat));
			bool arg2 = LuaScriptMgr.GetBoolean(L, 3);
			Cubemap obj = new Cubemap(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Cubemap.New");
		}

		return 0;
	}

	static Type classType = typeof(Cubemap);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_format(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cubemap obj = (Cubemap)o;

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
	static int SetPixel(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 5);
		Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
		CubemapFace arg0 = (CubemapFace)LuaScriptMgr.GetNetObject(L, 2, typeof(CubemapFace));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
		Color arg3 = LuaScriptMgr.GetColor(L, 5);
		obj.SetPixel(arg0,arg1,arg2,arg3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixel(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
		CubemapFace arg0 = (CubemapFace)LuaScriptMgr.GetNetObject(L, 2, typeof(CubemapFace));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
		Color o = obj.GetPixel(arg0,arg1,arg2);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixels(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
			CubemapFace arg0 = (CubemapFace)LuaScriptMgr.GetNetObject(L, 2, typeof(CubemapFace));
			Color[] o = obj.GetPixels(arg0);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 3)
		{
			Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
			CubemapFace arg0 = (CubemapFace)LuaScriptMgr.GetNetObject(L, 2, typeof(CubemapFace));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			Color[] o = obj.GetPixels(arg0,arg1);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Cubemap.GetPixels");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixels(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
			Color[] objs0 = LuaScriptMgr.GetArrayObject<Color>(L, 2);
			CubemapFace arg1 = (CubemapFace)LuaScriptMgr.GetNetObject(L, 3, typeof(CubemapFace));
			obj.SetPixels(objs0,arg1);
			return 0;
		}
		else if (count == 4)
		{
			Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
			Color[] objs0 = LuaScriptMgr.GetArrayObject<Color>(L, 2);
			CubemapFace arg1 = (CubemapFace)LuaScriptMgr.GetNetObject(L, 3, typeof(CubemapFace));
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			obj.SetPixels(objs0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Cubemap.SetPixels");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Apply(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
			obj.Apply();
			return 0;
		}
		else if (count == 2)
		{
			Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			obj.Apply(arg0);
			return 0;
		}
		else if (count == 3)
		{
			Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
			obj.Apply(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Cubemap.Apply");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SmoothEdges(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
			obj.SmoothEdges();
			return 0;
		}
		else if (count == 2)
		{
			Cubemap obj = (Cubemap)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cubemap");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			obj.SmoothEdges(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Cubemap.SmoothEdges");
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

