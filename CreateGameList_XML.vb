Public Class CreateGameList_XML
    Private p_MAME_XML_Path As String
    Private p_HistoryDAT_Path As String
    Private p_MameInfoDAT_Path As String
    Private p_GameExt As String
    Private p_ImagePath As String
    Private p_ImageExtension As String
    Private p_VideoExtension As String

    Public Property ShowProgress As Boolean
    Public Property ROMPath As String
    Public Property VideoPath As String
    Public Property ImageAppend As String
    Public Property ImagePrepend As String
    Public Property MarqueePath As String
    Public Property PrettyXML As Boolean = True
    Public Property RatingPath As String = ""
    Public Property RatingScale As Integer = 100
    Public Property FavouritePath As String = ""
    Public Property GenrePath As String = ""

    ''' <summary>
    ''' Path to the EmulationStation Gameslist.xml file to create and write to.
    ''' </summary>
    ''' <returns>Path to the xml file</returns>
    Public Property GAMELIST_XML_Path As String

    Public Property VideoExension As String
        Get
            If p_VideoExtension <> "" Then
                Return p_VideoExtension
            Else
                Return ".mp4"
            End If
        End Get
        Set(value As String)
            p_VideoExtension = value
        End Set
    End Property

    Public Property ImageExtension As String
        Get
            If p_ImageExtension <> "" Then
                Return p_ImageExtension
            Else
                Return ".jpg"
            End If
        End Get
        Set(value As String)
            p_ImageExtension = value
        End Set
    End Property

    Public Property ImagePath As String
        Get
            If p_ImagePath <> "" Then
                Return p_ImagePath
            Else
                Return "." 'Assume images are in same folder as roms. So things don't get broken?
            End If
        End Get
        Set(value As String)
            p_ImagePath = value
        End Set
    End Property

    Public Property GameExt As String
        Get
            If p_GameExt <> "" Then
                Return p_GameExt
            Else
                Return ".zip"
            End If
        End Get
        Set(value As String)
            p_GameExt = value
        End Set
    End Property

    ''' <summary>
    ''' Path to the Mame .XML file to read from
    ''' </summary>
    ''' <returns>Path to the xml file</returns>
    Public Property MAME_XML_Path As String
        Get
            Return p_MAME_XML_Path
        End Get
        Set(value As String)
            If System.IO.File.Exists(value) Then
                p_MAME_XML_Path = value
            Else
                p_MAME_XML_Path = ""
            End If
        End Set
    End Property

    ''' <summary>
    ''' Mame History.dat file to read info from
    ''' </summary>
    ''' <returns>path to the DAT file</returns>
    Public Property HistoryDAT_Path As String
        Get
            Return p_HistoryDAT_Path
        End Get
        Set(value As String)
            If System.IO.File.Exists(value) Then
                p_HistoryDAT_Path = value
            Else
                p_HistoryDAT_Path = ""
            End If
        End Set
    End Property

    ''' <summary>
    ''' Mame MameInfo.dat file to read info from
    ''' </summary>
    ''' <returns>path to the DAT file</returns>
    Public Property MameInfoDAT_Path As String
        Get
            Return p_MameInfoDAT_Path
        End Get
        Set(value As String)
            If System.IO.File.Exists(value) Then
                p_MameInfoDAT_Path = value
            Else
                p_MameInfoDAT_Path = ""
            End If
        End Set
    End Property

    ''' <summary>
    ''' Read in a mame .xml file, parse the rom name, game name, players, status etc and save to a new Emulation Station format Gamename.xml
    ''' </summary>
    ''' <returns>Integer: 0 for success otherwise error code.</returns>
    Public Function CreateGAMELIST_XML() As Integer
        Try
            Dim xd As New Xml.XmlDocument           'Create new XML Document. for the mame xml
            Dim xn As Xml.XmlNodeList               'Create a new XML Node, for reading mame xml nodes

            Dim Fs As IO.FileStream = New IO.FileStream(GAMELIST_XML_Path, IO.FileMode.Create)      'Create a new filestream, to write new xml out to
            Dim W As Xml.XmlTextWriter = New Xml.XmlTextWriter(Fs, System.Text.Encoding.UTF8)       'Create new xml writer class, used to write to filestream above

            Dim prgFrm As New frmGameListProgress
            If ShowProgress = True Then
                prgFrm.Show()
                'prgFrm.TopMost = True
                prgFrm.Activate()
                prgFrm.lblMain.Text = "Reading Mame XML file: " + MAME_XML_Path
                prgFrm.Refresh()
            End If

            xd.Load(MAME_XML_Path)  'Load mame xml into xml document

            Dim History As New ReadDATFile
            If HistoryDAT_Path <> "" Then
                prgFrm.lblMain.Text = "Reading History.dat file: " + HistoryDAT_Path
                prgFrm.Refresh()
                History.DatFilePath = HistoryDAT_Path
                History.RemoveString = "$bio"
                History.LoadDAT()
            End If

            Dim Info As New ReadDATFile
            If MameInfoDAT_Path <> "" Then
                prgFrm.lblMain.Text = "Reading MameInfo.dat file: " + MameInfoDAT_Path
                prgFrm.Refresh()
                Info.DatFilePath = MameInfoDAT_Path
                Info.RemoveString = "$mame"
                Info.LoadDAT()
            End If

            Dim Fav As New ReadFolderINI
            If FavouritePath <> "" Then
                prgFrm.lblMain.Text = "Reading Favourite ini file: " + FavouritePath
                prgFrm.Refresh()
                Fav.FolderINI_Path = FavouritePath
                Fav.SkipSettingsAndRoot = True
                Fav.StoreHeader = False
                Fav.LoadINI()
            End If

            Dim Genre As New ReadFolderINI
            If GenrePath <> "" Then
                prgFrm.lblMain.Text = "Reading Genre ini file: " + GenrePath
                prgFrm.Refresh()
                Genre.FolderINI_Path = GenrePath
                Genre.SkipSettingsAndRoot = True
                Genre.StoreHeader = True
                Genre.LoadINI()
            End If

            Dim Rating As New ReadFolderINI
            If RatingPath <> "" Then
                prgFrm.lblMain.Text = "Reading Rating ini file: " + RatingPath
                prgFrm.Refresh()
                Rating.FolderINI_Path = RatingPath
                Rating.SkipSettingsAndRoot = True
                Rating.HeaderFirstWordSignificantOnly = True
                Rating.StoreHeader = True
                Rating.LoadINI()
            End If

            Dim i As Integer
            Dim st1 As String = ""
            Dim Romfile As String = ""

            W.WriteStartDocument()                          'Begin XML Writer output.

            If PrettyXML = True Then
                W.Formatting = Xml.Formatting.Indented
                W.Indentation = 2
            End If

            W.WriteComment(“This file generated by the CreateGameList_XML class.”)
            W.WriteStartElement(“gameList”)                 'Write first Element, GameList

            xn = xd.GetElementsByTagName("machine")                                                                         'Find the "Machine" elements in the MAME XML
            For i = 0 To xn.Count - 1
                Try
                    Romfile = xn(i).Attributes.GetNamedItem("name").InnerText.Trim                                          'Read MAME Name (rom file/folder)

                    If ShowProgress Then
                        prgFrm.pbMain.Minimum = 0
                        prgFrm.pbMain.Maximum = xn.Count
                        prgFrm.pbMain.Step = 1
                        prgFrm.lblMain.Text = "Reading Mame game: " + Romfile
                    End If

                    Dim canwrite As Boolean = True

                    If ROMPath <> "" Then                                               'If the Rompath is not blank,
                        If Not IO.File.Exists(ROMPath + "\" + Romfile + GameExt) Then   'Check to see if the rom exists in the rom dir
                            canwrite = False                                            'If it doesn't then don't include this rom in the gamename.xml
                        End If
                    End If

                    If canwrite = True Then                                             'Include this game?
                        W.WriteStartElement(“game”)         'Write Game Element

                        W.WriteStartElement(“path”)         'Write Rom Path
                        W.WriteString(“./” + Romfile + GameExt)
                        W.WriteEndElement()                 'Close Rom Path

                        st1 = xn(i).Item("description").InnerText.Trim                                                      'Read MAME Game Name (Long Name/Description)
                        W.WriteStartElement(“name”)         'Write Game Name
                        W.WriteString(st1)
                        W.WriteEndElement()                 'Close Game Name

                        st1 = ""
                        If Not xn(i).Item("driver") Is Nothing Then                                                         'Check MAME 'driver' section exists in XML
                            If Not xn(i).Item("driver").Attributes.GetNamedItem("emulation").InnerText Is Nothing Then      'Check MAME 'emulatuon' section exists in 'driver' section in XML
                                st1 = "Emulation status: "
                                st1 += xn(i).Item("driver").Attributes.GetNamedItem("emulation").InnerText.Trim             'Read MAME Emulation Status
                            End If

                            If Not xn(i).Item("driver").Attributes.GetNamedItem("status").InnerText.Trim Is Nothing Then    'Check MAME 'status' section exists in 'driver' section in XML
                                st1 += "  Driver status: "
                                st1 += xn(i).Item("driver").Attributes.GetNamedItem("status").InnerText.Trim                'Read MAME Driver Status
                            End If
                        End If
                        If HistoryDAT_Path <> "" Then                                   'If History.dat is not blank, include it in the <description>
                            st1 += History.GetData(Romfile) 'Include History in <description>
                        End If
                        If MameInfoDAT_Path <> "" Then                                  'If MameInfo.dat is not blank, include it in the <description>
                            st1 += Info.GetData(Romfile)    'Include MameInfo in <description>
                        End If

                        W.WriteStartElement(“desc”)         'Write Description
                        W.WriteString(st1)
                        W.WriteEndElement()                 'Close Description

                        st1 = ImagePath + "/" + ImagePrepend + Romfile + ImageAppend + ImageExtension
                        W.WriteStartElement(“image”)        'Write Image
                        W.WriteString(st1)
                        W.WriteEndElement()                 'Close Image

                        If VideoPath <> "" Then                                         'If Video Path is not blank, include it in the .xml
                            st1 = VideoPath + "/" + Romfile + VideoExension
                            W.WriteStartElement(“video”)    'Write video
                            W.WriteString(st1)
                            W.WriteEndElement()             'Close video
                        End If

                        If MarqueePath <> "" Then
                            st1 = MarqueePath + "/" + Romfile + ImageExtension
                            W.WriteStartElement(“marquee”)  'Write marquee
                            W.WriteString(st1)
                            W.WriteEndElement()             'Close marquee
                        End If

                        Try
                            If RatingPath <> "" Then
                                st1 = Rating.GetData(Romfile)
                                If st1 <> "" Then
                                    st1 = CStr(CDbl(st1) / RatingScale)
                                    W.WriteStartElement(“rating”)   'Write rating
                                    W.WriteString(st1)
                                    W.WriteEndElement()             'Close rating
                                End If
                            End If
                        Catch
                        End Try

                        If Not xn(i).Item("year") Is Nothing Then                                                           'Check MAME 'year' section exists in XML
                            st1 = xn(i).Item("year").InnerText.Trim + "0101T000000"                                         'Read MAME Year : and add Month, Day,T, Hours, Mins, Seconds to it
                            W.WriteStartElement(“releasedate”)  'Write releasedate
                            W.WriteString(st1)
                            W.WriteEndElement()                 'Close releasedate
                        End If

                        If Not xn(i).Item("manufacturer") Is Nothing Then                                                   'Check MAME 'manufacturer' section exists in XML
                            st1 = xn(i).Item("manufacturer").InnerText.Trim                                                 'Read MAME Manufactutrer
                            W.WriteStartElement(“developer”)    'Write developer
                            W.WriteString(st1)
                            W.WriteEndElement()                 'Close developer
                            W.WriteStartElement(“publisher”)    'Write publisher
                            W.WriteString(st1)
                            W.WriteEndElement()                 'Close publisher
                        End If

                        If GenrePath <> "" Then
                            st1 = Genre.GetData(Romfile)
                            If st1 <> "" Then
                                W.WriteStartElement(“genre”)        'Write genre
                                W.WriteString(st1)
                                W.WriteEndElement()                 'Close genre
                            End If
                        End If

                        If Not xn(i).Item("input") Is Nothing Then                                                          'Check MAME 'input' section exists in XML
                            st1 = xn(i).Item("input").Attributes.GetNamedItem("players").InnerText.Trim                     'Read MAME Players
                            W.WriteStartElement(“players”)      'Write players
                            W.WriteString(st1)
                            W.WriteEndElement()                 'Close players
                        End If

                        If FavouritePath <> "" Then
                            st1 = Fav.GetDataB(Romfile).ToString
                            If st1 <> "" Then
                                W.WriteStartElement(“favorite”)     'Write favorite
                                W.WriteString(st1)
                                W.WriteEndElement()                 'Close favorite
                            End If
                        End If

                        W.WriteEndElement()                 'Close Game Element
                    End If

                    If ShowProgress Then
                        prgFrm.pbMain.PerformStep()
                        prgFrm.Refresh()
                    End If
                Catch e As Exception
                End Try
            Next
            If ShowProgress Then
                prgFrm.lblMain.Text = "Writing gamename.xml"
                prgFrm.Refresh()
            End If
            W.WriteEndElement()             'Close the first element, GameList.
            W.WriteEndDocument()            'Close XML Writer output.
            W.Close()                       'Close the class
            prgFrm.Close()
            prgFrm = Nothing
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function
End Class
