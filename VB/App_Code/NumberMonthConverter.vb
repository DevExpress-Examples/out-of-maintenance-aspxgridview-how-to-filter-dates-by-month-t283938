Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI


Public NotInheritable Class NumberMonthConverter

    Private Sub New()
    End Sub

    Private Shared Months As New List(Of Pair)() From { _
        New Pair("January", 1), _
        New Pair("Feburary", 2), _
        New Pair("March", 3), _
        New Pair("April", 4), _
        New Pair("May", 5), _
        New Pair("June", 6), _
        New Pair("July", 7), _
        New Pair("August", 8), _
        New Pair("September", 9), _
        New Pair("October", 10), _
        New Pair("November", 11), _
        New Pair("December", 12) _
    }
    Public Shared Function GetTitleOfMonth(ByVal numberOfMonth As Integer) As String
        For i As Integer = 0 To Months.Count - 1
            If numberOfMonth = Convert.ToInt32(Months(i).Second) Then
                Return Months(i).First.ToString()
            End If
        Next i
        Return String.Empty
    End Function
End Class