Public Class HelpBotForm
    Public WithEvents XHBS As XML = HB_S
    Public WithEvents XHBD As XML = HB_D

    Private Sub HelpBotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.alsé
        Select Case Language.SelectedLanguage
            Case "ENGLISH"
                Me.Text = Language.English.MS_MainMenu_BTN_HelpBot

                TP_Source.Text = Language.English.TP_Source
                BTN_Source_New.Text = Language.English.BTN_Source_New

                GB_Source_From.Text = Language.English.GB_Source_From
                GB_Source_To.Text = Language.English.GB_Source_To

                BTN_Source_Delete.Text = Language.English.BTN_Source_Delete
                BTN_Source_Modify.Text = Language.English.BTN_Source_Modify
                BTN_Source_Add.Text = Language.English.BTN_Source_Add

                BTN_Source_NewFile.Text = Language.English.BTN_Source_New
                BTN_Source_Open.Text = Language.English.BTN_Source_Open
                BTN_Source_Save.Text = Language.English.BTN_Source_Save


                TP_Dest.Text = Language.English.TP_Dest
                BTN_Dest_New.Text = Language.English.BTN_Dest_New

                GB_Dest_From.Text = Language.English.GB_Dest_From
                GB_Dest_To.Text = Language.English.GB_Dest_To

                BTN_Dest_Delete.Text = Language.English.BTN_Dest_Delete
                BTN_Dest_Modify.Text = Language.English.BTN_Dest_Modify
                BTN_Dest_Add.Text = Language.English.BTN_Dest_Add

                BTN_Dest_NewFile.Text = Language.English.BTN_Dest_New
                BTN_Dest_Open.Text = Language.English.BTN_Dest_Open
                BTN_Dest_Save.Text = Language.English.BTN_Dest_Save
            Case "FRANÇAIS"
                Me.Text = Language.French.MS_MainMenu_BTN_HelpBot

                TP_Source.Text = Language.French.TP_Source
                BTN_Source_New.Text = Language.French.BTN_Source_New

                GB_Source_From.Text = Language.French.GB_Source_From
                GB_Source_To.Text = Language.French.GB_Source_To

                BTN_Source_Delete.Text = Language.French.BTN_Source_Delete
                BTN_Source_Modify.Text = Language.French.BTN_Source_Modify
                BTN_Source_Add.Text = Language.French.BTN_Source_Add

                BTN_Source_NewFile.Text = Language.French.BTN_Source_New
                BTN_Source_Open.Text = Language.French.BTN_Source_Open
                BTN_Source_Save.Text = Language.French.BTN_Source_Save


                TP_Dest.Text = Language.French.TP_Dest
                BTN_Dest_New.Text = Language.French.BTN_Dest_New

                GB_Dest_From.Text = Language.French.GB_Dest_From
                GB_Dest_To.Text = Language.French.GB_Dest_To

                BTN_Dest_Delete.Text = Language.French.BTN_Dest_Delete
                BTN_Dest_Modify.Text = Language.French.BTN_Dest_Modify
                BTN_Dest_Add.Text = Language.French.BTN_Dest_Add

                BTN_Dest_NewFile.Text = Language.French.BTN_Source_New
                BTN_Dest_Open.Text = Language.French.BTN_Dest_Open
                BTN_Dest_Save.Text = Language.French.BTN_Dest_Save
            Case "РУССКИЙ"
                Me.Text = Language.Russian.MS_MainMenu_BTN_HelpBot

                TP_Source.Text = Language.Russian.TP_Source
                BTN_Source_New.Text = Language.Russian.BTN_Source_New

                GB_Source_From.Text = Language.Russian.GB_Source_From
                GB_Source_To.Text = Language.Russian.GB_Source_To

                BTN_Source_Delete.Text = Language.Russian.BTN_Source_Delete
                BTN_Source_Modify.Text = Language.Russian.BTN_Source_Modify
                BTN_Source_Add.Text = Language.Russian.BTN_Source_Add

                BTN_Source_NewFile.Text = Language.Russian.BTN_Source_New
                BTN_Source_Open.Text = Language.Russian.BTN_Source_Open
                BTN_Source_Save.Text = Language.Russian.BTN_Source_Save


                TP_Dest.Text = Language.Russian.TP_Dest
                BTN_Dest_New.Text = Language.Russian.BTN_Dest_New

                GB_Dest_From.Text = Language.Russian.GB_Dest_From
                GB_Dest_To.Text = Language.Russian.GB_Dest_To

                BTN_Dest_Delete.Text = Language.Russian.BTN_Dest_Delete
                BTN_Dest_Modify.Text = Language.Russian.BTN_Dest_Modify
                BTN_Dest_Add.Text = Language.Russian.BTN_Dest_Add

                BTN_Dest_NewFile.Text = Language.Russian.BTN_Source_New
                BTN_Dest_Open.Text = Language.Russian.BTN_Dest_Open
                BTN_Dest_Save.Text = Language.Russian.BTN_Dest_Save
        End Select

        LoadSource()
        LoadDest()
    End Sub


#Region "   ~   SOURCE   ~   "
    Private Sub LoadSource()
        LB_Source.Items.Clear()
        TB_Source_From.Clear()
        TB_Source_To.Clear()
        If XHBS.FileDatas IsNot Nothing Then
            For Each xd As XML.Data In XHBS.FileDatas
                LB_Source.Items.Add(xd.Id & " --> " & xd.Content)
            Next
            If XHBS.FileDatas.Length > 0 Then
                LB_Source.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub BTN_Source_New_Click(sender As Object, e As EventArgs) Handles BTN_Source_New.Click
        TB_Source_From.Clear()
        TB_Source_To.Clear()
    End Sub
    Private Sub BTN_Source_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Source_Delete.Click
        XHBS.DeleteData(LB_Source.SelectedIndex)
        LoadSource()
    End Sub
    Private Sub BTN_Source_Modify_Click(sender As Object, e As EventArgs) Handles BTN_Source_Modify.Click
        Dim i As Integer = LB_Source.SelectedIndex
        XHBS.ModifyData(i, TB_Source_From.Text, TB_Source_To.Text)
        LoadSource()
        LB_Source.SelectedIndex = i
    End Sub
    Private Sub BTN_Source_Add_Click(sender As Object, e As EventArgs) Handles BTN_Source_Add.Click
        ' If TB_Source_From.Text = TB_Source_To.Text Then Exit Sub
        ' XHBS.NewData(New XML.Data(TB_Source_From.Text, TB_Source_To.Text))
        '  LoadSource()
        ' LB_Source.SelectedIndex = LB_Source.Items.Count - 1

        If TB_Source_From.Text = TB_Source_To.Text Then Exit Sub
        Dim d As XML.Data = New XML.Data(TB_Source_From.Text, TB_Source_To.Text)
        Dim i As Integer = LB_Source.SelectedIndex
        If i < LB_Source.Items.Count - 1 Then
            XHBS.InsertData(i, d)
            LoadSource()
            LB_Source.SelectedIndex = i
        Else
            XHBS.NewData(d)
            LoadSource()
            LB_Source.SelectedIndex = LB_Source.Items.Count - 1
        End If
    End Sub
    Private Sub LB_Source_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Source.SelectedIndexChanged
        If XHBS.FileDatas IsNot Nothing Then
            If XHBS.FileDatas(LB_Source.SelectedIndex) IsNot Nothing Then
                TB_Source_From.Text = XHBS.FileDatas(LB_Source.SelectedIndex).Id
                TB_Source_To.Text = XHBS.FileDatas(LB_Source.SelectedIndex).Content
            Else
                TB_Source_From.Clear()
                TB_Source_To.Clear()
            End If
        End If
    End Sub
    Private Sub BTN_Source_NewFile_Click(sender As Object, e As EventArgs) Handles BTN_Source_NewFile.Click
        HB_S = New XML
        With HB_S
            .SelectedEncoding = "utf-32"
        End With
        XHBS = HB_S
        LoadSource()
    End Sub
    Private Sub BTN_Source_Open_Click(sender As Object, e As EventArgs) Handles BTN_Source_Open.Click
        If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\Help-Bot\Source\") Then
            MkDir(My.Application.Info.DirectoryPath & "\Help-Bot\Source\")
        End If
        XHBS.OpenFile(My.Application.Info.DirectoryPath & "\Help-Bot\Source\")
    End Sub
    Private Sub BTN_Source_Save_Click(sender As Object, e As EventArgs) Handles BTN_Source_Save.Click
        If IO.File.Exists(XHBS.FilePath) Then
            XHBS.SaveFile()
        Else
            XHBS.SaveAsFile(My.Application.Info.DirectoryPath & "\Help-Bot\Source")
        End If
    End Sub
    Private Sub XHBS_FileOpened() Handles XHBS.FileOpened
        LoadSource()
    End Sub
#End Region


#Region "   ~   DESTINATION   ~   "
    Private Sub LoadDest()
        LB_Dest.Items.Clear()
        TB_Dest_From.Clear()
        TB_Dest_To.Clear()
        If XHBD.FileDatas IsNot Nothing Then
            For Each xd As XML.Data In XHBD.FileDatas
                LB_Dest.Items.Add(xd.Id & " --> " & xd.Content)
            Next
            If XHBD.FileDatas.Length > 0 Then
                LB_Dest.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub BTN_Dest_New_Click(sender As Object, e As EventArgs) Handles BTN_Dest_New.Click
        TB_Dest_From.Clear()
        TB_Dest_To.Clear()
    End Sub
    Private Sub BTN_Dest_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Delete.Click
        XHBD.DeleteData(LB_Dest.SelectedIndex)
        LoadDest()
    End Sub
    Private Sub BTN_Dest_Modify_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Modify.Click
        Dim i As Integer = LB_Dest.SelectedIndex
        XHBD.ModifyData(i, TB_Dest_From.Text, TB_Dest_To.Text)
        LoadDest()
        LB_Dest.SelectedIndex = i
    End Sub
    Private Sub BTN_Dest_Add_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Add.Click
        'If TB_Dest_From.Text = TB_Dest_To.Text Then Exit Sub
        'XHBD.NewData(New XML.Data(TB_Dest_From.Text, TB_Dest_To.Text))
        'LoadDest()
        'LB_Dest.SelectedIndex = LB_Dest.Items.Count - 1

        If TB_Dest_From.Text = TB_Dest_To.Text Then Exit Sub
        Dim d As XML.Data = New XML.Data(TB_Dest_From.Text, TB_Dest_To.Text)
        Dim i As Integer = LB_Dest.SelectedIndex
        If i < LB_Dest.Items.Count - 1 Then
            XHBD.InsertData(i, d)
            LoadDest()
            LB_Dest.SelectedIndex = i
        Else
            XHBD.NewData(d)
            LoadDest()
            LB_Dest.SelectedIndex = LB_Dest.Items.Count - 1
        End If
    End Sub
    Private Sub LB_Dest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Dest.SelectedIndexChanged
        If XHBD.FileDatas IsNot Nothing Then
            If XHBD.FileDatas(LB_Dest.SelectedIndex) IsNot Nothing Then
                TB_Dest_From.Text = XHBD.FileDatas(LB_Dest.SelectedIndex).Id
                TB_Dest_To.Text = XHBD.FileDatas(LB_Dest.SelectedIndex).Content
            Else
                TB_Dest_From.Clear()
                TB_Dest_To.Clear()
            End If
        End If
    End Sub
    Private Sub BTN_Dest_NewFile_Click(sender As Object, e As EventArgs) Handles BTN_Dest_NewFile.Click
        HB_D = New XML
        With HB_D
            .SelectedEncoding = "utf-32"
        End With
        XHBD = HB_D
        LoadDest()
    End Sub
    Private Sub BTN_Dest_Open_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Open.Click
        If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\Help-Bot\Destination\") Then
            MkDir(My.Application.Info.DirectoryPath & "\Help-Bot\Destination\")
        End If
        XHBD.OpenFile(My.Application.Info.DirectoryPath & "\Help-Bot\Destination\")
    End Sub
    Private Sub BTN_Dest_Save_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Save.Click
        If IO.File.Exists(XHBD.FilePath) Then
            XHBD.SaveFile()
        Else
            XHBD.SaveAsFile(My.Application.Info.DirectoryPath & "\Help-Bot\Destination")
        End If
    End Sub
    Private Sub XHBD_FileOpened() Handles XHBD.FileOpened
        LoadDest()
    End Sub
#End Region
End Class