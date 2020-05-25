Public Class Form1

    Private Sub testProxie(proxie As String, timeout As Integer)
        If My.Computer.Network.Ping(proxie, timeout) Then
            MsgBox("[" + proxie + "]" + " Server pinged successfully.")
        Else
            MsgBox("[" + proxie + "]" + " Ping request timed out.")
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

    Dim timeout As Integer

    Private Sub main()
        'timeout = Convert.ToInt32(timeoutTextBox.Text)
        If (Started = True) Then
            For Each line In Me.ProxylistTextBox.Text.Split({Environment.NewLine}, StringSplitOptions.None)
                'MsgBox(line + ":" + timeout)
                testProxie(line, 1000)
            Next
        End If
    End Sub
End Class
