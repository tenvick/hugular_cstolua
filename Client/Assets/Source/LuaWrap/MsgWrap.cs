using System;
using LuaInterface;

public class MsgWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("ToArray", ToArray),
			new LuaMethod("Debug", Debug),
			new LuaMethod("ToCArray", ToCArray),
			new LuaMethod("Write", Write),
			new LuaMethod("WriteBoolean", WriteBoolean),
			new LuaMethod("WriteByte", WriteByte),
			new LuaMethod("WriteChar", WriteChar),
			new LuaMethod("WriteUShort", WriteUShort),
			new LuaMethod("WriteUInt", WriteUInt),
			new LuaMethod("WriteULong", WriteULong),
			new LuaMethod("WriteShort", WriteShort),
			new LuaMethod("WriteFloat", WriteFloat),
			new LuaMethod("WriteInt", WriteInt),
			new LuaMethod("WriteString", WriteString),
			new LuaMethod("WriteUTFBytes", WriteUTFBytes),
			new LuaMethod("ReadBoolean", ReadBoolean),
			new LuaMethod("ReadByte", ReadByte),
			new LuaMethod("ReadChar", ReadChar),
			new LuaMethod("ReadUShort", ReadUShort),
			new LuaMethod("ReadUInt", ReadUInt),
			new LuaMethod("ReadULong", ReadULong),
			new LuaMethod("ReadShort", ReadShort),
			new LuaMethod("ReadInt", ReadInt),
			new LuaMethod("ReadFloat", ReadFloat),
			new LuaMethod("ReadString", ReadString),
			new LuaMethod("ReadUTF", ReadUTF),
			new LuaMethod("New", _CreateMsg),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("Length", get_Length, null),
			new LuaField("Position", get_Position, set_Position),
			new LuaField("Type", get_Type, set_Type),
		};

		LuaScriptMgr.RegisterLib(L, "Msg", typeof(Msg), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMsg(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Msg obj = new Msg();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 1)
		{
			byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
			Msg obj = new Msg(objs0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Msg.New");
		}

		return 0;
	}

	static Type classType = typeof(Msg);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Length(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Msg obj = (Msg)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Length");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Length on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.Length);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Position(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Msg obj = (Msg)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Position");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Position on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.Position);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Msg obj = (Msg)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Type on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.Type);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Position(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Msg obj = (Msg)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Position");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Position on a nil value");
			}
		}

		obj.Position = (long)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Msg obj = (Msg)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Type on a nil value");
			}
		}

		obj.Type = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToArray(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		byte[] o = obj.ToArray();
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Debug(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(byte[])))
		{
			byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
			string o = Msg.Debug(objs0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Msg)))
		{
			Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
			string o = obj.Debug();
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Msg.Debug");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToCArray(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		byte[] o = obj.ToCArray();
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Write(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 2);
		obj.Write(objs0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteBoolean(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
		obj.WriteBoolean(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteByte(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		byte arg0 = (byte)LuaScriptMgr.GetNumber(L, 2);
		obj.WriteByte(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteChar(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		char arg0 = (char)LuaScriptMgr.GetNumber(L, 2);
		obj.WriteChar(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteUShort(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		ushort arg0 = (ushort)LuaScriptMgr.GetNumber(L, 2);
		obj.WriteUShort(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteUInt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 2);
		obj.WriteUInt(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteULong(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		ulong arg0 = (ulong)LuaScriptMgr.GetNumber(L, 2);
		obj.WriteULong(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteShort(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.WriteShort(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteFloat(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		obj.WriteFloat(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteInt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.WriteInt(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteString(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		obj.WriteString(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteUTFBytes(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		obj.WriteUTFBytes(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadBoolean(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		bool o = obj.ReadBoolean();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadByte(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		byte o = obj.ReadByte();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadChar(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		char o = obj.ReadChar();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadUShort(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		ushort o = obj.ReadUShort();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadUInt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		uint o = obj.ReadUInt();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadULong(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		ulong o = obj.ReadULong();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadShort(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		short o = obj.ReadShort();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadInt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		int o = obj.ReadInt();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadFloat(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		float o = obj.ReadFloat();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadString(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		string o = obj.ReadString();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadUTF(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Msg obj = (Msg)LuaScriptMgr.GetNetObjectSelf(L, 1, "Msg");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		string o = obj.ReadUTF(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

