# Sudoku - Windows Desktop Game.
#### Sudoku game was created using such technologies as:
>
- Microsoft WPF Framework
  https://docs.microsoft.com/pl-pl/visualstudio/designers/getting-started-with-wpf?view=vs-2019
- SudokuSharp - library allowing to create sudoku board
  https://github.com/BenjaminChambers/SudokuSharp
- Microsoft .NET Framework
  https://en.wikipedia.org/wiki/.NET_Framework

## Sudoku - project design
Project consists of few projects:
- Sudoku.Engine
  This is class library project used for all logic happenning in the applicaiton 
- Sudoku.Engine.Tests
  This is test project used for testing application logic
- Sudoku.GUI
  This is a project containing GUI for sudoku game, using Sudoku.Engine as game logic.

## Sudoku.Engine - documentation 
[Documentation for Sudoku.Engine](Sudoku/Sudoku.Engine/articles/intro.md)

## Sudoku.GUI - description

[Description for Sudoku.GUI](Sudoku/Sudoku.GUI/articles/description.md)

## Sudoku Test

Test were divided between GUI and Engine and can be found here:
### GUI:
https://github.com/karolinakania90/sudoku/tree/master/Sudoku/Sudoku.GUI.Tests
### ENGINE:
https://github.com/karolinakania90/sudoku/tree/master/Sudoku/Sudoku.Engine.Tests
