# Trikis Project Template for Unity

## READ THIS FIRST

This is using Unity **2020.3.11f1**

Clone this repo and create a branch off of `main` before starting.; All your changes should be on that branch. Once you are done, create a Pull Request (PR). This will signify to us that you are complete.

## Game Idea

Your job is to create a 2D game with falling blocks similar to [Tetris](https://tetris.com/play-tetris/). In the original Tetris game, the falling blocks were composed of 4 squares; in this game, the blocks will be composed of 3 squares.

Instead of 7 shapes from the original Tetris game, there will only be 2 shapes in yours which should reduce the complexity of the game.

## Game Objective

The aim in Trikis is simple; you bring down blocks from the top of the screen. You can move the blocks around, either left to right and/or you can rotate them. The blocks fall at a certain rate, but you can make them fall faster if you're sure of your positioning. Blocks are randomly selected to fill a block queue.

Your objective is to get all the blocks to fill all the empty space in a line at the bottom of the screen; whenever you do this, the blocks will vanish and you get awarded some points.

## Game Mechanics

* **Rotation**: rotate clockwise and rotate counter-clockwise.
* **Movement**: left, right, and down.
* **Hold**: Swaps block with the block inside the holding area. If there is no block in the holding area, place current block in holding area. After the swap, the new block should have the same board position as the swapped block.
* **Trikis**: When a line/row is formed from left to right, remove the line and add the score. Shift overhead occupied rows downwards to fill the gap.
* **Hard-Drop**: Instantly drop block to the bottom of the board.

## Game Requirements

* Playable field with grid size of 8 x 16.
* Main Menu Scene.
* Keyboard Input.
* Game Over when block height reaches above 16.
* A button to restart after Game Over.
* Hold Mechanic from original Tetris Game.
* A block queue of at least 1.
* Score counter.

### Nice to Haves

* A "ghost block" at the bottom of the board to indicate hard-drop position
* Audio
* Line matching effects
* A pause menu

### Recommended Button Scheme (Let us know if you change this)

* Arrow Keys for movement
* Spacebar for hard-drop
* Z and X for rotation
* Shift or C for hold

### Unity's New Input System

This project template is currently using Unity's new Input system. If you prefer to use Unity's legacy input system, you will need to change the settings.

Documentation on the new system:
<https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/index.html>

### Included Assets

**USAGE IS OPTIONAL** -- I just thought they might be nice to have.

* A spritesheet and example block prefabs.
* An object pool written by Quill18.
* An orthographic camera resizing script.
* A platform agnostic, seeded, random number generation algorithm called Mersenne Twister.
* A tweening library called DOTween.
* An example script showing how to use Mersenne Twister and DOTween.

DOTween Documentation: <http://dotween.demigiant.com/documentation.php>
