using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ClothWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("ClearTransformMotion", ClearTransformMotion),
			new LuaMethod("SetEnabledFading", SetEnabledFading),
			new LuaMethod("New", _CreateCloth),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("sleepThreshold", get_sleepThreshold, set_sleepThreshold),
			new LuaField("bendingStiffness", get_bendingStiffness, set_bendingStiffness),
			new LuaField("stretchingStiffness", get_stretchingStiffness, set_stretchingStiffness),
			new LuaField("damping", get_damping, set_damping),
			new LuaField("externalAcceleration", get_externalAcceleration, set_externalAcceleration),
			new LuaField("randomAcceleration", get_randomAcceleration, set_randomAcceleration),
			new LuaField("useGravity", get_useGravity, set_useGravity),
			new LuaField("enabled", get_enabled, set_enabled),
			new LuaField("vertices", get_vertices, null),
			new LuaField("normals", get_normals, null),
			new LuaField("friction", get_friction, set_friction),
			new LuaField("collisionMassScale", get_collisionMassScale, set_collisionMassScale),
			new LuaField("useContinuousCollision", get_useContinuousCollision, set_useContinuousCollision),
			new LuaField("useVirtualParticles", get_useVirtualParticles, set_useVirtualParticles),
			new LuaField("coefficients", get_coefficients, set_coefficients),
			new LuaField("worldVelocityScale", get_worldVelocityScale, set_worldVelocityScale),
			new LuaField("worldAccelerationScale", get_worldAccelerationScale, set_worldAccelerationScale),
			new LuaField("solverFrequency", get_solverFrequency, set_solverFrequency),
			new LuaField("capsuleColliders", get_capsuleColliders, set_capsuleColliders),
			new LuaField("sphereColliders", get_sphereColliders, set_sphereColliders),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Cloth", typeof(Cloth), regs, fields, typeof(Component));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCloth(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Cloth obj = new Cloth();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Cloth.New");
		}

		return 0;
	}

	static Type classType = typeof(Cloth);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sleepThreshold(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sleepThreshold");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sleepThreshold on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sleepThreshold);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bendingStiffness(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bendingStiffness");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bendingStiffness on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bendingStiffness);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_stretchingStiffness(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name stretchingStiffness");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index stretchingStiffness on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.stretchingStiffness);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_damping(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name damping");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index damping on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.damping);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_externalAcceleration(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name externalAcceleration");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index externalAcceleration on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.externalAcceleration);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_randomAcceleration(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name randomAcceleration");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index randomAcceleration on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.randomAcceleration);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useGravity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useGravity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useGravity on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useGravity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enabled(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name enabled");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index enabled on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.enabled);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_vertices(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name vertices");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index vertices on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.vertices);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_normals(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name normals");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index normals on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.normals);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_friction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name friction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index friction on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.friction);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_collisionMassScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name collisionMassScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index collisionMassScale on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.collisionMassScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useContinuousCollision(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useContinuousCollision");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useContinuousCollision on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useContinuousCollision);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useVirtualParticles(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useVirtualParticles");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useVirtualParticles on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useVirtualParticles);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_coefficients(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name coefficients");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index coefficients on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.coefficients);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldVelocityScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name worldVelocityScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index worldVelocityScale on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.worldVelocityScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldAccelerationScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name worldAccelerationScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index worldAccelerationScale on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.worldAccelerationScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_solverFrequency(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name solverFrequency");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index solverFrequency on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.solverFrequency);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_capsuleColliders(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name capsuleColliders");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index capsuleColliders on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.capsuleColliders);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sphereColliders(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sphereColliders");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sphereColliders on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.sphereColliders);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sleepThreshold(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sleepThreshold");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sleepThreshold on a nil value");
			}
		}

		obj.sleepThreshold = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bendingStiffness(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bendingStiffness");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bendingStiffness on a nil value");
			}
		}

		obj.bendingStiffness = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_stretchingStiffness(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name stretchingStiffness");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index stretchingStiffness on a nil value");
			}
		}

		obj.stretchingStiffness = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_damping(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name damping");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index damping on a nil value");
			}
		}

		obj.damping = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_externalAcceleration(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name externalAcceleration");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index externalAcceleration on a nil value");
			}
		}

		obj.externalAcceleration = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_randomAcceleration(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name randomAcceleration");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index randomAcceleration on a nil value");
			}
		}

		obj.randomAcceleration = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useGravity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useGravity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useGravity on a nil value");
			}
		}

		obj.useGravity = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_enabled(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name enabled");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index enabled on a nil value");
			}
		}

		obj.enabled = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_friction(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name friction");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index friction on a nil value");
			}
		}

		obj.friction = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_collisionMassScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name collisionMassScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index collisionMassScale on a nil value");
			}
		}

		obj.collisionMassScale = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useContinuousCollision(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useContinuousCollision");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useContinuousCollision on a nil value");
			}
		}

		obj.useContinuousCollision = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useVirtualParticles(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useVirtualParticles");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useVirtualParticles on a nil value");
			}
		}

		obj.useVirtualParticles = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_coefficients(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name coefficients");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index coefficients on a nil value");
			}
		}

		obj.coefficients = LuaScriptMgr.GetArrayObject<ClothSkinningCoefficient>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_worldVelocityScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name worldVelocityScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index worldVelocityScale on a nil value");
			}
		}

		obj.worldVelocityScale = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_worldAccelerationScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name worldAccelerationScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index worldAccelerationScale on a nil value");
			}
		}

		obj.worldAccelerationScale = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_solverFrequency(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name solverFrequency");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index solverFrequency on a nil value");
			}
		}

		obj.solverFrequency = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_capsuleColliders(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name capsuleColliders");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index capsuleColliders on a nil value");
			}
		}

		obj.capsuleColliders = LuaScriptMgr.GetArrayObject<CapsuleCollider>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sphereColliders(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Cloth obj = (Cloth)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sphereColliders");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sphereColliders on a nil value");
			}
		}

		obj.sphereColliders = LuaScriptMgr.GetArrayObject<ClothSphereColliderPair>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearTransformMotion(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Cloth obj = (Cloth)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cloth");
		obj.ClearTransformMotion();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetEnabledFading(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Cloth obj = (Cloth)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cloth");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			obj.SetEnabledFading(arg0);
			return 0;
		}
		else if (count == 3)
		{
			Cloth obj = (Cloth)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Cloth");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
			obj.SetEnabledFading(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Cloth.SetEnabledFading");
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

