Public Class InformationDeckHospital
    Private Sub StudyDecksTxt_Click(sender As Object, e As EventArgs) Handles StudyDecksTxt.Click
        Me.Hide()
        StudyDecks.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Desktop_High_Fidelity1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As New System.Uri("http://maps.google.com")
        WebBrowser1.Navigate(url)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Sync.Show()
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

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Close()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        MessageBox.Show("Sorry, this feature is currently unavailable", "Manabu", _
          MessageBoxButtons.OKCancel)
    End Sub
End Class