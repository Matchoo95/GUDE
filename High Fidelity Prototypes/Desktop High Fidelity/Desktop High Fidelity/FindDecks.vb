Public Class FindDecks

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        InformationDeckHospital.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        InformationDeckHospital.Show()
    End Sub

    Private Sub FindDecksTxt_Click(sender As Object, e As EventArgs) Handles FindDecksTxt.Click
        MessageBox.Show("You are already on the Find a Decks page!", "Manabu", _
          MessageBoxButtons.OKCancel)
    End Sub

    Private Sub ViewMapTxt_Click(sender As Object, e As EventArgs) Handles ViewMapTxt.Click
        Me.Hide()
        ViewMap.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MessageBox.Show("Sorry, this flashcard deck is currently locked. Please reach level 20 first! For more level statistics see the graph page by clicking the pie chart in the top right hand corner.", "Manabu", _
           MessageBoxButtons.OKCancel)
    End Sub

    Private Sub FindDecks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Sync.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        Statistics.Show()
    End Sub

    Private Sub AccountSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MessageBox.Show("Sorry, this flashcard deck is currently locked. Please reach level 20 first! For more level statistics see the graph page by clicking the pie chart in the top right hand corner.", "Manabu", _
           MessageBoxButtons.OKCancel)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        MessageBox.Show("Sorry, this flashcard deck is currently locked. Please reach level 20 first! For more level statistics see the graph page by clicking the pie chart in the top right hand corner.", "Manabu", _
           MessageBoxButtons.OKCancel)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        ViewMap.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        ViewMap.Show()
    End Sub

    Private Sub ExportFlashcardsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportFlashcardsToolStripMenuItem.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ViewTutorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTutorialToolStripMenuItem.Click
        MessageBox.Show("Sorry, this feature is currently unavailable", "Manabu", _
          MessageBoxButtons.OKCancel)
    End Sub

    Private Sub StudyDecksTxt_Click(sender As Object, e As EventArgs) Handles StudyDecksTxt.Click
        Me.Hide()
        StudyDecks.Show()
    End Sub
End Class