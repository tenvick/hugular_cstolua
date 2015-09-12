// Copyright (c) 2014 hugula
// actor Property customer data class
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections;

/// <summary>
/// actor的属性
/// 可以自己根据需求修改
/// </summary>
public class Property
{
    /// <summary>
    /// 类型
    /// 1 普通单位
    /// 2 建筑单位
    /// 3 物品单位
    /// </summary>
    public int type = 1;

    /// <summary>
    /// 单位类别
    /// 0未指定
    /// 1 地面
    /// 2 空中
    /// 3 基地
    /// </summary>
    public int categroy = 0;

    /// <summary>
    /// teamId
    /// </summary>
    public int team = 0;

    /// <summary>
    /// 角色ID
    /// </summary>
    public int id;

    /// <summary>
    /// 等级
    /// </summary>
    public int level;

    #region 基础属性

    #region 基础属性

    /// <summary>
    /// 基础最大血量
    /// </summary>
    private int _maxHp = 10;

    /// <summary>
    /// 基础最大魔力值
    /// </summary>
    private int _maxMp = 10;

    /// <summary>
    /// 基础当前血量
    /// </summary>
    private int _hp = 1;

    /// <summary>
    /// 基础当前魔力值
    /// </summary>
    private int _mp = 1;

    /// <summary>
    /// 基础伤害值
    /// </summary>
    private int _damage = 1;
    /// <summary>
    /// 基础防御值
    /// </summary>
    private int _defend = 1;

    /// <summary>
    /// 基础魔力伤害
    /// </summary>
    private int _magicDamage = 1;
    /// <summary>
    /// 基础魔力防御
    /// </summary>
    private int _magicDefend = 1;

    /// <summary>
    /// 基础暴击值
    /// </summary>
    private int _critValue = 1;

    /// <summary>
    /// 基础闪避值
    /// </summary>
    private int _dodgeValue = 1;

    /// <summary>
    /// 基础移动速度
    /// </summary>
    private float _speed = 6;

    /// <summary>
    /// 基础转身速度
    /// </summary>
    private float _turnSpeed = 120;

    /// <summary>
    /// 基础攻击速度
    /// </summary>
    private float _attackSpeed = 1.0f;

    #endregion

    #region 增益属性
    /// <summary>
    /// 增益血量
    /// </summary>
    public int p_maxHp = 0;

    /// <summary>
    /// 增益魔力值
    /// </summary>
    public int p_maxMp = 0;

    ///// <summary>
    ///// 增益血量
    ///// </summary>
    //private int __hp = 0;

    ///// <summary>
    ///// 增益魔力值
    ///// </summary>
    //private int __mp = 0;

    /// <summary>
    /// 增益伤害值
    /// </summary>
    public int p_damage = 0;
    /// <summary>
    /// 增益防御值
    /// </summary>
    public int p_defend = 0;

    /// <summary>
    /// 增益魔力伤害
    /// </summary>
    public int p_magicDamage = 0;
    /// <summary>
    /// 增益魔力防御
    /// </summary>
    public int p_magicDefend = 0;

    /// <summary>
    /// 增益暴击值
    /// </summary>
    public int p_critValue = 0;

    /// <summary>
    /// 增益闪避值
    /// </summary>
    public int p_dodgeValue = 0;

    /// <summary>
    /// 增益移动速度
    /// </summary>
    private float p_speed = 0;

    /// <summary>
    /// 增益转身速度
    /// </summary>
    public float p_turnSpeed = 0;

    /// <summary>
    /// 增益攻击速度
    /// </summary>
    public float p_attackSpeed = 0;
    #endregion

    /// <summary>
    /// 最大血量
    /// </summary>
    public int maxHp
    {
        get { return this._maxHp + this.p_maxHp; }
    }

    /// <summary>
    /// 最大魔力值
    /// </summary>
    public int maxMp
    {
        get { return this._maxMp + this.p_maxMp; }
    }

    /// <summary>
    /// 当前血量
    /// </summary>
    public int hp
    {
        get { return this._hp; } // + this.__hp;
    }

    /// <summary>
    /// 当前魔力值
    /// </summary>
    public int mp
    {
        get { return this._mp; } //+ this.__mp;
    }

    /// <summary>
    /// 伤害值
    /// </summary>
    public int damage
    {
        get { return this._damage + this.p_damage; }
    }

    /// <summary>
    /// 防御值
    /// </summary>
    public int defend
    {
        get { return this._defend + this.p_defend; }
    }

    /// <summary>
    /// 魔力伤害
    /// </summary>
    public int magicDamage
    {
        get { return this._magicDamage + this.p_magicDamage; }
    }

    /// <summary>
    /// 魔力防御
    /// </summary>
    public int magicDefend
    {
        get { return this._magicDefend + this.p_magicDefend; }
    }

    /// <summary>
    /// 暴击值
    /// </summary>
    public int critValue
    {
        get { return this._critValue + this.p_critValue; }
    }

    /// <summary>
    /// 闪避值
    /// </summary>
    public int dodgeValue
    {
        get { return this._dodgeValue + this.p_dodgeValue; }
    }

    /// <summary>
    /// 移动速度
    /// </summary>
    public float speed
    {
        get { return this._speed + this.p_speed; }
    }

    /// <summary>
    /// 转身速度
    /// </summary>
    public float turnSpeed
    {
        get { return this._turnSpeed + this.p_turnSpeed; }
    }

    /// <summary>
    /// 攻击速度
    /// </summary>
    public float attackSpeed
    {
        get { return this._attackSpeed + this.p_attackSpeed; }
    }

    /// <summary>
    /// 可视范围
    /// </summary>
    public float rangeVisible
    {
        get { return this._rangeVisible + this.__rangeVisible; }
    }

    /// <summary>
    /// 基础可视范围
    /// </summary>
    public float _rangeVisible = 10;

    /// <summary>
    /// 增益可视范围
    /// </summary>
    public float __rangeVisible = 0;

    /// <summary>
    /// lua配置信息
    /// </summary>
    public object data;

    #endregion

    /// <summary>
    /// 设置基础属性
    /// </summary>
    public void SetBaseProperty(int hp, int mp, int maxHp, int maxMp, int damage, int defend, int magicDamage, int magicDefend, int critValue, int dodgeValue, float speed, float attackSpeed, float rangeVisible, float turnSpeed = 240)
    {
        this._hp = hp;
        this._mp = mp;
        this._maxHp = maxHp;
        this._maxMp = maxMp;
        this._damage = damage;
        this._magicDamage = magicDamage;
        this._magicDefend = magicDefend;
        this._defend = defend;
        this._critValue = critValue;
        this._dodgeValue = dodgeValue;
        this._speed = speed;
        this._turnSpeed = turnSpeed;
        this._attackSpeed = attackSpeed;
        this._rangeVisible = rangeVisible;
    }

    /// <summary>
    /// 设置类型属性
    /// </summary>
    /// <param name="type"></param>
    /// <param name="categroy"></param>
    public void SetCateProperty(int type, int categroy)
    {
        this.type = type;
        this.categroy = categroy;
    }

    /// <summary>
    /// 设置可变属性
    /// </summary>
    /// <param name="id"></param>
    /// <param name="level"></param>
    /// <param name="team"></param>
    public void SetLevelProperty(int id, int level)
    {
        this.id = id;
        this.level = level;
    }

    /// <summary>
    /// 设置最大HP和MP
    /// </summary>
    /// <param name="maxHp"></param>
    /// <param name="maxMp"></param>
    public void SetBaseMax(int maxHp, int maxMp)
    {
        this._maxHp = maxHp;
        this._maxMp = maxMp;
    }

    public int AddHp(int add)
    {
        int added = 0;
        int ne = hp + add;
        if (ne > maxHp)
        {
            added = add - (ne - maxHp);
            _hp = maxHp;
        }
        else
        {
            added = add;
            _hp = ne;
        }
        return added;
    }

    public int RemoveHp(int sub)
    {
        int removeed = 0;
        int re = hp - sub;
        if (re < 0)
        {
            removeed = hp;
            _hp = 0;
        }
        else
        {
            _hp = re;
            removeed = sub;
        }
        return removeed;
    }

    public int AddMp(int add)
    {
        int added = 0;
        int ne = mp + add;
        if (ne > maxMp)
        {
            added = add - (ne - maxMp);
            _mp = maxMp;
        }
        else
        {
            _mp = ne;
            added = add;
        }
        return added;
    }

    public int RemoveMp(int sub)
    {
        int removeed = 0;
        int re = mp - sub;
        if (re < 0)
        {
            removeed = mp;
            _mp = 0;
        }
        else
        {
            removeed = sub;
            _mp = re;
        }
        return removeed;
    }

    ///// <summary>
    ///// 从目标COPY值
    ///// </summary>
    ///// <param name="rolePro"></param>
    //public void CopySimpleFrom(Property rolePro)
    //{
    //    type = rolePro.type;

    //    _speed = rolePro.speed;
    //    _turnSpeed = rolePro.turnSpeed;

    //    _attackSpeed = rolePro.attackSpeed;
    //    _rangeVisible = rolePro.rangeVisible;

    //    team = rolePro.team;
    //}

}

