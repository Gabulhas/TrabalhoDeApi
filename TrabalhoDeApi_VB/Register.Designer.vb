﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.registButton = New System.Windows.Forms.Button()
        Me.registUserBox = New System.Windows.Forms.TextBox()
        Me.registPasswordBox = New System.Windows.Forms.TextBox()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
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
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.registPasswordBox)
        Me.Controls.Add(Me.registUserBox)
        Me.Controls.Add(Me.registButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registerForm"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents registButton As System.Windows.Forms.Button
    Friend WithEvents registUserBox As System.Windows.Forms.TextBox
    Friend WithEvents registPasswordBox As System.Windows.Forms.TextBox
End Class