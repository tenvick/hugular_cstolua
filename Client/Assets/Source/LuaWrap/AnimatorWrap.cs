using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class AnimatorWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetFloat", GetFloat),
			new LuaMethod("SetFloat", SetFloat),
			new LuaMethod("GetBool", GetBool),
			new LuaMethod("SetBool", SetBool),
			new LuaMethod("GetInteger", GetInteger),
			new LuaMethod("SetInteger", SetInteger),
			new LuaMethod("SetTrigger", SetTrigger),
			new LuaMethod("ResetTrigger", ResetTrigger),
			new LuaMethod("IsParameterControlledByCurve", IsParameterControlledByCurve),
			new LuaMethod("GetIKPosition", GetIKPosition),
			new LuaMethod("SetIKPosition", SetIKPosition),
			new LuaMethod("GetIKRotation", GetIKRotation),
			new LuaMethod("SetIKRotation", SetIKRotation),
			new LuaMethod("GetIKPositionWeight", GetIKPositionWeight),
			new LuaMethod("SetIKPositionWeight", SetIKPositionWeight),
			new LuaMethod("GetIKRotationWeight", GetIKRotationWeight),
			new LuaMethod("SetIKRotationWeight", SetIKRotationWeight),
			new LuaMethod("GetIKHintPosition", GetIKHintPosition),
			new LuaMethod("SetIKHintPosition", SetIKHintPosition),
			new LuaMethod("GetIKHintPositionWeight", GetIKHintPositionWeight),
			new LuaMethod("SetIKHintPositionWeight", SetIKHintPositionWeight),
			new LuaMethod("SetLookAtPosition", SetLookAtPosition),
			new LuaMethod("SetLookAtWeight", SetLookAtWeight),
			new LuaMethod("GetLayerName", GetLayerName),
			new LuaMethod("GetLayerIndex", GetLayerIndex),
			new LuaMethod("GetLayerWeight", GetLayerWeight),
			new LuaMethod("SetLayerWeight", SetLayerWeight),
			new LuaMethod("GetCurrentAnimatorStateInfo", GetCurrentAnimatorStateInfo),
			new LuaMethod("GetNextAnimatorStateInfo", GetNextAnimatorStateInfo),
			new LuaMethod("GetAnimatorTransitionInfo", GetAnimatorTransitionInfo),
			new LuaMethod("GetCurrentAnimatorClipInfo", GetCurrentAnimatorClipInfo),
			new LuaMethod("GetNextAnimatorClipInfo", GetNextAnimatorClipInfo),
			new LuaMethod("IsInTransition", IsInTransition),
			new LuaMethod("MatchTarget", MatchTarget),
			new LuaMethod("InterruptMatchTarget", InterruptMatchTarget),
			new LuaMethod("CrossFade", CrossFade),
			new LuaMethod("Play", Play),
			new LuaMethod("SetTarget", SetTarget),
			new LuaMethod("GetBoneTransform", GetBoneTransform),
			new LuaMethod("StartPlayback", StartPlayback),
			new LuaMethod("StopPlayback", StopPlayback),
			new LuaMethod("StartRecording", StartRecording),
			new LuaMethod("StopRecording", StopRecording),
			new LuaMethod("HasState", HasState),
			new LuaMethod("StringToHash", StringToHash),
			new LuaMethod("Update", Update),
			new LuaMethod("Rebind", Rebind),
			new LuaMethod("New", _CreateAnimator),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("isOptimizable", get_isOptimizable, null),
			new LuaField("isHuman", get_isHuman, null),
			new LuaField("hasRootMotion", get_hasRootMotion, null),
			new LuaField("humanScale", get_humanScale, null),
			new LuaField("deltaPosition", get_deltaPosition, null),
			new LuaField("deltaRotation", get_deltaRotation, null),
			new LuaField("velocity", get_velocity, null),
			new LuaField("angularVelocity", get_angularVelocity, null),
			new LuaField("rootPosition", get_rootPosition, set_rootPosition),
			new LuaField("rootRotation", get_rootRotation, set_rootRotation),
			new LuaField("applyRootMotion", get_applyRootMotion, set_applyRootMotion),
			new LuaField("linearVelocityBlending", get_linearVelocityBlending, set_linearVelocityBlending),
			new LuaField("updateMode", get_updateMode, set_updateMode),
			new LuaField("hasTransformHierarchy", get_hasTransformHierarchy, null),
			new LuaField("gravityWeight", get_gravityWeight, null),
			new LuaField("bodyPosition", get_bodyPosition, set_bodyPosition),
			new LuaField("bodyRotation", get_bodyRotation, set_bodyRotation),
			new LuaField("stabilizeFeet", get_stabilizeFeet, set_stabilizeFeet),
			new LuaField("layerCount", get_layerCount, null),
			new LuaField("parameters", get_parameters, null),
			new LuaField("feetPivotActive", get_feetPivotActive, set_feetPivotActive),
			new LuaField("pivotWeight", get_pivotWeight, null),
			new LuaField("pivotPosition", get_pivotPosition, null),
			new LuaField("isMatchingTarget", get_isMatchingTarget, null),
			new LuaField("speed", get_speed, set_speed),
			new LuaField("targetPosition", get_targetPosition, null),
			new LuaField("targetRotation", get_targetRotation, null),
			new LuaField("cullingMode", get_cullingMode, set_cullingMode),
			new LuaField("playbackTime", get_playbackTime, set_playbackTime),
			new LuaField("recorderStartTime", get_recorderStartTime, set_recorderStartTime),
			new LuaField("recorderStopTime", get_recorderStopTime, set_recorderStopTime),
			new LuaField("recorderMode", get_recorderMode, null),
			new LuaField("runtimeAnimatorController", get_runtimeAnimatorController, set_runtimeAnimatorController),
			new LuaField("avatar", get_avatar, set_avatar),
			new LuaField("layersAffectMassCenter", get_layersAffectMassCenter, set_layersAffectMassCenter),
			new LuaField("leftFeetBottomHeight", get_leftFeetBottomHeight, null),
			new LuaField("rightFeetBottomHeight", get_rightFeetBottomHeight, null),
			new LuaField("logWarnings", get_logWarnings, set_logWarnings),
			new LuaField("fireEvents", get_fireEvents, set_fireEvents),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Animator", typeof(Animator), regs, fields, typeof(Behaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAnimator(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Animator obj = new Animator();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.New");
		}

		return 0;
	}

	static Type classType = typeof(Animator);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isOptimizable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isOptimizable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isOptimizable on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isOptimizable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isHuman(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isHuman");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isHuman on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isHuman);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasRootMotion(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name hasRootMotion");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index hasRootMotion on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.hasRootMotion);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_humanScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name humanScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index humanScale on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.humanScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deltaPosition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name deltaPosition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index deltaPosition on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.deltaPosition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deltaRotation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name deltaRotation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index deltaRotation on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.deltaRotation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_velocity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

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
		Animator obj = (Animator)o;

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
	static int get_rootPosition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rootPosition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rootPosition on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.rootPosition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rootRotation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rootRotation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rootRotation on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.rootRotation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_applyRootMotion(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name applyRootMotion");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index applyRootMotion on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.applyRootMotion);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_linearVelocityBlending(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name linearVelocityBlending");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index linearVelocityBlending on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.linearVelocityBlending);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name updateMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index updateMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.updateMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasTransformHierarchy(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name hasTransformHierarchy");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index hasTransformHierarchy on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.hasTransformHierarchy);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gravityWeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name gravityWeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index gravityWeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.gravityWeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bodyPosition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bodyPosition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bodyPosition on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bodyPosition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bodyRotation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bodyRotation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bodyRotation on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bodyRotation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_stabilizeFeet(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name stabilizeFeet");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index stabilizeFeet on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.stabilizeFeet);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layerCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name layerCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index layerCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.layerCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_parameters(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name parameters");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index parameters on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.parameters);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_feetPivotActive(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name feetPivotActive");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index feetPivotActive on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.feetPivotActive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pivotWeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pivotWeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pivotWeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.pivotWeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pivotPosition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pivotPosition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pivotPosition on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.pivotPosition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMatchingTarget(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isMatchingTarget");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isMatchingTarget on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isMatchingTarget);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_speed(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name speed");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index speed on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.speed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetPosition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name targetPosition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index targetPosition on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.targetPosition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetRotation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name targetRotation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index targetRotation on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.targetRotation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cullingMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cullingMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cullingMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cullingMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_playbackTime(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name playbackTime");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index playbackTime on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.playbackTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_recorderStartTime(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name recorderStartTime");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index recorderStartTime on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.recorderStartTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_recorderStopTime(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name recorderStopTime");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index recorderStopTime on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.recorderStopTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_recorderMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name recorderMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index recorderMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.recorderMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_runtimeAnimatorController(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name runtimeAnimatorController");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index runtimeAnimatorController on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.runtimeAnimatorController);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_avatar(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name avatar");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index avatar on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.avatar);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layersAffectMassCenter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name layersAffectMassCenter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index layersAffectMassCenter on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.layersAffectMassCenter);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_leftFeetBottomHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name leftFeetBottomHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index leftFeetBottomHeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.leftFeetBottomHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rightFeetBottomHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rightFeetBottomHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rightFeetBottomHeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.rightFeetBottomHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logWarnings(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name logWarnings");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index logWarnings on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.logWarnings);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fireEvents(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fireEvents");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fireEvents on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fireEvents);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rootPosition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rootPosition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rootPosition on a nil value");
			}
		}

		obj.rootPosition = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rootRotation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rootRotation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rootRotation on a nil value");
			}
		}

		obj.rootRotation = LuaScriptMgr.GetQuaternion(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_applyRootMotion(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name applyRootMotion");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index applyRootMotion on a nil value");
			}
		}

		obj.applyRootMotion = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_linearVelocityBlending(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name linearVelocityBlending");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index linearVelocityBlending on a nil value");
			}
		}

		obj.linearVelocityBlending = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updateMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name updateMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index updateMode on a nil value");
			}
		}

		obj.updateMode = (AnimatorUpdateMode)LuaScriptMgr.GetNetObject(L, 3, typeof(AnimatorUpdateMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bodyPosition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bodyPosition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bodyPosition on a nil value");
			}
		}

		obj.bodyPosition = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bodyRotation(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bodyRotation");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bodyRotation on a nil value");
			}
		}

		obj.bodyRotation = LuaScriptMgr.GetQuaternion(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_stabilizeFeet(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name stabilizeFeet");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index stabilizeFeet on a nil value");
			}
		}

		obj.stabilizeFeet = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_feetPivotActive(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name feetPivotActive");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index feetPivotActive on a nil value");
			}
		}

		obj.feetPivotActive = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_speed(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name speed");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index speed on a nil value");
			}
		}

		obj.speed = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cullingMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cullingMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cullingMode on a nil value");
			}
		}

		obj.cullingMode = (AnimatorCullingMode)LuaScriptMgr.GetNetObject(L, 3, typeof(AnimatorCullingMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_playbackTime(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name playbackTime");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index playbackTime on a nil value");
			}
		}

		obj.playbackTime = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_recorderStartTime(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name recorderStartTime");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index recorderStartTime on a nil value");
			}
		}

		obj.recorderStartTime = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_recorderStopTime(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name recorderStopTime");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index recorderStopTime on a nil value");
			}
		}

		obj.recorderStopTime = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_runtimeAnimatorController(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name runtimeAnimatorController");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index runtimeAnimatorController on a nil value");
			}
		}

		obj.runtimeAnimatorController = (RuntimeAnimatorController)LuaScriptMgr.GetUnityObject(L, 3, typeof(RuntimeAnimatorController));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_avatar(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name avatar");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index avatar on a nil value");
			}
		}

		obj.avatar = (Avatar)LuaScriptMgr.GetUnityObject(L, 3, typeof(Avatar));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_layersAffectMassCenter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name layersAffectMassCenter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index layersAffectMassCenter on a nil value");
			}
		}

		obj.layersAffectMassCenter = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logWarnings(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name logWarnings");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index logWarnings on a nil value");
			}
		}

		obj.logWarnings = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fireEvents(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Animator obj = (Animator)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fireEvents");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fireEvents on a nil value");
			}
		}

		obj.fireEvents = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFloat(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float o = obj.GetFloat(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float o = obj.GetFloat(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.GetFloat");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetFloat(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.SetFloat(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.SetFloat(arg0,arg1);
			return 0;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int), typeof(float), typeof(float), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 5);
			obj.SetFloat(arg0,arg1,arg2,arg3);
			return 0;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string), typeof(float), typeof(float), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 5);
			obj.SetFloat(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.SetFloat");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBool(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			bool o = obj.GetBool(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			bool o = obj.GetBool(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.GetBool");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetBool(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int), typeof(bool)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			bool arg1 = LuaDLL.lua_toboolean(L, 3);
			obj.SetBool(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string), typeof(bool)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			bool arg1 = LuaDLL.lua_toboolean(L, 3);
			obj.SetBool(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.SetBool");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInteger(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			int o = obj.GetInteger(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			int o = obj.GetInteger(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.GetInteger");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetInteger(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
			obj.SetInteger(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
			obj.SetInteger(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.SetInteger");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTrigger(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			obj.SetTrigger(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			obj.SetTrigger(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.SetTrigger");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetTrigger(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			obj.ResetTrigger(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			obj.ResetTrigger(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.ResetTrigger");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsParameterControlledByCurve(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			bool o = obj.IsParameterControlledByCurve(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			bool o = obj.IsParameterControlledByCurve(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.IsParameterControlledByCurve");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIKPosition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKGoal arg0 = (AvatarIKGoal)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKGoal));
		Vector3 o = obj.GetIKPosition(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetIKPosition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKGoal arg0 = (AvatarIKGoal)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKGoal));
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 3);
		obj.SetIKPosition(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIKRotation(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKGoal arg0 = (AvatarIKGoal)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKGoal));
		Quaternion o = obj.GetIKRotation(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetIKRotation(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKGoal arg0 = (AvatarIKGoal)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKGoal));
		Quaternion arg1 = LuaScriptMgr.GetQuaternion(L, 3);
		obj.SetIKRotation(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIKPositionWeight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKGoal arg0 = (AvatarIKGoal)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKGoal));
		float o = obj.GetIKPositionWeight(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetIKPositionWeight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKGoal arg0 = (AvatarIKGoal)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKGoal));
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		obj.SetIKPositionWeight(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIKRotationWeight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKGoal arg0 = (AvatarIKGoal)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKGoal));
		float o = obj.GetIKRotationWeight(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetIKRotationWeight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKGoal arg0 = (AvatarIKGoal)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKGoal));
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		obj.SetIKRotationWeight(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIKHintPosition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKHint arg0 = (AvatarIKHint)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKHint));
		Vector3 o = obj.GetIKHintPosition(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetIKHintPosition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKHint arg0 = (AvatarIKHint)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKHint));
		Vector3 arg1 = LuaScriptMgr.GetVector3(L, 3);
		obj.SetIKHintPosition(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIKHintPositionWeight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKHint arg0 = (AvatarIKHint)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKHint));
		float o = obj.GetIKHintPositionWeight(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetIKHintPositionWeight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarIKHint arg0 = (AvatarIKHint)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarIKHint));
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		obj.SetIKHintPositionWeight(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLookAtPosition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
		obj.SetLookAtPosition(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLookAtWeight(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			obj.SetLookAtWeight(arg0);
			return 0;
		}
		else if (count == 3)
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
			obj.SetLookAtWeight(arg0,arg1);
			return 0;
		}
		else if (count == 4)
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 4);
			obj.SetLookAtWeight(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 5)
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 4);
			float arg3 = (float)LuaScriptMgr.GetNumber(L, 5);
			obj.SetLookAtWeight(arg0,arg1,arg2,arg3);
			return 0;
		}
		else if (count == 6)
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
			float arg2 = (float)LuaScriptMgr.GetNumber(L, 4);
			float arg3 = (float)LuaScriptMgr.GetNumber(L, 5);
			float arg4 = (float)LuaScriptMgr.GetNumber(L, 6);
			obj.SetLookAtWeight(arg0,arg1,arg2,arg3,arg4);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.SetLookAtWeight");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLayerName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		string o = obj.GetLayerName(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLayerIndex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		int o = obj.GetLayerIndex(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLayerWeight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		float o = obj.GetLayerWeight(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayerWeight(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		obj.SetLayerWeight(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCurrentAnimatorStateInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		AnimatorStateInfo o = obj.GetCurrentAnimatorStateInfo(arg0);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNextAnimatorStateInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		AnimatorStateInfo o = obj.GetNextAnimatorStateInfo(arg0);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAnimatorTransitionInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		AnimatorTransitionInfo o = obj.GetAnimatorTransitionInfo(arg0);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCurrentAnimatorClipInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		AnimatorClipInfo[] o = obj.GetCurrentAnimatorClipInfo(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNextAnimatorClipInfo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		AnimatorClipInfo[] o = obj.GetNextAnimatorClipInfo(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsInTransition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		bool o = obj.IsInTransition(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MatchTarget(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 6)
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg1 = LuaScriptMgr.GetQuaternion(L, 3);
			AvatarTarget arg2 = (AvatarTarget)LuaScriptMgr.GetNetObject(L, 4, typeof(AvatarTarget));
			MatchTargetWeightMask arg3 = (MatchTargetWeightMask)LuaScriptMgr.GetNetObject(L, 5, typeof(MatchTargetWeightMask));
			float arg4 = (float)LuaScriptMgr.GetNumber(L, 6);
			obj.MatchTarget(arg0,arg1,arg2,arg3,arg4);
			return 0;
		}
		else if (count == 7)
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
			Quaternion arg1 = LuaScriptMgr.GetQuaternion(L, 3);
			AvatarTarget arg2 = (AvatarTarget)LuaScriptMgr.GetNetObject(L, 4, typeof(AvatarTarget));
			MatchTargetWeightMask arg3 = (MatchTargetWeightMask)LuaScriptMgr.GetNetObject(L, 5, typeof(MatchTargetWeightMask));
			float arg4 = (float)LuaScriptMgr.GetNumber(L, 6);
			float arg5 = (float)LuaScriptMgr.GetNumber(L, 7);
			obj.MatchTarget(arg0,arg1,arg2,arg3,arg4,arg5);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.MatchTarget");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InterruptMatchTarget(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			obj.InterruptMatchTarget();
			return 0;
		}
		else if (count == 2)
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			obj.InterruptMatchTarget(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.InterruptMatchTarget");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFade(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.CrossFade(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.CrossFade(arg0,arg1);
			return 0;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int), typeof(float), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
			obj.CrossFade(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string), typeof(float), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
			obj.CrossFade(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string), typeof(float), typeof(int), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 5);
			obj.CrossFade(arg0,arg1,arg2,arg3);
			return 0;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int), typeof(float), typeof(int), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
			float arg3 = (float)LuaDLL.lua_tonumber(L, 5);
			obj.CrossFade(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.CrossFade");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			obj.Play(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			obj.Play(arg0);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
			obj.Play(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string), typeof(int)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
			obj.Play(arg0,arg1);
			return 0;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(string), typeof(int), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			string arg0 = LuaScriptMgr.GetString(L, 2);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
			obj.Play(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(Animator), typeof(int), typeof(int), typeof(float)))
		{
			Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
			int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
			obj.Play(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Animator.Play");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTarget(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		AvatarTarget arg0 = (AvatarTarget)LuaScriptMgr.GetNetObject(L, 2, typeof(AvatarTarget));
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		obj.SetTarget(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBoneTransform(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		HumanBodyBones arg0 = (HumanBodyBones)LuaScriptMgr.GetNetObject(L, 2, typeof(HumanBodyBones));
		Transform o = obj.GetBoneTransform(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartPlayback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		obj.StartPlayback();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopPlayback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		obj.StopPlayback();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartRecording(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.StartRecording(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopRecording(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		obj.StopRecording();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasState(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		bool o = obj.HasState(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StringToHash(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		int o = Animator.StringToHash(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		obj.Update(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebind(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Animator obj = (Animator)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Animator");
		obj.Rebind();
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

