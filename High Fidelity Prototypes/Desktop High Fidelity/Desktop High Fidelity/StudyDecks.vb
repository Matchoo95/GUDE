Public Class StudyDecks

    Private Sub StudyDecksTxt_Click(sender As Object, e As EventArgs) Handles StudyDecksTxt.Click
        MessageBox.Show("You are already on the Study Decks page!", "Manabu", _
          MessageBoxButtons.OKCancel)
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FindDecksTxt_Click(sender As Object, e As EventArgs) Handles FindDecksTxt.Click
        Me.Hide()
        FindDecks.Show()
    End Sub

    Private Sub ViewMapTxt_Click(sender As Object, e As EventArgs) Handles ViewMapTxt.Click
        Me.Hide()
        ViewMap.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        Statistics.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Sync.Show()
    End Sub

    Private Sub StudyDecks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        StudyCard.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        StudyCard.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        StudyCard.Show()
    End Sub

    Private Sub AccountSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        Me.Hide()
        Settings.Hide()
    End Sub

    Private Sub EndToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ExportFlashcardsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportFlashcardsToolStripMenuItem.Click
        Me.Hide()
        SignIn.Hide()
    End Sub

    Private Sub ViewTutorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTutorialToolStripMenuItem.Click
        MessageBox.Show("Sorry, this feature is currently unavailable", "Manabu", _
          MessageBoxButtons.OKCancel)
    End Sub
End Class