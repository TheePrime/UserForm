Imports System.Windows.Forms.MonthCalendar

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim radius As Double = Double.Parse(TextBox1.Text)

        Dim circumfrence As Double = Math.Round(2 * Math.PI * radius, 3)
        Dim area As Double = Math.Round(Math.PI * radius * radius, 3)
        Label5.Text = area.ToString()
        Label6.Text = circumfrence.ToString()

    End Sub


End Class
