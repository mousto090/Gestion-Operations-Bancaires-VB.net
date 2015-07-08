Public Class authentification

    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            executercmdreader("select count(*) from COMPTES where NUMERO_COMPTE='" + id + "' and MOTPASS_COMPTE='" + MaskedTextBox1.Text.Replace(" ", "") + "'")
            dr.Read()
            If dr(0).ToString() = 1 Then
                dr.Close()
                Form1.Controls.Remove(Form1.a)
                Form1.r.Location = New Point(12, 143)
                Form1.r.Panel1.Visible = False
                Form1.r.TextBox1.Clear()

                Form1.r.PictureBox11.Visible = False
                Form1.Controls.Add(Form1.r)
            Else
                dr.Close()
                Panel1.Visible = False
                PictureBox1.Visible = False
                Panel2.Location = New Point(444, 52)
                Panel2.Visible = True
            End If
            MaskedTextBox1.Text = ""
        End If
    End Sub

    Private Sub authentification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaskedTextBox1.Focus()

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Panel2.Visible = False
        MaskedTextBox1.Text = ""

        Panel1.Visible = True
        PictureBox1.Visible = True
    End Sub
End Class
