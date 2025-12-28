# 🚀 Interactive AR Portfolio | Unity 6 & Vuforia

[![Watch the AR Portfolio Demo](https://img.youtube.com/vi/zObSq2VReU8/maxresdefault.jpg)](https://www.youtube.com/watch?v=zObSq2VReU8)

*Click the image above to watch the project in action!*

---

## 📖 Overview
This project is an immersive Augmented Reality (AR) application built in **Unity 6**. It transforms a physical QR code into a dynamic digital workstation, featuring a custom-animated 3D avatar and interactive holographic nodes that link to professional platforms like LinkedIn, GitHub, and LeetCode.

## 🛠️ Technical Features
* **Image Tracking**: Utilizes the Vuforia Engine to anchor 3D assets to physical targets using high-contrast feature mapping.
* **3D Spatial UI**: Designed a "Holographic" interface on a 3D glass plane to provide a grounded, immersive user experience.
* **Physics Raycasting**: Implemented a C# raycasting system that translates screen-touch coordinates into 3D world rays to detect collisions with object colliders.
* **Dynamic Linking**: Integrated `Application.OpenURL` to bridge the AR environment with native mobile and desktop browsers.
* **Optimized Version Control**: Configured a professional `.gitignore` to exclude large Unity binaries and IL2CPP temp files, keeping the repository lightweight.

## 🚀 How to Run
1.  **Clone the Repo**: 
    `git clone https://github.com/tzprograms/AR-Interactive-Portfolio.git`
2.  **Open in Unity**: Use **Unity 6 (6000.0.32f1)**.
3.  **Vuforia Key**: Add your license key in the Vuforia Configuration settings.
4.  **Print Target**: Use the `myQR.png` file found in the root directory as your physical tracking target.

## 📂 Project Structure
* **Assets/Scripts**: Contains core C# logic for raycasting and hover animations.
* **Assets/Prefabs**: Pre-configured 3D icons and the glass-base UI anchor.
* **ProjectSettings**: Engine-level configurations for XR Plug-in Management and URP.

---
*Developed by Tejas for academic evaluation.*
