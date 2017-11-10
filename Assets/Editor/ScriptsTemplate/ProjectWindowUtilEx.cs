using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEditor;

public static class ProjectWindowUtilEx {

    public static void CreateScriptUtil(string templete, string path)
    {
        MethodInfo method = typeof(ProjectWindowUtil).GetMethod("CreateScriptAsset",
            BindingFlags.Static | BindingFlags.NonPublic);
        if (method != null)
            method.Invoke(null, new object[] { templete, path });
    }
}
