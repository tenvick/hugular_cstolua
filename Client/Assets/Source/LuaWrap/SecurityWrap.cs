using System;
using UnityEngine;
using LuaInterface;

public class SecurityWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("PrefetchSocketPolicy", PrefetchSocketPolicy),
			new LuaMethod("LoadAndVerifyAssembly", LoadAndVerifyAssembly),
			new LuaMethod("New", _CreateSecurity),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Security", typeof(Security), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSecurity(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Security obj = new Security();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Security.New");
		}

		return 0;
	}

	static Type classType = typeof(Security);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PrefetchSocketPolicy(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			bool o = Security.PrefetchSocketPolicy(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			bool o = Security.PrefetchSocketPolicy(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Security.PrefetchSocketPolicy");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAndVerifyAssembly(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
			System.Reflection.Assembly o = Security.LoadAndVerifyAssembly(objs0);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 2)
		{
			byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
			string arg1 = LuaScriptMgr.GetLuaString(L, 2);
			System.Reflection.Assembly o = Security.LoadAndVerifyAssembly(objs0,arg1);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Security.LoadAndVerifyAssembly");
		}

		return 0;
	}
}

