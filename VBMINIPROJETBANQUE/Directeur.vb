Public Class Directeur

    Private Sub Directeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PCLIREC.Visible = False
        PPRIN.Visible = True
        PCLIETR.Visible = False
        PLISCLI.Visible = False


    End Sub
    Private Sub LOGAOUTAGENT_Click(sender As Object, e As EventArgs) Handles LOGAOUTAGENT.Click
        Me.Hide()
        Accueil.Show()
        Accueil.T_Utilisateur.Focus()

    End Sub




    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton1.Checked = True Or RadioButton2.Checked = True Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles LISDESCLI.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        Label1.Visible = False
        TextBox1.Visible = False
        PCLIREC.Visible = False
        PPRIN.Visible = False
        PCLIETR.Visible = False
        PLISCLI.Visible = True
    End Sub

    Private Sub CLIETR_Click(sender As Object, e As EventArgs) Handles CLIETR.Click
        PCLIREC.Visible = False
        PPRIN.Visible = False
        PCLIETR.Visible = True
        PLISCLI.Visible = False
    End Sub

    Private Sub CLIREC_Click(sender As Object, e As EventArgs) Handles CLIREC.Click
        PCLIREC.Visible = True
        PPRIN.Visible = False
        PCLIETR.Visible = False
        PLISCLI.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Visible = True
            TextBox1.Clear()

        ElseIf RadioButton2.Checked Then
            TextBox1.Visible = True
            TextBox1.Clear()

        ElseIf RadioButton3.Checked Then

            TextBox1.Visible = False
            Label1.Visible = False
            remplirdatagrid("select cl.CIN_CLIENT,cl.NOM_CLIENT,cl.PRENOM_CLIENT,cl.NATIONALITE_CLIENT,c.NUMERO_COMPTE,c.SOLDE_COMPTE from COMPTES c join CLIENTS cl on c.CIN_CLIENT=cl.CIN_CLIENT where c.ETAT_COMPTE='Interieur'", DataGridView2)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then
            remplirdatagrid("select cl.CIN_CLIENT,cl.NOM_CLIENT,cl.PRENOM_CLIENT,cl.NATIONALITE_CLIENT,c.NUMERO_COMPTE,c.SOLDE_COMPTE from COMPTES c join CLIENTS cl on c.CIN_CLIENT=cl.CIN_CLIENT where c.SOLDE_COMPTE>'" + TextBox1.Text + "'  and c.ETAT_COMPTE='Interieur'", DataGridView2)

        ElseIf RadioButton2.Checked Then
            remplirdatagrid("select cl.CIN_CLIENT,cl.NOM_CLIENT,cl.PRENOM_CLIENT,cl.NATIONALITE_CLIENT,c.NUMERO_COMPTE,c.SOLDE_COMPTE from COMPTES c join CLIENTS cl on c.CIN_CLIENT=cl.CIN_CLIENT where c.SOLDE_COMPTE<'" + TextBox1.Text + "'  and c.ETAT_COMPTE='Interieur'", DataGridView2)
        End If
    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        remplir_combo("select distinct cl.NATIONALITE_CLIENT from COMPTES c join CLIENTS cl on c.CIN_CLIENT=cl.CIN_CLIENT where  c.ETAT_COMPTE='Interieur'", ComboBox2)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        remplirdatagrid("select cl.CIN_CLIENT,cl.NOM_CLIENT,cl.PRENOM_CLIENT,cl.NATIONALITE_CLIENT,c.NUMERO_COMPTE,c.SOLDE_COMPTE from COMPTES c join CLIENTS cl on c.CIN_CLIENT=cl.CIN_CLIENT where cl.NATIONALITE_CLIENT='" + ComboBox2.Text + "' and c.ETAT_COMPTE='Interieur'", DataGridView3)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        remplirdatagrid("select cl.CIN_CLIENT,cl.NOM_CLIENT,cl.PRENOM_CLIENT,cl.NATIONALITE_CLIENT,c.NUMERO_COMPTE,c.SOLDE_COMPTE from COMPTES c join CLIENTS cl on c.CIN_CLIENT=cl.CIN_CLIENT where c.ETAT_COMPTE='Interieur' and c.DATEOUVERTURE_COMPTE='" + DateTimePicker1.Value + "'", DataGridView1)
    End Sub

    Private Sub Directeur_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class