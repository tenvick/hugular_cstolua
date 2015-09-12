// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections.Generic;
using LuaInterface;

#region 条件节点
/// <summary>
/// 条件节点
/// </summary>
public class ConditionNode : BehaviourNode
{
    protected Condition _condition;
    protected LuaFunction _fn;

    /// <summary>
    ///  条件节点
    /// </summary>
    /// <param name="condition">条件委托 bool Condition(object input, object output)</param>
    public ConditionNode(Condition condition):base()
    {
        this._condition = condition;
        _fn = null;
    }

    /// <summary>
    ///  条件节点
    /// </summary>
    /// <param name="condition">条件委托 bool Condition(object input, object output)</param>
    public ConditionNode(Condition condition,string name)
        : base(name)
    {
        this._condition = condition;
        _fn = null;
    }

    /// <summary>
    ///  条件节点
    /// </summary>
    /// <param name="fn">条件委托 luafunction(input,output)</param>
    public ConditionNode(LuaFunction fn):base()
    {
        this._fn = fn;
        _condition = null;
    }

    /// <summary>
    /// 条件节点
    /// </summary>
    /// <param name="fn">条件委托 luafunction(input,output)</param>
    /// <param name="name">节点名</param>
    public ConditionNode(LuaFunction fn,string name):base(name)
    {
        this._fn = fn;
        _condition = null;
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        output.leafNode = this;
        if (_condition != null)
        {
            if (_condition(input, output))
            {
                this._status = BehaviourStatus.Success;
            }
            else
            {
                this._status = BehaviourStatus.Failed;
            }
        }
        else if (_fn != null)
        {
            object[] res = _fn.Call(input, output);
            if (res.Length > 0 && res[0].Equals(true))
            {
                this._status = BehaviourStatus.Success;
            }
            else
            {
                this._status = BehaviourStatus.Failed;
            }
        }
        else
        {
            this._status = BehaviourStatus.Failed;
        }

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ConditionNode(this._condition);
        base.CopyTo(behaviourNode);
        behaviourNode._fn = this._fn;
        behaviourNode._condition = this._condition;
        return behaviourNode;
    }
}

/// <summary>
/// 条件等待节点
/// </summary>
public class ConditionWaitNode : ConditionNode
{

    public ConditionWaitNode(Condition condition,string name)
        : base(condition,name)
    {
    }

    public ConditionWaitNode(LuaFunction fn,string name)
        : base(fn,name)
    {

    }

    public ConditionWaitNode(Condition condition)
        : base(condition)
    {
    }

    public ConditionWaitNode(LuaFunction fn)
        : base(fn)
    {
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        output.leafNode = this;

        if (_condition != null)
        {
            if (_condition(input, output))
            {
                this._status = BehaviourStatus.Success;
            }
            else
            {
                this._status = BehaviourStatus.Running;
            }
        }
        else if (_fn != null)
        {
            object[] res = _fn.Call(input, output);
            if (res.Length > 0 && res[0].Equals(true))
            {
                this._status = BehaviourStatus.Success;
            }
            else
            {
                this._status = BehaviourStatus.Running;
            }
        }
        else
        {
            this._status = BehaviourStatus.Failed;
        }

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ConditionWaitNode(this._condition);
        base.CopyTo(behaviourNode);
        behaviourNode._fn = this._fn;
        behaviourNode._condition = this._condition;
        return behaviourNode;
    }
}

/// <summary>
/// 非 条件节点
/// </summary>
public class ConditionNotNode : ConditionNode
{
    /// <summary>
    ///  非 条件节点
    /// </summary>
    /// <param name="condition">条件委托 bool Condition(object input, object output)</param>
    public ConditionNotNode(Condition condition,string name)
        : base(condition,name)
    {

    }

    /// <summary>
    ///  非 条件节点
    /// </summary>
    /// <param name="fn">条件委托 luafunction(input,output)</param>
    public ConditionNotNode(LuaFunction fn, string name)
        : base(fn,name)
    {

    }
    /// <summary>
    ///  非 条件节点
    /// </summary>
    /// <param name="condition">条件委托 bool Condition(object input, object output)</param>
    public ConditionNotNode(Condition condition):base(condition)
    {

    }

    /// <summary>
    ///  非 条件节点
    /// </summary>
    /// <param name="fn">条件委托 luafunction(input,output)</param>
    public ConditionNotNode(LuaFunction fn)
        : base(fn)
    {

    }

    public override void Visit(BTInput input, BTOutput output)
    {
        output.leafNode = this;
        if (_condition != null)
        {
            if (_condition(input, output))
            {
                this._status = BehaviourStatus.Failed;
            }
            else
            {
                this._status = BehaviourStatus.Success;
            }
        }
        else if (_fn != null)
        {
            object[] res = _fn.Call(input, output);
            if (res.Length > 0 && res[0].Equals(true))
            {
                this._status = BehaviourStatus.Failed;
            }
            else
            {
                this._status = BehaviourStatus.Success;
            }
        }
        else
        {
            this._status = BehaviourStatus.Failed;
        }

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ConditionNotNode(this._condition);
        base.CopyTo(behaviourNode);
        behaviourNode._fn = this._fn;
        behaviourNode._condition = this._condition;
        return behaviourNode;
    }
}

/// <summary>
/// 按一定时间执行的条件节点
/// </summary>
public class DeltaConditionNode : ConditionNode
{
    /// <summary>
    /// 执行时间秒
    /// </summary>
    public float delta = 0.167f;

    protected float lastTime = 0;

    /// <summary>
    /// 按一定时间执行的条件节点
    /// </summary>
    /// <param name="condition">Condition</param>
    public DeltaConditionNode(float delta, Condition condition)
        : base(condition)
    {
        this.delta = delta;
    }

    /// <summary>
    /// 按一定时间执行的条件节点
    /// </summary>
    /// <param name="fn">luafunction</param>
    public DeltaConditionNode(float delta,LuaFunction fn)
        : base(fn)
    {
        this.delta = delta;
    }

    /// <summary>
    /// 按一定时间执行的条件节点
    /// </summary>
    /// <param name="condition">Condition</param>
    public DeltaConditionNode(float delta, Condition condition, string name)
        : base(condition,name)
    {
        this.delta = delta;
    }

    /// <summary>
    /// 按一定时间执行的条件节点
    /// </summary>
    /// <param name="fn">luafunction</param>
    public DeltaConditionNode(float delta, LuaFunction fn, string name)
        : base(fn,name)
    {
        this.delta = delta;
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        float dt = Time.unscaledTime - lastTime; //Debug.Log(string.Format("DeltaConditionNode doit={0} ,dt={1}", dt > delta, dt));
        if (dt > delta)
        {
            output.leafNode = this;
            base.Visit(input, output);
            lastTime = Time.unscaledTime;
        }
        else
        {
            this.status = BehaviourStatus.Failed;
        }

    }

    //public override void Reset()
    //{
    //    base.Reset();
    //    //lastTime = 0;
    //}

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new DeltaConditionNode(this.delta,this._condition);
        base.CopyTo(behaviourNode);
        behaviourNode._fn = this._fn;
        behaviourNode._condition = this._condition;
        return behaviourNode;
    }

}

/// <summary>
/// 条件委托
/// </summary>
/// <param name="input"></param>
/// <param name="output"></param>
/// <returns></returns>
public delegate bool Condition(BTInput input, BTOutput output);

#endregion

#region 行动节点
/// <summary>
/// 行动委托
/// </summary>
/// <param name="input"></param>
/// <param name="output"></param>
/// <returns></returns>
public delegate void ActionDelegate(BTInput input, BTOutput output);

/// <summary>
/// 行动节点
/// </summary>
public class ActionNode : BehaviourNode
{
    protected ActionDelegate action;

    /// <summary>
    /// 行动节点
    /// </summary>
    /// <param name="action"><![CDATA[System.Action<object, object, ActionNode>]]></param>
    public ActionNode(ActionDelegate action)
        : base()
    {
        this.action = action;
    }

    /// <summary>
    /// 行动节点
    /// </summary>
    /// <param name="action"></param>
    /// <param name="name"></param>
    public ActionNode(ActionDelegate action, string name)
        : base(name)
    {
        this.action = action;
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        this.status = BehaviourStatus.Success;
        output.leafNode = this;
        action(input, output);
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ActionNode(this.action);
        base.CopyTo(behaviourNode);
        return behaviourNode;
    }
}

/// <summary>
/// 总是失败的行动节点
/// </summary>
public class ActionNotNode : BehaviourNode
{
    protected ActionDelegate action;

    /// <summary>
    /// 行动节点
    /// </summary>
    /// <param name="action"><![CDATA[System.Action<object, object, ActionNode>]]></param>
    public ActionNotNode(ActionDelegate action)
        : base()
    {
        this.action = action;
    }

    /// <summary>
    /// 行动节点
    /// </summary>
    /// <param name="action"></param>
    /// <param name="name"></param>
    public ActionNotNode(ActionDelegate action, string name)
        : base(name)
    {
        this.action = action;
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        this.status = BehaviourStatus.Failed;
        output.leafNode = this;
        action(input, output);
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ActionNotNode(this.action);
        base.CopyTo(behaviourNode);
        return behaviourNode;
    }
}

/// <summary>
/// 间隔时间执行的行动节点
/// </summary>
public class DeltaActionNode : ActionNode
{
    /// <summary>
    /// 执行时间秒
    /// </summary>
    public float delta = 0.167f;

    private float lastTime = 0;

    /// <summary>
    /// 一定时间间隔执行的行动节点
    /// </summary>
    /// <param name="action"><![CDATA[System.Action<object, object, ActionNode>]]></param>
    public DeltaActionNode(float delta,ActionDelegate action)
        : base(action)
    {
        this.delta = delta;
    }

    /// <summary>
    /// 一定时间间隔执行的行动节点
    /// </summary>
    /// <param name="action"><![CDATA[System.Action<object, object, ActionNode>]]></param>
    public DeltaActionNode(float delta, ActionDelegate action, string name)
        : base(action,name)
    {
        //Debug.Log(string.Format("DeltaActionNode action= {0} name = {1}", action, name));
        this.delta = delta;
    }

    public override void Visit(BTInput input, BTOutput output)
    {
         float dt = Time.unscaledTime - lastTime;
        if (dt > delta)
        {
            base.Visit(input, output);
            lastTime = Time.unscaledTime;
        }
        else
        {
            this.status = BehaviourStatus.Success;
        }
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new DeltaActionNode(this.delta, this.action);
        base.CopyTo(behaviourNode);
        return behaviourNode;
    }
}

#endregion

#region 等待节点

/// <summary>
/// 等待指定时间后返回成功
/// The Wait node SUCCEEDS after a certain amount of time has passed
/// </summary>
public class WaitNode : BehaviourNode
{
    protected float duration = 0;
    protected float variation = 0;

    protected float wakeTime = 0;

   /// <summary>
    /// The Wait node SUCCEEDS after a certain amount of time has passed
   /// </summary>
   /// <param name="duration">The amount of seconds before the failure of the node occurs.</param>
   /// <param name="variation">The extra amount of time that will be added on top of the specified duration, in the range 0, variation. This allows to have random variations between different executions of the node.</param>
    public WaitNode(float duration, float variation)
        : base()
    {
        this.duration = duration;
        this.variation = variation;
    }

    /// <summary>
    /// The Wait node SUCCEEDS after a certain amount of time has passed
    /// </summary>
    /// <param name="duration">The amount of seconds before the failure of the node occurs.</param>
    /// <param name="variation">The extra amount of time that will be added on top of the specified duration, in the range 0, variation. This allows to have random variations between different executions of the node.</param>
    /// <param name="name">the name of the nodes</param>
    public WaitNode(float duration, float variation,string name)
        : base(name)
    {
        this.duration = duration;
        this.variation = variation;
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        float currTime = Time.unscaledTime;

        if (status != BehaviourStatus.Running)
        {
            wakeTime = currTime + duration+Random.Range(0,variation);
            status = BehaviourStatus.Running;
        }

        if (status == BehaviourStatus.Running)
        {
            if (currTime >= wakeTime)
                status = BehaviourStatus.Success;
        }
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new WaitNode(this.duration, this.variation);
        base.CopyTo(behaviourNode);
        return behaviourNode;
    }
}

#endregion

#region 超时节点

/// <summary>
/// 等待指定时间后返回失败
/// The Timeout node FAILS after a certain amount of time has passed.
/// </summary>
public class TimeoutNode : BehaviourNode
{
    protected float duration = 0;
    protected float variation = 0;

    protected float wakeTime = 0;

   /// <summary>
    /// The Timeout node FAILS after a certain amount of time has passed.
   /// </summary>
   /// <param name="duration">The amount of seconds before the failure of the node occurs.</param>
   /// <param name="variation">The extra amount of time that will be added on top of the specified duration, in the range 0, variation. This allows to have random variations between different executions of the node.</param>
    public TimeoutNode(float duration, float variation)
        : base()
    {
        this.duration = duration;
        this.variation = variation;
    }

    /// <summary>
    /// The Timeout node FAILS after a certain amount of time has passed.
    /// </summary>
    /// <param name="duration">The amount of seconds before the failure of the node occurs.</param>
    /// <param name="variation">The extra amount of time that will be added on top of the specified duration, in the range 0, variation. This allows to have random variations between different executions of the node.</param>
    /// <param name="name">the name of the nodes</param>
    public TimeoutNode(float duration, float variation, string name)
        : base(name)
    {
        this.duration = duration;
        this.variation = variation;
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        float currTime = Time.unscaledTime;

        if (status != BehaviourStatus.Running)
        {
            wakeTime = currTime + duration+Random.Range(0,variation);
            status = BehaviourStatus.Running;
        }

        if (status == BehaviourStatus.Running)
        {
            if (currTime >= wakeTime)
                status = BehaviourStatus.Failed;
        }
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new TimeoutNode(this.duration, this.variation);
        base.CopyTo(behaviourNode);
        return behaviourNode;
    }
}

#endregion


/// <summary>
/// 复合节点
/// </summary>
public class CompositeNode : BehaviourNode
{
    protected IList<IBehaviourNode> children;

    public CompositeNode():base()
    {
        children = new List<IBehaviourNode>();
    }

    public CompositeNode(string name):base(name)
    {
        children = new List<IBehaviourNode>();
        this.name = this.GetType().Name + name;
    }

    public CompositeNode(IList<IBehaviourNode> children,string name)
    {
        this.children = children;
        foreach (IBehaviourNode node in children)
        {
            node.parent = this;
        }
        this.name = this.GetType().Name+name;
    }

    public void AddNode(IBehaviourNode node)
    {
        node.parent = this;
        children.Add(node);
    }

    public override void Step()
    {
        if (status != BehaviourStatus.Running)
        {
            this.Reset();
        }
        else if (children != null)
        {
            foreach (IBehaviourNode child in children)
                child.Step();
        }
    }

    public override void Reset()
    {
        if (status != BehaviourStatus.Ready)
        {
            status = BehaviourStatus.Ready;
            foreach (IBehaviourNode child in children)
                child.Reset();
        }
    }

    public IList<IBehaviourNode> getChildrens
    {
        get
        {
            return children;
        }
    }
    protected void CopyToCompositeNode(CompositeNode behaviourNode)
    {
        base.CopyTo(behaviourNode);
        foreach (IBehaviourNode child in children)
        {
            behaviourNode.AddNode(child.Clone());
        }
    }

}

#region 装饰节点
public class DecoratorNode : CompositeNode
{
   /// <summary>
    /// 装修结果
    /// </summary>
    public DecoratorNode()
        : base()
    {
    }

    /// <summary>
    /// 装修结果
    /// </summary>
    public DecoratorNode(string name)
        : base(name)
    {

    }

    /// <summary>
    /// 装修结果
    /// </summary>
    /// <param name="children">子节点</param>
    public DecoratorNode(IList<IBehaviourNode> children, string name)
        : base(children,name)
    {

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new DecoratorNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    } 
}

/// <summary>
/// 反转结果
/// 只支持一个节点
/// </summary>
public class DecoratorNotNode : CompositeNode
{
     /// <summary>
    /// 反转结果
    /// 只支持一个节点
    /// </summary>
    public DecoratorNotNode()
        : base()
    {
    }

    /// <summary>
    /// 反转结果
    /// 只支持一个节点
    /// </summary>
    public DecoratorNotNode(string name)
        : base(name)
    {

    }

    /// <summary>
    /// 反转结果
    /// 只支持一个节点
    /// </summary>
    /// <param name="children">子节点</param>
    public DecoratorNotNode(IList<IBehaviourNode> children, string name)
        : base(children,name)
    {

    } 

    public override void Visit(BTInput input, BTOutput output)
    {
        var child = this.children[0];
        child.Visit(input, output);

        if (child.status == BehaviourStatus.Success)
            status = BehaviourStatus.Failed;
        else if (child.status == BehaviourStatus.Failed)
            status = BehaviourStatus.Success;
        else
            status = child.status;

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new DecoratorNotNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    } 
}

#endregion

#region 选择节点
/// <summary>
/// 当执行本类型Node时，它将从begin到end迭代执行自己的Child Node：
///  如遇到一个Child Node执行后返回True，那停止迭代，
///  如果没有Child Node 返回True 那本Node返回False,所有节点失败返回失败。
///  The node executes the children in sequential order and SUCCEEDS as soon as one of the child SUCCEEDS. The children that follows the succeeding one are not executed.
/// The node FAILS if all the children FAIL.
/// </summary>
public class SelectorNode : CompositeNode
{
    protected int currIndex = 0;

    /// <summary>
    /// 选择节点 依次选择执行直到第一个child成功后停止
    /// </summary>
    public SelectorNode()
        : base()
    {
    }

    /// <summary>
    /// 选择节点 依次选择执行直到第一个child成功后停止
    /// </summary>
    public SelectorNode(string name)
        : base(name)
    {
    }

    /// <summary>
    ///  选择节点 依次选择执行直到第一个child成功后停止
    /// </summary>
    /// <param name="children">子节点</param>
    public SelectorNode(IList<IBehaviourNode> children,string name)
        : base(children,name)
    {
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        if (status != BehaviourStatus.Running)
            this.currIndex = 0;

        int len = this.children.Count;
        while (this.currIndex < len)
        {
            IBehaviourNode child = children[this.currIndex];
            child.Visit(input, output);
            if (child.status == BehaviourStatus.Running || child.status == BehaviourStatus.Success)
            {
                this.status = child.status;
                return;
            }
            this.currIndex++;
        }

        this.status = BehaviourStatus.Failed;
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new SelectorNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    } 
}

/// <summary>
/// 随机选择一个节点执行
/// 如遇到一个Child Node执行后返回True，那停止迭代，
/// 如果当前节点失败继续下个节点，所有节点失败返回失败
/// </summary>
public class RandomNode : CompositeNode
{
    protected int currIndex = 0;

    /// <summary>
    /// 随机选择一个节点执行
    /// </summary>
    public RandomNode()
        : base()
    {
    }

    /// <summary>
    /// 随机选择一个节点执行
    /// </summary>
    public RandomNode(string name)
        : base(name)
    {
    }

    /// <summary>
    /// 随机选择一个节点执行
    /// </summary>
    /// <param name="children">子节点</param>
    public RandomNode(IList<IBehaviourNode> children,string name)
        : base(children,name)
    {

    }

    public override void Visit(BTInput input, BTOutput output)
    {

        if (status == BehaviourStatus.Ready)
        {
            int len = this.children.Count - 1;
            this.currIndex = Random.Range(0, len);
            int start = this.currIndex;

            while (true)
            {
                IBehaviourNode child = children[this.currIndex];
                child.Visit(input, output);
                if (child.status != BehaviourStatus.Failed)
                {
                    this.status = child.status;
                    return;
                }
                this.currIndex++;

                if (this.currIndex == len)
                    this.currIndex = 0;

                if (this.currIndex == start)
                {
                    this.status = BehaviourStatus.Failed;
                    return;
                }
            }
        }
        else
        {
            IBehaviourNode child = children[this.currIndex];
            child.Visit(input, output);
            this.status = child.status;
        }

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new RandomNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    } 
}

#endregion

#region 顺序节点
/// <summary>
///    它将从begin到end迭代执行自己的Child Node：
///    如遇到一个Child Node执行后返回False，那停止迭代，
///    所有Child Node都返回True,那本Node向自己的返回True，
///    The node SUCCEEDS if all the children SUCCEED.
/// The node FAILS if any of the children FAILS.
/// </summary>
public class SequenceNode : CompositeNode
{
    protected int currIndex = 0;

    /// <summary>
    /// 顺序节点
    /// </summary>
    public SequenceNode()
        : base()
    {
    }

    /// <summary>
    /// 顺序节点
    /// </summary>
    public SequenceNode(string name)
        : base(name)
    {

    }

    /// <summary>
    /// 顺序节点
    /// </summary>
    /// <param name="children">子节点</param>
    public SequenceNode(IList<IBehaviourNode> children,string name)
        : base(children,name)
    {

    }

    public override void Visit(BTInput input, BTOutput output)
    {
        if (status != BehaviourStatus.Running)
        {
            this.currIndex = 0;
        }

        int len = this.children.Count;
        while (this.currIndex < len)
        {
            IBehaviourNode child = children[this.currIndex];
            child.Visit(input, output);
            if (child.status == BehaviourStatus.Running || child.status == BehaviourStatus.Failed)
            {
                this.status = child.status;
                return;
            }
            this.currIndex++;
        }

        this.status = BehaviourStatus.Success;

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new SequenceNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    } 
}

/// <summary>
/// 顺序节点
///  它将从begin到end迭代执行自己的Child Node：
///  如遇到一个Child Node执行后返回False，那停止迭代，
///  始终返回true 
/// </summary>
public class SequenceTrueNode : SequenceNode
{
    /// <summary>
    /// 顺序节点
    /// </summary>
    public SequenceTrueNode()
        : base()
    {
    }

    /// <summary>
    /// 顺序节点
    /// </summary>
    public SequenceTrueNode(string name)
        : base(name)
    {

    }

    /// <summary>
    /// 顺序节点
    /// </summary>
    /// <param name="children">子节点</param>
    public SequenceTrueNode(IList<IBehaviourNode> children, string name)
        : base(children,name)
    {

    }

    public override void Visit(BTInput input, BTOutput output)
    {
        if (status != BehaviourStatus.Running)
        {
            this.currIndex = 0;
        }

        int len = this.children.Count;
        while (this.currIndex < len)
        {
            IBehaviourNode child = children[this.currIndex];
            child.Visit(input, output);
            if (child.status == BehaviourStatus.Running)
            {
                this.status = child.status;
                return;
            }
            else if (child.status == BehaviourStatus.Failed)
            {
                this.status = BehaviourStatus.Success;
                return;
            }
            this.currIndex++;
        }

        this.status = BehaviourStatus.Success;

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new SequenceTrueNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    } 
}

#endregion

#region 并行节点
/// <summary>
/// 平行执行它的所有Child Node,遇到False则返回False，全True才返回True。
/// 如果已经返回true的节点不会再次访问
/// </summary>
public class ParallelNode : CompositeNode
{
    /// <summary>
    /// 并行节点
    /// </summary>
    public ParallelNode()
        : base()
    {
    }

    /// <summary>
    /// 并行节点
    /// </summary>
    public ParallelNode(string name)
        : base(name)
    {

    }

    /// <summary>
    /// 并行节点
    /// </summary>
    /// <param name="children">子节点</param>
    public ParallelNode(IList<IBehaviourNode> children,string name)
        : base(children,name)
    {
    }

    public override void Step()
    {
        if (status != BehaviourStatus.Running)
            this.Reset();
        else if (this.children != null)
        {
            foreach (IBehaviourNode child in children)
            {
                if (child.status == BehaviourStatus.Success && child is ConditionNode)
                    child.Reset();
            }
        }
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        bool done = true;
        bool any_done = false;
        foreach (IBehaviourNode child in children)
        {
            if (children is ConditionNode)
            {
                child.Reset();
            }

            if (child.status != BehaviourStatus.Success)
            {
                child.Visit(input, output);
                if (child.status == BehaviourStatus.Failed)
                {
                    this.status = BehaviourStatus.Failed;
                    return;
                }
            }

            if (child.status == BehaviourStatus.Running)
                done = false;
            else
                any_done = true;

        }

        if (done || (stopOnAnyComplete && any_done))
            this.status = BehaviourStatus.Success;
        else
            this.status = BehaviourStatus.Running;

    }

    protected bool stopOnAnyComplete = false;

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ParallelNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    } 
}

/// <summary>
/// 平行执行它的所有Child Node,遇到False则返回False，有True返回True。
/// </summary>
public class ParallelNodeAny : ParallelNode
{
    /// <summary>
    /// 并行any节点
    /// </summary>
    public ParallelNodeAny()
        : base()
    {
        this.stopOnAnyComplete = true;
    }

    /// <summary>
    /// 并行any节点
    /// </summary>
    public ParallelNodeAny(string name)
        : base(name)
    {
        this.stopOnAnyComplete = true;
    }

    /// <summary>
    /// 并行any节点
    /// </summary>
    /// <param name="children">子节点列表</param>
    /// <param name="name">节点名字</param>
    public ParallelNodeAny(IList<IBehaviourNode> children,string name)
        : base(children, name)
    {
        this.stopOnAnyComplete = true;
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ParallelNodeAny();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    } 
}

/// <summary>
/// 遇到True则返回True，全False才返回False
/// </summary>
public class ParallelSelectorNode : CompositeNode
{
    /// <summary>
    /// 并行顺序节点
    /// 遇到True则返回True，全False才返回False
    /// </summary>
    public ParallelSelectorNode()
        : base()
    {
    }

    /// <summary>
    /// 并行顺序节点
    /// 遇到True则返回True，全False才返回False
    /// </summary>
    /// <param name="name">节点名</param>
    public ParallelSelectorNode(string name)
        : base(name)
    {

    }

    /// <summary>
    /// 并行顺序节点
    /// 遇到True则返回True，全False才返回False
    /// </summary>
    /// <param name="children">子节点</param>    
    /// <param name="name">节点名</param>
    public ParallelSelectorNode(IList<IBehaviourNode> children, string name)
        : base(children,name)
    {
    }

    public override void Step()
    {
        if (status != BehaviourStatus.Running)
            this.Reset();
        else if (this.children != null)
        {
            foreach (IBehaviourNode child in children)
            {
                if (child.status == BehaviourStatus.Success && child is ConditionNode)
                    child.Reset();
            }
        }
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        bool done = true;
        foreach (IBehaviourNode child in children)
        {
            if (children is ConditionNode)
            {
                child.Reset();
            }

            child.Visit(input, output);

            if (child.status == BehaviourStatus.Running)
                done = false;
            else if (child.status == BehaviourStatus.Success)
            {
                status = child.status;
                return;
            }
        }

        if (!done)
            this.status = BehaviourStatus.Running;
        else
            this.status = BehaviourStatus.Failed;

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ParallelSelectorNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    }
}

/// <summary>
///  所有False才返回False，否则返回True
/// </summary>
public class ParallelFallOnAllNode : CompositeNode
{
    /// <summary>
    /// 并行FallOnAll节点
    /// 并行顺序节点 所有False才返回False，否则返回True
    /// </summary>
    public ParallelFallOnAllNode()
        : base()
    {
    }

    /// <summary>
    /// 并行FallOnAll节点
    /// 并行顺序节点 所有False才返回False，否则返回True
    /// </summary>
    public ParallelFallOnAllNode(string name)
        : base(name)
    {
    }

    /// <summary>
    /// 并行FallOnAll节点
    /// 所有False才返回False，否则返回True
    /// </summary>
    /// <param name="children">子节点</param>
    /// <param name="name">节点名</param>
    public ParallelFallOnAllNode(IList<IBehaviourNode> children,string name)
        : base(children,name)
    {

    }

    public override void Step()
    {
        if (status != BehaviourStatus.Running)
            this.Reset();
        else if (this.children != null)
        {
            foreach (IBehaviourNode child in children)
            {
                if (child.status == BehaviourStatus.Success && child is ConditionNode)
                    child.Reset();
            }
        }
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        bool done = true;
        bool has_true = false;
        foreach (IBehaviourNode child in children)
        {
            if (children is ConditionNode)
            {
                child.Reset();
            }

            child.Visit(input, output);

            if (child.status == BehaviourStatus.Running)
                done = false;
            else if (child.status == BehaviourStatus.Success)
                has_true = true;
        }

        if (!done)
            this.status = BehaviourStatus.Running;
        else if (has_true)
            this.status = BehaviourStatus.Success;
        else
            this.status = BehaviourStatus.Failed;

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new ParallelFallOnAllNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    }
}
#endregion

#region if 节点

/// <summary>
/// if 条件节点
/// </summary>
public class IfNode : SequenceNode
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="condition"></param>
    /// <param name="node"></param>
    public IfNode(ConditionNode condition, IBehaviourNode node,string name)
        : base(name)
    {
        this.AddNode(condition);
        this.AddNode(node);
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var condition = this.children[0].Clone() as ConditionNode;
        var node = this.children[1].Clone();
        var behaviourNode = new IfNode(condition, node,this.name);
        //base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    }
}

#endregion

#region loop

/// <summary>
/// The Loop node allows to execute one child a multiple number of times n (if n is not specified then it's considered to be infinite) or until the child FAILS its execution
/// </summary>
public class LoopNode : CompositeNode
{
      protected int currIndex = 0;

      protected int count = 0;

      protected int rep = 0;

    /// <summary>
    ///  循环节点
    /// 遇到false返回false
    /// 全true 次数完成返回true
    /// </summary>
    /// <param name="count">循环次数</param>
    public LoopNode(int count)
        : base()
    {
        this.count = count;
    }

    /// <summary>
    ///  循环节点
    /// 遇到false返回false
    /// 全true 次数完成返回true
    /// </summary>
    /// <param name="count">循环次数</param>
    /// <param name="name">节点名称</param>
    public LoopNode(int count,string name)
        : base(name)
    {
        this.count = count;
    }

    /// <summary>
    /// 循环节点 
    /// 遇到false返回false
    /// 全true 次数完成返回true
    /// </summary>
    /// <param name="children">子节点</param>
    /// <param name="count">循环次数</param>
    /// <param name="name">节点名称</param>
    public LoopNode(int count,IList<IBehaviourNode> children, string name)
        : base(children,name)
    {
        this.count = count;
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        if (status != BehaviourStatus.Running)
        {
            this.currIndex = 0;
            this.rep = 0;
        }

        int len = this.children.Count;
        while (this.currIndex < len)
        {
            IBehaviourNode child = children[this.currIndex];
            child.Visit(input, output);
            //Debug.Log(string.Format("LoopNode {0},count ={1}rep={2} status={3} child.name ={4} child.status={5}", name, count, rep, status, child.name, child.status));

            if (child.status == BehaviourStatus.Running || child.status == BehaviourStatus.Failed)
            {
                this.status = child.status;
                return;
            }
            else
            {
                this.status = BehaviourStatus.Running;
            }
            this.currIndex++;
        }

        if (currIndex >= len) //从头开始
        {
            currIndex = 0;//从头开始
            rep++;
        }

        if (rep > count && count>0)
        {
            this.status = BehaviourStatus.Success;
        }
        //else
        //{
        //    foreach (var child in children)
        //        child.Reset();
        //}


    }

    public override void Reset()
    {
        base.Reset();
        rep = 0;
        this.currIndex = 0;
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new LoopNode(this.count);
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    }
}

/// <summary>
/// The LoopUntilSuccess node allows to execute one child until it SUCCEEDS. A maximum number of attempts can be specified. If no maximum number of attempts is specified or if it's set to <= 0, then this node will try to run its child over and over again until the child succeeds.
/// </summary>
public class LoopUntilSuccessNode : LoopNode
{
    /// <summary>
    ///  循环节点
    /// </summary>
    /// <param name="count">循环次数</param>
    public LoopUntilSuccessNode()
        : base(0)
    {
    }

    /// <summary>
    ///  循环节点
    /// </summary>
    /// <param name="count">循环次数</param>
    /// <param name="name">节点名称</param>
    public LoopUntilSuccessNode(string name)
        : base(0,name)
    {
    }

    /// <summary>
    /// 循环节点
    /// </summary>
    /// <param name="children">子节点</param>
    /// <param name="name">节点名称</param>
    public LoopUntilSuccessNode(IList<IBehaviourNode> children, string name)
        : base(0,children, name)
    {
    }

    public override void Visit(BTInput input, BTOutput output)
    {
        if (status != BehaviourStatus.Running)
        {
            this.currIndex = 0;
            this.rep = 0;
        }

        int len = this.children.Count;
        while (this.currIndex < len)
        {
            IBehaviourNode child = children[this.currIndex];
            child.Visit(input, output);
            if (child.status == BehaviourStatus.Running || child.status == BehaviourStatus.Success)
            {
                this.status = child.status;
                return;
            }
            else
            {
                this.status = BehaviourStatus.Running;
            }
            this.currIndex++;
        }

        if (currIndex >= len) currIndex = 0;//从头开始

    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new LoopUntilSuccessNode();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    }
}
#endregion

#region SuppressFailure
/// <summary>
/// The SuppressFailure node owns and executes one child. It will SUCCEED irregardless of the result of the child's execution.
/// </summary>
public class SuppressFailure : CompositeNode
{
    /// <summary>
    /// The SuppressFailure node owns and executes one child.
    /// The node SUCCEEDS as soon as the child execution finishes.
    /// </summary>
      public SuppressFailure()
        : base()
    {
    }

    /// <summary>
    /// The SuppressFailure node owns and executes one child.
    /// The node SUCCEEDS as soon as the child execution finishes.
    /// </summary>
    /// <param name="name"></param>
    public SuppressFailure(string name)
        : base(name)
    {
    }

    /// <summary>
    /// The SuppressFailure node owns and executes one child.
    /// The node SUCCEEDS as soon as the child execution finishes.
    /// </summary>
    /// <param name="children">子节点</param>
    /// <param name="name">节点名</param>
    public SuppressFailure(IList<IBehaviourNode> children, string name)
        : base(children,name)
    {

    }

    public override void Visit(BTInput input, BTOutput output)
    {

        if (children.Count >= 1)
        {
            var child = children[0];
            child.Visit(input, output);

            if (child.status != BehaviourStatus.Failed)
            {
                status = child.status;
            }
            else
            {
                status = BehaviourStatus.Success;
            }
        }
        else
        {
            status = BehaviourStatus.Success;
        }
    }

    /// <summary>
    /// clone
    /// </summary>
    /// <returns></returns>
    public IBehaviourNode Clone()
    {
        var behaviourNode = new SuppressFailure();
        base.CopyToCompositeNode(behaviourNode);
        return behaviourNode;
    }
}

#endregion

