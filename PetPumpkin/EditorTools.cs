using UnityEditor;
using UnityEngine;

namespace PetPumpkin
{
    public static class EditorTools
    {
        [MenuItem("Tools/Setup/Open Script Template Directory")]
        public static void OpenScriptTemplateDirectory(){
            System.Diagnostics.Process.Start("explorer.exe", "/select,"+"C:\\Program Files\\Unity\\Hub\\Editor\\"+Application.unityVersion+"\\Editor\\Data\\Resources\\ScriptTemplates\\");
            Application.OpenURL("https://github.com/PetPumpkin/Unity-Tools/blob/9c73a0fa517a997990b972177365957aee6b1a9c/PetPumpkin/Setup/new_script_template.txt");
        }
        
        [MenuItem("Tools/Setup/Override Package Manifest")]
        public static void OverridePackageManifest(){
            // System.Diagnostics.Process.Start("explorer.exe", "/select,"+"C:\\Program Files\\Unity\\Hub\\Editor\\"+Application.unityVersion+"\\Editor\\Data\\Resources\\ScriptTemplates\\");
        }
    }
}
