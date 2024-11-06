Imports System.Data.SqlClient


Public Class FrmPrincipale
    ' Dim connection As New SqlConnection("Server=.; Database = BIJOU; Integrated Security = true")
    ' Récupérer la connexion depuis FrmCnx
    Dim connection = FrmCnx.connection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblServeur.Text = FrmCnx.TxtServeur.Text
        LblDatabase.Text = FrmCnx.TxtDatabase.Text
        FrmCnx.Hide()
        Dim dtable As DataTable
        Dim ds As DataSet
        Dim ds_mois As DataSet

        Dim adp = New SqlDataAdapter()
        adp.SelectCommand = New SqlCommand("Select Distinct JO_Num FROM F_ECRITUREC", connection)

        ds = New DataSet("ds")
        adp.Fill(ds)
        dtable = ds.Tables(0)
        For Each drow As DataRow In dtable.Rows
            List_JNL.Items.Add(drow(0).ToString())

        Next

        Dim adp_mois = New SqlDataAdapter()
        adp_mois.SelectCommand = New SqlCommand("SELECT DISTINCT MONTH(EC_Date) FROM F_ECRITUREC", connection)

        ds_mois = New DataSet("ds_mois")
        adp_mois.Fill(ds_mois)
        dtable = ds_mois.Tables(0)
        For Each drow As DataRow In dtable.Rows
            List_Mois.Items.Add(drow(0).ToString)
        Next



    End Sub





    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click

        Dim result As DialogResult = MessageBox.Show("Voulez vraiment quitter !!", "Quitter", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            Application.Exit()
        End If


    End Sub

    Private Sub AProposToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem1.Click
        FrmApropos.Show()
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        FrmCnx.Show()

    End Sub

    Private Sub List_Mois_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnRechrecher_Click(sender As Object, e As EventArgs) Handles BtnRechrecher.Click

        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        Try
            ' Créer la commande SQL
            Using MyCommand As New SqlCommand("SELECT JO_Num , JM_Date , EC_Date, EC_RefPiece, EC_Intitule , 
                                                CASE When EC_Cloture='1' then 'Cloturer' When EC_Cloture='0' then 'Non cloturer' END
                                                FROM F_ECRITUREC WHERE JO_Num = @JNL and Month(JM_Date)=@Mois", connection)
                ' Ajout explicite du paramètre avec son type
                MyCommand.Parameters.Add("@JNL", SqlDbType.VarChar).Value = List_JNL.Text
                MyCommand.Parameters.Add("@Mois", SqlDbType.VarChar).Value = List_Mois.Text

                ' Utiliser SqlDataAdapter avec l'objet SqlCommand
                Using adapter As New SqlDataAdapter(MyCommand)
                    ' Remplir le DataTable avec les résultats de la requête
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Lier le DataTable au DataGridView
                    DataGridView1.DataSource = table
                    With DataGridView1.RowHeadersVisible = False
                        DataGridView1.Columns(0).HeaderCell.Value = "Journal"
                        DataGridView1.Columns(1).HeaderCell.Value = "Date Journal"
                        DataGridView1.Columns(2).HeaderCell.Value = "Date Ecriture"
                        DataGridView1.Columns(3).HeaderCell.Value = "Référence Piece"
                        DataGridView1.Columns(4).HeaderCell.Value = "Intitulé Ecriture"
                        DataGridView1.Columns(5).HeaderCell.Value = "Cloture Ecriture"


                    End With
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'exécution de la requête : " & ex.Message)
        Finally
            ' Fermer la connexion si elle est encore ouverte
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try


    End Sub

    Private Sub BtnReintialiser_Click(sender As Object, e As EventArgs) Handles BtnReintialiser.Click
        List_JNL.Text = ""
        List_Mois.Text = ""
    End Sub

    Private Sub BtnDecolture_Click(sender As Object, e As EventArgs) Handles BtnDecolture.Click
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the index of the selected row
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Get the value of a specific cell in the selected row (e.g., the first column)
            Dim JOURNAL As String = DataGridView1.Rows(selectedRowIndex).Cells(0).Value.ToString()
            Dim MOIS As String = DataGridView1.Rows(selectedRowIndex).Cells(1).Value.Month.ToString()
            MessageBox.Show("Voulez-vous décolturez le Journal: " & JOURNAL & "    " & "du Mois: " & MOIS & " ?")



            ' Créer la commande SQL
            Using MyCommand As New SqlCommand("update F_ECRITUREC set EC_Cloture='1' where Month(jm_date)=@MOIS and JO_Num=@JRNL ", connection)
                ' Ajout explicite du paramètre avec son type
                MyCommand.Parameters.Add("@JRNL", SqlDbType.VarChar).Value = JOURNAL
                MyCommand.Parameters.Add("@MOIS", SqlDbType.VarChar).Value = MOIS

                Dim rowsAffected As Integer = MyCommand.ExecuteNonQuery()

                ' Display how many rows were updated
                MessageBox.Show(rowsAffected & "ligne mis à jour.")
                connection.Close()
            End Using
        Else
            MessageBox.Show("Merci de séléctionner une ligne.")
        End If
    End Sub

    Private Sub BtnCloturer_Click(sender As Object, e As EventArgs) Handles BtnCloturer.Click
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the index of the selected row
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Get the value of a specific cell in the selected row (e.g., the first column)
            Dim JOURNAL As String = DataGridView1.Rows(selectedRowIndex).Cells(0).Value.ToString()
            Dim MOIS As String = DataGridView1.Rows(selectedRowIndex).Cells(1).Value.Month.ToString()
            MessageBox.Show("Voulez-vous colturez le Journal: " & JOURNAL & "    " & "du Mois: " & MOIS & " ?")



            ' Créer la commande SQL
            Using MyCommand As New SqlCommand("update F_ECRITUREC set EC_Cloture='0' where Month(jm_date)=@MOIS and JO_Num=@JRNL ", connection)
                ' Ajout explicite du paramètre avec son type
                MyCommand.Parameters.Add("@JRNL", SqlDbType.VarChar).Value = JOURNAL
                MyCommand.Parameters.Add("@MOIS", SqlDbType.VarChar).Value = MOIS

                Dim rowsAffected As Integer = MyCommand.ExecuteNonQuery()

                ' Display how many rows were updated
                MessageBox.Show(rowsAffected & "ligne mis à jour.")
                connection.Close()
            End Using
        Else
            MessageBox.Show("Merci de séléctionner une ligne.")
        End If
    End Sub
End Class
