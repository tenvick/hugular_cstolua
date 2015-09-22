using System;
using LuaInterface;

public class LNetWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Connect", Connect),
			new LuaMethod("ReConnect", ReConnect),
			new LuaMethod("Close", Close),
			new LuaMethod("Send", Send),
			new LuaMethod("Update", Update),
			new LuaMethod("OnApplicationPause", OnApplicationPause),
			new LuaMethod("Receive", Receive),
			new LuaMethod("SendErro", SendErro),
			new LuaMethod("Dispose", Dispose),
			new LuaMethod("New", _CreateLNet),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("pingDelay", get_pingDelay, set_pingDelay),
			new LuaField("timeoutMiliSecond", get_timeoutMiliSecond, set_timeoutMiliSecond),
			new LuaField("onAppErrorFn", get_onAppErrorFn, set_onAppErrorFn),
			new LuaField("onConnectionCloseFn", get_onConnectionCloseFn, set_onConnectionCloseFn),
			new LuaField("onConnectionFn", get_onConnectionFn, set_onConnectionFn),
			new LuaField("onMessageReceiveFn", get_onMessageReceiveFn, set_onMessageReceiveFn),
			new LuaField("onConnectionTimeoutFn", get_onConnectionTimeoutFn, set_onConnectionTimeoutFn),
			new LuaField("onReConnectFn", get_onReConnectFn, set_onReConnectFn),
			new LuaField("onAppPauseFn", get_onAppPauseFn, set_onAppPauseFn),
			new LuaField("onIntervalFn", get_onIntervalFn, set_onIntervalFn),
			new LuaField("isConnectCall", get_isConnectCall, null),
			new LuaField("IsConnected", get_IsConnected, null),
			new LuaField("Host", get_Host, null),
			new LuaField("Port", get_Port, null),
			new LuaField("ChatInstance", get_ChatInstance, null),
			new LuaField("instance", get_instance, null),
		};

		LuaScriptMgr.RegisterLib(L, "LNet", typeof(LNet), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLNet(IntPtr L)
	{
		LuaDLL.luaL_error(L, "LNet class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(LNet);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pingDelay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pingDelay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pingDelay on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.pingDelay);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeoutMiliSecond(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name timeoutMiliSecond");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index timeoutMiliSecond on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.timeoutMiliSecond);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onAppErrorFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onAppErrorFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onAppErrorFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onAppErrorFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onConnectionCloseFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onConnectionCloseFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onConnectionCloseFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onConnectionCloseFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onConnectionFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onConnectionFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onConnectionFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onConnectionFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onMessageReceiveFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onMessageReceiveFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onMessageReceiveFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onMessageReceiveFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onConnectionTimeoutFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onConnectionTimeoutFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onConnectionTimeoutFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onConnectionTimeoutFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onReConnectFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onReConnectFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onReConnectFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onReConnectFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onAppPauseFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onAppPauseFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onAppPauseFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onAppPauseFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onIntervalFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onIntervalFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onIntervalFn on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onIntervalFn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isConnectCall(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isConnectCall");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isConnectCall on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isConnectCall);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsConnected(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name IsConnected");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index IsConnected on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.IsConnected);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Host(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Host");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Host on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.Host);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Port(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Port");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Port on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.Port);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ChatInstance(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, LNet.ChatInstance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, LNet.instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pingDelay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pingDelay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pingDelay on a nil value");
			}
		}

		obj.pingDelay = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_timeoutMiliSecond(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name timeoutMiliSecond");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index timeoutMiliSecond on a nil value");
			}
		}

		obj.timeoutMiliSecond = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onAppErrorFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onAppErrorFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onAppErrorFn on a nil value");
			}
		}

		obj.onAppErrorFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onConnectionCloseFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onConnectionCloseFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onConnectionCloseFn on a nil value");
			}
		}

		obj.onConnectionCloseFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onConnectionFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onConnectionFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onConnectionFn on a nil value");
			}
		}

		obj.onConnectionFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onMessageReceiveFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onMessageReceiveFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onMessageReceiveFn on a nil value");
			}
		}

		obj.onMessageReceiveFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onConnectionTimeoutFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onConnectionTimeoutFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onConnectionTimeoutFn on a nil value");
			}
		}

		obj.onConnectionTimeoutFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onReConnectFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onReConnectFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onReConnectFn on a nil value");
			}
		}

		obj.onReConnectFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onAppPauseFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onAppPauseFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onAppPauseFn on a nil value");
			}
		}

		obj.onAppPauseFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onIntervalFn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LNet obj = (LNet)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onIntervalFn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onIntervalFn on a nil value");
			}
		}

		obj.onIntervalFn = LuaScriptMgr.GetLuaFunction(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Connect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		obj.Connect(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReConnect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
		obj.ReConnect();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Close(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
		obj.Close();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Send(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LNet), typeof(Msg)))
		{
			LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
			Msg arg0 = (Msg)LuaScriptMgr.GetLuaObject(L, 2);
			obj.Send(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LNet), typeof(byte[])))
		{
			LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
			byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 2);
			obj.Send(objs0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LNet.Send");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
		obj.Update();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnApplicationPause(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
		bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
		obj.OnApplicationPause(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Receive(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
		obj.Receive();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendErro(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		string arg1 = LuaScriptMgr.GetLuaString(L, 3);
		obj.SendErro(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LNet obj = (LNet)LuaScriptMgr.GetNetObjectSelf(L, 1, "LNet");
		obj.Dispose();
		return 0;
	}
}

