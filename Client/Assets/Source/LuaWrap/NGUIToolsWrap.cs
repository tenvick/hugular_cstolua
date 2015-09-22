using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class NGUIToolsWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("PlaySound", PlaySound),
			new LuaMethod("OpenURL", OpenURL),
			new LuaMethod("RandomRange", RandomRange),
			new LuaMethod("GetHierarchy", GetHierarchy),
			new LuaMethod("FindCameraForLayer", FindCameraForLayer),
			new LuaMethod("GetTypeName", GetTypeName),
			new LuaMethod("RegisterUndo", RegisterUndo),
			new LuaMethod("SetDirty", SetDirty),
			new LuaMethod("AddChild", AddChild),
			new LuaMethod("SetChildLayer", SetChildLayer),
			new LuaMethod("GetRoot", GetRoot),
			new LuaMethod("Destroy", Destroy),
			new LuaMethod("DestroyImmediate", DestroyImmediate),
			new LuaMethod("Broadcast", Broadcast),
			new LuaMethod("IsChild", IsChild),
			new LuaMethod("SetActiveChildren", SetActiveChildren),
			new LuaMethod("GetActive", GetActive),
			new LuaMethod("SetActiveSelf", SetActiveSelf),
			new LuaMethod("SetLayer", SetLayer),
			new LuaMethod("Round", Round),
			new LuaMethod("Save", Save),
			new LuaMethod("Load", Load),
			new LuaMethod("ApplyPMA", ApplyPMA),
			new LuaMethod("GetSides", GetSides),
			new LuaMethod("GetWorldCorners", GetWorldCorners),
			new LuaMethod("GetFuncName", GetFuncName),
			new LuaMethod("New", _CreateNGUITools),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("soundVolume", get_soundVolume, set_soundVolume),
			new LuaField("fileAccess", get_fileAccess, null),
			new LuaField("clipboard", get_clipboard, set_clipboard),
		};

		LuaScriptMgr.RegisterLib(L, "NGUITools", typeof(NGUITools), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNGUITools(IntPtr L)
	{
		LuaDLL.luaL_error(L, "NGUITools class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(NGUITools);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_soundVolume(IntPtr L)
	{
		LuaScriptMgr.Push(L, NGUITools.soundVolume);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fileAccess(IntPtr L)
	{
		LuaScriptMgr.Push(L, NGUITools.fileAccess);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipboard(IntPtr L)
	{
		LuaScriptMgr.Push(L, NGUITools.clipboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_soundVolume(IntPtr L)
	{
		NGUITools.soundVolume = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clipboard(IntPtr L)
	{
		NGUITools.clipboard = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlaySound(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			AudioClip arg0 = (AudioClip)LuaScriptMgr.GetUnityObject(L, 1, typeof(AudioClip));
			AudioSource o = NGUITools.PlaySound(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			AudioClip arg0 = (AudioClip)LuaScriptMgr.GetUnityObject(L, 1, typeof(AudioClip));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			AudioSource o = NGUITools.PlaySound(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			AudioClip arg0 = (AudioClip)LuaScriptMgr.GetUnityObject(L, 1, typeof(AudioClip));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			AudioSource o = NGUITools.PlaySound(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUITools.PlaySound");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenURL(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			WWW o = NGUITools.OpenURL(arg0);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 2)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			WWWForm arg1 = (WWWForm)LuaScriptMgr.GetNetObject(L, 2, typeof(WWWForm));
			WWW o = NGUITools.OpenURL(arg0,arg1);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUITools.OpenURL");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RandomRange(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		int o = NGUITools.RandomRange(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHierarchy(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string o = NGUITools.GetHierarchy(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindCameraForLayer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		Camera o = NGUITools.FindCameraForLayer(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTypeName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
		string o = NGUITools.GetTypeName(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterUndo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		NGUITools.RegisterUndo(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDirty(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
		NGUITools.SetDirty(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddChild(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			GameObject o = NGUITools.AddChild(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			GameObject arg1 = (GameObject)LuaScriptMgr.GetLuaObject(L, 2);
			GameObject o = NGUITools.AddChild(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(bool)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			bool arg1 = LuaDLL.lua_toboolean(L, 2);
			GameObject o = NGUITools.AddChild(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUITools.AddChild");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetChildLayer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		NGUITools.SetChildLayer(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRoot(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		GameObject o = NGUITools.GetRoot(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
		NGUITools.Destroy(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyImmediate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Object arg0 = (Object)LuaScriptMgr.GetUnityObject(L, 1, typeof(Object));
		NGUITools.DestroyImmediate(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Broadcast(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			NGUITools.Broadcast(arg0);
			return 0;
		}
		else if (count == 2)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			object arg1 = LuaScriptMgr.GetVarObject(L, 2);
			NGUITools.Broadcast(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUITools.Broadcast");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsChild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
		Transform arg1 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		bool o = NGUITools.IsChild(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetActiveChildren(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		bool arg1 = LuaScriptMgr.GetBoolean(L, 2);
		NGUITools.SetActiveChildren(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetActive(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			bool o = NGUITools.GetActive(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Behaviour)))
		{
			Behaviour arg0 = (Behaviour)LuaScriptMgr.GetLuaObject(L, 1);
			bool o = NGUITools.GetActive(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUITools.GetActive");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetActiveSelf(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		bool arg1 = LuaScriptMgr.GetBoolean(L, 2);
		NGUITools.SetActiveSelf(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		NGUITools.SetLayer(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Round(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		Vector3 o = NGUITools.Round(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Save(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		byte[] objs1 = LuaScriptMgr.GetArrayNumber<byte>(L, 2);
		bool o = NGUITools.Save(arg0,objs1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Load(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		byte[] o = NGUITools.Load(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ApplyPMA(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Color arg0 = LuaScriptMgr.GetColor(L, 1);
		Color o = NGUITools.ApplyPMA(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSides(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Camera arg0 = (Camera)LuaScriptMgr.GetUnityObject(L, 1, typeof(Camera));
			Vector3[] o = NGUITools.GetSides(arg0);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Camera), typeof(Transform)))
		{
			Camera arg0 = (Camera)LuaScriptMgr.GetLuaObject(L, 1);
			Transform arg1 = (Transform)LuaScriptMgr.GetLuaObject(L, 2);
			Vector3[] o = NGUITools.GetSides(arg0,arg1);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Camera), typeof(float)))
		{
			Camera arg0 = (Camera)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Vector3[] o = NGUITools.GetSides(arg0,arg1);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 3)
		{
			Camera arg0 = (Camera)LuaScriptMgr.GetUnityObject(L, 1, typeof(Camera));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			Transform arg2 = (Transform)LuaScriptMgr.GetUnityObject(L, 3, typeof(Transform));
			Vector3[] o = NGUITools.GetSides(arg0,arg1,arg2);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUITools.GetSides");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWorldCorners(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Camera arg0 = (Camera)LuaScriptMgr.GetUnityObject(L, 1, typeof(Camera));
			Vector3[] o = NGUITools.GetWorldCorners(arg0);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Camera), typeof(Transform)))
		{
			Camera arg0 = (Camera)LuaScriptMgr.GetLuaObject(L, 1);
			Transform arg1 = (Transform)LuaScriptMgr.GetLuaObject(L, 2);
			Vector3[] o = NGUITools.GetWorldCorners(arg0,arg1);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Camera), typeof(float)))
		{
			Camera arg0 = (Camera)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Vector3[] o = NGUITools.GetWorldCorners(arg0,arg1);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else if (count == 3)
		{
			Camera arg0 = (Camera)LuaScriptMgr.GetUnityObject(L, 1, typeof(Camera));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			Transform arg2 = (Transform)LuaScriptMgr.GetUnityObject(L, 3, typeof(Transform));
			Vector3[] o = NGUITools.GetWorldCorners(arg0,arg1,arg2);
			LuaScriptMgr.PushArray(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUITools.GetWorldCorners");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFuncName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object arg0 = LuaScriptMgr.GetVarObject(L, 1);
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		string o = NGUITools.GetFuncName(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

