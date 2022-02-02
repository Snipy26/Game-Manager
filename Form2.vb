Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.Startsound, AudioPlayMode.Background)

        Timer1.Enabled = True

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        If ProgressBar1.Value = ProgressBar1.Minimum = False Then
            Button1.Enabled = False
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum = True Then
            Timer1.Enabled = False
            Button1.Enabled = True

        End If
    End Sub
End Class