Public Class operation

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        executercmdreader("select SOLDE_COMPTE from COMPTES where NUMERO_COMPTE='" + id + "'")
        dr.Read()
        Form1.sl.TextBox1.Text = dr(0)
        dr.Close()
        Form1.Controls.Remove(Form1.op)
        Form1.Controls.Remove(Form1.a)
        Form1.sl.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.sl)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        remplirdatagrid("select TYPE_OPERATION,DATE_OPERATION,HEURE_OPERATION,MONTANT_OPERATION from OPERATIONS", Form1.con.DataGridView1)
        Form1.con.DataGridView1.Columns(0).Width = 250
        Form1.con.DataGridView1.Columns(1).Width = 250
        Form1.con.DataGridView1.Columns(2).Width = 250
        Form1.con.DataGridView1.Columns(3).Width = 230
        Form1.Controls.Remove(Form1.op)
        Form1.Controls.Remove(Form1.a)
        Form1.con.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.con)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.Controls.Remove(Form1.op)
        Form1.Controls.Remove(Form1.a)
        Form1.r.PictureBox11.Visible = False
        Form1.r.Panel1.Visible = False
        Form1.r.TextBox1.Clear()
        Form1.r.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.r)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form1.Controls.Remove(Form1.op)
        Form1.Controls.Remove(Form1.a)
        Form1.de.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.de)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form1.Controls.Remove(Form1.op)
        Form1.Controls.Remove(Form1.a)
        Form1.vi.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.vi)
        Form1.vi.ComboBox1.SelectedIndex = -1
        Form1.vi.TextBox1.Clear()
        Form1.vi.TextBox2.Clear()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Form1.Controls.Remove(Form1.op)
        Form1.Controls.Remove(Form1.r)
        Form1.Controls.Remove(Form1.a)
        Form1.an.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.an)
    End Sub
End Class
