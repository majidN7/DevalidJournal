Public Class FrmApropos
    Private Sub FrmApropos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Me.Close()
        Application.Exit()

    End Sub

    Private Sub MaterialListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialMultiLineTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaterialMultiLineTextBox1.TextChanged

    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        FrmPrincipale.Show()
        Me.Hide()
    End Sub
End Class