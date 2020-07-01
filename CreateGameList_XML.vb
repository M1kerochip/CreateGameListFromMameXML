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
    Public Property IsSoftwareList As Boolean = False

    Public Property CreateEmptyZip As String = ""
    Public Property MoveEmptyZipClonesDir As String = ""

    Public Property HiddenDriverList As String = ""

    Public Property ResultString As String = ""

    Public Property SearchRomSubDirs As Boolean = False

    ''' <summary>
    ''' If ratings are enabled, and there's a rating list, set this to true to check to see if a game has a score lower than this. If so, set hidden to true.
    ''' </summary>
    ''' <returns></returns>
    Public Property HideRatedGamesWithScore As Boolean = False

    Public Property HiddenScore As Integer = 30

    Public Property FavRatedGamesWithScore As Boolean = False
    Public Property FavScore As Integer = 80

    Public Property HideBios As Boolean = True
    Public Property HiddenListPath As String
    Public Property DontHideFavGame As Boolean = False

    ''' <summary>
    ''' Include Mame xml emulation status and driver status as first line of description
    ''' </summary>
    ''' <returns></returns>
    Public Property IncludeEmuStatus As Boolean = True

    Public Property RemoveAdditionalCategories As String

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
            Application.DoEvents()

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

            Dim HiddenList As New ReadFolderINI
            If HiddenListPath <> "" Then
                prgFrm.lblMain.Text = "Reading Hidden Games List ini file: " + HiddenListPath
                prgFrm.Refresh()
                HiddenList.FolderINI_Path = HiddenListPath
                HiddenList.SkipSettingsAndRoot = True
                HiddenList.StoreHeader = False
                HiddenList.LoadINI()
            End If

            Dim i As Integer                'Count of number of machine elements in the .xml file
            Dim favouritedGames As Integer = 0
            Dim hiddenGames As Integer = 0
            Dim writtenGames As Integer = 0

            Dim st1 As String = ""          'Blank String to hold results
            Dim Romfile As String = ""      'Rom Name
            Dim DriverName As String = ""   'Holds driver name eg cps1.cpp
            Dim gp As String = ""           'Holds Genre 

            W.WriteStartDocument()                          'Begin XML Writer output.

            If PrettyXML = True Then
                W.Formatting = Xml.Formatting.Indented
                W.Indentation = 2
            End If

            W.WriteComment(“This file generated by the CreateGameList_XML class.”)
            W.WriteStartElement(“gameList”)                 'Write first Element, GameList

            If IsSoftwareList = False Then
                xn = xd.GetElementsByTagName("machine")                                                                         'Find the "Machine" elements in the MAME XML
            Else
                xn = xd.GetElementsByTagName("software")                                                                        'Find the "software" elements in the Software List XML
            End If
            For i = 0 To xn.Count - 1
                Try
                    Romfile = xn(i).Attributes.GetNamedItem("name").InnerText.Trim                                          'Read MAME Name (rom file/folder)

                    If Not xn(i).Attributes("sourcefile") Is Nothing Then
                        DriverName = xn(i).Attributes.GetNamedItem("sourcefile").InnerText.Trim                             'Read MAME source file name.
                    End If

                    ResultString = "ROM: " + Romfile + vbCrLf + "Name: " + DriverName
                    If ShowProgress Then
                        prgFrm.pbMain.Minimum = 0
                        prgFrm.pbMain.Maximum = xn.Count
                        prgFrm.pbMain.Step = 1
                        prgFrm.lblMain.Text = "Reading Mame game: " + Romfile
                    End If

                    Dim canwrite As Boolean = True

                    If ROMPath <> "" Then                                               'If the Rompath is not blank, we need to check if a file exists in the rom dir.
                        If Not IO.File.Exists(ROMPath + "\" + Romfile + GameExt) Then   'Check to see if the rom exists in the rom dir
                            canwrite = False                                            'If it doesn't then don't include this rom in the gamename.xml
                        End If
                    End If

                    If canwrite = True Then                                             'Include this game?
                        W.WriteStartElement(“game”)         'Write Game Element

                        Dim romd As String = “./” + Romfile + GameExt

                        If MoveEmptyZipClonesDir <> "" Then
                            If Not xn(i).Attributes.GetNamedItem("cloneof") Is Nothing Then
                                romd = “./” + MoveEmptyZipClonesDir + "/" + Romfile + GameExt
                            End If
                        End If

                        W.WriteStartElement(“path”)         'Write Rom Path
                        W.WriteString(romd)
                        W.WriteEndElement()                 'Close Rom Path

                        Dim RomDescName As String = ""

                        RomDescName = xn(i).Item("description").InnerText.Trim                                                  'Read MAME Game Name (Long Name/Description)
                        W.WriteStartElement(“name”)         'Write Game Name
                        W.WriteString(RomDescName)
                        W.WriteEndElement()                 'Close Game Name

                        st1 = ""
                        If IncludeEmuStatus = True Then
                            If Not xn(i).Item("driver") Is Nothing Then                                                         'Check MAME 'driver' section exists in XML
                                If Not xn(i).Item("driver").Attributes.GetNamedItem("emulation").InnerText Is Nothing Then      'Check MAME 'emulatuon' section exists in 'driver' section in XML
                                    st1 = "Emulation status: "
                                    st1 += xn(i).Item("driver").Attributes.GetNamedItem("emulation").InnerText.Trim             'Read MAME Emulation Status
                                End If

                                If Not xn(i).Item("driver").Attributes.GetNamedItem("status").InnerText.Trim Is Nothing Then    'Check MAME 'status' section exists in 'driver' section in XML
                                    st1 += "  Driver status: "
                                    st1 += xn(i).Item("driver").Attributes.GetNamedItem("status").InnerText.Trim                'Read MAME Driver Status
                                End If
                                If st1 <> "" Then
                                    st1 += vbCrLf
                                End If
                            End If
                        End If

                        Dim HistDesc As String = ""
                        If HistoryDAT_Path <> "" Then                                   'If History.dat is not blank, include it in the <description>
                            HistDesc += History.GetData(Romfile) 'Include History in <description>
                        End If

                        Dim InfoDesc As String = ""
                        If MameInfoDAT_Path <> "" Then                                  'If MameInfo.dat is not blank, include it in the <description>
                            InfoDesc += Info.GetData(Romfile)    'Include MameInfo in <description>
                        End If

                        W.WriteStartElement(“desc”)         'Write Description
                        W.WriteString(st1 + HistDesc + InfoDesc)
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

                        If MarqueePath <> "" Then                                       'If Marquee Path is not blank, include it in the .xml
                            st1 = MarqueePath + "/" + Romfile + ImageExtension
                            W.WriteStartElement(“marquee”)  'Write marquee
                            W.WriteString(st1)
                            W.WriteEndElement()             'Close marquee
                        End If

                        Dim writeHiddensection As Boolean = False                       'Define hidden section criteria

                        Dim Ra As String = ""   'Holds Rating
                        Try
                            If RatingPath <> "" Then                                    'If we are rating games
                                Ra = Rating.GetData(Romfile)                            'Get Game Rating
                                If Ra <> "" Then                                        'If game has a rating:
                                    Ra = CStr(CDbl(Ra) / RatingScale)                   'Work out rating from scale, and convert into ES rating scale (ie a % of 1)
                                    W.WriteStartElement(“rating”)   'Write rating
                                    W.WriteString(Ra)
                                    W.WriteEndElement()             'Close rating

                                    If HideRatedGamesWithScore = True Then              'If games have a score, and we want to hide scores below a certain level:
                                        If CDbl(Ra) <= CDbl(HiddenScore) / RatingScale Then    'Check score is equal to or below level
                                            writeHiddensection = True                   'Critera matches; write hidden section for this game
                                        End If
                                    End If
                                End If
                            End If
                        Catch
                        End Try

                        If HideBios = True Then                                             'Hide Bios files in list
                            If Not xn(i).Attributes.GetNamedItem("isbios").InnerText Is Nothing Then                        'Check MAME 'is this machine/system a bios only' attribute exists in machine section in XML
                                If xn(i).Attributes.GetNamedItem("isbios").InnerText.Trim = "yes" Then                      'Read Bios attribute.
                                    writeHiddensection = True                               'Critera matches; write hidden section for this game
                                End If
                            End If
                            If xn(i).Item("display") Is Nothing Then                                                        'Check MAME for 'Display' entries. Zero entries means screenless game/system.
                                writeHiddensection = True                                   'Critera matches; write hidden section for this game
                            End If
                            If Not xn(i).Attributes.GetNamedItem("runnable").InnerText Is Nothing Then                      'Check MAME 'is this a runnable game/system' attribute exists in machine section in XML
                                If xn(i).Attributes.GetNamedItem("runnable").InnerText.Trim = "no" Then                     'Read Bios attribute.
                                    writeHiddensection = True                               'Critera matches; write hidden section for this game
                                End If
                            End If
                            If Not xn(i).Attributes.GetNamedItem("ismechanical").InnerText Is Nothing Then                  'Check MAME 'is this a mechanical game/system' attribute exists in machine section in XML
                                If xn(i).Attributes.GetNamedItem("ismechanical").InnerText.Trim = "yes" Then                'Read Bios attribute.
                                    writeHiddensection = True                               'Critera matches; write hidden section for this game
                                End If
                            End If
                            If Not xn(i).Attributes.GetNamedItem("isdevice").InnerText Is Nothing Then                      'Check MAME 'is this a device?' attribute exists in machine section in XML
                                If xn(i).Attributes.GetNamedItem("isdevice").InnerText.Trim = "yes" Then                    'Read Bios attribute.
                                    writeHiddensection = True                               'Critera matches; write hidden section for this game
                                End If
                            End If
                        End If

                        If HiddenListPath <> "" Then
                            If HiddenList.GetDataB(Romfile) = True Then
                                writeHiddensection = True                                   'Critera matches; write hidden section for this game
                            End If
                        End If


                        If GenrePath <> "" Then                                                                             'If an genre.ini file exists:
                            gp = Genre.GetData(Romfile)                                                                     'Get genre from ini file
                            If gp <> "" Then                                                                                'If the genre isn't blank:
                                If RemoveAdditionalCategories <> "" Then                                                    'Check to see if there are additional genre's to remove:
                                    For Each value As String In RemoveAdditionalCategories.Split(CType(";", Char()))        'If so, see if the genre for the game contains any of the [remove gnere] text entries
                                        If value.Trim <> "" Then
                                            If gp.ToUpper.Contains(value.ToUpper) Then
                                                writeHiddensection = True                   'Critera matches; write hidden section for this game
                                            End If
                                        End If
                                    Next
                                End If
                            End If
                        End If

                        If HiddenDriverList <> "" Then
                            For Each value As String In HiddenDriverList.Split(CType(";", Char()))        'If so, see if the genre for the game contains any of the [remove gnere] text entries
                                If value.Trim <> "" Then
                                    If DriverName.ToUpper = value.ToUpper Then
                                        writeHiddensection = True                           'Critera matches; write hidden section for this game
                                    End If
                                End If
                            Next
                        End If

                        'Final Hidden game override: Even if any of the above cause the game to be hidden, check to see if it's in the fav list. If so, whitelist it.
                        Dim FavReq As Boolean = False
                        Dim f As Boolean = False

                        If FavouritePath <> "" Then                                                                         'If we have a list of favourite.ini games
                            f = Fav.GetDataB(Romfile)                                                                       'Check to see if current game is in the fav list
                            If f = True Then
                                FavReq = True                                                                               'If so, need to mark it as fav in gamelist
                            End If
                        End If

                        If FavReq = True Then                                                                               'If this game is a favourite,
                            writeHiddensection = False                                      'Do not write hidden section for this game
                        End If

                        If writeHiddensection = True Then                                                                   'If any of the above causes the rom to be hidden:
                            W.WriteStartElement(“hidden”)   'Write hidden
                            W.WriteString("true")
                            W.WriteEndElement()             'Close hidden
                            hiddenGames += 1
                        End If

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

                        If gp <> "" Then                                                                                    'If a genre exists for the rom in the genre.ini file
                            W.WriteStartElement(“genre”)        'Write genre
                            W.WriteString(gp)
                            W.WriteEndElement()                 'Close genre
                        End If

                        If Not xn(i).Item("input") Is Nothing Then                                                          'Check MAME 'input' section exists in XML
                            st1 = xn(i).Item("input").Attributes.GetNamedItem("players").InnerText.Trim                     'Read MAME Players
                            W.WriteStartElement(“players”)      'Write players
                            W.WriteString(st1)
                            W.WriteEndElement()                 'Close players
                        End If

                        If RatingPath <> "" Then
                            If FavRatedGamesWithScore = True Then
                                If CDbl(Ra) >= CDbl(FavScore) / RatingScale Then    'Check score is equal to or below level
                                    FavReq = True                   'Critera matches; write hidden section for this game
                                End If
                            End If
                        End If

                        If FavReq = True Then
                            W.WriteStartElement(“favorite”)     'Write favorite
                            W.WriteString("true")
                            W.WriteEndElement()                 'Close favorite
                            favouritedGames += 1
                        End If

                        W.WriteEndElement()                     'Close Game Element
                        writtenGames += 1
                    End If

                    If ShowProgress Then
                        prgFrm.pbMain.PerformStep()
                        prgFrm.Refresh()
                    End If

                    If CreateEmptyZip <> "" Then
                        Dim fn As String = ""
                        If MoveEmptyZipClonesDir <> "" Then
                            If Not xn(i).Attributes.GetNamedItem("cloneof") Is Nothing Then
                                fn = CreateEmptyZip + "\" + MoveEmptyZipClonesDir + "\" + Romfile + GameExt
                            Else
                                fn = CreateEmptyZip + "\" + Romfile + GameExt
                            End If
                        Else
                            fn = CreateEmptyZip + "\" + Romfile + GameExt
                        End If
                        IO.File.Create(fn).Dispose()
                    End If
                Catch e As Exception
                End Try
                Application.DoEvents()
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

            ResultString = "Machines in XML: " + CStr(i) + vbCrLf
            ResultString += "Games written: " + CStr(writtenGames) + vbCrLf
            ResultString += "Games favourited: " + CStr(favouritedGames) + vbCrLf
            ResultString += "Games hidden: " + CStr(hiddenGames) + vbCrLf
            ResultString += "Visible game count: " + CStr(writtenGames - hiddenGames)

            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function
End Class
