<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnMameXMLPath = New System.Windows.Forms.Button()
        Me.btnMameEXEPath = New System.Windows.Forms.Button()
        Me.txtMameXMLPath = New System.Windows.Forms.TextBox()
        Me.txtMameEXEPath = New System.Windows.Forms.TextBox()
        Me.txtImages = New System.Windows.Forms.TextBox()
        Me.txtImagePrepend = New System.Windows.Forms.TextBox()
        Me.txtImageAppend = New System.Windows.Forms.TextBox()
        Me.chkVersionXML = New System.Windows.Forms.CheckBox()
        Me.lblImagesa = New System.Windows.Forms.Label()
        Me.lblMAME_EXE = New System.Windows.Forms.Label()
        Me.btnCreateGameList = New System.Windows.Forms.Button()
        Me.btnCreateMameXML = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnImageDir = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblImageExtension = New System.Windows.Forms.Label()
        Me.cmbImageExtension = New System.Windows.Forms.ComboBox()
        Me.chkImagePrepend = New System.Windows.Forms.CheckBox()
        Me.chkImageAppend = New System.Windows.Forms.CheckBox()
        Me.chkHistoryDAT = New System.Windows.Forms.CheckBox()
        Me.txtHistoryDATPath = New System.Windows.Forms.TextBox()
        Me.btnHistoryPath = New System.Windows.Forms.Button()
        Me.txtRomdir = New System.Windows.Forms.TextBox()
        Me.btnROMDir = New System.Windows.Forms.Button()
        Me.chkROMDir = New System.Windows.Forms.CheckBox()
        Me.txtVideoDir = New System.Windows.Forms.TextBox()
        Me.btnVideoDir = New System.Windows.Forms.Button()
        Me.chkVideoDir = New System.Windows.Forms.CheckBox()
        Me.cmbROMExt = New System.Windows.Forms.ComboBox()
        Me.lblRomExt = New System.Windows.Forms.Label()
        Me.llabelOpenRomDir = New System.Windows.Forms.LinkLabel()
        Me.txtMameInfoPath = New System.Windows.Forms.TextBox()
        Me.btnMameInfo = New System.Windows.Forms.Button()
        Me.chkIncludeMameInfo = New System.Windows.Forms.CheckBox()
        Me.chkIncludeFavourites = New System.Windows.Forms.CheckBox()
        Me.txtFavouritesPath = New System.Windows.Forms.TextBox()
        Me.btnFavPath = New System.Windows.Forms.Button()
        Me.chkIncludeRating = New System.Windows.Forms.CheckBox()
        Me.txtRatingPath = New System.Windows.Forms.TextBox()
        Me.btnRatingPath = New System.Windows.Forms.Button()
        Me.chkIncludeMarquee = New System.Windows.Forms.CheckBox()
        Me.txtMarqueeDir = New System.Windows.Forms.TextBox()
        Me.btnMarqueeDir = New System.Windows.Forms.Button()
        Me.chkIncludeGenre = New System.Windows.Forms.CheckBox()
        Me.txtGenereINIPath = New System.Windows.Forms.TextBox()
        Me.btnGenrePath = New System.Windows.Forms.Button()
        Me.lblVideoExtension = New System.Windows.Forms.Label()
        Me.cmbVideoExt = New System.Windows.Forms.ComboBox()
        Me.cmbScale = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkPrettyXML = New System.Windows.Forms.CheckBox()
        Me.llGithub = New System.Windows.Forms.LinkLabel()
        Me.llOpenXMLFolder = New System.Windows.Forms.LinkLabel()
        Me.cmbHideLessThanNumber = New System.Windows.Forms.ComboBox()
        Me.chkHideLessThan = New System.Windows.Forms.CheckBox()
        Me.lblHideLess = New System.Windows.Forms.Label()
        Me.chkAlsoRemoveINI = New System.Windows.Forms.CheckBox()
        Me.txtHiddenGames = New System.Windows.Forms.TextBox()
        Me.btnHiddenGamesPath = New System.Windows.Forms.Button()
        Me.chkHideBios = New System.Windows.Forms.CheckBox()
        Me.btnWideForm = New System.Windows.Forms.Button()
        Me.chkIncludeEmulationStatusInDesc = New System.Windows.Forms.CheckBox()
        Me.lblFavouriteGamesAndAbove = New System.Windows.Forms.Label()
        Me.chkFavGreaterThan = New System.Windows.Forms.CheckBox()
        Me.cmbFavGreaterThanNumber = New System.Windows.Forms.ComboBox()
        Me.chkHideCategories = New System.Windows.Forms.CheckBox()
        Me.txtHideCategories = New System.Windows.Forms.TextBox()
        Me.chkAlsoRemoveDriver = New System.Windows.Forms.CheckBox()
        Me.txtHiddenDrivers = New System.Windows.Forms.TextBox()
        Me.chkIsSoftwareList = New System.Windows.Forms.CheckBox()
        Me.txtFakeZipDir = New System.Windows.Forms.TextBox()
        Me.chkCreateFakeZip = New System.Windows.Forms.CheckBox()
        Me.chkMoveFakeClones = New System.Windows.Forms.CheckBox()
        Me.txtFakeClonesDir = New System.Windows.Forms.TextBox()
        Me.btnSetFakeZipDir = New System.Windows.Forms.Button()
        Me.lblClonesFolder = New System.Windows.Forms.Label()
        Me.ErrorProviderMain = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkScanSubFolders = New System.Windows.Forms.CheckBox()
        Me.chkDontHideFavGames = New System.Windows.Forms.CheckBox()
        Me.btnBackGround = New System.Windows.Forms.Button()
        Me.chkHistoryFirst = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorProviderMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMameXMLPath
        '
        Me.btnMameXMLPath.Location = New System.Drawing.Point(332, 90)
        Me.btnMameXMLPath.Name = "btnMameXMLPath"
        Me.btnMameXMLPath.Size = New System.Drawing.Size(24, 20)
        Me.btnMameXMLPath.TabIndex = 50
        Me.btnMameXMLPath.Text = "..."
        Me.btnMameXMLPath.UseVisualStyleBackColor = True
        '
        'btnMameEXEPath
        '
        Me.btnMameEXEPath.Location = New System.Drawing.Point(332, 36)
        Me.btnMameEXEPath.Name = "btnMameEXEPath"
        Me.btnMameEXEPath.Size = New System.Drawing.Size(24, 19)
        Me.btnMameEXEPath.TabIndex = 20
        Me.btnMameEXEPath.Text = "..."
        Me.btnMameEXEPath.UseVisualStyleBackColor = True
        '
        'txtMameXMLPath
        '
        Me.txtMameXMLPath.Location = New System.Drawing.Point(12, 90)
        Me.txtMameXMLPath.Name = "txtMameXMLPath"
        Me.txtMameXMLPath.Size = New System.Drawing.Size(322, 20)
        Me.txtMameXMLPath.TabIndex = 45
        '
        'txtMameEXEPath
        '
        Me.txtMameEXEPath.Location = New System.Drawing.Point(12, 36)
        Me.txtMameEXEPath.Name = "txtMameEXEPath"
        Me.txtMameEXEPath.Size = New System.Drawing.Size(322, 20)
        Me.txtMameEXEPath.TabIndex = 15
        '
        'txtImages
        '
        Me.txtImages.Location = New System.Drawing.Point(12, 145)
        Me.txtImages.Name = "txtImages"
        Me.txtImages.Size = New System.Drawing.Size(322, 20)
        Me.txtImages.TabIndex = 75
        '
        'txtImagePrepend
        '
        Me.txtImagePrepend.Location = New System.Drawing.Point(12, 200)
        Me.txtImagePrepend.Name = "txtImagePrepend"
        Me.txtImagePrepend.Size = New System.Drawing.Size(100, 20)
        Me.txtImagePrepend.TabIndex = 105
        '
        'txtImageAppend
        '
        Me.txtImageAppend.Location = New System.Drawing.Point(143, 200)
        Me.txtImageAppend.Name = "txtImageAppend"
        Me.txtImageAppend.Size = New System.Drawing.Size(100, 20)
        Me.txtImageAppend.TabIndex = 115
        Me.txtImageAppend.Text = "-image"
        '
        'chkVersionXML
        '
        Me.chkVersionXML.AutoSize = True
        Me.chkVersionXML.Checked = True
        Me.chkVersionXML.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVersionXML.Location = New System.Drawing.Point(12, 73)
        Me.chkVersionXML.Name = "chkVersionXML"
        Me.chkVersionXML.Size = New System.Drawing.Size(168, 17)
        Me.chkVersionXML.TabIndex = 40
        Me.chkVersionXML.Text = "version.xml (mame.exe -listxml)"
        Me.chkVersionXML.UseVisualStyleBackColor = True
        '
        'lblImagesa
        '
        Me.lblImagesa.AutoSize = True
        Me.lblImagesa.Location = New System.Drawing.Point(9, 129)
        Me.lblImagesa.Name = "lblImagesa"
        Me.lblImagesa.Size = New System.Drawing.Size(142, 13)
        Me.lblImagesa.TabIndex = 70
        Me.lblImagesa.Text = "Snapshot / Images Directory"
        '
        'lblMAME_EXE
        '
        Me.lblMAME_EXE.AutoSize = True
        Me.lblMAME_EXE.Location = New System.Drawing.Point(9, 19)
        Me.lblMAME_EXE.Name = "lblMAME_EXE"
        Me.lblMAME_EXE.Size = New System.Drawing.Size(139, 13)
        Me.lblMAME_EXE.TabIndex = 5
        Me.lblMAME_EXE.Text = "MAME.exe (For list creation)"
        '
        'btnCreateGameList
        '
        Me.btnCreateGameList.Location = New System.Drawing.Point(12, 415)
        Me.btnCreateGameList.Name = "btnCreateGameList"
        Me.btnCreateGameList.Size = New System.Drawing.Size(720, 45)
        Me.btnCreateGameList.TabIndex = 240
        Me.btnCreateGameList.Text = "Create Emulation Station gamelist.xml"
        Me.btnCreateGameList.UseVisualStyleBackColor = True
        '
        'btnCreateMameXML
        '
        Me.btnCreateMameXML.Location = New System.Drawing.Point(228, 9)
        Me.btnCreateMameXML.Name = "btnCreateMameXML"
        Me.btnCreateMameXML.Size = New System.Drawing.Size(106, 21)
        Me.btnCreateMameXML.TabIndex = 10
        Me.btnCreateMameXML.Text = "Create Mame List"
        Me.btnCreateMameXML.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnImageDir
        '
        Me.btnImageDir.Location = New System.Drawing.Point(332, 145)
        Me.btnImageDir.Name = "btnImageDir"
        Me.btnImageDir.Size = New System.Drawing.Size(24, 20)
        Me.btnImageDir.TabIndex = 80
        Me.btnImageDir.Text = "..."
        Me.btnImageDir.UseVisualStyleBackColor = True
        '
        'lblImageExtension
        '
        Me.lblImageExtension.AutoSize = True
        Me.lblImageExtension.Location = New System.Drawing.Point(264, 184)
        Me.lblImageExtension.Name = "lblImageExtension"
        Me.lblImageExtension.Size = New System.Drawing.Size(70, 13)
        Me.lblImageExtension.TabIndex = 120
        Me.lblImageExtension.Text = "Snapshot Ext"
        '
        'cmbImageExtension
        '
        Me.cmbImageExtension.FormattingEnabled = True
        Me.cmbImageExtension.Items.AddRange(New Object() {".png", ".jpg", ".jpeg"})
        Me.cmbImageExtension.Location = New System.Drawing.Point(274, 200)
        Me.cmbImageExtension.Name = "cmbImageExtension"
        Me.cmbImageExtension.Size = New System.Drawing.Size(60, 21)
        Me.cmbImageExtension.TabIndex = 125
        Me.cmbImageExtension.Text = ".png"
        '
        'chkImagePrepend
        '
        Me.chkImagePrepend.AutoSize = True
        Me.chkImagePrepend.Location = New System.Drawing.Point(12, 183)
        Me.chkImagePrepend.Name = "chkImagePrepend"
        Me.chkImagePrepend.Size = New System.Drawing.Size(125, 17)
        Me.chkImagePrepend.TabIndex = 100
        Me.chkImagePrepend.Text = "Snap Name Prepend"
        Me.chkImagePrepend.UseVisualStyleBackColor = True
        '
        'chkImageAppend
        '
        Me.chkImageAppend.AutoSize = True
        Me.chkImageAppend.Location = New System.Drawing.Point(143, 183)
        Me.chkImageAppend.Name = "chkImageAppend"
        Me.chkImageAppend.Size = New System.Drawing.Size(122, 17)
        Me.chkImageAppend.TabIndex = 110
        Me.chkImageAppend.Text = "Snap Name Append"
        Me.chkImageAppend.UseVisualStyleBackColor = True
        '
        'chkHistoryDAT
        '
        Me.chkHistoryDAT.AutoSize = True
        Me.chkHistoryDAT.Location = New System.Drawing.Point(388, 19)
        Me.chkHistoryDAT.Name = "chkHistoryDAT"
        Me.chkHistoryDAT.Size = New System.Drawing.Size(168, 17)
        Me.chkHistoryDAT.TabIndex = 25
        Me.chkHistoryDAT.Text = "Include History.dat description"
        Me.chkHistoryDAT.UseVisualStyleBackColor = True
        '
        'txtHistoryDATPath
        '
        Me.txtHistoryDATPath.Location = New System.Drawing.Point(388, 36)
        Me.txtHistoryDATPath.Name = "txtHistoryDATPath"
        Me.txtHistoryDATPath.Size = New System.Drawing.Size(322, 20)
        Me.txtHistoryDATPath.TabIndex = 30
        '
        'btnHistoryPath
        '
        Me.btnHistoryPath.Location = New System.Drawing.Point(708, 36)
        Me.btnHistoryPath.Name = "btnHistoryPath"
        Me.btnHistoryPath.Size = New System.Drawing.Size(24, 20)
        Me.btnHistoryPath.TabIndex = 35
        Me.btnHistoryPath.Text = "..."
        Me.btnHistoryPath.UseVisualStyleBackColor = True
        '
        'txtRomdir
        '
        Me.txtRomdir.Location = New System.Drawing.Point(12, 310)
        Me.txtRomdir.Name = "txtRomdir"
        Me.txtRomdir.Size = New System.Drawing.Size(322, 20)
        Me.txtRomdir.TabIndex = 190
        '
        'btnROMDir
        '
        Me.btnROMDir.Location = New System.Drawing.Point(332, 310)
        Me.btnROMDir.Name = "btnROMDir"
        Me.btnROMDir.Size = New System.Drawing.Size(24, 20)
        Me.btnROMDir.TabIndex = 195
        Me.btnROMDir.Text = "..."
        Me.btnROMDir.UseVisualStyleBackColor = True
        '
        'chkROMDir
        '
        Me.chkROMDir.AutoSize = True
        Me.chkROMDir.Location = New System.Drawing.Point(12, 293)
        Me.chkROMDir.Name = "chkROMDir"
        Me.chkROMDir.Size = New System.Drawing.Size(231, 17)
        Me.chkROMDir.TabIndex = 180
        Me.chkROMDir.Text = "ROM Directory (Only include files from here)"
        Me.chkROMDir.UseVisualStyleBackColor = True
        '
        'txtVideoDir
        '
        Me.txtVideoDir.Location = New System.Drawing.Point(12, 255)
        Me.txtVideoDir.Name = "txtVideoDir"
        Me.txtVideoDir.Size = New System.Drawing.Size(322, 20)
        Me.txtVideoDir.TabIndex = 150
        '
        'btnVideoDir
        '
        Me.btnVideoDir.Location = New System.Drawing.Point(332, 255)
        Me.btnVideoDir.Name = "btnVideoDir"
        Me.btnVideoDir.Size = New System.Drawing.Size(24, 20)
        Me.btnVideoDir.TabIndex = 155
        Me.btnVideoDir.Text = "..."
        Me.btnVideoDir.UseVisualStyleBackColor = True
        '
        'chkVideoDir
        '
        Me.chkVideoDir.AutoSize = True
        Me.chkVideoDir.Location = New System.Drawing.Point(12, 237)
        Me.chkVideoDir.Name = "chkVideoDir"
        Me.chkVideoDir.Size = New System.Drawing.Size(230, 17)
        Me.chkVideoDir.TabIndex = 145
        Me.chkVideoDir.Text = "Video Directory  (Add .mp4 vides from here)"
        Me.chkVideoDir.UseVisualStyleBackColor = True
        '
        'cmbROMExt
        '
        Me.cmbROMExt.FormattingEnabled = True
        Me.cmbROMExt.Items.AddRange(New Object() {".zip", ".7z"})
        Me.cmbROMExt.Location = New System.Drawing.Point(99, 346)
        Me.cmbROMExt.Name = "cmbROMExt"
        Me.cmbROMExt.Size = New System.Drawing.Size(60, 21)
        Me.cmbROMExt.TabIndex = 230
        Me.cmbROMExt.Text = ".zip"
        '
        'lblRomExt
        '
        Me.lblRomExt.AutoSize = True
        Me.lblRomExt.Location = New System.Drawing.Point(12, 349)
        Me.lblRomExt.Name = "lblRomExt"
        Me.lblRomExt.Size = New System.Drawing.Size(81, 13)
        Me.lblRomExt.TabIndex = 225
        Me.lblRomExt.Text = "ROM Extension"
        '
        'llabelOpenRomDir
        '
        Me.llabelOpenRomDir.AutoSize = True
        Me.llabelOpenRomDir.Location = New System.Drawing.Point(257, 294)
        Me.llabelOpenRomDir.Name = "llabelOpenRomDir"
        Me.llabelOpenRomDir.Size = New System.Drawing.Size(77, 13)
        Me.llabelOpenRomDir.TabIndex = 185
        Me.llabelOpenRomDir.TabStop = True
        Me.llabelOpenRomDir.Text = "Open ROM Dir"
        '
        'txtMameInfoPath
        '
        Me.txtMameInfoPath.Location = New System.Drawing.Point(388, 90)
        Me.txtMameInfoPath.Name = "txtMameInfoPath"
        Me.txtMameInfoPath.Size = New System.Drawing.Size(322, 20)
        Me.txtMameInfoPath.TabIndex = 60
        '
        'btnMameInfo
        '
        Me.btnMameInfo.Location = New System.Drawing.Point(708, 90)
        Me.btnMameInfo.Name = "btnMameInfo"
        Me.btnMameInfo.Size = New System.Drawing.Size(24, 20)
        Me.btnMameInfo.TabIndex = 6
        Me.btnMameInfo.Text = "..."
        Me.btnMameInfo.UseVisualStyleBackColor = True
        '
        'chkIncludeMameInfo
        '
        Me.chkIncludeMameInfo.AutoSize = True
        Me.chkIncludeMameInfo.Location = New System.Drawing.Point(388, 73)
        Me.chkIncludeMameInfo.Name = "chkIncludeMameInfo"
        Me.chkIncludeMameInfo.Size = New System.Drawing.Size(183, 17)
        Me.chkIncludeMameInfo.TabIndex = 55
        Me.chkIncludeMameInfo.Text = "Include MameInfo.dat description"
        Me.chkIncludeMameInfo.UseVisualStyleBackColor = True
        '
        'chkIncludeFavourites
        '
        Me.chkIncludeFavourites.AutoSize = True
        Me.chkIncludeFavourites.Location = New System.Drawing.Point(388, 293)
        Me.chkIncludeFavourites.Name = "chkIncludeFavourites"
        Me.chkIncludeFavourites.Size = New System.Drawing.Size(336, 17)
        Me.chkIncludeFavourites.TabIndex = 200
        Me.chkIncludeFavourites.Text = "Include Favourites list (Games in this list have favourite set to true)"
        Me.chkIncludeFavourites.UseVisualStyleBackColor = True
        '
        'txtFavouritesPath
        '
        Me.txtFavouritesPath.Location = New System.Drawing.Point(388, 310)
        Me.txtFavouritesPath.Name = "txtFavouritesPath"
        Me.txtFavouritesPath.Size = New System.Drawing.Size(322, 20)
        Me.txtFavouritesPath.TabIndex = 205
        '
        'btnFavPath
        '
        Me.btnFavPath.Location = New System.Drawing.Point(708, 310)
        Me.btnFavPath.Name = "btnFavPath"
        Me.btnFavPath.Size = New System.Drawing.Size(24, 20)
        Me.btnFavPath.TabIndex = 210
        Me.btnFavPath.Text = "..."
        Me.btnFavPath.UseVisualStyleBackColor = True
        '
        'chkIncludeRating
        '
        Me.chkIncludeRating.AutoSize = True
        Me.chkIncludeRating.Location = New System.Drawing.Point(388, 238)
        Me.chkIncludeRating.Name = "chkIncludeRating"
        Me.chkIncludeRating.Size = New System.Drawing.Size(248, 17)
        Me.chkIncludeRating.TabIndex = 160
        Me.chkIncludeRating.Text = "Include Rating (BestGame.ini / rankings.ini etc)"
        Me.chkIncludeRating.UseVisualStyleBackColor = True
        '
        'txtRatingPath
        '
        Me.txtRatingPath.Location = New System.Drawing.Point(388, 255)
        Me.txtRatingPath.Name = "txtRatingPath"
        Me.txtRatingPath.Size = New System.Drawing.Size(322, 20)
        Me.txtRatingPath.TabIndex = 170
        '
        'btnRatingPath
        '
        Me.btnRatingPath.Location = New System.Drawing.Point(708, 255)
        Me.btnRatingPath.Name = "btnRatingPath"
        Me.btnRatingPath.Size = New System.Drawing.Size(24, 20)
        Me.btnRatingPath.TabIndex = 175
        Me.btnRatingPath.Text = "..."
        Me.btnRatingPath.UseVisualStyleBackColor = True
        '
        'chkIncludeMarquee
        '
        Me.chkIncludeMarquee.AutoSize = True
        Me.chkIncludeMarquee.Location = New System.Drawing.Point(388, 128)
        Me.chkIncludeMarquee.Name = "chkIncludeMarquee"
        Me.chkIncludeMarquee.Size = New System.Drawing.Size(113, 17)
        Me.chkIncludeMarquee.TabIndex = 85
        Me.chkIncludeMarquee.Text = "Marquee Directory"
        Me.chkIncludeMarquee.UseVisualStyleBackColor = True
        '
        'txtMarqueeDir
        '
        Me.txtMarqueeDir.Location = New System.Drawing.Point(388, 145)
        Me.txtMarqueeDir.Name = "txtMarqueeDir"
        Me.txtMarqueeDir.Size = New System.Drawing.Size(322, 20)
        Me.txtMarqueeDir.TabIndex = 90
        '
        'btnMarqueeDir
        '
        Me.btnMarqueeDir.Location = New System.Drawing.Point(708, 145)
        Me.btnMarqueeDir.Name = "btnMarqueeDir"
        Me.btnMarqueeDir.Size = New System.Drawing.Size(24, 20)
        Me.btnMarqueeDir.TabIndex = 95
        Me.btnMarqueeDir.Text = "..."
        Me.btnMarqueeDir.UseVisualStyleBackColor = True
        '
        'chkIncludeGenre
        '
        Me.chkIncludeGenre.AutoSize = True
        Me.chkIncludeGenre.Location = New System.Drawing.Point(388, 183)
        Me.chkIncludeGenre.Name = "chkIncludeGenre"
        Me.chkIncludeGenre.Size = New System.Drawing.Size(277, 17)
        Me.chkIncludeGenre.TabIndex = 130
        Me.chkIncludeGenre.Text = "Include Genre (Category.ini / catlist.ini / genre.ini etc)"
        Me.chkIncludeGenre.UseVisualStyleBackColor = True
        '
        'txtGenereINIPath
        '
        Me.txtGenereINIPath.Location = New System.Drawing.Point(388, 200)
        Me.txtGenereINIPath.Name = "txtGenereINIPath"
        Me.txtGenereINIPath.Size = New System.Drawing.Size(322, 20)
        Me.txtGenereINIPath.TabIndex = 135
        '
        'btnGenrePath
        '
        Me.btnGenrePath.Location = New System.Drawing.Point(708, 200)
        Me.btnGenrePath.Name = "btnGenrePath"
        Me.btnGenrePath.Size = New System.Drawing.Size(24, 20)
        Me.btnGenrePath.TabIndex = 140
        Me.btnGenrePath.Text = "..."
        Me.btnGenrePath.UseVisualStyleBackColor = True
        '
        'lblVideoExtension
        '
        Me.lblVideoExtension.AutoSize = True
        Me.lblVideoExtension.Location = New System.Drawing.Point(13, 381)
        Me.lblVideoExtension.Name = "lblVideoExtension"
        Me.lblVideoExtension.Size = New System.Drawing.Size(80, 13)
        Me.lblVideoExtension.TabIndex = 215
        Me.lblVideoExtension.Text = "VideoExtension"
        '
        'cmbVideoExt
        '
        Me.cmbVideoExt.FormattingEnabled = True
        Me.cmbVideoExt.Items.AddRange(New Object() {".mp4"})
        Me.cmbVideoExt.Location = New System.Drawing.Point(99, 378)
        Me.cmbVideoExt.Name = "cmbVideoExt"
        Me.cmbVideoExt.Size = New System.Drawing.Size(60, 21)
        Me.cmbVideoExt.TabIndex = 220
        Me.cmbVideoExt.Text = ".mp4"
        '
        'cmbScale
        '
        Me.cmbScale.FormattingEnabled = True
        Me.cmbScale.Items.AddRange(New Object() {"100", "10", "5"})
        Me.cmbScale.Location = New System.Drawing.Point(661, 234)
        Me.cmbScale.Name = "cmbScale"
        Me.cmbScale.Size = New System.Drawing.Size(49, 21)
        Me.cmbScale.TabIndex = 165
        Me.cmbScale.Text = "100"
        '
        'chkPrettyXML
        '
        Me.chkPrettyXML.AutoSize = True
        Me.chkPrettyXML.Checked = True
        Me.chkPrettyXML.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrettyXML.Location = New System.Drawing.Point(203, 380)
        Me.chkPrettyXML.Name = "chkPrettyXML"
        Me.chkPrettyXML.Size = New System.Drawing.Size(129, 17)
        Me.chkPrettyXML.TabIndex = 241
        Me.chkPrettyXML.Text = "Pretty/Readable XML"
        Me.chkPrettyXML.UseVisualStyleBackColor = True
        '
        'llGithub
        '
        Me.llGithub.AutoSize = True
        Me.llGithub.Location = New System.Drawing.Point(658, 399)
        Me.llGithub.Name = "llGithub"
        Me.llGithub.Size = New System.Drawing.Size(74, 13)
        Me.llGithub.TabIndex = 242
        Me.llGithub.TabStop = True
        Me.llGithub.Text = "Github Project"
        '
        'llOpenXMLFolder
        '
        Me.llOpenXMLFolder.AutoSize = True
        Me.llOpenXMLFolder.Location = New System.Drawing.Point(260, 74)
        Me.llOpenXMLFolder.Name = "llOpenXMLFolder"
        Me.llOpenXMLFolder.Size = New System.Drawing.Size(74, 13)
        Me.llOpenXMLFolder.TabIndex = 243
        Me.llOpenXMLFolder.TabStop = True
        Me.llOpenXMLFolder.Text = "Open XML Dir"
        '
        'cmbHideLessThanNumber
        '
        Me.cmbHideLessThanNumber.FormattingEnabled = True
        Me.cmbHideLessThanNumber.Items.AddRange(New Object() {"0", "10", "20", "30", "40", "50", "60", "70", "80", "90"})
        Me.cmbHideLessThanNumber.Location = New System.Drawing.Point(879, 255)
        Me.cmbHideLessThanNumber.Name = "cmbHideLessThanNumber"
        Me.cmbHideLessThanNumber.Size = New System.Drawing.Size(49, 21)
        Me.cmbHideLessThanNumber.TabIndex = 244
        Me.cmbHideLessThanNumber.Text = "20"
        '
        'chkHideLessThan
        '
        Me.chkHideLessThan.AutoSize = True
        Me.chkHideLessThan.Location = New System.Drawing.Point(764, 257)
        Me.chkHideLessThan.Name = "chkHideLessThan"
        Me.chkHideLessThan.Size = New System.Drawing.Size(109, 17)
        Me.chkHideLessThan.TabIndex = 245
        Me.chkHideLessThan.Text = "Hide games rated"
        Me.chkHideLessThan.UseVisualStyleBackColor = True
        '
        'lblHideLess
        '
        Me.lblHideLess.AutoSize = True
        Me.lblHideLess.Location = New System.Drawing.Point(934, 258)
        Me.lblHideLess.Name = "lblHideLess"
        Me.lblHideLess.Size = New System.Drawing.Size(56, 13)
        Me.lblHideLess.TabIndex = 246
        Me.lblHideLess.Text = "and below"
        '
        'chkAlsoRemoveINI
        '
        Me.chkAlsoRemoveINI.AutoSize = True
        Me.chkAlsoRemoveINI.Location = New System.Drawing.Point(764, 128)
        Me.chkAlsoRemoveINI.Name = "chkAlsoRemoveINI"
        Me.chkAlsoRemoveINI.Size = New System.Drawing.Size(262, 17)
        Me.chkAlsoRemoveINI.TabIndex = 247
        Me.chkAlsoRemoveINI.Text = "Hidden Games list (Set games in this list to hidden)"
        Me.chkAlsoRemoveINI.UseVisualStyleBackColor = True
        '
        'txtHiddenGames
        '
        Me.txtHiddenGames.Location = New System.Drawing.Point(764, 145)
        Me.txtHiddenGames.Name = "txtHiddenGames"
        Me.txtHiddenGames.Size = New System.Drawing.Size(322, 20)
        Me.txtHiddenGames.TabIndex = 248
        '
        'btnHiddenGamesPath
        '
        Me.btnHiddenGamesPath.Location = New System.Drawing.Point(1084, 145)
        Me.btnHiddenGamesPath.Name = "btnHiddenGamesPath"
        Me.btnHiddenGamesPath.Size = New System.Drawing.Size(24, 20)
        Me.btnHiddenGamesPath.TabIndex = 249
        Me.btnHiddenGamesPath.Text = "..."
        Me.btnHiddenGamesPath.UseVisualStyleBackColor = True
        '
        'chkHideBios
        '
        Me.chkHideBios.AutoSize = True
        Me.chkHideBios.Location = New System.Drawing.Point(1015, 257)
        Me.chkHideBios.Name = "chkHideBios"
        Me.chkHideBios.Size = New System.Drawing.Size(89, 17)
        Me.chkHideBios.TabIndex = 250
        Me.chkHideBios.Text = "Hide Bios etc"
        Me.chkHideBios.UseVisualStyleBackColor = True
        '
        'btnWideForm
        '
        Me.btnWideForm.Location = New System.Drawing.Point(708, 345)
        Me.btnWideForm.Name = "btnWideForm"
        Me.btnWideForm.Size = New System.Drawing.Size(24, 20)
        Me.btnWideForm.TabIndex = 251
        Me.btnWideForm.Text = ">"
        Me.btnWideForm.UseVisualStyleBackColor = True
        '
        'chkIncludeEmulationStatusInDesc
        '
        Me.chkIncludeEmulationStatusInDesc.AutoSize = True
        Me.chkIncludeEmulationStatusInDesc.Checked = True
        Me.chkIncludeEmulationStatusInDesc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeEmulationStatusInDesc.Location = New System.Drawing.Point(388, 380)
        Me.chkIncludeEmulationStatusInDesc.Name = "chkIncludeEmulationStatusInDesc"
        Me.chkIncludeEmulationStatusInDesc.Size = New System.Drawing.Size(246, 17)
        Me.chkIncludeEmulationStatusInDesc.TabIndex = 252
        Me.chkIncludeEmulationStatusInDesc.Text = "Include Emulation && Driver status in description"
        Me.chkIncludeEmulationStatusInDesc.UseVisualStyleBackColor = True
        '
        'lblFavouriteGamesAndAbove
        '
        Me.lblFavouriteGamesAndAbove.AutoSize = True
        Me.lblFavouriteGamesAndAbove.Location = New System.Drawing.Point(956, 299)
        Me.lblFavouriteGamesAndAbove.Name = "lblFavouriteGamesAndAbove"
        Me.lblFavouriteGamesAndAbove.Size = New System.Drawing.Size(58, 13)
        Me.lblFavouriteGamesAndAbove.TabIndex = 255
        Me.lblFavouriteGamesAndAbove.Text = "and above"
        Me.lblFavouriteGamesAndAbove.Visible = False
        '
        'chkFavGreaterThan
        '
        Me.chkFavGreaterThan.AutoSize = True
        Me.chkFavGreaterThan.Location = New System.Drawing.Point(764, 298)
        Me.chkFavGreaterThan.Name = "chkFavGreaterThan"
        Me.chkFavGreaterThan.Size = New System.Drawing.Size(131, 17)
        Me.chkFavGreaterThan.TabIndex = 254
        Me.chkFavGreaterThan.Text = "Favourite games rated"
        Me.chkFavGreaterThan.UseVisualStyleBackColor = True
        Me.chkFavGreaterThan.Visible = False
        '
        'cmbFavGreaterThanNumber
        '
        Me.cmbFavGreaterThanNumber.FormattingEnabled = True
        Me.cmbFavGreaterThanNumber.Items.AddRange(New Object() {"0", "10", "20", "30", "40", "50", "60", "70", "80", "90"})
        Me.cmbFavGreaterThanNumber.Location = New System.Drawing.Point(901, 296)
        Me.cmbFavGreaterThanNumber.Name = "cmbFavGreaterThanNumber"
        Me.cmbFavGreaterThanNumber.Size = New System.Drawing.Size(49, 21)
        Me.cmbFavGreaterThanNumber.TabIndex = 253
        Me.cmbFavGreaterThanNumber.Text = "80"
        Me.cmbFavGreaterThanNumber.Visible = False
        '
        'chkHideCategories
        '
        Me.chkHideCategories.AutoSize = True
        Me.chkHideCategories.Location = New System.Drawing.Point(764, 184)
        Me.chkHideCategories.Name = "chkHideCategories"
        Me.chkHideCategories.Size = New System.Drawing.Size(189, 17)
        Me.chkHideCategories.TabIndex = 256
        Me.chkHideCategories.Text = "Additionally, hide these categories:"
        Me.chkHideCategories.UseVisualStyleBackColor = True
        '
        'txtHideCategories
        '
        Me.txtHideCategories.Location = New System.Drawing.Point(764, 201)
        Me.txtHideCategories.Name = "txtHideCategories"
        Me.txtHideCategories.Size = New System.Drawing.Size(344, 20)
        Me.txtHideCategories.TabIndex = 257
        Me.txtHideCategories.Text = "mahjong;computer;casino;"
        '
        'chkAlsoRemoveDriver
        '
        Me.chkAlsoRemoveDriver.AutoSize = True
        Me.chkAlsoRemoveDriver.Location = New System.Drawing.Point(764, 73)
        Me.chkAlsoRemoveDriver.Name = "chkAlsoRemoveDriver"
        Me.chkAlsoRemoveDriver.Size = New System.Drawing.Size(262, 17)
        Me.chkAlsoRemoveDriver.TabIndex = 258
        Me.chkAlsoRemoveDriver.Text = "Hidden Drivers list (Set games in this list to hidden)"
        Me.chkAlsoRemoveDriver.UseVisualStyleBackColor = True
        '
        'txtHiddenDrivers
        '
        Me.txtHiddenDrivers.Location = New System.Drawing.Point(764, 90)
        Me.txtHiddenDrivers.Name = "txtHiddenDrivers"
        Me.txtHiddenDrivers.Size = New System.Drawing.Size(344, 20)
        Me.txtHiddenDrivers.TabIndex = 259
        '
        'chkIsSoftwareList
        '
        Me.chkIsSoftwareList.AutoSize = True
        Me.chkIsSoftwareList.Location = New System.Drawing.Point(562, 348)
        Me.chkIsSoftwareList.Name = "chkIsSoftwareList"
        Me.chkIsSoftwareList.Size = New System.Drawing.Size(123, 17)
        Me.chkIsSoftwareList.TabIndex = 260
        Me.chkIsSoftwareList.Text = "Load -listsoftware list"
        Me.chkIsSoftwareList.UseVisualStyleBackColor = True
        '
        'txtFakeZipDir
        '
        Me.txtFakeZipDir.Location = New System.Drawing.Point(886, 348)
        Me.txtFakeZipDir.Name = "txtFakeZipDir"
        Me.txtFakeZipDir.Size = New System.Drawing.Size(200, 20)
        Me.txtFakeZipDir.TabIndex = 262
        '
        'chkCreateFakeZip
        '
        Me.chkCreateFakeZip.AutoSize = True
        Me.chkCreateFakeZip.Location = New System.Drawing.Point(764, 350)
        Me.chkCreateFakeZip.Name = "chkCreateFakeZip"
        Me.chkCreateFakeZip.Size = New System.Drawing.Size(116, 17)
        Me.chkCreateFakeZip.TabIndex = 261
        Me.chkCreateFakeZip.Text = "Create empty roms:"
        Me.chkCreateFakeZip.UseVisualStyleBackColor = True
        '
        'chkMoveFakeClones
        '
        Me.chkMoveFakeClones.AutoSize = True
        Me.chkMoveFakeClones.Location = New System.Drawing.Point(764, 380)
        Me.chkMoveFakeClones.Name = "chkMoveFakeClones"
        Me.chkMoveFakeClones.Size = New System.Drawing.Size(110, 17)
        Me.chkMoveFakeClones.TabIndex = 263
        Me.chkMoveFakeClones.Text = "Move clones into:"
        Me.chkMoveFakeClones.UseVisualStyleBackColor = True
        '
        'txtFakeClonesDir
        '
        Me.txtFakeClonesDir.Location = New System.Drawing.Point(886, 378)
        Me.txtFakeClonesDir.Name = "txtFakeClonesDir"
        Me.txtFakeClonesDir.Size = New System.Drawing.Size(161, 20)
        Me.txtFakeClonesDir.TabIndex = 264
        Me.txtFakeClonesDir.Text = "00_Clones"
        '
        'btnSetFakeZipDir
        '
        Me.btnSetFakeZipDir.Location = New System.Drawing.Point(1084, 348)
        Me.btnSetFakeZipDir.Name = "btnSetFakeZipDir"
        Me.btnSetFakeZipDir.Size = New System.Drawing.Size(24, 20)
        Me.btnSetFakeZipDir.TabIndex = 265
        Me.btnSetFakeZipDir.Text = "..."
        Me.btnSetFakeZipDir.UseVisualStyleBackColor = True
        '
        'lblClonesFolder
        '
        Me.lblClonesFolder.AutoSize = True
        Me.lblClonesFolder.Location = New System.Drawing.Point(1053, 381)
        Me.lblClonesFolder.Name = "lblClonesFolder"
        Me.lblClonesFolder.Size = New System.Drawing.Size(33, 13)
        Me.lblClonesFolder.TabIndex = 266
        Me.lblClonesFolder.Text = "folder"
        '
        'ErrorProviderMain
        '
        Me.ErrorProviderMain.ContainerControl = Me
        '
        'chkScanSubFolders
        '
        Me.chkScanSubFolders.AutoSize = True
        Me.chkScanSubFolders.Location = New System.Drawing.Point(203, 348)
        Me.chkScanSubFolders.Name = "chkScanSubFolders"
        Me.chkScanSubFolders.Size = New System.Drawing.Size(104, 17)
        Me.chkScanSubFolders.TabIndex = 267
        Me.chkScanSubFolders.Text = "Scan Subfolders"
        Me.chkScanSubFolders.UseVisualStyleBackColor = True
        '
        'chkDontHideFavGames
        '
        Me.chkDontHideFavGames.AutoSize = True
        Me.chkDontHideFavGames.Location = New System.Drawing.Point(388, 348)
        Me.chkDontHideFavGames.Name = "chkDontHideFavGames"
        Me.chkDontHideFavGames.Size = New System.Drawing.Size(162, 17)
        Me.chkDontHideFavGames.TabIndex = 268
        Me.chkDontHideFavGames.Text = "Don't hide the Favourites list "
        Me.chkDontHideFavGames.UseVisualStyleBackColor = True
        '
        'btnBackGround
        '
        Me.btnBackGround.Location = New System.Drawing.Point(764, 415)
        Me.btnBackGround.Name = "btnBackGround"
        Me.btnBackGround.Size = New System.Drawing.Size(344, 45)
        Me.btnBackGround.TabIndex = 269
        Me.btnBackGround.Text = "Create Emulation Station gamelist.xml (Background worker thread)"
        Me.btnBackGround.UseVisualStyleBackColor = True
        Me.btnBackGround.Visible = False
        '
        'chkHistoryFirst
        '
        Me.chkHistoryFirst.AutoSize = True
        Me.chkHistoryFirst.Location = New System.Drawing.Point(604, 18)
        Me.chkHistoryFirst.Name = "chkHistoryFirst"
        Me.chkHistoryFirst.Size = New System.Drawing.Size(110, 17)
        Me.chkHistoryFirst.TabIndex = 270
        Me.chkHistoryFirst.Text = "Show History First"
        Me.chkHistoryFirst.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 472)
        Me.Controls.Add(Me.chkHistoryFirst)
        Me.Controls.Add(Me.btnBackGround)
        Me.Controls.Add(Me.chkDontHideFavGames)
        Me.Controls.Add(Me.chkScanSubFolders)
        Me.Controls.Add(Me.lblClonesFolder)
        Me.Controls.Add(Me.txtFakeZipDir)
        Me.Controls.Add(Me.btnSetFakeZipDir)
        Me.Controls.Add(Me.txtFakeClonesDir)
        Me.Controls.Add(Me.chkMoveFakeClones)
        Me.Controls.Add(Me.chkCreateFakeZip)
        Me.Controls.Add(Me.chkIsSoftwareList)
        Me.Controls.Add(Me.chkAlsoRemoveDriver)
        Me.Controls.Add(Me.txtHiddenDrivers)
        Me.Controls.Add(Me.chkHideCategories)
        Me.Controls.Add(Me.txtHideCategories)
        Me.Controls.Add(Me.lblFavouriteGamesAndAbove)
        Me.Controls.Add(Me.chkFavGreaterThan)
        Me.Controls.Add(Me.cmbFavGreaterThanNumber)
        Me.Controls.Add(Me.chkIncludeEmulationStatusInDesc)
        Me.Controls.Add(Me.btnWideForm)
        Me.Controls.Add(Me.chkHideBios)
        Me.Controls.Add(Me.chkAlsoRemoveINI)
        Me.Controls.Add(Me.txtHiddenGames)
        Me.Controls.Add(Me.btnHiddenGamesPath)
        Me.Controls.Add(Me.lblHideLess)
        Me.Controls.Add(Me.chkHideLessThan)
        Me.Controls.Add(Me.cmbHideLessThanNumber)
        Me.Controls.Add(Me.llOpenXMLFolder)
        Me.Controls.Add(Me.llGithub)
        Me.Controls.Add(Me.chkPrettyXML)
        Me.Controls.Add(Me.cmbScale)
        Me.Controls.Add(Me.lblVideoExtension)
        Me.Controls.Add(Me.cmbVideoExt)
        Me.Controls.Add(Me.chkIncludeGenre)
        Me.Controls.Add(Me.txtGenereINIPath)
        Me.Controls.Add(Me.btnGenrePath)
        Me.Controls.Add(Me.chkIncludeMarquee)
        Me.Controls.Add(Me.txtMarqueeDir)
        Me.Controls.Add(Me.btnMarqueeDir)
        Me.Controls.Add(Me.chkIncludeRating)
        Me.Controls.Add(Me.txtRatingPath)
        Me.Controls.Add(Me.btnRatingPath)
        Me.Controls.Add(Me.chkIncludeFavourites)
        Me.Controls.Add(Me.txtFavouritesPath)
        Me.Controls.Add(Me.btnFavPath)
        Me.Controls.Add(Me.txtMameInfoPath)
        Me.Controls.Add(Me.btnMameInfo)
        Me.Controls.Add(Me.chkIncludeMameInfo)
        Me.Controls.Add(Me.llabelOpenRomDir)
        Me.Controls.Add(Me.lblRomExt)
        Me.Controls.Add(Me.cmbROMExt)
        Me.Controls.Add(Me.chkVideoDir)
        Me.Controls.Add(Me.txtVideoDir)
        Me.Controls.Add(Me.btnVideoDir)
        Me.Controls.Add(Me.chkROMDir)
        Me.Controls.Add(Me.txtRomdir)
        Me.Controls.Add(Me.btnROMDir)
        Me.Controls.Add(Me.txtHistoryDATPath)
        Me.Controls.Add(Me.btnHistoryPath)
        Me.Controls.Add(Me.chkHistoryDAT)
        Me.Controls.Add(Me.txtImages)
        Me.Controls.Add(Me.chkImageAppend)
        Me.Controls.Add(Me.chkImagePrepend)
        Me.Controls.Add(Me.cmbImageExtension)
        Me.Controls.Add(Me.lblImageExtension)
        Me.Controls.Add(Me.btnImageDir)
        Me.Controls.Add(Me.btnCreateMameXML)
        Me.Controls.Add(Me.btnCreateGameList)
        Me.Controls.Add(Me.lblMAME_EXE)
        Me.Controls.Add(Me.lblImagesa)
        Me.Controls.Add(Me.chkVersionXML)
        Me.Controls.Add(Me.txtImageAppend)
        Me.Controls.Add(Me.txtImagePrepend)
        Me.Controls.Add(Me.txtMameEXEPath)
        Me.Controls.Add(Me.txtMameXMLPath)
        Me.Controls.Add(Me.btnMameEXEPath)
        Me.Controls.Add(Me.btnMameXMLPath)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create ES Gamelist.xml"
        CType(Me.ErrorProviderMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMameXMLPath As Button
    Friend WithEvents btnMameEXEPath As Button
    Friend WithEvents txtMameXMLPath As TextBox
    Friend WithEvents txtMameEXEPath As TextBox
    Friend WithEvents txtImages As TextBox
    Friend WithEvents txtImagePrepend As TextBox
    Friend WithEvents txtImageAppend As TextBox
    Friend WithEvents chkVersionXML As CheckBox
    Friend WithEvents lblImagesa As Label
    Friend WithEvents lblMAME_EXE As Label
    Friend WithEvents btnCreateGameList As Button
    Friend WithEvents btnCreateMameXML As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnImageDir As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblImageExtension As Label
    Friend WithEvents cmbImageExtension As ComboBox
    Friend WithEvents chkImagePrepend As CheckBox
    Friend WithEvents chkImageAppend As CheckBox
    Friend WithEvents chkHistoryDAT As CheckBox
    Friend WithEvents txtHistoryDATPath As TextBox
    Friend WithEvents btnHistoryPath As Button
    Friend WithEvents txtRomdir As TextBox
    Friend WithEvents btnROMDir As Button
    Friend WithEvents chkROMDir As CheckBox
    Friend WithEvents txtVideoDir As TextBox
    Friend WithEvents btnVideoDir As Button
    Friend WithEvents chkVideoDir As CheckBox
    Friend WithEvents cmbROMExt As ComboBox
    Friend WithEvents lblRomExt As Label
    Friend WithEvents llabelOpenRomDir As LinkLabel
    Friend WithEvents txtMameInfoPath As TextBox
    Friend WithEvents btnMameInfo As Button
    Friend WithEvents chkIncludeMameInfo As CheckBox
    Friend WithEvents chkIncludeFavourites As CheckBox
    Friend WithEvents txtFavouritesPath As TextBox
    Friend WithEvents btnFavPath As Button
    Friend WithEvents chkIncludeRating As CheckBox
    Friend WithEvents txtRatingPath As TextBox
    Friend WithEvents btnRatingPath As Button
    Friend WithEvents chkIncludeMarquee As CheckBox
    Friend WithEvents txtMarqueeDir As TextBox
    Friend WithEvents btnMarqueeDir As Button
    Friend WithEvents chkIncludeGenre As CheckBox
    Friend WithEvents txtGenereINIPath As TextBox
    Friend WithEvents btnGenrePath As Button
    Friend WithEvents lblVideoExtension As Label
    Friend WithEvents cmbVideoExt As ComboBox
    Friend WithEvents cmbScale As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkPrettyXML As CheckBox
    Friend WithEvents llGithub As LinkLabel
    Friend WithEvents llOpenXMLFolder As LinkLabel
    Friend WithEvents cmbHideLessThanNumber As ComboBox
    Friend WithEvents chkHideLessThan As CheckBox
    Friend WithEvents lblHideLess As Label
    Friend WithEvents chkAlsoRemoveINI As CheckBox
    Friend WithEvents txtHiddenGames As TextBox
    Friend WithEvents btnHiddenGamesPath As Button
    Friend WithEvents chkHideBios As CheckBox
    Friend WithEvents btnWideForm As Button
    Friend WithEvents chkIncludeEmulationStatusInDesc As CheckBox
    Friend WithEvents lblFavouriteGamesAndAbove As Label
    Friend WithEvents chkFavGreaterThan As CheckBox
    Friend WithEvents cmbFavGreaterThanNumber As ComboBox
    Friend WithEvents chkHideCategories As CheckBox
    Friend WithEvents txtHideCategories As TextBox
    Friend WithEvents chkAlsoRemoveDriver As CheckBox
    Friend WithEvents txtHiddenDrivers As TextBox
    Friend WithEvents chkIsSoftwareList As CheckBox
    Friend WithEvents txtFakeZipDir As TextBox
    Friend WithEvents chkCreateFakeZip As CheckBox
    Friend WithEvents chkMoveFakeClones As CheckBox
    Friend WithEvents txtFakeClonesDir As TextBox
    Friend WithEvents btnSetFakeZipDir As Button
    Friend WithEvents lblClonesFolder As Label
    Friend WithEvents ErrorProviderMain As ErrorProvider
    Friend WithEvents chkScanSubFolders As CheckBox
    Friend WithEvents chkDontHideFavGames As CheckBox
    Friend WithEvents btnBackGround As Button
    Friend WithEvents chkHistoryFirst As CheckBox
End Class
