using System;
using UnityEngine;
using LuaInterface;

public class RotationDriveModeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("XYAndZ", GetXYAndZ),
		new LuaMethod("Slerp", GetSlerp),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.RotationDriveMode", typeof(UnityEngine.RotationDriveMode), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetXYAndZ(IntPtr L)
	{
		LuaScriptMgr.Push(L, RotationDriveMode.XYAndZ);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSlerp(IntPtr L)
	{
		LuaScriptMgr.Push(L, RotationDriveMode.Slerp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		RotationDriveMode o = (RotationDriveMode)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

