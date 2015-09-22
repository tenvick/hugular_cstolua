using System;
using UnityEngine;
using LuaInterface;

public class HideFlagsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("None", GetNone),
		new LuaMethod("HideInHierarchy", GetHideInHierarchy),
		new LuaMethod("HideInInspector", GetHideInInspector),
		new LuaMethod("DontSaveInEditor", GetDontSaveInEditor),
		new LuaMethod("NotEditable", GetNotEditable),
		new LuaMethod("DontUnloadUnusedAsset", GetDontUnloadUnusedAsset),
		new LuaMethod("DontSaveInBuild", GetDontSaveInBuild),
		new LuaMethod("DontSave", GetDontSave),
		new LuaMethod("HideAndDontSave", GetHideAndDontSave),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.HideFlags", typeof(UnityEngine.HideFlags), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNone(IntPtr L)
	{
		LuaScriptMgr.Push(L, HideFlags.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHideInHierarchy(IntPtr L)
	{
		LuaScriptMgr.Push(L, HideFlags.HideInHierarchy);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHideInInspector(IntPtr L)
	{
		LuaScriptMgr.Push(L, HideFlags.HideInInspector);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDontSaveInEditor(IntPtr L)
	{
		LuaScriptMgr.Push(L, HideFlags.DontSaveInEditor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNotEditable(IntPtr L)
	{
		LuaScriptMgr.Push(L, HideFlags.NotEditable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDontUnloadUnusedAsset(IntPtr L)
	{
		LuaScriptMgr.Push(L, HideFlags.DontUnloadUnusedAsset);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDontSaveInBuild(IntPtr L)
	{
		LuaScriptMgr.Push(L, HideFlags.DontSaveInBuild);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDontSave(IntPtr L)
	{
		LuaScriptMgr.Push(L, HideFlags.DontSave);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHideAndDontSave(IntPtr L)
	{
		LuaScriptMgr.Push(L, HideFlags.HideAndDontSave);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		HideFlags o = (HideFlags)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

