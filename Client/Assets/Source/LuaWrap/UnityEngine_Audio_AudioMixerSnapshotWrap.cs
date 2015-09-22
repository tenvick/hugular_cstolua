using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UnityEngine_Audio_AudioMixerSnapshotWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("TransitionTo", TransitionTo),
			new LuaMethod("New", _CreateUnityEngine_Audio_AudioMixerSnapshot),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("audioMixer", get_audioMixer, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Audio.AudioMixerSnapshot", typeof(UnityEngine.Audio.AudioMixerSnapshot), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Audio_AudioMixerSnapshot(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UnityEngine.Audio.AudioMixerSnapshot class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UnityEngine.Audio.AudioMixerSnapshot);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_audioMixer(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.Audio.AudioMixerSnapshot obj = (UnityEngine.Audio.AudioMixerSnapshot)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name audioMixer");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index audioMixer on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.audioMixer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransitionTo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Audio.AudioMixerSnapshot obj = (UnityEngine.Audio.AudioMixerSnapshot)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.Audio.AudioMixerSnapshot");
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		obj.TransitionTo(arg0);
		return 0;
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

