Public Class ReadDATFile
    Private p_StartString As String
    Private p_EndString As String
    Private DataLoaded As Boolean = False
    Private lstTitles As New List(Of String)
    Private lstInfo As New List(Of String)

    Public Property DatFilePath As String
    Public Property IsBIOS As Boolean = False
    Public Property RemoveString As String = "$mame"
    Public Property StartString As String = "$info"
    Public Property EndString As String = "$end"
    Public Property IncludeCR As Boolean = True

    Public Function LoadDAT() As Boolean
        If DatFilePath <> "" Then
            lstTitles.Clear()
            lstInfo.Clear()

            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(DatFilePath)

            Dim st As String
            Dim S_Title As String = ""
            Dim S_Desc As String = ""

            st = fileReader.ReadLine()  'Read First line
            While Not fileReader.EndOfStream
                If st <> "" Then
                    If st.Chars(0) = "$" Then    'If first line is not an game info line
                        Exit While
                    Else
                        st = fileReader.ReadLine()  'Read lines until game line reached
                    End If
                Else
                    st = fileReader.ReadLine()  'Read lines until game line reached
                End If
            End While

            While Not fileReader.EndOfStream
                If st = EndString Then
                    If S_Title <> "" Then       'Don't add non $info titles to the list
                        lstTitles.Add(S_Title)
                        lstInfo.Add(S_Desc)
                    End If
                    S_Desc = ""
                    S_Title = ""
                Else
                    Dim s As String = st.Split(CType("=", Char())).First
                    If s = RemoveString Then
                        ' do nothing
                    Else
                        If st <> "" Then
                            If st.Chars(0) = "$" Then                                       'If the first character is a $
                                If st.Split(CType("=", Char())).First = StartString Then    'Check to see if it begins with $info  (This won't work for game list titles from BIOS fields ie lines that begin with $BIOSNAME)
                                    S_Title = st.Split(CType("=", Char())).Last             'If so, add everything after = to the list of titles
                                    st = fileReader.ReadLine()                              'Remove next line: $mame, $bio etc
                                End If
                            Else
                                If IncludeCR Then st += vbCr
                                S_Desc += st
                            End If
                        Else
                            If IncludeCR Then st += vbCr
                            S_Desc += st
                        End If
                    End If
                End If
                st = fileReader.ReadLine()
            End While
            DataLoaded = True
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetData(GameName As String) As String
        If DataLoaded = False Then LoadDAT()
        If GameName <> "" Then
            Dim GameInfo As String = ""
            Dim x As Integer
            For x = 0 To lstTitles.Count - 1
                If lstTitles(x).Split(CType(",", Char())).Contains(GameName) Then
                    GameInfo += lstInfo(x)
                End If
            Next
            Return GameInfo
        Else
            Return ""
        End If
    End Function

End Class
