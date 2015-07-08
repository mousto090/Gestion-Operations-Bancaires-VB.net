Public Class virement

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Numéro Compte Interne"
        TextBox1.ReadOnly = True
        ComboBox1.Items.Remove("Externe")
        ComboBox1.Items.Add("Interne")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "Numéro Compte Externe"
        TextBox1.ReadOnly = True
        ComboBox1.Items.Remove("Interne")
        ComboBox1.Items.Add("Externe")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Controls.Remove(Form1.de)
        Form1.Controls.Remove(Form1.vi)
        Form1.Controls.Remove(Form1.a)
        Form1.op.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.op)
    End Sub

    Private Sub virement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        Panel1.Visible = False
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim a As Double, b As Double, som As String, ido As String, x As Double, sus As String
            If Label1.Text = "Numéro Compte Externe" Then
                If ComboBox1.Text <> "" Then
                    executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
                    dr.Read()
                    a = dr(0)
                    dr.Close()
                    b = Val(TextBox2.Text)
                    sus = a - b
                    executercmdreader("select SOLDE_COMPTE from COMPTES where ETAT_COMPTE='Exterieur' and NUMERO_COMPTE='" + ComboBox1.Text + "'")
                    dr.Read()
                    x = dr(0)
                    dr.Close()
                    som = x + b
                    executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + ComboBox1.Text + "'")
                    executercmd("Update COMPTES set SOLDE_COMPTE='" + sus + "' where NUMERO_COMPTE='" + id + "'")
                    executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Virement','" + Date.Now + "','" + TimeOfDay + "','" + TextBox2.Text + "')")
                    executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
                    dr.Read()
                    ido = dr(0)
                    dr.Close()
                    executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION,ETAT) VALUES('" + id + "','" + ido + "','Externe')")
                    Panel1.Visible = True
                    ComboBox1.SelectedIndex = -1
                Else
                    TextBox1.Clear()
                    TextBox2.Clear()
                    Panel1.Visible = False



                End If

            ElseIf Label1.Text = "Numéro Compte Interne" Then
                If ComboBox1.Text <> "" Then


                    executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
                    dr.Read()
                    a = dr(0)
                    dr.Close()
                    b = Val(TextBox2.Text)
                    sus = a - b
                    executercmdreader("select SOLDE_COMPTE from COMPTES where ETAT_COMPTE='Interieur' and NUMERO_COMPTE='" + ComboBox1.Text + "'")
                    dr.Read()
                    x = dr(0)
                    dr.Close()
                    som = x + b
                    executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + ComboBox1.Text + "'")
                    executercmd("Update COMPTES set SOLDE_COMPTE='" + sus + "' where NUMERO_COMPTE='" + id + "'")
                    executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Virement','" + Date.Now + "','" + TimeOfDay + "','" + TextBox2.Text + "')")
                    executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
                    dr.Read()
                    ido = dr(0)
                    dr.Close()
                    executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION,ETAT) VALUES('" + id + "','" + ido + "','Interne')")
                    Panel1.Visible = True
                    ComboBox1.SelectedIndex = -1
                Else
                    TextBox1.Clear()
                    TextBox2.Clear()
                    Panel1.Visible = False



                End If
            End If
                ComboBox1.ResetText()
                TextBox1.Clear()
                TextBox2.Clear()

            End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim a As String
        If ComboBox1.Text <> "" Then
            executercmdreader("select cl.NOM_CLIENT+SPACE(2)+cl.PRENOM_CLIENT from COMPTES c join CLIENTS cl on cl.CIN_CLIENT=c.CIN_CLIENT  where c.NUMERO_COMPTE='" + ComboBox1.Text + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            TextBox1.Text = a
        Else
            TextBox1.Clear()

        End If


    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Panel1.Visible = False
        If Label1.Text = "Numéro Compte Externe" Then
            remplir_combo("select NUMERO_COMPTE from COMPTES where ETAT_COMPTE='Exterieur'", ComboBox1)

        ElseIf Label1.Text = "Numéro Compte Interne" Then
            remplir_combo("select NUMERO_COMPTE from COMPTES where ETAT_COMPTE='Interieur' and NUMERO_COMPTE!='" + id + "'", ComboBox1)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
