<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSelectNumber = New System.Windows.Forms.ComboBox()
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.lbxResult = New System.Windows.Forms.ListBox()
        Me.lblRollCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many doubles do you need?"
        '
        'cbSelectNumber
        '
        Me.cbSelectNumber.FormattingEnabled = True
        Me.cbSelectNumber.Location = New System.Drawing.Point(16, 30)
        Me.cbSelectNumber.Name = "cbSelectNumber"
        Me.cbSelectNumber.Size = New System.Drawing.Size(121, 21)
        Me.cbSelectNumber.TabIndex = 1
        '
        'btnRollDice
        '
        Me.btnRollDice.Location = New System.Drawing.Point(12, 390)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(75, 23)
        Me.btnRollDice.TabIndex = 2
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'lbxResult
        '
        Me.lbxResult.FormattingEnabled = True
        Me.lbxResult.Location = New System.Drawing.Point(184, 19)
        Me.lbxResult.Name = "lbxResult"
        Me.lbxResult.Size = New System.Drawing.Size(156, 394)
        Me.lbxResult.TabIndex = 3
        '
        'lblRollCount
        '
        Me.lblRollCount.Location = New System.Drawing.Point(16, 146)
        Me.lblRollCount.Name = "lblRollCount"
        Me.lblRollCount.Size = New System.Drawing.Size(140, 157)
        Me.lblRollCount.TabIndex = 4
        Me.lblRollCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 425)
        Me.Controls.Add(Me.lblRollCount)
        Me.Controls.Add(Me.lbxResult)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.cbSelectNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbSelectNumber As System.Windows.Forms.ComboBox
    Friend WithEvents btnRollDice As System.Windows.Forms.Button
    Friend WithEvents lbxResult As System.Windows.Forms.ListBox
    Friend WithEvents lblRollCount As System.Windows.Forms.Label

End Class
