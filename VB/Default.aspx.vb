Imports DevExpress.Data.Filtering
Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub ASPxGridView1_AutoFilterCellEditorCreate(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewEditorCreateEventArgs)
        If e.Column.FieldName <> "Month" Then
            Return
        End If
        Dim comboBoxProp As New ComboBoxProperties()
        e.EditorProperties = comboBoxProp
    End Sub
    Protected Sub ASPxGridView1_AutoFilterCellEditorInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewEditorEventArgs)
        If e.Column.FieldName <> "Month" Then
            Return
        End If
        Dim comboBox As ASPxComboBox = TryCast(e.Editor, ASPxComboBox)
        comboBox.ValueType = GetType(String)
        For i As Integer = 1 To 12
            comboBox.Items.Add(NumberMonthConverter.GetTitleOfMonth(i), i)
        Next i
    End Sub
    Protected Sub ASPxGridView1_ProcessColumnAutoFilter(ByVal sender As Object, ByVal e As ASPxGridViewAutoFilterEventArgs)
        If e.Column.FieldName <> "Month" Then
            Return
        End If
        If e.Kind = GridViewAutoFilterEventKind.CreateCriteria Then
            e.Criteria = New BinaryOperator(e.Column.FieldName, e.Value, BinaryOperatorType.Equal)
        Else
            If e.Value <> String.Empty Then
                e.Value = NumberMonthConverter.GetTitleOfMonth(Convert.ToInt32(e.Value))
            End If
        End If
    End Sub
    Protected Sub ASPxGridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As ASPxGridViewColumnDataEventArgs)
        If e.Column.FieldName <> "Month" Then
            Return
        End If
        Dim tempDate As Date = CDate(e.GetListSourceFieldValue("OrderDate"))
        e.Value = tempDate.Month
    End Sub
    Protected Sub ASPxGridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As ASPxGridViewColumnDisplayTextEventArgs)
        If e.Column.FieldName <> "Month" Then
            Return
        End If
        e.DisplayText = e.GetFieldValue("OrderDate").ToString()
    End Sub
    Protected Sub ASPxGridView1_HeaderFilterFillItems(ByVal sender As Object, ByVal e As ASPxGridViewHeaderFilterEventArgs)
        If e.Column.FieldName <> "Month" Then
            Return
        End If
        e.Values.Clear()
        For i As Integer = 1 To 12
            e.AddValue(NumberMonthConverter.GetTitleOfMonth(i), i.ToString())
        Next i
    End Sub
End Class
