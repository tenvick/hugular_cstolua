using System;

public static class LuaBinder
{
	public static void Bind(IntPtr L)
	{
		Vector3Wrap.Register(L);
		Vector4Wrap.Register(L);
		VerticalWrapModeWrap.Register(L);
		WebCamDeviceWrap.Register(L);
		WebCamFlagsWrap.Register(L);
		WebCamTextureWrap.Register(L);
		WindZoneModeWrap.Register(L);
		WindZoneWrap.Register(L);
		WrapModeWrap.Register(L);
		WWWFormWrap.Register(L);
		WWWWrap.Register(L);
	}
}
