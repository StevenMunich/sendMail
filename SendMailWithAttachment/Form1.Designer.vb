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
        Me.components = New System.ComponentModel.Container()
        Me.destination = New System.Windows.Forms.TextBox()
        Me.Destinaio = New System.Windows.Forms.TextBox()
        Me.Body = New System.Windows.Forms.TextBox()
        Me.Subject = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.attach = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'destination
        '
        Me.destination.Location = New System.Drawing.Point(12, 42)
        Me.destination.Name = "destination"
        Me.destination.Size = New System.Drawing.Size(192, 20)
        Me.destination.TabIndex = 0
        Me.destination.Text = "stevenmunich777@gmail.com"
        '
        'Destinaio
        '
        Me.Destinaio.Location = New System.Drawing.Point(12, 68)
        Me.Destinaio.Name = "Destinaio"
        Me.Destinaio.Size = New System.Drawing.Size(192, 20)
        Me.Destinaio.TabIndex = 1
        Me.Destinaio.Text = "bobfarker111@gmail.com"
        '
        'Body
        '
        Me.Body.Location = New System.Drawing.Point(12, 120)
        Me.Body.Multiline = True
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(513, 143)
        Me.Body.TabIndex = 3
        Me.Body.Text = "Body"
        '
        'Subject
        '
        Me.Subject.Location = New System.Drawing.Point(12, 94)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(192, 20)
        Me.Subject.TabIndex = 2
        Me.Subject.Text = "Subject"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(210, 68)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(192, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "sbkz lxnj yrnz cash"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(677, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(450, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 53)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Attach"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'attach
        '
        Me.attach.Location = New System.Drawing.Point(13, 283)
        Me.attach.Name = "attach"
        Me.attach.Size = New System.Drawing.Size(431, 20)
        Me.attach.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "To"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(677, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "KeyLog"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.attach)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.Destinaio)
        Me.Controls.Add(Me.destination)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents destination As TextBox
    Friend WithEvents Destinaio As TextBox
    Friend WithEvents Body As TextBox
    Friend WithEvents Subject As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents attach As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
End Class
