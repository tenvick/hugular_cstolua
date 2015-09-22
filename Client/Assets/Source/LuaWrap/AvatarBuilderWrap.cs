using System;
using UnityEngine;
using LuaInterface;

public class AvatarBuilderWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("BuildHumanAvatar", BuildHumanAvatar),
			new LuaMethod("BuildGenericAvatar", BuildGenericAvatar),
			new LuaMethod("New", _CreateAvatarBuilder),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AvatarBuilder", typeof(AvatarBuilder), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAvatarBuilder(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			AvatarBuilder obj = new AvatarBuilder();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AvatarBuilder.New");
		}

		return 0;
	}

	static Type classType = typeof(AvatarBuilder);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BuildHumanAvatar(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		HumanDescription arg1 = (HumanDescription)LuaScriptMgr.GetNetObject(L, 2, typeof(HumanDescription));
		Avatar o = AvatarBuilder.BuildHumanAvatar(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BuildGenericAvatar(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Avatar o = AvatarBuilder.BuildGenericAvatar(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

