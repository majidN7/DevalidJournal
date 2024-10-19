

Public Class FrmCnx
    Public connection
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnConnecter_Click(sender As Object, e As EventArgs) Handles BtnConnecter.Click
        Dim Serveur As String = TxtServeur.Text
        Dim Database As String = TxtDatabase.Text
        Dim utilisateur As String = TxtUser.Text
        Dim mdp As String = TxtMdp.Text

        ' Vérification que tous les champs sont remplis
        If String.IsNullOrEmpty(Serveur) Or String.IsNullOrEmpty(Database) Or String.IsNullOrEmpty(utilisateur) Or String.IsNullOrEmpty(mdp) Then
            MessageBox.Show("Veuillez remplir tous les champs avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ConnectString As String = "Server=" & Serveur & ";Database=" & Database & ";User Id=" & utilisateur & ";Password=" & mdp & ";"

        connection = ConnectDatabase(ConnectString)

        MessageBox.Show("Connexion réussie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FrmPrincipale.Show()
        Me.Hide()

    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class