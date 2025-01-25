'Tim Rossiter
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/rc-earnest/SimpleCalculator.git
Option Explicit On
Option Strict On

Module SimpleCalculator

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim choice As Integer
        Dim result As Integer

        'Gets users two numbers and converts the string input to an integer
        Console.WriteLine("Please provide two numbers.")
        Console.Write("What is your first number?: ")
        num1 = Integer.Parse(Console.ReadLine())
        Console.WriteLine()

        Console.Write("What is your second number?: ")
        num2 = Integer.Parse(Console.ReadLine())
        Console.WriteLine()

        'gets user input as to what operation that they would like to use
        Console.WriteLine("Choose an Operation:")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")
        Console.Write("Enter your choice (1 or 2): ")
        choice = Integer.Parse(Console.ReadLine())
        Console.WriteLine()

        'checks to see that they actually selected an option
        If choice = 1 Then
            result = num1 + num2
        ElseIf choice = 2 Then
            result = num1 * num2
        Else
            Console.WriteLine("Invalid Choice.")
            Return
        End If

        'displays result and pauses the console
        Console.Write($"Result: {result}")
        Console.ReadLine()
    End Sub

End Module
