# Libs文件夹使用说明

## 重要提示
本文件夹默认应为空。所有依赖项需要您从游戏安装目录手动添加，以确保版本兼容性。

## 完整引用库文件列表
1. **BepInEx核心库** (位于`BepInEx\core`文件夹):
   - BepInEx.dll - BepInEx插件框架核心
   - 0Harmony.dll - Harmony补丁库，用于方法修改

2. **Valheim游戏库** (位于`valheim_Data\Managed`文件夹):
   - assembly_valheim.dll - Valheim游戏主逻辑库
   - assembly_utils.dll - 游戏工具和辅助功能库
   - UnityEngine.dll - Unity引擎核心功能
   - UnityEngine.CoreModule.dll - Unity核心模块
   - assembly_guiutils.dll - Unity GUI工具库
   - assembly_steamworks.dll - Steam平台集成库

## 添加依赖项步骤
1. 安装BepInEx到您的Valheim游戏目录
2. 在Visual Studio中右键项目 → 添加 → 现有项
3. 导航到游戏目录下的相应路径添加所需DLL文件:
   - BepInEx文件: `游戏目录\BepInEx\core\`
   - 游戏库文件: `游戏目录\valheim_Data\Managed\`
4. 确保所有添加的引用"复制到输出目录"设置为"不复制"

## 为什么这样做?
- 确保使用与您游戏版本完全匹配的库文件
- 避免因版本不一致导致的兼容性问题
- 便于后续更新维护
- 符合Valheim模组开发最佳实践
