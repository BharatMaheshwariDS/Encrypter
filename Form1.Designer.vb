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
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.txtinputtext = New System.Windows.Forms.TextBox()
        Me.txtdecrypted = New System.Windows.Forms.TextBox()
        Me.txtencrypted = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(578, 88)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(88, 39)
        Me.btnEncrypt.TabIndex = 0
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'txtinputtext
        '
        Me.txtinputtext.Location = New System.Drawing.Point(302, 73)
        Me.txtinputtext.Name = "txtinputtext"
        Me.txtinputtext.Size = New System.Drawing.Size(195, 20)
        Me.txtinputtext.TabIndex = 1
        '
        'txtdecrypted
        '
        Me.txtdecrypted.Location = New System.Drawing.Point(302, 168)
        Me.txtdecrypted.Name = "txtdecrypted"
        Me.txtdecrypted.Size = New System.Drawing.Size(195, 20)
        Me.txtdecrypted.TabIndex = 2
        '
        'txtencrypted
        '
        Me.txtencrypted.Location = New System.Drawing.Point(302, 124)
        Me.txtencrypted.Name = "txtencrypted"
        Me.txtencrypted.Size = New System.Drawing.Size(195, 20)
        Me.txtencrypted.TabIndex = 3
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(240, 76)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(56, 13)
        Me.lblInput.TabIndex = 4
        Me.lblInput.Text = "Enter Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Encrypted Text"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Decrypted Text"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(578, 133)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(88, 39)
        Me.btnDecrypt.TabIndex = 7
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 442)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.txtencrypted)
        Me.Controls.Add(Me.txtdecrypted)
        Me.Controls.Add(Me.txtinputtext)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents txtinputtext As System.Windows.Forms.TextBox
    Friend WithEvents txtdecrypted As System.Windows.Forms.TextBox
    Friend WithEvents txtencrypted As System.Windows.Forms.TextBox
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button

End Class
