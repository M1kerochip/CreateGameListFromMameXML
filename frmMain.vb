Imports System.ComponentModel

Public Class frmMain
    Function ReadSettings() As Boolean
        txtMameEXEPath.Text = My.Settings.MameEXE
        txtMameXMLPath.Text = My.Settings.MameXML
        chkVersionXML.Checked = My.Settings.IncludeXML
        txtImages.Text = My.Settings.ScreenShotDir
        txtImagePrepend.Text = My.Settings.SnapPrepend
        chkImagePrepend.Checked = My.Settings.IncludeSnapPrepend
        txtImageAppend.Text = My.Settings.SnapAppend
        chkImageAppend.Checked = My.Settings.IncludeSnapAppend
        cmbImageExtension.Text = My.Settings.SnapExt
        txtHistoryDATPath.Text = My.Settings.HistoryDAT
        chkHistoryDAT.Checked = My.Settings.IncludeHistory
        txtMameInfoPath.Text = My.Settings.MameInfoDAT
        chkIncludeMameInfo.Checked = My.Settings.IncludeMameInfo
        txtVideoDir.Text = My.Settings.VideoDir
        chkVideoDir.Checked = My.Settings.IncludeVideo
        cmbVideoExt.Text = My.Settings.VideoExt
        txtRomdir.Text = My.Settings.ROMDir
        chkROMDir.Checked = My.Settings.IncludeROM
        cmbROMExt.Text = My.Settings.RomExt
        txtFavouritesPath.Text = My.Settings.FavouritesINI
        chkIncludeFavourites.Checked = My.Settings.IncludeFavourite
        txtRatingPath.Text = My.Settings.RatingINI
        chkIncludeRating.Checked = My.Settings.IncludeRating
        txtMarqueeDir.Text = My.Settings.MarqueeDir
        chkIncludeMarquee.Checked = My.Settings.IncludeMarquee
        txtGenereINIPath.Text = My.Settings.GenreINI
        chkIncludeGenre.Checked = My.Settings.IncludeGenre
        Return True
    End Function

    Function WriteSettings() As Boolean
        My.Settings.MameEXE = txtMameEXEPath.Text
        My.Settings.MameXML = txtMameXMLPath.Text
        My.Settings.IncludeXML = chkVersionXML.Checked
        My.Settings.ScreenShotDir = txtImages.Text
        My.Settings.SnapPrepend = txtImagePrepend.Text
        My.Settings.IncludeSnapPrepend = chkImagePrepend.Checked
        My.Settings.SnapAppend = txtImageAppend.Text
        My.Settings.IncludeSnapAppend = chkImageAppend.Checked
        My.Settings.SnapExt = cmbImageExtension.Text
        My.Settings.HistoryDAT = txtHistoryDATPath.Text
        My.Settings.IncludeHistory = chkHistoryDAT.Checked
        My.Settings.MameInfoDAT = txtMameInfoPath.Text
        My.Settings.IncludeMameInfo = chkIncludeMameInfo.Checked
        My.Settings.VideoDir = txtVideoDir.Text
        My.Settings.IncludeVideo = chkVideoDir.Checked
        My.Settings.VideoExt = cmbVideoExt.Text
        My.Settings.ROMDir = txtRomdir.Text
        My.Settings.IncludeROM = chkROMDir.Checked
        My.Settings.RomExt = cmbROMExt.Text
        My.Settings.FavouritesINI = txtFavouritesPath.Text
        My.Settings.IncludeFavourite = chkIncludeFavourites.Checked
        My.Settings.RatingINI = txtRatingPath.Text
        My.Settings.IncludeRating = chkIncludeRating.Checked
        My.Settings.MarqueeDir = txtMarqueeDir.Text
        My.Settings.IncludeMarquee = chkIncludeMarquee.Checked
        My.Settings.GenreINI = txtGenereINIPath.Text
        My.Settings.IncludeGenre = chkIncludeGenre.Checked
        Return True
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadSettings()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        WriteSettings()
    End Sub

    Private Sub btnCreateMameXML_Click(sender As Object, e As EventArgs) Handles btnCreateMameXML.Click
        If MessageBox.Show("Create XML from MAME?", "Read MAME -listinfo", MessageBoxButtons.YesNo) = vbYes Then
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

            g.ImagePath = txtImages.Text.Trim

            If chkHistoryDAT.Checked Then
                g.HistoryDAT_Path = txtHistoryDATPath.Text.Trim
            End If

            If chkIncludeMameInfo.Checked Then
                g.MameInfoDAT_Path = txtMameInfoPath.Text
            End If

            g.ImageExtension = cmbImageExtension.Text.Trim

            If chkImageAppend.Checked Then
                g.ImageAppend = txtImageAppend.Text.Trim
            End If

            If chkImagePrepend.Checked Then
                g.ImagePrepend = txtImagePrepend.Text.Trim
            End If

            If chkVideoDir.Checked Then
                g.VideoPath = txtVideoDir.Text.Trim
            End If

            If chkROMDir.Checked Then
                g.ROMPath = txtRomdir.Text.Trim
            End If

            If cmbROMExt.Text <> "" Then
                g.GameExt = cmbROMExt.Text
            End If

            If chkIncludeMarquee.Checked Then
                g.MarqueePath = txtMarqueeDir.Text
            End If

            g.ShowProgress = True

            Dim i As Integer = g.CreateGAMELIST_XML()   'Call the function
            If i = 0 Then
                MessageBox.Show("Successfully created")
            Else
                MessageBox.Show("Error: " + CStr(i))
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

End Class
