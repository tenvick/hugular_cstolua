using System;
using UnityEngine;
using LuaInterface;

public class MaterialPropertyBlockWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("SetFloat", SetFloat),
			new LuaMethod("SetVector", SetVector),
			new LuaMethod("SetColor", SetColor),
			new LuaMethod("SetMatrix", SetMatrix),
			new LuaMethod("SetTexture", SetTexture),
			new LuaMethod("AddFloat", AddFloat),
			new LuaMethod("AddVector", AddVector),
			new LuaMethod("AddColor", AddColor),
			new LuaMethod("AddMatrix", AddMatrix),
			new LuaMethod("AddTexture", AddTexture),
			new LuaMethod("GetFloat", GetFloat),
			new LuaMethod("GetVector", GetVector),
			new LuaMethod("GetMatrix", GetMatrix),
			new LuaMethod("GetTexture", GetTexture),
			new LuaMethod("Clear", Clear),
			new LuaMethod("New", _CreateMaterialPropertyBlock),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.MaterialPropertyBlock", typeof(MaterialPropertyBlock), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMaterialPropertyBlock(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			MaterialPropertyBlock obj = new MaterialPropertyBlock();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.New");
		}

		return 0;
	}

	static Type classType = typeof(MaterialPropertyBlock);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetFloat(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(float)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.SetFloat(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(float)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.SetFloat(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.SetFloat");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetVector(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(LuaTable)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Vector4 arg1 = LuaScriptMgr.GetVector4(L, 3);
			obj.SetVector(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(LuaTable)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Vector4 arg1 = LuaScriptMgr.GetVector4(L, 3);
			obj.SetVector(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.SetVector");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetColor(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(LuaTable)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Color arg1 = LuaScriptMgr.GetColor(L, 3);
			obj.SetColor(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(LuaTable)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Color arg1 = LuaScriptMgr.GetColor(L, 3);
			obj.SetColor(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.SetColor");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetMatrix(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(Matrix4x4)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetMatrix(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(Matrix4x4)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetMatrix(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.SetMatrix");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTexture(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(Texture)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetTexture(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(Texture)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetTexture(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.SetTexture");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddFloat(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(float)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.AddFloat(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(float)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.AddFloat(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.AddFloat");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddVector(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(LuaTable)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Vector4 arg1 = LuaScriptMgr.GetVector4(L, 3);
			obj.AddVector(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(LuaTable)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Vector4 arg1 = LuaScriptMgr.GetVector4(L, 3);
			obj.AddVector(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.AddVector");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddColor(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(LuaTable)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Color arg1 = LuaScriptMgr.GetColor(L, 3);
			obj.AddColor(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(LuaTable)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Color arg1 = LuaScriptMgr.GetColor(L, 3);
			obj.AddColor(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.AddColor");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddMatrix(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(Matrix4x4)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 3);
			obj.AddMatrix(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(Matrix4x4)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 3);
			obj.AddMatrix(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.AddMatrix");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddTexture(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int), typeof(Texture)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 3);
			obj.AddTexture(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string), typeof(Texture)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 3);
			obj.AddTexture(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.AddTexture");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFloat(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float o = obj.GetFloat(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float o = obj.GetFloat(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.GetFloat");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVector(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Vector4 o = obj.GetVector(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Vector4 o = obj.GetVector(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.GetVector");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMatrix(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Matrix4x4 o = obj.GetMatrix(arg0);
			LuaScriptMgr.PushValue(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Matrix4x4 o = obj.GetMatrix(arg0);
			LuaScriptMgr.PushValue(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.GetMatrix");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTexture(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(int)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Texture o = obj.GetTexture(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(MaterialPropertyBlock), typeof(string)))
		{
			MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Texture o = obj.GetTexture(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: MaterialPropertyBlock.GetTexture");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		MaterialPropertyBlock obj = (MaterialPropertyBlock)LuaScriptMgr.GetNetObjectSelf(L, 1, "MaterialPropertyBlock");
		obj.Clear();
		return 0;
	}
}

