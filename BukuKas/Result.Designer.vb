<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hasil
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ewallet = New System.Windows.Forms.Label()
        Me.norek = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bank / e-Wallet"
        '
        'ewallet
        '
        Me.ewallet.AutoSize = True
        Me.ewallet.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ewallet.Location = New System.Drawing.Point(64, 81)
        Me.ewallet.Name = "ewallet"
        Me.ewallet.Size = New System.Drawing.Size(101, 38)
        Me.ewallet.TabIndex = 1
        Me.ewallet.Text = "Gopay"
        '
        'norek
        '
        Me.norek.AutoSize = True
        Me.norek.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.norek.Location = New System.Drawing.Point(64, 173)
        Me.norek.Name = "norek"
        Me.norek.Size = New System.Drawing.Size(101, 38)
        Me.norek.TabIndex = 3
        Me.norek.Text = "Gopay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nomor Rekening"
        '
        'name
        '
        Me.name.AutoSize = True
        Me.name.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.name.Location = New System.Drawing.Point(64, 264)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(101, 38)
        Me.name.TabIndex = 5
        Me.name.Text = "Gopay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nama Pemilik"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Hasil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 494)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.norek)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ewallet)
        Me.Controls.Add(Me.Label1)
        Me.Text = "Result"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ewallet As Label
    Friend WithEvents norek As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents name As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
End Class
