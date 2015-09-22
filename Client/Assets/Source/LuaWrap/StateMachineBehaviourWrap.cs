using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class StateMachineBehaviourWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("OnStateEnter", OnStateEnter),
			new LuaMethod("OnStateUpdate", OnStateUpdate),
			new LuaMethod("OnStateExit", OnStateExit),
			new LuaMethod("OnStateMove", OnStateMove),
			new LuaMethod("OnStateIK", OnStateIK),
			new LuaMethod("OnStateMachineEnter", OnStateMachineEnter),
			new LuaMethod("OnStateMachineExit", OnStateMachineExit),
			new LuaMethod("New", _CreateStateMachineBehaviour),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.StateMachineBehaviour", typeof(StateMachineBehaviour), regs, fields, typeof(ScriptableObject));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateStateMachineBehaviour(IntPtr L)
	{
		LuaDLL.luaL_error(L, "StateMachineBehaviour class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(StateMachineBehaviour);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateEnter(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		StateMachineBehaviour obj = (StateMachineBehaviour)LuaScriptMgr.GetUnityObjectSelf(L, 1, "StateMachineBehaviour");
		Animator arg0 = (Animator)LuaScriptMgr.GetUnityObject(L, 2, typeof(Animator));
		AnimatorStateInfo arg1 = (AnimatorStateInfo)LuaScriptMgr.GetNetObject(L, 3, typeof(AnimatorStateInfo));
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
		obj.OnStateEnter(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateUpdate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		StateMachineBehaviour obj = (StateMachineBehaviour)LuaScriptMgr.GetUnityObjectSelf(L, 1, "StateMachineBehaviour");
		Animator arg0 = (Animator)LuaScriptMgr.GetUnityObject(L, 2, typeof(Animator));
		AnimatorStateInfo arg1 = (AnimatorStateInfo)LuaScriptMgr.GetNetObject(L, 3, typeof(AnimatorStateInfo));
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
		obj.OnStateUpdate(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateExit(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		StateMachineBehaviour obj = (StateMachineBehaviour)LuaScriptMgr.GetUnityObjectSelf(L, 1, "StateMachineBehaviour");
		Animator arg0 = (Animator)LuaScriptMgr.GetUnityObject(L, 2, typeof(Animator));
		AnimatorStateInfo arg1 = (AnimatorStateInfo)LuaScriptMgr.GetNetObject(L, 3, typeof(AnimatorStateInfo));
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
		obj.OnStateExit(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateMove(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		StateMachineBehaviour obj = (StateMachineBehaviour)LuaScriptMgr.GetUnityObjectSelf(L, 1, "StateMachineBehaviour");
		Animator arg0 = (Animator)LuaScriptMgr.GetUnityObject(L, 2, typeof(Animator));
		AnimatorStateInfo arg1 = (AnimatorStateInfo)LuaScriptMgr.GetNetObject(L, 3, typeof(AnimatorStateInfo));
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
		obj.OnStateMove(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateIK(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		StateMachineBehaviour obj = (StateMachineBehaviour)LuaScriptMgr.GetUnityObjectSelf(L, 1, "StateMachineBehaviour");
		Animator arg0 = (Animator)LuaScriptMgr.GetUnityObject(L, 2, typeof(Animator));
		AnimatorStateInfo arg1 = (AnimatorStateInfo)LuaScriptMgr.GetNetObject(L, 3, typeof(AnimatorStateInfo));
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
		obj.OnStateIK(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateMachineEnter(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		StateMachineBehaviour obj = (StateMachineBehaviour)LuaScriptMgr.GetUnityObjectSelf(L, 1, "StateMachineBehaviour");
		Animator arg0 = (Animator)LuaScriptMgr.GetUnityObject(L, 2, typeof(Animator));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		obj.OnStateMachineEnter(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateMachineExit(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		StateMachineBehaviour obj = (StateMachineBehaviour)LuaScriptMgr.GetUnityObjectSelf(L, 1, "StateMachineBehaviour");
		Animator arg0 = (Animator)LuaScriptMgr.GetUnityObject(L, 2, typeof(Animator));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		obj.OnStateMachineExit(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

