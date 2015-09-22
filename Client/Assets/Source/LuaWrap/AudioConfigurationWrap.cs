using System;
using UnityEngine;
using LuaInterface;

public class AudioConfigurationWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateAudioConfiguration),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("speakerMode", get_speakerMode, set_speakerMode),
			new LuaField("dspBufferSize", get_dspBufferSize, set_dspBufferSize),
			new LuaField("sampleRate", get_sampleRate, set_sampleRate),
			new LuaField("numRealVoices", get_numRealVoices, set_numRealVoices),
			new LuaField("numVirtualVoices", get_numVirtualVoices, set_numVirtualVoices),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AudioConfiguration", typeof(AudioConfiguration), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAudioConfiguration(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		AudioConfiguration obj = new AudioConfiguration();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(AudioConfiguration);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_speakerMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name speakerMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index speakerMode on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		LuaScriptMgr.Push(L, obj.speakerMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dspBufferSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name dspBufferSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index dspBufferSize on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		LuaScriptMgr.Push(L, obj.dspBufferSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sampleRate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sampleRate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sampleRate on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		LuaScriptMgr.Push(L, obj.sampleRate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_numRealVoices(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name numRealVoices");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index numRealVoices on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		LuaScriptMgr.Push(L, obj.numRealVoices);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_numVirtualVoices(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name numVirtualVoices");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index numVirtualVoices on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		LuaScriptMgr.Push(L, obj.numVirtualVoices);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_speakerMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name speakerMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index speakerMode on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		obj.speakerMode = (AudioSpeakerMode)LuaScriptMgr.GetNetObject(L, 3, typeof(AudioSpeakerMode));
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dspBufferSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name dspBufferSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index dspBufferSize on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		obj.dspBufferSize = (int)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sampleRate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sampleRate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sampleRate on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		obj.sampleRate = (int)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_numRealVoices(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name numRealVoices");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index numRealVoices on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		obj.numRealVoices = (int)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_numVirtualVoices(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name numVirtualVoices");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index numVirtualVoices on a nil value");
			}
		}

		AudioConfiguration obj = (AudioConfiguration)o;
		obj.numVirtualVoices = (int)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}
}

