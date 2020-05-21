Public Class ReadFolderINI
    Private lstTitles As New List(Of String)
    Private lstBoolean As New List(Of Boolean)
    Private lstHeaders As New List(Of String)

    ''' <summary>
    ''' Stores each game with a list of header sections, or list of booleans
    ''' </summary>
    ''' <returns>Return True to use Text header list, false to use Boolean list</returns>
    Public Property StoreHeader As Boolean

    Public Property FolderINI_Path As String

    Public Property SkipSettingsAndRoot As Boolean = True

    Public Property HeaderFirstWordSignificantOnly As Boolean = False

    Public Function LoadINI() As Boolean
        Dim Settings As String = "[FOLDER_SETTINGS]"
        Dim FolRoot As String = "[ROOT_FOLDER]"

        Dim CurrentHeader As String = ""
        Dim st As String = ""
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(FolderINI_Path)

        If SkipSettingsAndRoot = True Then
            st = fileReader.ReadLine()  'Read First line
            While Not fileReader.EndOfStream
                If st <> "" Then
                    If st = Settings Then    'If first line is not an game info line
                        st = fileReader.ReadLine()  'Read next line
                        Exit While
                    Else
                        st = fileReader.ReadLine()  'Read lines until game line reached
                    End If
                Else
                    st = fileReader.ReadLine()  'Read lines until game line reached
                End If
            End While
            While Not fileReader.EndOfStream
                If st <> "" Then
                    If st = FolRoot Then    'If first line is not an game info line
                        st = fileReader.ReadLine()  'Read next line
                        Exit While
                    Else
                        st = fileReader.ReadLine()  'Read lines until game line reached
                    End If
                Else
                    st = fileReader.ReadLine()  'Read lines until game line reached
                End If
            End While
            While Not fileReader.EndOfStream
                If st <> "" Then
                    If st.Chars(0) = "[" Then    'If first line is not a header line
                        Exit While
                    Else
                        st = fileReader.ReadLine()  'Read lines until game line reached
                    End If
                Else
                    st = fileReader.ReadLine()  'Read lines until game line reached
                End If
            End While

            While Not fileReader.EndOfStream
                If st <> "" Then
                    If st.Chars(0) = "[" Then    'If line is a header line
                        If HeaderFirstWordSignificantOnly = False Then
                            CurrentHeader = st.Substring(1, st.Length - 2)
                        Else
                            CurrentHeader = st.Substring(1, st.Length - 2).Split(CType(" ", Char())).First
                        End If
                    Else
                        If st <> "" Then
                            lstTitles.Add(st)
                            If StoreHeader = True Then
                                lstHeaders.Add(CurrentHeader)
                            Else
                                lstBoolean.Add(True)
                            End If
                        End If
                    End If
                End If
                st = fileReader.ReadLine()  'Read lines until end line reached
            End While
        End If

        Return True
    End Function

    Public Function GetData(GameName As String) As String
        If GameName <> "" Then
            Dim GameInfo As String = ""
            Dim x As Integer
            For x = 0 To lstTitles.Count - 1
                '                If lstTitles(x).Contains(GameName) Then
                If lstTitles(x).Trim.ToUpper = GameName.Trim.ToUpper Then
                    GameInfo += lstHeaders(x)
                    Exit For
                End If
            Next
            Return GameInfo
        Else
            Return ""
        End If
    End Function

    Public Function GetDataB(Gamename As String) As Boolean
        If Gamename <> "" Then
            Dim GameInfo As Boolean = False
            Dim x As Integer
            For x = 0 To lstTitles.Count - 1
                '               If lstTitles(x).Contains(Gamename) Then
                If lstTitles(x).Trim.ToUpper = Gamename.Trim.ToUpper Then
                    GameInfo = lstBoolean(x)
                    Exit For
                End If
            Next
            Return GameInfo
        Else
            Return False
        End If
    End Function

End Class
