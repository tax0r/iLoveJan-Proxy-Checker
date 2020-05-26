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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ThirteenForm1 = New iLoveJan_Proxy_Checker.ThirteenForm()
        Me.ThirteenCheckBox1 = New iLoveJan_Proxy_Checker.ThirteenCheckBox()
        Me.dead = New System.Windows.Forms.Label()
        Me.alive = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.timeoutTextBox = New iLoveJan_Proxy_Checker.ThirteenTextBox()
        Me.boolState = New System.Windows.Forms.Label()
        Me.ThirteenButton2 = New iLoveJan_Proxy_Checker.ThirteenButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProxyType = New iLoveJan_Proxy_Checker.ThirteenComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ThirteenButton1 = New iLoveJan_Proxy_Checker.ThirteenButton()
        Me.ProxylistTextBox = New iLoveJan_Proxy_Checker.ThirteenTextBox()
        Me.ThirteenControlBox1 = New iLoveJan_Proxy_Checker.ThirteenControlBox()
        Me.exportBool = New System.Windows.Forms.Label()
        Me.ThirteenForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ThirteenForm1
        '
        Me.ThirteenForm1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenForm1.ColorScheme = iLoveJan_Proxy_Checker.ThirteenForm.ColorSchemes.Dark
        Me.ThirteenForm1.Controls.Add(Me.exportBool)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenCheckBox1)
        Me.ThirteenForm1.Controls.Add(Me.dead)
        Me.ThirteenForm1.Controls.Add(Me.alive)
        Me.ThirteenForm1.Controls.Add(Me.Label4)
        Me.ThirteenForm1.Controls.Add(Me.timeoutTextBox)
        Me.ThirteenForm1.Controls.Add(Me.boolState)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton2)
        Me.ThirteenForm1.Controls.Add(Me.Label3)
        Me.ThirteenForm1.Controls.Add(Me.Label2)
        Me.ThirteenForm1.Controls.Add(Me.ProxyType)
        Me.ThirteenForm1.Controls.Add(Me.Label1)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton1)
        Me.ThirteenForm1.Controls.Add(Me.ProxylistTextBox)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenControlBox1)
        Me.ThirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThirteenForm1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenForm1.ForeColor = System.Drawing.Color.White
        Me.ThirteenForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThirteenForm1.Name = "ThirteenForm1"
        Me.ThirteenForm1.Size = New System.Drawing.Size(401, 411)
        Me.ThirteenForm1.TabIndex = 0
        Me.ThirteenForm1.Text = "Proxy Checker by iLoveJan"
        '
        'ThirteenCheckBox1
        '
        Me.ThirteenCheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenCheckBox1.Checked = True
        Me.ThirteenCheckBox1.ColorScheme = iLoveJan_Proxy_Checker.ThirteenCheckBox.ColorSchemes.Dark
        Me.ThirteenCheckBox1.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox1.Location = New System.Drawing.Point(227, 136)
        Me.ThirteenCheckBox1.Name = "ThirteenCheckBox1"
        Me.ThirteenCheckBox1.Size = New System.Drawing.Size(86, 17)
        Me.ThirteenCheckBox1.TabIndex = 13
        Me.ThirteenCheckBox1.Text = "Auto-Export"
        '
        'dead
        '
        Me.dead.AutoSize = True
        Me.dead.Location = New System.Drawing.Point(224, 116)
        Me.dead.Name = "dead"
        Me.dead.Size = New System.Drawing.Size(41, 17)
        Me.dead.TabIndex = 12
        Me.dead.Text = "Dead:"
        '
        'alive
        '
        Me.alive.AutoSize = True
        Me.alive.Location = New System.Drawing.Point(224, 99)
        Me.alive.Name = "alive"
        Me.alive.Size = New System.Drawing.Size(42, 17)
        Me.alive.TabIndex = 11
        Me.alive.Text = "Alive: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "(Timeout)"
        '
        'timeoutTextBox
        '
        Me.timeoutTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.timeoutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timeoutTextBox.ColorScheme = iLoveJan_Proxy_Checker.ThirteenTextBox.ColorSchemes.Dark
        Me.timeoutTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.timeoutTextBox.ForeColor = System.Drawing.Color.White
        Me.timeoutTextBox.Location = New System.Drawing.Point(118, 68)
        Me.timeoutTextBox.Name = "timeoutTextBox"
        Me.timeoutTextBox.Size = New System.Drawing.Size(100, 25)
        Me.timeoutTextBox.TabIndex = 9
        Me.timeoutTextBox.Text = "1000"
        '
        'boolState
        '
        Me.boolState.AutoSize = True
        Me.boolState.Location = New System.Drawing.Point(289, 65)
        Me.boolState.Name = "boolState"
        Me.boolState.Size = New System.Drawing.Size(45, 17)
        Me.boolState.TabIndex = 8
        Me.boolState.Text = "Status:"
        '
        'ThirteenButton2
        '
        Me.ThirteenButton2.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton2.ColorScheme = iLoveJan_Proxy_Checker.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton2.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton2.Location = New System.Drawing.Point(292, 36)
        Me.ThirteenButton2.Name = "ThirteenButton2"
        Me.ThirteenButton2.Size = New System.Drawing.Size(97, 26)
        Me.ThirteenButton2.TabIndex = 7
        Me.ThirteenButton2.Text = "Start / Stop"
        Me.ThirteenButton2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 51)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Code by: iLoveJan," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Theme by: XZ3ROXPROJ3CTX," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Donate: BTC WALLET"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "(Proxytype)"
        '
        'ProxyType
        '
        Me.ProxyType.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ProxyType.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ProxyType.ColorScheme = iLoveJan_Proxy_Checker.ThirteenComboBox.ColorSchemes.Dark
        Me.ProxyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProxyType.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ProxyType.ForeColor = System.Drawing.Color.White
        Me.ProxyType.FormattingEnabled = True
        Me.ProxyType.Items.AddRange(New Object() {"Socks 4", "Socks 5", "Https"})
        Me.ProxyType.Location = New System.Drawing.Point(118, 36)
        Me.ProxyType.Name = "ProxyType"
        Me.ProxyType.Size = New System.Drawing.Size(100, 26)
        Me.ProxyType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "or:"
        '
        'ThirteenButton1
        '
        Me.ThirteenButton1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton1.ColorScheme = iLoveJan_Proxy_Checker.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton1.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton1.Location = New System.Drawing.Point(12, 36)
        Me.ThirteenButton1.Name = "ThirteenButton1"
        Me.ThirteenButton1.Size = New System.Drawing.Size(100, 26)
        Me.ThirteenButton1.TabIndex = 2
        Me.ThirteenButton1.Text = "Select Proxylist"
        Me.ThirteenButton1.UseVisualStyleBackColor = False
        '
        'ProxylistTextBox
        '
        Me.ProxylistTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ProxylistTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProxylistTextBox.ColorScheme = iLoveJan_Proxy_Checker.ThirteenTextBox.ColorSchemes.Dark
        Me.ProxylistTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ProxylistTextBox.ForeColor = System.Drawing.Color.White
        Me.ProxylistTextBox.Location = New System.Drawing.Point(12, 99)
        Me.ProxylistTextBox.Multiline = True
        Me.ProxylistTextBox.Name = "ProxylistTextBox"
        Me.ProxylistTextBox.Size = New System.Drawing.Size(206, 300)
        Me.ProxylistTextBox.TabIndex = 1
        Me.ProxylistTextBox.Text = "Paste Proxies"
        '
        'ThirteenControlBox1
        '
        Me.ThirteenControlBox1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThirteenControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenControlBox1.ColorScheme = iLoveJan_Proxy_Checker.ThirteenControlBox.ColorSchemes.Dark
        Me.ThirteenControlBox1.ForeColor = System.Drawing.Color.White
        Me.ThirteenControlBox1.Location = New System.Drawing.Point(298, 3)
        Me.ThirteenControlBox1.Name = "ThirteenControlBox1"
        Me.ThirteenControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.ThirteenControlBox1.TabIndex = 0
        Me.ThirteenControlBox1.Text = "ThirteenControlBox1"
        '
        'exportBool
        '
        Me.exportBool.AutoSize = True
        Me.exportBool.Location = New System.Drawing.Point(227, 160)
        Me.exportBool.Name = "exportBool"
        Me.exportBool.Size = New System.Drawing.Size(45, 17)
        Me.exportBool.TabIndex = 14
        Me.exportBool.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 411)
        Me.Controls.Add(Me.ThirteenForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ThirteenForm1.ResumeLayout(False)
        Me.ThirteenForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ThirteenForm1 As iLoveJan_Proxy_Checker.ThirteenForm
    Friend WithEvents ThirteenControlBox1 As iLoveJan_Proxy_Checker.ThirteenControlBox
    Friend WithEvents ThirteenButton1 As iLoveJan_Proxy_Checker.ThirteenButton
    Friend WithEvents ProxylistTextBox As iLoveJan_Proxy_Checker.ThirteenTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProxyType As iLoveJan_Proxy_Checker.ThirteenComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ThirteenButton2 As iLoveJan_Proxy_Checker.ThirteenButton
    Friend WithEvents boolState As System.Windows.Forms.Label
    Friend WithEvents timeoutTextBox As iLoveJan_Proxy_Checker.ThirteenTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents alive As System.Windows.Forms.Label
    Friend WithEvents dead As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ThirteenCheckBox1 As iLoveJan_Proxy_Checker.ThirteenCheckBox
    Friend WithEvents exportBool As System.Windows.Forms.Label

End Class
