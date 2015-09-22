using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ConstantForceWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateConstantForce),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("force", get_force, set_force),
			new LuaField("relativeForce", get_relativeForce, set_relativeForce),
			new LuaField("torque", get_torque, set_torque),
			new LuaField("relativeTorque", get_relativeTorque, set_relativeTorque),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ConstantForce", typeof(ConstantForce), regs, fields, typeof(Behaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateConstantForce(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			ConstantForce obj = new ConstantForce();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ConstantForce.New");
		}

		return 0;
	}

	static Type classType = typeof(ConstantForce);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_force(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce obj = (ConstantForce)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name force");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index force on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.force);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_relativeForce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce obj = (ConstantForce)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name relativeForce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index relativeForce on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.relativeForce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_torque(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce obj = (ConstantForce)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name torque");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index torque on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.torque);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_relativeTorque(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce obj = (ConstantForce)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name relativeTorque");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index relativeTorque on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.relativeTorque);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_force(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce obj = (ConstantForce)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name force");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index force on a nil value");
			}
		}

		obj.force = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_relativeForce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce obj = (ConstantForce)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name relativeForce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index relativeForce on a nil value");
			}
		}

		obj.relativeForce = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_torque(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce obj = (ConstantForce)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name torque");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index torque on a nil value");
			}
		}

		obj.torque = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_relativeTorque(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce obj = (ConstantForce)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name relativeTorque");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index relativeTorque on a nil value");
			}
		}

		obj.relativeTorque = LuaScriptMgr.GetVector3(L, 3);
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

