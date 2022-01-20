Module SayMyName

    Sub Main()

        Dim userInput As String

        Console.WriteLine("Welcome to Skynet, What is your name?")
        userInput = Console.ReadLine()

        'show the user what they just typed 
        Console.WriteLine("Hello " & userInput & ", Welcome to the Skynet Automated Defense Network")

        'This puts a pause in the program until the user has an input
        Console.ReadLine()

        Console.WriteLine("")
    End Sub

End Module
