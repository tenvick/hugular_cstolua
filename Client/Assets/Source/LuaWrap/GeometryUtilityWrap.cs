using System;
using UnityEngine;
using LuaInterface;

public class GeometryUtilityWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("CalculateFrustumPlanes", CalculateFrustumPlanes),
			new LuaMethod("TestPlanesAABB", TestPlanesAABB),
			new LuaMethod("New", _CreateGeometryUtility),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.GeometryUtility", typeof(GeometryUtility), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGeometryUtility(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			GeometryUtility obj = new GeometryUtility();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: GeometryUtility.New");
		}

		return 0;
	}

	static Type classType = typeof(GeometryUtility);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateFrustumPlanes(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Matrix4x4)))
		{
			Matrix4x4 arg0 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 1);
			Plane[] o = GeometryUtility.CalculateFrustumPlanes(arg0);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Camera)))
		{
			Camera arg0 = (Camera)LuaScriptMgr.GetLuaObject(L, 1);
			Plane[] o = GeometryUtility.CalculateFrustumPlanes(arg0);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: GeometryUtility.CalculateFrustumPlanes");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestPlanesAABB(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Plane[] objs0 = LuaScriptMgr.GetArrayObject<Plane>(L, 1);
		Bounds arg1 = LuaScriptMgr.GetBounds(L, 2);
		bool o = GeometryUtility.TestPlanesAABB(objs0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

