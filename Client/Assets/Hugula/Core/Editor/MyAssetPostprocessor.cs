using UnityEngine;
using UnityEditor;

public class MyPostprocessor : AssetPostprocessor
{
    void OnPostprocessAssetbundleNameChanged(string path,
            string previous, string next)
    {
        Debug.Log("AB: " + path + " old: " + previous + " new: " + next);
    }

}