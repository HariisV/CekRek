<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.historyTxt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'historyTxt
        '
        Me.historyTxt.AutoSize = True
        Me.historyTxt.Location = New System.Drawing.Point(32, 53)
        Me.historyTxt.Name = "historyTxt"
        Me.historyTxt.Size = New System.Drawing.Size(122, 25)
        Me.historyTxt.TabIndex = 0
        Me.historyTxt.Text = "- No History -"
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 494)
        Me.Controls.Add(Me.historyTxt)
        Me.Name = "History"
        Me.Text = "History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents historyTxt As Label
End Class
