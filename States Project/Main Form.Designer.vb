<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstGuess = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.tmrLimit = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.radMin = New System.Windows.Forms.RadioButton()
        Me.radNoLim = New System.Windows.Forms.RadioButton()
        Me.grpTime = New System.Windows.Forms.GroupBox()
        Me.tmrNoLimit = New System.Windows.Forms.Timer(Me.components)
        Me.mnuFileScores = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.grpTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(198, 189)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(121, 27)
        Me.btnNewGame.TabIndex = 3
        Me.btnNewGame.Text = "&New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(198, 238)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(121, 27)
        Me.btnCheck.TabIndex = 6
        Me.btnCheck.Text = "&Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(198, 287)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstGuess
        '
        Me.lstGuess.FormattingEnabled = True
        Me.lstGuess.ItemHeight = 15
        Me.lstGuess.Location = New System.Drawing.Point(12, 169)
        Me.lstGuess.Name = "lstGuess"
        Me.lstGuess.Size = New System.Drawing.Size(133, 154)
        Me.lstGuess.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Gueses"
        '
        'txtState
        '
        Me.txtState.Enabled = False
        Me.txtState.Location = New System.Drawing.Point(12, 104)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 23)
        Me.txtState.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "State &Guess"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Progress:"
        '
        'lblProgress
        '
        Me.lblProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProgress.Location = New System.Drawing.Point(73, 339)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(82, 25)
        Me.lblProgress.TabIndex = 8
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrLimit
        '
        Me.tmrLimit.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTime.Location = New System.Drawing.Point(6, 100)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(89, 23)
        Me.lblTime.TabIndex = 9
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Timer:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(361, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit, Me.mnuFileSave, Me.mnuFileInfo, Me.mnuFileScores})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileInfo
        '
        Me.mnuFileInfo.Name = "mnuFileInfo"
        Me.mnuFileInfo.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileInfo.Text = "&Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "&Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 23)
        Me.txtName.TabIndex = 1
        '
        'radMin
        '
        Me.radMin.AutoSize = True
        Me.radMin.Checked = True
        Me.radMin.Location = New System.Drawing.Point(6, 22)
        Me.radMin.Name = "radMin"
        Me.radMin.Size = New System.Drawing.Size(87, 19)
        Me.radMin.TabIndex = 0
        Me.radMin.TabStop = True
        Me.radMin.Text = "10 &Mintutes"
        Me.radMin.UseVisualStyleBackColor = True
        '
        'radNoLim
        '
        Me.radNoLim.AutoSize = True
        Me.radNoLim.Location = New System.Drawing.Point(6, 46)
        Me.radNoLim.Name = "radNoLim"
        Me.radNoLim.Size = New System.Drawing.Size(101, 19)
        Me.radNoLim.TabIndex = 1
        Me.radNoLim.Text = "No Time &Limit"
        Me.radNoLim.UseVisualStyleBackColor = True
        '
        'grpTime
        '
        Me.grpTime.Controls.Add(Me.radMin)
        Me.grpTime.Controls.Add(Me.radNoLim)
        Me.grpTime.Controls.Add(Me.lblTime)
        Me.grpTime.Controls.Add(Me.Label4)
        Me.grpTime.Location = New System.Drawing.Point(198, 27)
        Me.grpTime.Name = "grpTime"
        Me.grpTime.Size = New System.Drawing.Size(121, 145)
        Me.grpTime.TabIndex = 2
        Me.grpTime.TabStop = False
        Me.grpTime.Text = "Time"
        '
        'tmrNoLimit
        '
        '
        'mnuFileScores
        '
        Me.mnuFileScores.Name = "mnuFileScores"
        Me.mnuFileScores.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileScores.Text = "Sco&res"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 382)
        Me.Controls.Add(Me.grpTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstGuess)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "States Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpTime.ResumeLayout(False)
        Me.grpTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewGame As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstGuess As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblProgress As Label
    Friend WithEvents tmrLimit As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileInfo As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents radMin As RadioButton
    Friend WithEvents radNoLim As RadioButton
    Friend WithEvents grpTime As GroupBox
    Friend WithEvents tmrNoLimit As Timer
    Friend WithEvents mnuFileScores As ToolStripMenuItem
End Class
