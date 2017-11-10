using UnityEngine;
using System.Collections;
using UnityEditor;

public static class LuaCreateUtils
{

    [MenuItem("Assets/Create/Lua/MyLua.lua")]
    static void CreateShader0000()
    {
        ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Lua\MyLua.lua.txt", "New MyLua.lua");
    }

}
