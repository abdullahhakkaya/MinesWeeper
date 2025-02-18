# Minesweeper Game

### Developed by Abdullah Akkaya  
**Software Engineering, Kocaeli University**  
**Kocaeli/Turkey**  
**Email:** abdullahakkayaa@icloud.com

---

## Overview
This repository contains the Minesweeper game developed in C# using Windows Forms. The game is a strategic puzzle game where players must detect hidden mines on a grid while avoiding detonating them. With a user-friendly interface and multiple difficulty levels, the application provides an engaging and enjoyable experience for players. Players can also compare their scores with others via a leaderboard displayed at the end of each game.

---

## Features
- **Graphical User Interface (GUI):**
  - Dynamic grid generation based on user input.
  - Intuitive controls with left-click to reveal cells and right-click to flag potential mines.
- **Customizable Gameplay:**
  - Players can input their desired grid size (10x10 to 30x30).
  - Specify the number of mines (minimum of 10, up to `(grid size - 1)^2`).
- **Automatic Cell Reveal:**
  - Opens surrounding cells automatically if no adjacent mines are detected.
- **Endgame Scenarios:**
  - Players win by revealing all non-mine cells.
  - If a mine is clicked, all mines are revealed, and the game ends.
- **Scoreboard:**
  - Tracks and displays the top 10 scores.
  - Scores are calculated based on time taken and correctly flagged mines.

---

## How to Play
1. **Input Parameters:**
   - Enter your name, grid size, and the number of mines.
2. **Reveal Cells:**
   - Left-click on a cell to reveal it.
   - Numbers indicate how many adjacent mines are present.
3. **Flag Mines:**
   - Right-click to flag a cell if you suspect it contains a mine.
4. **Win Condition:**
   - Successfully reveal all non-mine cells.
5. **Lose Condition:**
   - Click on a mine.

---

## Technical Details
### Programming Language:
- Developed in **C#** using its object-oriented programming features to ensure modularity and maintainability.

### Class Structure:
- **Form1:** Main interface for game setup and play.
- **Form2:** Displays the leaderboard with top scores.
- **Game Class:** Handles game logic and mechanics, such as grid creation, mine placement, and game state management.
- **Scoreboard Class:** Manages user scores and maintains a persistent leaderboard.

### Key Methods:
- `GenerateGrid()`: Dynamically creates the grid and initializes buttons.
- `PlaceMines()`: Randomly places mines and calculates adjacent mine counts.
- `RevealCell()`: Handles the logic for revealing a cell and its surroundings.
- `CheckWinCondition()`: Verifies if the game is won.
- `ShowMines()`: Reveals all mines when the game ends.

---

## Installation and Setup
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/minesweeper-game.git
   ```
2. **Open the Project:**
   - Open the solution file (`.sln`) in Visual Studio.
3. **Run the Application:**
   - Build and run the project directly from Visual Studio.

---

## Scoring System
- Scores are calculated based on:
  - Time taken to complete the game.
  - Correctly flagged mines.
- Formula:
  ```
  Score = (Remaining Flags / Total Mines) * 100 - Elapsed Time (seconds)
  ```

---

## Contribution
Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add a new feature"
   ```
4. Push the branch:
   ```bash
   git push origin feature-name
   ```
5. Open a pull request.

---

## License
This project is licensed under the MIT License. See the `LICENSE` file for details.

---

## References
1. Herbert Schildt, "C# 4.0 The Complete Reference," 2000.
2. Udemy, "C# Development from Scratch," Murat Yücedağ. [Accessed: Nov. 1, 2024].
3. YouTube, "C# Windows Forms Tutorials," Mehmet Mert Gündüz. [Accessed: Nov. 1, 2024].
4. [W3Schools C# Tutorial](https://www.w3schools.com/cs/index.php).
5. [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/).

---

## Screenshots
![Gameplay Screenshot](path/to/screenshot1.png)
![Leaderboard Screenshot](path/to/screenshot2.png)

---


