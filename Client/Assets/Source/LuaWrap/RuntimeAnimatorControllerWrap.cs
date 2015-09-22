using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class RuntimeAnimatorControllerWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateRuntimeAnimatorController),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("animationClips", get_animationClips, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.RuntimeAnimatorController", typeof(RuntimeAnimatorController), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateRuntimeAnimatorController(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			RuntimeAnimatorController obj = new RuntimeAnimatorController();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: RuntimeAnimatorController.New");
		}

		return 0;
	}

	static Type classType = typeof(RuntimeAnimatorController);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animationClips(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		RuntimeAnimatorController obj = (RuntimeAnimatorController)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name animationClips");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index animationClips on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.animationClips);
		return 1;
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

