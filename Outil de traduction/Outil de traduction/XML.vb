Imports System.Text.Encoding
Public Class XML
    Sub New()
        For Each ei As System.Text.EncodingInfo In GetEncodings()
            AddToArray(Of String)(_AvaibleEncoding, ei.Name)
        Next
        _FileDatas = Nothing
        _FileName = Nothing
        _FilePath = Nothing
        _TrimContent = False
        _SelectedEncoding = Nothing
    End Sub

    Public Event FileOpened()
    Public Event FileSaved()

    Private _Author As String
    Public Property Author() As String
        Get
            Return If(_Author Is Nothing, "Oyissan", _Author)
        End Get
        Set(ByVal value As String)
            _Author = value
        End Set
    End Property
    Private _AvaibleEncoding() As String
    Public ReadOnly Property AvaibleEncoding() As String()
        Get
            Return _AvaibleEncoding
        End Get
    End Property
    Public ReadOnly Property RawFileContent() As String
        Get
            Dim fc As String = Nothing
            If IO.File.Exists(FilePath) Then
                fc = IO.File.ReadAllText(_FilePath, GetEncoding(SelectedEncoding))
            End If
            Return fc
        End Get
    End Property
    Private _FileDatas() As Data
    Public Property FileDatas() As Data()
        Get
            Return _FileDatas
        End Get
        Set(ByVal value() As Data)
            _FileDatas = value
        End Set
    End Property
    Private _FileName As String
    Public ReadOnly Property FileName() As String
        Get
            Return _FileName
        End Get
    End Property
    Private _FilePath As String
    Public ReadOnly Property FilePath() As String
        Get
            Return _FilePath
        End Get
    End Property
    Private _TrimContent As Boolean
    Public Property TrimContent() As Boolean
        Get
            Return _TrimContent
        End Get
        Set(ByVal value As Boolean)
            _TrimContent = value
        End Set
    End Property
    Private _SelectedEncoding As String
    Public Property SelectedEncoding() As String
        Get
            If _SelectedEncoding Is Nothing Then _SelectedEncoding = AvaibleEncoding(0)
            Return _SelectedEncoding
        End Get
        Set(ByVal value As String)
            _SelectedEncoding = value
            ParseFile()
        End Set
    End Property

    Public Sub NewData(ByVal Data As Data)
        AddToArray(Of Data)(FileDatas, Data)
    End Sub
    Public Sub InsertData(ByVal Index As Integer, ByVal Data As Data)
        If FileDatas IsNot Nothing Then
            Dim f() As Data = Nothing
            For i As Integer = 0 To FileDatas.Length - 1
                AddToArray(Of Data)(f, New Data(FileDatas(i).Id, FileDatas(i).Content))
                If i = Index Then
                    AddToArray(Of Data)(f, Data)
                End If
            Next
            FileDatas = f
        Else
            NewData(Data)
        End If
    End Sub
    Public Sub ModifyData(ByVal Index As Integer, ByVal ID As String, ByVal Content As String)
        If FileDatas Is Nothing Then Exit Sub
        If FileDatas(Index) Is Nothing Then Exit Sub
        FileDatas(Index).Id = ID
        FileDatas(Index).Content = ParseContent(Content)
    End Sub
    Public Sub DeleteData(ByVal Index As Integer)
        If FileDatas IsNot Nothing Then
            If FileDatas(Index) IsNot Nothing Then
                If FileDatas.Length = 1 Then
                    FileDatas = Nothing
                    Exit Sub
                End If

                Dim f() As Data = Nothing
                For i As Integer = 0 To FileDatas.Length - 1
                    If Not i = Index Then
                        AddToArray(Of Data)(f, New Data(FileDatas(i).Id, FileDatas(i).Content))
                    End If
                Next
                FileDatas = f
            End If
        End If
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
    Function CreateFile() As String
        Dim f As String = Nothing
        f &= "<?xml version=""1.0"" encoding=""" & SelectedEncoding & """ ?>" & vbCrLf
        f &= "<!-- ALSEWARE -->" & vbCrLf
        f &= "<!-- File made by " & Author & " using Oyissan Tool -->" & vbCrLf
        f &= "<string_table>"
        If FileDatas IsNot Nothing Then
            For Each d As Data In FileDatas
                f &= vbCrLf & vbTab & "<string id=""" & d.Id & """>"
                f &= vbCrLf & vbTab & vbTab & "<text>" & d.Content & "</text>"
                f &= vbCrLf & vbTab & "</string>"
            Next
        End If
        f &= vbCrLf & "</string_table>"
        Return f
    End Function
    Sub OpenFile(Optional ByVal Path As String = Nothing)
        If Path Is Nothing Then
            Dim ofd As New OpenFileDialog
            ofd.Filter = "XML File|*.xml"
            ofd.CheckFileExists = True
            ofd.CheckPathExists = True
            ofd.Multiselect = False
            ofd.RestoreDirectory = False

            If ofd.ShowDialog = DialogResult.OK Then
                _FileDatas = Nothing
                _FileName = Nothing
                _FilePath = Nothing

                _FileName = ofd.SafeFileName
                _FilePath = ofd.FileName
                ParseFile()
                RaiseEvent FileOpened()
            End If
        Else
            If Path.Split("\")(Path.Split("\").Length - 1).EndsWith(".xml") Then
                _FileName = Path.Split("\")(Path.Split("\").Length - 1)
                _FilePath = Path
                ParseFile()
                RaiseEvent FileOpened()
            Else
                Dim ofd As New OpenFileDialog
                ofd.Filter = "XML File|*.xml"
                ofd.CheckFileExists = True
                ofd.CheckPathExists = True
                ofd.Multiselect = False
                ofd.InitialDirectory = Path

                If ofd.ShowDialog = DialogResult.OK Then
                    _FileDatas = Nothing
                    _FileName = Nothing
                    _FilePath = Nothing

                    _FileName = ofd.SafeFileName
                    _FilePath = ofd.FileName
                    ParseFile()
                    RaiseEvent FileOpened()
                End If
            End If
        End If
    End Sub
    Sub ParseFile()
        Dim c As String = RawFileContent
        Dim Parsed As String = Nothing
        Dim OpenString As String = "<string id="""
        Dim BeginId As String = "id="""
        Dim IdName As String = Nothing
        Dim EndId As String = """>"
        Dim BeginContent As String = "<text>"
        Dim content As String = Nothing
        Dim EndContent As String = "</text>"
        Dim CloseString As String = "</string>"
        If c = Nothing Then Exit Sub
        If Not c.Length > 0 Then Exit Sub
        FileDatas = Nothing
        For i As Integer = 0 To c.Length - 1
            If Not (i + OpenString.Length) <= c.Length - 1 Then Exit For

            If c.Substring(i, OpenString.Length).Equals(OpenString) Then
                For i2 As Integer = i To c.Length - 1
                    If c.Substring(i2, CloseString.Length).Equals(CloseString) Then
                        Dim L As Integer = ((i2 + CloseString.Length) - i)
                        Parsed = c.Substring(i, L)
                        For i3 As Integer = 0 To Parsed.Length - 1
                            If Not (i3 + BeginId.Length) <= Parsed.Length - 1 Then Exit For
                            If Parsed.Substring(i3, BeginId.Length).Equals(BeginId) Then
                                For i4 As Integer = (i3 + BeginId.Length) To Parsed.Length - 1
                                    If Parsed.Substring(i4, EndId.Length).Equals(EndId) Then
                                        IdName = Parsed.Substring(i3 + BeginId.Length, (i4 - (i3 + BeginId.Length)))
                                        Exit For
                                    End If
                                Next
                            End If
                            If Not (i3 + BeginContent.Length) <= Parsed.Length - 1 Then Exit For
                            If Parsed.Substring(i3, BeginContent.Length).Equals(BeginContent) Then
                                For i5 As Integer = (i3 + BeginContent.Length) To Parsed.Length - 1
                                    If Parsed.Substring(i5, EndContent.Length).Equals(EndContent) Then
                                        content = Parsed.Substring(i3 + BeginContent.Length, (i5 - (i3 + BeginContent.Length)))
                                        Exit For
                                    End If
                                Next
                            End If
                            If Not IdName = Nothing And Not content = Nothing Then
                                AddToArray(Of Data)(FileDatas, New Data(IdName, ParseContent(content)))
                                IdName = Nothing
                                content = Nothing
                            End If
                        Next
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub
    Function ParseContent(ByRef Content As String) As String
        If TrimContent = True Then
            Dim c() As String = Content.Split(vbCrLf.ToCharArray)
            Dim c2 As String = Nothing
            For Each s As String In c
                c2 &= s
            Next
            c2 = c2.Replace(vbTab, "")
            c2 = c2.Replace("\n", "\n" & vbCrLf)
            Return c2
        Else
            Return Content
        End If
    End Function
    Function SaveAsFile(Optional ByVal Path As String = Nothing) As Boolean
        If Path Is Nothing Then
            Dim sfd As New SaveFileDialog
            sfd.Filter = "XML File|*.xml"
            sfd.RestoreDirectory = False

            If sfd.ShowDialog = DialogResult.OK Then
                IO.File.WriteAllText(sfd.FileName, CreateFile, GetEncoding(SelectedEncoding))
                _FileName = sfd.FileName.Split("\")(sfd.FileName.Split("\").Length - 1)
                _FilePath = sfd.FileName
                RaiseEvent FileSaved()
                Return True
                Exit Function
            End If
        Else
            If Path.Split("\")(Path.Split("\").Length - 1).EndsWith(".xml") Then
                IO.File.WriteAllText(Path, CreateFile, GetEncoding(SelectedEncoding))
                _FileName = Path.Split("\")(Path.Split("\").Length - 1)
                _FilePath = Path
                RaiseEvent FileSaved()
                Return True
                Exit Function
            End If

            Dim sfd As New SaveFileDialog
            sfd.Filter = "XML File|*.xml"
            sfd.InitialDirectory = Path

            If sfd.ShowDialog = DialogResult.OK Then
                IO.File.WriteAllText(sfd.FileName, CreateFile, GetEncoding(SelectedEncoding))
                _FileName = sfd.FileName.Split("\")(sfd.FileName.Split("\").Length - 1)
                _FilePath = sfd.FileName
                RaiseEvent FileSaved()
                Return True
                Exit Function
            End If
        End If
        Return False
    End Function
    Function SaveFile() As Boolean
        If IO.File.Exists(FilePath) Then
            IO.File.WriteAllText(FilePath, CreateFile, GetEncoding(SelectedEncoding))
            RaiseEvent FileSaved()
            Return True
            Exit Function
        Else
            If SaveAsFile() Then
                Return True
                Exit Function
            End If
        End If
        Return False
    End Function

    Public Class Data
        Sub New(ByVal Id As String, ByVal Content As String)
            _Content = Content
            _Id = Id
        End Sub

        Private _Content As String
        Public Property Content() As String
            Get
                Return _Content
            End Get
            Set(ByVal value As String)
                _Content = value
            End Set
        End Property
        Private _Id As String
        Public Property Id() As String
            Get
                Return _Id
            End Get
            Set(ByVal value As String)
                _Id = value
            End Set
        End Property
    End Class
End Class
