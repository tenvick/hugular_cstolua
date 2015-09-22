using System;
using UnityEngine;
using LuaInterface;

public class HumanBodyBonesWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Hips", GetHips),
		new LuaMethod("LeftUpperLeg", GetLeftUpperLeg),
		new LuaMethod("RightUpperLeg", GetRightUpperLeg),
		new LuaMethod("LeftLowerLeg", GetLeftLowerLeg),
		new LuaMethod("RightLowerLeg", GetRightLowerLeg),
		new LuaMethod("LeftFoot", GetLeftFoot),
		new LuaMethod("RightFoot", GetRightFoot),
		new LuaMethod("Spine", GetSpine),
		new LuaMethod("Chest", GetChest),
		new LuaMethod("Neck", GetNeck),
		new LuaMethod("Head", GetHead),
		new LuaMethod("LeftShoulder", GetLeftShoulder),
		new LuaMethod("RightShoulder", GetRightShoulder),
		new LuaMethod("LeftUpperArm", GetLeftUpperArm),
		new LuaMethod("RightUpperArm", GetRightUpperArm),
		new LuaMethod("LeftLowerArm", GetLeftLowerArm),
		new LuaMethod("RightLowerArm", GetRightLowerArm),
		new LuaMethod("LeftHand", GetLeftHand),
		new LuaMethod("RightHand", GetRightHand),
		new LuaMethod("LeftToes", GetLeftToes),
		new LuaMethod("RightToes", GetRightToes),
		new LuaMethod("LeftEye", GetLeftEye),
		new LuaMethod("RightEye", GetRightEye),
		new LuaMethod("Jaw", GetJaw),
		new LuaMethod("LeftThumbProximal", GetLeftThumbProximal),
		new LuaMethod("LeftThumbIntermediate", GetLeftThumbIntermediate),
		new LuaMethod("LeftThumbDistal", GetLeftThumbDistal),
		new LuaMethod("LeftIndexProximal", GetLeftIndexProximal),
		new LuaMethod("LeftIndexIntermediate", GetLeftIndexIntermediate),
		new LuaMethod("LeftIndexDistal", GetLeftIndexDistal),
		new LuaMethod("LeftMiddleProximal", GetLeftMiddleProximal),
		new LuaMethod("LeftMiddleIntermediate", GetLeftMiddleIntermediate),
		new LuaMethod("LeftMiddleDistal", GetLeftMiddleDistal),
		new LuaMethod("LeftRingProximal", GetLeftRingProximal),
		new LuaMethod("LeftRingIntermediate", GetLeftRingIntermediate),
		new LuaMethod("LeftRingDistal", GetLeftRingDistal),
		new LuaMethod("LeftLittleProximal", GetLeftLittleProximal),
		new LuaMethod("LeftLittleIntermediate", GetLeftLittleIntermediate),
		new LuaMethod("LeftLittleDistal", GetLeftLittleDistal),
		new LuaMethod("RightThumbProximal", GetRightThumbProximal),
		new LuaMethod("RightThumbIntermediate", GetRightThumbIntermediate),
		new LuaMethod("RightThumbDistal", GetRightThumbDistal),
		new LuaMethod("RightIndexProximal", GetRightIndexProximal),
		new LuaMethod("RightIndexIntermediate", GetRightIndexIntermediate),
		new LuaMethod("RightIndexDistal", GetRightIndexDistal),
		new LuaMethod("RightMiddleProximal", GetRightMiddleProximal),
		new LuaMethod("RightMiddleIntermediate", GetRightMiddleIntermediate),
		new LuaMethod("RightMiddleDistal", GetRightMiddleDistal),
		new LuaMethod("RightRingProximal", GetRightRingProximal),
		new LuaMethod("RightRingIntermediate", GetRightRingIntermediate),
		new LuaMethod("RightRingDistal", GetRightRingDistal),
		new LuaMethod("RightLittleProximal", GetRightLittleProximal),
		new LuaMethod("RightLittleIntermediate", GetRightLittleIntermediate),
		new LuaMethod("RightLittleDistal", GetRightLittleDistal),
		new LuaMethod("LastBone", GetLastBone),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.HumanBodyBones", typeof(UnityEngine.HumanBodyBones), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHips(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.Hips);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftUpperLeg(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftUpperLeg);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightUpperLeg(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightUpperLeg);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftLowerLeg(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftLowerLeg);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightLowerLeg(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightLowerLeg);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftFoot(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftFoot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightFoot(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightFoot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSpine(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.Spine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChest(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.Chest);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNeck(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.Neck);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHead(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.Head);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftShoulder(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftShoulder);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightShoulder(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightShoulder);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftUpperArm(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftUpperArm);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightUpperArm(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightUpperArm);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftLowerArm(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftLowerArm);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightLowerArm(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightLowerArm);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftHand(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftHand);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightHand(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightHand);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftToes(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftToes);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightToes(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightToes);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftEye(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftEye);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightEye(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightEye);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetJaw(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.Jaw);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftThumbProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftThumbProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftThumbIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftThumbIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftThumbDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftThumbDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftIndexProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftIndexProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftIndexIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftIndexIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftIndexDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftIndexDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftMiddleProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftMiddleProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftMiddleIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftMiddleIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftMiddleDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftMiddleDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftRingProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftRingProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftRingIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftRingIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftRingDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftRingDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftLittleProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftLittleProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftLittleIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftLittleIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLeftLittleDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LeftLittleDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightThumbProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightThumbProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightThumbIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightThumbIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightThumbDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightThumbDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightIndexProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightIndexProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightIndexIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightIndexIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightIndexDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightIndexDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightMiddleProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightMiddleProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightMiddleIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightMiddleIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightMiddleDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightMiddleDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightRingProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightRingProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightRingIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightRingIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightRingDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightRingDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightLittleProximal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightLittleProximal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightLittleIntermediate(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightLittleIntermediate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRightLittleDistal(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.RightLittleDistal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLastBone(IntPtr L)
	{
		LuaScriptMgr.Push(L, HumanBodyBones.LastBone);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		HumanBodyBones o = (HumanBodyBones)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

