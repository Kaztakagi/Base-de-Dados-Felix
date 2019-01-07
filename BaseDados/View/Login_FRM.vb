Imports BaseDados.My.Resources
Imports System.Data.SqlClient
Public Class Login_FRM

    Private Sub Login_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NovoUtilizador_card.Visible = False
    End Sub

    Private Sub Utilizador_TextBox_TextChange(sender As Object, e As EventArgs) Handles Utilizador_TextBox.TextChange
        Me.Utilizador_TextBox.CharacterCasing = CharacterCasing.Upper
        If Utilizador_TextBox.Text = "PT00370979" Then ProfileFoto_PictureBox.Image = Foto Else ProfileFoto_PictureBox.Image = Profile
    End Sub

    Private Sub Cancel_BTN_Click(sender As Object, e As EventArgs) Handles Cancel_BTN.Click
        Me.Close()

    End Sub

    Private Sub Login_BTN_Click(sender As Object, e As EventArgs) Handles Login_BTN.Click

        '***Falta configuração para inserção da foto aquando uma correpondencia exata do utilizador a inserir na caixa de utilizador
        '***Abaixo exemplo pratico
        'If Utilizador_TextBox.Text = "PT00370979" Then ProfileFoto_PictureBox.Image = Foto Else ProfileFoto_PictureBox.Image = Profile

        'Dados Com Ligação á Base de Dados

        If Utilizador_TextBox.Text.Length <= 0 Then
            ErroLogin_Label.Text = "Verificar dados de Utiliador"
            ErroLogin_Label.Visible = True
        ElseIf Pass_TextBox.Text.Length < 8 Then
            ErroLogin_Label.Text = "Password Invalida"
            ErroLogin_Label.Visible = True
        End If
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Bases de Dados\VirgulaDB.mdf;Integrated Security=True;Connect Timeout=30"
        Dim sql As String = "select count(*) from UTILIZADORES where Utilizador=@Utilizador and Password=@Password"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@Utilizador", Utilizador_TextBox.Text)
                cmd.Parameters.AddWithValue("@Password", Pass_TextBox.Text)
                Dim value = cmd.ExecuteScalar()
                If value > 0 Then
                    FRM_Inicio.Show()
                    Me.Hide()
                End If
            End Using

        End Using


    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click

        'Transição animada da form de uma Card para a outra

        Login_Card.Visible = False

        BunifuTransition1.ShowSync(NovoUtilizador_card, False)

        ErroLogin_Label.Visible = False
        Info_Label.Visible = False

        NovoUtilizador_card.Visible = True

    End Sub

    Private Sub CriarConta_BTN_Click(sender As Object, e As EventArgs) Handles CriarConta_BTN.Click

        'Adiciona os campos mencionados á Base de Dados
        ''********************************************''
        ''**  FALTA CRIAR REGRA DE VALIDAÇÃO DE DADOS

        Dim insertquery As String = "INSERT INTO UTILIZADORES (Utilizador,Password,Nivel) VALUES('" & UtilizadorReg_TextBox.Text & "','" & PassReg_TextBox.Text & "','" & Nivel_TextBox.Text & "')"

        If UtilizadorReg_TextBox.Text.Length >= 1 Then

        ElseIf PassReg_TextBox.Text.Length >= 7 Then


            ExecuteQuery(insertquery)

            ErroLogin_Label.Text = "Conta criada com sucesso!!!"
            ErroLogin_Label.Visible = True
            NovoUtilizador_card.Visible = False
            Login_Card.Visible = True

        Else

            Info_Label.Text = "Verifique os dados inseridos"
            Info_Label.Visible = True
        End If


    End Sub
    Dim Connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Bases de Dados\VirgulaDB.mdf;Integrated Security=True;Connect Timeout=30")
    Public Sub ExecuteQuery(query As String)

        ''Executa a query para poder abrir e frechar a ligação á Base de Dados

        Dim Command As New SqlCommand(query, Connection)

        Connection.open()

        Command.ExecuteNonQuery()

        Connection.close()


    End Sub


    Private Sub CancelarReg_BTN_Click(sender As Object, e As EventArgs) Handles CancelarReg_BTN.Click

        NovoUtilizador_card.Visible = False
        Login_Card.Visible = True

    End Sub

    Private Sub UtilizadorReg_TextBox_TextChange(sender As Object, e As EventArgs) Handles UtilizadorReg_TextBox.TextChange
        'Para escreve sempre em Maiusculas na Caixa de Texto
        Me.UtilizadorReg_TextBox.CharacterCasing = CharacterCasing.Upper


    End Sub


End Class