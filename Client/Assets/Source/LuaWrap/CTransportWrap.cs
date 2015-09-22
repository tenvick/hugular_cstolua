using System;
using UnityEngine;
using System.Collections.Generic;
using LuaInterface;
using Object = UnityEngine.Object;

public class CTransportWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("BeginLoad", BeginLoad),
			new LuaMethod("RemapVariantName", RemapVariantName),
			new LuaMethod("New", _CreateCTransport),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("key", get_key, set_key),
			new LuaField("m_AssetBundleManifest", get_m_AssetBundleManifest, set_m_AssetBundleManifest),
			new LuaField("OnProcess", get_OnProcess, set_OnProcess),
			new LuaField("OnComplete", get_OnComplete, set_OnComplete),
			new LuaField("OnError", get_OnError, set_OnError),
			new LuaField("isFree", get_isFree, null),
			new LuaField("req", get_req, null),
			new LuaField("Variants", get_Variants, set_Variants),
		};

		LuaScriptMgr.RegisterLib(L, "CTransport", typeof(CTransport), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCTransport(IntPtr L)
	{
		LuaDLL.luaL_error(L, "CTransport class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(CTransport);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_key(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name key");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index key on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.key);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_AssetBundleManifest(IntPtr L)
	{
		LuaScriptMgr.Push(L, CTransport.m_AssetBundleManifest);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnProcess(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name OnProcess");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index OnProcess on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.OnProcess);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnComplete(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name OnComplete");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index OnComplete on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.OnComplete);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnError(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name OnError");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index OnError on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.OnError);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isFree(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isFree");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isFree on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isFree);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_req(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name req");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index req on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.req);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Variants(IntPtr L)
	{
		LuaScriptMgr.PushArray(L, CTransport.Variants);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_key(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name key");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index key on a nil value");
			}
		}

		obj.key = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_AssetBundleManifest(IntPtr L)
	{
		CTransport.m_AssetBundleManifest = (AssetBundleManifest)LuaScriptMgr.GetUnityObject(L, 3, typeof(AssetBundleManifest));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnProcess(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name OnProcess");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index OnProcess on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.OnProcess = (Action<CTransport,float>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<CTransport,float>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.OnProcess = (param0, param1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				LuaScriptMgr.Push(L, param1);
				func.PCall(top, 2);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnComplete(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name OnComplete");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index OnComplete on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.OnComplete = (Action<CTransport,CRequest,IList<CRequest>>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<CTransport,CRequest,IList<CRequest>>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.OnComplete = (param0, param1, param2) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				LuaScriptMgr.PushObject(L, param1);
				LuaScriptMgr.PushObject(L, param2);
				func.PCall(top, 3);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnError(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CTransport obj = (CTransport)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name OnError");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index OnError on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.OnError = (Action<CTransport,CRequest>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<CTransport,CRequest>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.OnError = (param0, param1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				LuaScriptMgr.PushObject(L, param1);
				func.PCall(top, 2);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Variants(IntPtr L)
	{
		CTransport.Variants = LuaScriptMgr.GetArrayString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BeginLoad(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CTransport obj = (CTransport)LuaScriptMgr.GetUnityObjectSelf(L, 1, "CTransport");
		CRequest arg0 = (CRequest)LuaScriptMgr.GetNetObject(L, 2, typeof(CRequest));
		obj.BeginLoad(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemapVariantName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = CTransport.RemapVariantName(arg0);
		LuaScriptMgr.Push(L, o);
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

