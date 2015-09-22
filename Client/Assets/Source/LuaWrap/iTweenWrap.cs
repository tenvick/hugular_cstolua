using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class iTweenWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Init", Init),
			new LuaMethod("CameraFadeFrom", CameraFadeFrom),
			new LuaMethod("CameraFadeTo", CameraFadeTo),
			new LuaMethod("ValueTo", ValueTo),
			new LuaMethod("FadeFrom", FadeFrom),
			new LuaMethod("FadeTo", FadeTo),
			new LuaMethod("ColorFrom", ColorFrom),
			new LuaMethod("ColorTo", ColorTo),
			new LuaMethod("AudioFrom", AudioFrom),
			new LuaMethod("AudioTo", AudioTo),
			new LuaMethod("Stab", Stab),
			new LuaMethod("LookFrom", LookFrom),
			new LuaMethod("LookTo", LookTo),
			new LuaMethod("MoveTo", MoveTo),
			new LuaMethod("MoveFrom", MoveFrom),
			new LuaMethod("MoveAdd", MoveAdd),
			new LuaMethod("MoveBy", MoveBy),
			new LuaMethod("ScaleTo", ScaleTo),
			new LuaMethod("ScaleFrom", ScaleFrom),
			new LuaMethod("ScaleAdd", ScaleAdd),
			new LuaMethod("ScaleBy", ScaleBy),
			new LuaMethod("RotateTo", RotateTo),
			new LuaMethod("RotateFrom", RotateFrom),
			new LuaMethod("RotateAdd", RotateAdd),
			new LuaMethod("RotateBy", RotateBy),
			new LuaMethod("ShakePosition", ShakePosition),
			new LuaMethod("ShakeScale", ShakeScale),
			new LuaMethod("ShakeRotation", ShakeRotation),
			new LuaMethod("PunchPosition", PunchPosition),
			new LuaMethod("PunchRotation", PunchRotation),
			new LuaMethod("PunchScale", PunchScale),
			new LuaMethod("RectUpdate", RectUpdate),
			new LuaMethod("Vector3Update", Vector3Update),
			new LuaMethod("Vector2Update", Vector2Update),
			new LuaMethod("FloatUpdate", FloatUpdate),
			new LuaMethod("FadeUpdate", FadeUpdate),
			new LuaMethod("ColorUpdate", ColorUpdate),
			new LuaMethod("AudioUpdate", AudioUpdate),
			new LuaMethod("RotateUpdate", RotateUpdate),
			new LuaMethod("ScaleUpdate", ScaleUpdate),
			new LuaMethod("MoveUpdate", MoveUpdate),
			new LuaMethod("LookUpdate", LookUpdate),
			new LuaMethod("PathLength", PathLength),
			new LuaMethod("CameraTexture", CameraTexture),
			new LuaMethod("PutOnPath", PutOnPath),
			new LuaMethod("PointOnPath", PointOnPath),
			new LuaMethod("DrawLine", DrawLine),
			new LuaMethod("DrawLineGizmos", DrawLineGizmos),
			new LuaMethod("DrawLineHandles", DrawLineHandles),
			new LuaMethod("DrawPath", DrawPath),
			new LuaMethod("DrawPathGizmos", DrawPathGizmos),
			new LuaMethod("DrawPathHandles", DrawPathHandles),
			new LuaMethod("CameraFadeDepth", CameraFadeDepth),
			new LuaMethod("CameraFadeDestroy", CameraFadeDestroy),
			new LuaMethod("CameraFadeSwap", CameraFadeSwap),
			new LuaMethod("CameraFadeAdd", CameraFadeAdd),
			new LuaMethod("Resume", Resume),
			new LuaMethod("Pause", Pause),
			new LuaMethod("Count", Count),
			new LuaMethod("Stop", Stop),
			new LuaMethod("StopByName", StopByName),
			new LuaMethod("Hash", Hash),
			new LuaMethod("HashLua", HashLua),
			new LuaMethod("New", _CreateiTween),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("tweens", get_tweens, set_tweens),
			new LuaField("id", get_id, set_id),
			new LuaField("type", get_type, set_type),
			new LuaField("method", get_method, set_method),
			new LuaField("easeType", get_easeType, set_easeType),
			new LuaField("time", get_time, set_time),
			new LuaField("delay", get_delay, set_delay),
			new LuaField("loopType", get_loopType, set_loopType),
			new LuaField("isRunning", get_isRunning, set_isRunning),
			new LuaField("isPaused", get_isPaused, set_isPaused),
			new LuaField("_name", get__name, set__name),
		};

		LuaScriptMgr.RegisterLib(L, "iTween", typeof(iTween), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateiTween(IntPtr L)
	{
		LuaDLL.luaL_error(L, "iTween class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(iTween);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tweens(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, iTween.tweens);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_id(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name id");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index id on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.id);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index type on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.type);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_method(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name method");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index method on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.method);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_easeType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name easeType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index easeType on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.easeType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_time(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name time");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index time on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.time);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_delay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name delay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index delay on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.delay);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loopType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name loopType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index loopType on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.loopType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isRunning(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isRunning");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isRunning on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isRunning);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPaused(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isPaused");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isPaused on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isPaused);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get__name(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name _name");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index _name on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj._name);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tweens(IntPtr L)
	{
		iTween.tweens = (List<Hashtable>)LuaScriptMgr.GetNetObject(L, 3, typeof(List<Hashtable>));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_id(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name id");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index id on a nil value");
			}
		}

		obj.id = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index type on a nil value");
			}
		}

		obj.type = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_method(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name method");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index method on a nil value");
			}
		}

		obj.method = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_easeType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name easeType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index easeType on a nil value");
			}
		}

		obj.easeType = (iTween.EaseType)LuaScriptMgr.GetNetObject(L, 3, typeof(iTween.EaseType));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_time(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name time");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index time on a nil value");
			}
		}

		obj.time = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_delay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name delay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index delay on a nil value");
			}
		}

		obj.delay = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_loopType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name loopType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index loopType on a nil value");
			}
		}

		obj.loopType = (iTween.LoopType)LuaScriptMgr.GetNetObject(L, 3, typeof(iTween.LoopType));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isRunning(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isRunning");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isRunning on a nil value");
			}
		}

		obj.isRunning = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isPaused(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isPaused");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isPaused on a nil value");
			}
		}

		obj.isPaused = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set__name(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		iTween obj = (iTween)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name _name");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index _name on a nil value");
			}
		}

		obj._name = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		iTween.Init(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CameraFadeFrom(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Hashtable arg0 = (Hashtable)LuaScriptMgr.GetNetObject(L, 1, typeof(Hashtable));
			iTween.CameraFadeFrom(arg0);
			return 0;
		}
		else if (count == 2)
		{
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			iTween.CameraFadeFrom(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.CameraFadeFrom");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CameraFadeTo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Hashtable arg0 = (Hashtable)LuaScriptMgr.GetNetObject(L, 1, typeof(Hashtable));
			iTween.CameraFadeTo(arg0);
			return 0;
		}
		else if (count == 2)
		{
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			iTween.CameraFadeTo(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.CameraFadeTo");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ValueTo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
		iTween.ValueTo(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FadeFrom(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.FadeFrom(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.FadeFrom(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.FadeFrom");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FadeTo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.FadeTo(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.FadeTo(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.FadeTo");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ColorFrom(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ColorFrom(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ColorFrom(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ColorFrom");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ColorTo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ColorTo(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ColorTo(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ColorTo");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AudioFrom(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.AudioFrom(arg0,arg1);
			return 0;
		}
		else if (count == 4)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			float arg3 = (float)LuaScriptMgr.GetNumber(L, 4);
			iTween.AudioFrom(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.AudioFrom");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AudioTo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.AudioTo(arg0,arg1);
			return 0;
		}
		else if (count == 4)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			float arg3 = (float)LuaScriptMgr.GetNumber(L, 4);
			iTween.AudioTo(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.AudioTo");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stab(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.Stab(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			AudioClip arg1 = (AudioClip)LuaScriptMgr.GetUnityObject(L, 2, typeof(AudioClip));
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.Stab(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.Stab");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LookFrom(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.LookFrom(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.LookFrom(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.LookFrom");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LookTo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.LookTo(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.LookTo(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.LookTo");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveTo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.MoveTo(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.MoveTo(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.MoveTo");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveFrom(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.MoveFrom(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.MoveFrom(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.MoveFrom");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveAdd(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.MoveAdd(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.MoveAdd(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.MoveAdd");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveBy(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.MoveBy(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.MoveBy(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.MoveBy");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScaleTo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ScaleTo(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ScaleTo(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ScaleTo");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScaleFrom(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ScaleFrom(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ScaleFrom(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ScaleFrom");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScaleAdd(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ScaleAdd(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ScaleAdd(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ScaleAdd");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScaleBy(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ScaleBy(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ScaleBy(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ScaleBy");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RotateTo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.RotateTo(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.RotateTo(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.RotateTo");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RotateFrom(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.RotateFrom(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.RotateFrom(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.RotateFrom");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RotateAdd(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.RotateAdd(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.RotateAdd(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.RotateAdd");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RotateBy(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.RotateBy(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.RotateBy(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.RotateBy");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShakePosition(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ShakePosition(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ShakePosition(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ShakePosition");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShakeScale(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ShakeScale(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ShakeScale(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ShakeScale");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShakeRotation(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ShakeRotation(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ShakeRotation(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ShakeRotation");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PunchPosition(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.PunchPosition(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.PunchPosition(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.PunchPosition");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PunchRotation(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.PunchRotation(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.PunchRotation(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.PunchRotation");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PunchScale(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.PunchScale(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.PunchScale(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.PunchScale");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RectUpdate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
		Rect arg1 = (Rect)LuaScriptMgr.GetNetObject(L, 2, typeof(Rect));
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		Rect o = iTween.RectUpdate(arg0,arg1,arg2);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Vector3Update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		Vector3 o = iTween.Vector3Update(arg0,arg1,arg2);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Vector2Update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 1);
		Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		Vector2 o = iTween.Vector2Update(arg0,arg1,arg2);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FloatUpdate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		float o = iTween.FloatUpdate(arg0,arg1,arg2);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FadeUpdate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.FadeUpdate(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.FadeUpdate(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.FadeUpdate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ColorUpdate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ColorUpdate(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ColorUpdate(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ColorUpdate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AudioUpdate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.AudioUpdate(arg0,arg1);
			return 0;
		}
		else if (count == 4)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			float arg3 = (float)LuaScriptMgr.GetNumber(L, 4);
			iTween.AudioUpdate(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.AudioUpdate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RotateUpdate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.RotateUpdate(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.RotateUpdate(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.RotateUpdate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScaleUpdate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.ScaleUpdate(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.ScaleUpdate(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.ScaleUpdate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveUpdate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.MoveUpdate(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.MoveUpdate(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.MoveUpdate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LookUpdate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Hashtable arg1 = (Hashtable)LuaScriptMgr.GetNetObject(L, 2, typeof(Hashtable));
			iTween.LookUpdate(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			iTween.LookUpdate(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.LookUpdate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PathLength(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[])))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			float o = iTween.PathLength(objs0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[])))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			float o = iTween.PathLength(objs0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.PathLength");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CameraTexture(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Color arg0 = LuaScriptMgr.GetColor(L, 1);
		Texture2D o = iTween.CameraTexture(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PutOnPath(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Transform[]), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Transform[] objs1 = LuaScriptMgr.GetArrayObject<Transform>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			iTween.PutOnPath(arg0,objs1,arg2);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform), typeof(Transform[]), typeof(float)))
		{
			Transform arg0 = (Transform)LuaScriptMgr.GetLuaObject(L, 1);
			Transform[] objs1 = LuaScriptMgr.GetArrayObject<Transform>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			iTween.PutOnPath(arg0,objs1,arg2);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable[]), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			iTween.PutOnPath(arg0,objs1,arg2);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform), typeof(LuaTable[]), typeof(float)))
		{
			Transform arg0 = (Transform)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			iTween.PutOnPath(arg0,objs1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.PutOnPath");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PointOnPath(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[]), typeof(float)))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Vector3 o = iTween.PointOnPath(objs0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[]), typeof(float)))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Vector3 o = iTween.PointOnPath(objs0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.PointOnPath");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawLine(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[])))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			iTween.DrawLine(objs0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[])))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			iTween.DrawLine(objs0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[]), typeof(LuaTable)))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawLine(objs0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[]), typeof(LuaTable)))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawLine(objs0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.DrawLine");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawLineGizmos(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[])))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			iTween.DrawLineGizmos(objs0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[])))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			iTween.DrawLineGizmos(objs0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[]), typeof(LuaTable)))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawLineGizmos(objs0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[]), typeof(LuaTable)))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawLineGizmos(objs0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.DrawLineGizmos");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawLineHandles(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[])))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			iTween.DrawLineHandles(objs0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[])))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			iTween.DrawLineHandles(objs0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[]), typeof(LuaTable)))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawLineHandles(objs0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[]), typeof(LuaTable)))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawLineHandles(objs0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.DrawLineHandles");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawPath(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[])))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			iTween.DrawPath(objs0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[])))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			iTween.DrawPath(objs0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[]), typeof(LuaTable)))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawPath(objs0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[]), typeof(LuaTable)))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawPath(objs0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.DrawPath");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawPathGizmos(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[])))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			iTween.DrawPathGizmos(objs0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[])))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			iTween.DrawPathGizmos(objs0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[]), typeof(LuaTable)))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawPathGizmos(objs0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[]), typeof(LuaTable)))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawPathGizmos(objs0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.DrawPathGizmos");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawPathHandles(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[])))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			iTween.DrawPathHandles(objs0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[])))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			iTween.DrawPathHandles(objs0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform[]), typeof(LuaTable)))
		{
			Transform[] objs0 = LuaScriptMgr.GetArrayObject<Transform>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawPathHandles(objs0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable[]), typeof(LuaTable)))
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			iTween.DrawPathHandles(objs0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.DrawPathHandles");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CameraFadeDepth(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		iTween.CameraFadeDepth(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CameraFadeDestroy(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		iTween.CameraFadeDestroy();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CameraFadeSwap(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Texture2D arg0 = (Texture2D)LuaScriptMgr.GetUnityObject(L, 1, typeof(Texture2D));
		iTween.CameraFadeSwap(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CameraFadeAdd(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			GameObject o = iTween.CameraFadeAdd();
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1)
		{
			Texture2D arg0 = (Texture2D)LuaScriptMgr.GetUnityObject(L, 1, typeof(Texture2D));
			GameObject o = iTween.CameraFadeAdd(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			Texture2D arg0 = (Texture2D)LuaScriptMgr.GetUnityObject(L, 1, typeof(Texture2D));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			GameObject o = iTween.CameraFadeAdd(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.CameraFadeAdd");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Resume(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			iTween.Resume();
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			iTween.Resume(arg0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			iTween.Resume(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(bool)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			bool arg1 = LuaDLL.lua_toboolean(L, 2);
			iTween.Resume(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			iTween.Resume(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			string arg1 = LuaScriptMgr.GetLuaString(L, 2);
			bool arg2 = LuaScriptMgr.GetBoolean(L, 3);
			iTween.Resume(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.Resume");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Pause(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			iTween.Pause();
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			iTween.Pause(arg0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			iTween.Pause(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(bool)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			bool arg1 = LuaDLL.lua_toboolean(L, 2);
			iTween.Pause(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			iTween.Pause(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			string arg1 = LuaScriptMgr.GetLuaString(L, 2);
			bool arg2 = LuaScriptMgr.GetBoolean(L, 3);
			iTween.Pause(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.Pause");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Count(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			int o = iTween.Count();
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			int o = iTween.Count(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			int o = iTween.Count(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			string arg1 = LuaScriptMgr.GetLuaString(L, 2);
			int o = iTween.Count(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.Count");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			iTween.Stop();
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			iTween.Stop(arg0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			iTween.Stop(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			iTween.Stop(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(bool)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			bool arg1 = LuaDLL.lua_toboolean(L, 2);
			iTween.Stop(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			string arg1 = LuaScriptMgr.GetLuaString(L, 2);
			bool arg2 = LuaScriptMgr.GetBoolean(L, 3);
			iTween.Stop(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.Stop");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopByName(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			iTween.StopByName(arg0);
			return 0;
		}
		else if (count == 2)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			string arg1 = LuaScriptMgr.GetLuaString(L, 2);
			iTween.StopByName(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			string arg1 = LuaScriptMgr.GetLuaString(L, 2);
			bool arg2 = LuaScriptMgr.GetBoolean(L, 3);
			iTween.StopByName(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: iTween.StopByName");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Hash(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		object[] objs0 = LuaScriptMgr.GetParamsObject(L, 1, count);
		Hashtable o = iTween.Hash(objs0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HashLua(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaTable arg0 = LuaScriptMgr.GetLuaTable(L, 1);
		Hashtable o = iTween.HashLua(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
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

