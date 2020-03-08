# Mid Semester Problems
The problems given here are slightly modified versions of the problems given in the mid semester exam.
As the problems are based on the same scenario, they are given in one single file.

Consider that you are developing a game “save the animals” where the main character, Ratul, 
fights the bad guys to free animals they have illegally captured.

Some code are given in the `MidSemester` folder of `DesignPatterns` project.
Also, some tests are given in the `MidSemester` folder of `DesignPatterns.Test` project.
You should make sure that all tests pass.
You may need to make some changes in the test code.
But do not remove any test methods.
You can add additional test methods if you need.

## Problem 1
Ratul has two actions: close action and distant action.  
The gamer can choose from one of three close actions for Ratul: punch, kick and head.  
The distant action is a sequence of acts: move, grab and hit. 
The gamer can choose from one of two distant actions: power and skill.  
When using power action, Ratul moves to a nearby enemy, picks the enemy up and slams the enemy to the ground. 
When using the skill action, Ratul moves to a nearby enemy, holds the enemy’s collar, and hit the enemy’s belly with a knee.
Note that the move part is exactly the same for the two actions, but the grab and hit parts vary.

## Problem 2
Gamers’ statistics are usually stored in a plain text file. 
However, some users prefer to keep their statistics secret so they want to encrypt the file.
For some, the data is very large so a compression facility is also required.
Additionally, Some people prefer to keep their data as base-64 encoding.

These conversions of the data file can be done in any sequence and the same conversion can be applied multiple times. 

## Problem 3
The users of “save the animals” can save their preferences.
To implement this, you need to write a `Preference` class with the following considerations:

* There should be a `void setPreference(string key, string value)` method to store a preference.
* There should be a `string getPreference(string key)` method to retrieve a preference.
* A single instance of the `Preference` class should be maintained throughout the application so that all the code gets the same preference values.
* Make sure that no code can accidentally create additional instances of `Preference` class.
* The instance of the `Preference` class should be created only when it is needed for the first time.
* Computer games are usually multi-threaded programs. 

You do not have to actually store the preferences in file or database.


