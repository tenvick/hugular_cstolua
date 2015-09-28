// Copyright (c) 2015 hugula
// direct https://github.com/tenvick/hugula
//
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System;
using System.Text;

using LuaInterface;
using Lua = LuaScriptMgr;


public class PLua : MonoBehaviour
{

    public static string enterLua = "main";
    public LuaFunction onDestroyFn;
    public static bool isDebug = true;

    public Lua lua;
    public LNet net;
    public LNet ChatNet;
    public static Dictionary<string, TextAsset> luacache;

    #region priveta
    private string luaMain = "";
    private const string initLua = @"require(""core.unity3d"")";

    private LuaFunction _updateFn;

    #endregion

    #region mono

    public LuaFunction updateFn
    {
        get { return _updateFn; }
        set
        {
            _updateFn = value;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        luacache = new Dictionary<string, TextAsset>();
        lua = new Lua();
        _instance = this;
        LoadScript();
    }

    void Start()
    {
        net = LNet.instance;
        ChatNet = LNet.ChatInstance;
        LoadBundle(true);
    }

    void Update()
    {
        if (net != null) net.Update();
        if (ChatNet != null) ChatNet.Update();
        if (_updateFn != null) _updateFn.Call();
        if (lua != null) lua.Update();
        Timer.Update();
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (net != null) net.OnApplicationPause(pauseStatus);
    }

    void OnDestroy()
    {
        if (onDestroyFn != null) onDestroyFn.Call();
        updateFn = null;
        if (lua != null) lua.Destroy();
        lua = null;
        _instance = null;
        if(net!=null)net.Dispose();
        net = null;
		if(ChatNet!=null)ChatNet.Dispose();
        ChatNet = null;
        luacache.Clear();
    }

    #endregion

    private void SetLuaPath()
    {
        this.luaMain = "return require(\"" + enterLua + "\") \n";
        Debug.Log(luaMain);
    }

    private void LoadScript()
    {
        SetLuaPath();

        RegisterFunc();

        Assembly assb = Assembly.GetExecutingAssembly();
        string assemblyname = assb.GetName().Name;
        lua.lua["assemblyname"] = assemblyname;
    }

    /// <summary>
    /// lua bundle
    /// </summary>
    /// <returns></returns>
    private IEnumerator loadLuaBundle(bool domain,LuaFunction onLoadedFn)
    {
        string keyName = "";
        string luaP = CUtils.GetAssetFullPath("font.u3d");
        WWW luaLoader = new WWW(luaP);
        yield return luaLoader;
        if (luaLoader.error == null)
        {
			byte[] byts=CryptographHelper.Decrypt(luaLoader.bytes,DESHelper.instance.Key,DESHelper.instance.IV);
			AssetBundle item = AssetBundle.CreateFromMemoryImmediate(byts);

            TextAsset[] all = item.LoadAllAssets<TextAsset>();
            foreach (var ass in all)
            {
				keyName = ass.name;
                luacache[keyName] = ass;
            }

			item.Unload(false);
            luaLoader.Dispose();
        }

        DoUnity3dLua();
        if (domain)
            DoMain();

        if (onLoadedFn != null) onLoadedFn.Call();
    }

    #region public

    public void DoUnity3dLua()
    {
        lua.Start();
    }

    /// <summary>
    /// lua begin
    /// </summary>
    public void DoMain()
    {
        lua.DoString(this.luaMain);
    }

    /// <summary>
	/// load assetbundle
    /// </summary>
    public void LoadBundle(bool domain)
    {
#if UNITY_EDITOR 
		if(!isDebug)
		{
	        StopCoroutine(loadLuaBundle(domain, null));
	        StartCoroutine(loadLuaBundle(domain, null));
		}else
		{
			DoUnity3dLua();
			if (domain)
				DoMain();
		}
#else
		StopCoroutine(loadLuaBundle(domain, null));
		StartCoroutine(loadLuaBundle(domain, null));
#endif
    }

    /// <summary>
    /// load assetbundle
    /// </summary>
    public void LoadBundle(LuaFunction onLoadedFn)
    {
        StopCoroutine(loadLuaBundle(false, onLoadedFn));
        StartCoroutine(loadLuaBundle(false, onLoadedFn));
    }

    #endregion

    #region toolMethod

    public void RegisterFunc()
    {
        LuaStatic.Load = Loader;
    }

    /// <summary>
    ///  loader
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static byte[] Loader(string name)
    {
        byte[] str = null;
#if UNITY_EDITOR

        if (isDebug)
        {
			name = name.Replace('.','/'); 
            string path = Application.dataPath + "/Lua/" + name+".lua";
            try
            {
				str =  File.ReadAllBytes(path);
            }
            catch
            {
            }
        } 
        else
        {
			name = name.Replace('.','_').Replace('/','_'); 
            if (luacache.ContainsKey(name))
            {
                TextAsset file = luacache[name];
                str = file.bytes;
            }
        }
#else
		name = name.Replace('.','_').Replace('/','_'); 
        if(luacache.ContainsKey(name))
        {
	        TextAsset file = luacache[name];
	        str = file.bytes;
        }
#endif
        return str;
    }


    public static void Delay(LuaFunction luafun, float time, object args = null)
    {
        _instance.StartCoroutine(DelayDo(luafun, args, time));
    }

    public static void StopDelay(string methodName = "DelayDo")
    {
        _instance.StopCoroutine(methodName);
    }

    private static IEnumerator DelayDo(LuaFunction luafun, object arg, float time)
    {
        yield return new WaitForSeconds(time);
        luafun.Call(arg);
    }

    #endregion

    #region static
    private static PLua _instance;

    public static PLua instance
    {
        get
        {
            return _instance;
        }
    }
    #endregion

}
