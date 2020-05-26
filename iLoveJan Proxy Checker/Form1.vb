Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1

    Dim aliveCount As Integer
    Dim deadCount As Integer
    Dim timeout As Integer
    Dim proxieCounter As Integer = 0

    Dim autoExport As Boolean = True

    Dim proxies() As String

    Private Sub testProxie(proxie As String, timeout As Integer)
        If My.Computer.Network.Ping(proxie, timeout) Then
            'MsgBox("[" + proxie + "]" + " Server pinged successfully.")
            ReDim Preserve proxies(proxieCounter)
            aliveCount = aliveCount + 1
            proxies(proxieCounter) = proxie
            proxieCounter = proxieCounter + 1
        Else
            'MsgBox("[" + proxie + "]" + " Ping request timed out.")
            deadCount = deadCount + 1
        End If
    End Sub

    Dim Started As Boolean = False

    Private Sub ThirteenButton2_Click(sender As Object, e As EventArgs) Handles ThirteenButton2.Click
        If (Started = False) Then
            Started = True
            boolState.Text = "Status: Started"
            main()
        ElseIf (Started = True) Then
            Started = False
            boolState.Text = "Status: Stopped"
        End If
    End Sub

    Private Sub main()
        timeout = Convert.ToInt32(timeoutTextBox.Text)
        If (Started = True) Then
            For Each line In Me.ProxylistTextBox.Text.Split({Environment.NewLine}, StringSplitOptions.None)
                'MsgBox(line + ":" + timeout)
                testProxie(line, timeout)
            Next
            alive.Text = "Alive: " + Convert.ToString(aliveCount)
            dead.Text = "Dead: " + Convert.ToString(deadCount)
            writeToFile("test")
        End If
    End Sub

    Private Sub ThirteenButton1_Click(sender As Object, e As EventArgs) Handles ThirteenButton1.Click
        OpenFileDialog1.Title = "Open your Proxylist-file."
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim path As String = OpenFileDialog1.FileName
            Try
                Dim text As String = File.ReadAllText(path)
                ProxylistTextBox.Text = text
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ThirteenCheckBox1_CheckedChanged(sender As Object) Handles ThirteenCheckBox1.CheckedChanged
        If (ThirteenCheckBox1.Checked = True) Then
            autoExport = True
        Else
            autoExport = False
        End If
    End Sub

    Private Sub writeToFile(text)
        Dim folderPath As String
        folderPath = My.Application.Info.DirectoryPath()

        Dim objWriter As New System.IO.StreamWriter(folderPath + "\proxies.txt")

        If System.IO.File.Exists(folderPath + "\proxies.txt") = True Then
            For i = 0 To UBound(proxies)
                text = proxies(i)
                objWriter.WriteLine(text)
            Next
            objWriter.Close()
        End If
    End Sub
End Class
