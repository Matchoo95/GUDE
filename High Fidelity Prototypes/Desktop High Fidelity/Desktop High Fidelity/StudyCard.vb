Public Class StudyCard

    Private Sub StudyDecksTxt_Click(sender As Object, e As EventArgs) Handles StudyDecksTxt.Click
        MessageBox.Show("You are already on the Study Decks page!", "Manabu", _
          MessageBoxButtons.OKCancel)
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FindDecksTxt_Click(sender As Object, e As EventArgs) Handles FindDecksTxt.Click
        FindDecks.Show()
    End Sub

    Private Sub ViewMapTxt_Click(sender As Object, e As EventArgs) Handles ViewMapTxt.Click
        ViewMap.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Statistics.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Sync.Show()
    End Sub

    Private Sub StudyDecks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label3.Visible = False
        Label13.Visible = False
        Skip.Visible = False
        Again.Visible = False
        Good.Visible = False
        Easy.Visible = False
        Label6.Visible = False

        Label22.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label14.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label6.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label3.Visible = True
        Label13.Visible = True
        Skip.Visible = True
        Again.Visible = True
        Good.Visible = True
        Easy.Visible = True
        Label6.Visible = True
    End Sub

    Private Sub Again_Click(sender As Object, e As EventArgs) Handles Again.Click
        Label22.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label14.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
    End Sub

    Private Sub Good_Click(sender As Object, e As EventArgs) Handles Good.Click
        Label22.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label14.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
    End Sub

    Private Sub Easy_Click(sender As Object, e As EventArgs) Handles Easy.Click
        Label22.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label14.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
    End Sub

    Private Sub Skip_Click(sender As Object, e As EventArgs) Handles Skip.Click
        Label22.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label14.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
    End Sub
End Class