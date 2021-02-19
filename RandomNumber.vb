'Spencer Gilchrist
'RCET 0265
'2-18-21
'Roll of the dice


Module RandomNumber

    Sub Main()
        Dim RandomNumbers(10) As Integer

        For i = 1 To 1000
            RandomNumbers(GetRandomNumber(11)) += 1
        Next

        Console.WriteLine("                                Random Numbers!")
        Console.WriteLine(StrDup(77, "-"))
        'This is just formatting ^^^^
        For i = 2 To 12
            Console.Write(Str(i).PadLeft(6) & "|")
            'This For loop sets up the top row form 1 to 12
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(77, "-"))
        'This is just formatting ^^^^
        For i = 0 To UBound(RandomNumbers)
            Console.Write(CStr(RandomNumbers(i)).PadLeft(6) & "|")
            'This for loop is our bottom numbers that are "random"
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(77, "-"))
        'This is just formatting ^^^^
        Console.ReadLine()

    End Sub

    Function GetRandomNumber(MaxNumber As Integer) As Integer
        Randomize()
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        FirstNumber = CInt(Int((6 * Rnd() * +1)))
        SecondNumber = CInt(Int((6 * Rnd() * +1)))
        Return (FirstNumber + SecondNumber)
    End Function

End Module
