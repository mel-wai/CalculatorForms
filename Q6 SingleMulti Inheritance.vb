Public Class BCA
    Public Sub Identify()
        Console.WriteLine("I am a Student.")
    End Sub
End Class

Public Class Subject
    Inherits BCA

    Public Sub SubA()
        Console.WriteLine("This is .Net programming")
    End Sub

    Public Sub SubB()
        Console.WriteLine("This is Visual Studio")
    End Sub
End Class

Public Class MainSub
    Inherits BCA

    Public Sub SubA()
        Console.WriteLine("Hello Everyone!")
    End Sub

    Public Sub SubB()
        Console.WriteLine("Let's do our Assignment.")
    End Sub

    Public Sub SubC()
        Console.WriteLine("Assignment Start.")
    End Sub
End Class

Module Module1
    Sub Main()
        Dim obj1 As New Subject()
        obj1.Identify()
        obj1.SubA()
        obj1.SubB()

        Dim obj2 As New MainSub()
        obj2.Identify()
        obj2.SubA()
        obj2.SubB()
        obj2.SubC()

        Console.ReadLine()
    End Sub
End Module