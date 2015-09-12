// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections;

/// <summary>
/// 记录节点信息
/// </summary>
public class BTOutput
{
    /// <summary>
    /// 主体
    /// </summary>
    public Actor actor;


    public BTOutput()
    {

    }

    public BTOutput(Actor actor)
    {
        this.actor = actor;
    }

    ///// <summary>
    ///// 目标位置
    ///// </summary>
    //public Vector3 position;

    ///// <summary>
    ///// 目标对象
    ///// </summary>
    //public RoleActor target;

    ///// <summary>
    ///// 技能ID
    ///// </summary>
    //public int skillId;

    /// <summary>
    /// 当前叶子节点
    /// </summary>
    public IBehaviourNode leafNode;

    /// <summary>
    /// 事件节点数据
    /// </summary>
    public object eventData;
}
