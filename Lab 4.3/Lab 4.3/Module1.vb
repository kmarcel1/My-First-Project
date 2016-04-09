Module Module1

    Sub Main()
        'declare variables
        Dim clientName As String = ""
        Dim feetUTP As Double = 0
        Dim subTotal As Double = 0
        Dim taxCost As Double = 0
        Dim totalCost As Double = 0

        'get input
        inputData(clientName, feetUTP)

        'calculations
        calcCosts(subTotal, taxCost, totalCost, feetUTP)

        'Output
        displayBill(clientName, totalCost)

        'hard pause
        Console.WriteLine(" Press ENTER to continue...")
        Console.ReadLine()
    End Sub

    Sub inputData(ByRef clientName As String, ByRef feetUTP As Double)
        Console.Write("What is the client name: ")
        clientName = Console.ReadLine()
        Console.Write("How many feet of cable was installed? ")
        feetUTP = Console.ReadLine()
    End Sub

    Sub calcCosts(ByRef subTotal As Double, ByRef taxCost As Double, ByRef totalCost As Double, ByVal feetUTP As Double)
        subTotal = feetUTP * 0.21
        taxCost = subTotal * 0.06
        totalCost = subTotal + taxCost
    End Sub

    Sub displayBill(ByVal clientName As String, ByVal totalCost As Double)
        Console.WriteLine("The client name is " & clientName)
        Console.WriteLine("The total cost will be $" & totalCost)
    End Sub

End Module
