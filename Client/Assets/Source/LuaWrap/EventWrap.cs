using System;
using UnityEngine;
using LuaInterface;

public class EventWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetTypeForControl", GetTypeForControl),
			new LuaMethod("Use", Use),
			new LuaMethod("PopEvent", PopEvent),
			new LuaMethod("GetEventCount", GetEventCount),
			new LuaMethod("KeyboardEvent", KeyboardEvent),
			new LuaMethod("GetHashCode", GetHashCode),
			new LuaMethod("Equals", Equals),
			new LuaMethod("ToString", ToString),
			new LuaMethod("New", _CreateEvent),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__tostring", Lua_ToString),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("rawType", get_rawType, null),
			new LuaField("type", get_type, set_type),
			new LuaField("mousePosition", get_mousePosition, set_mousePosition),
			new LuaField("delta", get_delta, set_delta),
			new LuaField("button", get_button, set_button),
			new LuaField("modifiers", get_modifiers, set_modifiers),
			new LuaField("pressure", get_pressure, set_pressure),
			new LuaField("clickCount", get_clickCount, set_clickCount),
			new LuaField("character", get_character, set_character),
			new LuaField("commandName", get_commandName, set_commandName),
			new LuaField("keyCode", get_keyCode, set_keyCode),
			new LuaField("shift", get_shift, set_shift),
			new LuaField("control", get_control, set_control),
			new LuaField("alt", get_alt, set_alt),
			new LuaField("command", get_command, set_command),
			new LuaField("capsLock", get_capsLock, set_capsLock),
			new LuaField("numeric", get_numeric, set_numeric),
			new LuaField("functionKey", get_functionKey, null),
			new LuaField("current", get_current, set_current),
			new LuaField("isKey", get_isKey, null),
			new LuaField("isMouse", get_isMouse, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Event", typeof(Event), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Event obj = new Event();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 1)
		{
			Event arg0 = (Event)LuaScriptMgr.GetNetObject(L, 1, typeof(Event));
			Event obj = new Event(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Event.New");
		}

		return 0;
	}

	static Type classType = typeof(Event);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rawType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rawType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rawType on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.rawType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

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
	static int get_mousePosition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mousePosition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mousePosition on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.mousePosition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_delta(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name delta");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index delta on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.delta);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_button(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name button");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index button on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.button);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_modifiers(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name modifiers");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index modifiers on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.modifiers);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pressure(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pressure");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pressure on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.pressure);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clickCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clickCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clickCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.clickCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_character(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name character");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index character on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.character);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_commandName(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name commandName");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index commandName on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.commandName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_keyCode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name keyCode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index keyCode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.keyCode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shift(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shift");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shift on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shift);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_control(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name control");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index control on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.control);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alt(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alt");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alt on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.alt);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_command(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name command");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index command on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.command);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_capsLock(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name capsLock");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index capsLock on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.capsLock);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_numeric(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name numeric");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index numeric on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.numeric);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_functionKey(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name functionKey");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index functionKey on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.functionKey);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_current(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, Event.current);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isKey(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isKey");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isKey on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isKey);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMouse(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isMouse");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isMouse on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isMouse);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

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

		obj.type = (EventType)LuaScriptMgr.GetNetObject(L, 3, typeof(EventType));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mousePosition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mousePosition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mousePosition on a nil value");
			}
		}

		obj.mousePosition = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_delta(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name delta");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index delta on a nil value");
			}
		}

		obj.delta = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_button(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name button");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index button on a nil value");
			}
		}

		obj.button = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_modifiers(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name modifiers");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index modifiers on a nil value");
			}
		}

		obj.modifiers = (EventModifiers)LuaScriptMgr.GetNetObject(L, 3, typeof(EventModifiers));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pressure(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pressure");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pressure on a nil value");
			}
		}

		obj.pressure = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clickCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clickCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clickCount on a nil value");
			}
		}

		obj.clickCount = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_character(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name character");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index character on a nil value");
			}
		}

		obj.character = (char)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_commandName(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name commandName");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index commandName on a nil value");
			}
		}

		obj.commandName = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_keyCode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name keyCode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index keyCode on a nil value");
			}
		}

		obj.keyCode = (KeyCode)LuaScriptMgr.GetNetObject(L, 3, typeof(KeyCode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shift(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shift");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shift on a nil value");
			}
		}

		obj.shift = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_control(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name control");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index control on a nil value");
			}
		}

		obj.control = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alt(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alt");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alt on a nil value");
			}
		}

		obj.alt = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_command(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name command");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index command on a nil value");
			}
		}

		obj.command = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_capsLock(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name capsLock");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index capsLock on a nil value");
			}
		}

		obj.capsLock = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_numeric(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Event obj = (Event)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name numeric");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index numeric on a nil value");
			}
		}

		obj.numeric = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_current(IntPtr L)
	{
		Event.current = (Event)LuaScriptMgr.GetNetObject(L, 3, typeof(Event));
		return 0;
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
			LuaScriptMgr.Push(L, "Table: UnityEngine.Event");
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTypeForControl(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Event obj = (Event)LuaScriptMgr.GetNetObjectSelf(L, 1, "Event");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		EventType o = obj.GetTypeForControl(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Use(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Event obj = (Event)LuaScriptMgr.GetNetObjectSelf(L, 1, "Event");
		obj.Use();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PopEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Event arg0 = (Event)LuaScriptMgr.GetNetObject(L, 1, typeof(Event));
		bool o = Event.PopEvent(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEventCount(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		int o = Event.GetEventCount();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int KeyboardEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		Event o = Event.KeyboardEvent(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Event obj = (Event)LuaScriptMgr.GetNetObjectSelf(L, 1, "Event");
		int o = obj.GetHashCode();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Event obj = LuaScriptMgr.GetVarObject(L, 1) as Event;
		object arg0 = LuaScriptMgr.GetVarObject(L, 2);
		bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Event obj = (Event)LuaScriptMgr.GetNetObjectSelf(L, 1, "Event");
		string o = obj.ToString();
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

