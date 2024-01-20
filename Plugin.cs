using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
namespace mindcontrol
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private ConfigEntry<string> enemytocontrol;
        private void Awake()
        {
         enemytocontrol = Config.Bind("ULTRAKILL Mindcontrol Mod",      // The section under which the option is shown
                                      "enemytocontrol",  // The key of the configuration option in the configuration file
                                      "", // The default value
                                      "enemy to control, i recommend using unity explorer to check the enemy's gameobject name"); // Description of the option to show in the config file
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
        private void Update()
        {
            if (GameObject.Find(enemytocontrol.Value))
            {   if (GameObject.Find(enemytocontrol.Value + "/GroundCheck")) {
                Destroy(GameObject.Find(enemytocontrol.Value + "/GroundCheck"));
            }
                if (GameObject.Find(enemytocontrol.Value).GetComponent<UnityEngine.CapsuleCollider>()) {
                    Destroy(GameObject.Find(enemytocontrol.Value).GetComponent<UnityEngine.CapsuleCollider>());
                }
                GameObject.Find(enemytocontrol.Value).transform.position = GameObject.Find("Player").transform.position;
            }
        }
    }
}
