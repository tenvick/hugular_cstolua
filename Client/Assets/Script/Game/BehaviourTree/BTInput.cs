// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 记录玩家信息
/// </summary>
public class BTInput  {
    /// <summary>
    /// 主体
    /// </summary>
    public Actor actor;

    public BTInput()
    {

    }

    public BTInput(Actor actor)
    {
        this.actor = actor;
    }

    /// <summary>
    /// 目标位置
    /// </summary>
    public Vector3 position;

    /// <summary>
    /// 目标对象
    /// </summary>
    public Actor target;

    ///// <summary>
    ///// 选择的技能ID
    ///// </summary>
    //public SkillData skill;

    /// <summary>
    /// 停止距离
    /// </summary>
    public float stopDistance;

    /// <summary>
    /// 是否处于拖动状态
    /// </summary>
    public bool isDragging;

}
