<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.registButton = New System.Windows.Forms.Button()
        Me.registUserBox = New System.Windows.Forms.TextBox()
        Me.registPasswordBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registo"
        '
        'registButton
        '
        Me.registButton.Location = New System.Drawing.Point(104, 315)
        Me.registButton.Name = "registButton"
        Me.registButton.Size = New System.Drawing.Size(111, 40)
        Me.registButton.TabIndex = 3
        Me.registButton.Text = "Registo"
        Me.registButton.UseVisualStyleBackColor = True
        '
        'registUserBox
        '
        Me.registUserBox.Location = New System.Drawing.Point(115, 147)
        Me.registUserBox.Name = "registUserBox"
        Me.registUserBox.Size = New System.Drawing.Size(100, 20)
        Me.registUserBox.TabIndex = 4
        '
        'registPasswordBox
        '
        Me.registPasswordBox.Location = New System.Drawing.Point(115, 219)
        Me.registPasswordBox.Name = "registPasswordBox"
        Me.registPasswordBox.Size = New System.Drawing.Size(100, 20)
        Me.registPasswordBox.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 85)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(272, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(41, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Pass"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(42, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "User"
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 440)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.registPasswordBox)
        Me.Controls.Add(Me.registUserBox)
        Me.Controls.Add(Me.registButton)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registerForm"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents registButton As System.Windows.Forms.Button
    Friend WithEvents registUserBox As System.Windows.Forms.TextBox
    Friend WithEvents registPasswordBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
