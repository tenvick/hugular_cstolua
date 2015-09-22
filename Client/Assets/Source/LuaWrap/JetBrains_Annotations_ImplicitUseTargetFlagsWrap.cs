using System;
using LuaInterface;

public class JetBrains_Annotations_ImplicitUseTargetFlagsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Default", GetDefault),
		new LuaMethod("Itself", GetItself),
		new LuaMethod("Members", GetMembers),
		new LuaMethod("WithMembers", GetWithMembers),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "JetBrains.Annotations.ImplicitUseTargetFlags", typeof(JetBrains.Annotations.ImplicitUseTargetFlags), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefault(IntPtr L)
	{
		LuaScriptMgr.Push(L, JetBrains.Annotations.ImplicitUseTargetFlags.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItself(IntPtr L)
	{
		LuaScriptMgr.Push(L, JetBrains.Annotations.ImplicitUseTargetFlags.Itself);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMembers(IntPtr L)
	{
		LuaScriptMgr.Push(L, JetBrains.Annotations.ImplicitUseTargetFlags.Members);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWithMembers(IntPtr L)
	{
		LuaScriptMgr.Push(L, JetBrains.Annotations.ImplicitUseTargetFlags.WithMembers);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		JetBrains.Annotations.ImplicitUseTargetFlags o = (JetBrains.Annotations.ImplicitUseTargetFlags)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

