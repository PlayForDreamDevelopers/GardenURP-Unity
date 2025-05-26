[![zh](https://img.shields.io/badge/lang-zh-blue.svg)](./README.zh.md)

<!-- PROJECT LOGO -->
<br />
<div align="center">
    <a href="https://github.com/PlayForDreamDevelopers/GardenURP-Unity">
        <img src="https://www.pfdm.cn/en/static/img/logo.2b1b07e.png" alt="Logo" width="20%">
    </a>
    <h1 align="center"> Garden URP Showcase </h1>
    <p align="center">
        Adaptation of Unity's official URP Template Garden scene for Play For Dream MR devices.
        <br />
        <a href="https://github.com/PlayForDreamDevelopers/DreamOSConfigs/issues/new?template=bug_report.yml">Report Bug</a>
        &middot;
        <a href="https://github.com/PlayForDreamDevelopers/DreamOSConfigs/issues/new?template=feature_request.yml">Request Feature</a>
        &middot;
        <a href="https://github.com/PlayForDreamDevelopers/DreamOSConfigs/issues/new?template=documentation_update.yml">Improve Documentation</a>
    </p>
</div>

> [!tip]
>
> You must use a Play For Dream MR device with foveated rendering enabled to experience this project correctly, otherwise you may encounter severe performance issues.

## About the Project

https://github.com/user-attachments/assets/648b7339-fff3-42e7-8a0e-6919161accfc

This project is based on the Garden scene from Unity's official URP Template, with effect adjustments and performance optimizations for Play For Dream MR devices. You can experience the performance boost and clarity improvement brought by Quad Views foveated rendering in this project.

Compared to Unity's original Guardian and `Mobile-Low` URP settings, the following main modifications have been made:
1. Use ASTC texture compression
2. Remove the restriction on `Global Mipmap Limit` resolution
3. Disable Post Processing and HDR, and remove all Render Features
4. Disable main light effects
5. Enable 4x MSAA
6. Use QuadViews rendering provided by YVR Core SDK