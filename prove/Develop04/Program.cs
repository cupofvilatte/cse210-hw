using System;

class Program
{
    static void Main(string[] args)
    {
        bool cont = true;

        while (cont == true) {
            // menu
            Console.WriteLine("Please choose an option from the menu:\n[1] Breathing Activity\n[2] Reflection Activity\n[3] Listing Activity\n[4] Quit");

            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 1) {
            //
            BreathingActivity breathing1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and breathign out slowly. Clear your mind and focus on your breathing.");
            breathing1.RunActivity();

            } else if (choice == 2) {
            //
            ReflectionActivity reflection1 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            reflection1.RunActivity();
            } else if (choice == 3) {
            //
            ListingActivity listing1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            listing1.RunActivity();
            } else if (choice == 4) {

            Console.WriteLine("Thank you for your time!");
            cont = false;
            }}
    }
}