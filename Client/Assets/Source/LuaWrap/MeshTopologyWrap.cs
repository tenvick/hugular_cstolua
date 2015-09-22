using System;
using UnityEngine;
using LuaInterface;

public class MeshTopologyWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Triangles", GetTriangles),
		new LuaMethod("Quads", GetQuads),
		new LuaMethod("Lines", GetLines),
		new LuaMethod("LineStrip", GetLineStrip),
		new LuaMethod("Points", GetPoints),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.MeshTopology", typeof(UnityEngine.MeshTopology), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTriangles(IntPtr L)
	{
		LuaScriptMgr.Push(L, MeshTopology.Triangles);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetQuads(IntPtr L)
	{
		LuaScriptMgr.Push(L, MeshTopology.Quads);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLines(IntPtr L)
	{
		LuaScriptMgr.Push(L, MeshTopology.Lines);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLineStrip(IntPtr L)
	{
		LuaScriptMgr.Push(L, MeshTopology.LineStrip);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPoints(IntPtr L)
	{
		LuaScriptMgr.Push(L, MeshTopology.Points);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		MeshTopology o = (MeshTopology)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

