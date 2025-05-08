# ValMod 模板

Valheim游戏模组开发模板项目，基于BepInEx和HarmonyLib构建。

## 功能特性
- 提供Valheim模组开发的基本框架
- 包含BepInEx插件模板代码
- 预配置Harmony补丁支持
- 包含必要的Valheim

## 系统要求
- Valheim 游戏
- BepInEx 5.4.21或更高版本
- .NET 框架 4.8.1
- Visual Studio 2019或更高版本（推荐）

## 安装使用
1. 克隆本项目到Valheim的BepInEx插件目录：
   ```
   git clone https://github.com/HsgtLgt/ValMod-Template.git
   ```
2. 修改`ValMod_Template.cs`中的模组信息：
   ```csharp
   internal const string mod_GUID = "your.mod.id";
   internal const string mod_NAME = "Your Mod Name"; 
   internal const string mod_VERSION = "1.0.0";
   ```
3. 实现你的模组功能

## 开发指南
1. 打开`ValMod Template.sln`
2. 添加你的功能代码
3. 构建项目，DLL文件将输出到`bin`目录
4. 将生成的DLL复制到Valheim的`BepInEx/plugins`目录进行测试

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
3. 导航到游戏目录下的相应路径添加所需DLL文件:
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
本项目采用 [MIT 许可证](LICENSE).

### 免责声明
- 开发者不对因使用本软件导致的任何直接或间接损失负责
- 本软件与Valheim官方及其开发商无任何直接或间接关联，仅为第三方开发者提供的模组开发模板
- 使用本模板开发的模组需自行承担所有责任
- 所有贡献者对其提交的代码负责，并应保证其代码不会侵犯任何第三方的权利