using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class AssetBundleManifestWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetAllAssetBundles", GetAllAssetBundles),
			new LuaMethod("GetAllAssetBundlesWithVariant", GetAllAssetBundlesWithVariant),
			new LuaMethod("GetAssetBundleHash", GetAssetBundleHash),
			new LuaMethod("GetDirectDependencies", GetDirectDependencies),
			new LuaMethod("GetAllDependencies", GetAllDependencies),
			new LuaMethod("New", _CreateAssetBundleManifest),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AssetBundleManifest", typeof(AssetBundleManifest), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAssetBundleManifest(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			AssetBundleManifest obj = new AssetBundleManifest();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AssetBundleManifest.New");
		}

		return 0;
	}

	static Type classType = typeof(AssetBundleManifest);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllAssetBundles(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		AssetBundleManifest obj = (AssetBundleManifest)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AssetBundleManifest");
		string[] o = obj.GetAllAssetBundles();
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllAssetBundlesWithVariant(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		AssetBundleManifest obj = (AssetBundleManifest)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AssetBundleManifest");
		string[] o = obj.GetAllAssetBundlesWithVariant();
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAssetBundleHash(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AssetBundleManifest obj = (AssetBundleManifest)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AssetBundleManifest");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		Hash128 o = obj.GetAssetBundleHash(arg0);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDirectDependencies(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AssetBundleManifest obj = (AssetBundleManifest)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AssetBundleManifest");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		string[] o = obj.GetDirectDependencies(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllDependencies(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AssetBundleManifest obj = (AssetBundleManifest)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AssetBundleManifest");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		string[] o = obj.GetAllDependencies(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
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

