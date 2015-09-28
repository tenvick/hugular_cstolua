// Copyright (c) 2015 hugula
// direct https://github.com/tenvick/hugula
//
using UnityEngine;
using System.Collections;
using LuaInterface;

public class LRequest : CRequest {

    public  LRequest(string url) :base(url)
    {
        this.OnComplete += OnCompHandler;
        this.OnEnd += OnEndHandler;
    }

    public LRequest(string url, string assetName, string assetType)
        : base(url, assetName, assetType)
    {
        this.OnComplete += OnCompHandler;
        this.OnEnd += OnEndHandler;
    }

    private void OnCompHandler(CRequest req)
    {
        if (onCompleteFn != null)
            onCompleteFn.Call(req);
    }

    private void OnEndHandler(CRequest req)
    {
        if (onEndFn != null)
            onEndFn.Call(req);
    }

    public LuaFunction onCompleteFn;

    public LuaFunction onEndFn;

}
