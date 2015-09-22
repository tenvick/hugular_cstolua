using System;
using UnityEngine;
using LuaInterface;

public class AudioCompressionFormatWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("PCM", GetPCM),
		new LuaMethod("Vorbis", GetVorbis),
		new LuaMethod("ADPCM", GetADPCM),
		new LuaMethod("MP3", GetMP3),
		new LuaMethod("VAG", GetVAG),
		new LuaMethod("HEVAG", GetHEVAG),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AudioCompressionFormat", typeof(UnityEngine.AudioCompressionFormat), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPCM(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioCompressionFormat.PCM);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVorbis(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioCompressionFormat.Vorbis);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetADPCM(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioCompressionFormat.ADPCM);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMP3(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioCompressionFormat.MP3);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVAG(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioCompressionFormat.VAG);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHEVAG(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioCompressionFormat.HEVAG);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AudioCompressionFormat o = (AudioCompressionFormat)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

