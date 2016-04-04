# Week_13A_Tasks
Repository for week 13A tasks

# Task description

- Task 1a: CreateClass

Using Visual Studio, create a new console application project. Name the project CreateClass. 
Let this class have the following properties: name, birth date (choose the data type you might think suitable). 
Also add an enumeration to your class, called Genders. The person can be Male or Female! 
Override the ToString() method of the Person, and return some information about the class in it.

- Task 1b: Inheritance

Add a new class to your project called Employee. Derive this class from Person, since an 
Employee is a person. Let the employee have new properties like salary and profession. 
Override the ToString() method of the Person in order to return these new pieces of information as well. 
Extend the Employee class to have a reference to a Room class.
Let the Room class be a simple class with a single integer, the room number.

- Task 1c: Clone Wars

This exercise is about cloning, and the meaning of deep and shallow copy. Modify the Employee class to implement the ICloneable interface.

- Task 2: Respod to an event

Implement the method that will respond to the Timer.Tick event. When the event occurs, add 10 to the ProgressBar.
Value attribute. Then stop the timer if the ProgressBar.Value attribute has reached 100.

- Task 3: Working with strings

In this exercise, you will write a function to sort a string.
Define a string. Then use the String.Split method to separate the string into an array of words.
Call the String.Join method to convert the array of words back into a single string, and then write the string to the console. 
