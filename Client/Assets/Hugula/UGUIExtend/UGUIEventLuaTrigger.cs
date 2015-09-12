//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2014 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;
using System.Collections.Generic;
using LuaInterface;
using Lua = LuaInterface.LuaState;

/// <summary>
/// Attaching this script to an object will let you trigger remote functions using UGUI events.
/// </summary>

public class UIEventLuaTrigger : MonoBehaviour
{
    /// <summary>
    /// 响应的lua函数
    /// </summary>
    public LuaFunction luaFn;

    /// <summary>
    /// 触发事件的脚本
    /// </summary>
    public MonoBehaviour trigger;

    public List<MonoBehaviour> target=new List<MonoBehaviour>();

    public void OnLuaTrigger()
    {
        if (luaFn != null)
        {
            luaFn.Call(this.gameObject, trigger, target);
        }
    }

}
