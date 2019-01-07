Public Class FRM_Inicio
    Private Sub FRM_Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load

        Pessoas_Card.Visible = False
        PServico_Card.Visible = False
        Definicoes_Card.Visible = False
        Home_Card.Visible = True

    End Sub

    Private Sub Home_BTN_Click(sender As Object, e As EventArgs) Handles Home_BTN.Click
        Pessoas_Card.Visible = False
        PServico_Card.Visible = False
        Definicoes_Card.Visible = False
        Home_Card.Visible = True

    End Sub

    Private Sub Pessoas_BTN_Click(sender As Object, e As EventArgs) Handles Pessoas_BTN.Click

        PServico_Card.Visible = False
        Definicoes_Card.Visible = False
        Home_Card.Visible = False
        Pessoas_Card.Visible = True
    End Sub

    Private Sub PServico_BTN_Click(sender As Object, e As EventArgs) Handles PServico_BTN.Click

        Definicoes_Card.Visible = False
        Home_Card.Visible = False
        Pessoas_Card.Visible = False
        PServico_Card.Visible = True
    End Sub

    Private Sub Definicoes_BTN_Click(sender As Object, e As EventArgs) Handles Definicoes_BTN.Click

        Home_Card.Visible = False
        Pessoas_Card.Visible = False
        PServico_Card.Visible = False
        Definicoes_Card.Visible = True
    End Sub

    Private Sub Sair_PictureBox_Click(sender As Object, e As EventArgs) Handles Sair_PictureBox.Click
        Login_FRM.Close()
        Me.Close()
    End Sub


End Class
