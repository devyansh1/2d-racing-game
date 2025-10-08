# Road Fighter Remake (2D Unity Racer)

A challenging 2D top-down racing game for PC, inspired by the classic arcade title **Road Fighter**. Dodge traffic, navigate changing road lanes, and see how far you can drive before crashing!

## Features

* **Classic Gameplay:** Endless vertical-scrolling driving action.
* **Dynamic Road:** The road randomly shifts between **center, left, and right lanes** using a state-machine system.
* **Challenging Traffic:** Enemy cars, including the **Blue Car**, utilize basic AI to weave within lane boundaries to challenge the player.
* **Core Systems:** Includes a custom **GameManager** (Singleton), collision handling, and distance tracking.

***

## How to Run

### Prerequisites

* Unity Hub
* Unity Editor

### Setup

1.  **Clone the Repository:**
    ```bash
    git clone https://github.com/devyansh1/2d-racing-game
    ```
2.  **Open in Unity Hub:** Add the cloned folder to Unity Hub and open the project.
3.  **Run:** Open the main game scene and press **Play** in the editor.

***

## Core Scripts Summary

| Script Name | Primary Role |
| :--- | :--- |
| **`GameManager`** | Controls game state (`gameOver`), handles scene restart, and triggers the crash sequence. |
| **`PlayerMove`** | Reads horizontal input and handles collisions with enemies/boundaries. |
| **`SpawnerRoad`** | Manages the procedural generation of road segments and changes lane states. |
| **`SpawnerCar`** | Spawns enemy traffic within the boundaries of the current road state. |
