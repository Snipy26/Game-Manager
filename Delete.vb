Public Class Delete

    Private Sub btnno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnno.Click
        MsgBox("Besser is dat !")
        Me.Close()
    End Sub

    Private Sub btnyes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnyes.Click
        MsgBox("Wird gelöscht :(")
        Me.Close()
    End Sub

    Private Sub Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub
End Class