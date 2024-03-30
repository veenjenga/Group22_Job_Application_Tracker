<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userRegistration
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
        Me.userRegistrationgrp = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lastName = New System.Windows.Forms.Label()
        Me.firstName = New System.Windows.Forms.Label()
        Me.emailAddress = New System.Windows.Forms.Label()
        Me.passWord = New System.Windows.Forms.Label()
        Me.userName = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.userRegistrationgrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'userRegistrationgrp
        '
        Me.userRegistrationgrp.Controls.Add(Me.TextBox6)
        Me.userRegistrationgrp.Controls.Add(Me.TextBox5)
        Me.userRegistrationgrp.Controls.Add(Me.TextBox4)
        Me.userRegistrationgrp.Controls.Add(Me.TextBox3)
        Me.userRegistrationgrp.Controls.Add(Me.TextBox2)
        Me.userRegistrationgrp.Controls.Add(Me.TextBox1)
        Me.userRegistrationgrp.Controls.Add(Me.lastName)
        Me.userRegistrationgrp.Controls.Add(Me.firstName)
        Me.userRegistrationgrp.Controls.Add(Me.emailAddress)
        Me.userRegistrationgrp.Controls.Add(Me.passWord)
        Me.userRegistrationgrp.Controls.Add(Me.userName)
        Me.userRegistrationgrp.Location = New System.Drawing.Point(122, 38)
        Me.userRegistrationgrp.Name = "userRegistrationgrp"
        Me.userRegistrationgrp.Size = New System.Drawing.Size(479, 309)
        Me.userRegistrationgrp.TabIndex = 0
        Me.userRegistrationgrp.TabStop = False
        Me.userRegistrationgrp.Text = "User Registration"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(129, 29)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(129, 68)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(129, 114)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(129, 219)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(129, 166)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(3, 286)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(473, 20)
        Me.TextBox1.TabIndex = 5
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Location = New System.Drawing.Point(15, 222)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(58, 13)
        Me.lastName.TabIndex = 4
        Me.lastName.Text = "Last Name"
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Location = New System.Drawing.Point(15, 169)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(57, 13)
        Me.firstName.TabIndex = 3
        Me.firstName.Text = "First Name"
        '
        'emailAddress
        '
        Me.emailAddress.AutoSize = True
        Me.emailAddress.Location = New System.Drawing.Point(15, 117)
        Me.emailAddress.Name = "emailAddress"
        Me.emailAddress.Size = New System.Drawing.Size(73, 13)
        Me.emailAddress.TabIndex = 2
        Me.emailAddress.Text = "Email Address"
        '
        'passWord
        '
        Me.passWord.AutoSize = True
        Me.passWord.Location = New System.Drawing.Point(15, 68)
        Me.passWord.Name = "passWord"
        Me.passWord.Size = New System.Drawing.Size(53, 13)
        Me.passWord.TabIndex = 1
        Me.passWord.Text = "Password"
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Location = New System.Drawing.Point(15, 29)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(55, 13)
        Me.userName.TabIndex = 0
        Me.userName.Text = "Username"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'userRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.userRegistrationgrp)
        Me.Name = "userRegistration"
        Me.Text = "User Registration"
        Me.userRegistrationgrp.ResumeLayout(False)
        Me.userRegistrationgrp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents userRegistrationgrp As GroupBox
    Friend WithEvents lastName As Label
    Friend WithEvents firstName As Label
    Friend WithEvents emailAddress As Label
    Friend WithEvents passWord As Label
    Friend WithEvents userName As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox6 As TextBox
End Class
