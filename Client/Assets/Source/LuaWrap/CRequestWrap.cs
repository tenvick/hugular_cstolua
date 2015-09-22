using System;
using UnityEngine;
using LuaInterface;

public class CRequestWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Dispose", Dispose),
			new LuaMethod("DispatchComplete", DispatchComplete),
			new LuaMethod("DispatchEnd", DispatchEnd),
			new LuaMethod("New", _CreateCRequest),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("assetType", get_assetType, set_assetType),
			new LuaField("assetBundle", get_assetBundle, set_assetBundle),
			new LuaField("www", get_www, set_www),
			new LuaField("userData", get_userData, set_userData),
			new LuaField("priority", get_priority, set_priority),
			new LuaField("times", get_times, set_times),
			new LuaField("childrenReq", get_childrenReq, set_childrenReq),
			new LuaField("dependenciesCount", get_dependenciesCount, set_dependenciesCount),
			new LuaField("suffix", get_suffix, set_suffix),
			new LuaField("assetBundleName", get_assetBundleName, set_assetBundleName),
			new LuaField("assetName", get_assetName, set_assetName),
			new LuaField("head", get_head, set_head),
			new LuaField("data", get_data, set_data),
			new LuaField("isShared", get_isShared, set_isShared),
			new LuaField("url", get_url, set_url),
			new LuaField("key", get_key, set_key),
			new LuaField("udKey", get_udKey, set_udKey),
			new LuaField("cache", get_cache, set_cache),
		};

		LuaScriptMgr.RegisterLib(L, "CRequest", typeof(CRequest), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCRequest(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			CRequest obj = new CRequest(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 3)
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			string arg2 = LuaScriptMgr.GetString(L, 3);
			CRequest obj = new CRequest(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: CRequest.New");
		}

		return 0;
	}

	static Type classType = typeof(CRequest);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_assetType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name assetType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index assetType on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.assetType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_assetBundle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name assetBundle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index assetBundle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.assetBundle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_www(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name www");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index www on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.www);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_userData(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name userData");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index userData on a nil value");
			}
		}

		LuaScriptMgr.PushVarObject(L, obj.userData);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_priority(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name priority");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index priority on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.priority);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_times(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name times");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index times on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.times);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_childrenReq(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name childrenReq");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index childrenReq on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.childrenReq);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dependenciesCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name dependenciesCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index dependenciesCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.dependenciesCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_suffix(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name suffix");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index suffix on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.suffix);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_assetBundleName(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name assetBundleName");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index assetBundleName on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.assetBundleName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_assetName(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name assetName");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index assetName on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.assetName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_head(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name head");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index head on a nil value");
			}
		}

		LuaScriptMgr.PushVarObject(L, obj.head);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_data(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name data");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index data on a nil value");
			}
		}

		LuaScriptMgr.PushVarObject(L, obj.data);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isShared(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isShared");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isShared on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isShared);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_url(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name url");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index url on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.url);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_key(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

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
	static int get_udKey(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name udKey");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index udKey on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.udKey);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cache(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cache");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cache on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cache);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_assetType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name assetType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index assetType on a nil value");
			}
		}

		obj.assetType = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_assetBundle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name assetBundle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index assetBundle on a nil value");
			}
		}

		obj.assetBundle = (AssetBundle)LuaScriptMgr.GetUnityObject(L, 3, typeof(AssetBundle));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_www(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name www");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index www on a nil value");
			}
		}

		obj.www = (WWW)LuaScriptMgr.GetNetObject(L, 3, typeof(WWW));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_userData(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name userData");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index userData on a nil value");
			}
		}

		obj.userData = LuaScriptMgr.GetVarObject(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_priority(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name priority");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index priority on a nil value");
			}
		}

		obj.priority = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_times(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name times");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index times on a nil value");
			}
		}

		obj.times = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_childrenReq(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name childrenReq");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index childrenReq on a nil value");
			}
		}

		obj.childrenReq = (CRequest)LuaScriptMgr.GetNetObject(L, 3, typeof(CRequest));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dependenciesCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name dependenciesCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index dependenciesCount on a nil value");
			}
		}

		obj.dependenciesCount = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_suffix(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name suffix");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index suffix on a nil value");
			}
		}

		obj.suffix = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_assetBundleName(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name assetBundleName");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index assetBundleName on a nil value");
			}
		}

		obj.assetBundleName = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_assetName(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name assetName");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index assetName on a nil value");
			}
		}

		obj.assetName = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_head(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name head");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index head on a nil value");
			}
		}

		obj.head = LuaScriptMgr.GetVarObject(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_data(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name data");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index data on a nil value");
			}
		}

		obj.data = LuaScriptMgr.GetVarObject(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isShared(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isShared");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isShared on a nil value");
			}
		}

		obj.isShared = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_url(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name url");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index url on a nil value");
			}
		}

		obj.url = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_key(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

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
	static int set_udKey(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name udKey");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index udKey on a nil value");
			}
		}

		obj.udKey = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cache(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		CRequest obj = (CRequest)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cache");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cache on a nil value");
			}
		}

		obj.cache = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		CRequest obj = (CRequest)LuaScriptMgr.GetNetObjectSelf(L, 1, "CRequest");
		obj.Dispose();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DispatchComplete(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		CRequest obj = (CRequest)LuaScriptMgr.GetNetObjectSelf(L, 1, "CRequest");
		obj.DispatchComplete();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DispatchEnd(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		CRequest obj = (CRequest)LuaScriptMgr.GetNetObjectSelf(L, 1, "CRequest");
		obj.DispatchEnd();
		return 0;
	}
}

