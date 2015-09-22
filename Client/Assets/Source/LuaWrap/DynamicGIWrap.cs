using System;
using UnityEngine;
using LuaInterface;

public class DynamicGIWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("SetEmissive", SetEmissive),
			new LuaMethod("UpdateMaterials", UpdateMaterials),
			new LuaMethod("UpdateEnvironment", UpdateEnvironment),
			new LuaMethod("New", _CreateDynamicGI),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("indirectScale", get_indirectScale, set_indirectScale),
			new LuaField("updateThreshold", get_updateThreshold, set_updateThreshold),
			new LuaField("synchronousMode", get_synchronousMode, set_synchronousMode),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.DynamicGI", typeof(DynamicGI), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDynamicGI(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			DynamicGI obj = new DynamicGI();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: DynamicGI.New");
		}

		return 0;
	}

	static Type classType = typeof(DynamicGI);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_indirectScale(IntPtr L)
	{
		LuaScriptMgr.Push(L, DynamicGI.indirectScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateThreshold(IntPtr L)
	{
		LuaScriptMgr.Push(L, DynamicGI.updateThreshold);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_synchronousMode(IntPtr L)
	{
		LuaScriptMgr.Push(L, DynamicGI.synchronousMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_indirectScale(IntPtr L)
	{
		DynamicGI.indirectScale = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updateThreshold(IntPtr L)
	{
		DynamicGI.updateThreshold = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_synchronousMode(IntPtr L)
	{
		DynamicGI.synchronousMode = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetEmissive(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Renderer arg0 = (Renderer)LuaScriptMgr.GetUnityObject(L, 1, typeof(Renderer));
		Color arg1 = LuaScriptMgr.GetColor(L, 2);
		DynamicGI.SetEmissive(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateMaterials(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Terrain)))
		{
			Terrain arg0 = (Terrain)LuaScriptMgr.GetLuaObject(L, 1);
			DynamicGI.UpdateMaterials(arg0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Renderer)))
		{
			Renderer arg0 = (Renderer)LuaScriptMgr.GetLuaObject(L, 1);
			DynamicGI.UpdateMaterials(arg0);
			return 0;
		}
		else if (count == 5)
		{
			Terrain arg0 = (Terrain)LuaScriptMgr.GetUnityObject(L, 1, typeof(Terrain));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg4 = (int)LuaScriptMgr.GetNumber(L, 5);
			DynamicGI.UpdateMaterials(arg0,arg1,arg2,arg3,arg4);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: DynamicGI.UpdateMaterials");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateEnvironment(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		DynamicGI.UpdateEnvironment();
		return 0;
	}
}

