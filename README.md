# ValMod 模组开发模板

一个专为**零基础小白**设计的Valheim模组开发入门模板，基于BepInEx和HarmonyLib构建。

## 🎯 这个模板能帮你做什么？

- ✅ 快速搭建Valheim模组开发环境
- ✅ 提供完整的项目结构和配置
- ✅ 包含基础的模组框架代码
- ✅ 预配置Harmony补丁系统
- ✅ 适合初学者学习和实践

## 🚀 快速开始（5分钟上手）

### 第一步：准备开发环境
1. **安装Visual Studio 2022 Community**（免费版）
   - 下载地址：https://visualstudio.microsoft.com/zh-hans/vs/community/
   - 安装时选择".NET桌面开发"工作负载

2. **确保你的电脑有.NET Framework 4.8.1**
   - Windows 10/11通常已预装
   - 如果没有，可以从微软官网下载

### 第二步：下载模板
1. 点击页面右上角的绿色"Code"按钮
2. 选择"Download ZIP"
3. 解压到你的工作目录（比如`D:\MyMods\`）

### 第三步：配置项目
1. 双击`ValMod Template.sln`打开项目
2. 修改`ValMod_Template.cs`中的模组信息：
   ```csharp
   internal const string mod_GUID = "com.yourname.firstmod";  // 改成你的唯一标识
   internal const string mod_NAME = "我的第一个模组";         // 改成你的模组名称
   internal const string mod_VERSION = "1.0.0";              // 改成你的版本号
   ```

### 第四步：添加游戏依赖库
1. **找到你的Valheim游戏安装目录**
   - Steam版通常在：`C:\Program Files (x86)\Steam\steamapps\common\Valheim\`
   - 其他平台请查找相应目录

2. **在Visual Studio中添加引用**
   - 右键项目 → 添加 → 项目引用
   - 点击"浏览"按钮
   - 添加以下文件（从游戏目录复制）：
     - `BepInEx\core\BepInEx.dll`
     - `BepInEx\core\0Harmony.dll`
     - `valheim_Data\Managed\assembly_valheim.dll`
     - `valheim_Data\Managed\assembly_utils.dll`
     - `valheim_Data\Managed\UnityEngine.dll`
     - `valheim_Data\Managed\UnityEngine.CoreModule.dll`

### 第五步：编译和测试
1. 按`Ctrl+Shift+B`编译项目
2. 将生成的`bin\Debug\net481\ValMod Template.dll`复制到：
   `游戏目录\BepInEx\plugins\`
3. 启动游戏，在BepInEx控制台应该能看到你的模组加载信息

## 📁 项目结构说明

```
ValMod Template/
├── ValMod_Template.cs          # 主模组代码文件
├── ValMod Template.csproj      # 项目配置文件
├── ValMod Template.sln         # 解决方案文件
├── Libs/                       # 依赖库文件夹（需要手动添加）
└── bin/                        # 编译输出目录
```

## 🔧 开发指南

### 在哪里添加你的代码？
- **Awake()方法**：模组初始化时执行，适合设置配置、注册事件
- **Update()方法**：每帧执行，适合处理实时逻辑
- **OnDestroy()方法**：模组卸载时执行，适合清理资源

### 基本代码结构
```csharp
public void Awake()
{
    // 在这里添加你的模组初始化代码
    Logger.LogInfo("我的模组开始工作了！");
    
    // 加载Harmony补丁
    harmony.PatchAll();
}
```

## ❓ 常见问题

### Q: 编译时提示找不到引用？
A: 确保已经按照"第四步"添加了所有必要的DLL文件

### Q: 游戏启动时模组没有加载？
A: 检查DLL文件是否放在了正确的`BepInEx\plugins\`目录下

### Q: 如何查看模组日志？
A: 游戏启动后按F5键，在BepInEx控制台中查看

### Q: 可以修改游戏中的什么？
A: 几乎所有内容都可以修改！比如：
- 玩家属性（血量、耐力、技能等）
- 物品属性（伤害、防御、重量等）
- 游戏机制（建造、战斗、探索等）

## 🎓 学习资源

- [BepInEx官方文档](https://docs.bepinex.dev/)
- [Harmony补丁教程](https://github.com/pardeike/Harmony/wiki)
- [Valheim模组开发社区](https://discord.gg/valheim)

## 📝 注意事项

- 开发模组前请备份你的存档
- 确保使用的依赖库版本与游戏版本匹配
- 发布模组时请遵守相关社区规范

## 🤝 需要帮助？

- 遇到问题？请提交Issue
- 有好的想法？欢迎提交Pull Request
- 想交流经验？可以加入我们的讨论群

## 📄 开源协议

本项目采用 [MIT 许可证](LICENSE)，你可以自由使用、修改和分发。

---

**🎉 恭喜！你已经成功搭建了Valheim模组开发环境！**

现在你可以开始编写你的第一个模组了。记住，每个大神都是从新手开始的，不要害怕犯错，多尝试、多学习！