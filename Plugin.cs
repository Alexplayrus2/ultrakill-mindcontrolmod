using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
namespace mindcontrol
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private ConfigEntry<string> enemytocontrol;
        public int ind = 0;
        private void Awake()
        {
         enemytocontrol = Config.Bind("ULTRAKILL Mindcontrol Mod",      // The section under which the option is shown
                                      "enemytocontrol",  // The key of the configuration option in the configuration file
                                      "", // The default value
                                      "the enemy to control, resets on game start and when n is pressed"); // Description of the option to show in the config file
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        enemytocontrol.Value = "";
        }
        private void Update()
        {
        var count = GameObject.Find("Debug Gore Zone").transform.childCount - 1;
        if (Input.GetKeyDown("m"))
        {
            if (ind <= count) {
                Destroy(GameObject.Find("Debug Gore Zone/Gore Zone"));
                Destroy(GameObject.Find("Debug Gore Zone/Gib Zone"));
                enemytocontrol.Value = "Debug Gore Zone/" + GameObject.Find("Debug Gore Zone").transform.GetChild(ind).name;
                ind = ind + 1;
            }
            if (ind > count) {
                ind = 0;
                enemytocontrol.Value = "Debug Gore Zone/" + GameObject.Find("Debug Gore Zone").transform.GetChild(ind).name;
            }
        }
                if (Input.GetKeyDown("n"))
        {
            enemytocontrol.Value = "";
        }
            if (GameObject.Find(enemytocontrol.Value))
            {   if (GameObject.Find(enemytocontrol.Value + "/GroundCheck")) {
                Destroy(GameObject.Find(enemytocontrol.Value + "/GroundCheck"));
            }
                if (GameObject.Find(enemytocontrol.Value).GetComponent<UnityEngine.CapsuleCollider>()) {
                    Destroy(GameObject.Find(enemytocontrol.Value).GetComponent<UnityEngine.CapsuleCollider>());
                }
                if (GameObject.Find(enemytocontrol.Value).GetComponent<EnemyIdentifier>()) {
                int hplol = (int)GameObject.Find(enemytocontrol.Value).GetComponent<EnemyIdentifier>().health;
                GameObject.Find("Player").GetComponent<NewMovement>().hp = hplol;
                GameObject.Find(enemytocontrol.Value).GetComponent<EnemyIdentifier>().ignorePlayer = true;
                GameObject.Find(enemytocontrol.Value).GetComponent<EnemyIdentifier>().attackEnemies = true;
                }
                GameObject.Find(enemytocontrol.Value).transform.position = GameObject.Find("Player").transform.position;
                Destroy(GameObject.Find("Player/Main Camera/Guns"));
                Destroy(GameObject.Find("Player/Main Camera/Punch"));
                Camera.main.transform.position = GameObject.Find("Player").transform.position + new Vector3(0,7,-7);
            }
        }
    }
}
