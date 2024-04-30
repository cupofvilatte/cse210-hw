using System;

// lists
List<string> fruits = new List<string>(); // create a new list of strings

fruits.Add("Apple"); // Add elements to the list
fruits.Add("Banana");
fruits.Add("Orange");

fruits.Remove("Banana"); // remove item by name
fruits.Prepend("Carrot") // Append at the start


// Function to add two numbers
static int AddNumbers(int a, int b) // can start with 'public' to declare public function
{
    int result = a + b;
    return result; // return sum
}

// Function to print a message
static void PrintMessage(string message)
{
    Console.WriteLine(message); // print the message to the console
}

Main(); // call the main funciton to start the program