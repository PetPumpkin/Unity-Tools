using UnityEditor;
using UnityEngine;
using System;
using System.Net.Http;

namespace PetPumpkin
{
    public static class EditorTools
    {
        static string scriptTemplateURL = "https://github.com/PetPumpkin/Unity-Tools/blob/c3a1079637cb9fc746ff8f9dabcb85fbe78869b6/Pet%20Pumpkin%20Tools/Setup/new_script_template.txt";
        
        [MenuItem("Tools/Setup/Open Script Template Directory")]
        public static void OpenScriptTemplateDirectory(){
            System.Diagnostics.Process.Start("explorer.exe", "/select,"+"C:\\Program Files\\Unity\\Hub\\Editor\\"+Application.unityVersion+"\\Editor\\Data\\Resources\\ScriptTemplates\\");
            Application.OpenURL(scriptTemplateURL);
        }
    }

    public static class Packages {
 
        static string manfistGistURL = "https://raw.githubusercontent.com/PetPumpkin/Unity-Tools/main/Pet%20Pumpkin%20Tools/Setup/manifest.json";

        [MenuItem("Tools/Setup/Override Package Manifest")]
        public static async void OverridePackageManifest(){
            var contents = await GetContentsFromURL(manfistGistURL);
            var existing = System.IO.Path.Combine(Application.dataPath, "../Packages/manifest.json");
            System.IO.File.WriteAllText(existing, contents);
            UnityEditor.PackageManager.Client.Resolve();
        }

        public static async System.Threading.Tasks.Task<string> GetContentsFromURL(string url){
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
