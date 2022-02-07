using UnityEditor;
using UnityEngine;

namespace PetPumpkin
{
    public static class EditorTools
    {
        [MenuItem("Tools/Setup/Open Script Template Directory")]
        public static void OpenScriptTemplateDirectory(){
            System.Diagnostics.Process.Start("explorer.exe", "/select,"+"C:\\Program Files\\Unity\\Hub\\Editor\\"+Application.unityVersion+"\\Editor\\Data\\Resources\\ScriptTemplates\\");
        }
    }
}
