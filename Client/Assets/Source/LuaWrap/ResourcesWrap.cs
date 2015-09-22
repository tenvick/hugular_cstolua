using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ResourcesWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("FindObjectsOfTypeAll", FindObjectsOfTypeAll),
			new LuaMethod("Load", Load),
			new LuaMethod("LoadAsync", LoadAsync),
			new LuaMethod("LoadAll", LoadAll),
			new LuaMethod("GetBuiltinResource", GetBuiltinResource),
			new LuaMethod("UnloadAsset", UnloadAsset),
			new LuaMethod("UnloadUnusedAssets", UnloadUnusedAssets),
			new LuaMethod("New", _CreateResources),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Resources", typeof(Resources), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateResources(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Resources obj = new Resources();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Resources.New");
		}

		return 0;
	}

	static Type classType = typeof(Resources);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindObjectsOfTypeAll(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Type arg0 = LuaScriptMgr.GetTypeObject(L, 1);
		Object[] o = Resources.FindObjectsOfTypeAll(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Load(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			Object o = Resources.Load(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			Type arg1 = LuaScriptMgr.GetTypeObject(L, 2);
			Object o = Resources.Load(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Resources.Load");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAsync(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			ResourceRequest o = Resources.LoadAsync(arg0);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 2)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			Type arg1 = LuaScriptMgr.GetTypeObject(L, 2);
			ResourceRequest o = Resources.LoadAsync(arg0,arg1);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Resources.LoadAsync");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAll(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			Object[] o = Resources.LoadAll(arg0);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 2)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			Type arg1 = LuaScriptMgr.GetTypeObject(L, 2);
			Object[] o = Resources.LoadAll(arg0,arg1);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Resources.LoadAll");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBuiltinResource(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Type arg0 = LuaScriptMgr.GetTypeObject(L, 1);
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Object o = Resources.GetBuiltinResource(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadAsset(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
		Resources.UnloadAsset(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadUnusedAssets(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		AsyncOperation o = Resources.UnloadUnusedAssets();
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}
}

