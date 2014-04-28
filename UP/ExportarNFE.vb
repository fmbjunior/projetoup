Imports System.IO
Public Class ExportarNFE
    Dim vOpt As String = String.Empty
    Private Sub opt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt1.CheckedChanged, opt2.CheckedChanged, opt4.CheckedChanged, opt3.CheckedChanged

        Select Case DirectCast(sender, RadioButton).Name
            Case "opt1"
                vOpt = 1
                Me.lblCodigo.Visible = False
                Me.txtCodigo.Visible = False

            Case "opt2"
                vOpt = 2
                Me.lblCodigo.Visible = False
                Me.txtCodigo.Visible = False

            Case "opt3"
                vOpt = 3
                Me.lblCodigo.Visible = True
                Me.txtCodigo.Visible = True
                Me.txtCodigo.Focus()

            Case "opt4"
                vOpt = 4
                Me.lblCodigo.Visible = True
                Me.txtCodigo.Visible = True
                Me.txtCodigo.Focus()
        End Select


    End Sub

    Private Sub BtGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGerar.Click

        'Criar conexao
        Dim cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        'Abrir conexao.
        cnn.Open()

        Dim sSql As String = String.Empty
        Dim sSql1 As String = String.Empty
        Select Case vOpt

            Case 1 'Todos os clientes
                sSql = "SELECT Mid([TipoPessoa],1,1) AS xTipoPessoa, Mid([CpfCgc],1,18) AS xCpfCgc, Mid([Insc],1,14) AS xInsc, Mid([Nome],1,80) AS xNome, Mid([NomeFantasia],1,80) AS xNomeFantasia, Mid([Endereço],1,60) AS xEndereço, Mid([Nro],1,6) AS xNro, Mid([xCpl],1,50) AS xxCpl, Mid([cMun],1,7) AS xcMun, Mid([Bairro],1,50) AS xBairro, Mid([cep],1,9) AS xCep, Mid([cUF],1,2) AS xcUF, Mid([Pais],1,15) AS xPais, Mid([Telefone],1,13) AS xTelefone, Clientes.Cidade as xCidade, clientes.Estado as xEstado, Clientes.Inativo as xInativo, Clientes.Email as xEmail FROM(Clientes) WHERE (((Mid([Insc],1,1)) Is Not Null) AND ((Mid([Nome],1,80)) Is Not Null) AND ((Mid([Endereço],1,60)) Is Not Null) AND ((Mid([Nro],1,6)) Is Not Null) AND ((Mid([cMun],1,7)) Is Not Null) AND ((Mid([cUF],1,2)) Is Not Null) AND ((Mid([Pais],1,15)) Is Not Null) AND ((Mid([CpfCgc],1,18)) Is Not Null))" ' lelo incluindo campo inativo
                'sSql = "SELECT Mid([TipoPessoa],1,1) AS xTipoPessoa, Mid([CpfCgc],1,18) AS xCpfCgc, Mid([Insc],1,14) AS xInsc, Mid([Nome],1,80) AS xNome, Mid([NomeFantasia],1,80) AS xNomeFantasia, Mid([Endereço],1,60) AS xEndereço, Mid([Nro],1,6) AS xNro, Mid([xCpl],1,50) AS xxCpl, Mid([cMun],1,7) AS xcMun, Mid([Bairro],1,50) AS xBairro, Mid([cep],1,9) AS xCep, Mid([cUF],1,2) AS xcUF, Mid([Pais],1,15) AS xPais, Mid([Telefone],1,13) AS xTelefone, Clientes.Cidade as xCidade, clientes.Estado as xEstado, Clientes.Email FROM(Clientes) WHERE (((Mid([Insc],1,1)) Is Not Null) AND ((Mid([Nome],1,80)) Is Not Null) AND ((Mid([Endereço],1,60)) Is Not Null) AND ((Mid([Nro],1,6)) Is Not Null) AND ((Mid([cMun],1,7)) Is Not Null) AND ((Mid([cUF],1,2)) Is Not Null) AND ((Mid([Pais],1,15)) Is Not Null) AND ((Mid([CpfCgc],1,18)) Is Not Null))"
                sSql1 = "SELECT Mid([id],1,4) AS xId, Mid([CpfCgc],1,18) AS xCpfCgc, Mid([cliente],1,18) AS xCliente, Mid([NomePropriedade],1,50) AS xNomePropriedade, Mid([Endereco],1,50) AS xEndereco, Mid([Propriedades].[cMun],1,7) AS xcMun, Mid([Propriedades].[cUf],1,2) AS xcUf, Mid([Propriedades].[Nro],1,6) AS xNro, Mid([Inscricao],1,20) AS xInscricao, Propriedades.Estado AS xEstado, Propriedades.Cidade AS xCidade FROM Clientes INNER JOIN Propriedades ON Clientes.Codigo = Propriedades.Cliente WHERE (((Mid([CpfCgc],1,18)) Is Not Null) AND ((Mid([cliente],1,18)) Is Not Null) AND ((Mid([NomePropriedade],1,50)) Is Not Null) AND ((Mid([Endereco],1,50)) Is Not Null) AND ((Mid([Propriedades].[cMun],1,7)) Is Not Null) AND ((Mid([Propriedades].[cUf],1,2)) Is Not Null) AND ((Mid([Propriedades].[Nro],1,6)) Is Not Null) AND ((Mid([Inscricao],1,20)) Is Not Null))  and propriedades.Inativo = false"

            Case 2 'todos os produtos                
                sSql = "SELECT CodigoProduto As CodigoERP, Mid([CodigoNfe],1,20) AS xCodigoProduto, Mid([Descrição],1,80) AS xDescrição, Produtos.UnidadeMedida, Mid([UnidadeMedida],1,6) AS uTrib, Produtos.ValorVenda, Mid([ValorVenda],1,8) AS vUnTrib, Mid([cf],1,8) AS xCF, Mid([Cst],1,3) AS xCst, Mid([Ean],1,13) AS xEan, Mid([cEanTrib],1,13) AS xcEanTrib, Mid([cstIPI],1,2) AS xcstIPI, Mid([cstCofins],1,2) AS xcstCofins, Mid([CstPIS],1,2) AS xCstPIS, Mid([Icms],1,8) AS xIcms, Mid([OrigemIcms],1,1) AS xOrigemIcms, Mid([ModBcIcms],1,1) AS xModBcIcms, Mid([TcalcIPI],1,1) AS xTcalcIPI, Mid([Ipi],1,8) AS xIpi, Mid([pPIS],1,8) AS xpPIS, Mid([pCofins],1,8) AS xpCofins, Mid([cEnq],1,3) AS xcEnq, 1 AS qTrib, Mid([Unidademedida],1,6) AS uCom, Inativo FROM Produtos WHERE (((Mid([Descrição],1,8)) Is Not Null) AND ((Produtos.UnidadeMedida) Is Not Null) AND ((Produtos.ValorVenda)>0) AND ((Mid([cf],1,8)) Is Not Null) AND ((Mid([Cst],1,2)) Is Not Null) AND ((Mid([OrigemIcms],1,1)) Is Not Null) AND ((Mid([ModBcIcms],1,1)) Is Not Null));"
                'sSql = "SELECT Mid([CodigoNfe],1,20) AS xCodigoProduto, Mid([Descrição],1,80) AS xDescrição, Produtos.UnidadeMedida, Mid([UnidadeMedida],1,6) AS uTrib, Produtos.ValorVenda, Mid([ValorVenda],1,8) AS vUnTrib, Mid([cf],1,8) AS xCF, Mid([Cst],1,3) AS xCst, Mid([Ean],1,13) AS xEan, Mid([cEanTrib],1,13) AS xcEanTrib, Mid([cstIPI],1,2) AS xcstIPI, Mid([cstCofins],1,2) AS xcstCofins, Mid([CstPIS],1,2) AS xCstPIS, Mid([Icms],1,8) AS xIcms, Mid([OrigemIcms],1,1) AS xOrigemIcms, Mid([ModBcIcms],1,1) AS xModBcIcms, Mid([TcalcIPI],1,1) AS xTcalcIPI, Mid([Ipi],1,8) AS xIpi, Mid([pPIS],1,8) AS xpPIS, Mid([pCofins],1,8) AS xpCofins, Mid([cEnq],1,3) AS xcEnq, 1 AS qTrib, Mid([Unidademedida],1,6) AS uCom FROM(Produtos) WHERE (((Mid([Descrição],1,8)) Is Not Null) AND ((Produtos.UnidadeMedida) Is Not Null) AND ((Produtos.ValorVenda)>0) AND ((Mid([cf],1,8)) Is Not Null) AND ((Mid([Cst],1,2)) Is Not Null) AND ((Mid([OrigemIcms],1,1)) Is Not Null) AND ((Mid([ModBcIcms],1,1)) Is Not Null)) and Produtos.inativo = false;"

            Case 3 'Clientes Individual
                sSql = "SELECT Mid([TipoPessoa],1,1) AS xTipoPessoa, Mid([CpfCgc],1,18) AS xCpfCgc, Mid([Insc],1,14) AS xInsc, Mid([Nome],1,80) AS xNome, Mid([NomeFantasia],1,80) AS xNomeFantasia, Mid([Endereço],1,60) AS xEndereço, Mid([Nro],1,6) AS xNro, Mid([xCpl],1,50) AS xxCpl, Mid([cMun],1,7) AS xcMun, Mid([Bairro],1,50) AS xBairro, Mid([cep],1,9) AS xCep, Mid([cUF],1,2) AS xcUF, Mid([Pais],1,15) AS xPais, Mid([Telefone],1,13) AS xTelefone, Clientes.Cidade as xCidade, Clientes.Estado as xEstado, Clientes.Inativo as xInativo, Clientes.Email as xEmail FROM(Clientes) WHERE (((Mid([CpfCgc],1,18)) Is Not Null) AND ((Mid([Insc],1,1)) Is Not Null) AND ((Mid([Nome],1,80)) Is Not Null) AND ((Mid([Endereço],1,60)) Is Not Null) AND ((Mid([Nro],1,6)) Is Not Null) AND ((Mid([cMun],1,7)) Is Not Null) AND ((Mid([cUF],1,2)) Is Not Null) AND ((Mid([Pais],1,15)) Is Not Null) AND ((Clientes.Codigo)=" & (Me.txtCodigo.Text) & "))"
                sSql1 = "SELECT Mid([id],1,4) AS xId, Mid([CpfCgc],1,18) AS xCpfCgc, Mid([cliente],1,18) AS xCliente, Mid([NomePropriedade],1,50) AS xNomePropriedade, Mid([Endereco],1,50) AS xEndereco, Mid([Propriedades].[cMun],1,7) AS xcMun, Mid([Propriedades].[cUf],1,2) AS xcUf, Mid([Propriedades].[Nro],1,6) AS xNro, Mid([Inscricao],1,20) AS xInscricao, Propriedades.Estado AS xEstado, Propriedades.Cidade AS xCidade FROM Clientes INNER JOIN Propriedades ON Clientes.Codigo = Propriedades.Cliente WHERE (((Mid([CpfCgc],1,18)) Is Not Null) and ((Propriedades.Cliente)=" & Me.txtCodigo.Text & ") AND ((Mid([cliente],1,18)) Is Not Null) AND ((Mid([NomePropriedade],1,50)) Is Not Null) AND ((Mid([Endereco],1,50)) Is Not Null) AND ((Mid([Propriedades].[cMun],1,7)) Is Not Null) AND ((Mid([Propriedades].[cUf],1,2)) Is Not Null) AND ((Mid([Propriedades].[Nro],1,6)) Is Not Null) AND ((Mid([Inscricao],1,20)) Is Not Null)) and propriedades.Inativo = false"

            
            Case 4 'Produtos individual
                sSql = "SELECT CodigoProduto As CodigoERP, Mid([CodigoNFE],1,20) AS xCodigoProduto, Mid([Descrição],1,80) AS xDescrição, [Produtos].[UnidadeMedida], Mid([UnidadeMedida],1,6) AS uTrib, [Produtos].[ValorVenda], Mid([ValorVenda],1,8) AS vUnTrib, Mid([cf],1,8) AS xCF, Mid([Cst],1,3) AS xCst, Mid([Ean],1,13) AS xEan, Mid([cEanTrib],1,13) AS xcEanTrib, Mid([cstIPI],1,2) AS xcstIPI, Mid([cstCofins],1,2) AS xcstCofins, Mid([CstPIS],1,2) AS xCstPIS, Mid([Icms],1,8) AS xIcms, Mid([OrigemIcms],1,1) AS xOrigemIcms, Mid([ModBcIcms],1,1) AS xModBcIcms, Mid([TcalcIPI],1,1) AS xTcalcIPI, Mid([Ipi],1,8) AS xIpi, Mid([pPIS],1,8) AS xpPIS, Mid([pCofins],1,8) AS xpCofins, Mid([cEnq],1,3) AS xcEnq, 1 AS qTrib, Mid([Unidademedida],1,6) AS uCom, Inativo FROM Produtos WHERE (((Mid([Descrição],1,8)) Is Not Null) And (([Produtos].[UnidadeMedida]) Is Not Null) And (([Produtos].[ValorVenda])>0) And ((Mid([cf],1,8)) Is Not Null) And ((Mid([Cst],1,2)) Is Not Null) And ((Mid([OrigemIcms],1,1)) Is Not Null) And ((Mid([ModBcIcms],1,1)) Is Not Null) And (([Produtos].[CodigoProduto])=" & Me.txtCodigo.Text & "))"
        End Select

        'Após estabelecer uma conexão, execute comandos e retorna o resultados de uma fonte de dados como uma SQL.
        Dim Cmd As New OleDb.OleDbCommand(sSql, cnn)

        'Usa o DataAdapter para para se conectar ao objeto command
        Dim Adt As New OleDb.OleDbDataAdapter(Cmd)

        Dim ADTpropriedade As New OleDb.OleDbDataAdapter(sSql1, cnn)

        'Cria uma nova data set.
        Dim Dst As New DataSet()



        'Vareoavel para guardar um valor boolean.
        Dim MyPath As Boolean

        'Vareavel para guardar o local do xml
        Dim myLocal As String = "C:\UP\Xml"
        'Verificação se o diretorio existe e retorna um valor false ou true.
        MyPath = Directory.Exists(myLocal)
        'Se a vareavel path retornar false será criado o local padrão para o xml
        If MyPath = False Then
            MkDir(myLocal)
            MyPath = Directory.Exists(myLocal)
        End If




        'Realiza um select para verificar em qual opção foi selecionada..
        Select Case vOpt
            Case 1, 3 'Gerar xml para clientes selecionado
                If MsgBox("Deseja Gerar XML dos Clientes", 36, "ATENÇÃO") = MsgBoxResult.Yes Then


                    Adt.Fill(Dst, "ClientesXml") 'preenche dataset com a tabela 
                    ADTpropriedade.Fill(Dst, "Propriedade")

                    Dst.WriteXml(myLocal & "\Clientes.xml") 'Cria um arquivo xml na pasta selecionada.

                    MsgBox("Exportação realizada com sucesso", MsgBoxStyle.Information, "ATENÇÃO")
                End If
            Case 2, 4 'Gerar xml para produtos selecionado.
                If MsgBox("Deseja Gerar XML dos Produtos", 36, "ATENÇÃO") = MsgBoxResult.Yes Then

                    Adt.Fill(Dst, "ProdutosXml") 'preenche dataset com a tabela 

                    Dst.WriteXml(myLocal & "\Produtos.xml") 'Cria um arquivo xml na pasta selecionada.
                    MsgBox("Exportação realizada com sucesso", MsgBoxStyle.Information, "ATENÇÃO")
                    Exit Sub
                End If
            Case String.Empty
                MsgBox("Não foi possível gerar o XML, Selecione umas das opções para prosseguir...", 48, "ATENÇÃO")
        End Select

        cnn.Close()
    End Sub

    Private Sub BtFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFechar.Click
        Me.Close()
        Me.Dispose()

    End Sub

  
End Class