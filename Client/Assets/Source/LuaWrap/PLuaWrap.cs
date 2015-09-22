using System;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class PLuaWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("DoUnity3dLua", DoUnity3dLua),
			new LuaMethod("DoMain", DoMain),
			new LuaMethod("LoadBundle", LoadBundle),
			new LuaMethod("RegisterFunc", RegisterFunc),
			new LuaMethod("Loader", Loader),
			new LuaMethod("Log", Log),
			new LuaMethod("Delay", Delay),
			new LuaMethod("StopDelay", StopDelay),
			new LuaMethod("New", _CreatePLua),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("enterLua", get_enterLua, set_enterLua),
			new LuaField("onDestroyFn", get_onDestroyFn, set_onDestroyFn),
			new LuaField("isDebug", get_isDebug, set_isDebug),
			new LuaField("lua", get_lua, set_lua),
			new LuaField("net", get_net, set_net),
			new LuaField("ChatNet", get_ChatNet, set_ChatNet),
			new LuaField("luacache", get_luacache, set_luacache),
			new LuaField("updateFn", get_updateFn, set_updateFn),
			new LuaField("instance", get_instance, null),
		};

		LuaScriptMgr.RegisterLib(L, "PLua", typeof(PLua), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePLua(IntPtr L)
	{
		LuaDLL.luaL_error(L, "PLua class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(PLua);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enterLua(IntPtr L)
	{
		LuaScriptMgr.Push(L, PLua.enterLua);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDestroyFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDestroyFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDestroyFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onDestroyFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isDebug(IntPtr L)
	{
		LuaScriptMgr.Push(L, PLua.isDebug);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lua(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lua");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lua on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.lua);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_net(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name net");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index net on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.net);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ChatNet(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ChatNet");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ChatNet on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.ChatNet);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luacache(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, PLua.luacache);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name updateFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index updateFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.updateFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		LuaScriptMgr.Push(L, PLua.instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_enterLua(IntPtr L)
	{
		PLua.enterLua = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDestroyFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDestroyFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDestroyFn on a nil value");
			}
		}

		obj.onDestroyFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isDebug(IntPtr L)
	{
		PLua.isDebug = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lua(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lua");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lua on a nil value");
			}
		}

		obj.lua = (LuaScriptMgr)LuaScriptMgr.GetNetObject(L, 3, typeof(LuaScriptMgr));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_net(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name net");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index net on a nil value");
			}
		}

		obj.net = (LNet)LuaScriptMgr.GetNetObject(L, 3, typeof(LNet));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ChatNet(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ChatNet");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ChatNet on a nil value");
			}
		}

		obj.ChatNet = (LNet)LuaScriptMgr.GetNetObject(L, 3, typeof(LNet));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luacache(IntPtr L)
	{
		PLua.luacache = (Dictionary<string,TextAsset>)LuaScriptMgr.GetNetObject(L, 3, typeof(Dictionary<string,TextAsset>));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updateFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		PLua obj = (PLua)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name updateFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index updateFn on a nil value");
			}
		}

		obj.updateFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoUnity3dLua(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		PLua obj = (PLua)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PLua");
		obj.DoUnity3dLua();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoMain(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		PLua obj = (PLua)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PLua");
		obj.DoMain();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadBundle(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(PLua), typeof(LuaInterface.LuaFunction)))
		{
			PLua obj = (PLua)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PLua");
			LuaFunction arg0 = LuaScriptMgr.ToLuaFunction(L, 2);
			obj.LoadBundle(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(PLua), typeof(bool)))
		{
			PLua obj = (PLua)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PLua");
			bool arg0 = LuaDLL.lua_toboolean(L, 2);
			obj.LoadBundle(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: PLua.LoadBundle");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterFunc(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		PLua obj = (PLua)LuaScriptMgr.GetUnityObjectSelf(L, 1, "PLua");
		obj.RegisterFunc();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Loader(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		byte[] o = PLua.Loader(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Log(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		object arg0 = LuaScriptMgr.GetVarObject(L, 1);
		PLua.Log(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Delay(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		object arg2 = LuaScriptMgr.GetVarObject(L, 3);
		PLua.Delay(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopDelay(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		PLua.StopDelay(arg0);
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

