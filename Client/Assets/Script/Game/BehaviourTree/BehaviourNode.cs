// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections;

public abstract class BehaviourNode : IBehaviourNode
{

    public BehaviourNode()
    {
        this.name = this.GetType().Name;
    }

     public BehaviourNode(string name)
    {
        this.name = this.GetType().Name + name;
    }

    protected IBehaviourNode _parent;
    protected BehaviourStatus _status = BehaviourStatus.Ready;
    protected string _name;
    //protected float _nextupdatetime;

    public IBehaviourNode parent
    {
        get
        {
            return _parent;
        }
        set
        {
            _parent = value;
        }
    }

    public BehaviourStatus status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }

    public string name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public virtual void Visit(BTInput input, BTOutput output)
    {
        this._status = BehaviourStatus.Failed;
    }

    ///// <summary>
    ///// 秒为单位
    ///// </summary>
    ///// <param name="time"></param>
    //public void Sleep(float time)
    //{
    //    _nextupdatetime = Time.time + time;
    //}

    public virtual void Reset()
    {
        if (status != BehaviourStatus.Ready)
        {
            status = BehaviourStatus.Ready;
        }
        
    }

    public virtual void Step()
    {
        if (status != BehaviourStatus.Running)
        {
            this.Reset();
        }
    }

    protected void CopyTo(IBehaviourNode node)
    {
        node.name = this._name;
        node.parent = this._parent;
        //node.status = BehaviourStatus.Ready;
    }

    public IBehaviourNode Clone()
    {
        return this;
    }
}

/// <summary>
/// 行为节点接口
/// </summary>
public interface IBehaviourNode
{
    /// <summary>
    /// 父节点
    /// </summary>
    IBehaviourNode parent { get; set; }
    /// <summary>
    /// 当前状态
    /// </summary>
    BehaviourStatus status { get; set; }
    /// <summary>
    /// 节点名
    /// </summary>
    string name { get; set; }
    /// <summary>
    /// 访问节点
    /// </summary>
    /// <param name="input">BTOutput</param>
    /// <param name="output">BTOutput</param>
    void Visit(BTInput input, BTOutput output);
    ///// <summary>
    ///// 睡眠？
    ///// </summary>
    ///// <param name="time"></param>
    //void Sleep(float time);
    /// <summary>
    /// 下一步
    /// </summary>
    void Step();
    /// <summary>
    /// 重置到开时状态
    /// </summary>
    void Reset();

    /// <summary>
    /// clone 节点
    /// </summary>
    /// <returns></returns>
    IBehaviourNode Clone();
}


/// <summary>
/// 行为树节点状态
/// </summary>
public enum BehaviourStatus
{
    Ready,
    Running,
    Success,
    Failed,
}