Imports System

Module Program
    Sub Main(args As String())
        While True
            Dim NumberToGuess As Integer = PickNumber()
            Dim GuessIt As String = GuessTheNumber(NumberToGuess)
            Console.WriteLine(GuessIt)
            Dim WannaPlayAgain As String = PlayAgain()

            If WannaPlayAgain = "Yes" Then
                Continue While
            End If

            Exit While
        End While
    End Sub

    Function PickNumber() As Integer
        Dim UserInput As Integer

        While True
            Try 'If UserInput is a String there will be an error so if that happens, the loop will continue
                Console.Write("Enter a number: ")
                UserInput = Console.ReadLine()

                If UserInput <= 0 Then 'If UserInput less than or equal to zero, the loop will continue
                    Continue While
                End If

                Exit While
            Catch ex As Exception
                Continue While
            End Try
        End While

        Return UserInput
    End Function

    Function GuessTheNumber(ByVal Number As Integer) As String
        Console.Write("Guess the number from 1 to {0}: ", CStr(Number))
        Dim UserInput As Integer
        Dim NumberToGuess As Integer = CInt(Math.Ceiling(Rnd() * Number))
        UserInput = Console.ReadLine()

        If UserInput = NumberToGuess Then
            Return "You Won"
        Else
            Return "You Lose"
        End If
    End Function

    Function PlayAgain() As String
        Dim YesOrNo As String
        Console.Write("Would you like to play again? Y/n: ")
        YesOrNo = Console.ReadLine()
        If YesOrNo = "yes" Or YesOrNo = "Yes" Or YesOrNo = "Y" Or YesOrNo = "y" Then
            Return "Yes"
        Else
            Return Nothing
        End If
    End Function


End Module
