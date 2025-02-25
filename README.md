# Thread Synchronization Demo - Race Conditions

## Overview

This project demonstrates the concept of thread synchronization in C#. Specifically, it compares the behavior of synchronized and non-synchronized threads in updating shared data. The non-synchronized version showcases potential issues like race conditions, where thread execution order leads to data mismatches (e.g., character names and colors being mixed up).

The application simulates a scenario where multiple threads attempt to update the favorite character and color of a person (Dorothy) in a shared `Data` object. The **synchronized** version ensures correct updates by using locks, while the **non-synchronized** version allows for race conditions, resulting in occasional data mismatches.

## Features

- **Synchronized Threads**: Correctly handles updates using locks to ensure the shared data is not overwritten by concurrent threads.
- **Non-Synchronized Threads**: Demonstrates race conditions, where the order of thread execution leads to inconsistent data.

## Screenshots

### Non-Synchronized Mode

![Screenshot 2025-02-25 174236](https://github.com/user-attachments/assets/c14492be-61df-4a40-94cf-49284797e832)
*This screenshot shows the output in non-synchronized mode, where occasional mismatches occur in the character's favorite and their color.*

### Synchronized Mode

![Screenshot 2025-02-25 174329](https://github.com/user-attachments/assets/ce834c24-21d1-4318-9053-fc7eccc5c7dd)
*This screenshot shows the output in synchronized mode, where the data is consistently correct due to the use of locks.*

## Installation

### Prerequisites

To run this project, you need the following installed:

- .NET Core 5.0 or later
- Visual Studio or Visual Studio Code (with C# extensions)

### Steps

1. Clone the repository:
    ```bash
    git clone https://github.com/YourUsername/kin4.git
    ```

2. Open the project in Visual Studio or your preferred IDE.

3. Build and run the application.

4. Use the buttons on the main window to test both synchronized and non-synchronized threading behavior.

## How It Works

### 1. **Non-Synchronized Threading**

In the non-synchronized version, multiple threads update the same shared `Data` object (`FavoriteCharacter` and `FavoriteColor`). No locking mechanism is used, which allows multiple threads to execute their work concurrently. This leads to potential **race conditions**, where the final output might display mismatched data, like the wrong character paired with an incorrect color.

### 2. **Synchronized Threading**

The synchronized version uses the `lock` keyword to ensure that only one thread can update the shared `Data` object at a time. This eliminates race conditions, ensuring that the data remains consistent. Each thread waits for the lock to be released before performing updates, preventing concurrent modifications.



