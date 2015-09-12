// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections;

#region 事件行动节点
/// <summary>
/// 事件行动节点
/// 接受到时间通知后才完成
/// </summary>
public class ActionEventNode : ActionNode
{
    /// <summary>
    ///  事件行动节点
    /// </summary>
    /// <param name="action">委托<![CDATA[ System.Action<object, object, ActionNode>]]></param>
    public ActionEventNode(ActionDelegate action)
        : base(action)
    {

    }

    /// <summary>
    ///  事件行动节点
    /// </summary>
    /// <param name="action">委托<![CDATA[ System.Action<object, object, ActionNode>]]></param>
    public ActionEventNode(ActionDelegate action, string name)
        : base(action, name)
    {
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        //Debug.Log(string.Format("ActionEventNode status={0}", status));
        if (status == BehaviourStatus.Ready)
        {
            status = BehaviourStatus.Running;
            output.leafNode = this;
            action(input, output);
        }
    }

    public void OnEvent(Actor actor, object data)
    {
        status = BehaviourStatus.Success;

        if (data is Actor)
        {
            //RoleActor actor = data as RoleActor;
            //actor.brain.RemoveEvent(OnEvent);

            //Debug.Log(string.Format(" {0} {1} Success",this.name ,actor));
        }
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ActionEventNode(this.action);
        base.CopyTo(behaviourNode);
        return behaviourNode;
    }

}

#endregion

#region 事件节点

/// <summary>
/// 某个事件触发，只能有一个子节点
/// </summary>
public class EventNode : CompositeNode
{
    /// <summary>
    /// 事件节点
    /// </summary>
    /// <param name="eventType">事件类型ID</param>
    public EventNode(int eventType, string name)
        : base(name)
    {
        this.eventType = eventType;
        triggered = false;
        isInit = false;
    }

    /// <summary>
    /// 事件节点
    /// </summary>
    /// <param name="eventType">事件类型ID</param>
    public EventNode(int eventType)
        : base()
    {
        this.eventType = eventType;
        triggered = false;
        isInit = false;
    }

    private bool isInit = false;

    public int eventType { private set; get; }
    public bool triggered { private set; get; }
    public object data { private set; get; }

    private void OnEvent(Actor actor, object data)
    {
        if (status == BehaviourStatus.Running && children.Count >= 1)
        {
            children[0].Reset();
        }
        this.data = data;
        //actor.brain.bTree.Reset();
        triggered = true;

        //if (eventType == (int)BrainEventEnum.SkillAttack)
        //Debug.Log(string.Format("trigger EventNode {0} data {1} status ={2} ,actor ={3}  ", this.name + (BrainEventEnum)eventType, data, status, actor));
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        if (status == BehaviourStatus.Ready && !isInit)
        {
            isInit = true;
            //Debug.Log(string.Format("AddEventHandler {0} status ={1} ,actor ={2} ", this.name + (BrainEventEnum)eventType, status, input.actor));
            //input.actor.brain.AddEventHandler(eventType, OnEvent);
        }

        if (status == BehaviourStatus.Ready && triggered)
        {
            triggered = false;
            status = BehaviourStatus.Running;
            //Debug.Log(string.Format("BeginRunning  EventNode {0} data {1} status ={2}", this.name + (BrainEventEnum)eventType, data, status));
        }
        //Debug.Log(string.Format("Visit  EventNode {0} data {1} status ={2} triggered ={3}", this.name + (BrainEventEnum)eventType, data, status, triggered));

        if (status == BehaviourStatus.Running)
        {
            if (children.Count >= 1)
            {
                BTOutput oup = output;
                oup.eventData = data;
                var child = children[0];
                child.Visit(input, output);
                status = child.status;
                oup.eventData = null;
                //if (status != BehaviourStatus.Running)
                //{
                //Debug.Log(string.Format(" EventNode {0} Complete {1} ", this.name, status));
                //MyDebug.StackTrace();
                //}
            }
            else
            {
                status = BehaviourStatus.Failed;
            }
        }
    }

    //public override void Step()
    //{
    //    base.Step();
    //    //triggered = false;
    //}

    //public override void Reset()
    //{
    //    //Debug.Log(string.Format("Reset  EventNode {0} data {1} status ={2} ,triggered ={3}", this.name + (BrainEventEnum)eventType, data, status, triggered));
    //    triggered = false;
    //    base.Reset();
    //}

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new EventNode(this.eventType);
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    }
}

#endregion

#region trigger node

/// <summary>
/// 触发事件
/// </summary>
public class TriggerNode : BehaviourNode
{

    public TriggerNode(int eventType)
        : base()
    {
        this.eventType = eventType;
    }

    public TriggerNode(int eventType, string name)
        : base(name)
    {
        this.eventType = eventType;
    }

    protected int eventType = 0;

    public override void Visit(BTInput input, BTOutput output)
    {
        Actor actor = input.actor;
        object data = output.eventData;

        if (data != null)
        {
            //Debug.Log("触发事件" + actor + "=>" + (BrainEventEnum)eventType + " data= " + data);
            //actor.brain.DispatchEvent(eventType, data);
            status = BehaviourStatus.Success;
        }
        else
        {
            status = BehaviourStatus.Failed;
        }
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new TriggerNode(this.eventType);
        base.CopyTo(behaviourNode);
        return behaviourNode;
    }
}

#endregion