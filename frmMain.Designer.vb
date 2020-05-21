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
        Me.Label2 = New System.Windows.Forms.Label()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MAME.exe (For list creation)"
        '
        'btnCreateGameList
        '
        Me.btnCreateGameList.Location = New System.Drawing.Point(12, 388)
        Me.btnCreateGameList.Name = "btnCreateGameList"
        Me.btnCreateGameList.Size = New System.Drawing.Size(720, 45)
        Me.btnCreateGameList.TabIndex = 240
        Me.btnCreateGameList.Text = "Create Emulation Station gamelist.xml"
        Me.btnCreateGameList.UseVisualStyleBackColor = True
        '
        'btnCreateMameXML
        '
        Me.btnCreateMameXML.Location = New System.Drawing.Point(198, 9)
        Me.btnCreateMameXML.Name = "btnCreateMameXML"
        Me.btnCreateMameXML.Size = New System.Drawing.Size(136, 23)
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
        Me.cmbROMExt.Location = New System.Drawing.Point(274, 344)
        Me.cmbROMExt.Name = "cmbROMExt"
        Me.cmbROMExt.Size = New System.Drawing.Size(60, 21)
        Me.cmbROMExt.TabIndex = 230
        Me.cmbROMExt.Text = ".zip"
        '
        'lblRomExt
        '
        Me.lblRomExt.AutoSize = True
        Me.lblRomExt.Location = New System.Drawing.Point(187, 347)
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
        Me.chkIncludeFavourites.Size = New System.Drawing.Size(113, 17)
        Me.chkIncludeFavourites.TabIndex = 200
        Me.chkIncludeFavourites.Text = "Include Favourites"
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
        Me.lblVideoExtension.Location = New System.Drawing.Point(9, 347)
        Me.lblVideoExtension.Name = "lblVideoExtension"
        Me.lblVideoExtension.Size = New System.Drawing.Size(80, 13)
        Me.lblVideoExtension.TabIndex = 215
        Me.lblVideoExtension.Text = "VideoExtension"
        '
        'cmbVideoExt
        '
        Me.cmbVideoExt.FormattingEnabled = True
        Me.cmbVideoExt.Items.AddRange(New Object() {".mp4"})
        Me.cmbVideoExt.Location = New System.Drawing.Point(95, 344)
        Me.cmbVideoExt.Name = "cmbVideoExt"
        Me.cmbVideoExt.Size = New System.Drawing.Size(60, 21)
        Me.cmbVideoExt.TabIndex = 220
        Me.cmbVideoExt.Text = ".mp4"
        '
        'cmbScale
        '
        Me.cmbScale.FormattingEnabled = True
        Me.cmbScale.Items.AddRange(New Object() {"100", "10", "5"})
        Me.cmbScale.Location = New System.Drawing.Point(650, 234)
        Me.cmbScale.Name = "cmbScale"
        Me.cmbScale.Size = New System.Drawing.Size(60, 21)
        Me.cmbScale.TabIndex = 165
        Me.cmbScale.Text = "100"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 445)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblImagesa)
        Me.Controls.Add(Me.chkVersionXML)
        Me.Controls.Add(Me.txtImageAppend)
        Me.Controls.Add(Me.txtImagePrepend)
        Me.Controls.Add(Me.txtMameEXEPath)
        Me.Controls.Add(Me.txtMameXMLPath)
        Me.Controls.Add(Me.btnMameEXEPath)
        Me.Controls.Add(Me.btnMameXMLPath)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create ES Gamelist.xml"
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
    Friend WithEvents Label2 As Label
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
End Class
