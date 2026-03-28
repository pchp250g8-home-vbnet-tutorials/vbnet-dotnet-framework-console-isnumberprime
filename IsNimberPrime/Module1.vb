Module Module1

    Sub Main()
        Dim ulNumber As ULong
        Console.WriteLine("Input an integer positive number")
        ULong.TryParse(Console.ReadLine(), ulNumber)
        Console.WriteLine($"The number {ulNumber} has the folowing divisors:")
        Dim nDividers = 0
        For i As ULong = 1 To ulNumber
            If (ulNumber Mod i = 0) Then
                Console.Write("{0} ", i)
                nDividers += 1
            End If
        Next
        Console.WriteLine()
        Select Case nDividers
            Case 0, 1
                Console.WriteLine($"The number {ulNumber} is neither composite nor prime")
            Case 2
                Console.WriteLine($"The number {ulNumber} is prime")
            Case Else
                Console.WriteLine($"The number {ulNumber} is composite")
        End Select
        Console.Read()
    End Sub

End Module
