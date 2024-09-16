
using System;
using System.Xml.Schema;
using Microsoft.VisualBasic;

public class TaskController{

    //CASE 1: 
    //Check the program individual price with the given age in the user input
    public void showProgramPriceByAge(){
        int age = getAgeFromUser();
        if (age <= 5 || age >= 100)
        {
            Console.WriteLine("It's free for below 5 and above 100 years old");
        }
        else if (age <= 20){
            Console.WriteLine("Youth price: 80kr\n");
        }
        else if (age >= 64){
            Console.WriteLine("Senoir person price: 90kr\n");
        }
        else{
            Console.WriteLine("Adult price: 120kr\n");
        }
    }
    private int getAgeFromUser(){
        Console.WriteLine("Check the program price by entering your age below");
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        return age;
    }

    //CASE 2:
    //Calculate and display the total price for the group of persons that value have entered in the user input
    public void calculateTotalPrice()
    {
        //GET THE USER INPUT
        Console.WriteLine("Calculate the total price");
        Console.WriteLine("Enter the total no.of.person: ");
        int count = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the age respectively:");
        List<int> ages = new List<int>();
        for(int i=0; i<count ; i++)
        {
            string ageNumber = Console.ReadLine();
            if (int.TryParse(ageNumber, out int age))
            {
                ages.Add(age); 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--;
            }
        }
        int calculatePrice = totalPriceForTheGroup(ages);
        Console.WriteLine("Total No.of.Persons:"+ count);
        Console.WriteLine("Total Price for " +count+ " persons: "+calculatePrice+ "kr\n");
    }

    private int totalPriceForTheGroup(List<int> ages)
    {
        int calculateTotalPrice = 0;
        foreach (int age in ages)
        {
            calculateTotalPrice += totalPriceByAge(age);
        }
        return calculateTotalPrice;
    }
    
    //Return the price with age apporapiate
    private int totalPriceByAge(int age)
    {
        if ( age <= 5 ) // below 5 years old price
        {
             return 0;
        }
        else if ( age >= 100)//above 100 years old price
        {
            return 0;
        }
        else if ( age <= 20 )//youth price 
        {
            return 80;
        }
        else if ( age >= 64)// senior price
        {
            return 90;
        }
        else //adult price
        {
            return 120;
        }
    }

    //CASE 3:
    //Get and display the text ten times which is entered by the user using for loop to iterate the text
    public void loopIteration()
    {
        Console.WriteLine("REPEATING TEXT");
        Console.WriteLine("Enter the text to be print:");
        var text = Console.ReadLine();
        for (int i = 1 ; i <= 10 ; i++)
        {
            Console.Write(i+". "+text);
            if(i == 10)Console.Write(".");
            else Console.Write(",");
        }
        Console.WriteLine("\n");
    }


    //CASE 4:
    //Get the sentence from the user and print the third word from the given sentence
    public void fetchThirdWord()
    {
        //GET THE USER INPUT AS SENTENCE
        Console.WriteLine("FETCH THIRD WORD");
        Console.WriteLine("Enter the sentence:");
        var inputLines = Console.ReadLine();
        string[] sentences = inputLines.Split(" ");

        int n = sentences.Length;
        Console.WriteLine(n);   
        validateNoOfWords(n);


        for (int i = 0; i < n; i++)
        {
            if (i == 2) {
                Console.WriteLine("Third word from the sentence:"+sentences[i]);
            }
            else{
                continue;
            }
        }
        
    }

    //check if the words are present with minimum required
    private void validateNoOfWords(int wordsCount)
    {
        try{
            if (wordsCount < 3) {
                Console.WriteLine("Sentences should contain atleast 3 words");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Log error:",e.Message);
        }
        
    }
}