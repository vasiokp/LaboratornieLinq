Friend Module BaseModule

    Sub Main()
        Dim arr As List(Of UserInfo)
        Console.WriteLine("Варіант1")
        Dim user As UserInfo
        arr = New List(Of UserInfo)

        For index = 1 To 5
            user = New UserInfo
            Console.WriteLine("firstname")
            user.FirstName = Console.ReadLine()

            Console.WriteLine("Lastname")
            user.LastName = Console.ReadLine()
            arr.Add(user)
        Next
        Dim b = From person In arr
                Group By person.FirstName Into Count()
        Dim mostPopularName = b.Where(Function(d) d.Count = b.Max(Function(s) s.Count
                                        )).FirstOrDefault()

        Console.Write("Most popular name: ")
        Console.Write(mostPopularName.FirstName)






        Console.ReadLine()


    End Sub

    'Function Variant1() As List(Of UserInfo)

    '    Return

    'End Function

    Public Class UserInfo
        Public LastName As String
        Public FirstName As String
    End Class



End Module
