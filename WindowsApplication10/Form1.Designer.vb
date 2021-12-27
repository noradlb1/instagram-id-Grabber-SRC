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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HexTheme1 = New WindowsApplication10.HexTheme()
        Me.HexClose1 = New WindowsApplication10.HexClose()
        Me.HexMini1 = New WindowsApplication10.HexMini()
        Me.HexButton1 = New WindowsApplication10.HexButton()
        Me.HexTextBox2 = New WindowsApplication10.HexTextBox()
        Me.HexTextBox1 = New WindowsApplication10.HexTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HexTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HexTheme1
        '
        Me.HexTheme1.Controls.Add(Me.HexClose1)
        Me.HexTheme1.Controls.Add(Me.HexMini1)
        Me.HexTheme1.Controls.Add(Me.HexButton1)
        Me.HexTheme1.Controls.Add(Me.HexTextBox2)
        Me.HexTheme1.Controls.Add(Me.HexTextBox1)
        Me.HexTheme1.Controls.Add(Me.Label1)
        Me.HexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.HexTheme1.Name = "HexTheme1"
        Me.HexTheme1.Size = New System.Drawing.Size(261, 152)
        Me.HexTheme1.TabIndex = 4
        Me.HexTheme1.Text = "instagram id Grabber"
        '
        'HexClose1
        '
        Me.HexClose1.Location = New System.Drawing.Point(246, 3)
        Me.HexClose1.Name = "HexClose1"
        Me.HexClose1.Size = New System.Drawing.Size(12, 12)
        Me.HexClose1.TabIndex = 6
        Me.HexClose1.Text = "HexClose1"
        '
        'HexMini1
        '
        Me.HexMini1.Location = New System.Drawing.Point(228, 3)
        Me.HexMini1.Name = "HexMini1"
        Me.HexMini1.Size = New System.Drawing.Size(12, 12)
        Me.HexMini1.TabIndex = 5
        Me.HexMini1.Text = "HexMini1"
        '
        'HexButton1
        '
        Me.HexButton1.Location = New System.Drawing.Point(3, 66)
        Me.HexButton1.Name = "HexButton1"
        Me.HexButton1.Size = New System.Drawing.Size(255, 30)
        Me.HexButton1.TabIndex = 4
        Me.HexButton1.Text = "Grab id"
        '
        'HexTextBox2
        '
        Me.HexTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.HexTextBox2.Location = New System.Drawing.Point(3, 33)
        Me.HexTextBox2.MaxLength = 32767
        Me.HexTextBox2.Multiline = False
        Me.HexTextBox2.Name = "HexTextBox2"
        Me.HexTextBox2.ReadOnly = False
        Me.HexTextBox2.Size = New System.Drawing.Size(255, 27)
        Me.HexTextBox2.TabIndex = 1
        Me.HexTextBox2.Text = "Username"
        Me.HexTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HexTextBox2.UseSystemPasswordChar = False
        '
        'HexTextBox1
        '
        Me.HexTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.HexTextBox1.Location = New System.Drawing.Point(3, 102)
        Me.HexTextBox1.MaxLength = 32767
        Me.HexTextBox1.Multiline = False
        Me.HexTextBox1.Name = "HexTextBox1"
        Me.HexTextBox1.ReadOnly = False
        Me.HexTextBox1.Size = New System.Drawing.Size(255, 27)
        Me.HexTextBox1.TabIndex = 0
        Me.HexTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HexTextBox1.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(3, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Coder : MONSTERMC"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 152)
        Me.Controls.Add(Me.HexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "instagram id Grabber"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HexTheme1.ResumeLayout(False)
        Me.HexTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HexTheme1 As HexTheme
    Friend WithEvents HexClose1 As HexClose
    Friend WithEvents HexMini1 As HexMini
    Friend WithEvents HexButton1 As HexButton
    Friend WithEvents HexTextBox2 As HexTextBox
    Friend WithEvents HexTextBox1 As HexTextBox
End Class
