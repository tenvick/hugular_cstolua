using System;
using LuaInterface;

public class UnityEngineInternal_APIUpdaterRuntimeServicesWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateUnityEngineInternal_APIUpdaterRuntimeServices),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngineInternal.APIUpdaterRuntimeServices", typeof(UnityEngineInternal.APIUpdaterRuntimeServices), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngineInternal_APIUpdaterRuntimeServices(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			UnityEngineInternal.APIUpdaterRuntimeServices obj = new UnityEngineInternal.APIUpdaterRuntimeServices();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngineInternal.APIUpdaterRuntimeServices.New");
		}

		return 0;
	}

	static Type classType = typeof(UnityEngineInternal.APIUpdaterRuntimeServices);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}
}

