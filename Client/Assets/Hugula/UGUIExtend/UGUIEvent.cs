// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections;

using LuaInterface;
using Lua = LuaInterface.LuaState;
using LuaState = System.IntPtr;

public static class UGUIEvent  {

    #region public

    public static void onCustomerHandle(object sender, object arg)
    {
        if (onCustomerFn != null)
        {
            onCustomerFn.Call(sender, arg);
        }
    }

    public static void onPressHandle(GameObject sender, bool arg)
	{
        if (onPressFn != null)
		{
            onPressFn.Call(sender, arg);
		}
	}

    public static void onClickHandle(GameObject sender, object arg)
	{
		if(onClickFn!=null)
		{
            onClickFn.Call(sender, arg);
		}
	}

    public static void onDragHandle(GameObject sender, Vector2 arg)
	{
		if(onDragFn!=null)
		{
            //LuaState L=ToLuaCS.lua.L;
            //onDragFn.push(L);
            //ToLuaCS.push(L, sender);
            //ToLuaCS.push(L, arg);
            //if (LuaDLL.lua_call(L, 2, -1) != 0)
            //{
            //}
            onDragFn.Call(sender, arg);
		}
	}

    public static void onDropHandle(GameObject sender, object arg)
	{
		if(onDropFn!=null)
		{
            onDropFn.Call(sender, arg);
		}
	}

    public static void onSelectHandle(GameObject sender, object arg)
	{
		if(onSelectFn!=null)
		{
            onSelectFn.Call(sender, arg);
		}
	}

    //public static void onDoubleClickHandle(GameObject sender, object arg)
    //{
    //    if (onDoubleFn != null)
    //    {
    //        onDoubleFn.Call(sender, arg);
    //    }
    //}
    public static void onCancelHandle(GameObject sender, object arg)
    {
        if (onCancelFn != null)
        {
            onCancelFn.Call(sender, arg);
        }
    }

	#endregion
    public static LuaFunction onCustomerFn;

    public static LuaFunction onPressFn;

    public static LuaFunction onClickFn;

    public static LuaFunction onDragFn;

    public static LuaFunction onDropFn;

    public static LuaFunction onSelectFn;

    public static LuaFunction onCancelFn;
    //public static LuaFunction onDoubleFn;

}

