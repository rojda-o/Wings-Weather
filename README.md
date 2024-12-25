# Wings & Weather
A simple 2D game developed in Unity for the Game Programming Course midterm project. In this game, you control a bird that interacts with sunny and stormy clouds, gaining or losing lives accordingly. The goal is to survive for as long as possible by avoiding stormy clouds and collecting sunny clouds. <br>
This game demonstrates fundamental mechanics such as player movement, collision detection, object spawning, and score tracking.
<br>
## Gameplay
- The bird moves up, down, left, and right using arrow keys.
- Sunny Clouds: Increase the bird's lives when collected.
- Stormy Clouds: Decrease the bird's lives when hit.
- The game ends when the bird’s lives drop to zero, restarting automatically.

## How to Play
- Use the arrow keys to navigate the bird.
- Collect sunny clouds to gain lives.
- Avoid stormy clouds to prevent losing lives.
- Survive as long as possible!

## Group Members
<h4>Rojda Özevli 22360859078</h4>

- Movement of the Bird   **Bird_sc.cs:20**
- Lives Counter Display  **Bird_sc.cs:34-40**
- Collision Detection with Clouds  **Bird_sc.cs:28**
- Restart on Death  **Bird_sc.cs:53**

<h4>İrem Aytaş  21360859018</h4>

- Cloud Movement Logic **Cloud_sc.cs:13**
- Cloud Respawn on Exit **Cloud_sc.cs:18**
- Cloud Spawning Mechanism **SpawnManager_sc.cs:12**
- Stop Spawning Clouds on Death **SpawnManager_sc.cs:26**

## Assets
- Cloud Sprites source: pngtree.com
- Bird sprite source: itch.io
- Background sprite source: pressstart.vip

## Technical Details

- Engine: Unity (Version 2022.3.49f1)
- Platform: WebGL
- Scripts:
  - Bird.cs: Handles bird movement, collision detection, lives update, and restart logic.
  - Cloud_sc.cs: Manages cloud movement and respawning after exiting the screen.
  - SpawnManager_sc.cs: Spawns clouds at random intervals and stops spawning on bird death.

## Gameplay Link
https://rojda-o.itch.io/wings-weather
