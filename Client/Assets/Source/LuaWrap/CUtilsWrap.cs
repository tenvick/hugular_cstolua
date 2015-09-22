using System;
using System.Collections.Generic;
using LuaInterface;

public class CUtilsWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetURLFileSuffix", GetURLFileSuffix),
			new LuaMethod("GetURLFileName", GetURLFileName),
			new LuaMethod("GetKeyURLFileName", GetKeyURLFileName),
			new LuaMethod("GetURLFullFileName", GetURLFullFileName),
			new LuaMethod("GetFileFullPath", GetFileFullPath),
			new LuaMethod("GetAssetFullPath", GetAssetFullPath),
			new LuaMethod("GetFileFullPathNoProtocol", GetFileFullPathNoProtocol),
			new LuaMethod("GetDirectoryFullPathNoProtocol", GetDirectoryFullPathNoProtocol),
			new LuaMethod("GetAssetPath", GetAssetPath),
			new LuaMethod("GetPlatformFolderForAssetBundles", GetPlatformFolderForAssetBundles),
			new LuaMethod("Collect", Collect),
			new LuaMethod("Execute", Execute),
			new LuaMethod("New", _CreateCUtils),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("currPersistentExist", get_currPersistentExist, set_currPersistentExist),
			new LuaField("dataPath", get_dataPath, null),
		};

		LuaScriptMgr.RegisterLib(L, "CUtils", typeof(CUtils), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCUtils(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			CUtils obj = new CUtils();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: CUtils.New");
		}

		return 0;
	}

	static Type classType = typeof(CUtils);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currPersistentExist(IntPtr L)
	{
		LuaScriptMgr.Push(L, CUtils.currPersistentExist);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dataPath(IntPtr L)
	{
		LuaScriptMgr.Push(L, CUtils.dataPath);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_currPersistentExist(IntPtr L)
	{
		CUtils.currPersistentExist = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetURLFileSuffix(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CUtils.GetURLFileSuffix(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetURLFileName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CUtils.GetURLFileName(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetKeyURLFileName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CUtils.GetKeyURLFileName(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetURLFullFileName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CUtils.GetURLFullFileName(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileFullPath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CUtils.GetFileFullPath(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAssetFullPath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CUtils.GetAssetFullPath(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileFullPathNoProtocol(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CUtils.GetFileFullPathNoProtocol(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDirectoryFullPathNoProtocol(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CUtils.GetDirectoryFullPathNoProtocol(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAssetPath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CUtils.GetAssetPath(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPlatformFolderForAssetBundles(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		string o = CUtils.GetPlatformFolderForAssetBundles();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Collect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		CUtils.Collect();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Execute(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(BetterList<Action>)))
		{
			BetterList<Action> arg0 = (BetterList<Action>)LuaScriptMgr.GetLuaObject(L, 1);
			CUtils.Execute(arg0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(IList<Action>)))
		{
			IList<Action> arg0 = (IList<Action>)LuaScriptMgr.GetLuaObject(L, 1);
			CUtils.Execute(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: CUtils.Execute");
		}

		return 0;
	}
}

