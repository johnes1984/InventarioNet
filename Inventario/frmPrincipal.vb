
Imports System.Data.OleDb

Public Class frmPrincipal

    Private Sub btnGrupo_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrupo.ItemClick
        fncAbrirconexion()

     
        Dim dtttabla As DataTable
        dtttabla = fncEjecutarConsulta("select * from grupo")



        frmGrupo.MdiParent = Me
        frmGrupo.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class