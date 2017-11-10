using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


public class ScriptTemplateGenerator
{
    /// <summary>
    /// 生成shader模板脚本：ShaderCreateUtils.cs
    /// </summary>
    [MenuItem("Assets/Create/Shader/Generate Templete", false, 2)]
    static void GenerateShaderTemplete()
    {
        string path = EditorUtility.OpenFolderPanel("选择Shader模板文件位置", "", "");
        if (string.IsNullOrEmpty(path))
            return;

        DirectoryInfo dir = new DirectoryInfo(path);
        if (!dir.Exists)
            return;
        FileInfo[] files = dir.GetFiles("*.shader", SearchOption.AllDirectories);
        if (files.Length == 0)
            return;

        FileStream templeteStream = new FileStream("Assets/Editor/ScriptsTemplate/ShaderCreateUtils.cs", FileMode.Create, FileAccess.Write);
        StreamWriter templeteWriter = new StreamWriter(templeteStream, Encoding.UTF8);

        templeteWriter.WriteLine("using UnityEngine;");
        templeteWriter.WriteLine("using UnityEditor;");
        templeteWriter.WriteLine("using System.Collections;");
        templeteWriter.WriteLine(" ");

        templeteWriter.WriteLine("/// <summary>");
        templeteWriter.WriteLine("/// 通过方法\"ScriptTemplateGenerator.GenerateShaderTemplete()\"自动生成，不要修改该脚本内容");
        templeteWriter.WriteLine("/// </summary>");
        templeteWriter.WriteLine("public class ShaderCreateUtils");
        templeteWriter.WriteLine("{");

        for (int i = 0; i < files.Length; i++)
        {
            string contents = File.ReadAllText(files[i].FullName);
            Regex reg = new Regex("Shader \"(.+)\"");
            string shaderName = "";
            contents = reg.Replace(contents, m =>
            {
                if (m.Groups.Count == 2)
                {
                    shaderName = m.Groups[1].Value;
                    int sindex = shaderName.LastIndexOf('/');
                    if (sindex >= 0 && sindex < shaderName.Length - 1)
                    {
                        string lastName = shaderName.Substring(sindex + 1);
                        string replaceName = shaderName.Replace(lastName, "#NAME#");
                        return m.Groups[0].Value.Replace(m.Groups[1].Value, replaceName);
                    }
                    else
                    {
                        string rp = m.Groups[0].Value.Replace(m.Groups[1].Value, "#NAME#");
                        return rp;
                    }
                }
                return m.Groups[0].Value;
            });
            string shaderPath = files[i].FullName.Replace(dir.FullName, "");
            shaderPath = @"Templates\Shaders" + shaderPath + ".txt";
            FileInfo shaderfile = new FileInfo(shaderPath);
            if (shaderfile.Directory.Exists == false)
                shaderfile.Directory.Create();
            File.WriteAllText(shaderfile.FullName, contents);

            templeteWriter.WriteLine("\n");
            templeteWriter.WriteLine("\t[MenuItem(\"Assets/Create/Shader/" + shaderName + "\")]");//创建[MenuItem]特性
            templeteWriter.WriteLine("\tstatic void CreateShader"+i.ToString("d4")+"()");//创建[MenuItem]特性
            templeteWriter.WriteLine("\t{");
            templeteWriter.WriteLine("\t\tProjectWindowUtilEx.CreateScriptUtil(@\""+ shaderPath + "\",\"New "+files[i].Name+"\");");
            templeteWriter.WriteLine("\t}");
        }

        templeteWriter.WriteLine("}");
        templeteWriter.Close();
        templeteStream.Close();

        AssetDatabase.Refresh();
    }
}