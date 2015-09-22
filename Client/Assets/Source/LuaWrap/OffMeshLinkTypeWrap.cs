using System;
using UnityEngine;
using LuaInterface;

public class OffMeshLinkTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("LinkTypeManual", GetLinkTypeManual),
		new LuaMethod("LinkTypeDropDown", GetLinkTypeDropDown),
		new LuaMethod("LinkTypeJumpAcross", GetLinkTypeJumpAcross),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.OffMeshLinkType", typeof(UnityEngine.OffMeshLinkType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLinkTypeManual(IntPtr L)
	{
		LuaScriptMgr.Push(L, OffMeshLinkType.LinkTypeManual);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLinkTypeDropDown(IntPtr L)
	{
		LuaScriptMgr.Push(L, OffMeshLinkType.LinkTypeDropDown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLinkTypeJumpAcross(IntPtr L)
	{
		LuaScriptMgr.Push(L, OffMeshLinkType.LinkTypeJumpAcross);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		OffMeshLinkType o = (OffMeshLinkType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

