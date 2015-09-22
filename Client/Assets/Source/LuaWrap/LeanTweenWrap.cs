using System;
using UnityEngine;
using System.Collections;
using LuaInterface;
using Object = UnityEngine.Object;

public class LeanTweenWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("init", init),
			new LuaMethod("reset", reset),
			new LuaMethod("Update", Update),
			new LuaMethod("OnLevelWasLoaded", OnLevelWasLoaded),
			new LuaMethod("update", update),
			new LuaMethod("removeTween", removeTween),
			new LuaMethod("add", add),
			new LuaMethod("closestRot", closestRot),
			new LuaMethod("cancel", cancel),
			new LuaMethod("description", description),
			new LuaMethod("pause", pause),
			new LuaMethod("resume", resume),
			new LuaMethod("isTweening", isTweening),
			new LuaMethod("drawBezierPath", drawBezierPath),
			new LuaMethod("logError", logError),
			new LuaMethod("options", options),
			new LuaMethod("alpha", alpha),
			new LuaMethod("alphaVertex", alphaVertex),
			new LuaMethod("color", color),
			new LuaMethod("delayedCall", delayedCall),
			new LuaMethod("destroyAfter", destroyAfter),
			new LuaMethod("move", move),
			new LuaMethod("moveSpline", moveSpline),
			new LuaMethod("moveSplineLocal", moveSplineLocal),
			new LuaMethod("moveMargin", moveMargin),
			new LuaMethod("moveX", moveX),
			new LuaMethod("moveY", moveY),
			new LuaMethod("moveZ", moveZ),
			new LuaMethod("moveLocal", moveLocal),
			new LuaMethod("moveLocalX", moveLocalX),
			new LuaMethod("moveLocalY", moveLocalY),
			new LuaMethod("moveLocalZ", moveLocalZ),
			new LuaMethod("rotate", rotate),
			new LuaMethod("rotateLocal", rotateLocal),
			new LuaMethod("rotateX", rotateX),
			new LuaMethod("rotateY", rotateY),
			new LuaMethod("rotateZ", rotateZ),
			new LuaMethod("rotateAround", rotateAround),
			new LuaMethod("rotateAroundLocal", rotateAroundLocal),
			new LuaMethod("scale", scale),
			new LuaMethod("scaleX", scaleX),
			new LuaMethod("scaleY", scaleY),
			new LuaMethod("scaleZ", scaleZ),
			new LuaMethod("value", value),
			new LuaMethod("delayedSound", delayedSound),
			new LuaMethod("h", h),
			new LuaMethod("addListener", addListener),
			new LuaMethod("removeListener", removeListener),
			new LuaMethod("dispatchEvent", dispatchEvent),
			new LuaMethod("New", _CreateLeanTween),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("throwErrors", get_throwErrors, set_throwErrors),
			new LuaField("startSearch", get_startSearch, set_startSearch),
			new LuaField("descr", get_descr, set_descr),
			new LuaField("EVENTS_MAX", get_EVENTS_MAX, set_EVENTS_MAX),
			new LuaField("LISTENERS_MAX", get_LISTENERS_MAX, set_LISTENERS_MAX),
			new LuaField("tweenEmpty", get_tweenEmpty, null),
		};

		LuaScriptMgr.RegisterLib(L, "LeanTween", typeof(LeanTween), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLeanTween(IntPtr L)
	{
		LuaDLL.luaL_error(L, "LeanTween class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(LeanTween);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_throwErrors(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTween.throwErrors);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_startSearch(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTween.startSearch);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_descr(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, LeanTween.descr);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EVENTS_MAX(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTween.EVENTS_MAX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LISTENERS_MAX(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTween.LISTENERS_MAX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tweenEmpty(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTween.tweenEmpty);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_throwErrors(IntPtr L)
	{
		LeanTween.throwErrors = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_startSearch(IntPtr L)
	{
		LeanTween.startSearch = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_descr(IntPtr L)
	{
		LeanTween.descr = (LTDescr)LuaScriptMgr.GetNetObject(L, 3, typeof(LTDescr));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_EVENTS_MAX(IntPtr L)
	{
		LeanTween.EVENTS_MAX = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_LISTENERS_MAX(IntPtr L)
	{
		LeanTween.LISTENERS_MAX = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int init(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LeanTween.init();
			return 0;
		}
		else if (count == 1)
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			LeanTween.init(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.init");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int reset(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		LeanTween.reset();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LeanTween obj = (LeanTween)LuaScriptMgr.GetUnityObjectSelf(L, 1, "LeanTween");
		obj.Update();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnLevelWasLoaded(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		LeanTween obj = (LeanTween)LuaScriptMgr.GetUnityObjectSelf(L, 1, "LeanTween");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.OnLevelWasLoaded(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		LeanTween.update();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int removeTween(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		LeanTween.removeTween(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int add(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
		Vector3[] o = LeanTween.add(objs0,arg1);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int closestRot(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float o = LeanTween.closestRot(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int cancel(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			LeanTween.cancel(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(int)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			LeanTween.cancel(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(int)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			LeanTween.cancel(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.cancel");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int description(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		LTDescr o = LeanTween.description(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int pause(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			LeanTween.pause(arg0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			LeanTween.pause(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.pause");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int resume(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			LeanTween.resume(arg0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			LeanTween.resume(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.resume");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int isTweening(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			bool o = LeanTween.isTweening(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			bool o = LeanTween.isTweening(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			bool o = LeanTween.isTweening(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.isTweening");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int drawBezierPath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
		Vector3 arg2 = LuaScriptMgr.GetVector3(L, 3);
		Vector3 arg3 = LuaScriptMgr.GetVector3(L, 4);
		LeanTween.drawBezierPath(arg0,arg1,arg2,arg3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int logError(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		object o = LeanTween.logError(arg0);
		LuaScriptMgr.PushVarObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int options(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LTDescr o = LeanTween.options();
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 1)
		{
			LTDescr arg0 = (LTDescr)LuaScriptMgr.GetNetObject(L, 1, typeof(LTDescr));
			LTDescr o = LeanTween.options(arg0);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.options");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int alpha(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(float), typeof(float)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.alpha(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.alpha(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.alpha(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.alpha(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(float), typeof(float), typeof(Hashtable)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.alpha(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(float), typeof(float), typeof(object[])))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.alpha(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.alpha");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int alphaVertex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		LTDescr o = LeanTween.alphaVertex(arg0,arg1,arg2);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int color(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		Color arg1 = LuaScriptMgr.GetColor(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		LTDescr o = LeanTween.color(arg0,arg1,arg2);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int delayedCall(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(float), typeof(Action<object>)))
		{
			float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
			Action<object> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<object>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushVarObject(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			LTDescr o = LeanTween.delayedCall(arg0,arg1);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(float), typeof(Action)))
		{
			float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
			Action arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = () =>
				{
					func.Call();
				};
			}

			LTDescr o = LeanTween.delayedCall(arg0,arg1);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(float), typeof(LuaInterface.LuaFunction), typeof(object[])))
		{
			float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
			LuaFunction arg1 = LuaScriptMgr.ToLuaFunction(L, 2);
			object[] objs2 = LuaScriptMgr.GetArrayObject<object>(L, 3);
			int o = LeanTween.delayedCall(arg0,arg1,objs2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(float), typeof(string), typeof(Hashtable)))
		{
			float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			Hashtable arg2 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 3);
			int o = LeanTween.delayedCall(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(float), typeof(Action), typeof(object[])))
		{
			float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
			Action arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = () =>
				{
					func.Call();
				};
			}

			object[] objs2 = LuaScriptMgr.GetArrayObject<object>(L, 3);
			int o = LeanTween.delayedCall(arg0,arg1,objs2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(Action)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Action arg2 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (Action)LuaScriptMgr.GetLuaObject(L, 3);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
				arg2 = () =>
				{
					func.Call();
				};
			}

			LTDescr o = LeanTween.delayedCall(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(Action<object>)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Action<object> arg2 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (Action<object>)LuaScriptMgr.GetLuaObject(L, 3);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
				arg2 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushVarObject(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			LTDescr o = LeanTween.delayedCall(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(float), typeof(LuaInterface.LuaFunction), typeof(Hashtable)))
		{
			float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
			LuaFunction arg1 = LuaScriptMgr.ToLuaFunction(L, 2);
			Hashtable arg2 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 3);
			int o = LeanTween.delayedCall(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(LuaInterface.LuaFunction), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			LuaFunction arg2 = LuaScriptMgr.ToLuaFunction(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.delayedCall(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(Action), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Action arg2 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (Action)LuaScriptMgr.GetLuaObject(L, 3);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
				arg2 = () =>
				{
					func.Call();
				};
			}

			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.delayedCall(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(Action<object>), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Action<object> arg2 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (Action<object>)LuaScriptMgr.GetLuaObject(L, 3);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
				arg2 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushVarObject(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.delayedCall(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(string), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			string arg2 = LuaScriptMgr.GetString(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.delayedCall(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(Action), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Action arg2 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (Action)LuaScriptMgr.GetLuaObject(L, 3);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
				arg2 = () =>
				{
					func.Call();
				};
			}

			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.delayedCall(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(string), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			string arg2 = LuaScriptMgr.GetString(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.delayedCall(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.delayedCall");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int destroyAfter(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		LTRect arg0 = (LTRect)LuaScriptMgr.GetNetObject(L, 1, typeof(LTRect));
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		LTDescr o = LeanTween.destroyAfter(arg0,arg1);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int move(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable[]), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.move(arg0,objs1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(LuaTable), typeof(float)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.move(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.move(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.move(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable[]), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.move(arg0,objs1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.move(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.move(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.move(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.move(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable[]), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.move(arg0,objs1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.move");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveSpline(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		LTDescr o = LeanTween.moveSpline(arg0,objs1,arg2);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveSplineLocal(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		LTDescr o = LeanTween.moveSplineLocal(arg0,objs1,arg2);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveMargin(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		LTRect arg0 = (LTRect)LuaScriptMgr.GetNetObject(L, 1, typeof(LTRect));
		Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		LTDescr o = LeanTween.moveMargin(arg0,arg1,arg2);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveX(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.moveX(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.moveX(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.moveX(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.moveX");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveY(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.moveY(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.moveY(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.moveY(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.moveY");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveZ(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.moveZ(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.moveZ(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.moveZ(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.moveZ");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveLocal(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable[]), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.moveLocal(arg0,objs1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.moveLocal(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable[]), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.moveLocal(arg0,objs1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable[]), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3[] objs1 = LuaScriptMgr.GetArrayObject<Vector3>(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.moveLocal(arg0,objs1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.moveLocal(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.moveLocal(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.moveLocal");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveLocalX(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.moveLocalX(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.moveLocalX(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.moveLocalX(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.moveLocalX");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveLocalY(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.moveLocalY(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.moveLocalY(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.moveLocalY(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.moveLocalY");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int moveLocalZ(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.moveLocalZ(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.moveLocalZ(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.moveLocalZ(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.moveLocalZ");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int rotate(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(float), typeof(float)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.rotate(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.rotate(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(float), typeof(float), typeof(Hashtable)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.rotate(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(float), typeof(float), typeof(object[])))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.rotate(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.rotate(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.rotate(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.rotate");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int rotateLocal(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.rotateLocal(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.rotateLocal(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.rotateLocal(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.rotateLocal");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int rotateX(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.rotateX(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.rotateX(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.rotateX(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.rotateX");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int rotateY(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.rotateY(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.rotateY(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.rotateY(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.rotateY");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int rotateZ(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.rotateZ(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.rotateZ(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.rotateZ(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.rotateZ");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int rotateAround(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 4)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			float arg3 = (float)LuaScriptMgr.GetNumber(L, 4);
			LTDescr o = LeanTween.rotateAround(arg0,arg1,arg2,arg3);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			object[] objs4 = LuaScriptMgr.GetArrayObject<object>(L, 5);
			int o = LeanTween.rotateAround(arg0,arg1,arg2,arg3,objs4);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			Hashtable arg4 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 5);
			int o = LeanTween.rotateAround(arg0,arg1,arg2,arg3,arg4);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.rotateAround");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int rotateAroundLocal(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		float arg3 = (float)LuaScriptMgr.GetNumber(L, 4);
		LTDescr o = LeanTween.rotateAroundLocal(arg0,arg1,arg2,arg3);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int scale(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(LuaTable), typeof(float)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.scale(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			LTDescr o = LeanTween.scale(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.scale(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LTRect), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			LTRect arg0 = (LTRect)LuaScriptMgr.GetLuaObject(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.scale(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.scale(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.scale(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.scale");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int scaleX(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.scaleX(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.scaleX(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.scaleX(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.scaleX");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int scaleY(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.scaleY(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.scaleY(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.scaleY(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.scaleY");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int scaleZ(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			LTDescr o = LeanTween.scaleZ(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			object[] objs3 = LuaScriptMgr.GetArrayObject<object>(L, 4);
			int o = LeanTween.scaleZ(arg0,arg1,arg2,objs3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Hashtable arg3 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 4);
			int o = LeanTween.scaleZ(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.scaleZ");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int value(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<float,object>), typeof(float), typeof(float), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<float,object> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<float,object>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0, param1) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					LuaScriptMgr.PushVarObject(L, param1);
					func.PCall(top, 2);
					func.EndPCall(top);
				};
			}

			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			LTDescr o = LeanTween.value(arg0,arg1,arg2,arg3,arg4);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(float), typeof(float), typeof(float), typeof(Hashtable)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			Hashtable arg4 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 5);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string), typeof(float), typeof(float), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<float>), typeof(float), typeof(float), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<float> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<float>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			LTDescr o = LeanTween.value(arg0,arg1,arg2,arg3,arg4);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<Color>), typeof(LuaTable), typeof(LuaTable), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<Color> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<Color>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			Color arg2 = LuaScriptMgr.GetColor(L, 3);
			Color arg3 = LuaScriptMgr.GetColor(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			LTDescr o = LeanTween.value(arg0,arg1,arg2,arg3,arg4);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<Vector3>), typeof(LuaTable), typeof(LuaTable), typeof(float)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<Vector3> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<Vector3>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			Vector3 arg2 = LuaScriptMgr.GetVector3(L, 3);
			Vector3 arg3 = LuaScriptMgr.GetVector3(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			LTDescr o = LeanTween.value(arg0,arg1,arg2,arg3,arg4);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<Vector3>), typeof(LuaTable), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<Vector3> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<Vector3>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			Vector3 arg2 = LuaScriptMgr.GetVector3(L, 3);
			Vector3 arg3 = LuaScriptMgr.GetVector3(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			Hashtable arg5 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,arg5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string), typeof(LuaTable), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			Vector3 arg2 = LuaScriptMgr.GetVector3(L, 3);
			Vector3 arg3 = LuaScriptMgr.GetVector3(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			object[] objs5 = LuaScriptMgr.GetArrayObject<object>(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,objs5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string), typeof(LuaTable), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			Vector3 arg2 = LuaScriptMgr.GetVector3(L, 3);
			Vector3 arg3 = LuaScriptMgr.GetVector3(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			Hashtable arg5 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,arg5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<Vector3,Hashtable>), typeof(LuaTable), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<Vector3,Hashtable> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<Vector3,Hashtable>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0, param1) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					LuaScriptMgr.PushObject(L, param1);
					func.PCall(top, 2);
					func.EndPCall(top);
				};
			}

			Vector3 arg2 = LuaScriptMgr.GetVector3(L, 3);
			Vector3 arg3 = LuaScriptMgr.GetVector3(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			object[] objs5 = LuaScriptMgr.GetArrayObject<object>(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,objs5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<Vector3>), typeof(LuaTable), typeof(LuaTable), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<Vector3> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<Vector3>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			Vector3 arg2 = LuaScriptMgr.GetVector3(L, 3);
			Vector3 arg3 = LuaScriptMgr.GetVector3(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			object[] objs5 = LuaScriptMgr.GetArrayObject<object>(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,objs5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<Vector3,Hashtable>), typeof(LuaTable), typeof(LuaTable), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<Vector3,Hashtable> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<Vector3,Hashtable>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0, param1) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					LuaScriptMgr.PushObject(L, param1);
					func.PCall(top, 2);
					func.EndPCall(top);
				};
			}

			Vector3 arg2 = LuaScriptMgr.GetVector3(L, 3);
			Vector3 arg3 = LuaScriptMgr.GetVector3(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			Hashtable arg5 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,arg5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<float,Hashtable>), typeof(float), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<float,Hashtable> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<float,Hashtable>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0, param1) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					LuaScriptMgr.PushObject(L, param1);
					func.PCall(top, 2);
					func.EndPCall(top);
				};
			}

			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			object[] objs5 = LuaScriptMgr.GetArrayObject<object>(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,objs5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<float>), typeof(float), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<float> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<float>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			object[] objs5 = LuaScriptMgr.GetArrayObject<object>(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,objs5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string), typeof(float), typeof(float), typeof(float), typeof(object[])))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			object[] objs5 = LuaScriptMgr.GetArrayObject<object>(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,objs5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<float,Hashtable>), typeof(float), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<float,Hashtable> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<float,Hashtable>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0, param1) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					LuaScriptMgr.PushObject(L, param1);
					func.PCall(top, 2);
					func.EndPCall(top);
				};
			}

			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			Hashtable arg5 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,arg5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(Action<float>), typeof(float), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			Action<float> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<float>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			Hashtable arg5 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,arg5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string), typeof(float), typeof(float), typeof(float), typeof(Hashtable)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetLuaObject(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
			Hashtable arg5 = (Hashtable)LuaScriptMgr.GetLuaObject(L, 6);
			int o = LeanTween.value(arg0,arg1,arg2,arg3,arg4,arg5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.value");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int delayedSound(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		AudioClip arg0 = (AudioClip)LuaScriptMgr.GetUnityObject(L, 1, typeof(AudioClip));
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		LTDescr o = LeanTween.delayedSound(arg0,arg1,arg2);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int h(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		object[] objs0 = LuaScriptMgr.GetArrayObject<object>(L, 1);
		Hashtable o = LeanTween.h(objs0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int addListener(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			Action<LTEvent> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<LTEvent>)LuaScriptMgr.GetNetObject(L, 2, typeof(Action<LTEvent>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			LeanTween.addListener(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			Action<LTEvent> arg2 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (Action<LTEvent>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<LTEvent>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
				arg2 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			LeanTween.addListener(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.addListener");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int removeListener(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			Action<LTEvent> arg1 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Action<LTEvent>)LuaScriptMgr.GetNetObject(L, 2, typeof(Action<LTEvent>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			bool o = LeanTween.removeListener(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			Action<LTEvent> arg2 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (Action<LTEvent>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<LTEvent>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
				arg2 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			bool o = LeanTween.removeListener(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.removeListener");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int dispatchEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			LeanTween.dispatchEvent(arg0);
			return 0;
		}
		else if (count == 2)
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			object arg1 = LuaScriptMgr.GetVarObject(L, 2);
			LeanTween.dispatchEvent(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LeanTween.dispatchEvent");
		}

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

