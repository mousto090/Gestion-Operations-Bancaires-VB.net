Public Class Admin

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ----------- Panel Principal ----------
        PNEWAGENT.Visible = False
        PDELETEAGENT.Visible = False
        PVALIDDEMANDE.Visible = False
        PSEARCHAGENT.Visible = False
        PABOUT.Visible = False
        PBIENVENU.Visible = True



        ' ----------- Panel Agents ----------

        ' ----------- Panel Delete Agents ----------

        ' ----------- Panel Valide des demandes ----------

        ' ----------- Panel Recherche des agents ----------


    End Sub



    ' ----------- Panel Menu ----------
    Private Sub NEWAGE_Click(sender As Object, e As EventArgs) Handles NEWAGE.Click
        TCINAGENT.Text = ""
        TNOMAGENT.Text = ""
        TPREAGENT.Text = ""
        TTELAGENT.Text = ""
        TADDAGENT.Text = ""
        TPASSAGENT.Text = ""
        TREPASSAGENT.Text = ""
        PNEWAGENT.Visible = True
        PDELETEAGENT.Visible = False
        PVALIDDEMANDE.Visible = False
        PSEARCHAGENT.Visible = False
        PABOUT.Visible = False
        PBIENVENU.Visible = False
    End Sub

    Private Sub DELAGE_Click(sender As Object, e As EventArgs) Handles DELAGE.Click
        PNEWAGENT.Visible = False
        PDELETEAGENT.Visible = True
        PVALIDDEMANDE.Visible = False
        PSEARCHAGENT.Visible = False
        PABOUT.Visible = False
        PBIENVENU.Visible = False
        remplirdatagrid("select * from AGENTS", DataGridView1)
    End Sub

    Private Sub VALIDDEM_Click(sender As Object, e As EventArgs) Handles VALIDDEM.Click
        PNEWAGENT.Visible = False
        PDELETEAGENT.Visible = False
        PVALIDDEMANDE.Visible = True
        PSEARCHAGENT.Visible = False
        PABOUT.Visible = False
        PBIENVENU.Visible = False
        remplirdatagrid("select c.*,f.NUMERO_COMPTE from DEMANDES c join FAIRE_DES_DEMANDE f on c.ID_DEMANDE=f.ID_DEMANDE", DataGridView2)
    End Sub

    Private Sub RECHERCHEAGE_Click(sender As Object, e As EventArgs) Handles RECHERCHEAGE.Click
        PNEWAGENT.Visible = False
        PDELETEAGENT.Visible = False
        PVALIDDEMANDE.Visible = False
        PSEARCHAGENT.Visible = True
        PABOUT.Visible = False
        PBIENVENU.Visible = False

    End Sub
    Private Sub ABOUT_Click(sender As Object, e As EventArgs) Handles ABOUT.Click
        PNEWAGENT.Visible = False
        PDELETEAGENT.Visible = False
        PVALIDDEMANDE.Visible = False
        PSEARCHAGENT.Visible = False
        PABOUT.Visible = True
        PBIENVENU.Visible = False
    End Sub


    ' ----------- Panel Agents ----------
    Private Sub VIDERCHAMPSAGENT_Click(sender As Object, e As EventArgs) Handles VIDERCHAMPSAGENT.Click
        TCINAGENT.Text = ""
        TNOMAGENT.Text = ""
        TPREAGENT.Text = ""
        TTELAGENT.Text = ""
        TADDAGENT.Text = ""
        TPASSAGENT.Text = ""
        TREPASSAGENT.Text = ""
    End Sub

    Private Sub VALIDERAGENTS_Click(sender As Object, e As EventArgs) Handles VALIDERAGENTS.Click

        Try
            If TPASSAGENT.Text = TREPASSAGENT.Text Then
                executercmd("insert into AGENTS values('" + TCINAGENT.Text.Replace("'", "''") + "','" + TNOMAGENT.Text.Replace("'", "''") + "','" + TPREAGENT.Text.Replace("'", "''") + "','" + TTELAGENT.Text.Replace("'", "''") + "','" + TADDAGENT.Text.Replace("'", "''") + "','" + TPASSAGENT.Text.Replace("'", "''") + "')")
                MsgBox("L'agent est ajouté avec succés")
            Else
                MsgBox("Les Mots de passe sont pas identique")
                TREPASSAGENT.Clear()
                TREPASSAGENT.Focus()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    ' ----------- Panel Delete Agents ----------

    Private Sub DELETEAGENT_Click(sender As Object, e As EventArgs) Handles DELETEAGENT.Click
        Dim i As Integer = DataGridView1.CurrentCellAddress.Y
        Dim del As String = DataGridView1.Rows(i).Cells(0).Value()
        Try
            executercmd("delete from AGENTS where CIN_AGENT='" + del + "'")
            remplirdatagrid("select * from AGENTS", DataGridView1)
            MsgBox("La suppression de l'agent est effectué avec succés")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    ' ----------- Panel Valide des demandes ----------
    Private Sub REFEUDEM_Click(sender As Object, e As EventArgs) Handles REFEUDEM.Click
        Dim i As Integer = DataGridView2.CurrentCellAddress.Y
        Dim del As String = DataGridView2.Rows(i).Cells(0).Value()
        Dim del2 As String = DataGridView2.Rows(i).Cells(4).Value()
        executercmdreader("select count(*) from DEMANDES where TYPE_DEMANDE='Fermeture'")
        dr.Read()
        If dr(0).ToString() = 1 Then
            dr.Close()
            Try
                executercmd("update DEMANDES set ETAT_DEMANDE='False' where ID_DEMANDE='" + del + "'")
                executercmd("Update COMPTES set ACTIVE_COMPTE='True',DATEFERMETURE_COMPTE='NULL' where NUMERO_COMPTE='" + del2 + "'")
                remplirdatagrid("select c.*,f.NUMERO_COMPTE from DEMANDES c join FAIRE_DES_DEMANDE f on c.ID_DEMANDE=f.ID_DEMANDE", DataGridView2)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub ACCEPTEDEM_Click(sender As Object, e As EventArgs) Handles ACCEPTEDEM.Click
        Dim i As Integer = DataGridView2.CurrentCellAddress.Y
        Dim del As String = DataGridView2.Rows(i).Cells(0).Value()
        Dim del2 As String = DataGridView2.Rows(i).Cells(4).Value()
        executercmdreader("select count(*) from DEMANDES where TYPE_DEMANDE='Fermeture'")
        dr.Read()
        If dr(0).ToString() = 1 Then
            dr.Close()
            Try
                executercmd("update DEMANDES set ETAT_DEMANDE='True' where ID_DEMANDE='" + del + "'")
                executercmd("Update COMPTES set ACTIVE_COMPTE='False',DATEFERMETURE_COMPTE='" + Date.Now + "' where NUMERO_COMPTE='" + del2 + "'")
                remplirdatagrid("select c.*,f.NUMERO_COMPTE from DEMANDES c join FAIRE_DES_DEMANDE f on c.ID_DEMANDE=f.ID_DEMANDE", DataGridView2)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If


    End Sub

    Private Sub LOGOUTADMIN_Click(sender As Object, e As EventArgs) Handles LOGOUTADMIN.Click
        Me.Hide()
        Accueil.Show()
        Accueil.T_Utilisateur.Focus()

    End Sub


    Private Sub Admin_FormClosing(sender As Object, e As FormClosingEventArgs)
        End
    End Sub

    Private Sub CLIAGE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CLIAGE.SelectedIndexChanged

        executercmdreader("select * from AGENTS where CIN_AGENT='" + CLIAGE.Text + "'")
        dr.Read()
        TextBox1.Text = dr(0)
        TextBox2.Text = dr(1)
        TextBox3.Text = dr(2)
        TextBox4.Text = dr(3)
        TextBox5.Text = dr(4)
        dr.Close()
        executercmdreader("select COUNT(*) from OPERATIONS  join AGENTS on OPERATIONS.CIN_AGENT=AGENTS.CIN_AGENT where OPERATIONS.CIN_AGENT='" + CLIAGE.Text + "'")
        dr.Read()
        TextBox8.Text = dr(0)
        dr.Close()
        executercmdreader("select COUNT(*) from  COMPTES join CLIENTS on CLIENTS.CIN_CLIENT=COMPTES.CIN_CLIENT join AGENTS on AGENTS.CIN_AGENT=COMPTES.CIN_AGENT where COMPTES.CIN_AGENT='" + CLIAGE.Text + "'")
        dr.Read()
        TextBox6.Text = dr(0)
        dr.Close()
        executercmdreader("select COUNT(*) from COMPTES join AGENTS on COMPTES.CIN_AGENT=AGENTS.CIN_AGENT where COMPTES.CIN_AGENT ='" + CLIAGE.Text + "'")
        dr.Read()
        TextBox7.Text = dr(0)
        dr.Close()
        executercmdreader("select COUNT(*) from AGENTS join FAIRE_DES_DEMANDE on AGENTS.CIN_AGENT=FAIRE_DES_DEMANDE.CIN_AGENT join DEMANDES on DEMANDES.ID_DEMANDE=FAIRE_DES_DEMANDE.ID_DEMANDE where FAIRE_DES_DEMANDE.CIN_AGENT='" + CLIAGE.Text + "'")
        dr.Read()
        TextBox9.Text = dr(0)
        dr.Close()
    End Sub

    Private Sub CLIAGE_Click(sender As Object, e As EventArgs) Handles CLIAGE.Click
        remplir_combo("select CIN_AGENT from AGENTS", CLIAGE)
    End Sub

    Private Sub Admin_FormClosing_1(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class