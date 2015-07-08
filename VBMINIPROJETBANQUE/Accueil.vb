Public Class Accueil
    Public a As String, x As String
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ----------- Banque ------------
        Authentification.Visible = False
        LOGIN.Enabled = False

    End Sub

    Private Sub Banque_Click(sender As Object, e As EventArgs) Handles Banque.Click
        If (Authentification.Visible = False) Then
            Authentification.Visible = True
            T_Utilisateur.Focus()
            T_Utilisateur.Text = ""
            T_MDP.Text = ""
        Else
            Authentification.Visible = False
        End If
    End Sub

    Private Sub T_Utilisateur_TextChanged(sender As Object, e As EventArgs) Handles T_Utilisateur.TextChanged, T_MDP.TextChanged
        If (T_Utilisateur.Text <> "" And T_MDP.Text <> "") Then
            LOGIN.Enabled = True
        Else
            LOGIN.Enabled = False
        End If
    End Sub

    Private Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click
        Dim b As Integer
        x = T_Utilisateur.Text
        executercmdreader("select count(*) from AGENTS where CIN_AGENT='" + T_Utilisateur.Text + "' and MOTPASS_AGENT='" + T_MDP.Text.Replace("'", "''") + "'")
        dr.Read()
        b = dr(0)
        dr.Close()

        If (T_Utilisateur.Text = "Admin" And T_MDP.Text = "1234") Then
            Me.Hide()
            Admin.Show()

            T_Utilisateur.Text = ""
            T_MDP.Text = ""
        ElseIf b = 1 Then

            Me.Hide()
            Agent.Show()
            executercmdreader("select NOM_AGENT+SPACE(2)+PRENOM_AGENT from AGENTS where CIN_AGENT='" + T_Utilisateur.Text + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            Agent.AGENTS.Text = a
            T_Utilisateur.Text = ""
            T_MDP.Text = ""
        ElseIf (T_Utilisateur.Text = "Direc" And T_MDP.Text = "1234") Then
            Me.Hide()
            Directeur.Show()
            T_Utilisateur.Text = ""
            T_MDP.Text = ""
        Else
            MsgBox("Le Nom d'utilisateur ou bien le mot de passe est incorrect")
        End If
    End Sub

    Private Sub Guichet_Click(sender As Object, e As EventArgs) Handles Guichet.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub T_MDP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_MDP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim b As Integer
            x = T_Utilisateur.Text
            executercmdreader("select count(*) from AGENTS where CIN_AGENT='" + T_Utilisateur.Text + "' and MOTPASS_AGENT='" + T_MDP.Text.Replace("'", "''") + "'")
            dr.Read()
            b = dr(0)
            dr.Close()
            If (T_Utilisateur.Text = "Admin" And T_MDP.Text = "1234") Then
                Me.Hide()
                Admin.Show()
                T_Utilisateur.Text = ""
                T_MDP.Text = ""
            ElseIf b = 1 Then
                Me.Hide()
                Agent.Show()
                executercmdreader("select NOM_AGENT+SPACE(2)+PRENOM_AGENT from AGENTS where CIN_AGENT='" + T_Utilisateur.Text + "'")
                dr.Read()
                a = dr(0)
                dr.Close()
                Agent.AGENTS.Text = a
                T_Utilisateur.Text = ""
                T_MDP.Text = ""
            ElseIf (T_Utilisateur.Text = "Direc" And T_MDP.Text = "1234") Then
                Me.Hide()
                Directeur.Show()
                T_Utilisateur.Text = ""
                T_MDP.Text = ""
            Else
                MsgBox("erreur")
            End If
        End If
    End Sub
End Class
