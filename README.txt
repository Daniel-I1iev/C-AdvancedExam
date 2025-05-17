# C# Exam Exercises

This repository contains C# solutions for a series of programming exercises designed to assess your understanding of C# concepts, including class design, data structures, and algorithm implementation.

## Exercises

The exercises cover the following problems:

1.  **Wild Survival**:  Simulates a battle between bees and bee-eaters.
   
2.  **Collecting Stars Game**:  A game where a player collects stars on a field while avoiding obstacles.
   
3.  **Cocktail Bar**:  Creates a system to manage a cocktail menu.

## 1. Wild Survival [cite: 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170]

   * **Description**: This program simulates a conflict between bees and bee-eaters.  It involves processing sequences of integers representing groups of bees and bee-eaters, and calculating the outcome of their battles. [cite: 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170]
   * **Input**:
        * A sequence of integers representing bee groups. [cite: 150, 151, 164]
        * A sequence of integers representing bee-eater groups. [cite: 152, 153, 165]
   * **Output**:
        * The final battle outcome, indicating surviving bee groups or bee-eater groups, or if none survived. [cite: 167, 168, 169]
   * **Key Concepts**:  Queues, Stacks, List manipulation, Game logic.

## 2. Collecting Stars Game [cite: 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145]

   * **Description**:  This is a console-based game where a player navigates a field to collect stars while avoiding obstacles. [cite: 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145]
   * **Input**:
        * The size of the square field (N). [cite: 116, 135]
        * The field configuration (N lines). [cite: 117, 136]
        * A sequence of player movement commands ("up", "down", "left", "right"). [cite: 121, 122, 136]
   * **Output**:
        * Game result (win/lose message). [cite: 137, 138]
        * Player's final position. [cite: 134, 139, 140]
        * The final state of the game field. [cite: 134, 139, 140]
   * **Key Concepts**:  2D arrays (matrices), game loop, player movement, collision detection.

## 3. Cocktail Bar [cite: 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112]

   * **Description**:  This program simulates a cocktail bar menu, managing cocktails and their details. [cite: 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112]
   * **Classes**:
        * `Cocktail`: Represents a cocktail with properties like name, price, volume, and ingredients. [cite: 96, 97, 98]
        * `Menu`:  Manages a collection of `Cocktail` objects and provides methods to add, remove, and retrieve cocktail information. [cite: 99, 100, 101, 102, 103, 104, 105, 106, 107, 108]
   * **Key Concepts**:  Object-oriented programming (OOP), classes, methods, lists, data management.

## Submission Instructions

   * For each exercise, zip the entire project folder, **excluding** the `bin` and `obj` folders. [cite: 91, 92, 93, 94, 112]

**Note:** Follow the naming conventions and project structure specified in the problem descriptions. [cite: 91, 92, 93, 94]