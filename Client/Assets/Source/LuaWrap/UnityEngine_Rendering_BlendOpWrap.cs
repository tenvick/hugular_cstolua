using System;
using LuaInterface;

public class UnityEngine_Rendering_BlendOpWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Add", GetAdd),
		new LuaMethod("Subtract", GetSubtract),
		new LuaMethod("ReverseSubtract", GetReverseSubtract),
		new LuaMethod("Min", GetMin),
		new LuaMethod("Max", GetMax),
		new LuaMethod("LogicalClear", GetLogicalClear),
		new LuaMethod("LogicalSet", GetLogicalSet),
		new LuaMethod("LogicalCopy", GetLogicalCopy),
		new LuaMethod("LogicalCopyInverted", GetLogicalCopyInverted),
		new LuaMethod("LogicalNoop", GetLogicalNoop),
		new LuaMethod("LogicalInvert", GetLogicalInvert),
		new LuaMethod("LogicalAnd", GetLogicalAnd),
		new LuaMethod("LogicalNand", GetLogicalNand),
		new LuaMethod("LogicalOr", GetLogicalOr),
		new LuaMethod("LogicalNor", GetLogicalNor),
		new LuaMethod("LogicalXor", GetLogicalXor),
		new LuaMethod("LogicalEquivalence", GetLogicalEquivalence),
		new LuaMethod("LogicalAndReverse", GetLogicalAndReverse),
		new LuaMethod("LogicalAndInverted", GetLogicalAndInverted),
		new LuaMethod("LogicalOrReverse", GetLogicalOrReverse),
		new LuaMethod("LogicalOrInverted", GetLogicalOrInverted),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.BlendOp", typeof(UnityEngine.Rendering.BlendOp), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAdd(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.Add);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSubtract(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.Subtract);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetReverseSubtract(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.ReverseSubtract);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMin(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.Min);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMax(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.Max);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalClear(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalClear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalSet(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalSet);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalCopy(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalCopy);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalCopyInverted(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalCopyInverted);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalNoop(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalNoop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalInvert(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalInvert);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalAnd(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalAnd);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalNand(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalNand);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalOr(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalOr);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalNor(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalNor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalXor(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalXor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalEquivalence(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalEquivalence);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalAndReverse(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalAndReverse);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalAndInverted(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalAndInverted);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalOrReverse(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalOrReverse);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLogicalOrInverted(IntPtr L)
	{
		LuaScriptMgr.Push(L, UnityEngine.Rendering.BlendOp.LogicalOrInverted);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.BlendOp o = (UnityEngine.Rendering.BlendOp)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

