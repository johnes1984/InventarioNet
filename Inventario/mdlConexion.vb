Imports System.Data.OleDb
Module mdlConexion

    Public MiConexion As OleDbConnection

    Public Sub fncAbrirconexion()
        MiConexion = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Inventario.mdb")
        MiConexion.Open()
    End Sub

    Public Function fncEjecutarConsulta(strsql As String) As DataTable
        Try
            Dim MiAdaptador As New OleDbDataAdapter(strsql, MiConexion)
            Dim dtttabla As New DataTable
            MiAdaptador.Fill(dtttabla)
            Return dtttabla

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Function

End Module
