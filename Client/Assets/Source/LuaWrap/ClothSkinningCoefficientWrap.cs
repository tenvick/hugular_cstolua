using System;
using UnityEngine;
using LuaInterface;

public class ClothSkinningCoefficientWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateClothSkinningCoefficient),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("maxDistance", get_maxDistance, set_maxDistance),
			new LuaField("collisionSphereDistance", get_collisionSphereDistance, set_collisionSphereDistance),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ClothSkinningCoefficient", typeof(ClothSkinningCoefficient), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateClothSkinningCoefficient(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		ClothSkinningCoefficient obj = new ClothSkinningCoefficient();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(ClothSkinningCoefficient);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxDistance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxDistance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxDistance on a nil value");
			}
		}

		ClothSkinningCoefficient obj = (ClothSkinningCoefficient)o;
		LuaScriptMgr.Push(L, obj.maxDistance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_collisionSphereDistance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name collisionSphereDistance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index collisionSphereDistance on a nil value");
			}
		}

		ClothSkinningCoefficient obj = (ClothSkinningCoefficient)o;
		LuaScriptMgr.Push(L, obj.collisionSphereDistance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxDistance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxDistance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxDistance on a nil value");
			}
		}

		ClothSkinningCoefficient obj = (ClothSkinningCoefficient)o;
		obj.maxDistance = (float)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_collisionSphereDistance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name collisionSphereDistance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index collisionSphereDistance on a nil value");
			}
		}

		ClothSkinningCoefficient obj = (ClothSkinningCoefficient)o;
		obj.collisionSphereDistance = (float)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}
}

