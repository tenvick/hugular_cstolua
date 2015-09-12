using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;


public class AssetbundlesMenuItems  {

    [MenuItem("Assets/AssetBundles/Build AssetBundles", false, 2)]
    [MenuItem("AssetBundles/Build AssetBundles", false, 2)]
    static public void BuildAssetBundles()
    {
        BuildScript.BuildAssetBundles();
    }


    [MenuItem("Assets/AssetBundles/Set AssetBundle Name", false, 1)]
    static public void SetAssetBundlesName()
    {
        Object[] selection = Selection.objects;

        AssetImporter import = null;
        foreach (Object s in selection)
        {
            import = AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(s));
            import.assetBundleName = s.name+"."+Common.ASSETBUNDLE_SUFFIX;
            Debug.Log(import.name);
        }
    }

}
