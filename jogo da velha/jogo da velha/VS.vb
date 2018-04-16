Public Class frmVS

    Private Sub frmVS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
        frmFight.pcbfigth.Image = My.Resources.Fight
        frmFight.Show()
        Timer1.Stop()

    End Sub

End Class