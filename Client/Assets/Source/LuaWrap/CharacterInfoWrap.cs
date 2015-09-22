using System;
using UnityEngine;
using LuaInterface;

public class CharacterInfoWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateCharacterInfo),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("index", get_index, set_index),
			new LuaField("size", get_size, set_size),
			new LuaField("style", get_style, set_style),
			new LuaField("advance", get_advance, null),
			new LuaField("glyphWidth", get_glyphWidth, null),
			new LuaField("glyphHeight", get_glyphHeight, null),
			new LuaField("bearing", get_bearing, null),
			new LuaField("minY", get_minY, null),
			new LuaField("maxY", get_maxY, null),
			new LuaField("minX", get_minX, null),
			new LuaField("maxX", get_maxX, null),
			new LuaField("uvBottomLeft", get_uvBottomLeft, null),
			new LuaField("uvBottomRight", get_uvBottomRight, null),
			new LuaField("uvTopRight", get_uvTopRight, null),
			new LuaField("uvTopLeft", get_uvTopLeft, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.CharacterInfo", typeof(CharacterInfo), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCharacterInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		CharacterInfo obj = new CharacterInfo();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(CharacterInfo);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_index(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name index");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index index on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.index);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_size(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name size");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index size on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.size);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_style(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name style");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index style on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.style);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_advance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name advance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index advance on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.advance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_glyphWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name glyphWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index glyphWidth on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.glyphWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_glyphHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name glyphHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index glyphHeight on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.glyphHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bearing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bearing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bearing on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.bearing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minY(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minY");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minY on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.minY);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxY(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxY");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxY on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.maxY);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minX(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minX");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minX on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.minX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxX(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxX");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxX on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.maxX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uvBottomLeft(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name uvBottomLeft");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index uvBottomLeft on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.uvBottomLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uvBottomRight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name uvBottomRight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index uvBottomRight on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.uvBottomRight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uvTopRight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name uvTopRight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index uvTopRight on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.uvTopRight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uvTopLeft(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name uvTopLeft");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index uvTopLeft on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		LuaScriptMgr.Push(L, obj.uvTopLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_index(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name index");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index index on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		obj.index = (int)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_size(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name size");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index size on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		obj.size = (int)LuaScriptMgr.GetNumber(L, 3);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_style(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name style");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index style on a nil value");
			}
		}

		CharacterInfo obj = (CharacterInfo)o;
		obj.style = (FontStyle)LuaScriptMgr.GetNetObject(L, 3, typeof(FontStyle));
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}
}

