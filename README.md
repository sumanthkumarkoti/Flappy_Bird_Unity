# Flappy Bird (Unity)

A 2D Flappy Bird-style game made with Unity.

## Features

- Player-controlled bird and pipe obstacles
- Score tracking
- High-score saving using Unity `PlayerPrefs`
- Increasing pipe speed as the score rises
- Start screen, game-over screen, and restart option
- Game-over sound effect
- Exit buttons on the start and game-over screens

## Controls

- Click/tap (or use the input configured in the project) to make the bird flap.

## Requirements

- Unity 6 (6000.0) or a compatible Unity version
- Windows, macOS, or Linux for the corresponding desktop build

## Open the project

1. Clone or download this repository.
2. Open Unity Hub.
3. Select **Add** and choose the cloned project folder.
4. Open the project with a compatible Unity Editor version.
5. Open the game scene from the `Assets/Scenes` folder (if the scene is stored there).

## Build the game

1. Open the project in Unity.
2. Go to **File → Build Profiles**.
3. Select the target platform.
4. Ensure the game scene is included in the build scene list.
5. Click **Build** and choose an output folder.

## Git notes

The repository should contain the Unity project source files, including `Assets`, `Packages`, and `ProjectSettings`.

Generated folders such as `Library`, `Temp`, and `Obj` are excluded by `.gitignore`. Build outputs should generally be shared separately from the source repository.

## Author

Sumanth Kumar Koti
