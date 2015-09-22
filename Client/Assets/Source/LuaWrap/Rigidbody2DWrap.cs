using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class Rigidbody2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("MovePosition", MovePosition),
			new LuaMethod("MoveRotation", MoveRotation),
			new LuaMethod("IsSleeping", IsSleeping),
			new LuaMethod("IsAwake", IsAwake),
			new LuaMethod("Sleep", Sleep),
			new LuaMethod("WakeUp", WakeUp),
			new LuaMethod("IsTouching", IsTouching),
			new LuaMethod("IsTouchingLayers", IsTouchingLayers),
			new LuaMethod("AddForce", AddForce),
			new LuaMethod("AddRelativeForce", AddRelativeForce),
			new LuaMethod("AddForceAtPosition", AddForceAtPosition),
			new LuaMethod("AddTorque", AddTorque),
			new LuaMethod("GetPoint", GetPoint),
			new LuaMethod("GetRelativePoint", GetRelativePoint),
			new LuaMethod("GetVector", GetVector),
			new LuaMethod("GetRelativeVector", GetRelativeVector),
			new LuaMethod("GetPointVelocity", GetPointVelocity),
			new LuaMethod("GetRelativePointVelocity", GetRelativePointVelocity),
			new LuaMethod("New", _CreateRigidbody2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("position", get_position, set_position),
			new LuaField("rotation", get_rotation, set_rotation),
			new LuaField("velocity", get_velocity, set_velocity),
			new LuaField("angularVelocity", get_angularVelocity, set_angularVelocity),
			new LuaField("mass", get_mass, set_mass),
			new LuaField("centerOfMass", get_centerOfMass, set_centerOfMass),
			new LuaField("worldCenterOfMass", get_worldCenterOfMass, null),
			new LuaField("inertia", get_inertia, set_inertia),
			new LuaField("drag", get_drag, set_drag),
			new LuaField("angularDrag", get_angularDrag, set_angularDrag),
			new LuaField("gravityScale", get_gravityScale, set_gravityScale),
			new LuaField("isKinematic", get_isKinematic, set_isKinematic),
			new LuaField("fixedAngle", get_fixedAngle, set_fixedAngle),
			new LuaField("simulated", get_simulated, set_simulated),
			new LuaField("interpolation", get_interpolation, set_interpolation),
			new LuaField("sleepMode", get_sleepMode, set_sleepMode),
			new LuaField("collisionDetectionMode", get_collisionDetectionMode, set_collisionDetectionMode),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Rigidbody2D", typeof(Rigidbody2D), regs, fields, typeof(Component));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateRigidbody2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Rigidbody2D obj = new Rigidbody2D();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Rigidbody2D.New");
		}

		return 0;
	}

	static Type classType = typeof(Rigidbody2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_position(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name position");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index position on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.position);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rotation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rotation on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.rotation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_velocity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name velocity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index velocity on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.velocity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_angularVelocity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name angularVelocity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index angularVelocity on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.angularVelocity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mass(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mass");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mass on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.mass);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_centerOfMass(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name centerOfMass");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index centerOfMass on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.centerOfMass);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldCenterOfMass(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name worldCenterOfMass");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index worldCenterOfMass on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.worldCenterOfMass);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inertia(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name inertia");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index inertia on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.inertia);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drag on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.drag);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_angularDrag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name angularDrag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index angularDrag on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.angularDrag);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gravityScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name gravityScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index gravityScale on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.gravityScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isKinematic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isKinematic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isKinematic on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isKinematic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fixedAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fixedAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fixedAngle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fixedAngle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_simulated(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name simulated");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index simulated on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.simulated);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_interpolation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name interpolation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index interpolation on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.interpolation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sleepMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sleepMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sleepMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sleepMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_collisionDetectionMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name collisionDetectionMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index collisionDetectionMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.collisionDetectionMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_position(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name position");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index position on a nil value");
			}
		}

		obj.position = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rotation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rotation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rotation on a nil value");
			}
		}

		obj.rotation = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_velocity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name velocity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index velocity on a nil value");
			}
		}

		obj.velocity = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_angularVelocity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name angularVelocity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index angularVelocity on a nil value");
			}
		}

		obj.angularVelocity = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mass(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mass");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mass on a nil value");
			}
		}

		obj.mass = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_centerOfMass(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name centerOfMass");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index centerOfMass on a nil value");
			}
		}

		obj.centerOfMass = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_inertia(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name inertia");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index inertia on a nil value");
			}
		}

		obj.inertia = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_drag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drag on a nil value");
			}
		}

		obj.drag = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_angularDrag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name angularDrag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index angularDrag on a nil value");
			}
		}

		obj.angularDrag = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_gravityScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name gravityScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index gravityScale on a nil value");
			}
		}

		obj.gravityScale = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isKinematic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isKinematic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isKinematic on a nil value");
			}
		}

		obj.isKinematic = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fixedAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fixedAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fixedAngle on a nil value");
			}
		}

		obj.fixedAngle = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_simulated(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name simulated");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index simulated on a nil value");
			}
		}

		obj.simulated = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_interpolation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name interpolation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index interpolation on a nil value");
			}
		}

		obj.interpolation = (RigidbodyInterpolation2D)LuaScriptMgr.GetNetObject(L, 3, typeof(RigidbodyInterpolation2D));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sleepMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sleepMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sleepMode on a nil value");
			}
		}

		obj.sleepMode = (RigidbodySleepMode2D)LuaScriptMgr.GetNetObject(L, 3, typeof(RigidbodySleepMode2D));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_collisionDetectionMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Rigidbody2D obj = (Rigidbody2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name collisionDetectionMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index collisionDetectionMode on a nil value");
			}
		}

		obj.collisionDetectionMode = (CollisionDetectionMode2D)LuaScriptMgr.GetNetObject(L, 3, typeof(CollisionDetectionMode2D));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MovePosition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		obj.MovePosition(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveRotation(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		obj.MoveRotation(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsSleeping(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		bool o = obj.IsSleeping();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsAwake(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		bool o = obj.IsAwake();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Sleep(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		obj.Sleep();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WakeUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		obj.WakeUp();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsTouching(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		Collider2D arg0 = (Collider2D)LuaScriptMgr.GetUnityObject(L, 2, typeof(Collider2D));
		bool o = obj.IsTouching(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsTouchingLayers(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			bool o = obj.IsTouchingLayers();
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			bool o = obj.IsTouchingLayers(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Rigidbody2D.IsTouchingLayers");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddForce(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
			obj.AddForce(arg0);
			return 0;
		}
		else if (count == 3)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
			ForceMode2D arg1 = (ForceMode2D)LuaScriptMgr.GetNetObject(L, 3, typeof(ForceMode2D));
			obj.AddForce(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Rigidbody2D.AddForce");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddRelativeForce(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
			obj.AddRelativeForce(arg0);
			return 0;
		}
		else if (count == 3)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
			ForceMode2D arg1 = (ForceMode2D)LuaScriptMgr.GetNetObject(L, 3, typeof(ForceMode2D));
			obj.AddRelativeForce(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Rigidbody2D.AddRelativeForce");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddForceAtPosition(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 3);
			obj.AddForceAtPosition(arg0,arg1);
			return 0;
		}
		else if (count == 4)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
			Vector2 arg1 = LuaScriptMgr.GetVector2(L, 3);
			ForceMode2D arg2 = (ForceMode2D)LuaScriptMgr.GetNetObject(L, 4, typeof(ForceMode2D));
			obj.AddForceAtPosition(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Rigidbody2D.AddForceAtPosition");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddTorque(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			obj.AddTorque(arg0);
			return 0;
		}
		else if (count == 3)
		{
			Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			ForceMode2D arg1 = (ForceMode2D)LuaScriptMgr.GetNetObject(L, 3, typeof(ForceMode2D));
			obj.AddTorque(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Rigidbody2D.AddTorque");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPoint(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Vector2 o = obj.GetPoint(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRelativePoint(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Vector2 o = obj.GetRelativePoint(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVector(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Vector2 o = obj.GetVector(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRelativeVector(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Vector2 o = obj.GetRelativeVector(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPointVelocity(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Vector2 o = obj.GetPointVelocity(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRelativePointVelocity(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Rigidbody2D obj = (Rigidbody2D)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Rigidbody2D");
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Vector2 o = obj.GetRelativePointVelocity(arg0);
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

