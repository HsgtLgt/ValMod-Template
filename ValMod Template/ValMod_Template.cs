using BepInEx;
using HarmonyLib;

namespace ValMod_Template
{
    // 这一行用于声明这是一个 BepInEx 插件，并指定了模组的 GUID、名称和版本号
    [BepInPlugin(mod_GUID, mod_NAME, mod_VERSION)]
    public class ValMod_Template : BaseUnityPlugin
    {
        internal const string mod_GUID = "mod_GUID"; // 插件 GUID （唯一标识符，只能由字母、数字和下划线组成）
        internal const string mod_NAME = "插件名称"; // 插件名称
        internal const string mod_VERSION = "0.0.1"; // 插件版本
        internal readonly Harmony harmony = new(mod_GUID);

        // 在对象被创建时立即调用。在游戏开始之前，对象已经初始化完成。它只会被调用一次。
        public void Awake()
        {
            Logger.LogInfo($"初始化 插件 {mod_GUID} ");

            // 所有 harmony 插件补丁加载
            harmony.PatchAll();
        }

        // 每一帧都会调用。用于处理每帧的游戏逻辑和交互。
        public void Update() { }

        // 当对象被销毁时调用。这可以是在场景切换时或者手动调用Destroy()方法
        public void OnDestroy() { } 


    }
}
