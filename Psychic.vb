Option Strict On
Option Explicit On
Module Psychic

    Sub Main()
        Randomize()
        Do
            Dim ligma As Integer
            Dim nums(9) As Integer
            Dim strs(9) As String
            Dim i As Single
            Dim j As Single
            Dim newVal As Single
            Dim randomnumber As Integer
            Console.WriteLine("Choose one number from the following number stream.. Watch closely")
            Threading.Thread.Sleep(3000)
            For bruh = 0 To 9
                nums(bruh) = bruh + 1
            Next

            For i = 0 To 9
                j = Int((9 - i + 1) * Rnd() + i)
                newVal = nums(CInt(i))
                nums(CInt(i)) = nums(CInt(j))
                nums(CInt(j)) = CInt(newVal)
            Next
            randomnumber = GetRandomNumber(1, 10)
            Console.ForegroundColor = ConsoleColor.Black
            For i = 0 To 9
                Console.Clear()
                strs(CInt(i)) &= CStr(nums(CInt(i)))
                If CInt(strs(CInt(i))) = randomnumber Then
                    Console.BackgroundColor = ConsoleColor.Red
                    Console.WriteLine(strs(CInt(i)))
                    Threading.Thread.Sleep(200)
                    GoTo poop
                Else
                    ligma = GetRandomNumber(1, 5)
                    Select Case ligma
                        Case 1
                            Console.BackgroundColor = ConsoleColor.Blue
                        Case 2
                            Console.BackgroundColor = ConsoleColor.Green
                        Case 3
                            Console.BackgroundColor = ConsoleColor.Magenta
                        Case 4
                            Console.BackgroundColor = ConsoleColor.Yellow
                        Case 5
                            Console.BackgroundColor = ConsoleColor.Gray
                    End Select
                End If
                Console.Write(strs(CInt(i)))
                Threading.Thread.Sleep(50)
poop:
                Console.BackgroundColor = ConsoleColor.Black
            Next
            Console.ForegroundColor = ConsoleColor.White
            Console.Clear()
            Console.WriteLine("Your number is....")
            Threading.Thread.Sleep(3000)
            Console.WriteLine(randomnumber)
            Console.ReadLine()
            Erase strs
            Erase nums
        Loop
    End Sub
    Function GetRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer) As Integer


        Dim value As Double


        Do
            value = (maximum * Rnd()) + 0.5

        Loop While value < minimum - 0.5 Or value >= maximum + 0.5


        Return CInt(value)
    End Function

End Module
