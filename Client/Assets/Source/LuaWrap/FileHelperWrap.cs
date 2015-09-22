using System;
using UnityEngine;
using LuaInterface;

public class FileHelperWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("UnZipFile", UnZipFile),
			new LuaMethod("UnpackConfigZip", UnpackConfigZip),
			new LuaMethod("PersistentUTF8File", PersistentUTF8File),
			new LuaMethod("ReadUTF8File", ReadUTF8File),
			new LuaMethod("DeleteFile", DeleteFile),
			new LuaMethod("UnpackConfigAssetBundleFn", UnpackConfigAssetBundleFn),
			new LuaMethod("New", _CreateFileHelper),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "FileHelper", typeof(FileHelper), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFileHelper(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			FileHelper obj = new FileHelper();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: FileHelper.New");
		}

		return 0;
	}

	static Type classType = typeof(FileHelper);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnZipFile(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(byte[]), typeof(string)))
		{
			byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			FileHelper.UnZipFile(objs0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(System.IO.Stream), typeof(string)))
		{
			System.IO.Stream arg0 = (System.IO.Stream)LuaScriptMgr.GetLuaObject(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			FileHelper.UnZipFile(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(string)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			FileHelper.UnZipFile(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: FileHelper.UnZipFile");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnpackConfigZip(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
		Action<string,string> arg1 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg1 = (Action<string,string>)LuaScriptMgr.GetNetObject(L, 2, typeof(Action<string,string>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg1 = (param0, param1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				LuaScriptMgr.Push(L, param1);
				func.PCall(top, 2);
				func.EndPCall(top);
			};
		}

		FileHelper.UnpackConfigZip(objs0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PersistentUTF8File(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		FileHelper.PersistentUTF8File(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadUTF8File(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = FileHelper.ReadUTF8File(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeleteFile(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		FileHelper.DeleteFile(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnpackConfigAssetBundleFn(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AssetBundle arg0 = (AssetBundle)LuaScriptMgr.GetUnityObject(L, 1, typeof(AssetBundle));
		LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 2);
		FileHelper.UnpackConfigAssetBundleFn(arg0,arg1);
		return 0;
	}
}

