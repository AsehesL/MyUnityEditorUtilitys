using UnityEngine;
using System.Collections;
using UnityEditor;

public static class LuaCreateUtils
{

    [MenuItem("Assets/Create/Lua/MyLua.lua")]
    static void CreateMyLua()
    {
        ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Lua\MyLua.lua.txt", "New MyLua.lua");
    }

}
