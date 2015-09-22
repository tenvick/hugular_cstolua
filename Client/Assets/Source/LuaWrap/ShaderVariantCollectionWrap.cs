using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ShaderVariantCollectionWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Add", Add),
			new LuaMethod("Remove", Remove),
			new LuaMethod("Contains", Contains),
			new LuaMethod("Clear", Clear),
			new LuaMethod("WarmUp", WarmUp),
			new LuaMethod("New", _CreateShaderVariantCollection),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("shaderCount", get_shaderCount, null),
			new LuaField("variantCount", get_variantCount, null),
			new LuaField("isWarmedUp", get_isWarmedUp, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ShaderVariantCollection", typeof(ShaderVariantCollection), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateShaderVariantCollection(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			ShaderVariantCollection obj = new ShaderVariantCollection();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ShaderVariantCollection.New");
		}

		return 0;
	}

	static Type classType = typeof(ShaderVariantCollection);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shaderCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ShaderVariantCollection obj = (ShaderVariantCollection)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shaderCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shaderCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shaderCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_variantCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ShaderVariantCollection obj = (ShaderVariantCollection)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name variantCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index variantCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.variantCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isWarmedUp(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ShaderVariantCollection obj = (ShaderVariantCollection)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isWarmedUp");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isWarmedUp on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isWarmedUp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		ShaderVariantCollection obj = (ShaderVariantCollection)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ShaderVariantCollection");
		ShaderVariantCollection.ShaderVariant arg0 = (ShaderVariantCollection.ShaderVariant)LuaScriptMgr.GetNetObject(L, 2, typeof(ShaderVariantCollection.ShaderVariant));
		bool o = obj.Add(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Remove(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		ShaderVariantCollection obj = (ShaderVariantCollection)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ShaderVariantCollection");
		ShaderVariantCollection.ShaderVariant arg0 = (ShaderVariantCollection.ShaderVariant)LuaScriptMgr.GetNetObject(L, 2, typeof(ShaderVariantCollection.ShaderVariant));
		bool o = obj.Remove(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Contains(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		ShaderVariantCollection obj = (ShaderVariantCollection)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ShaderVariantCollection");
		ShaderVariantCollection.ShaderVariant arg0 = (ShaderVariantCollection.ShaderVariant)LuaScriptMgr.GetNetObject(L, 2, typeof(ShaderVariantCollection.ShaderVariant));
		bool o = obj.Contains(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		ShaderVariantCollection obj = (ShaderVariantCollection)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ShaderVariantCollection");
		obj.Clear();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WarmUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		ShaderVariantCollection obj = (ShaderVariantCollection)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ShaderVariantCollection");
		obj.WarmUp();
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

