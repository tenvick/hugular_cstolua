using System;
using UnityEngine;
using LuaInterface;

public class UnityEngine_Rendering_CommandBufferWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Dispose", Dispose),
			new LuaMethod("Release", Release),
			new LuaMethod("Clear", Clear),
			new LuaMethod("DrawMesh", DrawMesh),
			new LuaMethod("DrawRenderer", DrawRenderer),
			new LuaMethod("SetRenderTarget", SetRenderTarget),
			new LuaMethod("Blit", Blit),
			new LuaMethod("GetTemporaryRT", GetTemporaryRT),
			new LuaMethod("ReleaseTemporaryRT", ReleaseTemporaryRT),
			new LuaMethod("ClearRenderTarget", ClearRenderTarget),
			new LuaMethod("SetGlobalFloat", SetGlobalFloat),
			new LuaMethod("SetGlobalVector", SetGlobalVector),
			new LuaMethod("SetGlobalColor", SetGlobalColor),
			new LuaMethod("SetGlobalMatrix", SetGlobalMatrix),
			new LuaMethod("SetGlobalTexture", SetGlobalTexture),
			new LuaMethod("New", _CreateUnityEngine_Rendering_CommandBuffer),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("name", get_name, set_name),
			new LuaField("sizeInBytes", get_sizeInBytes, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rendering.CommandBuffer", typeof(UnityEngine.Rendering.CommandBuffer), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Rendering_CommandBuffer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			UnityEngine.Rendering.CommandBuffer obj = new UnityEngine.Rendering.CommandBuffer();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.New");
		}

		return 0;
	}

	static Type classType = typeof(UnityEngine.Rendering.CommandBuffer);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name name");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index name on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.name);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sizeInBytes(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sizeInBytes");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sizeInBytes on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sizeInBytes);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_name(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name name");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index name on a nil value");
			}
		}

		obj.name = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
		obj.Dispose();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Release(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
		obj.Release();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
		obj.Clear();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawMesh(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 4)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Mesh arg0 = (Mesh)LuaScriptMgr.GetUnityObject(L, 2, typeof(Mesh));
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 3, typeof(Matrix4x4));
			Material arg2 = (Material)LuaScriptMgr.GetUnityObject(L, 4, typeof(Material));
			obj.DrawMesh(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 5)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Mesh arg0 = (Mesh)LuaScriptMgr.GetUnityObject(L, 2, typeof(Mesh));
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 3, typeof(Matrix4x4));
			Material arg2 = (Material)LuaScriptMgr.GetUnityObject(L, 4, typeof(Material));
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			obj.DrawMesh(arg0,arg1,arg2,arg3);
			return 0;
		}
		else if (count == 6)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Mesh arg0 = (Mesh)LuaScriptMgr.GetUnityObject(L, 2, typeof(Mesh));
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 3, typeof(Matrix4x4));
			Material arg2 = (Material)LuaScriptMgr.GetUnityObject(L, 4, typeof(Material));
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			int arg4 = (int)LuaScriptMgr.GetNumber(L, 6);
			obj.DrawMesh(arg0,arg1,arg2,arg3,arg4);
			return 0;
		}
		else if (count == 7)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Mesh arg0 = (Mesh)LuaScriptMgr.GetUnityObject(L, 2, typeof(Mesh));
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 3, typeof(Matrix4x4));
			Material arg2 = (Material)LuaScriptMgr.GetUnityObject(L, 4, typeof(Material));
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			int arg4 = (int)LuaScriptMgr.GetNumber(L, 6);
			MaterialPropertyBlock arg5 = (MaterialPropertyBlock)LuaScriptMgr.GetNetObject(L, 7, typeof(MaterialPropertyBlock));
			obj.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.DrawMesh");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawRenderer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Renderer arg0 = (Renderer)LuaScriptMgr.GetUnityObject(L, 2, typeof(Renderer));
			Material arg1 = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
			obj.DrawRenderer(arg0,arg1);
			return 0;
		}
		else if (count == 4)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Renderer arg0 = (Renderer)LuaScriptMgr.GetUnityObject(L, 2, typeof(Renderer));
			Material arg1 = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			obj.DrawRenderer(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 5)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Renderer arg0 = (Renderer)LuaScriptMgr.GetUnityObject(L, 2, typeof(Renderer));
			Material arg1 = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			obj.DrawRenderer(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.DrawRenderer");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRenderTarget(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			UnityEngine.Rendering.RenderTargetIdentifier arg0 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
			obj.SetRenderTarget(arg0);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.RenderTargetIdentifier[]), typeof(UnityEngine.Rendering.RenderTargetIdentifier)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			UnityEngine.Rendering.RenderTargetIdentifier[] objs0 = LuaScriptMgr.GetArrayObject<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetRenderTarget(objs0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			UnityEngine.Rendering.RenderTargetIdentifier arg0 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetRenderTarget(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.SetRenderTarget");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Blit(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			UnityEngine.Rendering.RenderTargetIdentifier arg0 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			obj.Blit(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Texture arg0 = (Texture)LuaScriptMgr.GetLuaObject(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			obj.Blit(arg0,arg1);
			return 0;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(Material)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			UnityEngine.Rendering.RenderTargetIdentifier arg0 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			obj.Blit(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(Material)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Texture arg0 = (Texture)LuaScriptMgr.GetLuaObject(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			obj.Blit(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(Material), typeof(int)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			UnityEngine.Rendering.RenderTargetIdentifier arg0 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
			obj.Blit(arg0,arg1,arg2,arg3);
			return 0;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(Material), typeof(int)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			Texture arg0 = (Texture)LuaScriptMgr.GetLuaObject(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
			obj.Blit(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.Blit");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTemporaryRT(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 4)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			obj.GetTemporaryRT(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 5)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			obj.GetTemporaryRT(arg0,arg1,arg2,arg3);
			return 0;
		}
		else if (count == 6)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			FilterMode arg4 = (FilterMode)LuaScriptMgr.GetNetObject(L, 6, typeof(FilterMode));
			obj.GetTemporaryRT(arg0,arg1,arg2,arg3,arg4);
			return 0;
		}
		else if (count == 7)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			FilterMode arg4 = (FilterMode)LuaScriptMgr.GetNetObject(L, 6, typeof(FilterMode));
			RenderTextureFormat arg5 = (RenderTextureFormat)LuaScriptMgr.GetNetObject(L, 7, typeof(RenderTextureFormat));
			obj.GetTemporaryRT(arg0,arg1,arg2,arg3,arg4,arg5);
			return 0;
		}
		else if (count == 8)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			FilterMode arg4 = (FilterMode)LuaScriptMgr.GetNetObject(L, 6, typeof(FilterMode));
			RenderTextureFormat arg5 = (RenderTextureFormat)LuaScriptMgr.GetNetObject(L, 7, typeof(RenderTextureFormat));
			RenderTextureReadWrite arg6 = (RenderTextureReadWrite)LuaScriptMgr.GetNetObject(L, 8, typeof(RenderTextureReadWrite));
			obj.GetTemporaryRT(arg0,arg1,arg2,arg3,arg4,arg5,arg6);
			return 0;
		}
		else if (count == 9)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			FilterMode arg4 = (FilterMode)LuaScriptMgr.GetNetObject(L, 6, typeof(FilterMode));
			RenderTextureFormat arg5 = (RenderTextureFormat)LuaScriptMgr.GetNetObject(L, 7, typeof(RenderTextureFormat));
			RenderTextureReadWrite arg6 = (RenderTextureReadWrite)LuaScriptMgr.GetNetObject(L, 8, typeof(RenderTextureReadWrite));
			int arg7 = (int)LuaScriptMgr.GetNumber(L, 9);
			obj.GetTemporaryRT(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.GetTemporaryRT");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReleaseTemporaryRT(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.ReleaseTemporaryRT(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearRenderTarget(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 4)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
			Color arg2 = LuaScriptMgr.GetColor(L, 4);
			obj.ClearRenderTarget(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 5)
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
			Color arg2 = LuaScriptMgr.GetColor(L, 4);
			float arg3 = (float)LuaScriptMgr.GetNumber(L, 5);
			obj.ClearRenderTarget(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.ClearRenderTarget");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalFloat(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(int), typeof(float)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.SetGlobalFloat(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(string), typeof(float)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.SetGlobalFloat(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.SetGlobalFloat");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalVector(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(int), typeof(LuaTable)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Vector4 arg1 = LuaScriptMgr.GetVector4(L, 3);
			obj.SetGlobalVector(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(string), typeof(LuaTable)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Vector4 arg1 = LuaScriptMgr.GetVector4(L, 3);
			obj.SetGlobalVector(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.SetGlobalVector");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalColor(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(int), typeof(LuaTable)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Color arg1 = LuaScriptMgr.GetColor(L, 3);
			obj.SetGlobalColor(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(string), typeof(LuaTable)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Color arg1 = LuaScriptMgr.GetColor(L, 3);
			obj.SetGlobalColor(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.SetGlobalColor");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalMatrix(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(int), typeof(Matrix4x4)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetGlobalMatrix(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(string), typeof(Matrix4x4)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetGlobalMatrix(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.SetGlobalMatrix");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalTexture(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(int), typeof(UnityEngine.Rendering.RenderTargetIdentifier)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetGlobalTexture(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UnityEngine.Rendering.CommandBuffer), typeof(string), typeof(UnityEngine.Rendering.RenderTargetIdentifier)))
		{
			UnityEngine.Rendering.CommandBuffer obj = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObjectSelf(L, 1, "UnityEngine.Rendering.CommandBuffer");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			UnityEngine.Rendering.RenderTargetIdentifier arg1 = (UnityEngine.Rendering.RenderTargetIdentifier)LuaScriptMgr.GetLuaObject(L, 3);
			obj.SetGlobalTexture(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Rendering.CommandBuffer.SetGlobalTexture");
		}

		return 0;
	}
}

