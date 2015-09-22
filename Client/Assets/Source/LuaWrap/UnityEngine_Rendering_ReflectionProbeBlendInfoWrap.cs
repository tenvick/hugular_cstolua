using System;
using UnityEngine;
using LuaInterface;

public class UnityEngine_Rendering_ReflectionProbeBlendInfoWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateUnityEngine_Rendering_ReflectionProbeBlendInfo),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("probe", get_probe, set_probe),
			new LuaField("weight", get_weight, set_weight),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.ReflectionProbeBlendInfo", typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Rendering_ReflectionProbeBlendInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		UnityEngine.Rendering.ReflectionProbeBlendInfo obj = new UnityEngine.Rendering.ReflectionProbeBlendInfo();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_probe(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name probe");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index probe on a nil value");
			}
		}

		UnityEngine.Rendering.ReflectionProbeBlendInfo obj = (UnityEngine.Rendering.ReflectionProbeBlendInfo)o;
		LuaScriptMgr.Push(L, obj.probe);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_weight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name weight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index weight on a nil value");
			}
		}

		UnityEngine.Rendering.ReflectionProbeBlendInfo obj = (UnityEngine.Rendering.ReflectionProbeBlendInfo)o;
		LuaScriptMgr.Push(L, obj.weight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_probe(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name probe");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index probe on a nil value");
			}
		}

		UnityEngine.Rendering.ReflectionProbeBlendInfo obj = (UnityEngine.Rendering.ReflectionProbeBlendInfo)o;
		obj.probe = (ReflectionProbe)LuaScriptMgr.GetUnityObject(L, 3, typeof(ReflectionProbe));
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_weight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name weight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index weight on a nil value");
			}
		}

		UnityEngine.Rendering.ReflectionProbeBlendInfo obj = (UnityEngine.Rendering.ReflectionProbeBlendInfo)o;
		obj.weight = (float)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}
}

