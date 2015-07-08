Imports System.Data.SqlClient

Module declaration
    Public cnx As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=MINIPROJETBANQUE;Integrated Security=True")
    Public cmd As SqlCommand
    Public dt As DataTable
    Public dr As SqlDataReader
    Public Sub connextion()
        If cnx.State <> ConnectionState.Open Then
            cnx.Open()
        End If
    End Sub
    Public Sub preparercmd(ByVal rqt As String)
        connextion()
        cmd = New SqlCommand(rqt, cnx)
    End Sub

    Public Sub executercmd(ByVal rqt As String)
        preparercmd(rqt)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub executercmdreader(ByVal rqt As String)
        preparercmd(rqt)
        dr = cmd.ExecuteReader()
    End Sub

    Public Sub remplirdatagrid(ByVal rqt As String, ByVal d As DataGridView)
        connextion()
        cmd = New SqlCommand(rqt, cnx)
        dr = cmd.ExecuteReader
        dt = New DataTable
        dt.Load(dr)
        dr.Close()
        d.DataSource = dt
    End Sub

    Public Sub remplir_combo(ByVal rqt As String, ByVal C As ComboBox)

        connextion()
        C.Items.Clear()
        cmd = New SqlCommand(rqt, cnx)
        dr = cmd.ExecuteReader
        While (dr.Read)
            C.Items.Add(dr(0))
        End While
        dr.Close()
    End Sub
    
End Module
