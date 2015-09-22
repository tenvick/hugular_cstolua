using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class LuaHelperWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Destroy", Destroy),
			new LuaMethod("DestroyImmediate", DestroyImmediate),
			new LuaMethod("Instantiate", Instantiate),
			new LuaMethod("InstantiateLocal", InstantiateLocal),
			new LuaMethod("InstantiateGlobal", InstantiateGlobal),
			new LuaMethod("SetParent", SetParent),
			new LuaMethod("GetType", GetType),
			new LuaMethod("Find", Find),
			new LuaMethod("FindWithTag", FindWithTag),
			new LuaMethod("GetComponentInChildren", GetComponentInChildren),
			new LuaMethod("GetComponent", GetComponent),
			new LuaMethod("GetComponents", GetComponents),
			new LuaMethod("GetComponentsInChildren", GetComponentsInChildren),
			new LuaMethod("GetAllChild", GetAllChild),
			new LuaMethod("ForeachChild", ForeachChild),
			new LuaMethod("Raycast", Raycast),
			new LuaMethod("RefreshShader", RefreshShader),
			new LuaMethod("GetAngle", GetAngle),
			new LuaMethod("GetUTF8String", GetUTF8String),
			new LuaMethod("GetBytes", GetBytes),
			new LuaMethod("GCCollect", GCCollect),
			new LuaMethod("New", _CreateLuaHelper),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "LuaHelper", typeof(LuaHelper), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaHelper(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LuaHelper obj = new LuaHelper();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaHelper.New");
		}

		return 0;
	}

	static Type classType = typeof(LuaHelper);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
			LuaHelper.Destroy(arg0);
			return 0;
		}
		else if (count == 2)
		{
			Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			LuaHelper.Destroy(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaHelper.Destroy");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyImmediate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
			LuaHelper.DestroyImmediate(arg0);
			return 0;
		}
		else if (count == 2)
		{
			Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
			bool arg1 = LuaScriptMgr.GetBoolean(L, 2);
			LuaHelper.DestroyImmediate(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaHelper.DestroyImmediate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Instantiate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
		Object o = LuaHelper.Instantiate(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InstantiateLocal(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			GameObject o = LuaHelper.InstantiateLocal(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			GameObject o = LuaHelper.InstantiateLocal(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			GameObject arg1 = (GameObject)LuaScriptMgr.GetLuaObject(L, 2);
			GameObject o = LuaHelper.InstantiateLocal(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			GameObject arg1 = (GameObject)LuaScriptMgr.GetUnityObject(L, 2, typeof(GameObject));
			Vector3 arg2 = LuaScriptMgr.GetVector3(L, 3);
			GameObject o = LuaHelper.InstantiateLocal(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaHelper.InstantiateLocal");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InstantiateGlobal(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		GameObject arg1 = (GameObject)LuaScriptMgr.GetUnityObject(L, 2, typeof(GameObject));
		GameObject o = LuaHelper.InstantiateGlobal(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetParent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		GameObject arg1 = (GameObject)LuaScriptMgr.GetUnityObject(L, 2, typeof(GameObject));
		LuaHelper.SetParent(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetType(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			Type o = LuaHelper.GetType(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(object)))
		{
			object arg0 = LuaScriptMgr.GetVarObject(L, 1);
			Type o = LuaHelper.GetType(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaHelper.GetType");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		GameObject o = LuaHelper.Find(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindWithTag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		GameObject o = LuaHelper.FindWithTag(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInChildren(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Component o = LuaHelper.GetComponentInChildren(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Component o = LuaHelper.GetComponent(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponents(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Component[] o = LuaHelper.GetComponents(arg0,arg1);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInChildren(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Component[] o = LuaHelper.GetComponentsInChildren(arg0,arg1);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllChild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		Transform[] o = LuaHelper.GetAllChild(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ForeachChild(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(ReferGameObjects), typeof(LuaInterface.LuaFunction)))
		{
			ReferGameObjects arg0 = (ReferGameObjects)LuaScriptMgr.GetLuaObject(L, 1);
			LuaFunction arg1 = LuaScriptMgr.ToLuaFunction(L, 2);
			LuaHelper.ForeachChild(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaInterface.LuaFunction)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			LuaFunction arg1 = LuaScriptMgr.ToLuaFunction(L, 2);
			LuaHelper.ForeachChild(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaHelper.ForeachChild");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Raycast(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Ray arg0 = LuaScriptMgr.GetRay(L, 1);
		object o = LuaHelper.Raycast(arg0);
		LuaScriptMgr.PushVarObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshShader(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(WWW)))
		{
			WWW arg0 = (WWW)LuaScriptMgr.GetLuaObject(L, 1);
			LuaHelper.RefreshShader(arg0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(AssetBundle)))
		{
			AssetBundle arg0 = (AssetBundle)LuaScriptMgr.GetLuaObject(L, 1);
			LuaHelper.RefreshShader(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaHelper.RefreshShader");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAngle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		float arg3 = (float)LuaScriptMgr.GetNumber(L, 4);
		float o = LuaHelper.GetAngle(arg0,arg1,arg2,arg3);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUTF8String(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		byte[] objs0 = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
		string o = LuaHelper.GetUTF8String(objs0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBytes(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		byte[] o = LuaHelper.GetBytes(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GCCollect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaHelper obj = (LuaHelper)LuaScriptMgr.GetNetObjectSelf(L, 1, "LuaHelper");
		obj.GCCollect();
		return 0;
	}
}

