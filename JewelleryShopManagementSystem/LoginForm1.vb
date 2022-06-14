Public Class aLoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtuser.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub aLoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
       

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        Label1.Text = ProgressBar1.Value & "&" & "completed"
        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False
            If txtuser.Text = "admin" And txtpass.Text = "admin" Then
                MsgBox("Login Successfully", MsgBoxStyle.Information)
                Me.Hide()
                frmMain.Show()
                ProgressBar1.Value = 0
            Else
                MsgBox("Login Failed", MsgBoxStyle.Information)
                Label1.Text = ""
                ProgressBar1.Value = 0
                txtuser.Focus()
            End If

        End If
    End Sub


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ProgressBar1.Visible = True
        Label1.Visible = True
        Timer1.Enabled = True

    End Sub

   
End Class
