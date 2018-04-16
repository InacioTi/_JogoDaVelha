Public Class frmjogo


    Private Sub btnvs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvs.Click
        frmMultiplayer.Tag = "sim"
        frmEscolha_o_Jogador.ShowDialog()
        frmEscolha_o_Jogador.txtjogador1.Clear()
        frmEscolha_o_Jogador.pcbpl1.Image = Nothing
        frmEscolha_o_Jogador_2.txtjogador2.Clear()
        frmEscolha_o_Jogador_2.pcbpl2.Image = Nothing

    End Sub

    Private Sub frmjogo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'botão fechar formulario com opção
        e.Cancel = Not MsgBox("Deseja encerrar o sistema ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Encerrando") = MsgBoxResult.Yes
    End Sub

    Private Sub btnn1_CausesValidationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnn1.CausesValidationChanged

    End Sub

    Private Sub btnv2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnv2.Click


    End Sub

    Private Sub btnn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnn1.Click
        frmCpu1.Tag = "sim"
        frmEscolha_o_Jogador.ShowDialog()
        frmEscolha_o_Jogador.txtjogador1.Clear()
        frmEscolha_o_Jogador.pcbpl1.Image = Nothing
        frmEscolha_o_Jogador_2.txtjogador2.Clear()
        frmEscolha_o_Jogador_2.pcbpl2.Image = Nothing
        frmEscolha_o_Jogador_2.lblVez.Text = "CPU escolhe"
    End Sub


End Class