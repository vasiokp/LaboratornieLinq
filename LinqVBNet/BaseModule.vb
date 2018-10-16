Friend Module BaseModule

    Sub Main()
        Dim arr As List(Of UserInfo)
        Console.WriteLine("Варіант1")
        Dim user As UserInfo
        arr = New List(Of UserInfo)

        For index = 1 To 3
            user = New UserInfo
            Console.WriteLine("firstname")
            user.FistName = Console.ReadLine()

            Console.WriteLine("Lastname")
            user.FistName = Console.ReadLine()
            arr.Add(user)
        Next
        Console.ReadLine()
        For index = 0 To arr.Count - 1
            Console.WriteLine("firstname")
            Console.WriteLine(arr(index).FistName)
        Next
        Console.ReadLine()


    End Sub

    'Function Variant1() As List(Of UserInfo)

    '    Return

    'End Function

    Public Class UserInfo
        Public LastName As String
        Public FistName As String
    End Class



End Module
