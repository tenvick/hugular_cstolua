using System;
using UnityEngine;
using LuaInterface;

public class AnimatorControllerParameterWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Equals", Equals),
			new LuaMethod("GetHashCode", GetHashCode),
			new LuaMethod("New", _CreateAnimatorControllerParameter),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("name", get_name, set_name),
			new LuaField("nameHash", get_nameHash, null),
			new LuaField("type", get_type, set_type),
			new LuaField("defaultFloat", get_defaultFloat, set_defaultFloat),
			new LuaField("defaultInt", get_defaultInt, set_defaultInt),
			new LuaField("defaultBool", get_defaultBool, set_defaultBool),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AnimatorControllerParameter", typeof(AnimatorControllerParameter), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAnimatorControllerParameter(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			AnimatorControllerParameter obj = new AnimatorControllerParameter();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AnimatorControllerParameter.New");
		}

		return 0;
	}

	static Type classType = typeof(AnimatorControllerParameter);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name name");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index name on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.name);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nameHash(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name nameHash");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index nameHash on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.nameHash);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index type on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.type);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultFloat(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name defaultFloat");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index defaultFloat on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.defaultFloat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultInt(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name defaultInt");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index defaultInt on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.defaultInt);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultBool(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name defaultBool");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index defaultBool on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.defaultBool);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_name(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name name");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index name on a nil value");
			}
		}

        //obj.name = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index type on a nil value");
			}
		}

		obj.type = (AnimatorControllerParameterType)LuaScriptMgr.GetNetObject(L, 3, typeof(AnimatorControllerParameterType));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultFloat(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name defaultFloat");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index defaultFloat on a nil value");
			}
		}

		obj.defaultFloat = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultInt(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name defaultInt");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index defaultInt on a nil value");
			}
		}

		obj.defaultInt = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultBool(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name defaultBool");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index defaultBool on a nil value");
			}
		}

		obj.defaultBool = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AnimatorControllerParameter obj = LuaScriptMgr.GetVarObject(L, 1) as AnimatorControllerParameter;
		object arg0 = LuaScriptMgr.GetVarObject(L, 2);
		bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		AnimatorControllerParameter obj = (AnimatorControllerParameter)LuaScriptMgr.GetNetObjectSelf(L, 1, "AnimatorControllerParameter");
		int o = obj.GetHashCode();
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

