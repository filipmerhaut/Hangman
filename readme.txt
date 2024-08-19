Project description:
The goal of the project is to create a console game Hangman in C# as a learning excercise. 
The point of the game is that the player will guess the hidden word letter by letter.
 If the player guesses the letter correctly, it is revealed in the word in all the corresponding positions.
If the player guesses wrong, a part is added to the "hangman". 
The game ends when the player guesses the whole word or when the "hangman" is complete.

Game functionality:
- Word selection: The program randomly selects a word from a list of words.
- Word Display: At the beginning of the game, the hidden word will be displayed as a series of underscores (_ _ _).
- Player input: The player enters the letter they think is in the word.
- Input check: if the character is not a letter, the program warns about it + this attempt is not deducted from the limit
- Letter Check:
    If the letter is in the word, the program will detect the letter in all matching positions.
    If the letter is not in the word, the body part is added to "hangman".
- List of already entered letters
- Number of attempts: The player has a limited number of bad attempts (eg 10).
- Game Over: The game ends when the player either guesses the whole word or makes too many mistakes and the hangman is complete.
- Replay: After the game is over, the player has the option to play again.
 
Technical requirements:
- List of words:
    The list of words can be stored directly in the code or in an external file (e.g. .txt).
- Console Application:
    Inputs and outputs will be done using the console.

Proposals for optional bonus extensions:
- Configuration file: structured (xml, csv, json, .config) configuration file with a parameter to set the maximum number of attempts
- Selection of difficulty level (either interactively or in configuration file)
- Saving results: Implement saving and retrieving game results (eg number of wins/losses).
- More word categories: Have more word categories for the player to choose from (eg animals, countries, food).
- "GUI": A step-by-step "graphical" display of the hangman (using "ASCII art")
- Multilingual version
- Words are stored in a database (e.g. SQLite)
- Unit Tests
- Utilize linq