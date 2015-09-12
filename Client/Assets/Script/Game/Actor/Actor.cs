// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections;

/// <summary>
/// 行动者
/// </summary>
public class Actor : MonoBehaviour
{

    #region pulic member

    #region 角色位置信息

    /// <summary>
    /// 头部位置
    /// </summary>
    public Transform head;

    /// <summary>
    /// 手臂位置
    /// </summary>
    public Transform arm;

    #endregion

    #region 特殊buff状态
    /// <summary>
    /// 沉默 不能释放技能
    /// </summary>
    [HideInInspector]
    public bool silence;

    /// <summary>
    /// 睡眠 不能行动
    /// </summary>
    [HideInInspector]
    public bool sleep;

    /// <summary>
    /// 魔法免疫
    /// </summary>
    [HideInInspector]
    public bool spellImmunity;

    /// <summary>
    /// 物理免疫
    /// </summary>
    [HideInInspector]
    public bool physicalImmunity;

    /// <summary>
    /// 移动
    /// </summary>
    [HideInInspector]
    public bool movability;

    #endregion

    #region 角色组件

    /// <summary>
    /// 动画控制器脚本
    /// </summary>
    public ActorAnimator actorAnimator;

    /// <summary>
    /// nav mesh agent 寻路组件
    /// </summary>
    public NavMeshAgent navMeshAgent;

    /// <summary>
    /// 角色技能
    /// </summary>
    public Ability ability;

    /// <summary>
    /// actor 属性
    /// </summary>
    public Property property;

    #endregion

    #region 行为相关

    public BTInput input { private set; get; }

    public BTOutput output { private set; get; }

    /// <summary>
    /// 大脑
    /// </summary>
    private Brain _brain;

    /// <summary>
    /// 大脑
    /// </summary>
    public Brain brain
    {
        get { return _brain; }
        set
        {
            _brain = value;
            if (_brain != null)
            {
                this._brain.actor = this;
                this._brain.Start();
            }
        }
    }
    #endregion

    /// <summary>
    /// 用户缓存数据
    /// </summary>
    public object userObject;

    /// <summary>
    /// 用户缓存数据
    /// </summary>
    public object userObject1;

    #endregion

    #region private member
    /// <summary>
    /// 是否醒着
    /// </summary>
    private bool _awake = true;
    #endregion

    #region mono

    void Awake()
    {
        this.input = new BTInput(this);
        this.output = new BTOutput(this);
    }


    // Use this for initialization
    void Start()
    {
        if (actorAnimator == null) actorAnimator = this.GetComponent<ActorAnimator>();
        if (navMeshAgent == null) navMeshAgent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_awake)
        {
            if (brain != null)
                brain.OnUpdate();
        }
    }

    void LateUpdate()
    {

    }

    void OnDisable()
    {

    }

    #endregion

    #region pulic method

    /// <summary>
    /// 停止主循环
    /// </summary>
    public void Stop()
    {
        _awake = false;
    }

    /// <summary>
    /// 开始主循环
    /// </summary>
    public void Begin()
    {
        _awake = true;
    }
    /// <summary>
    /// 触发type类型buff一次
    /// </summary>
    /// <param name="type"></param>
    public void DispatchBuffType(int type, object args)
    {
        //Debug.Log(string.Format("DispatchBuffType type={0} , args ={1}",type,args));
        //buff.Dispatch(type, args);
    }

    /// <summary>
    /// 触发大脑事件
    /// </summary>
    /// <param name="type"> 事件类型</param>
    /// <param name="arg">参数</param>
    public void DispatchBrainEvent(int type, object arg)
    {
        if (brain != null)
        {
            brain.DispatchEvent(type, arg);
        }
    }

    #endregion

    #region private method

    #endregion
}
