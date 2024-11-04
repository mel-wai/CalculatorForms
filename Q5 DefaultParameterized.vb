Module Module1
    Public Class Test
        Public value As String

        Public Sub New()
            value = "This is default constructor"
        End Sub

        Public Sub New(name As String)
            value = name
        End Sub

        Public Sub PrintName()
            Console.WriteLine(value)
        End Sub
    End Class
    Sub Main()
        Dim Test1 As New Test()
        Test1.PrintName()

        Dim Test2 As New Test("This is parameterized constructor")
        Test2.PrintName()

        Console.ReadLine()
    End Sub

End Module
