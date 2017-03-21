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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindDecks))
        Me.StudyDecksTxt = New System.Windows.Forms.Button()
        Me.FindDecksTxt = New System.Windows.Forms.Button()
        Me.ViewMapTxt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportFlashcardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudyDecksTxt
        '
        Me.StudyDecksTxt.Location = New System.Drawing.Point(357, 39)
        Me.StudyDecksTxt.Name = "StudyDecksTxt"
        Me.StudyDecksTxt.Size = New System.Drawing.Size(131, 41)
        Me.StudyDecksTxt.TabIndex = 0
        Me.StudyDecksTxt.Text = "Study Decks"
        Me.StudyDecksTxt.UseVisualStyleBackColor = True
        '
        'FindDecksTxt
        '
        Me.FindDecksTxt.Location = New System.Drawing.Point(511, 39)
        Me.FindDecksTxt.Name = "FindDecksTxt"
        Me.FindDecksTxt.Size = New System.Drawing.Size(131, 41)
        Me.FindDecksTxt.TabIndex = 1
        Me.FindDecksTxt.Text = "Find Decks"
        Me.FindDecksTxt.UseVisualStyleBackColor = True
        '
        'ViewMapTxt
        '
        Me.ViewMapTxt.Location = New System.Drawing.Point(669, 39)
        Me.ViewMapTxt.Name = "ViewMapTxt"
        Me.ViewMapTxt.Size = New System.Drawing.Size(131, 41)
        Me.ViewMapTxt.TabIndex = 2
        Me.ViewMapTxt.Text = "View Map"
        Me.ViewMapTxt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(369, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Flashcard decks near you"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1178, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportFlashcardsToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.MenuToolStripMenuItem.Text = "File"
        '
        'ExportFlashcardsToolStripMenuItem
        '
        Me.ExportFlashcardsToolStripMenuItem.Name = "ExportFlashcardsToolStripMenuItem"
        Me.ExportFlashcardsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ExportFlashcardsToolStripMenuItem.Text = "Switch Account"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EndToolStripMenuItem.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountSettingsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AccountSettingsToolStripMenuItem
        '
        Me.AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem"
        Me.AccountSettingsToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AccountSettingsToolStripMenuItem.Text = "Account and Language Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewTutorialToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewTutorialToolStripMenuItem
        '
        Me.ViewTutorialToolStripMenuItem.Name = "ViewTutorialToolStripMenuItem"
        Me.ViewTutorialToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ViewTutorialToolStripMenuItem.Text = "View Tutorial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(615, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Click an arrow to view a map and directions to a flashcard deck"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(371, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Deck List"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(422, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "At the Hospital"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(422, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "At University"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(778, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Locked! (Level 20+)"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(703, 297)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(703, 347)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(703, 398)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(422, 407)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Find Decks via Map"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(1058, 39)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1115, 39)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 19
        Me.PictureBox8.TabStop = False
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(0, 104)
        Me.Label10.MaximumSize = New System.Drawing.Size(5000, 2)
        Me.Label10.MinimumSize = New System.Drawing.Size(5000, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(5000, 2)
        Me.Label10.TabIndex = 20
        '
        'FindDecks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 493)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ViewMapTxt)
        Me.Controls.Add(Me.FindDecksTxt)
        Me.Controls.Add(Me.StudyDecksTxt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FindDecks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manabu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudyDecksTxt As System.Windows.Forms.Button
    Friend WithEvents FindDecksTxt As System.Windows.Forms.Button
    Friend WithEvents ViewMapTxt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportFlashcardsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTutorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
