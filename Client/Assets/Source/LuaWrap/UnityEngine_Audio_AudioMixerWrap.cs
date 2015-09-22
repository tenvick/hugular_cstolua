using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UnityEngine_Audio_AudioMixerWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("FindMatchingGroups", FindMatchingGroups),
			new LuaMethod("FindSnapshot", FindSnapshot),
			new LuaMethod("TransitionToSnapshots", TransitionToSnapshots),
			new LuaMethod("SetFloat", SetFloat),
			new LuaMethod("ClearFloat", ClearFloat),
			new LuaMethod("GetFloat", GetFloat),
			new LuaMethod("New", _CreateUnityEngine_Audio_AudioMixer),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("outputAudioMixerGroup", get_outputAudioMixerGroup, set_outputAudioMixerGroup),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Audio.AudioMixer", typeof(UnityEngine.Audio.AudioMixer), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Audio_AudioMixer(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UnityEngine.Audio.AudioMixer class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UnityEngine.Audio.AudioMixer);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_outputAudioMixerGroup(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.Audio.AudioMixer obj = (UnityEngine.Audio.AudioMixer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name outputAudioMixerGroup");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index outputAudioMixerGroup on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.outputAudioMixerGroup);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_outputAudioMixerGroup(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.Audio.AudioMixer obj = (UnityEngine.Audio.AudioMixer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name outputAudioMixerGroup");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index outputAudioMixerGroup on a nil value");
			}
		}

		obj.outputAudioMixerGroup = (UnityEngine.Audio.AudioMixerGroup)LuaScriptMgr.GetUnityObject(L, 3, typeof(UnityEngine.Audio.AudioMixerGroup));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindMatchingGroups(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Audio.AudioMixer obj = (UnityEngine.Audio.AudioMixer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.Audio.AudioMixer");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		UnityEngine.Audio.AudioMixerGroup[] o = obj.FindMatchingGroups(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSnapshot(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Audio.AudioMixer obj = (UnityEngine.Audio.AudioMixer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.Audio.AudioMixer");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		UnityEngine.Audio.AudioMixerSnapshot o = obj.FindSnapshot(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransitionToSnapshots(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		UnityEngine.Audio.AudioMixer obj = (UnityEngine.Audio.AudioMixer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.Audio.AudioMixer");
		UnityEngine.Audio.AudioMixerSnapshot[] objs0 = LuaScriptMgr.GetArrayObject<UnityEngine.Audio.AudioMixerSnapshot>(L, 2);
		float[] objs1 = LuaScriptMgr.GetArrayNumber<float>(L, 3);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 4);
		obj.TransitionToSnapshots(objs0,objs1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetFloat(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UnityEngine.Audio.AudioMixer obj = (UnityEngine.Audio.AudioMixer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.Audio.AudioMixer");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		bool o = obj.SetFloat(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearFloat(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Audio.AudioMixer obj = (UnityEngine.Audio.AudioMixer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.Audio.AudioMixer");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		bool o = obj.ClearFloat(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFloat(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UnityEngine.Audio.AudioMixer obj = (UnityEngine.Audio.AudioMixer)LuaScriptMgr.GetUnityObjectSelf(L, 1, "UnityEngine.Audio.AudioMixer");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		float arg1;
		bool o = obj.GetFloat(arg0,out arg1);
		LuaScriptMgr.Push(L, o);
		LuaScriptMgr.Push(L, arg1);
		return 2;
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

