Public Class frmGrupo 

    Private Sub fncLimpiar()
        Try
            txtCodigo.Text = ""
            txtNombre.Text = ""
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub
    Private Function fncGuardar() As Boolean
        Try
            Dim strsql As String
            strsql = "select count(*) as cantidad from grupo where id = '" & txtCodigo.Text & "'"





        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Function
    Private Function FncValidar() As Boolean
        Try
            If Trim(txtNombre.Text) = "" Then
                DxError.SetError(txtNombre, "Campo Obligatorio")
                Return False
            Else
                DxError.SetError(txtNombre, "")
            End If


            Return True

        Catch ex As Exception
            MessageBox.Show(Err.Description)
            Return False
        End Try
    End Function

    Private Sub btnNuevoResAmbulatoria_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoResAmbulatoria.Click
        fncLimpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

    End Sub
End Class