Imports System.ComponentModel

'TODO: add whitelisting for hidden in games (So, never set hidden=true, if game is in whitelist, regardless if game is bios, gamescore is too low etc.)

'TODO: add whitelisting for favourites too?

Public Class frmMain

    Function AddTooltips() As Boolean
        Try
            With ToolTip1
                .SetToolTip(btnCreateGameList, "Click to start the process, and create a gamelist.xml in the same directory as the mame input .xml")
                .SetToolTip(btnCreateMameXML, "Set the mame exe path and XML filename below. Click to create a mame -listxml .xml")
                .SetToolTip(btnMameEXEPath, "Use Windows dialog to pick mame exe path.")
                .SetToolTip(txtMameEXEPath, "Path to the mame exe you want to create details for.")
                .SetToolTip(txtMameXMLPath, "Path to the XML file you wish to use or create. File name must exist for gamelist.xml creation.")
                .SetToolTip(txtImages, "Path to the images you've downloaded for Mame. If you have a previous set of scraped and downloaded images, you can use the append box below to append -image to the filename")
                .SetToolTip(chkVersionXML, "Use the below .xml file for reading MAME details. (Required at the moment)")
                .SetToolTip(chkImagePrepend, "Prepend the below text to all snapshot images.")
                .SetToolTip(chkImageAppend, "Append the below text to all snapshot images. Useful if you have a previously scraped image set.")
                .SetToolTip(chkVideoDir, "Enable adding MAME video files to the gamelist. Must be in the format ROMNAME.EXT")
                .SetToolTip(chkScanSubFolders, "Scan subfolders in the main rom directory for rom file.")
                .SetToolTip(cmbROMExt, "The extension, including period, of the existing rom files. Usually .zip or .7z")
                .SetToolTip(cmbVideoExt, "The extension, including period, of the existing video files. Usually .mp4")
                .SetToolTip(chkPrettyXML, "Create readable, indented XML. Only useful if you're going to edit the file by hand.")
                .SetToolTip(txtFavouritesPath, "Set a folder.ini file here. If the romset exists in this file, it will be added to your favourites in Emulation Station")
                .SetToolTip(chkHideBios, "Sets Bios, non runnable, screenless and mechanical sets to hidden.")
                .SetToolTip(txtImageAppend, "Adds this text to the end of an image name. eg. rom 005.zip has 005-image.png if previously scraped.")
            End With
            'TODO: add toolips for rest of options
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function ReadSettings() As Boolean
        Try
            If My.Settings.UpdateSettings = True Then                       'Copy user settings from previous application version if necessary
                My.Settings.Upgrade()
                My.Settings.UpdateSettings = False
                My.Settings.Save()
            End If

            With My.Settings
                txtMameEXEPath.Text = .MameEXE
                txtMameXMLPath.Text = .MameXML
                chkVersionXML.Checked = .IncludeXML
                txtImages.Text = .ScreenShotDir
                txtImagePrepend.Text = .SnapPrepend
                chkImagePrepend.Checked = .IncludeSnapPrepend
                txtImageAppend.Text = .SnapAppend
                chkImageAppend.Checked = .IncludeSnapAppend
                cmbImageExtension.Text = .SnapExt
                txtHistoryDATPath.Text = .HistoryDAT
                chkHistoryDAT.Checked = .IncludeHistory
                txtMameInfoPath.Text = .MameInfoDAT
                chkIncludeMameInfo.Checked = .IncludeMameInfo
                txtVideoDir.Text = .VideoDir
                chkVideoDir.Checked = .IncludeVideo
                cmbVideoExt.Text = .VideoExt
                txtRomdir.Text = .ROMDir
                chkROMDir.Checked = .IncludeROM
                cmbROMExt.Text = .RomExt
                txtFavouritesPath.Text = .FavouritesINI
                chkIncludeFavourites.Checked = .IncludeFavourite
                txtRatingPath.Text = .RatingINI
                chkIncludeRating.Checked = .IncludeRating
                txtMarqueeDir.Text = .MarqueeDir
                chkIncludeMarquee.Checked = .IncludeMarquee
                txtGenereINIPath.Text = .GenreINI
                chkIncludeGenre.Checked = .IncludeGenre
                chkAlsoRemoveINI.Checked = .IncludeHiddenINI
                txtHiddenGames.Text = .HidenINI
                chkHideCategories.Checked = .IncludeHiddenCat
                txtHideCategories.Text = .HiddenCat
                chkHideLessThan.Checked = .IncludeRatingHiddenGames
                cmbHideLessThanNumber.Text = .RatingHiddenAmount
                chkHideBios.Checked = .IncludeHideBIOS
                chkFavGreaterThan.Checked = .IncludeFavGamesRating
                cmbFavGreaterThanNumber.Text = .RatingFavAmount
                chkIncludeEmulationStatusInDesc.Checked = .IncludeEmuStatusInDesc
                chkAlsoRemoveDriver.Checked = .IncludeHiddenDriverList
                txtHiddenDrivers.Text = .HiddenDriverList
                txtFakeClonesDir.Text = .MoveFakeClonesDir
                txtFakeZipDir.Text = .CreateFakeZipDir
                chkCreateFakeZip.Checked = .IncludeCreateFakeZip
                chkMoveFakeClones.Checked = .IncludeMoveFakeClones
                chkDontHideFavGames.Checked = .DontHideFavList
                chkHistoryFirst.Checked = .ShowHistoryFirst
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function WriteSettings() As Boolean
        Try
            With My.Settings
                .MameEXE = txtMameEXEPath.Text
                .MameXML = txtMameXMLPath.Text
                .IncludeXML = chkVersionXML.Checked
                .ScreenShotDir = txtImages.Text
                .SnapPrepend = txtImagePrepend.Text
                .IncludeSnapPrepend = chkImagePrepend.Checked
                .SnapAppend = txtImageAppend.Text
                .IncludeSnapAppend = chkImageAppend.Checked
                .SnapExt = cmbImageExtension.Text
                .HistoryDAT = txtHistoryDATPath.Text
                .IncludeHistory = chkHistoryDAT.Checked
                .MameInfoDAT = txtMameInfoPath.Text
                .IncludeMameInfo = chkIncludeMameInfo.Checked
                .VideoDir = txtVideoDir.Text
                .IncludeVideo = chkVideoDir.Checked
                .VideoExt = cmbVideoExt.Text
                .ROMDir = txtRomdir.Text
                .IncludeROM = chkROMDir.Checked
                .RomExt = cmbROMExt.Text
                .FavouritesINI = txtFavouritesPath.Text
                .IncludeFavourite = chkIncludeFavourites.Checked
                .RatingINI = txtRatingPath.Text
                .IncludeRating = chkIncludeRating.Checked
                .MarqueeDir = txtMarqueeDir.Text
                .IncludeMarquee = chkIncludeMarquee.Checked
                .GenreINI = txtGenereINIPath.Text
                .IncludeGenre = chkIncludeGenre.Checked
                .IncludeHiddenINI = chkAlsoRemoveINI.Checked
                .HidenINI = txtHiddenGames.Text
                .IncludeHiddenCat = chkHideCategories.Checked
                .HiddenCat = txtHideCategories.Text
                .IncludeRatingHiddenGames = chkHideLessThan.Checked
                .RatingHiddenAmount = cmbHideLessThanNumber.Text
                .IncludeHideBIOS = chkHideBios.Checked
                .IncludeFavGamesRating = chkFavGreaterThan.Checked
                .RatingFavAmount = cmbFavGreaterThanNumber.Text
                .IncludeEmuStatusInDesc = chkIncludeEmulationStatusInDesc.Checked
                .IncludeHiddenDriverList = chkAlsoRemoveDriver.Checked
                .HiddenDriverList = txtHiddenDrivers.Text
                .MoveFakeClonesDir = txtFakeClonesDir.Text
                .CreateFakeZipDir = txtFakeZipDir.Text
                .IncludeCreateFakeZip = chkCreateFakeZip.Checked
                .IncludeMoveFakeClones = chkMoveFakeClones.Checked
                .DontHideFavList = chkDontHideFavGames.Checked
                .ShowHistoryFirst = chkHistoryFirst.Checked
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function SetUpScreen() As Boolean
        Try
            Me.Text = "Create ES gamelist.xml  v" + My.Application.Info.Version.ToString
            Me.Width = 764

            ReadSettings()

            AddTooltips()

            txtFavouritesPath.Enabled = chkIncludeFavourites.Checked
            txtRatingPath.Enabled = chkIncludeRating.Checked
            txtGenereINIPath.Enabled = chkIncludeGenre.Checked
            txtMarqueeDir.Enabled = chkIncludeMarquee.Checked
            txtMameInfoPath.Enabled = chkIncludeMameInfo.Checked
            txtHistoryDATPath.Enabled = chkHistoryDAT.Checked
            txtRomdir.Enabled = chkROMDir.Checked
            txtVideoDir.Enabled = chkVideoDir.Checked
            txtImagePrepend.Enabled = chkImagePrepend.Checked
            txtImageAppend.Enabled = chkImageAppend.Checked
            txtFakeZipDir.Enabled = chkCreateFakeZip.Checked
            txtFakeClonesDir.Enabled = chkMoveFakeClones.Checked
            cmbFavGreaterThanNumber.Enabled = chkFavGreaterThan.Checked
            cmbHideLessThanNumber.Enabled = chkHideLessThan.Checked
            txtHideCategories.Enabled = chkHideCategories.Checked
            txtHiddenGames.Enabled = chkAlsoRemoveINI.Checked
            txtHiddenDrivers.Enabled = chkAlsoRemoveDriver.Checked

            Me.ValidateChildren() 'Triggers validation for all text boxes, etc on the form

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetUpScreen()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        WriteSettings()
    End Sub

    Private Sub btnCreateMameXML_Click(sender As Object, e As EventArgs) Handles btnCreateMameXML.Click
        Dim res As DialogResult
        'TODO: add custom dialog form for software list creation
        res = MessageBox.Show("Click 'YES' to create a standard MAME -listinfo list" + vbCrLf + " or" + vbCrLf + "Click 'NO' to create a MAME -listsoftware <system_list_name> list", "Select MAME XML Creation Options", MessageBoxButtons.YesNoCancel)
        If res = vbYes Then
            If MessageBox.Show("Ready to create XML from MAME?", "Read MAME -listinfo", MessageBoxButtons.YesNo) = vbYes Then
                Dim m As New CreateListInfoXMLfromMAME
                m.MAME_EXE_Path = txtMameEXEPath.Text
                m.MAME_XML_Path = txtMameXMLPath.Text
                Dim i As Integer = m.GenerateXML
                If i = 0 Then
                    MessageBox.Show("Successfully created")
                Else
                    MessageBox.Show("Error: " + CStr(i))
                End If
            End If
        Else
            If res = DialogResult.No Then
                Dim res2 As String = InputBox("Please enter the softwarelist to create", "Create SoftwareList. Remember to check 'Load Softwarelist' when importing", "neogeo")
                If res2 <> "" Then
                    If MessageBox.Show("Ready to create softwarelist XML from MAME for system: " + res2 + " ?", "Read MAME -listsoftware " + res2, MessageBoxButtons.YesNo) = vbYes Then
                        Dim m As New CreateListInfoXMLfromMAME
                        m.CMDArguments = "-listsoftware " + res2
                        m.MAME_EXE_Path = txtMameEXEPath.Text
                        m.MAME_XML_Path = txtMameXMLPath.Text
                        Dim i As Integer = m.GenerateXML
                        If i = 0 Then
                            MessageBox.Show("Successfully created")
                        Else
                            MessageBox.Show("Error: " + CStr(i))
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub BtnMameXMLPath_Click(sender As Object, e As EventArgs) Handles btnMameXMLPath.Click
        If txtMameXMLPath.Text.Trim = "" Then
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                txtMameXMLPath.Text = SaveFileDialog1.FileName
            End If
        Else
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                txtMameXMLPath.Text = OpenFileDialog1.FileName
            End If
        End If
    End Sub

    Private Sub BtnMameEXEPath_Click(sender As Object, e As EventArgs) Handles btnMameEXEPath.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtMameEXEPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnCreateGameList_Click(sender As Object, e As EventArgs) Handles btnCreateGameList.Click
        If MessageBox.Show("Create EmulationStation gamelist.xml from MAME -listinfo .xml?", "Create XML File?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim g As New CreateGameList_XML

            g.MAME_XML_Path = txtMameXMLPath.Text

            g.GAMELIST_XML_Path = System.IO.Path.GetDirectoryName(txtMameXMLPath.Text) + "\gamelist.xml"

            g.ImagePath = txtImages.Text.Trim                       'Set the path to the Snapshot files. Use images from here. Images in the format <ROMANAME>.png

            If chkHistoryDAT.Checked Then
                g.HistoryDAT_Path = txtHistoryDATPath.Text.Trim     'Set the History.dat file
            End If

            If chkIncludeMameInfo.Checked Then
                g.MameInfoDAT_Path = txtMameInfoPath.Text           'Set the MameInfo.dat file
            End If

            g.ImageExtension = cmbImageExtension.Text.Trim          'Set the Snapshot and Marquee image extension

            If chkImageAppend.Checked Then
                g.ImageAppend = txtImageAppend.Text.Trim            'Append some text to the image name. useful if you have an already scraped image collection, and the image names are <ROMNAME>-image.png etc
            End If

            If chkImagePrepend.Checked Then
                g.ImagePrepend = txtImagePrepend.Text.Trim          'Prepend some text to the image name.
            End If

            If chkVideoDir.Checked Then
                g.VideoPath = txtVideoDir.Text.Trim                 'Set the Video Path.
            End If

            If chkROMDir.Checked Then
                g.ROMPath = txtRomdir.Text.Trim                     'Set the ROM file path. If set, only include games that exist in this directory, in gamename.xml
            End If

            If cmbROMExt.Text <> "" Then
                g.GameExt = cmbROMExt.Text                          'Set the rom extension. Usually .zip but can be .7z, etc
            End If

            If chkIncludeMarquee.Checked Then
                g.MarqueePath = txtMarqueeDir.Text                  'Set the path to the Marquee image files.  Use Marquee images from here. Images in the format <ROMANAME>.png
            End If

            If chkIncludeFavourites.Checked Then
                If IO.File.Exists(txtFavouritesPath.Text) Then
                    g.FavouritePath = txtFavouritesPath.Text        'If a folder.ini exists with list of games, use this as the favourites ini path.
                End If
            End If

            If chkIncludeGenre.Checked Then
                If IO.File.Exists(txtGenereINIPath.Text) Then
                    g.GenrePath = txtGenereINIPath.Text
                End If
            End If

            If chkIncludeRating.Checked Then
                If IO.File.Exists(txtRatingPath.Text) Then
                    g.RatingPath = txtRatingPath.Text
                    g.RatingScale = CInt(cmbScale.Text)
                End If
            End If

            If chkHideLessThan.Checked = True Then
                If IsNumeric(cmbHideLessThanNumber.Text) Then
                    g.HideRatedGamesWithScore = True
                    g.HiddenScore = CInt(cmbHideLessThanNumber.Text)
                End If
            End If

            If chkAlsoRemoveINI.Checked Then
                If IO.File.Exists(txtHiddenGames.Text) Then
                    g.HiddenListPath = txtHiddenGames.Text
                End If
            End If

            If chkHideBios.Checked Then
                g.HideBios = True
            Else
                g.HideBios = False
            End If

            If chkAlsoRemoveINI.Checked Then
                If IO.File.Exists(txtHiddenGames.Text) Then
                    g.HiddenListPath = txtHiddenGames.Text
                End If
            End If

            If chkAlsoRemoveDriver.Checked Then
                If txtHiddenDrivers.Text <> "" Then
                    g.HiddenDriverList = txtHiddenDrivers.Text
                End If
            End If

            If chkIncludeEmulationStatusInDesc.Checked Then
                g.IncludeEmuStatus = True
            Else
                g.IncludeEmuStatus = False
            End If

            If chkHideCategories.Checked Then
                If txtHideCategories.Text <> "" Then
                    g.RemoveAdditionalCategories = txtHideCategories.Text
                End If
            End If

            If chkFavGreaterThan.Checked Then
                If IsNumeric(cmbFavGreaterThanNumber.Text) Then
                    g.FavRatedGamesWithScore = True
                    g.FavScore = CInt(cmbFavGreaterThanNumber.Text)
                End If
            End If

            g.PrettyXML = chkPrettyXML.Checked

            If chkIsSoftwareList.Checked Then
                g.IsSoftwareList = True
            Else
                g.IsSoftwareList = False
            End If

            If chkCreateFakeZip.Checked Then
                g.CreateEmptyZip = txtFakeZipDir.Text
                If chkMoveFakeClones.Checked Then
                    If Not IO.Directory.Exists(IO.Path.Combine(txtFakeZipDir.Text, txtFakeClonesDir.Text)) Then
                        Try
                            IO.Directory.CreateDirectory(IO.Path.Combine(txtFakeZipDir.Text, txtFakeClonesDir.Text))
                        Catch ex As Exception
                        End Try
                    End If
                    g.MoveEmptyZipClonesDir = txtFakeClonesDir.Text
                End If
            End If

            If chkScanSubFolders.Checked Then
                g.SearchRomSubDirs = True
            End If

            If chkDontHideFavGames.Checked = True Then
                g.DontHideFavGame = True
            Else
                g.DontHideFavGame = False
            End If

            g.ShowHistoryDescFirst = chkHistoryFirst.Checked

            g.ShowProgress = True

            Me.Enabled = False

            Dim i As Integer = g.CreateGAMELIST_XML()   'Call the function

            Me.Enabled = True

            If i = 0 Then
                MessageBox.Show("Successfully created" + vbCrLf + vbCrLf + g.ResultString)
            Else
                MessageBox.Show("Error: " + CStr(i) + vbCrLf + g.ResultString)
            End If
        End If
    End Sub

    Private Sub BtnImageDir_Click(sender As Object, e As EventArgs) Handles btnImageDir.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtImages.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BtnHistoryPath_Click(sender As Object, e As EventArgs) Handles btnHistoryPath.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtHistoryDATPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnVideoDir_Click(sender As Object, e As EventArgs) Handles btnVideoDir.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtVideoDir.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BtnROMDir_Click(sender As Object, e As EventArgs) Handles btnROMDir.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtRomdir.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub llabelOpenRomDir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llabelOpenRomDir.LinkClicked
        If txtRomdir.Text <> "" Then
            System.Diagnostics.Process.Start("explorer.exe", "/n,/e," + txtRomdir.Text)
        End If
    End Sub

    Private Sub btnMameInfo_Click(sender As Object, e As EventArgs) Handles btnMameInfo.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtMameInfoPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnMarqueeDir_Click(sender As Object, e As EventArgs) Handles btnMarqueeDir.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtMarqueeDir.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnGenrePath_Click(sender As Object, e As EventArgs) Handles btnGenrePath.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtGenereINIPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnFavPath_Click(sender As Object, e As EventArgs) Handles btnFavPath.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtFavouritesPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnRatingPath_Click(sender As Object, e As EventArgs) Handles btnRatingPath.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtRatingPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub llGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llGithub.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/M1kerochip/CreateGameListFromMameXML")
    End Sub

    Private Sub llOpenXMLFolder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llOpenXMLFolder.LinkClicked
        If txtMameXMLPath.Text <> "" Then
            System.Diagnostics.Process.Start("explorer.exe", "/n,/e," + IO.Path.GetDirectoryName(txtMameXMLPath.Text))
        End If
    End Sub

    Private Sub btnWideForm_Click(sender As Object, e As EventArgs) Handles btnWideForm.Click
        If btnWideForm.Text = ">" Then
            btnWideForm.Text = "<"
            Me.Width = 1136
        Else
            btnWideForm.Text = ">"
            Me.Width = 764
        End If
    End Sub

    Private Sub btnHiddenGamesPath_Click(sender As Object, e As EventArgs) Handles btnHiddenGamesPath.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtHiddenGames.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnSetFakeZipDir_Click(sender As Object, e As EventArgs) Handles btnSetFakeZipDir.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtFakeZipDir.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub chkIncludeFavourites_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeFavourites.CheckedChanged
        txtFavouritesPath.Enabled = chkIncludeFavourites.Checked
    End Sub

    Private Sub chkIncludeRating_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeRating.CheckedChanged
        txtRatingPath.Enabled = chkIncludeRating.Checked
    End Sub

    Private Sub chkIncludeGenre_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeGenre.CheckedChanged
        txtGenereINIPath.Enabled = chkIncludeGenre.Checked
    End Sub

    Private Sub chkIncludeMarquee_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeMarquee.CheckedChanged
        txtMarqueeDir.Enabled = chkIncludeMarquee.Checked
    End Sub

    Private Sub chkIncludeMameInfo_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeMameInfo.CheckedChanged
        txtMameInfoPath.Enabled = chkIncludeMameInfo.Checked
    End Sub

    Private Sub chkHistoryDAT_CheckedChanged(sender As Object, e As EventArgs) Handles chkHistoryDAT.CheckedChanged
        txtHistoryDATPath.Enabled = chkHistoryDAT.Checked
    End Sub

    Private Sub chkROMDir_CheckedChanged(sender As Object, e As EventArgs) Handles chkROMDir.CheckedChanged
        txtRomdir.Enabled = chkROMDir.Checked
    End Sub

    Private Sub chkVideoDir_CheckedChanged(sender As Object, e As EventArgs) Handles chkVideoDir.CheckedChanged
        txtVideoDir.Enabled = chkVideoDir.Checked
    End Sub

    Private Sub chkImagePrepend_CheckedChanged(sender As Object, e As EventArgs) Handles chkImagePrepend.CheckedChanged
        txtImagePrepend.Enabled = chkImagePrepend.Checked
    End Sub

    Private Sub chkImageAppend_CheckedChanged(sender As Object, e As EventArgs) Handles chkImageAppend.CheckedChanged
        txtImageAppend.Enabled = chkImageAppend.Checked
    End Sub

    Private Sub chkCreateFakeZip_CheckedChanged(sender As Object, e As EventArgs) Handles chkCreateFakeZip.CheckedChanged
        txtFakeZipDir.Enabled = chkCreateFakeZip.Checked
    End Sub

    Private Sub chkMoveFakeClones_CheckedChanged(sender As Object, e As EventArgs) Handles chkMoveFakeClones.CheckedChanged
        txtFakeClonesDir.Enabled = chkMoveFakeClones.Checked
    End Sub

    Private Sub chkFavGreaterThan_CheckedChanged(sender As Object, e As EventArgs) Handles chkFavGreaterThan.CheckedChanged
        cmbFavGreaterThanNumber.Enabled = chkFavGreaterThan.Checked
    End Sub

    Private Sub chkHideLessThan_CheckedChanged(sender As Object, e As EventArgs) Handles chkHideLessThan.CheckedChanged
        cmbHideLessThanNumber.Enabled = chkHideLessThan.Checked
    End Sub

    Private Sub chkHideCategories_CheckedChanged(sender As Object, e As EventArgs) Handles chkHideCategories.CheckedChanged
        txtHideCategories.Enabled = chkHideCategories.Checked
    End Sub

    Private Sub chkAlsoRemoveINI_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlsoRemoveINI.CheckedChanged
        txtHiddenGames.Enabled = chkAlsoRemoveINI.Checked
    End Sub

    Private Sub chkAlsoRemoveDriver_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlsoRemoveDriver.CheckedChanged
        txtHiddenDrivers.Enabled = chkAlsoRemoveDriver.Checked
    End Sub

    'TODO: Add Visual Error Checking for rest of form

    Private Sub txtMameEXEPath_Validating(sender As Object, e As CancelEventArgs) Handles txtMameEXEPath.Validating
        If Not IO.File.Exists(txtMameEXEPath.Text) Then
            ErrorProviderMain.SetError(txtMameEXEPath, "Unable to find MAME .exe file")
        Else
            ErrorProviderMain.SetError(txtMameEXEPath, "")
        End If
    End Sub

    Private Sub txtImages_Validating(sender As Object, e As CancelEventArgs) Handles txtImages.Validating
        If Not IO.Directory.Exists(txtImages.Text) Then
            ErrorProviderMain.SetError(txtImages, "Image file directory doesn't exist")
        Else
            ErrorProviderMain.SetError(txtImages, "")
        End If
    End Sub

    Private Sub txtRomdir_Validating(sender As Object, e As CancelEventArgs) Handles txtRomdir.Validating
        If Not IO.Directory.Exists(txtRomdir.Text) Then
            ErrorProviderMain.SetError(txtRomdir, "ROM file directory doesn't exist")
        Else
            ErrorProviderMain.SetError(txtRomdir, "")
        End If
    End Sub

    Private Sub txtVideoDir_Validating(sender As Object, e As CancelEventArgs) Handles txtVideoDir.Validating
        If Not IO.Directory.Exists(txtVideoDir.Text) Then
            ErrorProviderMain.SetError(txtVideoDir, "Video file directory doesn't exist")
        Else
            ErrorProviderMain.SetError(txtVideoDir, "")
        End If
    End Sub

    Private Sub cmbROMExt_Validating(sender As Object, e As CancelEventArgs) Handles cmbROMExt.Validating
        If Not cmbROMExt.Text.Contains(".") Then
            ErrorProviderMain.SetError(cmbROMExt, "Rom file extension must contain a period")
        Else
            ErrorProviderMain.SetError(cmbROMExt, "")
        End If
    End Sub

    Private Sub cmbVideoExt_Validating(sender As Object, e As CancelEventArgs) Handles cmbVideoExt.Validating
        If cmbVideoExt.Enabled = True Then
            If Not cmbVideoExt.Text.Contains(".") Then
                ErrorProviderMain.SetError(cmbVideoExt, "Video file extension must contain a period")
            Else
                ErrorProviderMain.SetError(cmbVideoExt, "")
            End If
        End If
    End Sub

    Private Sub txtMameInfoPath_Validating(sender As Object, e As CancelEventArgs) Handles txtMameInfoPath.Validating
        If txtMameInfoPath.Enabled = True Then
            If Not IO.File.Exists(txtMameInfoPath.Text) Then
                ErrorProviderMain.SetError(txtMameInfoPath, "Mame Info DAT file doesn't exist")
            Else
                ErrorProviderMain.SetError(txtMameInfoPath, "")
            End If
        End If
    End Sub

    Private Sub txtMameXMLPath_Validating(sender As Object, e As CancelEventArgs) Handles txtMameXMLPath.Validating
        If Not IO.File.Exists(txtMameXMLPath.Text) Then
            ErrorProviderMain.SetError(txtMameXMLPath, "Mame XML file doesn't exist. Please create it, or select the an existing file.")
        Else
            ErrorProviderMain.SetError(txtMameXMLPath, "")
        End If
    End Sub

    Private Sub txtMarqueeDir_Validating(sender As Object, e As CancelEventArgs) Handles txtMarqueeDir.Validating
        If Not IO.Directory.Exists(txtMarqueeDir.Text) Then
            ErrorProviderMain.SetError(txtMarqueeDir, "Marquee file directory doesn't exist")
        Else
            ErrorProviderMain.SetError(txtMarqueeDir, "")
        End If
    End Sub

    Private Sub txtHistoryDATPath_Validating(sender As Object, e As CancelEventArgs) Handles txtHistoryDATPath.Validating
        If txtHistoryDATPath.Enabled = True Then
            If Not IO.File.Exists(txtHistoryDATPath.Text) Then
                ErrorProviderMain.SetError(txtHistoryDATPath, "Mame History DAT file doesn't exist")
            Else
                ErrorProviderMain.SetError(txtHistoryDATPath, "")
            End If
        End If
    End Sub

    Private Sub txtGenereINIPath_Validating(sender As Object, e As CancelEventArgs) Handles txtGenereINIPath.Validating
        If txtGenereINIPath.Enabled = True Then
            If Not IO.File.Exists(txtGenereINIPath.Text) Then
                ErrorProviderMain.SetError(txtGenereINIPath, "Mame genre folder.ini file doesn't exist")
            Else
                ErrorProviderMain.SetError(txtGenereINIPath, "")
            End If
        End If
    End Sub

    Private Sub txtRatingPath_Validating(sender As Object, e As CancelEventArgs) Handles txtRatingPath.Validating
        If txtRatingPath.Enabled = True Then
            If Not IO.File.Exists(txtRatingPath.Text) Then
                ErrorProviderMain.SetError(txtRatingPath, "Mame rating folder.ini file doesn't exist")
            Else
                ErrorProviderMain.SetError(txtRatingPath, "")
            End If
        End If
    End Sub

    Private Sub txtFavouritesPath_Validating(sender As Object, e As CancelEventArgs) Handles txtFavouritesPath.Validating
        If txtFavouritesPath.Enabled = True Then
            If Not IO.File.Exists(txtFavouritesPath.Text) Then
                ErrorProviderMain.SetError(txtFavouritesPath, "Mame favourites folder.ini file doesn't exist")
            Else
                ErrorProviderMain.SetError(txtFavouritesPath, "")
            End If
        End If
    End Sub

    Private Sub txtHiddenGames_Validating(sender As Object, e As CancelEventArgs) Handles txtHiddenGames.Validating
        If txtHiddenGames.Enabled = True Then
            If Not IO.File.Exists(txtHiddenGames.Text) Then
                ErrorProviderMain.SetError(txtHiddenGames, "Mame hidden games folder.ini file doesn't exist")
            Else
                ErrorProviderMain.SetError(txtHiddenGames, "")
            End If
        End If
    End Sub

    Private Sub btnBackGround_Click(sender As Object, e As EventArgs) Handles btnBackGround.Click

    End Sub
End Class
