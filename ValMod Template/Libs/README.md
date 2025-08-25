# 📚 依赖库说明

## ⚠️ 重要提醒

**这个文件夹目前是空的，你需要手动添加游戏依赖库才能编译项目！**

## 🔍 需要哪些文件？

### BepInEx核心库（从游戏目录复制）
- `BepInEx\core\BepInEx.dll` - 模组框架核心
- `BepInEx\core\0Harmony.dll` - 代码补丁库

### Valheim游戏库（从游戏目录复制）
- `valheim_Data\Managed\assembly_valheim.dll` - 游戏主逻辑
- `valheim_Data\Managed\assembly_utils.dll` - 游戏工具库
- `valheim_Data\Managed\UnityEngine.dll` - Unity引擎核心
- `valheim_Data\Managed\UnityEngine.CoreModule.dll` - Unity核心模块

## 📁 如何添加？

1. **找到你的Valheim游戏安装目录**
   - Steam版：`C:\Program Files (x86)\Steam\steamapps\common\Valheim\`

2. **在Visual Studio中添加引用**
   - 右键项目 → 添加 → 项目引用
   - 点击"浏览"，选择上面列出的DLL文件

3. **设置引用属性**
   - 选中每个引用，在属性面板中设置"复制到输出目录"为"不复制"

## 💡 为什么这样做？

- ✅ 确保使用正确的游戏版本库文件
- ✅ 避免版本不匹配导致的错误
- ✅ 符合模组开发最佳实践

## 🆘 找不到这些文件？

- 确保已经安装了BepInEx到游戏目录
- 确保游戏已经至少启动过一次
- 如果还是找不到，请检查游戏安装是否完整
