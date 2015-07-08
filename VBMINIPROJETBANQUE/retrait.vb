Public Class retrait

    Private Sub retrait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        PictureBox11.Visible = False


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim a As Double, b As Double, som As String, ido As String
            executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
            dr.Read()
            a = dr(0)
            dr.Close()
            b = Val(TextBox1.Text)
            som = a - b
            executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + id + "'")
            executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Retrait','" + Date.Now + "','" + TimeOfDay + "','" + TextBox1.Text + "')")
            executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
            dr.Read()
            ido = dr(0)
            dr.Close()
            executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + id + "','" + ido + "')")
            Form1.Controls.Remove(Form1.a)
            Form1.Controls.Remove(Form1.r)
            Form1.mo.Location = New Point(12, 143)
            Form1.Controls.Add(Form1.mo)
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form1.Controls.Remove(Form1.a)
        Form1.Controls.Remove(Form1.r)
        Form1.op.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.op)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Form1.Controls.Remove(Form1.r)
        Form1.Controls.Remove(Form1.a)
        Form1.an.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.an)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Panel1.Visible = True
        PictureBox11.Visible = True
        TextBox1.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim a As Double, som As String, ido As String
        executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
        dr.Read()
        a = dr(0)
        dr.Close()
        som = a - 500
        executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + id + "'")
        executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Retrait','" + Date.Now + "','" + TimeOfDay + "',500)")
        executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
        dr.Read()
        ido = dr(0)
        dr.Close()
        executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + id + "','" + ido + "')")
        Form1.Controls.Remove(Form1.a)
        Form1.Controls.Remove(Form1.r)
        Form1.mo.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.mo)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim a As Double, som As String, ido As String
        executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
        dr.Read()
        a = dr(0)
        dr.Close()
        som = a - 1000
        executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + id + "'")
        executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Retrait','" + Date.Now + "','" + TimeOfDay + "',1000)")
        executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
        dr.Read()
        ido = dr(0)
        dr.Close()
        executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + id + "','" + ido + "')")
        Form1.Controls.Remove(Form1.a)
        Form1.Controls.Remove(Form1.r)
        Form1.mo.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.mo)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim a As Double, som As String, ido As String
        executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
        dr.Read()
        a = dr(0)
        dr.Close()
        som = a - 2000
        executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + id + "'")
        executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Retrait','" + Date.Now + "','" + TimeOfDay + "',2000)")
        executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
        dr.Read()
        ido = dr(0)
        dr.Close()
        executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + id + "','" + ido + "')")
        Form1.Controls.Remove(Form1.a)
        Form1.Controls.Remove(Form1.r)
        Form1.mo.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.mo)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim a As Double, som As String, ido As String
        executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
        dr.Read()
        a = dr(0)
        dr.Close()
        som = a - 100
        executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + id + "'")
        executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Retrait','" + Date.Now + "','" + TimeOfDay + "',100)")
        executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
        dr.Read()
        ido = dr(0)
        dr.Close()
        executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + id + "','" + ido + "')")
        Form1.Controls.Remove(Form1.a)
        Form1.Controls.Remove(Form1.r)
        Form1.mo.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.mo)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim a As Double, som As String, ido As String
        executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
        dr.Read()
        a = dr(0)
        dr.Close()
        som = a - 200
        executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + id + "'")
        executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Retrait','" + Date.Now + "','" + TimeOfDay + "',200)")
        executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
        dr.Read()
        ido = dr(0)
        dr.Close()
        executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + id + "','" + ido + "')")
        Form1.Controls.Remove(Form1.a)
        Form1.Controls.Remove(Form1.r)
        Form1.mo.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.mo)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim a As Double, som As String, ido As String
        executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
        dr.Read()
        a = dr(0)
        dr.Close()
        som = a - 300
        executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + id + "'")
        executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Retrait','" + Date.Now + "','" + TimeOfDay + "',300)")
        executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
        dr.Read()
        ido = dr(0)
        dr.Close()
        executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + id + "','" + ido + "')")
        Form1.Controls.Remove(Form1.a)
        Form1.Controls.Remove(Form1.r)
        Form1.mo.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.mo)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim a As Double, som As String, ido As String
        executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
        dr.Read()
        a = dr(0)
        dr.Close()
        som = a - 400
        executercmd("Update COMPTES set SOLDE_COMPTE='" + som + "' where NUMERO_COMPTE='" + id + "'")
        executercmd("INSERT INTO OPERATIONS (TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION) VALUES('Retrait','" + Date.Now + "','" + TimeOfDay + "',400)")
        executercmdreader("select ID_OPERATION from OPERATIONS where HEURE_OPERATION='" + TimeOfDay + "'")
        dr.Read()
        ido = dr(0)
        dr.Close()
        executercmd("INSERT INTO EFFECTUER (NUMERO_COMPTE,ID_OPERATION) VALUES('" + id + "','" + ido + "')")
        Form1.Controls.Remove(Form1.a)
        Form1.Controls.Remove(Form1.r)
        Form1.mo.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.mo)
    End Sub
End Class
