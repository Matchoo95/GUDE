Public Class Sync

    Private Sub Sync_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            MsgBox("Manabu has finished syncing. Click okay to close.", MsgBoxStyle.Exclamation)
            Me.Hide()
        End If
        Label1.Text = ProgressBar1.Value & (" %")
    End Sub
End Class