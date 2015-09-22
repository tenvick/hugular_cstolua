using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ComputeShaderWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("FindKernel", FindKernel),
			new LuaMethod("SetFloat", SetFloat),
			new LuaMethod("SetInt", SetInt),
			new LuaMethod("SetVector", SetVector),
			new LuaMethod("SetFloats", SetFloats),
			new LuaMethod("SetInts", SetInts),
			new LuaMethod("SetTexture", SetTexture),
			new LuaMethod("SetBuffer", SetBuffer),
			new LuaMethod("Dispatch", Dispatch),
			new LuaMethod("New", _CreateComputeShader),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ComputeShader", typeof(ComputeShader), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateComputeShader(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			ComputeShader obj = new ComputeShader();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ComputeShader.New");
		}

		return 0;
	}

	static Type classType = typeof(ComputeShader);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindKernel(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		ComputeShader obj = (ComputeShader)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ComputeShader");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		int o = obj.FindKernel(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetFloat(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		ComputeShader obj = (ComputeShader)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ComputeShader");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		obj.SetFloat(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetInt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		ComputeShader obj = (ComputeShader)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ComputeShader");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		obj.SetInt(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetVector(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		ComputeShader obj = (ComputeShader)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ComputeShader");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		Vector4 arg1 = LuaScriptMgr.GetVector4(L, 3);
		obj.SetVector(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetFloats(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		ComputeShader obj = (ComputeShader)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ComputeShader");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		float[] objs1 = LuaScriptMgr.GetArrayNumber<float>(L, 3);
		obj.SetFloats(arg0,objs1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetInts(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		ComputeShader obj = (ComputeShader)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ComputeShader");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		int[] objs1 = LuaScriptMgr.GetArrayNumber<int>(L, 3);
		obj.SetInts(arg0,objs1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTexture(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		ComputeShader obj = (ComputeShader)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ComputeShader");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		string arg1 = LuaScriptMgr.GetLuaString(L, 3);
		Texture arg2 = (Texture)LuaScriptMgr.GetUnityObject(L, 4, typeof(Texture));
		obj.SetTexture(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetBuffer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		ComputeShader obj = (ComputeShader)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ComputeShader");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		string arg1 = LuaScriptMgr.GetLuaString(L, 3);
		ComputeBuffer arg2 = (ComputeBuffer)LuaScriptMgr.GetNetObject(L, 4, typeof(ComputeBuffer));
		obj.SetBuffer(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispatch(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 5);
		ComputeShader obj = (ComputeShader)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ComputeShader");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
		int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
		obj.Dispatch(arg0,arg1,arg2,arg3);
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

