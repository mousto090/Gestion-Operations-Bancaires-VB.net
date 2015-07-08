Public Class solde

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Controls.Remove(Form1.sl)
        Form1.Controls.Remove(Form1.a)
        Form1.op.Location = New Point(12, 143)
        Form1.Controls.Add(Form1.op)
    End Sub
End Class
