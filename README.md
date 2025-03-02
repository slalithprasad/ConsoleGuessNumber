# Console Guess Number 🎯  

A simple console-based **Guess the Number** game built with **C#**. The program picks a random number, and the player must guess it with hints guiding them.  

## How It Works  

- The program selects a **random number** between 1 and 100.  
- The player guesses a number, and the game provides hints:  
  - 🔥 **High!** (Very close, but slightly above)  
  - ❄️ **Low!** (Very close, but slightly below)  
  - 📈 **Too High!** (Way above the correct number)  
  - 📉 **Too Low!** (Way below the correct number)  
- The player keeps guessing until they find the correct number.  
- The game tracks the **number of attempts** and displays the final score.  
- The player can **choose to play again** or exit.  

---

## Prerequisites  
- Download and Install [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download)  

---

## Setup  
1. Clone the repository:  
    ```bash
    git clone https://github.com/slalithprasad/ConsoleGuessNumber
    cd ConsoleGuessNumber
    ```
2. Install required NuGet packages:  
    ```bash
    dotnet restore
    ```

---

## Running the Game  
```bash
dotnet run
```

---

## Gameplay Example  

```text
🎯 Welcome to Guess the Number!

I have picked a number between 1 and 100. Try to guess it!

Enter your guess: 50
Too High!

Enter your guess: 30
Too Low!

Enter your guess: 45
High! You're very close!

Enter your guess: 43
Low! You're very close!

Enter your guess: 44
🎉 Congratulations! You guessed it in 5 attempts.

Do you want to play again? (y/n): y

I have picked a new number between 1 and 100. Try to guess it!
```

--- 

**Happy Guessing!** 🎉🔢