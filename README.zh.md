[![us](https://img.shields.io/badge/lang-us-red.svg)](./README.md)

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/PlayForDreamDevelopers/GardenURP-Unity">
    <img src="https://www.pfdm.cn/en/static/img/logo.2b1b07e.png" alt="Logo" width="20%">
  </a>

  <h1 align="center"> Garden URP 示例 </h1>

  <p align="center">
    适配 Unity 官方的 URP Template 中的 Garden 场景的至 Play For Dream MR设 设备。
    <br />
    <a href="https://github.com/PlayForDreamDevelopers/DreamOSConfigs/issues/new?template=bug_report.yml">报告错误</a>
    &middot;
    <a href="https://github.com/PlayForDreamDevelopers/DreamOSConfigs/issues/new?template=feature_request.yml">请求功能</a>
    &middot;
    <a href="https://github.com/PlayForDreamDevelopers/DreamOSConfigs/issues/new?template=documentation_update.yml">改进文档</a>
    
  </p>
</div>

> [!tip]
>
> 必须使用 Play For Dream MR 设备并启用了注视点渲染功能，才能正确的体验本项目，否则将遇到严重的性能问题。

## 关于项目

https://github.com/user-attachments/assets/648b7339-fff3-42e7-8a0e-6919161accfc

本项目基于 Unity 官方的 URP Template 中的 Garden 场景，进行效果调整和性能优化，使其能运行在 Play For Dream MR 设备上，你可以在本项目中体验到 Quad Views 注视点渲染带来的性能优化和清晰度的提升。

针对 Unity 原始的 Guardian 和 `Mobile-Low` URP 配置，主要进行了以下的修改：
1. 使用 ASTC 纹理压缩
2. 不再限制 `Global Mipmap Limit` 分辨率
3. 关闭 Post Processing 和 HDR 功能，移除所有的 Render Feature
4. 关闭主灯光效果
5. 开启 4x MSAA
6. 使用 YVR Core SDK 提供的 QuadViews 渲染方式
