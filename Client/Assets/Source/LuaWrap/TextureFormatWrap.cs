using System;
using UnityEngine;
using LuaInterface;

public class TextureFormatWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("Alpha8", GetAlpha8),
		new LuaMethod("ARGB4444", GetARGB4444),
		new LuaMethod("RGB24", GetRGB24),
		new LuaMethod("RGBA32", GetRGBA32),
		new LuaMethod("ARGB32", GetARGB32),
		new LuaMethod("RGB565", GetRGB565),
		new LuaMethod("R16", GetR16),
		new LuaMethod("DXT1", GetDXT1),
		new LuaMethod("DXT5", GetDXT5),
		new LuaMethod("RGBA4444", GetRGBA4444),
		new LuaMethod("BGRA32", GetBGRA32),
		new LuaMethod("RHalf", GetRHalf),
		new LuaMethod("RGHalf", GetRGHalf),
		new LuaMethod("RGBAHalf", GetRGBAHalf),
		new LuaMethod("RFloat", GetRFloat),
		new LuaMethod("RGFloat", GetRGFloat),
		new LuaMethod("RGBAFloat", GetRGBAFloat),
		new LuaMethod("YUY2", GetYUY2),
		new LuaMethod("PVRTC_RGB2", GetPVRTC_RGB2),
		new LuaMethod("PVRTC_RGBA2", GetPVRTC_RGBA2),
		new LuaMethod("PVRTC_RGB4", GetPVRTC_RGB4),
		new LuaMethod("PVRTC_RGBA4", GetPVRTC_RGBA4),
		new LuaMethod("ETC_RGB4", GetETC_RGB4),
		new LuaMethod("ATC_RGB4", GetATC_RGB4),
		new LuaMethod("ATC_RGBA8", GetATC_RGBA8),
		new LuaMethod("EAC_R", GetEAC_R),
		new LuaMethod("EAC_R_SIGNED", GetEAC_R_SIGNED),
		new LuaMethod("EAC_RG", GetEAC_RG),
		new LuaMethod("EAC_RG_SIGNED", GetEAC_RG_SIGNED),
		new LuaMethod("ETC2_RGB", GetETC2_RGB),
		new LuaMethod("ETC2_RGBA1", GetETC2_RGBA1),
		new LuaMethod("ETC2_RGBA8", GetETC2_RGBA8),
		new LuaMethod("ASTC_RGB_4x4", GetASTC_RGB_4x4),
		new LuaMethod("ASTC_RGB_5x5", GetASTC_RGB_5x5),
		new LuaMethod("ASTC_RGB_6x6", GetASTC_RGB_6x6),
		new LuaMethod("ASTC_RGB_8x8", GetASTC_RGB_8x8),
		new LuaMethod("ASTC_RGB_10x10", GetASTC_RGB_10x10),
		new LuaMethod("ASTC_RGB_12x12", GetASTC_RGB_12x12),
		new LuaMethod("ASTC_RGBA_4x4", GetASTC_RGBA_4x4),
		new LuaMethod("ASTC_RGBA_5x5", GetASTC_RGBA_5x5),
		new LuaMethod("ASTC_RGBA_6x6", GetASTC_RGBA_6x6),
		new LuaMethod("ASTC_RGBA_8x8", GetASTC_RGBA_8x8),
		new LuaMethod("ASTC_RGBA_10x10", GetASTC_RGBA_10x10),
		new LuaMethod("ASTC_RGBA_12x12", GetASTC_RGBA_12x12),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UnityEngine.TextureFormat", typeof(UnityEngine.TextureFormat), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAlpha8(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.Alpha8);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetARGB4444(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ARGB4444);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGB24(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RGB24);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGBA32(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RGBA32);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetARGB32(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ARGB32);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGB565(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RGB565);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetR16(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.R16);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDXT1(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.DXT1);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDXT5(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.DXT5);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGBA4444(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RGBA4444);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBGRA32(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.BGRA32);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRHalf(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RHalf);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGHalf(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RGHalf);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGBAHalf(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RGBAHalf);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRFloat(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RFloat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGFloat(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RGFloat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRGBAFloat(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.RGBAFloat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetYUY2(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.YUY2);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPVRTC_RGB2(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.PVRTC_RGB2);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPVRTC_RGBA2(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.PVRTC_RGBA2);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPVRTC_RGB4(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.PVRTC_RGB4);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPVRTC_RGBA4(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.PVRTC_RGBA4);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetETC_RGB4(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ETC_RGB4);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetATC_RGB4(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ATC_RGB4);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetATC_RGBA8(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ATC_RGBA8);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEAC_R(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.EAC_R);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEAC_R_SIGNED(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.EAC_R_SIGNED);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEAC_RG(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.EAC_RG);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEAC_RG_SIGNED(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.EAC_RG_SIGNED);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetETC2_RGB(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ETC2_RGB);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetETC2_RGBA1(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ETC2_RGBA1);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetETC2_RGBA8(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ETC2_RGBA8);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGB_4x4(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGB_4x4);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGB_5x5(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGB_5x5);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGB_6x6(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGB_6x6);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGB_8x8(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGB_8x8);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGB_10x10(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGB_10x10);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGB_12x12(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGB_12x12);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGBA_4x4(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGBA_4x4);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGBA_5x5(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGBA_5x5);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGBA_6x6(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGBA_6x6);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGBA_8x8(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGBA_8x8);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGBA_10x10(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGBA_10x10);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetASTC_RGBA_12x12(IntPtr L)
	{
		LuaScriptMgr.Push(L, TextureFormat.ASTC_RGBA_12x12);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		TextureFormat o = (TextureFormat)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

