using System;
using UnityEngine;
using LuaInterface;

public class NGUIMathWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Lerp", Lerp),
			new LuaMethod("ClampIndex", ClampIndex),
			new LuaMethod("RepeatIndex", RepeatIndex),
			new LuaMethod("WrapAngle", WrapAngle),
			new LuaMethod("Wrap01", Wrap01),
			new LuaMethod("HexToDecimal", HexToDecimal),
			new LuaMethod("DecimalToHexChar", DecimalToHexChar),
			new LuaMethod("DecimalToHex24", DecimalToHex24),
			new LuaMethod("DecimalToHex32", DecimalToHex32),
			new LuaMethod("ColorToInt", ColorToInt),
			new LuaMethod("IntToColor", IntToColor),
			new LuaMethod("IntToBinary", IntToBinary),
			new LuaMethod("HexToColor", HexToColor),
			new LuaMethod("ConvertToTexCoords", ConvertToTexCoords),
			new LuaMethod("ConvertToPixels", ConvertToPixels),
			new LuaMethod("MakePixelPerfect", MakePixelPerfect),
			new LuaMethod("ConstrainRect", ConstrainRect),
			new LuaMethod("SpringDampen", SpringDampen),
			new LuaMethod("SpringLerp", SpringLerp),
			new LuaMethod("RotateTowards", RotateTowards),
			new LuaMethod("DistanceToRectangle", DistanceToRectangle),
			new LuaMethod("AdjustByDPI", AdjustByDPI),
			new LuaMethod("ScreenToPixels", ScreenToPixels),
			new LuaMethod("ScreenToParentPixels", ScreenToParentPixels),
			new LuaMethod("New", _CreateNGUIMath),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaScriptMgr.RegisterLib(L, "NGUIMath", regs);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNGUIMath(IntPtr L)
	{
		LuaDLL.luaL_error(L, "NGUIMath class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(NGUIMath);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lerp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		float o = NGUIMath.Lerp(arg0,arg1,arg2);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClampIndex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		int o = NGUIMath.ClampIndex(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RepeatIndex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		int o = NGUIMath.RepeatIndex(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WrapAngle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float o = NGUIMath.WrapAngle(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Wrap01(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float o = NGUIMath.Wrap01(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HexToDecimal(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		char arg0 = (char)LuaScriptMgr.GetNumber(L, 1);
		int o = NGUIMath.HexToDecimal(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecimalToHexChar(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		char o = NGUIMath.DecimalToHexChar(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecimalToHex24(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		string o = NGUIMath.DecimalToHex24(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecimalToHex32(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		string o = NGUIMath.DecimalToHex32(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ColorToInt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Color arg0 = LuaScriptMgr.GetColor(L, 1);
		int o = NGUIMath.ColorToInt(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToColor(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		Color o = NGUIMath.IntToColor(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToBinary(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		string o = NGUIMath.IntToBinary(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HexToColor(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 1);
		Color o = NGUIMath.HexToColor(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConvertToTexCoords(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
		Rect o = NGUIMath.ConvertToTexCoords(arg0,arg1,arg2);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConvertToPixels(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
		bool arg3 = LuaScriptMgr.GetBoolean(L, 4);
		Rect o = NGUIMath.ConvertToPixels(arg0,arg1,arg2,arg3);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MakePixelPerfect(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
			Rect o = NGUIMath.MakePixelPerfect(arg0);
			LuaScriptMgr.PushValue(L, o);
			return 1;
		}
		else if (count == 3)
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			Rect o = NGUIMath.MakePixelPerfect(arg0,arg1,arg2);
			LuaScriptMgr.PushValue(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUIMath.MakePixelPerfect");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConstrainRect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 1);
		Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
		Vector2 arg2 = LuaScriptMgr.GetVector2(L, 3);
		Vector2 arg3 = LuaScriptMgr.GetVector2(L, 4);
		Vector2 o = NGUIMath.ConstrainRect(arg0,arg1,arg2,arg3);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SpringDampen(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Vector2), typeof(float), typeof(float)))
		{
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Vector2 o = NGUIMath.SpringDampen(ref arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			LuaScriptMgr.Push(L, arg0);
			return 2;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Vector3), typeof(float), typeof(float)))
		{
			Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			Vector3 o = NGUIMath.SpringDampen(ref arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			LuaScriptMgr.Push(L, arg0);
			return 2;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUIMath.SpringDampen");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SpringLerp(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float o = NGUIMath.SpringLerp(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable), typeof(LuaTable), typeof(float), typeof(float)))
		{
			Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			Vector3 o = NGUIMath.SpringLerp(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable), typeof(LuaTable), typeof(float), typeof(float)))
		{
			Quaternion arg0 = LuaScriptMgr.GetQuaternion(L, 1);
			Quaternion arg1 = LuaScriptMgr.GetQuaternion(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			Quaternion o = NGUIMath.SpringLerp(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(float), typeof(float), typeof(float), typeof(float)))
		{
			float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			float o = NGUIMath.SpringLerp(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(LuaTable), typeof(LuaTable), typeof(float), typeof(float)))
		{
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
			Vector2 o = NGUIMath.SpringLerp(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUIMath.SpringLerp");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RotateTowards(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		float o = NGUIMath.RotateTowards(arg0,arg1,arg2);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DistanceToRectangle(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Vector2[] objs0 = LuaScriptMgr.GetArrayObject<Vector2>(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			float o = NGUIMath.DistanceToRectangle(objs0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			Vector3[] objs0 = LuaScriptMgr.GetArrayObject<Vector3>(L, 1);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 2);
			Camera arg2 = (Camera)LuaScriptMgr.GetUnityObject(L, 3, typeof(Camera));
			float o = NGUIMath.DistanceToRectangle(objs0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: NGUIMath.DistanceToRectangle");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AdjustByDPI(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		int o = NGUIMath.AdjustByDPI(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScreenToPixels(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 1);
		Transform arg1 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		Vector2 o = NGUIMath.ScreenToPixels(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScreenToParentPixels(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 1);
		Transform arg1 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		Vector2 o = NGUIMath.ScreenToParentPixels(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

