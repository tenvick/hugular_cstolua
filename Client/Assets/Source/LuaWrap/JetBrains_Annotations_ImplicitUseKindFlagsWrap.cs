using System;
using LuaInterface;

public class JetBrains_Annotations_ImplicitUseKindFlagsWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Default", GetDefault),
		new LuaMethod("Access", GetAccess),
		new LuaMethod("Assign", GetAssign),
		new LuaMethod("InstantiatedWithFixedConstructorSignature", GetInstantiatedWithFixedConstructorSignature),
		new LuaMethod("InstantiatedNoFixedConstructorSignature", GetInstantiatedNoFixedConstructorSignature),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "JetBrains.Annotations.ImplicitUseKindFlags", typeof(JetBrains.Annotations.ImplicitUseKindFlags), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefault(IntPtr L)
	{
		LuaScriptMgr.Push(L, JetBrains.Annotations.ImplicitUseKindFlags.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAccess(IntPtr L)
	{
		LuaScriptMgr.Push(L, JetBrains.Annotations.ImplicitUseKindFlags.Access);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAssign(IntPtr L)
	{
		LuaScriptMgr.Push(L, JetBrains.Annotations.ImplicitUseKindFlags.Assign);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstantiatedWithFixedConstructorSignature(IntPtr L)
	{
		LuaScriptMgr.Push(L, JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstantiatedNoFixedConstructorSignature(IntPtr L)
	{
		LuaScriptMgr.Push(L, JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		JetBrains.Annotations.ImplicitUseKindFlags o = (JetBrains.Annotations.ImplicitUseKindFlags)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

