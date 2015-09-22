using System;
using UnityEngine;
using LuaInterface;

public class UnityEngine_Rendering_SphericalHarmonicsL2Wrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Clear", Clear),
			new LuaMethod("AddAmbientLight", AddAmbientLight),
			new LuaMethod("AddDirectionalLight", AddDirectionalLight),
			new LuaMethod("get_Item", get_Item),
			new LuaMethod("set_Item", set_Item),
			new LuaMethod("GetHashCode", GetHashCode),
			new LuaMethod("Equals", Equals),
			new LuaMethod("New", _CreateUnityEngine_Rendering_SphericalHarmonicsL2),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__add", Lua_Add),
			new LuaMethod("__mul", Lua_Mul),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.SphericalHarmonicsL2", typeof(UnityEngine.Rendering.SphericalHarmonicsL2), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Rendering_SphericalHarmonicsL2(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		UnityEngine.Rendering.SphericalHarmonicsL2 obj = new UnityEngine.Rendering.SphericalHarmonicsL2();
		LuaScriptMgr.PushValue(L, obj);
		return 1;
	}

	static Type classType = typeof(UnityEngine.Rendering.SphericalHarmonicsL2);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.Rendering.SphericalHarmonicsL2 obj = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.SphericalHarmonicsL2");
		obj.Clear();
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddAmbientLight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Rendering.SphericalHarmonicsL2 obj = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.SphericalHarmonicsL2");
		Color arg0 = LuaScriptMgr.GetColor(L, 2);
		obj.AddAmbientLight(arg0);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddDirectionalLight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		UnityEngine.Rendering.SphericalHarmonicsL2 obj = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.SphericalHarmonicsL2");
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
		Color arg1 = LuaScriptMgr.GetColor(L, 3);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 4);
		obj.AddDirectionalLight(arg0,arg1,arg2);
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UnityEngine.Rendering.SphericalHarmonicsL2 obj = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.SphericalHarmonicsL2");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		float o = obj[arg0,arg1];
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		UnityEngine.Rendering.SphericalHarmonicsL2 obj = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.SphericalHarmonicsL2");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 4);
		obj[arg0, arg1] = arg2;
		LuaScriptMgr.SetValueObject(L, 1, obj);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.Rendering.SphericalHarmonicsL2 obj = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.SphericalHarmonicsL2");
		int o = obj.GetHashCode();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Rendering.SphericalHarmonicsL2 obj = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetVarObject(L, 1);
		object arg0 = LuaScriptMgr.GetVarObject(L, 2);
		bool o = obj.Equals(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Mul(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(float), typeof(UnityEngine.Rendering.SphericalHarmonicsL2)))
		{
			float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
			UnityEngine.Rendering.SphericalHarmonicsL2 arg1 = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetLuaObject(L, 2);
			UnityEngine.Rendering.SphericalHarmonicsL2 o = arg0 * arg1;
			LuaScriptMgr.PushValue(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.SphericalHarmonicsL2), typeof(float)))
		{
			UnityEngine.Rendering.SphericalHarmonicsL2 arg0 = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			UnityEngine.Rendering.SphericalHarmonicsL2 o = arg0 * arg1;
			LuaScriptMgr.PushValue(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.SphericalHarmonicsL2.op_Multiply");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Add(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Rendering.SphericalHarmonicsL2 arg0 = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetNetObject(L, 1, typeof(UnityEngine.Rendering.SphericalHarmonicsL2));
		UnityEngine.Rendering.SphericalHarmonicsL2 arg1 = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.SphericalHarmonicsL2));
		UnityEngine.Rendering.SphericalHarmonicsL2 o = arg0 + arg1;
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Rendering.SphericalHarmonicsL2 arg0 = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetVarObject(L, 1);
		UnityEngine.Rendering.SphericalHarmonicsL2 arg1 = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetVarObject(L, 2);
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

