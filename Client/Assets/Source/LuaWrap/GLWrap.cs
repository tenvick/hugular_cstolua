using System;
using UnityEngine;
using LuaInterface;

public class GLWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Vertex3", Vertex3),
			new LuaMethod("Vertex", Vertex),
			new LuaMethod("Color", Color),
			new LuaMethod("TexCoord", TexCoord),
			new LuaMethod("TexCoord2", TexCoord2),
			new LuaMethod("TexCoord3", TexCoord3),
			new LuaMethod("MultiTexCoord2", MultiTexCoord2),
			new LuaMethod("MultiTexCoord3", MultiTexCoord3),
			new LuaMethod("MultiTexCoord", MultiTexCoord),
			new LuaMethod("Begin", Begin),
			new LuaMethod("End", End),
			new LuaMethod("LoadOrtho", LoadOrtho),
			new LuaMethod("LoadPixelMatrix", LoadPixelMatrix),
			new LuaMethod("Viewport", Viewport),
			new LuaMethod("LoadProjectionMatrix", LoadProjectionMatrix),
			new LuaMethod("LoadIdentity", LoadIdentity),
			new LuaMethod("MultMatrix", MultMatrix),
			new LuaMethod("PushMatrix", PushMatrix),
			new LuaMethod("PopMatrix", PopMatrix),
			new LuaMethod("GetGPUProjectionMatrix", GetGPUProjectionMatrix),
			new LuaMethod("Clear", Clear),
			new LuaMethod("ClearWithSkybox", ClearWithSkybox),
			new LuaMethod("InvalidateState", InvalidateState),
			new LuaMethod("IssuePluginEvent", IssuePluginEvent),
			new LuaMethod("New", _CreateGL),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("TRIANGLES", get_TRIANGLES, null),
			new LuaField("TRIANGLE_STRIP", get_TRIANGLE_STRIP, null),
			new LuaField("QUADS", get_QUADS, null),
			new LuaField("LINES", get_LINES, null),
			new LuaField("modelview", get_modelview, set_modelview),
			new LuaField("wireframe", get_wireframe, set_wireframe),
			new LuaField("sRGBWrite", get_sRGBWrite, set_sRGBWrite),
			new LuaField("invertCulling", get_invertCulling, set_invertCulling),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.GL", typeof(GL), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGL(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			GL obj = new GL();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: GL.New");
		}

		return 0;
	}

	static Type classType = typeof(GL);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TRIANGLES(IntPtr L)
	{
		LuaScriptMgr.Push(L, GL.TRIANGLES);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TRIANGLE_STRIP(IntPtr L)
	{
		LuaScriptMgr.Push(L, GL.TRIANGLE_STRIP);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_QUADS(IntPtr L)
	{
		LuaScriptMgr.Push(L, GL.QUADS);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LINES(IntPtr L)
	{
		LuaScriptMgr.Push(L, GL.LINES);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_modelview(IntPtr L)
	{
		LuaScriptMgr.PushValue(L, GL.modelview);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wireframe(IntPtr L)
	{
		LuaScriptMgr.Push(L, GL.wireframe);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sRGBWrite(IntPtr L)
	{
		LuaScriptMgr.Push(L, GL.sRGBWrite);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_invertCulling(IntPtr L)
	{
		LuaScriptMgr.Push(L, GL.invertCulling);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_modelview(IntPtr L)
	{
		GL.modelview = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 3, typeof(Matrix4x4));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wireframe(IntPtr L)
	{
		GL.wireframe = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sRGBWrite(IntPtr L)
	{
		GL.sRGBWrite = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_invertCulling(IntPtr L)
	{
		GL.invertCulling = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Vertex3(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		GL.Vertex3(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Vertex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		GL.Vertex(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Color(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Color arg0 = LuaScriptMgr.GetColor(L, 1);
		GL.Color(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TexCoord(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 1);
		GL.TexCoord(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TexCoord2(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		GL.TexCoord2(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TexCoord3(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		GL.TexCoord3(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MultiTexCoord2(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		GL.MultiTexCoord2(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MultiTexCoord3(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		float arg3 = (float)LuaScriptMgr.GetNumber(L, 4);
		GL.MultiTexCoord3(arg0,arg1,arg2,arg3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MultiTexCoord(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 2);
		GL.MultiTexCoord(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Begin(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		GL.Begin(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int End(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		GL.End();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadOrtho(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		GL.LoadOrtho();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadPixelMatrix(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			GL.LoadPixelMatrix();
			return 0;
		}
		else if (count == 4)
		{
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
			float arg3 = (float)LuaScriptMgr.GetNumber(L, 4);
			GL.LoadPixelMatrix(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: GL.LoadPixelMatrix");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Viewport(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Rect arg0 = (Rect)LuaScriptMgr.GetNetObject(L, 1, typeof(Rect));
		GL.Viewport(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadProjectionMatrix(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Matrix4x4 arg0 = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 1, typeof(Matrix4x4));
		GL.LoadProjectionMatrix(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadIdentity(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		GL.LoadIdentity();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MultMatrix(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Matrix4x4 arg0 = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 1, typeof(Matrix4x4));
		GL.MultMatrix(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PushMatrix(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		GL.PushMatrix();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PopMatrix(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		GL.PopMatrix();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGPUProjectionMatrix(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Matrix4x4 arg0 = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 1, typeof(Matrix4x4));
		bool arg1 = LuaScriptMgr.GetBoolean(L, 2);
		Matrix4x4 o = GL.GetGPUProjectionMatrix(arg0,arg1);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			bool arg0 = LuaScriptMgr.GetBoolean(L, 1);
			bool arg1 = LuaScriptMgr.GetBoolean(L, 2);
			Color arg2 = LuaScriptMgr.GetColor(L, 3);
			GL.Clear(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 4)
		{
			bool arg0 = LuaScriptMgr.GetBoolean(L, 1);
			bool arg1 = LuaScriptMgr.GetBoolean(L, 2);
			Color arg2 = LuaScriptMgr.GetColor(L, 3);
			float arg3 = (float)LuaScriptMgr.GetNumber(L, 4);
			GL.Clear(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: GL.Clear");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearWithSkybox(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		bool arg0 = LuaScriptMgr.GetBoolean(L, 1);
		Camera arg1 = (Camera)LuaScriptMgr.GetUnityObject(L, 2, typeof(Camera));
		GL.ClearWithSkybox(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InvalidateState(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		GL.InvalidateState();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IssuePluginEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		GL.IssuePluginEvent(arg0);
		return 0;
	}
}

