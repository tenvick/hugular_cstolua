using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class TextMeshWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateTextMesh),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("text", get_text, set_text),
			new LuaField("font", get_font, set_font),
			new LuaField("fontSize", get_fontSize, set_fontSize),
			new LuaField("fontStyle", get_fontStyle, set_fontStyle),
			new LuaField("offsetZ", get_offsetZ, set_offsetZ),
			new LuaField("alignment", get_alignment, set_alignment),
			new LuaField("anchor", get_anchor, set_anchor),
			new LuaField("characterSize", get_characterSize, set_characterSize),
			new LuaField("lineSpacing", get_lineSpacing, set_lineSpacing),
			new LuaField("tabSize", get_tabSize, set_tabSize),
			new LuaField("richText", get_richText, set_richText),
			new LuaField("color", get_color, set_color),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.TextMesh", typeof(TextMesh), regs, fields, typeof(Component));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTextMesh(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			TextMesh obj = new TextMesh();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: TextMesh.New");
		}

		return 0;
	}

	static Type classType = typeof(TextMesh);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name text");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index text on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.text);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_font(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name font");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index font on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.font);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fontSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontStyle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fontStyle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_offsetZ(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name offsetZ");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index offsetZ on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.offsetZ);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alignment(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alignment");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alignment on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.alignment);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name anchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index anchor on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.anchor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_characterSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name characterSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index characterSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.characterSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lineSpacing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lineSpacing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lineSpacing on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.lineSpacing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tabSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name tabSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index tabSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.tabSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_richText(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name richText");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index richText on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.richText);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_color(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name color");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index color on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.color);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_text(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name text");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index text on a nil value");
			}
		}

		obj.text = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_font(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name font");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index font on a nil value");
			}
		}

		obj.font = (Font)LuaScriptMgr.GetUnityObject(L, 3, typeof(Font));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fontSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontSize on a nil value");
			}
		}

		obj.fontSize = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fontStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontStyle on a nil value");
			}
		}

		obj.fontStyle = (FontStyle)LuaScriptMgr.GetNetObject(L, 3, typeof(FontStyle));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_offsetZ(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name offsetZ");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index offsetZ on a nil value");
			}
		}

		obj.offsetZ = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alignment(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alignment");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alignment on a nil value");
			}
		}

		obj.alignment = (TextAlignment)LuaScriptMgr.GetNetObject(L, 3, typeof(TextAlignment));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name anchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index anchor on a nil value");
			}
		}

		obj.anchor = (TextAnchor)LuaScriptMgr.GetNetObject(L, 3, typeof(TextAnchor));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_characterSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name characterSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index characterSize on a nil value");
			}
		}

		obj.characterSize = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lineSpacing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lineSpacing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lineSpacing on a nil value");
			}
		}

		obj.lineSpacing = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tabSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name tabSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index tabSize on a nil value");
			}
		}

		obj.tabSize = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_richText(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name richText");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index richText on a nil value");
			}
		}

		obj.richText = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_color(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		TextMesh obj = (TextMesh)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name color");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index color on a nil value");
			}
		}

		obj.color = LuaScriptMgr.GetColor(L, 3);
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

