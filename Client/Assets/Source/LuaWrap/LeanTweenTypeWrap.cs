using System;
using LuaInterface;

public class LeanTweenTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("notUsed", GetnotUsed),
		new LuaMethod("linear", Getlinear),
		new LuaMethod("easeOutQuad", GeteaseOutQuad),
		new LuaMethod("easeInQuad", GeteaseInQuad),
		new LuaMethod("easeInOutQuad", GeteaseInOutQuad),
		new LuaMethod("easeInCubic", GeteaseInCubic),
		new LuaMethod("easeOutCubic", GeteaseOutCubic),
		new LuaMethod("easeInOutCubic", GeteaseInOutCubic),
		new LuaMethod("easeInQuart", GeteaseInQuart),
		new LuaMethod("easeOutQuart", GeteaseOutQuart),
		new LuaMethod("easeInOutQuart", GeteaseInOutQuart),
		new LuaMethod("easeInQuint", GeteaseInQuint),
		new LuaMethod("easeOutQuint", GeteaseOutQuint),
		new LuaMethod("easeInOutQuint", GeteaseInOutQuint),
		new LuaMethod("easeInSine", GeteaseInSine),
		new LuaMethod("easeOutSine", GeteaseOutSine),
		new LuaMethod("easeInOutSine", GeteaseInOutSine),
		new LuaMethod("easeInExpo", GeteaseInExpo),
		new LuaMethod("easeOutExpo", GeteaseOutExpo),
		new LuaMethod("easeInOutExpo", GeteaseInOutExpo),
		new LuaMethod("easeInCirc", GeteaseInCirc),
		new LuaMethod("easeOutCirc", GeteaseOutCirc),
		new LuaMethod("easeInOutCirc", GeteaseInOutCirc),
		new LuaMethod("easeInBounce", GeteaseInBounce),
		new LuaMethod("easeOutBounce", GeteaseOutBounce),
		new LuaMethod("easeInOutBounce", GeteaseInOutBounce),
		new LuaMethod("easeInBack", GeteaseInBack),
		new LuaMethod("easeOutBack", GeteaseOutBack),
		new LuaMethod("easeInOutBack", GeteaseInOutBack),
		new LuaMethod("easeInElastic", GeteaseInElastic),
		new LuaMethod("easeOutElastic", GeteaseOutElastic),
		new LuaMethod("easeInOutElastic", GeteaseInOutElastic),
		new LuaMethod("easeSpring", GeteaseSpring),
		new LuaMethod("easeShake", GeteaseShake),
		new LuaMethod("punch", Getpunch),
		new LuaMethod("once", Getonce),
		new LuaMethod("clamp", Getclamp),
		new LuaMethod("pingPong", GetpingPong),
		new LuaMethod("animationCurve", GetanimationCurve),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "LeanTweenType", typeof(LeanTweenType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetnotUsed(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.notUsed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Getlinear(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.linear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutQuad(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutQuad);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInQuad(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInQuad);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutQuad(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutQuad);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInCubic(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInCubic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutCubic(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutCubic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutCubic(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutCubic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInQuart(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInQuart);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutQuart(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutQuart);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutQuart(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutQuart);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInQuint(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInQuint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutQuint(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutQuint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutQuint(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutQuint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInSine(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInSine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutSine(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutSine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutSine(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutSine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInExpo(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInExpo);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutExpo(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutExpo);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutExpo(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutExpo);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInCirc(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInCirc);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutCirc(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutCirc);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutCirc(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutCirc);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInBounce(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInBounce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutBounce(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutBounce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutBounce(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutBounce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInBack(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInBack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutBack(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutBack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutBack(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutBack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInElastic(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInElastic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseOutElastic(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeOutElastic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseInOutElastic(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeInOutElastic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseSpring(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeSpring);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeteaseShake(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.easeShake);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Getpunch(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.punch);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Getonce(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.once);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Getclamp(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.clamp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetpingPong(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.pingPong);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetanimationCurve(IntPtr L)
	{
		LuaScriptMgr.Push(L, LeanTweenType.animationCurve);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		LeanTweenType o = (LeanTweenType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

