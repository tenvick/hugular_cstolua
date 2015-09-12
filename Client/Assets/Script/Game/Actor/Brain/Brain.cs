// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections.Generic;


/// <summary>
/// 大脑
/// </summary>
public abstract class Brain
{

    public Brain()
    {
        isInit = false;
        enable = true;
        events = new Dictionary<int, List<System.Action<Actor,object>>>();
    }

    #region pulic member
    /// <summary>
    /// 行为树根节点
    /// </summary>
    public IBehaviourNode root;

    /// <summary>
    /// 是否初始化
    /// </summary>
    public bool isInit { get; private set; }

    /// <summary>
    /// 主体
    /// </summary>
    public Actor actor { get ; set;}

    /// <summary>
    /// 状态
    /// </summary>
    public bool enable { get; private set; }

    #endregion

    #region private member

    protected Dictionary<int, List<System.Action<Actor, object>>> events;

    protected BTInput _input;

    protected BTOutput _output;
    #endregion

    #region pulic method

    /// <summary>
    /// 开始
    /// </summary>
    internal void Start()
    {
        OnStart();
        isInit = true;
        _input = actor.input;
        _output = actor.output;
    }

    internal void OnUpdate()
    {
        if (isInit && enable)
        {
            root.Visit(_input, _output);
            root.Step();
        }
    }

    /// <summary>
    /// 唤醒
    /// </summary>
    public void Awake()
    {
        this.enable = true;
    }

    /// <summary>
    /// 停止
    /// </summary>
    public void Stop()
    {
        this.enable = false;
    }

    /// <summary>
    /// 注册事件
    /// </summary>
    /// <param name="type"></param>
    /// <param name="handler"></param>
    public void AddEventHandler(int type, System.Action<Actor,object> handler)
    {
        List<System.Action<Actor, object>> eventList;
        if (!events.ContainsKey(type))
        {
            eventList = new List<System.Action<Actor, object>>();
            events[type] = eventList;
        }
        else
        {
            eventList = events[type];
        }

        if (!eventList.Contains(handler))
            eventList.Add(handler);
    }

    /// <summary>
    /// 触发事件
    /// </summary>
    /// <param name="type"></param>
    /// <param name="data"></param>
    public void DispatchEvent(int type, object data)
    {

        if (events.ContainsKey(type))
        {

            List<System.Action<Actor, object>> eventList = events[type];
            int lastCount = eventList.Count;

            System.Action<Actor, object> bevent;
            for (int i = 0; i < eventList.Count; )
            {
                bevent = eventList[i];
                bevent(actor, data);

                if (lastCount == eventList.Count)
                {
                    i++;
                }
                else
                {
                    lastCount = eventList.Count;
                }
            }
        }
    }

    /// <summary>
    /// 移除事件
    /// </summary>
    /// <param name="type"></param>
    public void RemoveEvent(int type)
    {
        events.Remove(type);
    }

    /// <summary>
    /// 移除事件
    /// </summary>
    /// <param name="type">类型</param>
    /// <param name="handler">处理函数</param>
    public void RemoveEvent(int type, System.Action<Actor, object> handler)
    {
        if (events.ContainsKey(type))
        {
            List<System.Action<Actor, object>> eventList = events[type];
            eventList.Remove(handler);
        }
    }
    /// <summary>
    /// 通过事件移除
    /// </summary>
    /// <param name="handler"></param>
    public void RemoveEvent(System.Action<Actor, object> handler)
    {
        foreach (var vc in events)
        {
            if (vc.Value.Remove(handler))
                break;
        }

    }
    #endregion

    #region private method
    /// <summary>
    /// for init b tree
    /// </summary>
    protected virtual void OnStart()
    {

    }

    /// <summary>
    /// 打印树的目录
    /// </summary>
    /// <returns></returns>
    public string Debug()
    {
        IBehaviourNode current = Foreach(root);
        if (current != null)
            return GetPath(current);
        else
            return root.name + " " + root.status;
    }

    private IBehaviourNode Foreach(IBehaviourNode node)
    {
        if (node is CompositeNode)
        {
            CompositeNode a = node as CompositeNode;
            //a.chie
            if (a.status == BehaviourStatus.Running)
            {
                IList<IBehaviourNode> list = a.getChildrens;
                foreach (var IBehav in list)
                {
                    if (IBehav.status == BehaviourStatus.Running)
                        return Foreach(IBehav);
                }
            }
        }
        else if (node.status == BehaviourStatus.Running)
        {
            return node;
        }

        return null;

    }

    private string GetPath(IBehaviourNode current)
    {
        string re = "/" + current.name + "" + current.status;
        if (current.parent == null)
        {
            return re;
        }
        else
        {
            re += GetPath(current.parent);
            return re;
        }
    }
    #endregion
}
