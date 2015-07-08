Public Class Form1
    Public a As New authentification
    Public r As New retrait
    Public an As New annuler
    Public mo As New montant
    Public op As New operation
    Public sl As New solde
    Public de As New depot
    Public con As New consultation
    Public vi As New virement

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        id = GetDeviceId()
        If id <> "" Then
            Panel1.Visible = False

            a.Location = New Point(12, 143)
            Me.Controls.Add(a)

        Else
            Me.Controls.Remove(a)
            Me.Controls.Remove(an)
            Me.Controls.Remove(mo)

            Panel1.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class