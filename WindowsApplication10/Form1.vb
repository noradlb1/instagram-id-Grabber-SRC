Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1
    Dim wb As New WebClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Grabid()
        Dim s As String = wb.DownloadString("https://www.instagram.com/" + HexTextBox2.Text)
        Dim id As String = Regex.Match(s, "profilePage_(.*?)""").Groups(1).Value
        HexTextBox1.Text = id
    End Sub

    Private Sub HexButton1_Click(sender As Object, e As EventArgs) Handles HexButton1.Click
        Grabid()
    End Sub
End Class
