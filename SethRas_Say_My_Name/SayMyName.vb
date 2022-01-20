'Seth Nieslen Rasmussen
'RCET0265
'Spring 2022
'Say My Name

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        'Declare UserInput as a variable that the code will read
        Dim userInput As String

        'Upon running the program this line will prompt the user to input their name
        Console.WriteLine("Welcome to Skynet, What is your name?")
        userInput = Console.ReadLine()

        'show the user what they just typed with a greeting
        Console.WriteLine("Hello " & userInput & ", Welcome to the Skynet Automated Defense Network")

        'This puts a pause in the program until the user has an input
        Console.ReadLine()

    End Sub

End Module
