<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.loginFormgrp = New System.Windows.Forms.GroupBox()
        Me.userName = New System.Windows.Forms.Label()
        Me.passWord = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.loginFormgrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginFormgrp
        '
        Me.loginFormgrp.Controls.Add(Me.TextBox2)
        Me.loginFormgrp.Controls.Add(Me.TextBox1)
        Me.loginFormgrp.Controls.Add(Me.passWord)
        Me.loginFormgrp.Controls.Add(Me.userName)
        Me.loginFormgrp.Location = New System.Drawing.Point(106, 62)
        Me.loginFormgrp.Name = "loginFormgrp"
        Me.loginFormgrp.Size = New System.Drawing.Size(473, 249)
        Me.loginFormgrp.TabIndex = 0
        Me.loginFormgrp.TabStop = False
        Me.loginFormgrp.Text = "Login form"
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Location = New System.Drawing.Point(16, 28)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(55, 13)
        Me.userName.TabIndex = 0
        Me.userName.Text = "Username"
        '
        'passWord
        '
        Me.passWord.AutoSize = True
        Me.passWord.Location = New System.Drawing.Point(16, 65)
        Me.passWord.Name = "passWord"
        Me.passWord.Size = New System.Drawing.Size(53, 13)
        Me.passWord.TabIndex = 1
        Me.passWord.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(111, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.loginFormgrp)
        Me.Name = "loginForm"
        Me.Text = "Login Form"
        Me.loginFormgrp.ResumeLayout(False)
        Me.loginFormgrp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginFormgrp As GroupBox
    Friend WithEvents passWord As Label
    Friend WithEvents userName As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
