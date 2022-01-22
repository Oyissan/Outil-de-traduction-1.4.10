Public Class FindForm
    Private index() As Integer
    Private SelectedIndex As Integer
    Private Sub FindForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.alsé
        Select Case Language.SelectedLanguage
            Case "ENGLISH"
                FindForm.Text = Language.English.FindForm

                BTN_Ok.Text = Language.English.BTN_Ok

                GB_Result.Text = Language.English.GB_Result
                LBL_ObjsFound.Text = Language.English.LBL_ObjsFound & "0"
                LBL_SelectedObj.Text = Language.English.LBL_SelectedObj & "0"

                BTN_Previous.Text = Language.English.BTN_Previous
                BTN_Next.Text = Language.English.BTN_Next
            Case "FRANÇAIS"
                FindForm.Text = Language.French.FindForm

                BTN_Ok.Text = Language.French.BTN_Ok

                GB_Result.Text = Language.French.GB_Result
                LBL_ObjsFound.Text = Language.French.LBL_ObjsFound & "0"
                LBL_SelectedObj.Text = Language.French.LBL_SelectedObj & "0"

                BTN_Previous.Text = Language.French.BTN_Previous
                BTN_Next.Text = Language.French.BTN_Next
            Case "РУССКИЙ"
                FindForm.Text = Language.Russian.FindForm

                BTN_Ok.Text = Language.Russian.BTN_Ok

                GB_Result.Text = Language.Russian.GB_Result
                LBL_ObjsFound.Text = Language.Russian.LBL_ObjsFound & "0"
                LBL_SelectedObj.Text = Language.Russian.LBL_SelectedObj & "0"

                BTN_Previous.Text = Language.Russian.BTN_Previous
                BTN_Next.Text = Language.Russian.BTN_Next
        End Select
    End Sub

    Private Sub AddToArray(Of ArrayType)(ByRef Array() As ArrayType, ByVal Data As ArrayType)
        If Array Is Nothing Then
            ReDim Array(0)
            Array(0) = Data
        Else
            ReDim Preserve Array(Array.Length)
            Array(Array.Length - 1) = Data
        End If
    End Sub
    Private Sub BTN_Ok_Click(sender As Object, e As EventArgs) Handles BTN_Ok.Click
        If MainForm.XML_D.FileDatas Is Nothing Then Exit Sub

        index = Nothing
        For i As Integer = 0 To MainForm.XML_D.FileDatas.Length - 1
            Dim d As XML.Data = MainForm.XML_D.FileDatas(i)
            If d.Id.Contains(TB_Find.Text) Or d.Content.Contains(TB_Find.Text) Then
                AddToArray(Of Integer)(index, i)
            End If
        Next

        If index IsNot Nothing Then
            SelectedIndex = 0
            LBL_ObjsFound.Text = LBL_ObjsFound.Text.Split(":")(0) & ": " & index.Length
            LBL_SelectedObj.Text = LBL_SelectedObj.Text.Split(":")(0) & ": " & SelectedIndex + 1
            MainForm.LB_Dest_List.SelectedIndex = index(SelectedIndex)
        Else
            LBL_ObjsFound.Text = LBL_ObjsFound.Text.Split(":")(0) & ": " & "0"
            LBL_SelectedObj.Text = LBL_SelectedObj.Text.Split(":")(0) & ": " & "0"
        End If
    End Sub
    Private Sub BTN_Previous_Click(sender As Object, e As EventArgs) Handles BTN_Previous.Click
        If index IsNot Nothing Then
            If SelectedIndex - 1 < 0 Then
                SelectedIndex = index.Length - 1
            Else
                SelectedIndex -= 1
            End If
            LBL_ObjsFound.Text = LBL_ObjsFound.Text.Split(":")(0) & ": " & index.Length
            LBL_SelectedObj.Text = LBL_SelectedObj.Text.Split(":")(0) & ": " & SelectedIndex + 1
            MainForm.LB_Dest_List.SelectedIndex = index(SelectedIndex)
        Else
            LBL_ObjsFound.Text = LBL_ObjsFound.Text.Split(":")(0) & ": " & "0"
            LBL_SelectedObj.Text = LBL_SelectedObj.Text.Split(":")(0) & ": " & "0"
        End If
    End Sub
    Private Sub BTN_Next_Click(sender As Object, e As EventArgs) Handles BTN_Next.Click
        If index IsNot Nothing Then
            If SelectedIndex + 1 > index.Length - 1 Then
                SelectedIndex = 0
            Else
                SelectedIndex += 1
            End If
            LBL_ObjsFound.Text = LBL_ObjsFound.Text.Split(":")(0) & ": " & index.Length
            LBL_SelectedObj.Text = LBL_SelectedObj.Text.Split(":")(0) & ": " & SelectedIndex + 1
            MainForm.LB_Dest_List.SelectedIndex = index(SelectedIndex)
        Else
            LBL_ObjsFound.Text = LBL_ObjsFound.Text.Split(":")(0) & ": " & "0"
            LBL_SelectedObj.Text = LBL_SelectedObj.Text.Split(":")(0) & ": " & "0"
        End If
    End Sub
End Class