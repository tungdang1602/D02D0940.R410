<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F0001
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F0001))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tabSystem = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkIsObligatoryManagement = New System.Windows.Forms.CheckBox()
        Me.chkCIPforPropertyProduct = New System.Windows.Forms.CheckBox()
        Me.chkObligatoryReceiver = New System.Windows.Forms.CheckBox()
        Me.chkUseProperty = New System.Windows.Forms.CheckBox()
        Me.chkDecreaseAsset = New System.Windows.Forms.CheckBox()
        Me.tdbcMethodEndID = New C1.Win.C1List.C1Combo()
        Me.tdbcMethodID = New C1.Win.C1List.C1Combo()
        Me.tdbcDefAssignmentID = New C1.Win.C1List.C1Combo()
        Me.tdbcDefSourceID = New C1.Win.C1List.C1Combo()
        Me.tdbcDefDepreciationAccountID = New C1.Win.C1List.C1Combo()
        Me.lblDepreciateAccountID = New System.Windows.Forms.Label()
        Me.tdbcDefAssetAccountID = New C1.Win.C1List.C1Combo()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tdbcDivisionID = New C1.Win.C1List.C1Combo()
        Me.txtDefaultPeriod = New System.Windows.Forms.TextBox()
        Me.lblDefaultPeriod = New System.Windows.Forms.Label()
        Me.txtPeriodNumber = New System.Windows.Forms.TextBox()
        Me.lblNumberPeriod = New System.Windows.Forms.Label()
        Me.txtDivisionName = New System.Windows.Forms.TextBox()
        Me.lblAssetAccountID = New System.Windows.Forms.Label()
        Me.lblSourceID = New System.Windows.Forms.Label()
        Me.lblAssignmentID = New System.Windows.Forms.Label()
        Me.lblMethodID = New System.Windows.Forms.Label()
        Me.lblMethodEndID = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkIsAssetIDForD02D43 = New System.Windows.Forms.CheckBox()
        Me.chkAssetAuto = New System.Windows.Forms.CheckBox()
        Me.txtCheckAssetOutputLength = New System.Windows.Forms.TextBox()
        Me.chkCheckAssetOutputLength = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpIGE = New System.Windows.Forms.GroupBox()
        Me.optShowFormAotuCreate1 = New System.Windows.Forms.RadioButton()
        Me.optShowFormAotuCreate0 = New System.Windows.Forms.RadioButton()
        Me.optAssetAuto2 = New System.Windows.Forms.RadioButton()
        Me.optAssetAuto1 = New System.Windows.Forms.RadioButton()
        Me.lblCaptionExample = New System.Windows.Forms.Label()
        Me.grpAutoAssetNumbering = New System.Windows.Forms.GroupBox()
        Me.txtAssetOutputLength = New System.Windows.Forms.TextBox()
        Me.tdbcAssetSeperator = New C1.Win.C1List.C1Combo()
        Me.lblAssetOutputLength = New System.Windows.Forms.Label()
        Me.lblAutoNumberLength = New System.Windows.Forms.Label()
        Me.updownAutoNumberLength = New System.Windows.Forms.NumericUpDown()
        Me.cboAssetOutputOrder = New System.Windows.Forms.ComboBox()
        Me.chkAssetSeperated = New System.Windows.Forms.CheckBox()
        Me.lblAssetOutputOrder = New System.Windows.Forms.Label()
        Me.lblExample = New System.Windows.Forms.Label()
        Me.grpAssetCategories = New System.Windows.Forms.GroupBox()
        Me.tdbcAssetS3Default = New C1.Win.C1List.C1Combo()
        Me.tdbcAssetS2Default = New C1.Win.C1List.C1Combo()
        Me.chkAssetS3Enabled = New System.Windows.Forms.CheckBox()
        Me.chkAssetS2Enabled = New System.Windows.Forms.CheckBox()
        Me.tdbcAssetS1Default = New C1.Win.C1List.C1Combo()
        Me.chkAssetS1Enabled = New System.Windows.Forms.CheckBox()
        Me.txtS1Length = New System.Windows.Forms.TextBox()
        Me.txtS2Length = New System.Windows.Forms.TextBox()
        Me.txtS3Length = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chkUseBudgetForCIP = New System.Windows.Forms.CheckBox()
        Me.chkUseD54ForCIP = New System.Windows.Forms.CheckBox()
        Me.chkCIPAuto = New System.Windows.Forms.CheckBox()
        Me.txtCIPCheckOutputLength = New System.Windows.Forms.TextBox()
        Me.chkCIPCheckOutputLength = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optCIPAuto2 = New System.Windows.Forms.RadioButton()
        Me.optCIPAuto1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpAutoCIPNumbering = New System.Windows.Forms.GroupBox()
        Me.tdbcCIPSeperator = New C1.Win.C1List.C1Combo()
        Me.txtCIPOutputLength = New System.Windows.Forms.TextBox()
        Me.lblCIPOutputLength = New System.Windows.Forms.Label()
        Me.lblCIPAutoNumberLength = New System.Windows.Forms.Label()
        Me.updownCIPAutoNumberLength = New System.Windows.Forms.NumericUpDown()
        Me.cboCIPOutputOrder = New System.Windows.Forms.ComboBox()
        Me.chkCIPSeperated = New System.Windows.Forms.CheckBox()
        Me.lblCIPOutputOrder = New System.Windows.Forms.Label()
        Me.lblCIPExample = New System.Windows.Forms.Label()
        Me.grpCIPCategories = New System.Windows.Forms.GroupBox()
        Me.tdbcCIPS3Default = New C1.Win.C1List.C1Combo()
        Me.tdbcCIPS1Default = New C1.Win.C1List.C1Combo()
        Me.tdbcCIPS2Default = New C1.Win.C1List.C1Combo()
        Me.chkCIPS3Enabled = New System.Windows.Forms.CheckBox()
        Me.chkCIPS2Enabled = New System.Windows.Forms.CheckBox()
        Me.chkCIPS1Enabled = New System.Windows.Forms.CheckBox()
        Me.txtCIPS1Length = New System.Windows.Forms.TextBox()
        Me.txtCIPS2Length = New System.Windows.Forms.TextBox()
        Me.txtCIPS3Length = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.chkIsCalPeriodByRate = New System.Windows.Forms.CheckBox()
        Me.chkIsEditAnaID = New System.Windows.Forms.CheckBox()
        Me.chkIsCalDepByDate = New System.Windows.Forms.CheckBox()
        Me.chkIsAllowChangeAccount = New System.Windows.Forms.CheckBox()
        Me.chkAllowChangeDivision = New System.Windows.Forms.CheckBox()
        Me.chkIsCheckNormIDAllocated = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.tdbdVoucherTypeID = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.tdbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tabSystem.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.tdbcMethodEndID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcMethodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDefAssignmentID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDefSourceID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDefDepreciationAccountID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDefAssetAccountID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp1.SuspendLayout()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpIGE.SuspendLayout()
        Me.grpAutoAssetNumbering.SuspendLayout()
        CType(Me.tdbcAssetSeperator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownAutoNumberLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAssetCategories.SuspendLayout()
        CType(Me.tdbcAssetS3Default, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcAssetS2Default, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcAssetS1Default, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpAutoCIPNumbering.SuspendLayout()
        CType(Me.tdbcCIPSeperator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownCIPAutoNumberLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCIPCategories.SuspendLayout()
        CType(Me.tdbcCIPS3Default, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcCIPS1Default, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcCIPS2Default, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.tdbdVoucherTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(428, 370)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 22)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(511, 370)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 22)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tabSystem
        '
        Me.tabSystem.Controls.Add(Me.TabPage1)
        Me.tabSystem.Controls.Add(Me.TabPage2)
        Me.tabSystem.Controls.Add(Me.TabPage3)
        Me.tabSystem.Controls.Add(Me.TabPage4)
        Me.tabSystem.Controls.Add(Me.TabPage5)
        Me.tabSystem.Location = New System.Drawing.Point(5, 10)
        Me.tabSystem.Name = "tabSystem"
        Me.tabSystem.SelectedIndex = 0
        Me.tabSystem.Size = New System.Drawing.Size(584, 354)
        Me.tabSystem.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkIsObligatoryManagement)
        Me.TabPage1.Controls.Add(Me.chkCIPforPropertyProduct)
        Me.TabPage1.Controls.Add(Me.chkObligatoryReceiver)
        Me.TabPage1.Controls.Add(Me.chkUseProperty)
        Me.TabPage1.Controls.Add(Me.chkDecreaseAsset)
        Me.TabPage1.Controls.Add(Me.tdbcMethodEndID)
        Me.TabPage1.Controls.Add(Me.tdbcMethodID)
        Me.TabPage1.Controls.Add(Me.tdbcDefAssignmentID)
        Me.TabPage1.Controls.Add(Me.tdbcDefSourceID)
        Me.TabPage1.Controls.Add(Me.tdbcDefDepreciationAccountID)
        Me.TabPage1.Controls.Add(Me.lblDepreciateAccountID)
        Me.TabPage1.Controls.Add(Me.tdbcDefAssetAccountID)
        Me.TabPage1.Controls.Add(Me.grp1)
        Me.TabPage1.Controls.Add(Me.lblAssetAccountID)
        Me.TabPage1.Controls.Add(Me.lblSourceID)
        Me.TabPage1.Controls.Add(Me.lblAssignmentID)
        Me.TabPage1.Controls.Add(Me.lblMethodID)
        Me.TabPage1.Controls.Add(Me.lblMethodEndID)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(576, 328)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông tin chính"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkIsObligatoryManagement
        '
        Me.chkIsObligatoryManagement.AutoSize = True
        Me.chkIsObligatoryManagement.Location = New System.Drawing.Point(8, 288)
        Me.chkIsObligatoryManagement.Name = "chkIsObligatoryManagement"
        Me.chkIsObligatoryManagement.Size = New System.Drawing.Size(175, 17)
        Me.chkIsObligatoryManagement.TabIndex = 17
        Me.chkIsObligatoryManagement.Text = "Bắt buộc nhập bộ phận quản lý"
        Me.chkIsObligatoryManagement.UseVisualStyleBackColor = True
        '
        'chkCIPforPropertyProduct
        '
        Me.chkCIPforPropertyProduct.AutoSize = True
        Me.chkCIPforPropertyProduct.Location = New System.Drawing.Point(8, 265)
        Me.chkCIPforPropertyProduct.Name = "chkCIPforPropertyProduct"
        Me.chkCIPforPropertyProduct.Size = New System.Drawing.Size(161, 17)
        Me.chkCIPforPropertyProduct.TabIndex = 16
        Me.chkCIPforPropertyProduct.Text = "Tập hợp XDCB cho mã BĐS"
        Me.chkCIPforPropertyProduct.UseVisualStyleBackColor = True
        '
        'chkObligatoryReceiver
        '
        Me.chkObligatoryReceiver.AutoSize = True
        Me.chkObligatoryReceiver.Checked = True
        Me.chkObligatoryReceiver.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkObligatoryReceiver.Location = New System.Drawing.Point(8, 242)
        Me.chkObligatoryReceiver.Name = "chkObligatoryReceiver"
        Me.chkObligatoryReceiver.Size = New System.Drawing.Size(172, 17)
        Me.chkObligatoryReceiver.TabIndex = 15
        Me.chkObligatoryReceiver.Text = "Bắt buộc nhập người tiếp nhận"
        Me.chkObligatoryReceiver.UseVisualStyleBackColor = True
        '
        'chkUseProperty
        '
        Me.chkUseProperty.AutoSize = True
        Me.chkUseProperty.Location = New System.Drawing.Point(8, 218)
        Me.chkUseProperty.Name = "chkUseProperty"
        Me.chkUseProperty.Size = New System.Drawing.Size(82, 17)
        Me.chkUseProperty.TabIndex = 14
        Me.chkUseProperty.Text = "BĐS đầu tư"
        Me.chkUseProperty.UseVisualStyleBackColor = True
        '
        'chkDecreaseAsset
        '
        Me.chkDecreaseAsset.AutoSize = True
        Me.chkDecreaseAsset.Location = New System.Drawing.Point(8, 195)
        Me.chkDecreaseAsset.Name = "chkDecreaseAsset"
        Me.chkDecreaseAsset.Size = New System.Drawing.Size(129, 17)
        Me.chkDecreaseAsset.TabIndex = 13
        Me.chkDecreaseAsset.Text = "Các bút toán giảm TS"
        Me.chkDecreaseAsset.UseVisualStyleBackColor = True
        '
        'tdbcMethodEndID
        '
        Me.tdbcMethodEndID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcMethodEndID.AllowColMove = False
        Me.tdbcMethodEndID.AllowSort = False
        Me.tdbcMethodEndID.AlternatingRows = True
        Me.tdbcMethodEndID.AutoDropDown = True
        Me.tdbcMethodEndID.Caption = ""
        Me.tdbcMethodEndID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcMethodEndID.ColumnWidth = 100
        Me.tdbcMethodEndID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcMethodEndID.DisplayMember = "MethodEndName"
        Me.tdbcMethodEndID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcMethodEndID.DropDownWidth = 400
        Me.tdbcMethodEndID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcMethodEndID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMethodEndID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcMethodEndID.EmptyRows = True
        Me.tdbcMethodEndID.ExtendRightColumn = True
        Me.tdbcMethodEndID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMethodEndID.Images.Add(CType(resources.GetObject("tdbcMethodEndID.Images"), System.Drawing.Image))
        Me.tdbcMethodEndID.Location = New System.Drawing.Point(427, 162)
        Me.tdbcMethodEndID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcMethodEndID.MaxDropDownItems = CType(8, Short)
        Me.tdbcMethodEndID.MaxLength = 32767
        Me.tdbcMethodEndID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcMethodEndID.Name = "tdbcMethodEndID"
        Me.tdbcMethodEndID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcMethodEndID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcMethodEndID.Size = New System.Drawing.Size(135, 21)
        Me.tdbcMethodEndID.TabIndex = 12
        Me.tdbcMethodEndID.ValueMember = "MethodEndID"
        Me.tdbcMethodEndID.PropBag = resources.GetString("tdbcMethodEndID.PropBag")
        '
        'tdbcMethodID
        '
        Me.tdbcMethodID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcMethodID.AllowColMove = False
        Me.tdbcMethodID.AllowSort = False
        Me.tdbcMethodID.AlternatingRows = True
        Me.tdbcMethodID.AutoDropDown = True
        Me.tdbcMethodID.Caption = ""
        Me.tdbcMethodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcMethodID.ColumnWidth = 100
        Me.tdbcMethodID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcMethodID.DisplayMember = "MethodName"
        Me.tdbcMethodID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcMethodID.DropDownWidth = 400
        Me.tdbcMethodID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcMethodID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMethodID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcMethodID.EmptyRows = True
        Me.tdbcMethodID.ExtendRightColumn = True
        Me.tdbcMethodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMethodID.Images.Add(CType(resources.GetObject("tdbcMethodID.Images"), System.Drawing.Image))
        Me.tdbcMethodID.Location = New System.Drawing.Point(427, 133)
        Me.tdbcMethodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcMethodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcMethodID.MaxLength = 32767
        Me.tdbcMethodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcMethodID.Name = "tdbcMethodID"
        Me.tdbcMethodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcMethodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcMethodID.Size = New System.Drawing.Size(135, 21)
        Me.tdbcMethodID.TabIndex = 10
        Me.tdbcMethodID.ValueMember = "MethodID"
        Me.tdbcMethodID.PropBag = resources.GetString("tdbcMethodID.PropBag")
        '
        'tdbcDefAssignmentID
        '
        Me.tdbcDefAssignmentID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDefAssignmentID.AllowColMove = False
        Me.tdbcDefAssignmentID.AllowSort = False
        Me.tdbcDefAssignmentID.AlternatingRows = True
        Me.tdbcDefAssignmentID.AutoCompletion = True
        Me.tdbcDefAssignmentID.AutoDropDown = True
        Me.tdbcDefAssignmentID.Caption = ""
        Me.tdbcDefAssignmentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDefAssignmentID.ColumnWidth = 100
        Me.tdbcDefAssignmentID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDefAssignmentID.DisplayMember = "AssignmentID"
        Me.tdbcDefAssignmentID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDefAssignmentID.DropDownWidth = 400
        Me.tdbcDefAssignmentID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDefAssignmentID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDefAssignmentID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDefAssignmentID.EmptyRows = True
        Me.tdbcDefAssignmentID.ExtendRightColumn = True
        Me.tdbcDefAssignmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDefAssignmentID.Images.Add(CType(resources.GetObject("tdbcDefAssignmentID.Images"), System.Drawing.Image))
        Me.tdbcDefAssignmentID.Location = New System.Drawing.Point(427, 104)
        Me.tdbcDefAssignmentID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDefAssignmentID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDefAssignmentID.MaxLength = 32767
        Me.tdbcDefAssignmentID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDefAssignmentID.Name = "tdbcDefAssignmentID"
        Me.tdbcDefAssignmentID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDefAssignmentID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDefAssignmentID.Size = New System.Drawing.Size(135, 21)
        Me.tdbcDefAssignmentID.TabIndex = 8
        Me.tdbcDefAssignmentID.ValueMember = "AssignmentID"
        Me.tdbcDefAssignmentID.PropBag = resources.GetString("tdbcDefAssignmentID.PropBag")
        '
        'tdbcDefSourceID
        '
        Me.tdbcDefSourceID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDefSourceID.AllowColMove = False
        Me.tdbcDefSourceID.AllowSort = False
        Me.tdbcDefSourceID.AlternatingRows = True
        Me.tdbcDefSourceID.AutoDropDown = True
        Me.tdbcDefSourceID.Caption = ""
        Me.tdbcDefSourceID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDefSourceID.ColumnWidth = 100
        Me.tdbcDefSourceID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDefSourceID.DisplayMember = "SourceName"
        Me.tdbcDefSourceID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDefSourceID.DropDownWidth = 500
        Me.tdbcDefSourceID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDefSourceID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDefSourceID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDefSourceID.EmptyRows = True
        Me.tdbcDefSourceID.ExtendRightColumn = True
        Me.tdbcDefSourceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDefSourceID.Images.Add(CType(resources.GetObject("tdbcDefSourceID.Images"), System.Drawing.Image))
        Me.tdbcDefSourceID.Location = New System.Drawing.Point(127, 162)
        Me.tdbcDefSourceID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDefSourceID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDefSourceID.MaxLength = 32767
        Me.tdbcDefSourceID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDefSourceID.Name = "tdbcDefSourceID"
        Me.tdbcDefSourceID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDefSourceID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDefSourceID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcDefSourceID.TabIndex = 6
        Me.tdbcDefSourceID.ValueMember = "SourceID"
        Me.tdbcDefSourceID.PropBag = resources.GetString("tdbcDefSourceID.PropBag")
        '
        'tdbcDefDepreciationAccountID
        '
        Me.tdbcDefDepreciationAccountID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDefDepreciationAccountID.AllowColMove = False
        Me.tdbcDefDepreciationAccountID.AllowSort = False
        Me.tdbcDefDepreciationAccountID.AlternatingRows = True
        Me.tdbcDefDepreciationAccountID.AutoCompletion = True
        Me.tdbcDefDepreciationAccountID.AutoDropDown = True
        Me.tdbcDefDepreciationAccountID.Caption = ""
        Me.tdbcDefDepreciationAccountID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDefDepreciationAccountID.ColumnWidth = 100
        Me.tdbcDefDepreciationAccountID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDefDepreciationAccountID.DisplayMember = "AccountID"
        Me.tdbcDefDepreciationAccountID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDefDepreciationAccountID.DropDownWidth = 500
        Me.tdbcDefDepreciationAccountID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDefDepreciationAccountID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDefDepreciationAccountID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDefDepreciationAccountID.EmptyRows = True
        Me.tdbcDefDepreciationAccountID.ExtendRightColumn = True
        Me.tdbcDefDepreciationAccountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDefDepreciationAccountID.Images.Add(CType(resources.GetObject("tdbcDefDepreciationAccountID.Images"), System.Drawing.Image))
        Me.tdbcDefDepreciationAccountID.Location = New System.Drawing.Point(127, 133)
        Me.tdbcDefDepreciationAccountID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDefDepreciationAccountID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDefDepreciationAccountID.MaxLength = 32767
        Me.tdbcDefDepreciationAccountID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDefDepreciationAccountID.Name = "tdbcDefDepreciationAccountID"
        Me.tdbcDefDepreciationAccountID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDefDepreciationAccountID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDefDepreciationAccountID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcDefDepreciationAccountID.TabIndex = 4
        Me.tdbcDefDepreciationAccountID.ValueMember = "AccountID"
        Me.tdbcDefDepreciationAccountID.PropBag = resources.GetString("tdbcDefDepreciationAccountID.PropBag")
        '
        'lblDepreciateAccountID
        '
        Me.lblDepreciateAccountID.AutoSize = True
        Me.lblDepreciateAccountID.Location = New System.Drawing.Point(5, 138)
        Me.lblDepreciateAccountID.Name = "lblDepreciateAccountID"
        Me.lblDepreciateAccountID.Size = New System.Drawing.Size(69, 13)
        Me.lblDepreciateAccountID.TabIndex = 3
        Me.lblDepreciateAccountID.Text = "TK khấu hao"
        Me.lblDepreciateAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcDefAssetAccountID
        '
        Me.tdbcDefAssetAccountID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDefAssetAccountID.AllowColMove = False
        Me.tdbcDefAssetAccountID.AllowSort = False
        Me.tdbcDefAssetAccountID.AlternatingRows = True
        Me.tdbcDefAssetAccountID.AutoCompletion = True
        Me.tdbcDefAssetAccountID.AutoDropDown = True
        Me.tdbcDefAssetAccountID.Caption = ""
        Me.tdbcDefAssetAccountID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDefAssetAccountID.ColumnWidth = 100
        Me.tdbcDefAssetAccountID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDefAssetAccountID.DisplayMember = "AccountID"
        Me.tdbcDefAssetAccountID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDefAssetAccountID.DropDownWidth = 500
        Me.tdbcDefAssetAccountID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDefAssetAccountID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDefAssetAccountID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDefAssetAccountID.EmptyRows = True
        Me.tdbcDefAssetAccountID.ExtendRightColumn = True
        Me.tdbcDefAssetAccountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDefAssetAccountID.Images.Add(CType(resources.GetObject("tdbcDefAssetAccountID.Images"), System.Drawing.Image))
        Me.tdbcDefAssetAccountID.Location = New System.Drawing.Point(127, 104)
        Me.tdbcDefAssetAccountID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDefAssetAccountID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDefAssetAccountID.MaxLength = 32767
        Me.tdbcDefAssetAccountID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDefAssetAccountID.Name = "tdbcDefAssetAccountID"
        Me.tdbcDefAssetAccountID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDefAssetAccountID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDefAssetAccountID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcDefAssetAccountID.TabIndex = 2
        Me.tdbcDefAssetAccountID.ValueMember = "AccountID"
        Me.tdbcDefAssetAccountID.PropBag = resources.GetString("tdbcDefAssetAccountID.PropBag")
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.Label1)
        Me.grp1.Controls.Add(Me.tdbcDivisionID)
        Me.grp1.Controls.Add(Me.txtDefaultPeriod)
        Me.grp1.Controls.Add(Me.lblDefaultPeriod)
        Me.grp1.Controls.Add(Me.txtPeriodNumber)
        Me.grp1.Controls.Add(Me.lblNumberPeriod)
        Me.grp1.Controls.Add(Me.txtDivisionName)
        Me.grp1.Location = New System.Drawing.Point(6, 6)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(564, 83)
        Me.grp1.TabIndex = 0
        Me.grp1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đơn vị mặc định"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcDivisionID
        '
        Me.tdbcDivisionID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDivisionID.AllowColMove = False
        Me.tdbcDivisionID.AllowSort = False
        Me.tdbcDivisionID.AlternatingRows = True
        Me.tdbcDivisionID.AutoCompletion = True
        Me.tdbcDivisionID.AutoDropDown = True
        Me.tdbcDivisionID.Caption = ""
        Me.tdbcDivisionID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDivisionID.ColumnWidth = 100
        Me.tdbcDivisionID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDivisionID.DisplayMember = "DivisionID"
        Me.tdbcDivisionID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDivisionID.DropDownWidth = 500
        Me.tdbcDivisionID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDivisionID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDivisionID.EmptyRows = True
        Me.tdbcDivisionID.ExtendRightColumn = True
        Me.tdbcDivisionID.FlatStyle = C1.Win.C1List.FlatModeEnum.Standard
        Me.tdbcDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.Images.Add(CType(resources.GetObject("tdbcDivisionID.Images"), System.Drawing.Image))
        Me.tdbcDivisionID.Location = New System.Drawing.Point(121, 19)
        Me.tdbcDivisionID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDivisionID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDivisionID.MaxLength = 32767
        Me.tdbcDivisionID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDivisionID.Name = "tdbcDivisionID"
        Me.tdbcDivisionID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDivisionID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDivisionID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcDivisionID.TabIndex = 1
        Me.tdbcDivisionID.ValueMember = "DivisionID"
        Me.tdbcDivisionID.PropBag = resources.GetString("tdbcDivisionID.PropBag")
        '
        'txtDefaultPeriod
        '
        Me.txtDefaultPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtDefaultPeriod.Location = New System.Drawing.Point(121, 47)
        Me.txtDefaultPeriod.Name = "txtDefaultPeriod"
        Me.txtDefaultPeriod.ReadOnly = True
        Me.txtDefaultPeriod.Size = New System.Drawing.Size(128, 20)
        Me.txtDefaultPeriod.TabIndex = 4
        '
        'lblDefaultPeriod
        '
        Me.lblDefaultPeriod.AutoSize = True
        Me.lblDefaultPeriod.Location = New System.Drawing.Point(6, 51)
        Me.lblDefaultPeriod.Name = "lblDefaultPeriod"
        Me.lblDefaultPeriod.Size = New System.Drawing.Size(66, 13)
        Me.lblDefaultPeriod.TabIndex = 3
        Me.lblDefaultPeriod.Text = "Kỳ mặc định"
        Me.lblDefaultPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPeriodNumber
        '
        Me.txtPeriodNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtPeriodNumber.Location = New System.Drawing.Point(421, 47)
        Me.txtPeriodNumber.Name = "txtPeriodNumber"
        Me.txtPeriodNumber.ReadOnly = True
        Me.txtPeriodNumber.Size = New System.Drawing.Size(124, 20)
        Me.txtPeriodNumber.TabIndex = 6
        Me.txtPeriodNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumberPeriod
        '
        Me.lblNumberPeriod.AutoSize = True
        Me.lblNumberPeriod.Location = New System.Drawing.Point(261, 51)
        Me.lblNumberPeriod.Name = "lblNumberPeriod"
        Me.lblNumberPeriod.Size = New System.Drawing.Size(73, 13)
        Me.lblNumberPeriod.TabIndex = 5
        Me.lblNumberPeriod.Text = "Số kỳ kế toán"
        Me.lblNumberPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDivisionName
        '
        Me.txtDivisionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDivisionName.Location = New System.Drawing.Point(255, 19)
        Me.txtDivisionName.Name = "txtDivisionName"
        Me.txtDivisionName.ReadOnly = True
        Me.txtDivisionName.Size = New System.Drawing.Size(290, 20)
        Me.txtDivisionName.TabIndex = 2
        Me.txtDivisionName.TabStop = False
        '
        'lblAssetAccountID
        '
        Me.lblAssetAccountID.AutoSize = True
        Me.lblAssetAccountID.Location = New System.Drawing.Point(5, 109)
        Me.lblAssetAccountID.Name = "lblAssetAccountID"
        Me.lblAssetAccountID.Size = New System.Drawing.Size(55, 13)
        Me.lblAssetAccountID.TabIndex = 1
        Me.lblAssetAccountID.Text = "TK tài sản"
        Me.lblAssetAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSourceID
        '
        Me.lblSourceID.AutoSize = True
        Me.lblSourceID.Location = New System.Drawing.Point(5, 167)
        Me.lblSourceID.Name = "lblSourceID"
        Me.lblSourceID.Size = New System.Drawing.Size(60, 13)
        Me.lblSourceID.TabIndex = 5
        Me.lblSourceID.Text = "Nguồn vốn"
        Me.lblSourceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAssignmentID
        '
        Me.lblAssignmentID.AutoSize = True
        Me.lblAssignmentID.Location = New System.Drawing.Point(261, 109)
        Me.lblAssignmentID.Name = "lblAssignmentID"
        Me.lblAssignmentID.Size = New System.Drawing.Size(65, 13)
        Me.lblAssignmentID.TabIndex = 7
        Me.lblAssignmentID.Text = "Phân bổ KH"
        Me.lblAssignmentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMethodID
        '
        Me.lblMethodID.AutoSize = True
        Me.lblMethodID.Location = New System.Drawing.Point(261, 138)
        Me.lblMethodID.Name = "lblMethodID"
        Me.lblMethodID.Size = New System.Drawing.Size(89, 13)
        Me.lblMethodID.TabIndex = 9
        Me.lblMethodID.Text = "Phương pháp KH"
        Me.lblMethodID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMethodEndID
        '
        Me.lblMethodEndID.AutoSize = True
        Me.lblMethodEndID.Location = New System.Drawing.Point(261, 167)
        Me.lblMethodEndID.Name = "lblMethodEndID"
        Me.lblMethodEndID.Size = New System.Drawing.Size(85, 13)
        Me.lblMethodEndID.TabIndex = 11
        Me.lblMethodEndID.Text = "Xử lý KH kỳ cuối"
        Me.lblMethodEndID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkIsAssetIDForD02D43)
        Me.TabPage2.Controls.Add(Me.chkAssetAuto)
        Me.TabPage2.Controls.Add(Me.txtCheckAssetOutputLength)
        Me.TabPage2.Controls.Add(Me.chkCheckAssetOutputLength)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(576, 328)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tạo mã TSCĐ tự động"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkIsAssetIDForD02D43
        '
        Me.chkIsAssetIDForD02D43.AutoSize = True
        Me.chkIsAssetIDForD02D43.Location = New System.Drawing.Point(244, 282)
        Me.chkIsAssetIDForD02D43.Name = "chkIsAssetIDForD02D43"
        Me.chkIsAssetIDForD02D43.Size = New System.Drawing.Size(198, 17)
        Me.chkIsAssetIDForD02D43.TabIndex = 7
        Me.chkIsAssetIDForD02D43.Text = "Mã TSCĐ và mã CCDC tăng liên tục"
        Me.chkIsAssetIDForD02D43.UseVisualStyleBackColor = True
        '
        'chkAssetAuto
        '
        Me.chkAssetAuto.AutoSize = True
        Me.chkAssetAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAssetAuto.Location = New System.Drawing.Point(18, 7)
        Me.chkAssetAuto.Name = "chkAssetAuto"
        Me.chkAssetAuto.Size = New System.Drawing.Size(196, 17)
        Me.chkAssetAuto.TabIndex = 1
        Me.chkAssetAuto.Text = "Tạo mã tự động cho tài sản cố định"
        Me.chkAssetAuto.UseVisualStyleBackColor = True
        '
        'txtCheckAssetOutputLength
        '
        Me.txtCheckAssetOutputLength.Location = New System.Drawing.Point(174, 280)
        Me.txtCheckAssetOutputLength.Name = "txtCheckAssetOutputLength"
        Me.txtCheckAssetOutputLength.Size = New System.Drawing.Size(55, 20)
        Me.txtCheckAssetOutputLength.TabIndex = 5
        Me.txtCheckAssetOutputLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkCheckAssetOutputLength
        '
        Me.chkCheckAssetOutputLength.AutoSize = True
        Me.chkCheckAssetOutputLength.Location = New System.Drawing.Point(14, 283)
        Me.chkCheckAssetOutputLength.Name = "chkCheckAssetOutputLength"
        Me.chkCheckAssetOutputLength.Size = New System.Drawing.Size(148, 17)
        Me.chkCheckAssetOutputLength.TabIndex = 4
        Me.chkCheckAssetOutputLength.Text = "Kiểm tra độ dài mã tài sản"
        Me.chkCheckAssetOutputLength.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpIGE)
        Me.GroupBox1.Controls.Add(Me.optAssetAuto2)
        Me.GroupBox1.Controls.Add(Me.optAssetAuto1)
        Me.GroupBox1.Controls.Add(Me.lblCaptionExample)
        Me.GroupBox1.Controls.Add(Me.grpAutoAssetNumbering)
        Me.GroupBox1.Controls.Add(Me.lblExample)
        Me.GroupBox1.Controls.Add(Me.grpAssetCategories)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'grpIGE
        '
        Me.grpIGE.Controls.Add(Me.optShowFormAotuCreate1)
        Me.grpIGE.Controls.Add(Me.optShowFormAotuCreate0)
        Me.grpIGE.Enabled = False
        Me.grpIGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpIGE.Location = New System.Drawing.Point(8, 216)
        Me.grpIGE.Name = "grpIGE"
        Me.grpIGE.Size = New System.Drawing.Size(540, 38)
        Me.grpIGE.TabIndex = 4
        Me.grpIGE.TabStop = False
        Me.grpIGE.Text = "Hiển thị"
        '
        'optShowFormAotuCreate1
        '
        Me.optShowFormAotuCreate1.AutoSize = True
        Me.optShowFormAotuCreate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.optShowFormAotuCreate1.Location = New System.Drawing.Point(303, 14)
        Me.optShowFormAotuCreate1.Name = "optShowFormAotuCreate1"
        Me.optShowFormAotuCreate1.Size = New System.Drawing.Size(182, 17)
        Me.optShowFormAotuCreate1.TabIndex = 1
        Me.optShowFormAotuCreate1.TabStop = True
        Me.optShowFormAotuCreate1.Text = "Hiển thị màn hình tạo mã tự động"
        Me.optShowFormAotuCreate1.UseVisualStyleBackColor = True
        '
        'optShowFormAotuCreate0
        '
        Me.optShowFormAotuCreate0.AutoSize = True
        Me.optShowFormAotuCreate0.Checked = True
        Me.optShowFormAotuCreate0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.optShowFormAotuCreate0.Location = New System.Drawing.Point(19, 14)
        Me.optShowFormAotuCreate0.Name = "optShowFormAotuCreate0"
        Me.optShowFormAotuCreate0.Size = New System.Drawing.Size(214, 17)
        Me.optShowFormAotuCreate0.TabIndex = 0
        Me.optShowFormAotuCreate0.TabStop = True
        Me.optShowFormAotuCreate0.Text = "Không hiển thị màn hình tạo mã tự động"
        Me.optShowFormAotuCreate0.UseVisualStyleBackColor = True
        '
        'optAssetAuto2
        '
        Me.optAssetAuto2.AutoSize = True
        Me.optAssetAuto2.Location = New System.Drawing.Point(18, 196)
        Me.optAssetAuto2.Name = "optAssetAuto2"
        Me.optAssetAuto2.Size = New System.Drawing.Size(191, 17)
        Me.optAssetAuto2.TabIndex = 3
        Me.optAssetAuto2.TabStop = True
        Me.optAssetAuto2.Text = "Chọn phương pháp tạo mã tự động"
        Me.optAssetAuto2.UseVisualStyleBackColor = True
        '
        'optAssetAuto1
        '
        Me.optAssetAuto1.AutoSize = True
        Me.optAssetAuto1.Location = New System.Drawing.Point(15, 19)
        Me.optAssetAuto1.Name = "optAssetAuto1"
        Me.optAssetAuto1.Size = New System.Drawing.Size(113, 17)
        Me.optAssetAuto1.TabIndex = 0
        Me.optAssetAuto1.TabStop = True
        Me.optAssetAuto1.Text = "Chọn mã phân loại"
        Me.optAssetAuto1.UseVisualStyleBackColor = True
        '
        'lblCaptionExample
        '
        Me.lblCaptionExample.AutoSize = True
        Me.lblCaptionExample.Location = New System.Drawing.Point(299, 21)
        Me.lblCaptionExample.Name = "lblCaptionExample"
        Me.lblCaptionExample.Size = New System.Drawing.Size(36, 13)
        Me.lblCaptionExample.TabIndex = 1
        Me.lblCaptionExample.Text = "Ví dụ:"
        Me.lblCaptionExample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpAutoAssetNumbering
        '
        Me.grpAutoAssetNumbering.Controls.Add(Me.txtAssetOutputLength)
        Me.grpAutoAssetNumbering.Controls.Add(Me.tdbcAssetSeperator)
        Me.grpAutoAssetNumbering.Controls.Add(Me.lblAssetOutputLength)
        Me.grpAutoAssetNumbering.Controls.Add(Me.lblAutoNumberLength)
        Me.grpAutoAssetNumbering.Controls.Add(Me.updownAutoNumberLength)
        Me.grpAutoAssetNumbering.Controls.Add(Me.cboAssetOutputOrder)
        Me.grpAutoAssetNumbering.Controls.Add(Me.chkAssetSeperated)
        Me.grpAutoAssetNumbering.Controls.Add(Me.lblAssetOutputOrder)
        Me.grpAutoAssetNumbering.Enabled = False
        Me.grpAutoAssetNumbering.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAutoAssetNumbering.Location = New System.Drawing.Point(305, 51)
        Me.grpAutoAssetNumbering.Name = "grpAutoAssetNumbering"
        Me.grpAutoAssetNumbering.Size = New System.Drawing.Size(243, 139)
        Me.grpAutoAssetNumbering.TabIndex = 3
        Me.grpAutoAssetNumbering.TabStop = False
        Me.grpAutoAssetNumbering.Text = "Định dạng mã tự động"
        '
        'txtAssetOutputLength
        '
        Me.txtAssetOutputLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtAssetOutputLength.Location = New System.Drawing.Point(114, 102)
        Me.txtAssetOutputLength.Name = "txtAssetOutputLength"
        Me.txtAssetOutputLength.ReadOnly = True
        Me.txtAssetOutputLength.Size = New System.Drawing.Size(123, 20)
        Me.txtAssetOutputLength.TabIndex = 7
        Me.txtAssetOutputLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tdbcAssetSeperator
        '
        Me.tdbcAssetSeperator.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcAssetSeperator.AllowColMove = False
        Me.tdbcAssetSeperator.AllowSort = False
        Me.tdbcAssetSeperator.AlternatingRows = True
        Me.tdbcAssetSeperator.AutoCompletion = True
        Me.tdbcAssetSeperator.AutoDropDown = True
        Me.tdbcAssetSeperator.Caption = ""
        Me.tdbcAssetSeperator.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcAssetSeperator.ColumnHeaders = False
        Me.tdbcAssetSeperator.ColumnWidth = 100
        Me.tdbcAssetSeperator.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcAssetSeperator.DisplayMember = "AssetSeperatorName"
        Me.tdbcAssetSeperator.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcAssetSeperator.DropDownWidth = 125
        Me.tdbcAssetSeperator.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcAssetSeperator.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetSeperator.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcAssetSeperator.EmptyRows = True
        Me.tdbcAssetSeperator.ExtendRightColumn = True
        Me.tdbcAssetSeperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetSeperator.Images.Add(CType(resources.GetObject("tdbcAssetSeperator.Images"), System.Drawing.Image))
        Me.tdbcAssetSeperator.Location = New System.Drawing.Point(114, 20)
        Me.tdbcAssetSeperator.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcAssetSeperator.MaxDropDownItems = CType(8, Short)
        Me.tdbcAssetSeperator.MaxLength = 32767
        Me.tdbcAssetSeperator.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcAssetSeperator.Name = "tdbcAssetSeperator"
        Me.tdbcAssetSeperator.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcAssetSeperator.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcAssetSeperator.Size = New System.Drawing.Size(123, 21)
        Me.tdbcAssetSeperator.TabIndex = 1
        Me.tdbcAssetSeperator.ValueMember = "AssetSeperatorID"
        Me.tdbcAssetSeperator.PropBag = resources.GetString("tdbcAssetSeperator.PropBag")
        '
        'lblAssetOutputLength
        '
        Me.lblAssetOutputLength.AutoSize = True
        Me.lblAssetOutputLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssetOutputLength.Location = New System.Drawing.Point(26, 106)
        Me.lblAssetOutputLength.Name = "lblAssetOutputLength"
        Me.lblAssetOutputLength.Size = New System.Drawing.Size(55, 13)
        Me.lblAssetOutputLength.TabIndex = 6
        Me.lblAssetOutputLength.Text = "Độ dài mã"
        Me.lblAssetOutputLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAutoNumberLength
        '
        Me.lblAutoNumberLength.AutoSize = True
        Me.lblAutoNumberLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutoNumberLength.Location = New System.Drawing.Point(26, 80)
        Me.lblAutoNumberLength.Name = "lblAutoNumberLength"
        Me.lblAutoNumberLength.Size = New System.Drawing.Size(52, 13)
        Me.lblAutoNumberLength.TabIndex = 4
        Me.lblAutoNumberLength.Text = "Độ dài số"
        Me.lblAutoNumberLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'updownAutoNumberLength
        '
        Me.updownAutoNumberLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updownAutoNumberLength.Location = New System.Drawing.Point(114, 76)
        Me.updownAutoNumberLength.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.updownAutoNumberLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updownAutoNumberLength.Name = "updownAutoNumberLength"
        Me.updownAutoNumberLength.Size = New System.Drawing.Size(123, 20)
        Me.updownAutoNumberLength.TabIndex = 5
        Me.updownAutoNumberLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.updownAutoNumberLength.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cboAssetOutputOrder
        '
        Me.cboAssetOutputOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssetOutputOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.cboAssetOutputOrder.FormattingEnabled = True
        Me.cboAssetOutputOrder.Location = New System.Drawing.Point(114, 49)
        Me.cboAssetOutputOrder.Name = "cboAssetOutputOrder"
        Me.cboAssetOutputOrder.Size = New System.Drawing.Size(123, 21)
        Me.cboAssetOutputOrder.TabIndex = 3
        '
        'chkAssetSeperated
        '
        Me.chkAssetSeperated.AutoSize = True
        Me.chkAssetSeperated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAssetSeperated.Location = New System.Drawing.Point(6, 25)
        Me.chkAssetSeperated.Name = "chkAssetSeperated"
        Me.chkAssetSeperated.Size = New System.Drawing.Size(100, 17)
        Me.chkAssetSeperated.TabIndex = 0
        Me.chkAssetSeperated.Text = "Dấu phân cách"
        Me.chkAssetSeperated.UseVisualStyleBackColor = True
        '
        'lblAssetOutputOrder
        '
        Me.lblAssetOutputOrder.AutoSize = True
        Me.lblAssetOutputOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssetOutputOrder.Location = New System.Drawing.Point(26, 53)
        Me.lblAssetOutputOrder.Name = "lblAssetOutputOrder"
        Me.lblAssetOutputOrder.Size = New System.Drawing.Size(70, 13)
        Me.lblAssetOutputOrder.TabIndex = 2
        Me.lblAssetOutputOrder.Text = "Dạng hiển thị"
        Me.lblAssetOutputOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblExample
        '
        Me.lblExample.AutoSize = True
        Me.lblExample.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExample.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblExample.Location = New System.Drawing.Point(348, 21)
        Me.lblExample.Name = "lblExample"
        Me.lblExample.Size = New System.Drawing.Size(35, 13)
        Me.lblExample.TabIndex = 2
        Me.lblExample.Text = "XXXX"
        Me.lblExample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpAssetCategories
        '
        Me.grpAssetCategories.Controls.Add(Me.tdbcAssetS3Default)
        Me.grpAssetCategories.Controls.Add(Me.tdbcAssetS2Default)
        Me.grpAssetCategories.Controls.Add(Me.chkAssetS3Enabled)
        Me.grpAssetCategories.Controls.Add(Me.chkAssetS2Enabled)
        Me.grpAssetCategories.Controls.Add(Me.tdbcAssetS1Default)
        Me.grpAssetCategories.Controls.Add(Me.chkAssetS1Enabled)
        Me.grpAssetCategories.Controls.Add(Me.txtS1Length)
        Me.grpAssetCategories.Controls.Add(Me.txtS2Length)
        Me.grpAssetCategories.Controls.Add(Me.txtS3Length)
        Me.grpAssetCategories.Enabled = False
        Me.grpAssetCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAssetCategories.Location = New System.Drawing.Point(8, 51)
        Me.grpAssetCategories.Name = "grpAssetCategories"
        Me.grpAssetCategories.Size = New System.Drawing.Size(284, 139)
        Me.grpAssetCategories.TabIndex = 2
        Me.grpAssetCategories.TabStop = False
        Me.grpAssetCategories.Text = "Mã phân loại TSCĐ"
        '
        'tdbcAssetS3Default
        '
        Me.tdbcAssetS3Default.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcAssetS3Default.AllowColMove = False
        Me.tdbcAssetS3Default.AllowSort = False
        Me.tdbcAssetS3Default.AlternatingRows = True
        Me.tdbcAssetS3Default.AutoCompletion = True
        Me.tdbcAssetS3Default.AutoDropDown = True
        Me.tdbcAssetS3Default.Caption = ""
        Me.tdbcAssetS3Default.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcAssetS3Default.ColumnWidth = 100
        Me.tdbcAssetS3Default.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcAssetS3Default.DisplayMember = "AssetS3ID"
        Me.tdbcAssetS3Default.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcAssetS3Default.DropDownWidth = 400
        Me.tdbcAssetS3Default.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcAssetS3Default.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetS3Default.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcAssetS3Default.EmptyRows = True
        Me.tdbcAssetS3Default.ExtendRightColumn = True
        Me.tdbcAssetS3Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetS3Default.Images.Add(CType(resources.GetObject("tdbcAssetS3Default.Images"), System.Drawing.Image))
        Me.tdbcAssetS3Default.Location = New System.Drawing.Point(110, 76)
        Me.tdbcAssetS3Default.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcAssetS3Default.MaxDropDownItems = CType(8, Short)
        Me.tdbcAssetS3Default.MaxLength = 32767
        Me.tdbcAssetS3Default.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcAssetS3Default.Name = "tdbcAssetS3Default"
        Me.tdbcAssetS3Default.ReadOnly = True
        Me.tdbcAssetS3Default.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcAssetS3Default.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcAssetS3Default.Size = New System.Drawing.Size(101, 21)
        Me.tdbcAssetS3Default.TabIndex = 7
        Me.tdbcAssetS3Default.ValueMember = "AssetS3ID"
        Me.tdbcAssetS3Default.PropBag = resources.GetString("tdbcAssetS3Default.PropBag")
        '
        'tdbcAssetS2Default
        '
        Me.tdbcAssetS2Default.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcAssetS2Default.AllowColMove = False
        Me.tdbcAssetS2Default.AllowSort = False
        Me.tdbcAssetS2Default.AlternatingRows = True
        Me.tdbcAssetS2Default.AutoCompletion = True
        Me.tdbcAssetS2Default.AutoDropDown = True
        Me.tdbcAssetS2Default.Caption = ""
        Me.tdbcAssetS2Default.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcAssetS2Default.ColumnWidth = 100
        Me.tdbcAssetS2Default.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcAssetS2Default.DisplayMember = "AssetS2ID"
        Me.tdbcAssetS2Default.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcAssetS2Default.DropDownWidth = 400
        Me.tdbcAssetS2Default.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcAssetS2Default.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetS2Default.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcAssetS2Default.EmptyRows = True
        Me.tdbcAssetS2Default.ExtendRightColumn = True
        Me.tdbcAssetS2Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetS2Default.Images.Add(CType(resources.GetObject("tdbcAssetS2Default.Images"), System.Drawing.Image))
        Me.tdbcAssetS2Default.Location = New System.Drawing.Point(110, 47)
        Me.tdbcAssetS2Default.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcAssetS2Default.MaxDropDownItems = CType(8, Short)
        Me.tdbcAssetS2Default.MaxLength = 32767
        Me.tdbcAssetS2Default.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcAssetS2Default.Name = "tdbcAssetS2Default"
        Me.tdbcAssetS2Default.ReadOnly = True
        Me.tdbcAssetS2Default.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcAssetS2Default.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcAssetS2Default.Size = New System.Drawing.Size(101, 21)
        Me.tdbcAssetS2Default.TabIndex = 4
        Me.tdbcAssetS2Default.ValueMember = "AssetS2ID"
        Me.tdbcAssetS2Default.PropBag = resources.GetString("tdbcAssetS2Default.PropBag")
        '
        'chkAssetS3Enabled
        '
        Me.chkAssetS3Enabled.AutoSize = True
        Me.chkAssetS3Enabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAssetS3Enabled.Location = New System.Drawing.Point(11, 82)
        Me.chkAssetS3Enabled.Name = "chkAssetS3Enabled"
        Me.chkAssetS3Enabled.Size = New System.Drawing.Size(70, 17)
        Me.chkAssetS3Enabled.TabIndex = 6
        Me.chkAssetS3Enabled.Text = "Phân loại"
        Me.chkAssetS3Enabled.UseVisualStyleBackColor = True
        '
        'chkAssetS2Enabled
        '
        Me.chkAssetS2Enabled.AutoSize = True
        Me.chkAssetS2Enabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAssetS2Enabled.Location = New System.Drawing.Point(11, 53)
        Me.chkAssetS2Enabled.Name = "chkAssetS2Enabled"
        Me.chkAssetS2Enabled.Size = New System.Drawing.Size(70, 17)
        Me.chkAssetS2Enabled.TabIndex = 3
        Me.chkAssetS2Enabled.Text = "Phân loại"
        Me.chkAssetS2Enabled.UseVisualStyleBackColor = True
        '
        'tdbcAssetS1Default
        '
        Me.tdbcAssetS1Default.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcAssetS1Default.AllowColMove = False
        Me.tdbcAssetS1Default.AllowSort = False
        Me.tdbcAssetS1Default.AlternatingRows = True
        Me.tdbcAssetS1Default.AutoCompletion = True
        Me.tdbcAssetS1Default.AutoDropDown = True
        Me.tdbcAssetS1Default.Caption = ""
        Me.tdbcAssetS1Default.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcAssetS1Default.ColumnWidth = 100
        Me.tdbcAssetS1Default.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcAssetS1Default.DisplayMember = "AssetS1ID"
        Me.tdbcAssetS1Default.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcAssetS1Default.DropDownWidth = 400
        Me.tdbcAssetS1Default.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcAssetS1Default.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetS1Default.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcAssetS1Default.EmptyRows = True
        Me.tdbcAssetS1Default.ExtendRightColumn = True
        Me.tdbcAssetS1Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetS1Default.Images.Add(CType(resources.GetObject("tdbcAssetS1Default.Images"), System.Drawing.Image))
        Me.tdbcAssetS1Default.Location = New System.Drawing.Point(109, 18)
        Me.tdbcAssetS1Default.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcAssetS1Default.MaxDropDownItems = CType(8, Short)
        Me.tdbcAssetS1Default.MaxLength = 32767
        Me.tdbcAssetS1Default.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcAssetS1Default.Name = "tdbcAssetS1Default"
        Me.tdbcAssetS1Default.ReadOnly = True
        Me.tdbcAssetS1Default.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcAssetS1Default.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcAssetS1Default.Size = New System.Drawing.Size(102, 21)
        Me.tdbcAssetS1Default.TabIndex = 1
        Me.tdbcAssetS1Default.ValueMember = "AssetS1ID"
        Me.tdbcAssetS1Default.PropBag = resources.GetString("tdbcAssetS1Default.PropBag")
        '
        'chkAssetS1Enabled
        '
        Me.chkAssetS1Enabled.AutoSize = True
        Me.chkAssetS1Enabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAssetS1Enabled.Location = New System.Drawing.Point(11, 24)
        Me.chkAssetS1Enabled.Name = "chkAssetS1Enabled"
        Me.chkAssetS1Enabled.Size = New System.Drawing.Size(70, 17)
        Me.chkAssetS1Enabled.TabIndex = 0
        Me.chkAssetS1Enabled.Text = "Phân loại"
        Me.chkAssetS1Enabled.UseVisualStyleBackColor = True
        '
        'txtS1Length
        '
        Me.txtS1Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtS1Length.Location = New System.Drawing.Point(217, 18)
        Me.txtS1Length.MaxLength = 2
        Me.txtS1Length.Name = "txtS1Length"
        Me.txtS1Length.ReadOnly = True
        Me.txtS1Length.Size = New System.Drawing.Size(55, 20)
        Me.txtS1Length.TabIndex = 2
        Me.txtS1Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtS2Length
        '
        Me.txtS2Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtS2Length.Location = New System.Drawing.Point(217, 47)
        Me.txtS2Length.MaxLength = 2
        Me.txtS2Length.Name = "txtS2Length"
        Me.txtS2Length.ReadOnly = True
        Me.txtS2Length.Size = New System.Drawing.Size(55, 20)
        Me.txtS2Length.TabIndex = 5
        Me.txtS2Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtS3Length
        '
        Me.txtS3Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtS3Length.Location = New System.Drawing.Point(217, 76)
        Me.txtS3Length.MaxLength = 2
        Me.txtS3Length.Name = "txtS3Length"
        Me.txtS3Length.ReadOnly = True
        Me.txtS3Length.Size = New System.Drawing.Size(55, 20)
        Me.txtS3Length.TabIndex = 8
        Me.txtS3Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkUseBudgetForCIP)
        Me.TabPage3.Controls.Add(Me.chkUseD54ForCIP)
        Me.TabPage3.Controls.Add(Me.chkCIPAuto)
        Me.TabPage3.Controls.Add(Me.txtCIPCheckOutputLength)
        Me.TabPage3.Controls.Add(Me.chkCIPCheckOutputLength)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(576, 328)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tạo mã XDCB tự động"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkUseBudgetForCIP
        '
        Me.chkUseBudgetForCIP.AutoSize = True
        Me.chkUseBudgetForCIP.Location = New System.Drawing.Point(18, 290)
        Me.chkUseBudgetForCIP.Name = "chkUseBudgetForCIP"
        Me.chkUseBudgetForCIP.Size = New System.Drawing.Size(163, 17)
        Me.chkUseBudgetForCIP.TabIndex = 5
        Me.chkUseBudgetForCIP.Text = "Tập hợp XDCB từ ngân sách"
        Me.chkUseBudgetForCIP.UseVisualStyleBackColor = True
        '
        'chkUseD54ForCIP
        '
        Me.chkUseD54ForCIP.AutoSize = True
        Me.chkUseD54ForCIP.Location = New System.Drawing.Point(18, 265)
        Me.chkUseD54ForCIP.Name = "chkUseD54ForCIP"
        Me.chkUseD54ForCIP.Size = New System.Drawing.Size(140, 17)
        Me.chkUseD54ForCIP.TabIndex = 4
        Me.chkUseD54ForCIP.Text = "Tập hợp XDCB từ dự án"
        Me.chkUseD54ForCIP.UseVisualStyleBackColor = True
        '
        'chkCIPAuto
        '
        Me.chkCIPAuto.AutoSize = True
        Me.chkCIPAuto.Location = New System.Drawing.Point(18, 4)
        Me.chkCIPAuto.Name = "chkCIPAuto"
        Me.chkCIPAuto.Size = New System.Drawing.Size(134, 17)
        Me.chkCIPAuto.TabIndex = 1
        Me.chkCIPAuto.Text = "Tạo mã XDCB tự động"
        Me.chkCIPAuto.UseVisualStyleBackColor = True
        '
        'txtCIPCheckOutputLength
        '
        Me.txtCIPCheckOutputLength.Location = New System.Drawing.Point(178, 237)
        Me.txtCIPCheckOutputLength.Name = "txtCIPCheckOutputLength"
        Me.txtCIPCheckOutputLength.Size = New System.Drawing.Size(55, 20)
        Me.txtCIPCheckOutputLength.TabIndex = 3
        Me.txtCIPCheckOutputLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkCIPCheckOutputLength
        '
        Me.chkCIPCheckOutputLength.AutoSize = True
        Me.chkCIPCheckOutputLength.Location = New System.Drawing.Point(18, 240)
        Me.chkCIPCheckOutputLength.Name = "chkCIPCheckOutputLength"
        Me.chkCIPCheckOutputLength.Size = New System.Drawing.Size(146, 17)
        Me.chkCIPCheckOutputLength.TabIndex = 2
        Me.chkCIPCheckOutputLength.Text = "Kiểm tra độ dài mã XDCB"
        Me.chkCIPCheckOutputLength.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optCIPAuto2)
        Me.GroupBox2.Controls.Add(Me.optCIPAuto1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.grpAutoCIPNumbering)
        Me.GroupBox2.Controls.Add(Me.lblCIPExample)
        Me.GroupBox2.Controls.Add(Me.grpCIPCategories)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 224)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'optCIPAuto2
        '
        Me.optCIPAuto2.AutoSize = True
        Me.optCIPAuto2.Location = New System.Drawing.Point(22, 196)
        Me.optCIPAuto2.Name = "optCIPAuto2"
        Me.optCIPAuto2.Size = New System.Drawing.Size(191, 17)
        Me.optCIPAuto2.TabIndex = 5
        Me.optCIPAuto2.TabStop = True
        Me.optCIPAuto2.Text = "Chọn phương pháp tạo mã tự động"
        Me.optCIPAuto2.UseVisualStyleBackColor = True
        '
        'optCIPAuto1
        '
        Me.optCIPAuto1.AutoSize = True
        Me.optCIPAuto1.Location = New System.Drawing.Point(19, 25)
        Me.optCIPAuto1.Name = "optCIPAuto1"
        Me.optCIPAuto1.Size = New System.Drawing.Size(113, 17)
        Me.optCIPAuto1.TabIndex = 0
        Me.optCIPAuto1.TabStop = True
        Me.optCIPAuto1.Text = "Chọn mã phân loại"
        Me.optCIPAuto1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ví dụ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpAutoCIPNumbering
        '
        Me.grpAutoCIPNumbering.Controls.Add(Me.tdbcCIPSeperator)
        Me.grpAutoCIPNumbering.Controls.Add(Me.txtCIPOutputLength)
        Me.grpAutoCIPNumbering.Controls.Add(Me.lblCIPOutputLength)
        Me.grpAutoCIPNumbering.Controls.Add(Me.lblCIPAutoNumberLength)
        Me.grpAutoCIPNumbering.Controls.Add(Me.updownCIPAutoNumberLength)
        Me.grpAutoCIPNumbering.Controls.Add(Me.cboCIPOutputOrder)
        Me.grpAutoCIPNumbering.Controls.Add(Me.chkCIPSeperated)
        Me.grpAutoCIPNumbering.Controls.Add(Me.lblCIPOutputOrder)
        Me.grpAutoCIPNumbering.Enabled = False
        Me.grpAutoCIPNumbering.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAutoCIPNumbering.Location = New System.Drawing.Point(305, 51)
        Me.grpAutoCIPNumbering.Name = "grpAutoCIPNumbering"
        Me.grpAutoCIPNumbering.Size = New System.Drawing.Size(243, 139)
        Me.grpAutoCIPNumbering.TabIndex = 4
        Me.grpAutoCIPNumbering.TabStop = False
        Me.grpAutoCIPNumbering.Text = "Định dạng mã tự động"
        '
        'tdbcCIPSeperator
        '
        Me.tdbcCIPSeperator.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcCIPSeperator.AllowColMove = False
        Me.tdbcCIPSeperator.AllowSort = False
        Me.tdbcCIPSeperator.AlternatingRows = True
        Me.tdbcCIPSeperator.AutoCompletion = True
        Me.tdbcCIPSeperator.AutoDropDown = True
        Me.tdbcCIPSeperator.Caption = ""
        Me.tdbcCIPSeperator.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcCIPSeperator.ColumnHeaders = False
        Me.tdbcCIPSeperator.ColumnWidth = 100
        Me.tdbcCIPSeperator.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcCIPSeperator.DisplayMember = "AssetSeperatorName"
        Me.tdbcCIPSeperator.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcCIPSeperator.DropDownWidth = 125
        Me.tdbcCIPSeperator.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcCIPSeperator.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCIPSeperator.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcCIPSeperator.EmptyRows = True
        Me.tdbcCIPSeperator.ExtendRightColumn = True
        Me.tdbcCIPSeperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCIPSeperator.Images.Add(CType(resources.GetObject("tdbcCIPSeperator.Images"), System.Drawing.Image))
        Me.tdbcCIPSeperator.Location = New System.Drawing.Point(114, 20)
        Me.tdbcCIPSeperator.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcCIPSeperator.MaxDropDownItems = CType(8, Short)
        Me.tdbcCIPSeperator.MaxLength = 32767
        Me.tdbcCIPSeperator.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcCIPSeperator.Name = "tdbcCIPSeperator"
        Me.tdbcCIPSeperator.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcCIPSeperator.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcCIPSeperator.Size = New System.Drawing.Size(125, 21)
        Me.tdbcCIPSeperator.TabIndex = 1
        Me.tdbcCIPSeperator.ValueMember = "AssetSeperatorID"
        Me.tdbcCIPSeperator.PropBag = resources.GetString("tdbcCIPSeperator.PropBag")
        '
        'txtCIPOutputLength
        '
        Me.txtCIPOutputLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtCIPOutputLength.Location = New System.Drawing.Point(114, 102)
        Me.txtCIPOutputLength.Name = "txtCIPOutputLength"
        Me.txtCIPOutputLength.ReadOnly = True
        Me.txtCIPOutputLength.Size = New System.Drawing.Size(123, 20)
        Me.txtCIPOutputLength.TabIndex = 7
        Me.txtCIPOutputLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCIPOutputLength
        '
        Me.lblCIPOutputLength.AutoSize = True
        Me.lblCIPOutputLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIPOutputLength.Location = New System.Drawing.Point(26, 106)
        Me.lblCIPOutputLength.Name = "lblCIPOutputLength"
        Me.lblCIPOutputLength.Size = New System.Drawing.Size(55, 13)
        Me.lblCIPOutputLength.TabIndex = 6
        Me.lblCIPOutputLength.Text = "Độ dài mã"
        Me.lblCIPOutputLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCIPAutoNumberLength
        '
        Me.lblCIPAutoNumberLength.AutoSize = True
        Me.lblCIPAutoNumberLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIPAutoNumberLength.Location = New System.Drawing.Point(26, 80)
        Me.lblCIPAutoNumberLength.Name = "lblCIPAutoNumberLength"
        Me.lblCIPAutoNumberLength.Size = New System.Drawing.Size(52, 13)
        Me.lblCIPAutoNumberLength.TabIndex = 4
        Me.lblCIPAutoNumberLength.Text = "Độ dài số"
        Me.lblCIPAutoNumberLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'updownCIPAutoNumberLength
        '
        Me.updownCIPAutoNumberLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updownCIPAutoNumberLength.Location = New System.Drawing.Point(114, 76)
        Me.updownCIPAutoNumberLength.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.updownCIPAutoNumberLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updownCIPAutoNumberLength.Name = "updownCIPAutoNumberLength"
        Me.updownCIPAutoNumberLength.Size = New System.Drawing.Size(123, 20)
        Me.updownCIPAutoNumberLength.TabIndex = 5
        Me.updownCIPAutoNumberLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.updownCIPAutoNumberLength.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cboCIPOutputOrder
        '
        Me.cboCIPOutputOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCIPOutputOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.cboCIPOutputOrder.FormattingEnabled = True
        Me.cboCIPOutputOrder.Location = New System.Drawing.Point(114, 49)
        Me.cboCIPOutputOrder.Name = "cboCIPOutputOrder"
        Me.cboCIPOutputOrder.Size = New System.Drawing.Size(123, 21)
        Me.cboCIPOutputOrder.TabIndex = 3
        '
        'chkCIPSeperated
        '
        Me.chkCIPSeperated.AutoSize = True
        Me.chkCIPSeperated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCIPSeperated.Location = New System.Drawing.Point(6, 25)
        Me.chkCIPSeperated.Name = "chkCIPSeperated"
        Me.chkCIPSeperated.Size = New System.Drawing.Size(100, 17)
        Me.chkCIPSeperated.TabIndex = 0
        Me.chkCIPSeperated.Text = "Dấu phân cách"
        Me.chkCIPSeperated.UseVisualStyleBackColor = True
        '
        'lblCIPOutputOrder
        '
        Me.lblCIPOutputOrder.AutoSize = True
        Me.lblCIPOutputOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIPOutputOrder.Location = New System.Drawing.Point(26, 53)
        Me.lblCIPOutputOrder.Name = "lblCIPOutputOrder"
        Me.lblCIPOutputOrder.Size = New System.Drawing.Size(70, 13)
        Me.lblCIPOutputOrder.TabIndex = 2
        Me.lblCIPOutputOrder.Text = "Dạng hiển thị"
        Me.lblCIPOutputOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCIPExample
        '
        Me.lblCIPExample.AutoSize = True
        Me.lblCIPExample.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIPExample.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCIPExample.Location = New System.Drawing.Point(348, 21)
        Me.lblCIPExample.Name = "lblCIPExample"
        Me.lblCIPExample.Size = New System.Drawing.Size(35, 13)
        Me.lblCIPExample.TabIndex = 2
        Me.lblCIPExample.Text = "XXXX"
        Me.lblCIPExample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpCIPCategories
        '
        Me.grpCIPCategories.Controls.Add(Me.tdbcCIPS3Default)
        Me.grpCIPCategories.Controls.Add(Me.tdbcCIPS1Default)
        Me.grpCIPCategories.Controls.Add(Me.tdbcCIPS2Default)
        Me.grpCIPCategories.Controls.Add(Me.chkCIPS3Enabled)
        Me.grpCIPCategories.Controls.Add(Me.chkCIPS2Enabled)
        Me.grpCIPCategories.Controls.Add(Me.chkCIPS1Enabled)
        Me.grpCIPCategories.Controls.Add(Me.txtCIPS1Length)
        Me.grpCIPCategories.Controls.Add(Me.txtCIPS2Length)
        Me.grpCIPCategories.Controls.Add(Me.txtCIPS3Length)
        Me.grpCIPCategories.Enabled = False
        Me.grpCIPCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCIPCategories.Location = New System.Drawing.Point(8, 51)
        Me.grpCIPCategories.Name = "grpCIPCategories"
        Me.grpCIPCategories.Size = New System.Drawing.Size(284, 139)
        Me.grpCIPCategories.TabIndex = 3
        Me.grpCIPCategories.TabStop = False
        Me.grpCIPCategories.Text = "Mã phân loại XDCB"
        '
        'tdbcCIPS3Default
        '
        Me.tdbcCIPS3Default.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcCIPS3Default.AllowColMove = False
        Me.tdbcCIPS3Default.AllowSort = False
        Me.tdbcCIPS3Default.AlternatingRows = True
        Me.tdbcCIPS3Default.AutoCompletion = True
        Me.tdbcCIPS3Default.AutoDropDown = True
        Me.tdbcCIPS3Default.Caption = ""
        Me.tdbcCIPS3Default.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcCIPS3Default.ColumnWidth = 100
        Me.tdbcCIPS3Default.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcCIPS3Default.DisplayMember = "AssetS3ID"
        Me.tdbcCIPS3Default.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcCIPS3Default.DropDownWidth = 400
        Me.tdbcCIPS3Default.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcCIPS3Default.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCIPS3Default.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcCIPS3Default.EmptyRows = True
        Me.tdbcCIPS3Default.ExtendRightColumn = True
        Me.tdbcCIPS3Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCIPS3Default.Images.Add(CType(resources.GetObject("tdbcCIPS3Default.Images"), System.Drawing.Image))
        Me.tdbcCIPS3Default.Location = New System.Drawing.Point(110, 77)
        Me.tdbcCIPS3Default.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcCIPS3Default.MaxDropDownItems = CType(8, Short)
        Me.tdbcCIPS3Default.MaxLength = 32767
        Me.tdbcCIPS3Default.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcCIPS3Default.Name = "tdbcCIPS3Default"
        Me.tdbcCIPS3Default.ReadOnly = True
        Me.tdbcCIPS3Default.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcCIPS3Default.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcCIPS3Default.Size = New System.Drawing.Size(101, 21)
        Me.tdbcCIPS3Default.TabIndex = 7
        Me.tdbcCIPS3Default.ValueMember = "AssetS3ID"
        Me.tdbcCIPS3Default.PropBag = resources.GetString("tdbcCIPS3Default.PropBag")
        '
        'tdbcCIPS1Default
        '
        Me.tdbcCIPS1Default.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcCIPS1Default.AllowColMove = False
        Me.tdbcCIPS1Default.AllowSort = False
        Me.tdbcCIPS1Default.AlternatingRows = True
        Me.tdbcCIPS1Default.AutoCompletion = True
        Me.tdbcCIPS1Default.AutoDropDown = True
        Me.tdbcCIPS1Default.Caption = ""
        Me.tdbcCIPS1Default.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcCIPS1Default.ColumnWidth = 100
        Me.tdbcCIPS1Default.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcCIPS1Default.DisplayMember = "AssetS1ID"
        Me.tdbcCIPS1Default.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcCIPS1Default.DropDownWidth = 400
        Me.tdbcCIPS1Default.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcCIPS1Default.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCIPS1Default.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcCIPS1Default.EmptyRows = True
        Me.tdbcCIPS1Default.ExtendRightColumn = True
        Me.tdbcCIPS1Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCIPS1Default.Images.Add(CType(resources.GetObject("tdbcCIPS1Default.Images"), System.Drawing.Image))
        Me.tdbcCIPS1Default.Location = New System.Drawing.Point(109, 20)
        Me.tdbcCIPS1Default.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcCIPS1Default.MaxDropDownItems = CType(8, Short)
        Me.tdbcCIPS1Default.MaxLength = 32767
        Me.tdbcCIPS1Default.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcCIPS1Default.Name = "tdbcCIPS1Default"
        Me.tdbcCIPS1Default.ReadOnly = True
        Me.tdbcCIPS1Default.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcCIPS1Default.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcCIPS1Default.Size = New System.Drawing.Size(102, 21)
        Me.tdbcCIPS1Default.TabIndex = 1
        Me.tdbcCIPS1Default.ValueMember = "AssetS1ID"
        Me.tdbcCIPS1Default.PropBag = resources.GetString("tdbcCIPS1Default.PropBag")
        '
        'tdbcCIPS2Default
        '
        Me.tdbcCIPS2Default.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcCIPS2Default.AllowColMove = False
        Me.tdbcCIPS2Default.AllowSort = False
        Me.tdbcCIPS2Default.AlternatingRows = True
        Me.tdbcCIPS2Default.AutoCompletion = True
        Me.tdbcCIPS2Default.AutoDropDown = True
        Me.tdbcCIPS2Default.Caption = ""
        Me.tdbcCIPS2Default.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcCIPS2Default.ColumnWidth = 100
        Me.tdbcCIPS2Default.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcCIPS2Default.DisplayMember = "AssetS2ID"
        Me.tdbcCIPS2Default.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcCIPS2Default.DropDownWidth = 400
        Me.tdbcCIPS2Default.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcCIPS2Default.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCIPS2Default.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcCIPS2Default.EmptyRows = True
        Me.tdbcCIPS2Default.ExtendRightColumn = True
        Me.tdbcCIPS2Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCIPS2Default.Images.Add(CType(resources.GetObject("tdbcCIPS2Default.Images"), System.Drawing.Image))
        Me.tdbcCIPS2Default.Location = New System.Drawing.Point(110, 48)
        Me.tdbcCIPS2Default.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcCIPS2Default.MaxDropDownItems = CType(8, Short)
        Me.tdbcCIPS2Default.MaxLength = 32767
        Me.tdbcCIPS2Default.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcCIPS2Default.Name = "tdbcCIPS2Default"
        Me.tdbcCIPS2Default.ReadOnly = True
        Me.tdbcCIPS2Default.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcCIPS2Default.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcCIPS2Default.Size = New System.Drawing.Size(101, 21)
        Me.tdbcCIPS2Default.TabIndex = 4
        Me.tdbcCIPS2Default.ValueMember = "AssetS2ID"
        Me.tdbcCIPS2Default.PropBag = resources.GetString("tdbcCIPS2Default.PropBag")
        '
        'chkCIPS3Enabled
        '
        Me.chkCIPS3Enabled.AutoSize = True
        Me.chkCIPS3Enabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCIPS3Enabled.Location = New System.Drawing.Point(11, 82)
        Me.chkCIPS3Enabled.Name = "chkCIPS3Enabled"
        Me.chkCIPS3Enabled.Size = New System.Drawing.Size(70, 17)
        Me.chkCIPS3Enabled.TabIndex = 6
        Me.chkCIPS3Enabled.Text = "Phân loại"
        Me.chkCIPS3Enabled.UseVisualStyleBackColor = True
        '
        'chkCIPS2Enabled
        '
        Me.chkCIPS2Enabled.AutoSize = True
        Me.chkCIPS2Enabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCIPS2Enabled.Location = New System.Drawing.Point(11, 53)
        Me.chkCIPS2Enabled.Name = "chkCIPS2Enabled"
        Me.chkCIPS2Enabled.Size = New System.Drawing.Size(70, 17)
        Me.chkCIPS2Enabled.TabIndex = 3
        Me.chkCIPS2Enabled.Text = "Phân loại"
        Me.chkCIPS2Enabled.UseVisualStyleBackColor = True
        '
        'chkCIPS1Enabled
        '
        Me.chkCIPS1Enabled.AutoSize = True
        Me.chkCIPS1Enabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCIPS1Enabled.Location = New System.Drawing.Point(11, 24)
        Me.chkCIPS1Enabled.Name = "chkCIPS1Enabled"
        Me.chkCIPS1Enabled.Size = New System.Drawing.Size(70, 17)
        Me.chkCIPS1Enabled.TabIndex = 0
        Me.chkCIPS1Enabled.Text = "Phân loại"
        Me.chkCIPS1Enabled.UseVisualStyleBackColor = True
        '
        'txtCIPS1Length
        '
        Me.txtCIPS1Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCIPS1Length.Location = New System.Drawing.Point(217, 21)
        Me.txtCIPS1Length.MaxLength = 2
        Me.txtCIPS1Length.Name = "txtCIPS1Length"
        Me.txtCIPS1Length.ReadOnly = True
        Me.txtCIPS1Length.Size = New System.Drawing.Size(55, 20)
        Me.txtCIPS1Length.TabIndex = 2
        Me.txtCIPS1Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCIPS2Length
        '
        Me.txtCIPS2Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCIPS2Length.Location = New System.Drawing.Point(217, 50)
        Me.txtCIPS2Length.MaxLength = 2
        Me.txtCIPS2Length.Name = "txtCIPS2Length"
        Me.txtCIPS2Length.ReadOnly = True
        Me.txtCIPS2Length.Size = New System.Drawing.Size(55, 20)
        Me.txtCIPS2Length.TabIndex = 5
        Me.txtCIPS2Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCIPS3Length
        '
        Me.txtCIPS3Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCIPS3Length.Location = New System.Drawing.Point(217, 79)
        Me.txtCIPS3Length.MaxLength = 2
        Me.txtCIPS3Length.Name = "txtCIPS3Length"
        Me.txtCIPS3Length.ReadOnly = True
        Me.txtCIPS3Length.Size = New System.Drawing.Size(55, 20)
        Me.txtCIPS3Length.TabIndex = 8
        Me.txtCIPS3Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.chkIsCalPeriodByRate)
        Me.TabPage4.Controls.Add(Me.chkIsEditAnaID)
        Me.TabPage4.Controls.Add(Me.chkIsCalDepByDate)
        Me.TabPage4.Controls.Add(Me.chkIsAllowChangeAccount)
        Me.TabPage4.Controls.Add(Me.chkAllowChangeDivision)
        Me.TabPage4.Controls.Add(Me.chkIsCheckNormIDAllocated)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(576, 328)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Các thiết lập khác"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'chkIsCalPeriodByRate
        '
        Me.chkIsCalPeriodByRate.AutoSize = True
        Me.chkIsCalPeriodByRate.Location = New System.Drawing.Point(15, 148)
        Me.chkIsCalPeriodByRate.Name = "chkIsCalPeriodByRate"
        Me.chkIsCalPeriodByRate.Size = New System.Drawing.Size(250, 17)
        Me.chkIsCalPeriodByRate.TabIndex = 5
        Me.chkIsCalPeriodByRate.Text = "Tính số kỳ khấu hao theo tỷ lệ khấu hao (Năm)"
        Me.chkIsCalPeriodByRate.UseVisualStyleBackColor = True
        '
        'chkIsEditAnaID
        '
        Me.chkIsEditAnaID.AutoSize = True
        Me.chkIsEditAnaID.Location = New System.Drawing.Point(15, 121)
        Me.chkIsEditAnaID.Name = "chkIsEditAnaID"
        Me.chkIsEditAnaID.Size = New System.Drawing.Size(235, 17)
        Me.chkIsEditAnaID.TabIndex = 4
        Me.chkIsEditAnaID.Text = "Cho phép sửa khoản mục khi tính khấu hao"
        Me.chkIsEditAnaID.UseVisualStyleBackColor = True
        '
        'chkIsCalDepByDate
        '
        Me.chkIsCalDepByDate.AutoSize = True
        Me.chkIsCalDepByDate.Location = New System.Drawing.Point(15, 94)
        Me.chkIsCalDepByDate.Name = "chkIsCalDepByDate"
        Me.chkIsCalDepByDate.Size = New System.Drawing.Size(224, 17)
        Me.chkIsCalDepByDate.TabIndex = 3
        Me.chkIsCalDepByDate.Text = "Tính khấu hao theo ngày cho kỳ đầu tiên"
        Me.chkIsCalDepByDate.UseVisualStyleBackColor = True
        '
        'chkIsAllowChangeAccount
        '
        Me.chkIsAllowChangeAccount.AutoSize = True
        Me.chkIsAllowChangeAccount.Location = New System.Drawing.Point(15, 67)
        Me.chkIsAllowChangeAccount.Name = "chkIsAllowChangeAccount"
        Me.chkIsAllowChangeAccount.Size = New System.Drawing.Size(176, 17)
        Me.chkIsAllowChangeAccount.TabIndex = 2
        Me.chkIsAllowChangeAccount.Text = "Hiện thiết lập thay đổi tài khoản"
        Me.chkIsAllowChangeAccount.UseVisualStyleBackColor = True
        '
        'chkAllowChangeDivision
        '
        Me.chkAllowChangeDivision.AutoSize = True
        Me.chkAllowChangeDivision.Location = New System.Drawing.Point(15, 40)
        Me.chkAllowChangeDivision.Name = "chkAllowChangeDivision"
        Me.chkAllowChangeDivision.Size = New System.Drawing.Size(199, 17)
        Me.chkAllowChangeDivision.TabIndex = 1
        Me.chkAllowChangeDivision.Text = "Cho phép điều chuyển đơn vị TSCĐ"
        Me.chkAllowChangeDivision.UseVisualStyleBackColor = True
        '
        'chkIsCheckNormIDAllocated
        '
        Me.chkIsCheckNormIDAllocated.AutoSize = True
        Me.chkIsCheckNormIDAllocated.Location = New System.Drawing.Point(15, 13)
        Me.chkIsCheckNormIDAllocated.Name = "chkIsCheckNormIDAllocated"
        Me.chkIsCheckNormIDAllocated.Size = New System.Drawing.Size(233, 17)
        Me.chkIsCheckNormIDAllocated.TabIndex = 0
        Me.chkIsCheckNormIDAllocated.Text = "Cho phép bổ sung tài sản theo bộ định mức"
        Me.chkIsCheckNormIDAllocated.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.tdbdVoucherTypeID)
        Me.TabPage5.Controls.Add(Me.tdbg)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(576, 328)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Thiết lập loại phiếu"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'tdbdVoucherTypeID
        '
        Me.tdbdVoucherTypeID.AllowColMove = False
        Me.tdbdVoucherTypeID.AllowColSelect = False
        Me.tdbdVoucherTypeID.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbdVoucherTypeID.AllowSort = False
        Me.tdbdVoucherTypeID.AlternatingRows = True
        Me.tdbdVoucherTypeID.CaptionStyle = Style1
        Me.tdbdVoucherTypeID.ColumnCaptionHeight = 17
        Me.tdbdVoucherTypeID.ColumnFooterHeight = 17
        Me.tdbdVoucherTypeID.DisplayMember = "VoucherTypeID"
        Me.tdbdVoucherTypeID.EmptyRows = True
        Me.tdbdVoucherTypeID.EvenRowStyle = Style2
        Me.tdbdVoucherTypeID.ExtendRightColumn = True
        Me.tdbdVoucherTypeID.FetchRowStyles = False
        Me.tdbdVoucherTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbdVoucherTypeID.FooterStyle = Style3
        Me.tdbdVoucherTypeID.HeadingStyle = Style4
        Me.tdbdVoucherTypeID.HighLightRowStyle = Style5
        Me.tdbdVoucherTypeID.Images.Add(CType(resources.GetObject("tdbdVoucherTypeID.Images"), System.Drawing.Image))
        Me.tdbdVoucherTypeID.Location = New System.Drawing.Point(113, 91)
        Me.tdbdVoucherTypeID.Name = "tdbdVoucherTypeID"
        Me.tdbdVoucherTypeID.OddRowStyle = Style6
        Me.tdbdVoucherTypeID.PropBag = resources.GetString("tdbdVoucherTypeID.PropBag")
        Me.tdbdVoucherTypeID.RecordSelectorStyle = Style7
        Me.tdbdVoucherTypeID.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdbdVoucherTypeID.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdbdVoucherTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbdVoucherTypeID.ScrollTips = False
        Me.tdbdVoucherTypeID.Size = New System.Drawing.Size(350, 147)
        Me.tdbdVoucherTypeID.Style = Style8
        Me.tdbdVoucherTypeID.TabIndex = 9
        Me.tdbdVoucherTypeID.TabStop = False
        Me.tdbdVoucherTypeID.ValueMember = "VoucherTypeID"
        Me.tdbdVoucherTypeID.Visible = False
        '
        'tdbg
        '
        Me.tdbg.AllowColMove = False
        Me.tdbg.AllowColSelect = False
        Me.tdbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg.AllowSort = False
        Me.tdbg.AlternatingRows = True
        Me.tdbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbg.EmptyRows = True
        Me.tdbg.ExtendRightColumn = True
        Me.tdbg.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard
        Me.tdbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbg.Images.Add(CType(resources.GetObject("tdbg.Images"), System.Drawing.Image))
        Me.tdbg.Location = New System.Drawing.Point(3, 3)
        Me.tdbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor
        Me.tdbg.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.tdbg.Name = "tdbg"
        Me.tdbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbg.PrintInfo.PageSettings = CType(resources.GetObject("tdbg.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg.PropBag = resources.GetString("tdbg.PropBag")
        Me.tdbg.Size = New System.Drawing.Size(570, 322)
        Me.tdbg.TabAcrossSplits = True
        Me.tdbg.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.tdbg.TabIndex = 2
        Me.tdbg.Tag = "COL"
        '
        'D02F0001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 398)
        Me.Controls.Add(Me.tabSystem)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F0001"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThiÕt lËp hÖ thçng - D02F0001"
        Me.tabSystem.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.tdbcMethodEndID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcMethodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDefAssignmentID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDefSourceID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDefDepreciationAccountID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDefAssetAccountID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpIGE.ResumeLayout(False)
        Me.grpIGE.PerformLayout()
        Me.grpAutoAssetNumbering.ResumeLayout(False)
        Me.grpAutoAssetNumbering.PerformLayout()
        CType(Me.tdbcAssetSeperator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownAutoNumberLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAssetCategories.ResumeLayout(False)
        Me.grpAssetCategories.PerformLayout()
        CType(Me.tdbcAssetS3Default, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcAssetS2Default, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcAssetS1Default, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpAutoCIPNumbering.ResumeLayout(False)
        Me.grpAutoCIPNumbering.PerformLayout()
        CType(Me.tdbcCIPSeperator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownCIPAutoNumberLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCIPCategories.ResumeLayout(False)
        Me.grpCIPCategories.PerformLayout()
        CType(Me.tdbcCIPS3Default, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcCIPS1Default, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcCIPS2Default, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.tdbdVoucherTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents tabSystem As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents grp1 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcDivisionID As C1.Win.C1List.C1Combo
    Private WithEvents txtDefaultPeriod As System.Windows.Forms.TextBox
    Private WithEvents lblDefaultPeriod As System.Windows.Forms.Label
    Private WithEvents txtPeriodNumber As System.Windows.Forms.TextBox
    Private WithEvents lblNumberPeriod As System.Windows.Forms.Label
    Private WithEvents txtDivisionName As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents tdbcDefSourceID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcDefDepreciationAccountID As C1.Win.C1List.C1Combo
    Private WithEvents lblDepreciateAccountID As System.Windows.Forms.Label
    Private WithEvents tdbcDefAssetAccountID As C1.Win.C1List.C1Combo
    Private WithEvents lblAssetAccountID As System.Windows.Forms.Label
    Private WithEvents lblSourceID As System.Windows.Forms.Label
    Private WithEvents tdbcMethodEndID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcMethodID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcDefAssignmentID As C1.Win.C1List.C1Combo
    Private WithEvents lblAssignmentID As System.Windows.Forms.Label
    Private WithEvents lblMethodID As System.Windows.Forms.Label
    Private WithEvents lblMethodEndID As System.Windows.Forms.Label
    Private WithEvents chkDecreaseAsset As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents chkAssetAuto As System.Windows.Forms.CheckBox
    Private WithEvents grpAssetCategories As System.Windows.Forms.GroupBox
    Private WithEvents chkAssetS3Enabled As System.Windows.Forms.CheckBox
    Private WithEvents tdbcAssetS1Default As C1.Win.C1List.C1Combo
    Private WithEvents chkAssetS1Enabled As System.Windows.Forms.CheckBox
    Private WithEvents txtS1Length As System.Windows.Forms.TextBox
    Private WithEvents tdbcAssetS2Default As C1.Win.C1List.C1Combo
    Private WithEvents txtS2Length As System.Windows.Forms.TextBox
    Private WithEvents tdbcAssetS3Default As C1.Win.C1List.C1Combo
    Private WithEvents txtS3Length As System.Windows.Forms.TextBox
    Private WithEvents grpAutoAssetNumbering As System.Windows.Forms.GroupBox
    Private WithEvents chkAssetSeperated As System.Windows.Forms.CheckBox
    Private WithEvents cboAssetOutputOrder As System.Windows.Forms.ComboBox
    Private WithEvents lblAssetOutputOrder As System.Windows.Forms.Label
    Private WithEvents lblAssetOutputLength As System.Windows.Forms.Label
    Private WithEvents lblAutoNumberLength As System.Windows.Forms.Label
    Friend WithEvents updownAutoNumberLength As System.Windows.Forms.NumericUpDown
    Private WithEvents chkAssetS2Enabled As System.Windows.Forms.CheckBox
    Private WithEvents tdbcAssetSeperator As C1.Win.C1List.C1Combo
    Private WithEvents txtAssetOutputLength As System.Windows.Forms.TextBox
    Private WithEvents lblExample As System.Windows.Forms.Label
    Private WithEvents lblCaptionExample As System.Windows.Forms.Label
    Friend WithEvents txtCheckAssetOutputLength As System.Windows.Forms.TextBox
    Private WithEvents chkCheckAssetOutputLength As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents optAssetAuto2 As System.Windows.Forms.RadioButton
    Private WithEvents optAssetAuto1 As System.Windows.Forms.RadioButton
    Private WithEvents chkIsAssetIDForD02D43 As System.Windows.Forms.CheckBox
    Private WithEvents chkUseProperty As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtCIPCheckOutputLength As System.Windows.Forms.TextBox
    Private WithEvents chkCIPCheckOutputLength As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents optCIPAuto2 As System.Windows.Forms.RadioButton
    Private WithEvents chkCIPAuto As System.Windows.Forms.CheckBox
    Private WithEvents optCIPAuto1 As System.Windows.Forms.RadioButton
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents grpAutoCIPNumbering As System.Windows.Forms.GroupBox
    Private WithEvents tdbcCIPSeperator As C1.Win.C1List.C1Combo
    Private WithEvents txtCIPOutputLength As System.Windows.Forms.TextBox
    Private WithEvents lblCIPOutputLength As System.Windows.Forms.Label
    Private WithEvents lblCIPAutoNumberLength As System.Windows.Forms.Label
    Friend WithEvents updownCIPAutoNumberLength As System.Windows.Forms.NumericUpDown
    Private WithEvents cboCIPOutputOrder As System.Windows.Forms.ComboBox
    Private WithEvents chkCIPSeperated As System.Windows.Forms.CheckBox
    Private WithEvents lblCIPOutputOrder As System.Windows.Forms.Label
    Private WithEvents lblCIPExample As System.Windows.Forms.Label
    Private WithEvents grpCIPCategories As System.Windows.Forms.GroupBox
    Private WithEvents tdbcCIPS3Default As C1.Win.C1List.C1Combo
    Private WithEvents tdbcCIPS1Default As C1.Win.C1List.C1Combo
    Private WithEvents tdbcCIPS2Default As C1.Win.C1List.C1Combo
    Private WithEvents chkCIPS3Enabled As System.Windows.Forms.CheckBox
    Private WithEvents chkCIPS2Enabled As System.Windows.Forms.CheckBox
    Private WithEvents chkCIPS1Enabled As System.Windows.Forms.CheckBox
    Private WithEvents txtCIPS1Length As System.Windows.Forms.TextBox
    Private WithEvents txtCIPS2Length As System.Windows.Forms.TextBox
    Private WithEvents txtCIPS3Length As System.Windows.Forms.TextBox
    Private WithEvents chkObligatoryReceiver As System.Windows.Forms.CheckBox
    Private WithEvents chkUseBudgetForCIP As System.Windows.Forms.CheckBox
    Private WithEvents chkUseD54ForCIP As System.Windows.Forms.CheckBox
    Private WithEvents chkCIPforPropertyProduct As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Private WithEvents chkIsCheckNormIDAllocated As System.Windows.Forms.CheckBox
    Private WithEvents grpIGE As System.Windows.Forms.GroupBox
    Private WithEvents optShowFormAotuCreate0 As System.Windows.Forms.RadioButton
    Private WithEvents optShowFormAotuCreate1 As System.Windows.Forms.RadioButton
    Private WithEvents chkAllowChangeDivision As System.Windows.Forms.CheckBox
    Private WithEvents chkIsAllowChangeAccount As System.Windows.Forms.CheckBox
    Private WithEvents chkIsCalDepByDate As System.Windows.Forms.CheckBox
    Private WithEvents chkIsEditAnaID As System.Windows.Forms.CheckBox
    Private WithEvents chkIsCalPeriodByRate As System.Windows.Forms.CheckBox
    Private WithEvents chkIsObligatoryManagement As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Private WithEvents tdbdVoucherTypeID As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Private WithEvents tdbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class