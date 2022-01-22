Public Class MainForm
    Private ReadOnly ConfigPath As String = My.Application.Info.DirectoryPath & "\alseconfig.xml"
    Private WithEvents ALSECONFIG As XML
    Public WithEvents XML_S As XML
    Public WithEvents XML_D As XML

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.alsé
        CB_MainMenu_Language.SelectedIndex = 0

        XML_S = New XML
        With XML_S
            CB_Source_Encoding.DataSource = .AvaibleEncoding
            .TrimContent = True
        End With

        XML_D = New XML
        With XML_D
            CB_Dest_Encoding.DataSource = .AvaibleEncoding
            .TrimContent = True
        End With

        HB_S = New XML
        With HB_S
            .SelectedEncoding = "utf-32"
        End With

        HB_D = New XML
        With HB_D
            .SelectedEncoding = "utf-32"
        End With

        ALSECONFIG = New XML
        With ALSECONFIG
            .SelectedEncoding = "utf-32"
            .OpenFile(ConfigPath)
        End With
    End Sub
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CreateConfig()
    End Sub

    Private Sub CB_MainMenu_Language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_MainMenu_Language.SelectedIndexChanged
        Language.SelectedLanguage = CB_MainMenu_Language.SelectedItem

        Select Case Language.SelectedLanguage
            Case "ENGLISH"
                MS_MainMenu_BTN_HelpBot.Text = Language.English.MS_MainMenu_BTN_HelpBot


                GB_Source.Text = Language.English.GB_Source

                MS_Source_BTN_File.Text = Language.English.MS_Source_BTN_File
                MS_Source_BTN_File_New.Text = Language.English.MS_source_BTN_File_New
                MS_Source_BTN_File_Open.Text = Language.English.MS_Source_BTN_File_Open

                LBL_Source_Encoding.Text = Language.English.LBL_Source_Encoding

                GB_Source_Data.Text = Language.English.GB_Source_Data
                GB_Source_Data_Id.Text = Language.English.GB_Source_Data_Id
                GB_Source_Data_Content.Text = Language.English.GB_Source_Data_Content

                BTN_Source_Data_Previous.Text = Language.English.BTN_Source_Data_Previous
                BTN_Source_Data_Next.Text = Language.English.BTN_Source_Data_Next

                BTN_Source_Data_UseHelpBot.Text = Language.English.BTN_Source_Data_UseHelpBot
                BTN_Source_Data_Add.Text = Language.English.BTN_Source_Data_Add

                GB_Source_List.Text = Language.English.GB_Source_List
                LBL_Source_List_Total.Text = Language.English.LBL_Source_List_Total
                LBL_Source_List_Selected.Text = Language.English.LBL_Source_List_Selected


                GB_Dest.Text = Language.English.GB_Dest

                MS_Dest_BTN_File.Text = Language.English.MS_Dest_BTN_File
                MS_Dest_BTN_File_New.Text = Language.English.MS_Dest_BTN_File_New
                MS_Dest_BTN_File_Open.Text = Language.English.MS_Dest_BTN_File_Open
                MS_Dest_BTN_File_Save.Text = Language.English.MS_Dest_BTN_File_Save
                MS_Dest_BTN_File_SaveAs.Text = Language.English.MS_Dest_BTN_File_SaveAs

                MS_Dest_BTN_Find.Text = Language.English.FindForm

                LBL_Dest_Encoding.Text = Language.English.LBL_Dest_Encoding

                GB_Dest_Data.Text = Language.English.GB_Dest_Data
                GB_Dest_Data_Id.Text = Language.English.GB_Dest_Data_Id
                GB_Dest_Data_Content.Text = Language.English.GB_Dest_Data_Content

                BTN_Dest_Data_UseSource.Text = Language.English.BTN_Dest_Data_UseSource

                BTN_Dest_Data_Delete.Text = Language.English.BTN_Dest_Data_Delete
                BTN_Dest_Data_Modify.Text = Language.English.BTN_Dest_Data_Modify
                BTN_Dest_Data_Add.Text = Language.English.BTN_Dest_Data_Add

                BTN_Dest_Data_UseHelpBot.Text = Language.English.BTN_Dest_Data_UseHelpBot


                GB_Dest_List.Text = Language.English.GB_Dest_List
                LBL_Dest_List_Total.Text = Language.English.LBL_Dest_List_Total
                LBL_Dest_List_Selected.Text = Language.English.LBL_Dest_List_Selected
            Case "FRANÇAIS"
                MS_MainMenu_BTN_HelpBot.Text = Language.French.MS_MainMenu_BTN_HelpBot


                GB_Source.Text = Language.French.GB_Source

                MS_Source_BTN_File.Text = Language.French.MS_Source_BTN_File
                MS_Source_BTN_File_New.Text = Language.French.MS_source_BTN_File_New
                MS_Source_BTN_File_Open.Text = Language.French.MS_Source_BTN_File_Open

                LBL_Source_Encoding.Text = Language.French.LBL_Source_Encoding

                GB_Source_Data.Text = Language.French.GB_Source_Data
                GB_Source_Data_Id.Text = Language.French.GB_Source_Data_Id
                GB_Source_Data_Content.Text = Language.French.GB_Source_Data_Content

                BTN_Source_Data_Previous.Text = Language.French.BTN_Source_Data_Previous
                BTN_Source_Data_Next.Text = Language.French.BTN_Source_Data_Next

                BTN_Source_Data_UseHelpBot.Text = Language.French.BTN_Source_Data_UseHelpBot
                BTN_Source_Data_Add.Text = Language.French.BTN_Source_Data_Add

                GB_Source_List.Text = Language.French.GB_Source_List
                LBL_Source_List_Total.Text = Language.French.LBL_Source_List_Total
                LBL_Source_List_Selected.Text = Language.French.LBL_Source_List_Selected


                GB_Dest.Text = Language.French.GB_Dest

                MS_Dest_BTN_File.Text = Language.French.MS_Dest_BTN_File
                MS_Dest_BTN_File_New.Text = Language.French.MS_Dest_BTN_File_New
                MS_Dest_BTN_File_Open.Text = Language.French.MS_Dest_BTN_File_Open
                MS_Dest_BTN_File_Save.Text = Language.French.MS_Dest_BTN_File_Save
                MS_Dest_BTN_File_SaveAs.Text = Language.French.MS_Dest_BTN_File_SaveAs

                MS_Dest_BTN_Find.Text = Language.French.FindForm

                LBL_Dest_Encoding.Text = Language.French.LBL_Dest_Encoding

                GB_Dest_Data.Text = Language.French.GB_Dest_Data
                GB_Dest_Data_Id.Text = Language.French.GB_Dest_Data_Id
                GB_Dest_Data_Content.Text = Language.French.GB_Dest_Data_Content

                BTN_Dest_Data_UseSource.Text = Language.French.BTN_Dest_Data_UseSource

                BTN_Dest_Data_Delete.Text = Language.French.BTN_Dest_Data_Delete
                BTN_Dest_Data_Modify.Text = Language.French.BTN_Dest_Data_Modify
                BTN_Dest_Data_Add.Text = Language.French.BTN_Dest_Data_Add

                BTN_Dest_Data_UseHelpBot.Text = Language.French.BTN_Dest_Data_UseHelpBot


                GB_Dest_List.Text = Language.French.GB_Dest_List
                LBL_Dest_List_Total.Text = Language.French.LBL_Dest_List_Total
                LBL_Dest_List_Selected.Text = Language.French.LBL_Dest_List_Selected
            Case "РУССКИЙ"
                MS_MainMenu_BTN_HelpBot.Text = Language.Russian.MS_MainMenu_BTN_HelpBot


                GB_Source.Text = Language.Russian.GB_Source

                MS_Source_BTN_File.Text = Language.Russian.MS_Source_BTN_File
                MS_Source_BTN_File_New.Text = Language.Russian.MS_source_BTN_File_New
                MS_Source_BTN_File_Open.Text = Language.Russian.MS_Source_BTN_File_Open

                LBL_Source_Encoding.Text = Language.Russian.LBL_Source_Encoding

                GB_Source_Data.Text = Language.Russian.GB_Source_Data
                GB_Source_Data_Id.Text = Language.Russian.GB_Source_Data_Id
                GB_Source_Data_Content.Text = Language.Russian.GB_Source_Data_Content

                BTN_Source_Data_Previous.Text = Language.Russian.BTN_Source_Data_Previous
                BTN_Source_Data_Next.Text = Language.Russian.BTN_Source_Data_Next

                BTN_Source_Data_UseHelpBot.Text = Language.Russian.BTN_Source_Data_UseHelpBot
                BTN_Source_Data_Add.Text = Language.Russian.BTN_Source_Data_Add

                GB_Source_List.Text = Language.Russian.GB_Source_List
                LBL_Source_List_Total.Text = Language.Russian.LBL_Source_List_Total
                LBL_Source_List_Selected.Text = Language.Russian.LBL_Source_List_Selected


                GB_Dest.Text = Language.Russian.GB_Dest

                MS_Dest_BTN_File.Text = Language.Russian.MS_Dest_BTN_File
                MS_Dest_BTN_File_New.Text = Language.Russian.MS_Dest_BTN_File_New
                MS_Dest_BTN_File_Open.Text = Language.Russian.MS_Dest_BTN_File_Open
                MS_Dest_BTN_File_Save.Text = Language.Russian.MS_Dest_BTN_File_Save
                MS_Dest_BTN_File_SaveAs.Text = Language.Russian.MS_Dest_BTN_File_SaveAs

                MS_Dest_BTN_Find.Text = Language.Russian.FindForm

                LBL_Dest_Encoding.Text = Language.Russian.LBL_Dest_Encoding

                GB_Dest_Data.Text = Language.Russian.GB_Dest_Data
                GB_Dest_Data_Id.Text = Language.Russian.GB_Dest_Data_Id
                GB_Dest_Data_Content.Text = Language.Russian.GB_Dest_Data_Content

                BTN_Dest_Data_UseSource.Text = Language.Russian.BTN_Dest_Data_UseSource

                BTN_Dest_Data_Delete.Text = Language.Russian.BTN_Dest_Data_Delete
                BTN_Dest_Data_Modify.Text = Language.Russian.BTN_Dest_Data_Modify
                BTN_Dest_Data_Add.Text = Language.Russian.BTN_Dest_Data_Add

                BTN_Dest_Data_UseHelpBot.Text = Language.Russian.BTN_Dest_Data_UseHelpBot


                GB_Dest_List.Text = Language.Russian.GB_Dest_List
                LBL_Dest_List_Total.Text = Language.Russian.LBL_Dest_List_Total
                LBL_Dest_List_Selected.Text = Language.Russian.LBL_Dest_List_Selected
        End Select
        Try
            LBL_Source_List_Total.Text = LBL_Source_List_Total.Text.Split(":")(0) & ": " & LB_Source_List.Items.Count
            LBL_Source_List_Selected.Text = LBL_Source_List_Selected.Text.Split(":")(0) & ": " & LB_Source_List.SelectedIndex + 1
            LBL_Dest_List_Total.Text = LBL_Dest_List_Total.Text.Split(":")(0) & ": " & LB_Dest_List.Items.Count
            LBL_Dest_List_Selected.Text = LBL_Dest_List_Selected.Text.Split(":")(0) & ": " & LB_Dest_List.SelectedIndex + 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MS_MainMenu_BTN_HelpBot_Click(sender As Object, e As EventArgs) Handles MS_MainMenu_BTN_HelpBot.Click
        HelpBotForm.ShowDialog(Me)
    End Sub


#Region "   ~   CONFIG   ~   "
    Private Sub CreateConfig()
        ALSECONFIG = New XML
        ALSECONFIG.SelectedEncoding = "utf-32"

        ALSECONFIG.NewData(New XML.Data("Language sélectionné", CB_MainMenu_Language.SelectedItem))
        If MS_Dest_TB_Author.Text Is Nothing Then
            ALSECONFIG.NewData(New XML.Data("Auteur", "Oyissan"))
        Else
            ALSECONFIG.NewData(New XML.Data("Auteur", MS_Dest_TB_Author.Text))
        End If
        ALSECONFIG.NewData(New XML.Data("Source : Encodage", XML_S.SelectedEncoding))
        ALSECONFIG.NewData(New XML.Data("Destination : Encodage", XML_D.SelectedEncoding))
        ALSECONFIG.NewData(New XML.Data("Source : Fichier", XML_S.FilePath))
        ALSECONFIG.NewData(New XML.Data("Destination : Fichier", XML_D.FilePath))
        ALSECONFIG.NewData(New XML.Data("Aide-Bot : Source : Fichier", HB_S.FilePath))
        ALSECONFIG.NewData(New XML.Data("Aide-Bot : Destination : Fichier", HB_D.FilePath))
        ALSECONFIG.SaveAsFile(ConfigPath)
    End Sub
    Private Sub LoadConfig()
        If ALSECONFIG.FileDatas IsNot Nothing Then
            For Each d As XML.Data In ALSECONFIG.FileDatas
                If d.Id = "Language sélectionné" Then
                    CB_MainMenu_Language.SelectedItem = d.Content
                    Language.SelectedLanguage = d.Content
                End If

                If d.Id = "Auteur" Then
                    MS_Dest_TB_Author.Text = d.Content
                End If

                If d.Id = "Source : Encodage" Then
                    If CB_Source_Encoding.Items.Contains(d.Content) Then
                        CB_Source_Encoding.SelectedItem = d.Content
                    End If
                End If

                If d.Id = "Destination : Encodage" Then
                    If CB_Dest_Encoding.Items.Contains(d.Content) Then
                        CB_Dest_Encoding.SelectedItem = d.Content
                    End If
                End If

                If d.Id = "Source : Fichier" Then
                    XML_S.OpenFile(d.Content)
                End If

                If d.Id = "Destination : Fichier" Then
                    XML_D.OpenFile(d.Content)
                End If

                If d.Id = "Aide-Bot : Source : Fichier" Then
                    HB_S.OpenFile(d.Content)
                End If

                If d.Id = "Aide-Bot : Destination : Fichier" Then
                    HB_D.OpenFile(d.Content)
                End If
            Next
        End If
    End Sub
    Private Sub ALSECONFIG_FileOpened() Handles ALSECONFIG.FileOpened
        LoadConfig()
    End Sub
#End Region


#Region "   ~   SOURCE   ~   "
    Private Sub LoadSource()
        TB_Source_Data_Id.Clear()
        RTB_Source_Data_Content.Clear()
        LB_Source_List.Items.Clear()
        GB_Source.Text = "Source : " & XML_S.FileName
        SS_Source_LBL_Path.Text = XML_S.FilePath

        If XML_S.FileDatas IsNot Nothing Then
            For Each x As XML.Data In XML_S.FileDatas
                LB_Source_List.Items.Add(x.Id)
            Next
            If XML_S.FileDatas.Length > 0 Then
                LB_Source_List.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub MS_Source_BTN_File_New_Click(sender As Object, e As EventArgs) Handles MS_Source_BTN_File_New.Click
        XML_S = New XML
        With XML_S
            .SelectedEncoding = CB_Source_Encoding.Text
            .TrimContent = True
        End With
        LoadSource()
        LBL_Source_List_Total.Text = "Total : " & 0
        LBL_Source_List_Selected.Text = "Sélectionné : " & 0
    End Sub
    Private Sub MS_Source_BTN_File_Open_Click(sender As Object, e As EventArgs) Handles MS_Source_BTN_File_Open.Click
        If XML_S IsNot Nothing Then
            Dim ps As String = XML_S.FilePath
            If ps IsNot Nothing Then
                Dim nps As String = ps.Replace(XML_S.FileName, "")
                XML_S.OpenFile(nps)
            Else
                XML_S.OpenFile()
            End If
        Else
            XML_S.OpenFile()
        End If
    End Sub
    Private Sub CB_Source_Encoding_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Source_Encoding.SelectedIndexChanged
        XML_S.SelectedEncoding = CB_Source_Encoding.Text
        LoadSource()
    End Sub
    Private Sub LB_Source_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Source_List.SelectedIndexChanged
        If XML_S.FileDatas IsNot Nothing Then

            LBL_Source_List_Total.Text = LBL_Source_List_Total.Text.Split(":")(0) & ": " & LB_Source_List.Items.Count
            LBL_Source_List_Selected.Text = LBL_Source_List_Selected.Text.Split(":")(0) & ": " & LB_Source_List.SelectedIndex + 1

            If XML_S.FileDatas(LB_Source_List.SelectedIndex) IsNot Nothing Then
                TB_Source_Data_Id.Text = XML_S.FileDatas(LB_Source_List.SelectedIndex).Id
                RTB_Source_Data_Content.Text = XML_S.FileDatas(LB_Source_List.SelectedIndex).Content
                If LB_Dest_List.Items.Contains(LB_Source_List.SelectedItem) Then
                    LB_Dest_List.SelectedItem = LB_Source_List.SelectedItem
                End If
            Else
                TB_Source_Data_Id.Clear()
                RTB_Source_Data_Content.Clear()
            End If
        Else
            LBL_Source_List_Total.Text = LBL_Source_List_Total.Text.Split(":")(0) & ": 0"
            LBL_Source_List_Selected.Text = LBL_Source_List_Selected.Text.Split(":")(0) & ": 0"
        End If
    End Sub
    Private Sub XML_S_FileOpened() Handles XML_S.FileOpened
        LoadSource()
    End Sub
    Private Sub BTN_Source_Data_Previous_Click(sender As Object, e As EventArgs) Handles BTN_Source_Data_Previous.Click
        If LB_Source_List.SelectedIndex - 1 < 0 Then Exit Sub
        If XML_S.FileDatas IsNot Nothing Then
            If XML_S.FileDatas(LB_Source_List.SelectedIndex - 1) IsNot Nothing Then
                LB_Source_List.SelectedIndex -= 1
            End If
        End If
    End Sub
    Private Sub BTN_Source_Data_Next_Click(sender As Object, e As EventArgs) Handles BTN_Source_Data_Next.Click
        If LB_Source_List.SelectedIndex = LB_Source_List.Items.Count - 1 Then Exit Sub
        If XML_S.FileDatas IsNot Nothing Then
            If XML_S.FileDatas(LB_Source_List.SelectedIndex + 1) IsNot Nothing Then
                LB_Source_List.SelectedIndex += 1
            End If
        End If
    End Sub
    Private Sub BTN_Source_Data_Add_Click(sender As Object, e As EventArgs) Handles BTN_Source_Data_Add.Click
        If TB_Source_Data_Id.Text = Nothing And RTB_Source_Data_Content.Text = Nothing Then Exit Sub
        Dim d As XML.Data = New XML.Data(TB_Source_Data_Id.Text, RTB_Source_Data_Content.Text)
        Dim i As Integer = LB_Dest_List.SelectedIndex
        If i < LB_Dest_List.Items.Count - 1 Then
            XML_D.InsertData(i, d)
            LoadDestination()
            LB_Dest_List.SelectedIndex = i
        Else
            XML_D.NewData(d)
            LoadDestination()
            LB_Dest_List.SelectedIndex = LB_Dest_List.Items.Count - 1
        End If
    End Sub
    Private Sub BTN_Source_Data_UseHelpBot_Click(sender As Object, e As EventArgs) Handles BTN_Source_Data_UseHelpBot.Click
        If HB_S Is Nothing Then Exit Sub
        If HB_S.FileDatas Is Nothing Then Exit Sub
        For Each xd As XML.Data In HB_S.FileDatas
            RTB_Source_Data_Content.Text = RTB_Source_Data_Content.Text.Replace(xd.Id, xd.Content)
        Next
    End Sub
    Private Sub CMS_LB_Source_List_BTN_Copie_Click(sender As Object, e As EventArgs) Handles CMS_LB_Source_List_BTN_Copie.Click
        If TB_Source_Data_Id.Text = Nothing And RTB_Source_Data_Content.Text = Nothing Then Exit Sub
        Dim d As XML.Data = New XML.Data(TB_Source_Data_Id.Text, RTB_Source_Data_Content.Text)
        Clipboard.SetText(d.Content)
    End Sub
#End Region


#Region "   ~   DESTINATION   ~   "
    Private Sub LoadDestination()
        TB_Dest_Data_Id.Clear()
        RTB_Dest_Data_Content.Clear()
        LB_Dest_List.Items.Clear()
        GB_Dest.Text = "Destination : " & XML_D.FileName
        SS_Dest_LBL_Path.Text = XML_D.FilePath

        If XML_D.FileDatas IsNot Nothing Then
            For Each x As XML.Data In XML_D.FileDatas
                LB_Dest_List.Items.Add(x.Id)
            Next
            If XML_D.FileDatas.Length > 0 Then
                LB_Dest_List.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub MS_Dest_TB_Author_TextChanged(sender As Object, e As EventArgs) Handles MS_Dest_TB_Author.TextChanged
        If XML_D Is Nothing Then Exit Sub
        XML_D.Author = MS_Dest_TB_Author.Text
    End Sub
    Private Sub MS_Dest_BTN_File_New_Click(sender As Object, e As EventArgs) Handles MS_Dest_BTN_File_New.Click
        XML_D = New XML
        With XML_D
            .SelectedEncoding = CB_Dest_Encoding.Text
            .TrimContent = True
        End With
        LoadDestination()
        LBL_Dest_List_Total.Text = "Total : " & 0
        LBL_Dest_List_Selected.Text = "Sélectionné : " & 0
    End Sub
    Private Sub MS_Dest_BTN_File_Open_Click(sender As Object, e As EventArgs) Handles MS_Dest_BTN_File_Open.Click
        If XML_D IsNot Nothing Then
            Dim pd As String = XML_D.FilePath
            If pd IsNot Nothing Then
                Dim npd As String = pd.Replace(XML_D.FileName, "")
                XML_D.OpenFile(npd)
            Else
                XML_D.OpenFile()
            End If
        Else
            XML_D.OpenFile()
        End If
    End Sub
    Private Sub MS_Dest_BTN_File_Save_Click(sender As Object, e As EventArgs) Handles MS_Dest_BTN_File_Save.Click
        XML_D.SaveFile()
    End Sub
    Private Sub MS_Dest_BTN_File_SaveAs_Click(sender As Object, e As EventArgs) Handles MS_Dest_BTN_File_SaveAs.Click
        XML_D.SaveAsFile()
    End Sub
    Private Sub MS_Dest_BTN_Find_Click(sender As Object, e As EventArgs) Handles MS_Dest_BTN_Find.Click
        Dim Ff As Form = New FindForm
        Ff.Show(Me)
    End Sub
    Private Sub CB_Dest_Encoding_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Dest_Encoding.SelectedIndexChanged
        XML_D.SelectedEncoding = CB_Dest_Encoding.Text
        LoadDestination()
    End Sub
    Private Sub BTN_Dest_Data_UseSource_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Data_UseSource.Click
        TB_Dest_Data_Id.Text = TB_Source_Data_Id.Text
        RTB_Dest_Data_Content.Text = RTB_Source_Data_Content.Text
        If TB_Dest_Data_Id.Text = Nothing And RTB_Dest_Data_Content.Text = Nothing Then Exit Sub
        Dim i As Integer = LB_Dest_List.SelectedIndex
        XML_D.ModifyData(i, TB_Dest_Data_Id.Text, RTB_Dest_Data_Content.Text)
        LoadDestination()
        LB_Dest_List.SelectedIndex = i
    End Sub
    Private Sub BTN_Dest_Data_Add_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Data_Add.Click
        If TB_Dest_Data_Id.Text = Nothing And RTB_Dest_Data_Content.Text = Nothing Then Exit Sub
        XML_D.NewData(New XML.Data(TB_Dest_Data_Id.Text, RTB_Dest_Data_Content.Text))
        LoadDestination()
        LB_Dest_List.SelectedIndex = LB_Dest_List.Items.Count - 1
    End Sub
    Private Sub BTN_Dest_Data_Modify_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Data_Modify.Click
        If TB_Dest_Data_Id.Text = Nothing And RTB_Dest_Data_Content.Text = Nothing Then Exit Sub
        Dim i As Integer = LB_Dest_List.SelectedIndex
        XML_D.ModifyData(i, TB_Dest_Data_Id.Text, RTB_Dest_Data_Content.Text)
        LoadDestination()
        LB_Dest_List.SelectedIndex = i
    End Sub
    Private Sub BTN_Dest_Data_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Data_Delete.Click
        If TB_Dest_Data_Id.Text = Nothing And RTB_Dest_Data_Content.Text = Nothing Then Exit Sub
        Dim i As Integer = LB_Dest_List.SelectedIndex
        XML_D.DeleteData(i)
        LoadDestination()
        If Not i > LB_Dest_List.Items.Count - 1 Then
            LB_Dest_List.SelectedIndex = i
        End If
    End Sub
    Private Sub CMS_LB_Dest_List_BTN_Copie_Click(sender As Object, e As EventArgs) Handles CMS_LB_Dest_List_BTN_Copie.Click
        If TB_Dest_Data_Id.Text = Nothing And RTB_Dest_Data_Content.Text = Nothing Then Exit Sub
        Dim d As XML.Data = New XML.Data(TB_Dest_Data_Id.Text, RTB_Dest_Data_Content.Text)
        Clipboard.SetText(d.Content)
    End Sub
    Private Sub CMS_LB_Dest_List_BTN_Delete_Click(sender As Object, e As EventArgs) Handles CMS_LB_Dest_List_BTN_Delete.Click
        If TB_Dest_Data_Id.Text = Nothing And RTB_Dest_Data_Content.Text = Nothing Then Exit Sub
        Dim i As Integer = LB_Dest_List.SelectedIndex
        XML_D.DeleteData(i)
        LoadDestination()
        If Not i > LB_Dest_List.Items.Count - 1 Then
            LB_Dest_List.SelectedIndex = i
        End If
    End Sub
    Private Sub LB_Dest_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Dest_List.SelectedIndexChanged
        If XML_D.FileDatas IsNot Nothing Then
            LBL_Dest_List_Total.Text = LBL_Dest_List_Total.Text.Split(":")(0) & ": " & LB_Dest_List.Items.Count
            LBL_Dest_List_Selected.Text = LBL_Dest_List_Selected.Text.Split(":")(0) & ": " & LB_Dest_List.SelectedIndex + 1

            If XML_D.FileDatas(LB_Dest_List.SelectedIndex) IsNot Nothing Then
                TB_Dest_Data_Id.Text = XML_D.FileDatas(LB_Dest_List.SelectedIndex).Id
                RTB_Dest_Data_Content.Text = XML_D.FileDatas(LB_Dest_List.SelectedIndex).Content
                If LB_Source_List.Items.Contains(LB_Dest_List.SelectedItem) Then
                    LB_Source_List.SelectedItem = LB_Dest_List.SelectedItem
                End If
            Else
                TB_Dest_Data_Id.Clear()
                RTB_Dest_Data_Content.Clear()
            End If
        Else
            LBL_Dest_List_Total.Text = "Total : " & 0
            LBL_Dest_List_Selected.Text = "Sélectionné : " & 0
        End If
    End Sub
    Private Sub XML_D_FileOpened() Handles XML_D.FileOpened
        LoadDestination()
    End Sub
    Private Sub XML_D_FileSaved() Handles XML_D.FileSaved
        GB_Dest.Text = "Destination : " & XML_D.FileName
        SS_Dest_LBL_Path.Text = XML_D.FilePath
    End Sub
    Private Sub BTN_Dest_Data_UseHelpBot_Click(sender As Object, e As EventArgs) Handles BTN_Dest_Data_UseHelpBot.Click
        If HB_D Is Nothing Then Exit Sub
        If HB_D.FileDatas Is Nothing Then Exit Sub

        For Each xd As XML.Data In HB_D.FileDatas
            RTB_Dest_Data_Content.Text = RTB_Dest_Data_Content.Text.Replace(xd.Id, xd.Content)
        Next
    End Sub
#End Region
End Class
