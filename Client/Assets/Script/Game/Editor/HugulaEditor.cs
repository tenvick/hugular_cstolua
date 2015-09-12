// Copyright (c) 2014 hugula
// direct https://github.com/Hugulor/Hugula
//
using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;

/// <summary>
/// 角色创建类
/// </summary>
public static class HugulaEditor
{

    #region pulic static config member
    /// <summary>
    /// 角色阴影路径
    /// </summary>
    public static string ShadowPath = "Assets/CustomerResource/Source/Roles/Shadow/Shadow.prefab";
    /// <summary>
    /// 导出路径
    /// </summary>
    public static string RoleSavePath = "Assets/CustomerResource/Export/Unit/{0}.prefab";

    /// <summary>
    /// 生成的动画controller路径
    /// </summary>
    public static string AnimatorControllerToPath = "Assets/CustomerResource/Source/Roles/AnimatorController/{0}Contr.controller";

    /// <summary>
    /// 目标动画控制器路径
    /// </summary>
    public static string ControllSourcePath = "Assets/CustomerResource/Source/Roles/SourceController/{0}.controller";

    #endregion

    #region 入口方法
    [MenuItem("Assets/Hugula/CreateRole", false, 0)]
    [MenuItem("Hugula/Create/CreateRole", false, 0)]
    static public void CreateRole()
    {
        foreach (Object o in Selection.objects)
        {
            if (o is GameObject)
            {
                string ends = AssetDatabase.GetAssetPath(o).ToLower();
                if (ends.EndsWith("fbx") || ends.EndsWith("prefab"))
                {
                    CreateRole((GameObject)o);
                }
            }
        }
    }

    [MenuItem("Assets/Hugula/CreateBuilding", false, 1)]
    [MenuItem("Hugula/Create/CreateBuilding", false, 1)]
    static public void CreateBuilding()
    {
        foreach (Object o in Selection.objects)
        {
            if (o is GameObject)
            {
                string ends = AssetDatabase.GetAssetPath(o).ToLower();
                if (ends.EndsWith("fbx") || ends.EndsWith("prefab"))
                {
                    CreateBuilding((GameObject)o);
                }
            }
        }
    }
    #endregion


    #region pulic method
    /// <summary>
    /// 从模型创建角色
    /// </summary>
    /// <param name="roleModel"></param>
    static void CreateRole(GameObject roleModel, string sourceController = "RoleController")
    {
        string path1 = AssetDatabase.GetAssetPath(roleModel).ToLower();
        string currPath = path1.Replace(roleModel.name.ToLower() + ".fbx", "").Replace(roleModel.name.ToLower() + ".prefab", "");
        string path = string.Format(RoleSavePath, roleModel.name);//"Assets/Resource/Roles/Prefab/" + roleModel.name + ".prefab";
        string animatorControllerToPath = string.Format(AnimatorControllerToPath, roleModel.name);//"Assets/Resource/Roles/AnimatorController/" + roleModel.name + "Contr.controller";

        GameObject tmp = new GameObject(roleModel.name);
        GameObject clone = (GameObject)GameObject.Instantiate(roleModel);
        clone.name = roleModel.name;
        clone.transform.parent = tmp.transform;

#if UNITY_5 
        UnityEditor.Animations.AnimatorController newContr = CreateAnimatorController(sourceController, roleModel.name);
#else
        AnimatorController newContr = CreateAnimatorController(sourceController, roleModel.name);
#endif
        Animator animator = AddRoleScript(tmp);
        //添加影子
        Object shad = AssetDatabase.LoadMainAssetAtPath(ShadowPath);
        if (shad != null)
        {
            GameObject shadow = (GameObject)GameObject.Instantiate(shad);
            shadow.transform.parent = tmp.transform;
            shadow.name = shad.name;
            Vector3 sshadow = shadow.transform.localScale;

            shadow.transform.localScale = sshadow * 1.5f;
            //clone.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
        //绑定动画控制器
        Dictionary<string, AnimationClip> clips = FindClips(currPath);
        CopyAnimatorController(animator, newContr, clips);
        PrefabUtility.CreatePrefab(path, tmp);
        GameObject.DestroyImmediate(tmp);
        Debug.Log(path + " is created");
    }

    /// <summary>
    /// 创建建筑
    /// </summary>
    /// <param name="obj"></param>
    static void CreateBuilding(GameObject roleModel, string sourceController = "RoleController")
    {
        string path1 = AssetDatabase.GetAssetPath(roleModel).ToLower();
        string currPath = path1.Replace(roleModel.name.ToLower() + ".fbx", "").Replace(roleModel.name.ToLower() + ".prefab", "");
        string path = string.Format(RoleSavePath, roleModel.name);// "Assets/Resource/Roles/Prefab/" + roleModel.name + ".prefab";
        string animatorControllerToPath = string.Format(AnimatorControllerToPath, roleModel.name);//"Assets/Resource/Roles/AnimatorController/" + roleModel.name + "Contr.controller";

        GameObject tmp = new GameObject(roleModel.name);
        GameObject clone = (GameObject)GameObject.Instantiate(roleModel);
        clone.name = roleModel.name;
        clone.transform.parent = tmp.transform;
        Animator animator = AddBuildingScript(tmp);
#if UNITY_5 
        UnityEditor.Animations.AnimatorController newContr = CreateAnimatorController(sourceController, roleModel.name);
#else
        AnimatorController newContr = CreateAnimatorController(sourceController, roleModel.name);
#endif
        //绑定动画控制器
        Dictionary<string, AnimationClip> clips = FindClips(currPath);
        CopyAnimatorController(animator, newContr, clips);
        PrefabUtility.CreatePrefab(path, tmp);
        GameObject.DestroyImmediate(tmp);
        Debug.Log(path + " is created");
    }

    #endregion

    #region private method
    /// <summary>
    /// 添加角色角本
    /// </summary>
    /// <param name="role"></param>
    static Animator AddRoleScript(GameObject role)
    {
        BoxCollider collider = AddComponent<BoxCollider>(role);
        Animator animator = role.GetComponentInChildren<Animator>();
        NavMeshAgent navMeshAgent = AddComponent<NavMeshAgent>(role);

        Actor roleAc = AddComponent<Actor>(role);
        ActorAnimator roleAnimator = AddComponent<ActorAnimator>(role);
        //RoleSlider roleSlider = AddComponent<RoleSlider>(role);

        //UISlider hpSlider = role.GetComponentInChildren<UISlider>();

        //
        List<GameObject> pos = CreateHeadAndArm(role);
        if (pos.Count >= 1) roleAc.head = pos[0].transform;
        if (pos.Count >= 2) roleAc.arm = pos[1].transform;

        collider.size = new Vector3(1.5f, 1.5f, 1.5f);
        Vector3 size = collider.size;
        Vector3 center = new Vector3(0, size.y / 2, 0);
        collider.center = center;
        navMeshAgent.radius = 0.4f;

        roleAc.navMeshAgent = navMeshAgent;
        roleAc.actorAnimator = roleAnimator;
        //roleAc.roleSlider = roleSlider;

        roleAnimator.actor = roleAc;
        roleAnimator.animator = animator;
        animator.applyRootMotion = false;

        //roleSlider.actor = roleAc;
        //if (hpSlider != null)
        //{
        //    //roleSlider.hpSlider.Add(hpSlider);
        //}

        return animator;
    }

    /// <summary>
    /// 建筑物
    /// </summary>
    /// <param name="role"></param>
    static Animator AddBuildingScript(GameObject role)
    {
        BoxCollider collider = AddComponent<BoxCollider>(role);
        Animator animator = AddComponent<Animator>(role);
        NavMeshObstacle obs = AddComponent<NavMeshObstacle>(role);
        ActorAnimator roleAnimator = AddComponent<ActorAnimator>(role);

        Actor roleAc = AddComponent<Actor>(role);
        //RoleSlider roleSlider = AddComponent<RoleSlider>(role);
        //UISlider hpSlider = role.GetComponentInChildren<UISlider>();

        List<GameObject> pos = CreateHeadAndArm(role);
        if (pos.Count >= 1) roleAc.head = pos[0].transform;
        if (pos.Count >= 2) roleAc.arm = pos[1].transform;

        roleAnimator.animator = animator;
        animator.applyRootMotion = false;
        //roleAc.roleSlider = roleSlider;
        //roleSlider.actor = roleAc;
        //if (hpSlider != null)
        //{
        //    roleSlider.hpSlider.Add(hpSlider);
        //}
        return animator;
    }

    /// <summary>
    /// 创建头和胸部
    /// </summary>
    /// <param name="model"></param>
    static List<GameObject> CreateHeadAndArm(GameObject model)
    {
        List<GameObject> re = new List<GameObject>();
        SkinnedMeshRenderer[] meshs = model.GetComponentsInChildren<SkinnedMeshRenderer>();
        float maxy = 0;
        Vector3 lossyScale;
        foreach (var sm in meshs)
        {
            lossyScale = sm.transform.lossyScale;
            var bounds = sm.bounds;
            var meshSize = bounds.size;
            var ry = meshSize.y;// -bounds.center.x;// *lossyScale.y;
            //UnityEngine.Debug.Log(bounds.center);
            //UnityEngine.Debug.Log(bounds.extents);
            //UnityEngine.Debug.Log(meshSize);
            if (maxy < ry) maxy = ry;
        }

        MeshRenderer[] mRenders = model.GetComponentsInChildren<MeshRenderer>();
        //UnityEngine.Debug.Log(meshs.Length);
        //UnityEngine.Debug.Log(mRenders.Length);

        foreach (var sm in mRenders)
        {
            lossyScale = sm.transform.lossyScale;
            var bounds = sm.bounds;
            var meshSize = bounds.size;
            var ry = meshSize.y;// -bounds.center.x;// *lossyScale.y;
            if (maxy < ry) maxy = ry;
        }

        var hed = new GameObject("Head");
        hed.transform.parent = model.transform;
        hed.transform.localPosition = new Vector3(0, maxy, 0);
        re.Add(hed);

        var arm = new GameObject("Arm");
        arm.transform.parent = model.transform;
        arm.transform.localPosition = new Vector3(0, maxy * 0.55f, 0);
        re.Add(arm);

        return re;

    }

    /// <summary>
    /// 寻找当前目录下面的所有clips
    /// </summary>
    /// <param name="currPath"></param>
    /// <returns></returns>
    static Dictionary<string, AnimationClip> FindClips(string currPath)
    {
        List<string> allFBX = ExportResources.getAllChildFiles(currPath, "fbx");
        Dictionary<string, AnimationClip> clips = new Dictionary<string, AnimationClip>();
        foreach (string file in allFBX)
        {
            Object[] all = AssetDatabase.LoadAllAssetsAtPath(file);
            foreach (Object o in all)
            {
                if (o is AnimationClip)
                {
                    clips[o.name] = o as AnimationClip;
                    //if (o.name.ToLower().StartsWith("idle") || o.name.ToLower().StartsWith("run"))
                    //{
                    //    clips[o.name].l
                    //}
                }
            }
        }

        return clips;
    }

#if UNITY_5

    /// <summary>
    /// 拷贝动画剪辑到新的动画控制器
    /// </summary>
    /// <param name="animator"></param>
    /// <param name="newContr"></param>
    /// <param name="clips"></param>
    static void CopyAnimatorController(Animator animator, UnityEditor.Animations.AnimatorController newContr, Dictionary<string, AnimationClip> clips)
    {

        UnityEditor.Animations.AnimatorControllerLayer lay = newContr.layers[0];
        UnityEditor.Animations.AnimatorStateMachine sm = lay.stateMachine;
        int count = sm.stateMachines.Length;
        count = sm.states.Length;
        for (int i = 0; i < count; i++)
        {
            UnityEditor.Animations.ChildAnimatorState s1 = sm.states[i];
            Motion m = s1.state.motion;
            if (m is UnityEditor.Animations.BlendTree)
            {
                UnityEditor.Animations.BlendTree m1 = m as UnityEditor.Animations.BlendTree;
                for (int j = 0; j < m1.children.Length; j++)
                {
                    var child = m1.children[j];
                    Motion m2 = child.motion;
                    AnimationClip cu = null;
                    if (clips.ContainsKey(m2.name)) cu = clips[m2.name];
                    child.motion = cu;
                }
            }
            else
            {
                AnimationClip cu = null;
                if (clips.ContainsKey(m.name))
                {
                    cu = clips[m.name];
                    s1.state.motion = cu;
                }
            }
        }
            UnityEditor.Animations.AnimatorController.SetAnimatorController(animator, newContr);
    }

       /// <summary>
    /// 创建动画控制器
    /// </summary>
    /// <param name="contorllName"></param>
    /// <returns></returns>
    static UnityEditor.Animations.AnimatorController CreateAnimatorController(string source, string target)
    {
        //Animator a;
        string controllSourcePath = string.Format(ControllSourcePath, source); // "Assets/Resource/AnimatorController/" + source + ".controller";
        string toPath = string.Format(AnimatorControllerToPath, target); //"Assets/Resource/Roles/AnimatorController/" + target + "Contr.controller";
        AssetDatabase.DeleteAsset(toPath);
        AssetDatabase.CopyAsset(controllSourcePath, toPath);
        AssetDatabase.Refresh();
        UnityEditor.Animations.AnimatorController copy = (UnityEditor.Animations.AnimatorController)AssetDatabase.LoadMainAssetAtPath(toPath);
        return copy;
    }
#else

    /// <summary>
    /// 创建动画控制器
    /// </summary>
    /// <param name="contorllName"></param>
    /// <returns></returns>
    static AnimatorController CreateAnimatorController(string source, string target)
    {
        //Animator a;
        string controllSourcePath = string.Format(ControllSourcePath, source); // "Assets/Resource/AnimatorController/" + source + ".controller";
        string toPath = string.Format(AnimatorControllerToPath, target); //"Assets/Resource/Roles/AnimatorController/" + target + "Contr.controller";
        AssetDatabase.DeleteAsset(toPath);
        AssetDatabase.CopyAsset(controllSourcePath, toPath);
        AssetDatabase.Refresh();
        AnimatorController copy = (AnimatorController)AssetDatabase.LoadMainAssetAtPath(toPath);
        return copy;
    }

    /// <summary>
    /// 拷贝动画剪辑到新的动画控制器
    /// </summary>
    /// <param name="animator"></param>
    /// <param name="newContr"></param>
    /// <param name="clips"></param>
    static void CopyAnimatorController(Animator animator, AnimatorController newContr, Dictionary<string, AnimationClip> clips)
    {
        AnimatorController.SetAnimatorController(animator, newContr);
        AnimatorControllerLayer lay = newContr.GetLayer(0);

        StateMachine sm = lay.stateMachine;

        int count = sm.stateMachineCount;

        count = sm.stateCount;
        for (int i = 0; i < count; i++)
        {
            State s1 = sm.GetState(i);

            Motion m = s1.GetMotion();
            if (m is BlendTree)
            {
                BlendTree m1 = m as BlendTree;
                int c = m1.childCount;
                for (int j = 0; j < c; j++)
                {
                    Motion m2 = m1.GetMotion(j);
                    AnimationClip cu = null;

                    if (clips.ContainsKey(m2.name)) cu = clips[m2.name];

                    float Threshold = m1.GetChildThreshold(0);
                    float TimeScale = m1.GetChildTimeScale(0);
                    m1.RemoveChild(0);
                    m1.AddAnimationClip(cu);
                    m1.SetChildThreshold(m1.childCount - 1, Threshold);
                    m1.SetChildTimeScale(m1.childCount - 1, TimeScale);
                }
            }
            else
            {
                AnimationClip cu = null;
                if (clips.ContainsKey(m.name))
                {
                    cu = clips[m.name];
                    s1.SetAnimationClip(cu, lay);
                }
            }
        }
    }
#endif

    /// <summary>
    /// 判断添加组件
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="go"></param>
    /// <returns></returns>
    static public T AddComponent<T>(this GameObject go) where T : Component
    {
        T comp = go.GetComponent<T>();
        if (comp == null)
        {
            comp = go.AddComponent<T>();
        }
        return comp;
    }

    #endregion
}
