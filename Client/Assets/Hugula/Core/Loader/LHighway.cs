// Copyright (c) 2015 hugula
// direct https://github.com/tenvick/hugula
//

using UnityEngine;
using System.Collections;
using LuaInterface;

/// <summary>
/// L highway.
/// </summary>
public class LHighway : CHighway {


	public LHighway()
		: base()
	{
		base.OnAllComplete += LHighway_onAllComplete;
		base.OnProgress += LHighway_onProgress;
		base.OnSharedComplete += LHighway_onSharedComplete;
	}
	
	public void LoadLuaTable(LuaTable reqs)
	{
		System.Collections.IEnumerator luatb = reqs.Values.GetEnumerator();
		while (luatb.MoveNext())
		{
			AddReqToQueue((CRequest)luatb.Current);
		}
		BeginQueue();
	}


	protected  override object  GetCache(string Key)
	{
		if (this._cache != null)
			return _cache [Key];
		else
			return null;
	}
	
	protected override void SetCache(string key,object Value)
	{
		if (onCacheFn != null) {
			onCacheFn.Call(key,Value);
				}
		else if (this._cache != null)
			this._cache [key] = Value;
	}

	#region protected method
	
	void LHighway_onSharedComplete(CRequest req)
	{
		if (onSharedCompleteFn != null)
			onSharedCompleteFn.Call(req);
	}
	
	void LHighway_onProgress(CHighway loader, HighwayEventArg arg)
	{
		if (onProgressFn != null)
			onProgressFn.Call(loader, arg);
	}
	
	void LHighway_onAllComplete(CHighway loader)
	{
		if (onAllCompleteFn != null)
			onAllCompleteFn.Call(loader);
	}
	
	private LuaTable _cache;
	
	public override object cache
	{
		get { return _cache; }
		set
		{
			if (value is LuaTable)
				_cache = (LuaTable)value;
		}
	}



	#endregion

	#region  delegate and event
	
	public LuaFunction onAllCompleteFn;
	public LuaFunction onProgressFn;
	public LuaFunction onSharedCompleteFn;
	public LuaFunction onCacheFn;
	#endregion
	
	private static LHighway _instance;
	
	public static LHighway instance
	{
		get
		{
			if (_instance == null)
				_instance = new LHighway();
			return _instance;
		}
	}
}
