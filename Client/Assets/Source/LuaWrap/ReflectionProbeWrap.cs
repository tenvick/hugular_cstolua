using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ReflectionProbeWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("RenderProbe", RenderProbe),
			new LuaMethod("IsFinishedRendering", IsFinishedRendering),
			new LuaMethod("BlendCubemap", BlendCubemap),
			new LuaMethod("New", _CreateReflectionProbe),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("type", get_type, set_type),
			new LuaField("hdr", get_hdr, set_hdr),
			new LuaField("size", get_size, set_size),
			new LuaField("center", get_center, set_center),
			new LuaField("nearClipPlane", get_nearClipPlane, set_nearClipPlane),
			new LuaField("farClipPlane", get_farClipPlane, set_farClipPlane),
			new LuaField("shadowDistance", get_shadowDistance, set_shadowDistance),
			new LuaField("resolution", get_resolution, set_resolution),
			new LuaField("cullingMask", get_cullingMask, set_cullingMask),
			new LuaField("clearFlags", get_clearFlags, set_clearFlags),
			new LuaField("backgroundColor", get_backgroundColor, set_backgroundColor),
			new LuaField("intensity", get_intensity, set_intensity),
			new LuaField("boxProjection", get_boxProjection, set_boxProjection),
			new LuaField("bounds", get_bounds, null),
			new LuaField("mode", get_mode, set_mode),
			new LuaField("importance", get_importance, set_importance),
			new LuaField("refreshMode", get_refreshMode, set_refreshMode),
			new LuaField("timeSlicingMode", get_timeSlicingMode, set_timeSlicingMode),
			new LuaField("bakedTexture", get_bakedTexture, set_bakedTexture),
			new LuaField("customBakedTexture", get_customBakedTexture, set_customBakedTexture),
			new LuaField("texture", get_texture, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ReflectionProbe", typeof(ReflectionProbe), regs, fields, typeof(Behaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateReflectionProbe(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			ReflectionProbe obj = new ReflectionProbe();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ReflectionProbe.New");
		}

		return 0;
	}

	static Type classType = typeof(ReflectionProbe);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

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
	static int get_hdr(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name hdr");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index hdr on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.hdr);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_size(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name size");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index size on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.size);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_center(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name center");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index center on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.center);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nearClipPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name nearClipPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index nearClipPlane on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.nearClipPlane);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_farClipPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name farClipPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index farClipPlane on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.farClipPlane);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowDistance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowDistance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowDistance on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadowDistance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resolution(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name resolution");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index resolution on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.resolution);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cullingMask(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cullingMask");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cullingMask on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cullingMask);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clearFlags(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clearFlags");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clearFlags on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.clearFlags);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_backgroundColor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name backgroundColor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index backgroundColor on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.backgroundColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_intensity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name intensity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index intensity on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.intensity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_boxProjection(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name boxProjection");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index boxProjection on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.boxProjection);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bounds(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bounds");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bounds on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bounds);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.mode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_importance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name importance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index importance on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.importance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_refreshMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name refreshMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index refreshMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.refreshMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeSlicingMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name timeSlicingMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index timeSlicingMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.timeSlicingMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bakedTexture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bakedTexture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bakedTexture on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bakedTexture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_customBakedTexture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name customBakedTexture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index customBakedTexture on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.customBakedTexture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_texture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name texture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index texture on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.texture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

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

		obj.type = (UnityEngine.Rendering.ReflectionProbeType)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.ReflectionProbeType));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hdr(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name hdr");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index hdr on a nil value");
			}
		}

		obj.hdr = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_size(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name size");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index size on a nil value");
			}
		}

		obj.size = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_center(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name center");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index center on a nil value");
			}
		}

		obj.center = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_nearClipPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name nearClipPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index nearClipPlane on a nil value");
			}
		}

		obj.nearClipPlane = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_farClipPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name farClipPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index farClipPlane on a nil value");
			}
		}

		obj.farClipPlane = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowDistance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowDistance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowDistance on a nil value");
			}
		}

		obj.shadowDistance = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resolution(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name resolution");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index resolution on a nil value");
			}
		}

		obj.resolution = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cullingMask(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cullingMask");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cullingMask on a nil value");
			}
		}

		obj.cullingMask = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clearFlags(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clearFlags");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clearFlags on a nil value");
			}
		}

		obj.clearFlags = (UnityEngine.Rendering.ReflectionProbeClearFlags)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.ReflectionProbeClearFlags));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_backgroundColor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name backgroundColor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index backgroundColor on a nil value");
			}
		}

		obj.backgroundColor = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_intensity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name intensity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index intensity on a nil value");
			}
		}

		obj.intensity = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_boxProjection(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name boxProjection");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index boxProjection on a nil value");
			}
		}

		obj.boxProjection = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mode on a nil value");
			}
		}

		obj.mode = (UnityEngine.Rendering.ReflectionProbeMode)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.ReflectionProbeMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_importance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name importance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index importance on a nil value");
			}
		}

		obj.importance = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_refreshMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name refreshMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index refreshMode on a nil value");
			}
		}

		obj.refreshMode = (UnityEngine.Rendering.ReflectionProbeRefreshMode)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.ReflectionProbeRefreshMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_timeSlicingMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name timeSlicingMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index timeSlicingMode on a nil value");
			}
		}

		obj.timeSlicingMode = (UnityEngine.Rendering.ReflectionProbeTimeSlicingMode)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bakedTexture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bakedTexture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bakedTexture on a nil value");
			}
		}

		obj.bakedTexture = (Texture)LuaScriptMgr.GetUnityObject(L, 3, typeof(Texture));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_customBakedTexture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ReflectionProbe obj = (ReflectionProbe)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name customBakedTexture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index customBakedTexture on a nil value");
			}
		}

		obj.customBakedTexture = (Texture)LuaScriptMgr.GetUnityObject(L, 3, typeof(Texture));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RenderProbe(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			ReflectionProbe obj = (ReflectionProbe)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ReflectionProbe");
			int o = obj.RenderProbe();
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			ReflectionProbe obj = (ReflectionProbe)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ReflectionProbe");
			RenderTexture arg0 = (RenderTexture)LuaScriptMgr.GetUnityObject(L, 2, typeof(RenderTexture));
			int o = obj.RenderProbe(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ReflectionProbe.RenderProbe");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsFinishedRendering(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		ReflectionProbe obj = (ReflectionProbe)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ReflectionProbe");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		bool o = obj.IsFinishedRendering(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BlendCubemap(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		Texture arg0 = (Texture)LuaScriptMgr.GetUnityObject(L, 1, typeof(Texture));
		Texture arg1 = (Texture)LuaScriptMgr.GetUnityObject(L, 2, typeof(Texture));
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 3);
		RenderTexture arg3 = (RenderTexture)LuaScriptMgr.GetUnityObject(L, 4, typeof(RenderTexture));
		bool o = ReflectionProbe.BlendCubemap(arg0,arg1,arg2,arg3);
		LuaScriptMgr.Push(L, o);
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

