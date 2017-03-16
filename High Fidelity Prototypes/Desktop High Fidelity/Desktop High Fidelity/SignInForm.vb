Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel

Public Class SignInForm

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

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If usernameSignInTxt.Text = "gude" And passwordSignInTxt.Text = "12345" Then
            FindDecks.Show()
        Else
            MsgBox("Sorry, Username or Password is incorrect", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class
