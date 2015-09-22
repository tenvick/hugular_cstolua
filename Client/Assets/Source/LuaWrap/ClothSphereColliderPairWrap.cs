using System;
using UnityEngine;
using LuaInterface;

public class ClothSphereColliderPairWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateClothSphereColliderPair),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("first", get_first, set_first),
			new LuaField("second", get_second, set_second),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ClothSphereColliderPair", typeof(ClothSphereColliderPair), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateClothSphereColliderPair(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			SphereCollider arg0 = (SphereCollider)LuaScriptMgr.GetUnityObject(L, 1, typeof(SphereCollider));
			ClothSphereColliderPair obj = new ClothSphereColliderPair(arg0);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 2)
		{
			SphereCollider arg0 = (SphereCollider)LuaScriptMgr.GetUnityObject(L, 1, typeof(SphereCollider));
			SphereCollider arg1 = (SphereCollider)LuaScriptMgr.GetUnityObject(L, 2, typeof(SphereCollider));
			ClothSphereColliderPair obj = new ClothSphereColliderPair(arg0,arg1);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 0)
		{
			ClothSphereColliderPair obj = new ClothSphereColliderPair();
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ClothSphereColliderPair.New");
		}

		return 0;
	}

	static Type classType = typeof(ClothSphereColliderPair);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_first(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name first");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index first on a nil value");
			}
		}

		ClothSphereColliderPair obj = (ClothSphereColliderPair)o;
		LuaScriptMgr.Push(L, obj.first);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_second(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name second");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index second on a nil value");
			}
		}

		ClothSphereColliderPair obj = (ClothSphereColliderPair)o;
		LuaScriptMgr.Push(L, obj.second);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_first(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name first");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index first on a nil value");
			}
		}

		ClothSphereColliderPair obj = (ClothSphereColliderPair)o;
		obj.first = (SphereCollider)LuaScriptMgr.GetUnityObject(L, 3, typeof(SphereCollider));
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_second(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name second");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index second on a nil value");
			}
		}

		ClothSphereColliderPair obj = (ClothSphereColliderPair)o;
		obj.second = (SphereCollider)LuaScriptMgr.GetUnityObject(L, 3, typeof(SphereCollider));
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}
}

