using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ShaderWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Find", Find),
			new LuaMethod("EnableKeyword", EnableKeyword),
			new LuaMethod("DisableKeyword", DisableKeyword),
			new LuaMethod("IsKeywordEnabled", IsKeywordEnabled),
			new LuaMethod("SetGlobalColor", SetGlobalColor),
			new LuaMethod("SetGlobalVector", SetGlobalVector),
			new LuaMethod("SetGlobalFloat", SetGlobalFloat),
			new LuaMethod("SetGlobalInt", SetGlobalInt),
			new LuaMethod("SetGlobalTexture", SetGlobalTexture),
			new LuaMethod("SetGlobalMatrix", SetGlobalMatrix),
			new LuaMethod("SetGlobalBuffer", SetGlobalBuffer),
			new LuaMethod("PropertyToID", PropertyToID),
			new LuaMethod("WarmupAllShaders", WarmupAllShaders),
			new LuaMethod("New", _CreateShader),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("isSupported", get_isSupported, null),
			new LuaField("maximumLOD", get_maximumLOD, set_maximumLOD),
			new LuaField("globalMaximumLOD", get_globalMaximumLOD, set_globalMaximumLOD),
			new LuaField("renderQueue", get_renderQueue, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Shader", typeof(Shader), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateShader(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Shader obj = new Shader();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Shader.New");
		}

		return 0;
	}

	static Type classType = typeof(Shader);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isSupported(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Shader obj = (Shader)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isSupported");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isSupported on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isSupported);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumLOD(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Shader obj = (Shader)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maximumLOD");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maximumLOD on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.maximumLOD);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_globalMaximumLOD(IntPtr L)
	{
		LuaScriptMgr.Push(L, Shader.globalMaximumLOD);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderQueue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Shader obj = (Shader)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name renderQueue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index renderQueue on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.renderQueue);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumLOD(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Shader obj = (Shader)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maximumLOD");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maximumLOD on a nil value");
			}
		}

		obj.maximumLOD = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_globalMaximumLOD(IntPtr L)
	{
		Shader.globalMaximumLOD = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		Shader o = Shader.Find(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnableKeyword(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		Shader.EnableKeyword(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DisableKeyword(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		Shader.DisableKeyword(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsKeywordEnabled(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		bool o = Shader.IsKeywordEnabled(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalColor(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(LuaTable)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			Shader.SetGlobalColor(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(LuaTable)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			Color arg1 = LuaScriptMgr.GetColor(L, 2);
			Shader.SetGlobalColor(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Shader.SetGlobalColor");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalVector(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(LuaTable)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			Vector4 arg1 = LuaScriptMgr.GetVector4(L, 2);
			Shader.SetGlobalVector(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(LuaTable)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			Vector4 arg1 = LuaScriptMgr.GetVector4(L, 2);
			Shader.SetGlobalVector(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Shader.SetGlobalVector");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalFloat(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(float)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Shader.SetGlobalFloat(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(float)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			Shader.SetGlobalFloat(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Shader.SetGlobalFloat");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalInt(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			Shader.SetGlobalInt(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(int)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			Shader.SetGlobalInt(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Shader.SetGlobalInt");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalTexture(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(Texture)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 2);
			Shader.SetGlobalTexture(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(Texture)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 2);
			Shader.SetGlobalTexture(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Shader.SetGlobalTexture");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalMatrix(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(Matrix4x4)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			Shader.SetGlobalMatrix(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(Matrix4x4)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			Shader.SetGlobalMatrix(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Shader.SetGlobalMatrix");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalBuffer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		ComputeBuffer arg1 = (ComputeBuffer)LuaScriptMgr.GetNetObject(L, 2, typeof(ComputeBuffer));
		Shader.SetGlobalBuffer(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PropertyToID(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		int o = Shader.PropertyToID(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WarmupAllShaders(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		Shader.WarmupAllShaders();
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

