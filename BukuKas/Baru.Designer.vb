<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Baru
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
        Me.no_rek = New System.Windows.Forms.TextBox()
        Me.bank = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'no_rek
        '
        Me.no_rek.Location = New System.Drawing.Point(64, 205)
        Me.no_rek.Name = "no_rek"
        Me.no_rek.Size = New System.Drawing.Size(310, 31)
        Me.no_rek.TabIndex = 0
        '
        'bank
        '
        Me.bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bank.FormattingEnabled = True
        Me.bank.Items.AddRange(New Object() {"BCA", "Blu By BCA", "BNI", "BRI", "Mandiri", "CIMB Niaga", "Permata", "Danamon", "Bank DKI", "BTPN/Jenius", "Bank NOBU", "Bank Jago", "Line Bank", "LinkAja!", "GoPay", "OVO", "DANA"})
        Me.bank.Location = New System.Drawing.Point(64, 120)
        Me.bank.Name = "bank"
        Me.bank.Size = New System.Drawing.Size(310, 33)
        Me.bank.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bank / e-Wallet "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Account Number"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(64, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contoh : Bank 8000904991 | e-wallet: 082299933362"
        '
        'Baru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 494)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bank)
        Me.Controls.Add(Me.no_rek)
        Me.Name = "Baru"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Baru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents no_rek As TextBox
    Friend WithEvents bank As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
