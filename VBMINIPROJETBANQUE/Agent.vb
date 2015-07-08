Public Class Agent

    Private Sub Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ----------- Panel Principal ----------
        PCONDITION.Visible = False
        PCLIENT.Visible = False
        PCOMPTE.Visible = False
        POPERATION.Visible = False
        PDEMAND.Visible = False
        PRECHERCHE.Visible = False
        PABOUT.Visible = False
        PBIENVENU.Visible = True

        ' ----------- Panel Condiction ----------
        ETAPESUI.Enabled = False

        ' ----------- Panel clients ----------
        CCIVCLI.Items.Add("Homme")
        CCIVCLI.Items.Add("Femme")

        ' ----------- Panel Comptes ----------

        TSOLDCOM.Text = ""

        ' ----------- Panel Operations ----------
        CTYPEOPE.Items.Add("Retrait")
        CTYPEOPE.Items.Add("Depot")
        CTYPEOPE.Items.Add("Virement Intern")
        CTYPEOPE.Items.Add("Virement Extern")
        CTYPEOPE.SelectedIndex = 0
        NUMCOMRECUOPE.Visible = False
        NOMPRERECUCLI.Visible = False
        CNUMCOMRECUOPE.Visible = False
        TNOMPRERECUCLI.Visible = False



        ' ----------- Panel Demandes ----------

        ' ----------- Panel Recherche ----------



    End Sub


    Private Sub LOGAOUTAGENT_Click(sender As Object, e As EventArgs) Handles LOGAOUTAGENT.Click
        Me.Hide()
        Accueil.Show()
        Accueil.T_Utilisateur.Focus()

    End Sub

    ' ----------- Menu Principal ----------
    Private Sub NEWCLI_Click(sender As Object, e As EventArgs) Handles NEWCLI.Click
        PCONDITION.Visible = True
        PCLIENT.Visible = False
        PCOMPTE.Visible = False
        POPERATION.Visible = False
        PDEMAND.Visible = False
        PRECHERCHE.Visible = False
        PABOUT.Visible = False
        PBIENVENU.Visible = False
    End Sub

    Private Sub NEWCOM_Click(sender As Object, e As EventArgs) Handles NEWCOM.Click
        PCONDITION.Visible = False
        PCLIENT.Visible = False
        PCOMPTE.Visible = True
        POPERATION.Visible = False
        PDEMAND.Visible = False
        PRECHERCHE.Visible = False
        PABOUT.Visible = False
        PBIENVENU.Visible = False
        remplir_combo("select CIN_CLIENT from CLIENTS", CCINCLICOM)
    End Sub

    Private Sub NEWOPER_Click(sender As Object, e As EventArgs) Handles NEWOPER.Click
        PCONDITION.Visible = False
        PCLIENT.Visible = False
        PCOMPTE.Visible = False
        POPERATION.Visible = True
        PDEMAND.Visible = False
        PRECHERCHE.Visible = False
        PABOUT.Visible = False
        PBIENVENU.Visible = False
        CTYPEOPE.SelectedIndex = -1
        remplir_combo("select NUMERO_COMPTE from COMPTES where ETAT_COMPTE='Interieur'", CNUMCOMOPE)
    End Sub

    Private Sub NEWDEM_Click(sender As Object, e As EventArgs) Handles NEWDEM.Click
        PCONDITION.Visible = False
        PCLIENT.Visible = False
        PCOMPTE.Visible = False
        POPERATION.Visible = False
        PDEMAND.Visible = True
        PRECHERCHE.Visible = False
        PABOUT.Visible = False
        PBIENVENU.Visible = False
        remplir_combo("select NUMERO_COMPTE from COMPTES", CNUMCOMDEM)

    End Sub

    Private Sub RECHERCHE_Click(sender As Object, e As EventArgs) Handles RECHERCHE.Click
        PCONDITION.Visible = False
        PCLIENT.Visible = False
        PCOMPTE.Visible = False
        POPERATION.Visible = False
        PDEMAND.Visible = False
        PRECHERCHE.Visible = True
        PABOUT.Visible = False
        PBIENVENU.Visible = False
        remplir_combo("select CIN_CLIENT from CLIENTS", CRECHERCHECLIENT)
        remplir_combo("select NUMERO_COMPTE from COMPTES", CRECHERCHECOMPTE)
    End Sub
    Private Sub ABOUT_Click(sender As Object, e As EventArgs) Handles ABOUT.Click
        PCONDITION.Visible = False
        PCLIENT.Visible = False
        PCOMPTE.Visible = False
        POPERATION.Visible = False
        PDEMAND.Visible = False
        PRECHERCHE.Visible = False
        PABOUT.Visible = True
        PBIENVENU.Visible = False
    End Sub


    ' ----------- Panel Condiction ----------
    Private Sub ETAPESUI_Click(sender As Object, e As EventArgs) Handles ETAPESUI.Click
        PCONDITION.Visible = False
        PCLIENT.Visible = True
        PCOMPTE.Visible = False
        POPERATION.Visible = False
        PDEMAND.Visible = False
        PRECHERCHE.Visible = False
    End Sub

    Private Sub VIDERLEST_Click(sender As Object, e As EventArgs) Handles VIDERLEST.Click
        CHID.Checked = False
        CHJU.Checked = False
        CHSP.Checked = False
        CHPH.Checked = False
        CHAT.Checked = False
        CONDI1.Checked = False
        CONDI2.Checked = False
        CONDI3.Checked = False
    End Sub

    Private Sub CHID_CheckedChanged(sender As Object, e As EventArgs) Handles CHID.CheckedChanged, CHJU.CheckedChanged, CHSP.CheckedChanged, CHPH.CheckedChanged, CHAT.CheckedChanged, CONDI1.CheckedChanged, CONDI2.CheckedChanged, CONDI3.CheckedChanged
        If (CHID.Checked = True And CHJU.Checked = True And CHSP.Checked = True And CHPH.Checked = True And CHAT.Checked = True And CONDI1.Checked = True And CONDI2.Checked = True And CONDI3.Checked = True) Then
            ETAPESUI.Enabled = True
        Else
            ETAPESUI.Enabled = False
        End If
    End Sub



    ' ----------- Panel Clients ----------
    Private Sub ETAPEPRE_Click(sender As Object, e As EventArgs) Handles ETAPEPRE.Click
        PCONDITION.Visible = True
        PCLIENT.Visible = False
        PCOMPTE.Visible = False
        POPERATION.Visible = False
        PDEMAND.Visible = False
        PRECHERCHE.Visible = False
    End Sub

    Private Sub VIDCHMAP_Click(sender As Object, e As EventArgs) Handles VIDCHMAP.Click
        TCINCLI.Text = ""
        TNOMCLI.Text = ""
        TPRECLI.Text = ""
        TDNCLI.Text = Now.Date
        TTELCLI.Text = ""
        TEMAILCLI.Text = ""
        TADDCLI.Text = ""
        TNATCLI.Text = ""
        CCIVCLI.SelectedIndex = -1
    End Sub

    Private Sub VALIDNEWCLI_Click(sender As Object, e As EventArgs) Handles VALIDNEWCLI.Click
        Try

            executercmd("insert into CLIENTS values('" + TCINCLI.Text.Replace("'", "''") + "','" + TNOMCLI.Text.Replace("'", "''") + "','" + TPRECLI.Text.Replace("'", "''") + "','" + TDNCLI.Value + "','" + TTELCLI.Text.Replace("'", "''") + "','" + TEMAILCLI.Text.Replace("'", "''") + "','" + TADDCLI.Text.Replace("'", "''") + "','" + TNATCLI.Text.Replace("'", "''") + "','" + CCIVCLI.Text + "')")
            MsgBox("Ajout effectué")
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    ' ----------- Panel Demandes ----------
    Private Sub METTREAZERO_Click(sender As Object, e As EventArgs) Handles METTREAZERO.Click
        Dim a As String
        executercmd("update COMPTES set SOLDE_COMPTE='0' where NUMERO_COMPTE='" + CNUMCOMDEM.Text + "'")
        executercmdreader("select SOLDE_COMPTE from COMPTES  where NUMERO_COMPTE='" + CNUMCOMDEM.Text + "'")
        dr.Read()
        a = dr(0)
        dr.Close()
        TSOLDECOMDEM.Text = a

    End Sub

    Private Sub VIDERLESCHAMPSDEM_Click(sender As Object, e As EventArgs) Handles VIDERLESCHAMPSDEM.Click
        CNUMCOMDEM.SelectedIndex = -1
        TNOMPREDEMCLI.Text = ""
        TDATEOUVERDEM.Text = ""
        TSOLDECOMDEM.Text = ""
    End Sub

    Private Sub VALIDERDEMANDE_Click(sender As Object, e As EventArgs) Handles VALIDERDEMANDE.Click
        Try
            Dim a As String
            executercmd("insert into DEMANDES values('Fermeture','" + Date.Now + "','False')")
            executercmdreader("select max(ID_DEMANDE) from DEMANDES ")
            dr.Read()
            a = dr(0)
            dr.Close()
            executercmd("insert into FAIRE_DES_DEMANDE values('" + Accueil.x + "','" + CNUMCOMDEM.Text + "','" + a + "')")
            MsgBox("Demande envoyer")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    ' ----------- Panel Recherche ----------


    Private Sub CNUMCOMDEM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CNUMCOMDEM.SelectedIndexChanged
        Dim a As String, b As String, c As String
        If CNUMCOMDEM.Text <> "" Then
            executercmdreader("select cl.NOM_CLIENT+SPACE(2)+cl.PRENOM_CLIENT,c.DATEOUVERTURE_COMPTE,c.SOLDE_COMPTE from COMPTES c join CLIENTS cl on cl.CIN_CLIENT=c.CIN_CLIENT where NUMERO_COMPTE='" + CNUMCOMDEM.Text + "'")
            dr.Read()
            a = dr(0)
            b = dr(1)
            c = dr(2)
            dr.Close()
            TNOMPREDEMCLI.Text = a
            TDATEOUVERDEM.Text = b
            TSOLDECOMDEM.Text = c
        Else
            a = ""
            b = ""
            c = ""
        End If
        
    End Sub

    Private Sub CRECHERCHECLIENT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CRECHERCHECLIENT.SelectedIndexChanged
        CRECHERCHECOMPTE.Items.Clear()
        remplir_combo("select NUMERO_COMPTE from COMPTES where CIN_CLIENT='" + CRECHERCHECLIENT.Text + "'", CRECHERCHECOMPTE)
    End Sub

    Private Sub CRECHERCHECOMPTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CRECHERCHECOMPTE.SelectedIndexChanged
        Dim a, b, c, d, x, f, g, h, i, j As String
        executercmdreader("select c.CIN_CLIENT,cl.NOM_CLIENT+space(2)+cl.PRENOM_CLIENT,c.NUMERO_COMPTE,c.SOLDE_COMPTE,c.DATEOUVERTURE_COMPTE,cl.DATENAISSANCE_CLIENT,cl.TELEPHONE_CLIENT,cl.EMAIL_CLIENT,cl.ADRESSE_CLIENT,cl.NATIONALITE_CLIENT from COMPTES c join CLIENTS cl on cl.CIN_CLIENT=c.CIN_CLIENT where c.NUMERO_COMPTE='" + CRECHERCHECOMPTE.Text + "'")
        dr.Read()
        a = dr(0)
        b = dr(1)
        c = dr(2)
        d = dr(3)
        x = dr(4)
        f = dr(5)
        g = dr(6)
        h = dr(7)
        i = dr(8)
        j = dr(9)
        dr.Close()
        TCINCLIRECH.Text = a
        TNOMPRECLIRECH.Text = b
        TNUMCOMRECH.Text = c
        TSOLDECOMRECH.Text = d
        TDATEOUVERRECH.Text = x
        TDATENAISSRECH.Text = f
        TTELCLIRECH.Text = g
        TEMAILCLIRECH.Text = h
        TADRESSCLIRECH.Text = i
        TNATCLIRECH.Text = j

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Timer1.Start()

        id = GetDeviceId()
        If id <> "" Then
            TNUMCOM.Text = id
            Form1.Timer1.Stop()
        End If
    End Sub

    ' ----------- Panel Comptes ----------

    Private Sub VALIDCOMPTE_Click_1(sender As Object, e As EventArgs) Handles VALIDCOMPTE.Click
        Try
            If TPASSCOM.Text = TREPASSCOM.Text Then
                executercmd("insert into COMPTES (NUMERO_COMPTE,CIN_AGENT,CIN_CLIENT,SOLDE_COMPTE,DATEOUVERTURE_COMPTE,MOTPASS_COMPTE,ETAT_COMPTE,ACTIVE_COMPTE) values('" + TNUMCOM.Text.Replace("'", "''") + "','" + Accueil.x + "','" + CCINCLICOM.Text + "','" + TSOLDCOM.Text.Replace("'", "''") + "','" + TDOCOM.Value + "','" + TREPASSCOM.Text + "','Interieur','True')")
                MsgBox("Ajout effectué")
            Else
                MsgBox("Mots de passes non identiquent")
                TREPASSCOM.Clear()
                TREPASSCOM.Focus()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VIDCHAM_Click_1(sender As Object, e As EventArgs) Handles VIDCHAM.Click
        CCINCLICOM.SelectedIndex = -1
        TNUMCOM.Text = ""
        TSOLDCOM.Text = ""
        TDOCOM.Value = Now.Date
        TPASSCOM.Text = ""
        TREPASSCOM.Text = ""
    End Sub
    ' operation

    Private Sub VIDECHAMPS_Click_1(sender As Object, e As EventArgs) Handles VIDECHAMPS.Click

        CTYPEOPE.SelectedIndex = -1
        CNUMCOMOPE.SelectedIndex = -1
        TNOMPRECLI.Text = ""
        TMANTANTOPE.Text = ""
        CNUMCOMRECUOPE.SelectedIndex = -1
        TNOMPRERECUCLI.Text = ""
    End Sub

    Private Sub CTYPEOPE_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CTYPEOPE.SelectedIndexChanged
        If (CTYPEOPE.SelectedItem = "Virement Intern") Then
            CNUMCOMRECUOPE.Items.Clear()
            CNUMCOMRECUOPE.Items.Add("Intern")

            NUMCOMRECUOPE.Visible = True
            NOMPRERECUCLI.Visible = True
            CNUMCOMRECUOPE.Visible = True
            TNOMPRERECUCLI.Visible = True
        ElseIf (CTYPEOPE.SelectedItem = "Virement Extern") Then
            CNUMCOMRECUOPE.Items.Clear()
            CNUMCOMRECUOPE.Items.Add("Extern")

            NUMCOMRECUOPE.Visible = True
            NOMPRERECUCLI.Visible = True
            CNUMCOMRECUOPE.Visible = True
            TNOMPRERECUCLI.Visible = True
        Else
            NUMCOMRECUOPE.Visible = False
            NOMPRERECUCLI.Visible = False
            CNUMCOMRECUOPE.Visible = False
            TNOMPRERECUCLI.Visible = False
        End If
       

    End Sub

    Private Sub CNUMCOMOPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CNUMCOMOPE.SelectedIndexChanged
        If CNUMCOMOPE.SelectedIndex = -1 Then
            TNOMPRECLI.Text = ""
        Else
            Dim a As String
            executercmdreader("select cl.NOM_CLIENT+SPACE(2)+cl.PRENOM_CLIENT from COMPTES c join CLIENTS cl on cl.CIN_CLIENT=c.CIN_CLIENT  where c.NUMERO_COMPTE='" + CNUMCOMOPE.Text + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            TNOMPRECLI.Text = a
            If CTYPEOPE.Text = "Virement Intern" Then
                remplir_combo("select NUMERO_COMPTE from COMPTES where ETAT_COMPTE='Interieur' and NUMERO_COMPTE not like '" + CNUMCOMOPE.Text + "'", CNUMCOMRECUOPE)
            ElseIf CTYPEOPE.Text = "Virement Extern" Then
                remplir_combo("select NUMERO_COMPTE from COMPTES where ETAT_COMPTE='Exterieur' ", CNUMCOMRECUOPE)
            End If
        End If
        
    End Sub

    Private Sub CNUMCOMRECUOPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CNUMCOMRECUOPE.SelectedIndexChanged
        If CNUMCOMRECUOPE.SelectedIndex = -1 Then
            TNOMPRERECUCLI.Text = ""
        Else
            Dim a As String
            executercmdreader("select cl.NOM_CLIENT+SPACE(2)+cl.PRENOM_CLIENT from COMPTES c join CLIENTS cl on cl.CIN_CLIENT=c.CIN_CLIENT  where c.NUMERO_COMPTE='" + CNUMCOMRECUOPE.Text + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            TNOMPRERECUCLI.Text = a
        End If
    End Sub

    Private Sub VALIDOPERATION_Click(sender As Object, e As EventArgs) Handles VALIDOPERATION.Click
        Dim a As Double, b As Double, som As String, ido As String, x As Double, sus As String

        If CTYPEOPE.Text = "Virement Extern" Then
            executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + CNUMCOMOPE.Text + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            b = Val(TMANTANTOPE.Text)
            sus = a - b
            executercmdreader("select SOLDE_COMPTE from COMPTES where ETAT_COMPTE='Exterieur' and NUMERO_COMPTE='" + CNUMCOMRECUOPE.Text + "'")
            dr.Read()
            x = dr(0)
            dr.Close()
            som = x + b
            executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + CNUMCOMRECUOPE.Text + "'")
            executercmd("Update COMPTES set SOLDE_COMPTE='" + sus + "' where NUMERO_COMPTE='" + CNUMCOMOPE.Text + "'")
            executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATIONnCIN_AGENT) VALUES('Virement','" + Date.Now + "','" + TimeOfDay + "','" + TMANTANTOPE.Text + "','" + Accueil.x + "')")
            executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
            dr.Read()
            ido = dr(0)
            dr.Close()
            executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION,ETAT) VALUES('" + CNUMCOMOPE.Text + "','" + ido + "','Externe')")
            MsgBox("Operation effectué")

        ElseIf CTYPEOPE.Text = "Virement Intern" Then
            executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + CNUMCOMOPE.Text + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            b = Val(TMANTANTOPE.Text)
            sus = a - b
            executercmdreader("select SOLDE_COMPTE from COMPTES where ETAT_COMPTE='Interieur' and NUMERO_COMPTE='" + CNUMCOMRECUOPE.Text + "'")
            dr.Read()
            x = dr(0)
            dr.Close()
            som = x + b
            executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + CNUMCOMRECUOPE.Text + "'")
            executercmd("Update COMPTES set SOLDE_COMPTE='" + sus + "' where NUMERO_COMPTE='" + CNUMCOMOPE.Text + "'")
            executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION,CIN_AGENT) VALUES('Virement','" + Date.Now + "','" + TimeOfDay + "','" + TMANTANTOPE.Text + "','" + Accueil.x + "')")
            executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
            dr.Read()
            ido = dr(0)
            dr.Close()
            executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION,ETAT) VALUES('" + CNUMCOMOPE.Text + "','" + ido + "','Interne')")
            MsgBox("Operation effectué")
        ElseIf CTYPEOPE.Text = "Retrait" Then
            executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + CNUMCOMOPE.Text + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            b = Val(TMANTANTOPE.Text)
            som = a - b
            executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + CNUMCOMOPE.Text + "'")
            executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION,CIN_AGENT) VALUES('Retrait','" + Date.Now + "','" + TimeOfDay + "','" + TMANTANTOPE.Text + "','" + Accueil.x + "')")
            executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
            dr.Read()
            ido = dr(0)
            dr.Close()
            executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + CNUMCOMOPE.Text + "','" + ido + "')")
            MsgBox("Operation effectué")
        ElseIf CTYPEOPE.Text = "Depot" Then
            executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + CNUMCOMOPE.Text + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            b = Val(TMANTANTOPE.Text)
            som = a + b
            executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + CNUMCOMOPE.Text + "'")
            executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION,CIN_AGENT) VALUES('Dépôt','" + Date.Now + "','" + TimeOfDay + "','" + TMANTANTOPE.Text + "','" + Accueil.x + "')")
            executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
            dr.Read()
            ido = dr(0)
            dr.Close()
            executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + CNUMCOMOPE.Text + "','" + ido + "')")
            MsgBox("Operation effectué")
        End If
    End Sub

    Private Sub Agent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class