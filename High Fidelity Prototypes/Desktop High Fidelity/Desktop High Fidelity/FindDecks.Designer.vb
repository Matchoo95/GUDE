<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindDecks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StudyDecksTxt = New System.Windows.Forms.Button()
        Me.FindDecksTxt = New System.Windows.Forms.Button()
        Me.ViewMapTxt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StudyDecksTxt
        '
        Me.StudyDecksTxt.Location = New System.Drawing.Point(379, 12)
        Me.StudyDecksTxt.Name = "StudyDecksTxt"
        Me.StudyDecksTxt.Size = New System.Drawing.Size(95, 31)
        Me.StudyDecksTxt.TabIndex = 0
        Me.StudyDecksTxt.Text = "Study Decks"
        Me.StudyDecksTxt.UseVisualStyleBackColor = True
        '
        'FindDecksTxt
        '
        Me.FindDecksTxt.Location = New System.Drawing.Point(531, 12)
        Me.FindDecksTxt.Name = "FindDecksTxt"
        Me.FindDecksTxt.Size = New System.Drawing.Size(95, 31)
        Me.FindDecksTxt.TabIndex = 1
        Me.FindDecksTxt.Text = "Find Decks"
        Me.FindDecksTxt.UseVisualStyleBackColor = True
        '
        'ViewMapTxt
        '
        Me.ViewMapTxt.Location = New System.Drawing.Point(691, 12)
        Me.ViewMapTxt.Name = "ViewMapTxt"
        Me.ViewMapTxt.Size = New System.Drawing.Size(95, 31)
        Me.ViewMapTxt.TabIndex = 2
        Me.ViewMapTxt.Text = "View Map"
        Me.ViewMapTxt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Flashcard decks near you"
        '
        'FindDecks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 773)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ViewMapTxt)
        Me.Controls.Add(Me.FindDecksTxt)
        Me.Controls.Add(Me.StudyDecksTxt)
        Me.Name = "FindDecks"
        Me.Text = "Find Decks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudyDecksTxt As System.Windows.Forms.Button
    Friend WithEvents FindDecksTxt As System.Windows.Forms.Button
    Friend WithEvents ViewMapTxt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
