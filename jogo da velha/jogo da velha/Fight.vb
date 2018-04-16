Public Class frmFight

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
        If frmMultiplayer.Tag = "sim" Then
            frmMultiplayer.Show()
        End If

        If frmCpu1.Tag = "sim" Then
            frmCpu1.Show()
        End If

        Timer1.Stop()
    End Sub

    Private Sub frmFight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub pcbfigth_Click(sender As Object, e As EventArgs) Handles pcbfigth.Click

    End Sub
End Class