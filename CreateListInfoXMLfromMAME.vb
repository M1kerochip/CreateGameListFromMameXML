Public Class CreateListInfoXMLfromMAME
    Private p_MAME_EXE_Path As String
    Private p_MAME_XML_Path As String

    Public Property CMDArguments As String = "-listxml"

    Public Property MAME_EXE_Path As String
        Get
            Return p_MAME_EXE_Path
        End Get
        Set(value As String)
            If System.IO.File.Exists(value) Then
                p_MAME_EXE_Path = value
            Else
                p_MAME_EXE_Path = ""
            End If
        End Set
    End Property

    Public Property MAME_XML_Path As String
        Get
            Return p_MAME_XML_Path
        End Get
        Set(value As String)
            p_MAME_XML_Path = value
        End Set
    End Property


    Public Function GenerateXML() As Integer
        If System.IO.File.Exists(MAME_EXE_Path) Then
            Try
                Dim CMD As New Process
                Dim SW As IO.StreamWriter
                Dim SR As IO.StreamReader

                CMD.StartInfo.FileName = MAME_EXE_Path
                CMD.StartInfo.Arguments = CMDArguments
                CMD.StartInfo.UseShellExecute = False
                CMD.StartInfo.WorkingDirectory = IO.Path.GetDirectoryName(MAME_EXE_Path)
                CMD.StartInfo.RedirectStandardInput = True
                CMD.StartInfo.RedirectStandardOutput = True
                CMD.StartInfo.CreateNoWindow = True
                CMD.Start()
                SW = CMD.StandardInput
                SR = CMD.StandardOutput
                CMD.Dispose()
                Dim StreamWriter As New IO.StreamWriter(MAME_XML_Path)
                StreamWriter.Write(SR.ReadToEnd())
                StreamWriter.Flush()
                StreamWriter.Close()
                StreamWriter.Dispose()
                SW.Dispose()
                SR.Dispose()
                Return 0
            Catch
                Return -2
            End Try
        Else
            Return -1
        End If
    End Function
End Class
