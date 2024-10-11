# NETLab3

## Lab3 | Design Patterns | Singleton

Muzyka Stefan
IS-02
11 variant

## Task
Make console application "Game Manager." The game consists of a game space and a list of game chips. Ensure the ability to create only one instance of the manager (Singleton pattern).

## Explanation
The game board is described by the Gameboard class. It has a Size field – this is the number of spaces on the game board.
A game chip is described by an abstract class Chip. Each chip has a Value property that defines its weight in the game.
The board and the chips are created by the game manager, as their owner. Each game may differ in the number of spaces on the board and the number of chips, making the "composition" relationship obvious.
The user of the application must have the ability to input, through the console, the number of spaces on the board (its size) and the number of chips of each type.

## Class diagram

![3 (1)](https://user-images.githubusercontent.com/76735417/175928424-7fd2321d-388b-4358-a053-807bd2dd13c9.png)
