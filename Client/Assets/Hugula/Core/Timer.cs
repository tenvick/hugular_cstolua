// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;

/// <summary>
/// lua Timer
/// @author rikcypu
/// </summary>
public class Timer  {

    private static List<LuaFnArg> times = new List<LuaFnArg>();

    public static void AddFn(LuaFunction fn, float delaytime)
    {
        AddFn(fn, delaytime, null);
    }

    public static void AddFn(LuaFunction fn,float delaytime, object arg)
    {
        float next = Time.unscaledTime + delaytime;
        LuaFnArg fnarg = new LuaFnArg(fn, next, arg);
        times.Add(fnarg);
        //times.Sort((left, right) =>
        //{
        //    if (left.time > right.time)
        //        return -1;
        //    else if (left.time == right.time)
        //        return 0;
        //    else
        //        return 1;
        //});
        
    }

    public static void RemoveFn(LuaFunction fn)
    {
        LuaFnArg remItem=null;
        foreach (LuaFnArg arg in times)
        {
            if (arg.LuaFn.Equals(fn))
            {
                remItem=arg;
            }
        }

//        if (remItem != null) {
//			removes.Add(remItem);
//				}
            times.Remove(remItem);
    }

    private static List<LuaFnArg> removes = new List<LuaFnArg>();


    public static void Update()
    {
        List<LuaFnArg>.Enumerator enmu=  times.GetEnumerator();

        //int i = 0;
//        removes.Clear();
//        while (enmu.MoveNext())
//        {
//            LuaFnArg item = enmu.Current;
//            if (Time.unscaledTime >= item.time)
//            {
//                item.LuaFn.Call(item.arg);
//                removes.Add(item);
//            }
//            //i++;
//        }

		for (int i=0; i<times.Count; i++) {
			LuaFnArg item=times[i];
			if (Time.unscaledTime >= item.time)
			{
				item.LuaFn.Call(item.arg);
				removes.Add(item);
			}
		}

		if (removes.Count > 0) {
						foreach (LuaFnArg item in removes) {
								times.Remove (item);
						}
			removes.Clear();
		}

    }

}

public class LuaFnArg
{
    public LuaFnArg() { }
    public LuaFnArg(LuaFunction LuaFn, float time, object arg) { this.LuaFn = LuaFn; this.arg = arg; this.time = time; }
    public LuaFunction LuaFn;
    public object arg;
    public float time;
}