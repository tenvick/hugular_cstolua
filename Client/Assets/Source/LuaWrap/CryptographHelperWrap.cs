using System;
using LuaInterface;

public class CryptographHelperWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("CrypfString", CrypfString),
			new LuaMethod("Decrypt", Decrypt),
			new LuaMethod("Encrypt", Encrypt),
			new LuaMethod("New", _CreateCryptographHelper),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "CryptographHelper", typeof(CryptographHelper), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCryptographHelper(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			CryptographHelper obj = new CryptographHelper();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: CryptographHelper.New");
		}

		return 0;
	}

	static Type classType = typeof(CryptographHelper);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrypfString(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		string o = CryptographHelper.CrypfString(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Decrypt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
		byte[] objs1 = LuaScriptMgr.GetArrayNumber<byte>(L, 2);
		byte[] objs2 = LuaScriptMgr.GetArrayNumber<byte>(L, 3);
		byte[] o = CryptographHelper.Decrypt(objs0,objs1,objs2);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Encrypt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
		byte[] objs1 = LuaScriptMgr.GetArrayNumber<byte>(L, 2);
		byte[] objs2 = LuaScriptMgr.GetArrayNumber<byte>(L, 3);
		byte[] o = CryptographHelper.Encrypt(objs0,objs1,objs2);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}
}

