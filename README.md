🚀 Interactive AR Portfolio | Unity 6 & Vuforia
Click the image above to watch the project in action!

📖 Overview
This project is an immersive Augmented Reality (AR) application that transforms a physical QR code into a dynamic digital workstation. It features a custom-animated 3D avatar and interactive holographic nodes linking to professional platforms.

🛠️ Technical Features
Image Tracking: Utilizes Vuforia’s Computer Vision engine to anchor 3D assets to physical targets using high-contrast feature mapping.

3D Spatial UI: Features a "Holographic" interface designed on a 3D plane, providing a grounded user experience.

Physics Raycasting: Implemented a C# raycasting system that shoots invisible rays from screen-touch coordinates to detect collisions with 3D object colliders.

Dynamic Linking: Integrated Application.OpenURL to bridge the AR environment with native mobile/desktop browsers.

Optimized Version Control: Configured a professional .gitignore to exclude heavy Unity build binaries and IL2CPP temp files, keeping the repo lightweight.

🚀 How to Run
Clone the Repo: git clone https://github.com/tzprograms/AR-Interactive-Portfolio.git.

Open in Unity: Use Unity 6 (6000.0.32f1).

Vuforia Key: Add your license key in Vuforia Configuration.

Print Target: Use the myQR.png file in the root directory as the physical tracking target.

📂 Project Structure
Assets/Scripts: Core C# logic for raycasting and animations.

Assets/Prefabs: Pre-configured 3D icons and glass-base UI.

ProjectSettings: Engine-level configurations for XR and URP.
