Public Class depot

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Controls.Remove(Form1.de)
        Form1.Controls.Remove(Form1.a)
        Form1.op.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.op)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim a As Double, b As Double, som As String, ido As String
            executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            b = Val(TextBox1.Text)
            som = a + b
            executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + id + "'")
            executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Dépôt','" + Date.Now + "','" + TimeOfDay + "','" + TextBox1.Text + "')")
            executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
            dr.Read()
            ido = dr(0)
            dr.Close()
            executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + id + "','" + ido + "')")


            Panel1.Visible = True
            TextBox1.Clear()

        End If
    End Sub

    Private Sub depot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        TextBox1.Focus()
    End Sub
End Class
