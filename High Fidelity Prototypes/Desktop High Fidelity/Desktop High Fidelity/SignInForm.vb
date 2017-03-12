Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel

Public Class SignInForm


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub DisplayLanguageCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayLanguageCombo.SelectedIndexChanged

    End Sub

    Private Sub SignInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLanguageCombo.Items.Add("English")
        DisplayLanguageCombo.Items.Add("Japanese")
        DisplayLanguageCombo.SelectedIndex = 0
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If DisplayLanguageCombo.SelectedItem.ToString() = "English" Then
            ChangeLanguage("en")
        Else 
            ChangeLanguage("jp-JP")
        End If
    End Sub

    Private Sub ChangeLanguage(ByVal lang As String)
        For Each c As Control In Me.Controls
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(SignInForm))
            resources.ApplyResources(c, c.Name, New CultureInfo(lang))
        Next c
    End Sub

End Class
