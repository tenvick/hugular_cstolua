using System;
using UnityEngine;
using LuaInterface;

public class GraphicsWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("DrawMesh", DrawMesh),
			new LuaMethod("DrawMeshNow", DrawMeshNow),
			new LuaMethod("DrawProcedural", DrawProcedural),
			new LuaMethod("DrawProceduralIndirect", DrawProceduralIndirect),
			new LuaMethod("DrawTexture", DrawTexture),
			new LuaMethod("ExecuteCommandBuffer", ExecuteCommandBuffer),
			new LuaMethod("Blit", Blit),
			new LuaMethod("BlitMultiTap", BlitMultiTap),
			new LuaMethod("SetRandomWriteTarget", SetRandomWriteTarget),
			new LuaMethod("ClearRandomWriteTargets", ClearRandomWriteTargets),
			new LuaMethod("SetRenderTarget", SetRenderTarget),
			new LuaMethod("New", _CreateGraphics),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("activeColorBuffer", get_activeColorBuffer, null),
			new LuaField("activeDepthBuffer", get_activeDepthBuffer, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Graphics", typeof(Graphics), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGraphics(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Graphics obj = new Graphics();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Graphics.New");
		}

		return 0;
	}

	static Type classType = typeof(Graphics);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activeColorBuffer(IntPtr L)
	{
		LuaScriptMgr.PushValue(L, Graphics.activeColorBuffer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activeDepthBuffer(IntPtr L)
	{
		LuaScriptMgr.PushValue(L, Graphics.activeDepthBuffer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawMesh(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 4)
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetUnityObject(L, 1, typeof(Mesh));
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 2, typeof(Matrix4x4));
			Material arg2 = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3);
			return 0;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(LuaTable), typeof(LuaTable), typeof(Material), typeof(int)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Material arg3 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4);
			return 0;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			Camera arg4 = (Camera)LuaScriptMgr.GetLuaObject(L, 5);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4);
			return 0;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			Camera arg4 = (Camera)LuaScriptMgr.GetLuaObject(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5);
			return 0;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(LuaTable), typeof(LuaTable), typeof(Material), typeof(int), typeof(Camera)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Material arg3 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			Camera arg5 = (Camera)LuaScriptMgr.GetLuaObject(L, 6);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5);
			return 0;
		}
		else if (count == 7 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			Camera arg4 = (Camera)LuaScriptMgr.GetLuaObject(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			MaterialPropertyBlock arg6 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 7);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6);
			return 0;
		}
		else if (count == 7 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(LuaTable), typeof(LuaTable), typeof(Material), typeof(int), typeof(Camera), typeof(int)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Material arg3 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			Camera arg5 = (Camera)LuaScriptMgr.GetLuaObject(L, 6);
			int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6);
			return 0;
		}
		else if (count == 8 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(bool)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			Camera arg4 = (Camera)LuaScriptMgr.GetLuaObject(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			MaterialPropertyBlock arg6 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 7);
			bool arg7 = LuaDLL.lua_toboolean(L, 8);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7);
			return 0;
		}
		else if (count == 8 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(LuaTable), typeof(LuaTable), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Material arg3 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			Camera arg5 = (Camera)LuaScriptMgr.GetLuaObject(L, 6);
			int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
			MaterialPropertyBlock arg7 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 8);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7);
			return 0;
		}
		else if (count == 8 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			Camera arg4 = (Camera)LuaScriptMgr.GetLuaObject(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			MaterialPropertyBlock arg6 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 7);
			UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)LuaScriptMgr.GetLuaObject(L, 8);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7);
			return 0;
		}
		else if (count == 9 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(bool), typeof(bool)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			Camera arg4 = (Camera)LuaScriptMgr.GetLuaObject(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			MaterialPropertyBlock arg6 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 7);
			bool arg7 = LuaDLL.lua_toboolean(L, 8);
			bool arg8 = LuaDLL.lua_toboolean(L, 9);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
			return 0;
		}
		else if (count == 9 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(LuaTable), typeof(LuaTable), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(bool)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Material arg3 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			Camera arg5 = (Camera)LuaScriptMgr.GetLuaObject(L, 6);
			int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
			MaterialPropertyBlock arg7 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 8);
			bool arg8 = LuaDLL.lua_toboolean(L, 9);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
			return 0;
		}
		else if (count == 9 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(LuaTable), typeof(LuaTable), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Material arg3 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			Camera arg5 = (Camera)LuaScriptMgr.GetLuaObject(L, 6);
			int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
			MaterialPropertyBlock arg7 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 8);
			UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)LuaScriptMgr.GetLuaObject(L, 9);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
			return 0;
		}
		else if (count == 9 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(bool)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			Camera arg4 = (Camera)LuaScriptMgr.GetLuaObject(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			MaterialPropertyBlock arg6 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 7);
			UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)LuaScriptMgr.GetLuaObject(L, 8);
			bool arg8 = LuaDLL.lua_toboolean(L, 9);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
			return 0;
		}
		else if (count == 10 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(LuaTable), typeof(LuaTable), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(bool), typeof(bool)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Material arg3 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			Camera arg5 = (Camera)LuaScriptMgr.GetLuaObject(L, 6);
			int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
			MaterialPropertyBlock arg7 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 8);
			bool arg8 = LuaDLL.lua_toboolean(L, 9);
			bool arg9 = LuaDLL.lua_toboolean(L, 10);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
			return 0;
		}
		else if (count == 10 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(LuaTable), typeof(LuaTable), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(bool)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Material arg3 = (Material)LuaScriptMgr.GetLuaObject(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			Camera arg5 = (Camera)LuaScriptMgr.GetLuaObject(L, 6);
			int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
			MaterialPropertyBlock arg7 = (MaterialPropertyBlock)LuaScriptMgr.GetLuaObject(L, 8);
			UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)LuaScriptMgr.GetLuaObject(L, 9);
			bool arg9 = LuaDLL.lua_toboolean(L, 10);
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
			return 0;
		}
		else if (count == 11)
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetUnityObject(L, 1, typeof(Mesh));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Material arg3 = (Material)LuaScriptMgr.GetUnityObject(L, 4, typeof(Material));
			int arg4 = (int)LuaScriptMgr.GetNumber(L, 5);
			Camera arg5 = (Camera)LuaScriptMgr.GetUnityObject(L, 6, typeof(Camera));
			int arg6 = (int)LuaScriptMgr.GetNumber(L, 7);
			MaterialPropertyBlock arg7 = (MaterialPropertyBlock)LuaScriptMgr.GetNetObject(L, 8, typeof(MaterialPropertyBlock));
			UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)LuaScriptMgr.GetNetObject(L, 9, typeof(UnityEngine.Rendering.ShadowCastingMode));
			bool arg9 = LuaScriptMgr.GetBoolean(L, 10);
			Transform arg10 = (Transform)LuaScriptMgr.GetUnityObject(L, 11, typeof(Transform));
			Graphics.DrawMesh(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Graphics.DrawMesh");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawMeshNow(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetUnityObject(L, 1, typeof(Mesh));
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 2, typeof(Matrix4x4));
			Graphics.DrawMeshNow(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(Matrix4x4), typeof(int)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Matrix4x4 arg1 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 2);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 3);
			Graphics.DrawMeshNow(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Mesh), typeof(LuaTable), typeof(LuaTable)))
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetLuaObject(L, 1);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			Graphics.DrawMeshNow(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 4)
		{
			Mesh arg0 = (Mesh)LuaScriptMgr.GetUnityObject(L, 1, typeof(Mesh));
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg2 = LuaScriptMgr.GetQuaternion(L, 3);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			Graphics.DrawMeshNow(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Graphics.DrawMeshNow");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawProcedural(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			MeshTopology arg0 = (MeshTopology)LuaScriptMgr.GetNetObject(L, 1, typeof(MeshTopology));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			Graphics.DrawProcedural(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			MeshTopology arg0 = (MeshTopology)LuaScriptMgr.GetNetObject(L, 1, typeof(MeshTopology));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			Graphics.DrawProcedural(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Graphics.DrawProcedural");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawProceduralIndirect(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			MeshTopology arg0 = (MeshTopology)LuaScriptMgr.GetNetObject(L, 1, typeof(MeshTopology));
			ComputeBuffer arg1 = (ComputeBuffer)LuaScriptMgr.GetNetObject(L, 2, typeof(ComputeBuffer));
			Graphics.DrawProceduralIndirect(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			MeshTopology arg0 = (MeshTopology)LuaScriptMgr.GetNetObject(L, 1, typeof(MeshTopology));
			ComputeBuffer arg1 = (ComputeBuffer)LuaScriptMgr.GetNetObject(L, 2, typeof(ComputeBuffer));
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			Graphics.DrawProceduralIndirect(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Graphics.DrawProceduralIndirect");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawTexture(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
			Texture arg1 = (Texture)LuaScriptMgr.GetUnityObject(L, 2, typeof(Texture));
			Graphics.DrawTexture(arg0,arg1);
			return 0;
		}
		else if (count == 3)
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
			Texture arg1 = (Texture)LuaScriptMgr.GetUnityObject(L, 2, typeof(Texture));
			Material arg2 = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
			Graphics.DrawTexture(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 6)
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
			Texture arg1 = (Texture)LuaScriptMgr.GetUnityObject(L, 2, typeof(Texture));
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg4 = (int)LuaScriptMgr.GetNumber(L, 5);
			int arg5 = (int)LuaScriptMgr.GetNumber(L, 6);
			Graphics.DrawTexture(arg0,arg1,arg2,arg3,arg4,arg5);
			return 0;
		}
		else if (count == 7 && LuaScriptMgr.CheckTypes(L, 1, typeof(Rect), typeof(Texture), typeof(Rect), typeof(int), typeof(int), typeof(int), typeof(int)))
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetLuaObject(L, 1);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 2);
			Rect arg2 = (Rect)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
			Graphics.DrawTexture(arg0,arg1,arg2,arg3,arg4,arg5,arg6);
			return 0;
		}
		else if (count == 7 && LuaScriptMgr.CheckTypes(L, 1, typeof(Rect), typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Material)))
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetLuaObject(L, 1);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 2);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			Material arg6 = (Material)LuaScriptMgr.GetLuaObject(L, 7);
			Graphics.DrawTexture(arg0,arg1,arg2,arg3,arg4,arg5,arg6);
			return 0;
		}
		else if (count == 8 && LuaScriptMgr.CheckTypes(L, 1, typeof(Rect), typeof(Texture), typeof(Rect), typeof(int), typeof(int), typeof(int), typeof(int), typeof(LuaTable)))
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetLuaObject(L, 1);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 2);
			Rect arg2 = (Rect)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
			Color arg7 = LuaScriptMgr.GetColor(L, 8);
			Graphics.DrawTexture(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7);
			return 0;
		}
		else if (count == 8 && LuaScriptMgr.CheckTypes(L, 1, typeof(Rect), typeof(Texture), typeof(Rect), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Material)))
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetLuaObject(L, 1);
			Texture arg1 = (Texture)LuaScriptMgr.GetLuaObject(L, 2);
			Rect arg2 = (Rect)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
			int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
			int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
			Material arg7 = (Material)LuaScriptMgr.GetLuaObject(L, 8);
			Graphics.DrawTexture(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7);
			return 0;
		}
		else if (count == 9)
		{
			Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
			Texture arg1 = (Texture)LuaScriptMgr.GetUnityObject(L, 2, typeof(Texture));
			Rect arg2 = (Rect)LuaScriptMgr.GetNetObject(L, 3, typeof(Rect));
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg4 = (int)LuaScriptMgr.GetNumber(L, 5);
			int arg5 = (int)LuaScriptMgr.GetNumber(L, 6);
			int arg6 = (int)LuaScriptMgr.GetNumber(L, 7);
			Color arg7 = LuaScriptMgr.GetColor(L, 8);
			Material arg8 = (Material)LuaScriptMgr.GetUnityObject(L, 9, typeof(Material));
			Graphics.DrawTexture(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Graphics.DrawTexture");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExecuteCommandBuffer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UnityEngine.Rendering.CommandBuffer arg0 = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObject(L, 1, typeof(UnityEngine.Rendering.CommandBuffer));
		Graphics.ExecuteCommandBuffer(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Blit(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Texture), typeof(Material)))
		{
			Texture arg0 = (Texture)LuaScriptMgr.GetLuaObject(L, 1);
			Material arg1 = (Material)LuaScriptMgr.GetLuaObject(L, 2);
			Graphics.Blit(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Texture), typeof(RenderTexture)))
		{
			Texture arg0 = (Texture)LuaScriptMgr.GetLuaObject(L, 1);
			RenderTexture arg1 = (RenderTexture)LuaScriptMgr.GetLuaObject(L, 2);
			Graphics.Blit(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Texture), typeof(Material), typeof(int)))
		{
			Texture arg0 = (Texture)LuaScriptMgr.GetLuaObject(L, 1);
			Material arg1 = (Material)LuaScriptMgr.GetLuaObject(L, 2);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 3);
			Graphics.Blit(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Texture), typeof(RenderTexture), typeof(Material)))
		{
			Texture arg0 = (Texture)LuaScriptMgr.GetLuaObject(L, 1);
			RenderTexture arg1 = (RenderTexture)LuaScriptMgr.GetLuaObject(L, 2);
			Material arg2 = (Material)LuaScriptMgr.GetLuaObject(L, 3);
			Graphics.Blit(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 4)
		{
			Texture arg0 = (Texture)LuaScriptMgr.GetUnityObject(L, 1, typeof(Texture));
			RenderTexture arg1 = (RenderTexture)LuaScriptMgr.GetUnityObject(L, 2, typeof(RenderTexture));
			Material arg2 = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			Graphics.Blit(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Graphics.Blit");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BlitMultiTap(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		Texture arg0 = (Texture)LuaScriptMgr.GetUnityObject(L, 1, typeof(Texture));
		RenderTexture arg1 = (RenderTexture)LuaScriptMgr.GetUnityObject(L, 2, typeof(RenderTexture));
		Material arg2 = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
		Vector2[] objs3 = LuaScriptMgr.GetParamsObject<Vector2>(L, 4, count - 3);
		Graphics.BlitMultiTap(arg0,arg1,arg2,objs3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRandomWriteTarget(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(ComputeBuffer)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			ComputeBuffer arg1 = (ComputeBuffer)LuaScriptMgr.GetLuaObject(L, 2);
			Graphics.SetRandomWriteTarget(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(RenderTexture)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			RenderTexture arg1 = (RenderTexture)LuaScriptMgr.GetLuaObject(L, 2);
			Graphics.SetRandomWriteTarget(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Graphics.SetRandomWriteTarget");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearRandomWriteTargets(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		Graphics.ClearRandomWriteTargets();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRenderTarget(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			RenderTexture arg0 = (RenderTexture)LuaScriptMgr.GetUnityObject(L, 1, typeof(RenderTexture));
			Graphics.SetRenderTarget(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(RenderBuffer), typeof(RenderBuffer)))
		{
			RenderBuffer arg0 = (RenderBuffer)LuaScriptMgr.GetLuaObject(L, 1);
			RenderBuffer arg1 = (RenderBuffer)LuaScriptMgr.GetLuaObject(L, 2);
			Graphics.SetRenderTarget(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(RenderBuffer[]), typeof(RenderBuffer)))
		{
			RenderBuffer[] objs0 = LuaScriptMgr.GetArrayObject<RenderBuffer>(L, 1);
			RenderBuffer arg1 = (RenderBuffer)LuaScriptMgr.GetLuaObject(L, 2);
			Graphics.SetRenderTarget(objs0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(RenderTexture), typeof(int)))
		{
			RenderTexture arg0 = (RenderTexture)LuaScriptMgr.GetLuaObject(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			Graphics.SetRenderTarget(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(RenderBuffer), typeof(RenderBuffer), typeof(int)))
		{
			RenderBuffer arg0 = (RenderBuffer)LuaScriptMgr.GetLuaObject(L, 1);
			RenderBuffer arg1 = (RenderBuffer)LuaScriptMgr.GetLuaObject(L, 2);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 3);
			Graphics.SetRenderTarget(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(RenderTexture), typeof(int), typeof(CubemapFace)))
		{
			RenderTexture arg0 = (RenderTexture)LuaScriptMgr.GetLuaObject(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			CubemapFace arg2 = (CubemapFace)LuaScriptMgr.GetLuaObject(L, 3);
			Graphics.SetRenderTarget(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 4)
		{
			RenderBuffer arg0 = (RenderBuffer)LuaScriptMgr.GetNetObject(L, 1, typeof(RenderBuffer));
			RenderBuffer arg1 = (RenderBuffer)LuaScriptMgr.GetNetObject(L, 2, typeof(RenderBuffer));
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			CubemapFace arg3 = (CubemapFace)LuaScriptMgr.GetNetObject(L, 4, typeof(CubemapFace));
			Graphics.SetRenderTarget(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Graphics.SetRenderTarget");
		}

		return 0;
	}
}

