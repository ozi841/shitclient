Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim wc As New System.Net.WebClient
        TextBox3.Text = wc.DownloadString("http://api.sudaox.com/nativechat/chat.php")

        WebBrowser1.Navigate("https://useragentf.glitch.me")
        ChangeUserAgent("Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.5005.115 Safari/537.36")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        WebBrowser1.Navigate("http://api.sudaox.com/nativechat/send.php?u=" + TextBox1.Text + "&m=" + TextBox2.Text + "&v=2")
        Dim wc As New System.Net.WebClient
        TextBox3.Text = wc.DownloadString("http://api.sudaox.com/nativechat/chat.php")
        Call thing()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("NativeChat by Sudaox")
        MsgBox("oliver")
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Text = "client"
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim wc As New System.Net.WebClient
        TextBox3.Text = wc.DownloadString("http://api.sudaox.com/nativechat/chat.php")



        Call thing()
        'BackgroundWorker1.RunWorkerAsync()
    End Sub

    Sub thing()
        Dim wc As New System.Net.WebClient
        TextBox3.Text = wc.DownloadString("http://api.sudaox.com/nativechat/chat.php")

        wait(1400)



        Call thing()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

End Class



