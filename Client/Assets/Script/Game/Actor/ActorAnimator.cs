// Copyright (c) 2014 hugula
// actor animator
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections.Generic;


/// <summary>
/// 动画播放控制器
/// </summary>
[RequireComponent(typeof(Actor))]
public class ActorAnimator : MonoBehaviour
{
    #region public member
    /// <summary>
    /// 角色控制器
    /// </summary>
    public Actor actor;
    /// <summary>
    /// 动画控制器
    /// </summary>
    public Animator animator;
    /// <summary>
    /// 动画关键时间帧触发的事件
    /// </summary>
    public List<System.Action<ActorAnimator>> onEffect = new List<System.Action<ActorAnimator>>();

    /// <summary>
    /// 动画结束帧事件触发
    /// </summary>
    public List<System.Action<ActorAnimator>> onAnimEnd = new List<System.Action<ActorAnimator>>();
    /// <summary>
    /// 动画触发效果时间
    /// </summary>
    public float effectTime = 0.4f;
    /// <summary>
    /// 动画结束阶段时间
    /// </summary>
    public float endEffectTime = 0.90f;

    /// <summary>
    /// 当前播放的动画片段名称
    /// </summary>
    public string playStateName { get; private set; }

    #endregion

    #region private member
    /// <summary>
    /// 当前片段已经播放效果
    /// </summary>
    private bool didDameage;

    /// <summary>
    ///  调用过结束
    /// </summary>
    private bool didEnd = true;

    /// <summary>
    /// 速度hash值
    /// </summary>
    private int m_speed;

    /// <summary>
    /// 播放次数
    /// </summary>
    private int noLoopTimes;
    #endregion

    #region Mono
    // Use this for initialization
    void Start()
    {
        GetAimatorHashCode();
        if (animator == null) animator = this.GetComponent<Animator>();
        if (actor == null) actor = this.GetComponent<Actor>();
    }

    // Update is called once per frame
    void Update() //Fixed
    {
        if (animator != null)
        {
            AnimatorStateInfo stateinfo = animator.GetCurrentAnimatorStateInfo(0);
            //bool triger=stateinfo.IsTag(playStateName);
            float normalizedTime = 0;

            if (!stateinfo.loop) //如果是非循环的动画片段我们需要他抛出（关键帧和结束帧）事件
            {
                normalizedTime = stateinfo.normalizedTime - Mathf.Floor(stateinfo.normalizedTime);
                //Debug.Log(this.name + " name= " +this.playStateName+"  time="+normalizedTime);
                if (normalizedTime >= effectTime && normalizedTime < endEffectTime)
                {
                    if (!didDameage)
                    {
                        didDameage = true;
                        DoEffect();
                    }
                    didEnd = false;
                    noLoopTimes = 0;
                }

                if (normalizedTime > endEffectTime) //播放结束
                {
                    didDameage = false;
                }

                if (Mathf.Floor(stateinfo.normalizedTime) > noLoopTimes)
                {
                    noLoopTimes++;
                }
            }
            else
            {
                if (!didEnd)
                {
                    DoEnd();
                    didEnd = true;
                }
            }
        }
    }

    #endregion

    #region private method

    /// <summary>
    /// 生成动画参数键的hash值
    /// </summary>
    private void GetAimatorHashCode()
    {
        m_speed = Animator.StringToHash("Speed");
    }

    /// <summary>
    /// 执行关键帧触发
    /// </summary>
    private void DoEffect()
    {
        foreach (System.Action<ActorAnimator> act in this.onEffect)
            act(this);
        //System.Action<ActorAnimator>
    }

    /// <summary>
    /// 动画播放结束
    /// </summary>
    private void DoEnd()
    {
        foreach (System.Action<ActorAnimator> act in this.onAnimEnd)
            act(this);
        //Debug.Log(actor.name + "...............DoEnd Animator roleState = " + actor.roleState);
    }

    #endregion

    #region public method

    /// <summary>
    /// 播放一个动画状态
    /// </summary>
    /// <param name="name"></param>
    public void Play(string name, float transitionDuration = 0.4f)
    {
        if (animator != null)
        {
            playStateName = name;
            int hash = Animator.StringToHash(name);
            this.animator.CrossFade(hash, transitionDuration);
            //this.animator.Play(hash);
        }
    }

    /// <summary>
    /// 根据速度播放跑步动画
    /// </summary>
    /// <param name="speed"></param>
    public void Run(float speed)
    {
        if (animator != null)
        {
            if (speed > 0) playStateName = "Run";
            animator.SetFloat(m_speed, speed);
        }
    }

    /// <summary>
    /// 设置播放速度
    /// </summary>
    /// <param name="speed"></param>
    public void SetAnimatorSpeed(float speed)
    {
        animator.speed = speed;
    }

    #endregion

}
