# ValMod Template

Valheim游戏模组开发模板项目，基于BepInEx和HarmonyLib构建。

## 功能特性

- 提供Valheim模组开发的基本框架
- 包含BepInEx插件模板代码
- 预配置Harmony补丁支持
- 包含必要的Valheim游戏库引用

## 系统要求

- [Valheim](https://store.steampowered.com/app/892970/Valheim/) 游戏
- [BepInEx](https://github.com/BepInEx/BepInEx) 5.4.21或更高版本
- .NET Framework 4.8.1
- Visual Studio 2019或更高版本(推荐)

## 安装使用

1. 克隆本项目到Valheim的BepInEx插件目录:
   ```
   git clone https://github.com/your-repo/ValMod-Template.git
   ```
2. 修改`ValMod_Template.cs`中的模组信息:
   ```csharp
   internal const string mod_GUID = "your.mod.id";
   internal const string mod_NAME = "Your Mod Name"; 
   internal const string mod_VERSION = "1.0.0";
   ```
3. 实现你的模组功能

## 开发指南

1. 打开`ValMod Template.sln`解决方案文件
2. 添加你的功能代码
3. 构建项目，DLL将输出到`bin`目录
4. 将生成的DLL复制到Valheim的`BepInEx/plugins`目录测试

## 依赖项说明

### 重要提示
本项目中的`Libs`文件夹默认应为空，请勿直接使用其中可能存在的库文件。所有依赖项需要您从游戏安装目录手动添加，以确保版本兼容性。

### 完整引用库文件列表
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

### 添加依赖项步骤
1. 安装BepInEx到您的Valheim游戏目录
2. 在Visual Studio中右键项目 → 添加 → 现有项
3. 导航到游戏目录下的相应路径添加所需dll文件:
   - BepInEx文件: `游戏目录\BepInEx\core\`
   - 游戏库文件: `游戏目录\valheim_Data\Managed\`
4. 确保所有添加的引用"复制到输出目录"设置为"不复制"

### 为什么这样做?
- 确保使用与您游戏版本完全匹配的库文件
- 避免因版本不一致导致的兼容性问题
- 便于后续更新维护
- 符合Valheim模组开发最佳实践

## 贡献

欢迎提交Pull Request或Issue报告问题。

## 开源协议与法律声明

### 许可证
本项目采用 [MIT 许可证](LICENSE) 开源，这是Valheim模组开发社区广泛使用的许可证。您可以自由地：

- 使用、复制、修改、合并、出版发行、散布、再许可
- 将本软件用于商业用途

唯一的限制是必须包含原始许可证和版权声明。

### 免责声明
1. 本软件按"原样"提供，不附带任何明示或暗示的担保
2. 开发者不对因使用本软件导致的任何直接或间接损失负责
3. 本软件与Valheim官方无任何关联，是独立第三方开发
4. 使用本模板开发的模组需自行承担所有责任

### 法律建议
如需将本模板用于商业项目，建议咨询专业法律人士。
