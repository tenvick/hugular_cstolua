using System;
using LuaInterface;

public class UnityEngineInternal_ReproductionWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("CaptureScreenshot", CaptureScreenshot),
			new LuaMethod("New", _CreateUnityEngineInternal_Reproduction),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngineInternal.Reproduction", typeof(UnityEngineInternal.Reproduction), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngineInternal_Reproduction(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			UnityEngineInternal.Reproduction obj = new UnityEngineInternal.Reproduction();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngineInternal.Reproduction.New");
		}

		return 0;
	}

	static Type classType = typeof(UnityEngineInternal.Reproduction);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CaptureScreenshot(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		UnityEngineInternal.Reproduction.CaptureScreenshot();
		return 0;
	}
}

