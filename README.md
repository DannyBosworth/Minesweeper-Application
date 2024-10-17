# Minesweeper-Application

Modular Object-Oriented WinForms application including a full implementation of Minesweeoper, a solver, a custom board creator and a stats tracker created to the specification of an end user.

[FULL REPORT AND DETAILED ANALYSIS OF THE PROJECT](https://github.com/DannyBosworth/Minesweeper-Application/blob/main/Report%20and%20Testing/Project%20Report.pdf)

## The Game

The primary feature of the application is a fully functional implementatio of Minesweeper, including a timer and custom board difficulties.

## Solver

The solver uses a constraint satisfaction algorithm making use of stacks to perform backtracking, as well as a brute force algorithm using combinatorial maths to calculate the next best move.

## Custom Board Generator

Allows the user to create and then have the computer solve a board created by them. Can create any board with any valid combination of values.

## Stats Tracker

Stores information about every game the user has played in a custiom plaintext form. A user friendlyt interface is provided, allowing for sorting and filtering of games by any recorded statistic. Game sessions played by the solver are also tracked live with a window providing average win rates, guess success percentages and other intersting metrics to assess the effectiveness of the solving algorithms.
