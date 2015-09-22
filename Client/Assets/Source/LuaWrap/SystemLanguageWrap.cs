using System;
using UnityEngine;
using LuaInterface;

public class SystemLanguageWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Afrikaans", GetAfrikaans),
		new LuaMethod("Arabic", GetArabic),
		new LuaMethod("Basque", GetBasque),
		new LuaMethod("Belarusian", GetBelarusian),
		new LuaMethod("Bulgarian", GetBulgarian),
		new LuaMethod("Catalan", GetCatalan),
		new LuaMethod("Chinese", GetChinese),
		new LuaMethod("Czech", GetCzech),
		new LuaMethod("Danish", GetDanish),
		new LuaMethod("Dutch", GetDutch),
		new LuaMethod("English", GetEnglish),
		new LuaMethod("Estonian", GetEstonian),
		new LuaMethod("Faroese", GetFaroese),
		new LuaMethod("Finnish", GetFinnish),
		new LuaMethod("French", GetFrench),
		new LuaMethod("German", GetGerman),
		new LuaMethod("Greek", GetGreek),
		new LuaMethod("Hebrew", GetHebrew),
		new LuaMethod("Icelandic", GetIcelandic),
		new LuaMethod("Indonesian", GetIndonesian),
		new LuaMethod("Italian", GetItalian),
		new LuaMethod("Japanese", GetJapanese),
		new LuaMethod("Korean", GetKorean),
		new LuaMethod("Latvian", GetLatvian),
		new LuaMethod("Lithuanian", GetLithuanian),
		new LuaMethod("Norwegian", GetNorwegian),
		new LuaMethod("Polish", GetPolish),
		new LuaMethod("Portuguese", GetPortuguese),
		new LuaMethod("Romanian", GetRomanian),
		new LuaMethod("Russian", GetRussian),
		new LuaMethod("SerboCroatian", GetSerboCroatian),
		new LuaMethod("Slovak", GetSlovak),
		new LuaMethod("Slovenian", GetSlovenian),
		new LuaMethod("Spanish", GetSpanish),
		new LuaMethod("Swedish", GetSwedish),
		new LuaMethod("Thai", GetThai),
		new LuaMethod("Turkish", GetTurkish),
		new LuaMethod("Ukrainian", GetUkrainian),
		new LuaMethod("Vietnamese", GetVietnamese),
		new LuaMethod("ChineseSimplified", GetChineseSimplified),
		new LuaMethod("ChineseTraditional", GetChineseTraditional),
		new LuaMethod("Unknown", GetUnknown),
		new LuaMethod("Hungarian", GetHungarian),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.SystemLanguage", typeof(UnityEngine.SystemLanguage), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAfrikaans(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Afrikaans);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetArabic(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Arabic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBasque(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Basque);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBelarusian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Belarusian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBulgarian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Bulgarian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCatalan(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Catalan);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChinese(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Chinese);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCzech(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Czech);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDanish(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Danish);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDutch(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Dutch);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnglish(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.English);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEstonian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Estonian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFaroese(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Faroese);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFinnish(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Finnish);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFrench(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.French);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGerman(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.German);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGreek(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Greek);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHebrew(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Hebrew);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIcelandic(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Icelandic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIndonesian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Indonesian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItalian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Italian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetJapanese(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Japanese);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetKorean(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Korean);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLatvian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Latvian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLithuanian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Lithuanian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNorwegian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Norwegian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPolish(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Polish);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPortuguese(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Portuguese);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRomanian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Romanian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRussian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Russian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSerboCroatian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.SerboCroatian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSlovak(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Slovak);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSlovenian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Slovenian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSpanish(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Spanish);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSwedish(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Swedish);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetThai(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Thai);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTurkish(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Turkish);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUkrainian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Ukrainian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVietnamese(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Vietnamese);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChineseSimplified(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.ChineseSimplified);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChineseTraditional(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.ChineseTraditional);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUnknown(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Unknown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHungarian(IntPtr L)
	{
		LuaScriptMgr.Push(L, SystemLanguage.Hungarian);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		SystemLanguage o = (SystemLanguage)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

