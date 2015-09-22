using System;
using System.Collections.Generic;
using LuaInterface;

public class LocalizationWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Load", Load),
			new LuaMethod("Get", Get),
			new LuaMethod("Exists", Exists),
			new LuaMethod("New", _CreateLocalization),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("localizationHasBeenSet", get_localizationHasBeenSet, set_localizationHasBeenSet),
			new LuaField("dictionary", get_dictionary, set_dictionary),
			new LuaField("knownLanguages", get_knownLanguages, null),
			new LuaField("language", get_language, set_language),
		};

		LuaScriptMgr.RegisterLib(L, "Localization", typeof(Localization), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLocalization(IntPtr L)
	{
		LuaDLL.luaL_error(L, "Localization class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(Localization);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localizationHasBeenSet(IntPtr L)
	{
		LuaScriptMgr.Push(L, Localization.localizationHasBeenSet);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dictionary(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, Localization.dictionary);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_knownLanguages(IntPtr L)
	{
		LuaScriptMgr.PushArray(L, Localization.knownLanguages);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_language(IntPtr L)
	{
		LuaScriptMgr.Push(L, Localization.language);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localizationHasBeenSet(IntPtr L)
	{
		Localization.localizationHasBeenSet = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dictionary(IntPtr L)
	{
		Localization.dictionary = (Dictionary<string,string>)LuaScriptMgr.GetNetObject(L, 3, typeof(Dictionary<string,string>));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_language(IntPtr L)
	{
		Localization.language = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Load(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
		Localization.Load(objs0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Get(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = Localization.Get(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Exists(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		bool o = Localization.Exists(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

