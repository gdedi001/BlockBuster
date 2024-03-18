# BlockBuster (Generative AI For Real-Time 3D Evaluation)

## Project Overview
This mixed reality game is a testament to the capabilities of generative AI in game development. Every aspect of this project, including music, scripting, textures, and materials, was generated using AI. The main goal was to evaluate how AI could be leveraged to rapidly build a simple proof of concept. Utilizing advanced technologies like Meta's depth API, the game offers real-time occlusion for both hands and the scene, allowing cubes to seamlessly transition through walls.

### Features
- **Generative AI Creation**: Every component of the game, from the auditory experience to the visual assets, was crafted using generative AI.
- **Real-time Occlusion with Meta's Depth API**: Integrates Meta's depth API for enhanced interaction between the player's hands, the cubes, and the environment, enabling objects to move convincingly through and around obstacles in the scene.

## Getting Started

### Prerequisites
- Unity 2022.3.4.f1
- Meta Quest 3 Headset
- **Required Packages**:
  - Meta XR Core SDK (v60.0.0)
  - Meta XR Interaction SDK (v60.0.0)
  - Meta XR Interaction SDK OVR Integration (v60.0.0)
  - Meta Depth API

### Installation
1. Ensure Unity 2022.3.4.f1 is installed on your system.
2. Clone the repository to your local machine:
3. Open the project in Unity Hub by pointing it to the cloned repo directory.
4. Navigate to `Edit -> Project Settings -> XR Plugin Management` and configure the settings for the Meta Quest 3 headset.
5. Ensure all the required Meta packages are installed and up to date in the Unity Package Manager.

## Usage
Upon launching the game on your Meta Quest 3 headset, you'll be greeted with a start button. Interact with this button using hand tracking to begin the game. Cubes will start to appear and move towards you, challenging you to punch them as they come. Gold cubes offer bonus points, so keep an eye out for them. This application relies solely on hand tracking for interaction, providing an intuitive and immersive experience.
![image](https://github.com/gdedi001/BlockBuster/assets/8450711/1a956a22-21cc-4661-8cae-d9f02d4aece6)
![image](https://github.com/gdedi001/BlockBuster/assets/8450711/3cbf14b0-5a9d-4a6c-b8c3-f4b175c29636)



## Acknowledgements
- [Unity Muse](https://unity.com/products/muse)
- [Meta Platforms, Inc. Depth API](https://developer.oculus.com/blog/mesh-depth-api-meta-quest-3-developers-mixed-reality/)
- [Generative AI Music](https://www.suno.ai/)
- [Generative AI Sound](https://mubert.com/)  
