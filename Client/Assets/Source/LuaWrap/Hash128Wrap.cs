using System;
using UnityEngine;
using LuaInterface;

public class Hash128Wrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("ToString", ToString),
			new LuaMethod("Parse", Parse),
			new LuaMethod("New", _CreateHash128),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__tostring", Lua_ToString),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Hash128", typeof(Hash128), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateHash128(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 4)
		{
			uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 1);
			uint arg1 = (uint)LuaScriptMgr.GetNumber(L, 2);
			uint arg2 = (uint)LuaScriptMgr.GetNumber(L, 3);
			uint arg3 = (uint)LuaScriptMgr.GetNumber(L, 4);
			Hash128 obj = new Hash128(arg0,arg1,arg2,arg3);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 0)
		{
			Hash128 obj = new Hash128();
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Hash128.New");
		}

		return 0;
	}

	static Type classType = typeof(Hash128);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = LuaScriptMgr.GetLuaObject(L, 1);

		if (obj != null)
		{
			LuaScriptMgr.Push(L, obj.ToString());
		}
		else
		{
			LuaScriptMgr.Push(L, "Table: UnityEngine.Hash128");
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Hash128 obj = (Hash128)LuaScriptMgr.GetNetObjectSelf(L, 1, "Hash128");
		string o = obj.ToString();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Parse(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		Hash128 o = Hash128.Parse(arg0);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}
}

