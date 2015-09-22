using System;
using UnityEngine;
using LuaInterface;

public class AudioClipLoadTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("DecompressOnLoad", GetDecompressOnLoad),
		new LuaMethod("CompressedInMemory", GetCompressedInMemory),
		new LuaMethod("Streaming", GetStreaming),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.AudioClipLoadType", typeof(UnityEngine.AudioClipLoadType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDecompressOnLoad(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioClipLoadType.DecompressOnLoad);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCompressedInMemory(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioClipLoadType.CompressedInMemory);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStreaming(IntPtr L)
	{
		LuaScriptMgr.Push(L, AudioClipLoadType.Streaming);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		AudioClipLoadType o = (AudioClipLoadType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

