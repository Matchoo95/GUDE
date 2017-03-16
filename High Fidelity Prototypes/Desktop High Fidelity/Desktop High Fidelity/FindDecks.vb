Public Class FindDecks

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        InformationDeckHospital.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        InformationDeckHospital.Show()
    End Sub

    Private Sub FindDecksTxt_Click(sender As Object, e As EventArgs) Handles FindDecksTxt.Click
        Me.Show()
    End Sub

    Private Sub ViewMapTxt_Click(sender As Object, e As EventArgs) Handles ViewMapTxt.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MessageBox.Show("Sorry, this flashcard deck is currently locked. Please reach level 20 first! For more level statistics see the graph page by clicking the pie chart in the top right hand corner.", "Manabu", _
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub
End Class