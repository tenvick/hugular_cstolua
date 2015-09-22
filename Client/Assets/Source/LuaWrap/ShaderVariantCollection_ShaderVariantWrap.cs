using System;
using UnityEngine;
using LuaInterface;

public class ShaderVariantCollection_ShaderVariantWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateShaderVariantCollection_ShaderVariant),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("shader", get_shader, set_shader),
			new LuaField("passType", get_passType, set_passType),
			new LuaField("keywords", get_keywords, set_keywords),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ShaderVariantCollection.ShaderVariant", typeof(ShaderVariantCollection.ShaderVariant), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateShaderVariantCollection_ShaderVariant(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (LuaScriptMgr.CheckTypes(L, 1, typeof(Shader), typeof(UnityEngine.Rendering.PassType)) && LuaScriptMgr.CheckParamsType(L, typeof(string), 3, count - 2))
		{
			Shader arg0 = (Shader)LuaScriptMgr.GetUnityObject(L, 1, typeof(Shader));
			UnityEngine.Rendering.PassType arg1 = (UnityEngine.Rendering.PassType)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.PassType));
			string[] objs2 = LuaScriptMgr.GetParamsString(L, 3, count - 2);
			ShaderVariantCollection.ShaderVariant obj = new ShaderVariantCollection.ShaderVariant(arg0,arg1,objs2);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 0)
		{
			ShaderVariantCollection.ShaderVariant obj = new ShaderVariantCollection.ShaderVariant();
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ShaderVariantCollection.ShaderVariant.New");
		}

		return 0;
	}

	static Type classType = typeof(ShaderVariantCollection.ShaderVariant);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shader(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shader");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shader on a nil value");
			}
		}

		ShaderVariantCollection.ShaderVariant obj = (ShaderVariantCollection.ShaderVariant)o;
		LuaScriptMgr.Push(L, obj.shader);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_passType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name passType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index passType on a nil value");
			}
		}

		ShaderVariantCollection.ShaderVariant obj = (ShaderVariantCollection.ShaderVariant)o;
		LuaScriptMgr.Push(L, obj.passType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_keywords(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name keywords");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index keywords on a nil value");
			}
		}

		ShaderVariantCollection.ShaderVariant obj = (ShaderVariantCollection.ShaderVariant)o;
		LuaScriptMgr.PushArray(L, obj.keywords);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shader(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shader");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shader on a nil value");
			}
		}

		ShaderVariantCollection.ShaderVariant obj = (ShaderVariantCollection.ShaderVariant)o;
		obj.shader = (Shader)LuaScriptMgr.GetUnityObject(L, 3, typeof(Shader));
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_passType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name passType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index passType on a nil value");
			}
		}

		ShaderVariantCollection.ShaderVariant obj = (ShaderVariantCollection.ShaderVariant)o;
		obj.passType = (UnityEngine.Rendering.PassType)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.PassType));
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_keywords(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name keywords");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index keywords on a nil value");
			}
		}

		ShaderVariantCollection.ShaderVariant obj = (ShaderVariantCollection.ShaderVariant)o;
		obj.keywords = LuaScriptMgr.GetArrayString(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}
}

