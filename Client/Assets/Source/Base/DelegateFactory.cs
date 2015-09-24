using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using LuaInterface;

public static class DelegateFactory
{
	delegate Delegate DelegateValue(LuaFunction func);
	static Dictionary<Type, DelegateValue> dict = new Dictionary<Type, DelegateValue>();

	[NoToLuaAttribute]
	public static void Register(IntPtr L)
	{
		dict.Add(typeof(Action<GameObject>), new DelegateValue(Action_GameObject));
		dict.Add(typeof(Action), new DelegateValue(Action));
		dict.Add(typeof(UnityEngine.Events.UnityAction), new DelegateValue(UnityEngine_Events_UnityAction));
		dict.Add(typeof(System.Reflection.MemberFilter), new DelegateValue(System_Reflection_MemberFilter));
		dict.Add(typeof(System.Reflection.TypeFilter), new DelegateValue(System_Reflection_TypeFilter));
		dict.Add(typeof(Camera.CameraCallback), new DelegateValue(Camera_CameraCallback));
		dict.Add(typeof(AudioClip.PCMReaderCallback), new DelegateValue(AudioClip_PCMReaderCallback));
		dict.Add(typeof(AudioClip.PCMSetPositionCallback), new DelegateValue(AudioClip_PCMSetPositionCallback));
		dict.Add(typeof(Application.LogCallback), new DelegateValue(Application_LogCallback));
		dict.Add(typeof(UnityEngine.UI.InputField.OnValidateInput), new DelegateValue(UnityEngine_UI_InputField_OnValidateInput));
		dict.Add(typeof(Action<CHighway>), new DelegateValue(Action_CHighway));
		dict.Add(typeof(Action<CHighway,HighwayEventArg>), new DelegateValue(Action_CHighway_HighwayEventArg));
		dict.Add(typeof(Action<CRequest>), new DelegateValue(Action_CRequest));
		dict.Add(typeof(CompleteHandle), new DelegateValue(CompleteHandle));
		dict.Add(typeof(Action<CTransport,float>), new DelegateValue(Action_CTransport_float));
		dict.Add(typeof(Action<CTransport,CRequest,IList<CRequest>>), new DelegateValue(Action_CTransport_CRequest_IList_CRequest));
		dict.Add(typeof(Action<CTransport,CRequest>), new DelegateValue(Action_CTransport_CRequest));
		dict.Add(typeof(Action<string,string>), new DelegateValue(Action_string_string));
		dict.Add(typeof(Action<object>), new DelegateValue(Action_object));
		dict.Add(typeof(Action<float>), new DelegateValue(Action_float));
		dict.Add(typeof(Action<Color>), new DelegateValue(Action_Color));
		dict.Add(typeof(Action<Vector3>), new DelegateValue(Action_Vector3));
		dict.Add(typeof(Action<float,object>), new DelegateValue(Action_float_object));
		dict.Add(typeof(Action<float,Hashtable>), new DelegateValue(Action_float_Hashtable));
		dict.Add(typeof(Action<Vector3,Hashtable>), new DelegateValue(Action_Vector3_Hashtable));
		dict.Add(typeof(Action<LTEvent>), new DelegateValue(Action_LTEvent));
	}

	[NoToLuaAttribute]
	public static Delegate CreateDelegate(Type t, LuaFunction func)
	{
		DelegateValue create = null;

		if (!dict.TryGetValue(t, out create))
		{
			Debugger.LogError("Delegate {0} not register", t.FullName);
			return null;
		}
		return create(func);
	}

	public static Delegate Action_GameObject(LuaFunction func)
	{
		Action<GameObject> d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action(LuaFunction func)
	{
		Action d = () =>
		{
			func.Call();
		};
		return d;
	}

	public static Delegate UnityEngine_Events_UnityAction(LuaFunction func)
	{
		UnityEngine.Events.UnityAction d = () =>
		{
			func.Call();
		};
		return d;
	}

	public static Delegate System_Reflection_MemberFilter(LuaFunction func)
	{
		System.Reflection.MemberFilter d = (param0, param1) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.PushObject(L, param0);
			LuaScriptMgr.PushVarObject(L, param1);
			func.PCall(top, 2);
			object[] objs = func.PopValues(top);
			func.EndPCall(top);
			return (bool)objs[0];
		};
		return d;
	}

	public static Delegate System_Reflection_TypeFilter(LuaFunction func)
	{
		System.Reflection.TypeFilter d = (param0, param1) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.PushVarObject(L, param1);
			func.PCall(top, 2);
			object[] objs = func.PopValues(top);
			func.EndPCall(top);
			return (bool)objs[0];
		};
		return d;
	}

	public static Delegate Camera_CameraCallback(LuaFunction func)
	{
		Camera.CameraCallback d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate AudioClip_PCMReaderCallback(LuaFunction func)
	{
		AudioClip.PCMReaderCallback d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.PushArray(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate AudioClip_PCMSetPositionCallback(LuaFunction func)
	{
		AudioClip.PCMSetPositionCallback d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Application_LogCallback(LuaFunction func)
	{
		Application.LogCallback d = (param0, param1, param2) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.Push(L, param1);
			LuaScriptMgr.Push(L, param2);
			func.PCall(top, 3);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate UnityEngine_UI_InputField_OnValidateInput(LuaFunction func)
	{
		UnityEngine.UI.InputField.OnValidateInput d = (param0, param1, param2) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.Push(L, param1);
			LuaScriptMgr.Push(L, param2);
			func.PCall(top, 3);
			object[] objs = func.PopValues(top);
			func.EndPCall(top);
			return (char)objs[0];
		};
		return d;
	}

	public static Delegate Action_CHighway(LuaFunction func)
	{
		Action<CHighway> d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.PushObject(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_CHighway_HighwayEventArg(LuaFunction func)
	{
		Action<CHighway,HighwayEventArg> d = (param0, param1) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.PushObject(L, param0);
			LuaScriptMgr.PushObject(L, param1);
			func.PCall(top, 2);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_CRequest(LuaFunction func)
	{
		Action<CRequest> d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.PushObject(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate CompleteHandle(LuaFunction func)
	{
		CompleteHandle d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.PushObject(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_CTransport_float(LuaFunction func)
	{
		Action<CTransport,float> d = (param0, param1) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.Push(L, param1);
			func.PCall(top, 2);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_CTransport_CRequest_IList_CRequest(LuaFunction func)
	{
		Action<CTransport,CRequest,IList<CRequest>> d = (param0, param1, param2) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.PushObject(L, param1);
			LuaScriptMgr.PushObject(L, param2);
			func.PCall(top, 3);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_CTransport_CRequest(LuaFunction func)
	{
		Action<CTransport,CRequest> d = (param0, param1) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.PushObject(L, param1);
			func.PCall(top, 2);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_string_string(LuaFunction func)
	{
		Action<string,string> d = (param0, param1) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.Push(L, param1);
			func.PCall(top, 2);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_object(LuaFunction func)
	{
		Action<object> d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.PushVarObject(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_float(LuaFunction func)
	{
		Action<float> d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_Color(LuaFunction func)
	{
		Action<Color> d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_Vector3(LuaFunction func)
	{
		Action<Vector3> d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_float_object(LuaFunction func)
	{
		Action<float,object> d = (param0, param1) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.PushVarObject(L, param1);
			func.PCall(top, 2);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_float_Hashtable(LuaFunction func)
	{
		Action<float,Hashtable> d = (param0, param1) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.PushObject(L, param1);
			func.PCall(top, 2);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_Vector3_Hashtable(LuaFunction func)
	{
		Action<Vector3,Hashtable> d = (param0, param1) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.Push(L, param0);
			LuaScriptMgr.PushObject(L, param1);
			func.PCall(top, 2);
			func.EndPCall(top);
		};
		return d;
	}

	public static Delegate Action_LTEvent(LuaFunction func)
	{
		Action<LTEvent> d = (param0) =>
		{
			int top = func.BeginPCall();
			IntPtr L = func.GetLuaState();
			LuaScriptMgr.PushObject(L, param0);
			func.PCall(top, 1);
			func.EndPCall(top);
		};
		return d;
	}

}
