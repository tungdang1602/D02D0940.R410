Public Class D02F0001
    Private bFormClosed As Boolean = False ' Cờ xem form đó đóng = nút X của form không

#Region "Const of tdbg - Total of Columns: 4"
    Private Const COL_FormID As Integer = 0          ' Mã màn hình
    Private Const COL_FormName As Integer = 1        ' Màn hình
    Private Const COL_VoucherTypeID As Integer = 2   ' Mã loại
    Private Const COL_VoucherTypeName As Integer = 3 ' Loại phiếu
#End Region

    Private _FormState As EnumFormState
    Public WriteOnly Property FormState() As EnumFormState
        Set(ByVal value As EnumFormState)

            If ExistRecord("SELECT * FROM D02T0000  WITH(NOLOCK) ") = True Then
                _FormState = EnumFormState.FormEdit
            Else
                _FormState = EnumFormState.FormAdd
            End If

            LoadTDBCombo()
            LoadTDBDropdown()
            LoadTDBGridTab5()
            LoadPeriodNumberAndDefaultPeriod()
            LoadInfoGeneral()
            Select Case _FormState
                Case EnumFormState.FormAdd
                Case EnumFormState.FormEdit
                    LoadEdit()
                Case EnumFormState.FormView
            End Select
        End Set
    End Property

    Private Sub D02F0001_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If _FormState = EnumFormState.FormAdd And Not bFormClosed Then End
    End Sub

    Private Sub D02F0001_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
            Exit Sub
        End If

        If e.Alt = True And (e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1) Then
            tabSystem.SelectedIndex = 0
            tabSystem.Focus()
        End If
        If e.Alt = True And (e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad2) Then
            tabSystem.SelectedIndex = 1
            tabSystem.Focus()
        End If
    End Sub

    Private Sub D02F0001_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormState = EnumFormState.FormEdit
        Me.Cursor = Cursors.WaitCursor
        Loadlanguage()
        SetBackColorObligatory()
        btnSave.Enabled = ReturnPermission("D02F0001") > EnumPermission.View
        InputbyUnicode(Me, gbUnicode)
        Lemon3.D00Systems.LockControlsFromDesktop(tdbcDivisionID)
        SetResolutionForm(Me)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcDivisionID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        updownAutoNumberLength.BackColor = COLOR_BACKCOLOROBLIGATORY
        updownCIPAutoNumberLength.BackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Thiet_lap_he_thong_-_D02F0001") & UnicodeCaption(gbUnicode) 'ThiÕt lËp hÖ thçng - D02F0001
        '================================================================ 
        lblDepreciateAccountID.Text = rl3("TK_khau_hao") 'TK khấu hao
        Label1.Text = rl3("Don_vi_mac_dinh") 'Đơn vị mặc định
        lblDefaultPeriod.Text = rl3("Ky_ke_toan_mac_dinh") 'Kỳ mặc định
        lblNumberPeriod.Text = rl3("So_ky_ke_toan") 'Số kỳ kế toán
        lblAssetAccountID.Text = rl3("TK_tai_san") 'TK tài sản
        lblSourceID.Text = rl3("Nguon_von") 'Nguồn vốn
        lblAssignmentID.Text = rl3("Phan_bo_KH") 'Phân bổ KH
        lblMethodID.Text = rl3("Phuong_phap_KH") 'Phương pháp KH
        lblMethodEndID.Text = rl3("Xu_ly_KH_ky_cuoi") 'Xử lý KH kỳ cuối
        lblAssetOutputLength.Text = rl3("Do_dai_ma") 'Độ dài mã
        lblAutoNumberLength.Text = rl3("Do_dai_so") 'Độ dài số
        lblAssetOutputOrder.Text = rl3("Dang_hien_thi") 'Dạng hiển thị
        lblCaptionExample.Text = rL3("Vi_du") & ":" 'Ví dụ
        Label2.Text = rL3("Vi_du_") 'Ví dụ:
        lblCIPOutputOrder.Text = rL3("Dang_hien_thi") 'Dạng hiển thị
        lblCIPAutoNumberLength.Text = rL3("Do_dai_so") 'Độ dài số
        lblCIPOutputLength.Text = rL3("Do_dai_ma") 'Độ dài mã
        '================================================================ 
        btnSave.Text = rl3("_Luu") '&Lưu
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        '================================================================ 
        chkAssetSeperated.Text = rl3("Dau_phan_cach") 'Dấu phân cách
        chkAssetS1Enabled.Text = rl3("Phan_loai") & " 1" 'Phân loại 1
        chkAssetS2Enabled.Text = rl3("Phan_loai") & " 2" 'Phân loại 2
        chkAssetS3Enabled.Text = rl3("Phan_loai") & " 3" 'Phân loại 3
        chkDecreaseAsset.Text = rl3("Cac_but_toan_giam_TS") 'Các bút toán giảm TS
        chkAssetAuto.Text = rl3("Tao_ma_tu_dong_cho_tai_san_co_dinh") 'Tạo mã tự động cho tài sản cố định
        chkCheckAssetOutputLength.Text = rl3("Kiem_tra_do_dai_ma_tai_san") ' Kiểm tra độ dài mã tài sản
        chkIsAssetIDForD02D43.Text = rL3("Ma_TSCD_va_ma_CCDC_tang_lien_tuc") 'Mã TSCĐ và mã CCDC tăng liên tục
        chkCIPAuto.Text = rL3("Tao_ma_XDCB_tu_dong") 'Tạo mã XDCB tự động 
        chkUseProperty.Text = rL3("BDS_dau_tu") 'BĐS đầu tư
        chkCIPAuto.Text = rL3("Tao_ma_XDCB_tu_dong") 'Tạo mã XDCB tự động
        chkCIPCheckOutputLength.Text = rL3("Kiem_tra_do_dai_ma_XDCB") 'Kiểm tra độ dài mã XDCB
        chkCIPS1Enabled.Text = rL3("Phan_loai") 'Phân loại
        chkCIPS2Enabled.Text = rL3("Phan_loai") 'Phân loại
        chkCIPS3Enabled.Text = rL3("Phan_loai") 'Phân loại
        chkCIPSeperated.Text = rL3("Dau_phan_cach") 'Dấu phân cách
        chkObligatoryReceiver.Text = rL3("Bat_buoc_nhap_nguoi_tiep_nhan") 'Bắt buộc nhập người tiếp nhận
        chkUseD54ForCIP.Text = rL3("Tap_hop_XDCB_tu_du_an") 'Tập hợp XDCB từ dự án
        chkUseBudgetForCIP.Text = rL3("Tap_hop_XDCB_tu_ngan_sach") 'Tập hợp XDCB từ ngân sách
        chkCIPforPropertyProduct.Text = rL3("Tap_hop_XDCB_cho_ma_BDS") 'Tập hợp XDCB cho mã BĐS
        chkIsCheckNormIDAllocated.Text = rL3("Cho_phep_bo_sung_tai_san_theo_bo_dinh_muc")
        chkAllowChangeDivision.Text = rL3("Cho_phep_dieu_chuyen_don_vi_TSCD") 'Cho phép điều chuyển đơn vị TSCĐ
        chkIsAllowChangeAccount.Text = rL3("Hien_thiet_lap_thay_doi_tai_khoan") 'Hiện thiết lập thay đổi tài khoản
        chkIsCalDepByDate.Text = rL3("Tinh_khau_hao_theo_ngay_cho_ky_dau_tien") 'Tính khấu hao theo ngày cho kỳ đầu tiên
        chkIsEditAnaID.Text = rL3("Cho_phep_sua_khoan_muc_khi_tinh_khau_hao") 'Cho phép sửa khoản mục khi tính khấu hao
        chkIsCalPeriodByRate.Text = rL3("Tinh_so_ky_khau_hao_theo_ty_le_khau_hao_(Nam)") 'Tính số kỳ khấu hao theo tỷ lệ khấu hao (Năm)

        '================================================================ 
        optAssetAuto1.Text = rL3("Chon_ma_phan_loai") 'Chọn mã phân loại
        optAssetAuto2.Text = rL3("Chon_phuong_phap_tao_ma_tu_dong") 'Chọn phương pháp tạo mã tự động
        optCIPAuto1.Text = rL3("Chon_ma_phan_loai") 'Chọn mã phân loại
        optCIPAuto2.Text = rL3("Chon_phuong_phap_tao_ma_tu_dong") 'Chọn phương pháp tạo mã tự động
        '================================================================ 
        grpAutoAssetNumbering.Text = rl3("Dinh_dang_ma_tu_dong") 'Định dạng mã tự động
        grpAssetCategories.Text = rL3("Ma_phan_loai_TSCD") 'Mã phân loại TSCĐ
        grpCIPCategories.Text = rL3("Ma_phan_loai_XDCB") 'Mã phân loại XDCB
        grpAutoCIPNumbering.Text = rL3("Dinh_dang_ma_tu_dong") 'Định dạng mã tự động
        '================================================================ 
        TabPage1.Text = "1. " & rl3("Thong_tin_chinh") 'Thông tin chính
        TabPage2.Text = "2. " & rL3("Tao_ma_TSCD_tu_dong") 'Tạo mã tự động
        TabPage3.Text = "3. " & rL3("Tao_ma_XDCB_tu_dong") 'Tạo mã tự động
        TabPage4.Text = "4. " & rL3("Cac_thiet_lap_khac") 'Các thiết lập khác
        TabPage5.Text = "5. " & rL3("Thiet_lap_loai_phieu") ' Thiết lập loại phiếu

        '================================================================ 
        tdbcMethodEndID.Columns("MethodEndID").Caption = rl3("Ma") 'Mã
        tdbcMethodEndID.Columns("MethodEndName").Caption = rl3("Ten") 'Tên
        tdbcMethodID.Columns("MethodID").Caption = rl3("Ma") 'Mã
        tdbcMethodID.Columns("MethodName").Caption = rl3("Ten") 'Tên
        tdbcDefAssignmentID.Columns("AssignmentID").Caption = rl3("Ma") 'Mã
        tdbcDefAssignmentID.Columns("AssignmentName").Caption = rl3("Ten") 'Tên
        tdbcDefSourceID.Columns("SourceID").Caption = rl3("Ma") 'Mã
        tdbcDefSourceID.Columns("SourceName").Caption = rl3("Ten") 'Tên
        tdbcDefDepreciationAccountID.Columns("AccountID").Caption = rl3("Ma") 'Mã
        tdbcDefDepreciationAccountID.Columns("AccountName").Caption = rl3("Ten") 'Tên
        tdbcDefAssetAccountID.Columns("AccountID").Caption = rl3("Ma") 'Mã
        tdbcDefAssetAccountID.Columns("AccountName").Caption = rl3("Ten") 'Tên
        tdbcDivisionID.Columns("DivisionID").Caption = rl3("Ma_don_vi") 'Mã đơn vị
        tdbcDivisionID.Columns("DivisionName").Caption = rl3("Ten_don_vi") 'Tên đơn vị
        tdbcAssetS3Default.Columns("AssetS3ID").Caption = rl3("Ma") 'Mã
        tdbcAssetS3Default.Columns("AssetS3Name").Caption = rl3("Ten") 'Tên
        tdbcAssetS2Default.Columns("AssetS2ID").Caption = rl3("Ma") 'Mã
        tdbcAssetS2Default.Columns("AssetS2Name").Caption = rl3("Ten") 'Tên
        tdbcAssetS1Default.Columns("AssetS1ID").Caption = rl3("Ma") 'Mã
        tdbcAssetS1Default.Columns("AssetS1Name").Caption = rL3("Ten") 'Tên
        '================================================================ 

        '================================================================ 
        optShowFormAotuCreate0.Text = rL3("Khong_hien_thi_man_hinh_tao_ma_tu_dong") 'Không hiển thị màn hình tạo mã tự động
        optShowFormAotuCreate1.Text = rL3("Hien_thi_man_hinh_tao_ma_tu_dong") 'Hiển thị màn hình tạo mã tự động
        '================================================================ 
        grpIGE.Text = rL3("Hien_thi") 'Hiển thị
    
        '================================================================ 
        chkIsObligatoryManagement.Text = rL3("Bat_buoc_nhap_bo_phan_quan_ly") 'Bắt buộc nhập bộ phận quản lý

        '================================================================ 
        tdbdVoucherTypeID.Columns("VoucherTypeID").Caption = rL3("Ma") 'Mã
        tdbdVoucherTypeID.Columns("VoucherTypeName").Caption = rL3("Ten") 'Tên
        '================================================================ 
        tdbg.Columns(COL_FormID).Caption = rL3("Ma_man_hinh") 'Mã màn hình
        tdbg.Columns(COL_FormName).Caption = rL3("Man_hinh") 'Màn hình
        tdbg.Columns(COL_VoucherTypeID).Caption = rL3("Ma_loai") 'Mã loại
        tdbg.Columns(COL_VoucherTypeName).Caption = rL3("Loai_phieu") 'Loại phiếu
    End Sub

    Private Sub LoadTDBCombo()
        Dim sSQL As String = ""

        'Load tdbcDivisionID
        LoadCboDivisionID(tdbcDivisionID, D02, False, gbUnicode)

        'Load tdbcAssetAccountID
        LoadAccountID(tdbcDefAssetAccountID, "GroupID = '7'", gbUnicode)

        'Load tdbcDepreciateAccountID
        LoadAccountID(tdbcDefDepreciationAccountID, "GroupID = '19'", gbUnicode)

        'Load tdbcSourceID
        sSQL = "SELECT     SourceID, SourceName" & UnicodeJoin(gbUnicode) & " As SourceName" & vbCrLf
        sSQL &= "FROM       D02T0013 WITH(NOLOCK)  " & vbCrLf
        sSQL &= "WHERE      Disabled = 0" & vbCrLf
        sSQL &= "ORDER BY   SourceID" & vbCrLf
        LoadDataSource(tdbcDefSourceID, sSQL, gbUnicode)

        'Load tdbcAssignmentID
        sSQL = "SELECT     AssignmentID,AssignmentName" & UnicodeJoin(gbUnicode) & " As AssignmentName" & vbCrLf
        sSQL &= "FROM       D02T0002 WITH(NOLOCK) " & vbCrLf
        sSQL &= "WHERE      Disabled = 0" & vbCrLf
        sSQL &= "ORDER BY   AssignmentID" & vbCrLf
        LoadDataSource(tdbcDefAssignmentID, sSQL, gbUnicode)

        'Load tdbcMethodID
        sSQL = "SELECT 	Convert(Varchar(20),IntCode) as MethodID,  " & vbCrLf
        sSQL &= "           Description" & UnicodeJoin(gbUnicode) & " As MethodName " & vbCrLf
        sSQL &= "FROM       D02T8000 WITH(NOLOCK) " & vbCrLf
        sSQL &= "WHERE      ModuleID ='02' and Type =0  and Language = 84 " & vbCrLf
        sSQL &= "ORDER BY   intCode" & vbCrLf
        LoadDataSource(tdbcMethodID, sSQL, gbUnicode)

        'Load tdbcMethodEndID
        sSQL = "SELECT     Convert(Varchar(20),IntCode) as MethodEndID,  " & vbCrLf
        sSQL &= "           Description" & UnicodeJoin(gbUnicode) & " As MethodEndName " & vbCrLf
        sSQL &= "FROM       D02T8000  WITH(NOLOCK) " & vbCrLf
        sSQL &= "WHERE      ModuleID ='02' and Type =1  and Language = 84 " & vbCrLf
        sSQL &= "ORDER BY   intCode" & vbCrLf
        LoadDataSource(tdbcMethodEndID, sSQL, gbUnicode)

        'Load tdbcAssetS1Default
        sSQL = "SELECT     AssetS1ID, AssetS1Name" & UnicodeJoin(gbUnicode) & " As AssetS1Name" & vbCrLf
        sSQL &= "FROM       D02T1000  WITH(NOLOCK) " & vbCrLf
        sSQL &= "WHERE      Disabled = 0 " & vbCrLf
        sSQL &= "ORDER BY   AssetS1ID" & vbCrLf
        LoadDataSource(tdbcAssetS1Default, sSQL, gbUnicode)
        LoadDataSource(tdbcCIPS1Default, sSQL, gbUnicode)

        'Load tdbcAssetS2Default
        sSQL = "SELECT     AssetS2ID, AssetS2Name" & UnicodeJoin(gbUnicode) & " As AssetS2Name" & vbCrLf
        sSQL &= "FROM       D02T2000  WITH(NOLOCK) " & vbCrLf
        sSQL &= "WHERE      Disabled = 0 " & vbCrLf
        sSQL &= "ORDER BY   AssetS2ID" & vbCrLf
        LoadDataSource(tdbcAssetS2Default, sSQL, gbUnicode)
        LoadDataSource(tdbcCIPS2Default, sSQL, gbUnicode)

        'Load tdbcAssetS3Enabled
        sSQL = "SELECT     AssetS3ID, AssetS3Name" & UnicodeJoin(gbUnicode) & " As AssetS3Name" & vbCrLf
        sSQL &= "FROM       D02T3000  WITH(NOLOCK) " & vbCrLf
        sSQL &= "WHERE      Disabled = 0 " & vbCrLf
        sSQL &= "ORDER BY   AssetS3ID" & vbCrLf
        LoadDataSource(tdbcAssetS3Default, sSQL, gbUnicode)
        LoadDataSource(tdbcCIPS3Default, sSQL, gbUnicode)

        'Load cboAssetSeperator
        sSQL = "Select '-' as AssetSeperatorID, N'-" & Space(2) & IIf(gbUnicode, rl3("Dau_gach_ngang"), ConvertUnicodeToVni(rl3("Dau_gach_ngang"))).ToString() & "' As AssetSeperatorName" & vbCrLf
        sSQL &= "Union" & vbCrLf
        sSQL &= "Select '*' as AssetSeperatorID, N'*" & Space(2) & IIf(gbUnicode, rl3("Dau_sao"), ConvertUnicodeToVni(rl3("Dau_sao"))).ToString() & "' As AssetSeperatorName" & vbCrLf
        sSQL &= "Union" & vbCrLf
        sSQL &= "Select '/' as AssetSeperatorID, N'/" & Space(2) & IIf(gbUnicode, rl3("Dau_suyet"), ConvertUnicodeToVni(rl3("Dau_suyet"))).ToString() & "' As AssetSeperatorName" & vbCrLf
        sSQL &= "Union" & vbCrLf
        sSQL &= "Select '.' as AssetSeperatorID, N'." & Space(2) & IIf(gbUnicode, rl3("Dau_cham"), ConvertUnicodeToVni(rl3("Dau_cham"))).ToString() & "' As AssetSeperatorName" & vbCrLf
        sSQL &= "Union" & vbCrLf
        sSQL &= "Select ',' as AssetSeperatorID, N'," & Space(2) & IIf(gbUnicode, rl3("Dau_phay"), ConvertUnicodeToVni(rl3("Dau_phay"))).ToString() & "' As AssetSeperatorName" & vbCrLf
        sSQL &= "Union" & vbCrLf
        sSQL &= "Select ';' as AssetSeperatorID, N';" & Space(2) & IIf(gbUnicode, rl3("Dau_cham_phay"), ConvertUnicodeToVni(rl3("Dau_cham_phay"))).ToString() & "' As AssetSeperatorName" & vbCrLf
        LoadDataSource(tdbcAssetSeperator, sSQL, gbUnicode)
        LoadDataSource(tdbcCIPSeperator, sSQL, gbUnicode)
        'Load cboAssetOutputOrder
        cboAssetOutputOrder.Items.Add("SSSN")
        cboAssetOutputOrder.Items.Add("SSNS")
        cboAssetOutputOrder.Items.Add("SNSS")
        cboAssetOutputOrder.Items.Add("NSSS")

        cboCIPOutputOrder.Items.Add("SSSN")
        cboCIPOutputOrder.Items.Add("SSNS")
        cboCIPOutputOrder.Items.Add("SNSS")
        cboCIPOutputOrder.Items.Add("NSSS")

    End Sub
    Private Sub LoadTDBDropdown()
        Dim sSQL As String = ""
        sSQL = SQLStoreD02P0080("VoucherType")
        LoadDataSource(tdbdVoucherTypeID, sSQL, gbUnicode)
    End Sub

    Private Sub LoadTDBGridTab5()
        Dim sSQL As String = ""
        sSQL = SQLStoreD02P0080("Grid")
        LoadDataSource(tdbg, sSQL, gbUnicode)
    End Sub

#Region "Events Combo"

#Region "Events tdbcDivisionID with txtDivisionName"

    Private Sub tdbcDivisionID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.Close
        If tdbcDivisionID.FindStringExact(tdbcDivisionID.Text) = -1 Then
            tdbcDivisionID.Text = ""
            txtDivisionName.Text = ""
        End If
    End Sub

    Private Sub tdbcDivisionID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.SelectedValueChanged
        txtDivisionName.Text = tdbcDivisionID.Columns(1).Value.ToString
        LoadPeriodNumberAndDefaultPeriod()
    End Sub

    Private Sub tdbcDivisionID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcDivisionID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcDivisionID.Text = ""
            txtDivisionName.Text = ""
        End If
    End Sub

#End Region

#Region "Events tdbcDefAssetAccountID"

    Private Sub tdbcDefAssetAccountID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDefAssetAccountID.LostFocus
        If tdbcDefAssetAccountID.FindStringExact(tdbcDefAssetAccountID.Text) = -1 Then tdbcDefAssetAccountID.Text = ""
    End Sub

#End Region

#Region "Events tdbcDefDepreciateAccountID"

    Private Sub tdbcDefDepreciateAccountID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDefDepreciationAccountID.LostFocus
        If tdbcDefDepreciationAccountID.FindStringExact(tdbcDefDepreciationAccountID.Text) = -1 Then tdbcDefDepreciationAccountID.Text = ""
    End Sub

#End Region

#Region "Events tdbcDefSourceID"

    Private Sub tdbcDefSourceID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDefSourceID.LostFocus
        If tdbcDefSourceID.FindStringExact(tdbcDefSourceID.Text) = -1 Then tdbcDefSourceID.Text = ""
    End Sub

#End Region

#Region "Events tdbcDefAssignmentID"

    Private Sub tdbcDefAssignmentID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDefAssignmentID.LostFocus
        If tdbcDefAssignmentID.FindStringExact(tdbcDefAssignmentID.Text) = -1 Then tdbcDefAssignmentID.Text = ""
    End Sub

#End Region

#Region "Events tdbcMethodID"

    Private Sub tdbcMethodID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcMethodID.LostFocus
        If tdbcMethodID.FindStringExact(tdbcMethodID.Text) = -1 Then tdbcMethodID.Text = ""
    End Sub

#End Region

#Region "Events tdbcMethodEndID"

    Private Sub tdbcMethodEndID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcMethodEndID.LostFocus
        If tdbcMethodEndID.FindStringExact(tdbcMethodEndID.Text) = -1 Then tdbcMethodEndID.Text = ""
    End Sub

#End Region

#Region "Events tdbcAssetS1Default"

    Private Sub tdbcAssetS1Default_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcAssetS1Default.LostFocus
        If tdbcAssetS1Default.FindStringExact(tdbcAssetS1Default.Text) = -1 Then tdbcAssetS1Default.Text = ""
    End Sub

#End Region

#Region "Events tdbcAssetS2Default"

    Private Sub tdbcAssetS2Default_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcAssetS2Default.LostFocus
        If tdbcAssetS2Default.FindStringExact(tdbcAssetS2Default.Text) = -1 Then tdbcAssetS2Default.Text = ""
    End Sub

#End Region

#Region "Events tdbcAssetS3Default"

    Private Sub tdbcAssetS3Default_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcAssetS3Default.LostFocus
        If tdbcAssetS3Default.FindStringExact(tdbcAssetS3Default.Text) = -1 Then tdbcAssetS3Default.Text = ""
    End Sub

#End Region

#Region "Events tdbcAssetSeperator"

    Private Sub tdbcAssetSeperator_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcAssetSeperator.LostFocus
        If tdbcAssetSeperator.FindStringExact(tdbcAssetSeperator.Text) = -1 Then tdbcAssetSeperator.Text = ""
    End Sub

    Private Sub tdbcAssetSeperator_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcAssetSeperator.SelectedValueChanged
        CalAssetOutputLength()
    End Sub

    Private Sub tdbcCIPSeperator_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcCIPSeperator.SelectedValueChanged
        CalCIPOutputLength()
    End Sub
#End Region

    Private Sub tdbcName_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcDefSourceID.Close, tdbcMethodID.Close, tdbcMethodEndID.Close
        tdbcName_Validated(sender, Nothing)
    End Sub

    Private Sub tdbcName_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcDefSourceID.Validated, tdbcMethodID.Validated, tdbcMethodEndID.Validated
        Dim tdbc As C1.Win.C1List.C1Combo = CType(sender, C1.Win.C1List.C1Combo)
        tdbc.Text = tdbc.WillChangeToText
    End Sub

#End Region

    Private Sub LoadEdit()

     
        With D02Systems
         
            If gbCallDesktop Then 'ID 88532 29/06/2016
                Lemon3.D00Systems.LockControlsFromDesktop(tdbcDivisionID)
            Else
                If Not IsDBNull(.DefaultDivisionID) Then
                    tdbcDivisionID.SelectedValue = .DefaultDivisionID
                    tdbcDivisionID.Tag = .DefaultDivisionID
                End If
            End If
            ' TK tài sản
            tdbcDefAssetAccountID.SelectedValue = .DefAssetAccountID
            ' TK khấu hao
            tdbcDefDepreciationAccountID.SelectedValue = .DefDepreciationAccountID
            ' Nguồn vốn
            tdbcDefSourceID.SelectedValue = .DefSourceID
            ' Phân bổ KH
            tdbcDefAssignmentID.SelectedValue = .DefAssignmentID
            ' Phương pháp KH
            tdbcMethodID.SelectedValue = .MethodID
            ' Xử lý KH kỳ cuối
            tdbcMethodEndID.SelectedValue = .MethodEndID
            ' Các bút toán giảm TS
            chkDecreaseAsset.Checked = .DecreaseAsset

            'Tạo mã tự động cho tài sản cố định
            If L3Int(.AssetAuto) = 1 Then
                chkAssetAuto.Checked = True
                optAssetAuto1.Checked = True
                optShowFormAotuCreate0.Checked = False
            ElseIf L3Int(.AssetAuto) = 2 Then
                chkAssetAuto.Checked = True
                optAssetAuto2.Checked = True
                If .IsShowFormAutoCreate Then
                    optShowFormAotuCreate1.Checked = True
                Else
                    optShowFormAotuCreate0.Checked = True
                End If

            Else
                chkAssetAuto.Checked = False
                optAssetAuto1.Checked = False
                optAssetAuto1.Enabled = False
                optAssetAuto2.Checked = False
                optAssetAuto2.Enabled = False
            End If
            ' Phân loại 1
            chkAssetS1Enabled.Checked = .AssetS1Enabled
            ' AssetS1Default
            tdbcAssetS1Default.SelectedValue = .AssetS1Default
            ' S1Length
            txtS1Length.Text = .S1Length.ToString()
            chkAssetS1Enabled_Click(Nothing, Nothing)

            ' Phân loại 2
            chkAssetS2Enabled.Checked = .AssetS2Enabled
            ' AssetS2Default
            tdbcAssetS2Default.SelectedValue = .AssetS2Default
            ' S2Length
            txtS2Length.Text = .S2Length.ToString()
            chkAssetS2Enabled_Click(Nothing, Nothing)

            ' Phân loại 3
            chkAssetS3Enabled.Checked = .AssetS3Enabled
            ' AssetS3Default
            tdbcAssetS3Default.SelectedValue = .AssetS3Default
            ' S3Length
            txtS3Length.Text = .S3Length.ToString()
            chkAssetS3Enabled_Click(Nothing, Nothing)


            ' Dấu phân cách
            chkAssetSeperated.Checked = .AssetSeperated
            ' Dấu phân cách
            tdbcAssetSeperator.SelectedValue = .AssetSeperator
            ' Dạng hiển thị
            cboAssetOutputOrder.Text = .AssetOutputOrder
            ' Độ dài số
            If .AutoNumberLength > 0 Then updownAutoNumberLength.Value = .AutoNumberLength
            ' Độ dài mã
            txtAssetOutputLength.Text = .AssetOutputLength.ToString()

            ' update 3/6/2013 id 56102
            If L3Int(.AssetAuto) <> 2 Then
                chkCheckAssetOutputLength.Checked = .AssetOutputLength <> 0
            End If

            txtCheckAssetOutputLength.Text = .AssetOutputLength.ToString()
            chkCheckAssetOutputLength_CheckedChanged(Nothing, Nothing)

            chkIsAssetIDForD02D43.Checked = .IsAssetIDForD02D43
            chkUseProperty.Checked = .UseProperty


            ''Phan danh cho XDCB
            If L3Int(.CIPAuto) = 2 Then
                chkCIPAuto.Checked = True
                optCIPAuto1.Checked = True
            ElseIf L3Int(.CIPAuto) = 1 Then
                chkCIPAuto.Checked = True
                optCIPAuto2.Checked = True
            Else
                chkCIPAuto.Checked = False
                optCIPAuto1.Checked = False
                optCIPAuto1.Enabled = False
                optCIPAuto2.Checked = False
                optCIPAuto2.Enabled = False
            End If
            chkCIPS1Enabled.Checked = .CIPS1Enabled
            tdbcCIPS1Default.SelectedValue = .CIPS1Default
            txtCIPS1Length.Text = .CIPS1Length.ToString
            chkCIPS1Enabled_Click(Nothing, Nothing)

            chkCIPS2Enabled.Checked = .CIPS2Enabled
            tdbcCIPS2Default.SelectedValue = .CIPS2Default
            txtCIPS2Length.Text = .CIPS2Length.ToString
            chkCIPS2Enabled_Click(Nothing, Nothing)

            chkCIPS3Enabled.Checked = .CIPS3Enabled
            tdbcCIPS3Default.SelectedValue = .CIPS3Default
            txtCIPS3Length.Text = .CIPS3Length.ToString
            chkCIPS3Enabled_Click(Nothing, Nothing)

            chkCIPSeperated.Checked = .CIPSeperated
            tdbcCIPSeperator.SelectedValue = .CIPSeperator.ToString
            cboCIPOutputOrder.Text = .CIPOutputOrder
            If .CIPAutoNumberLength > 0 Then updownCIPAutoNumberLength.Value = .CIPAutoNumberLength
            txtCIPOutputLength.Text = .CIPOutputLength.ToString()
            If L3Int(.CIPAuto) <> 1 Then
                chkCIPCheckOutputLength.Checked = .CIPOutputLength <> 0
            End If
            txtCIPCheckOutputLength.Text = .CIPOutputLength.ToString
            chkCIPCheckOutputLength_CheckedChanged(Nothing, Nothing)

            chkObligatoryReceiver.Checked = .ObligatoryReceiver
            chkUseD54ForCIP.Checked = L3Bool(.UseD54ForCIP)
            chkUseBudgetForCIP.Checked = L3Bool(.UseBudgetForCIP)
            chkCIPforPropertyProduct.Checked = .CIPforPropertyProduct
            chkIsCheckNormIDAllocated.Checked = .IsCheckNormIDAllocated
            chkAllowChangeDivision.Checked = .AllowChangeDivision '28/3/2017, Trần Hoàng Anh: id 75367-Bổ sung tính năng điều chuyển đơn vị TSCĐ

            chkIsAllowChangeAccount.Checked = .IsAllowChangeAccount '17/5/2017, Trần Hoàng Anh: id 96202
            chkIsCalDepByDate.Checked = .IsCalDepByDate '17/8/2020, Đặng Ngọc Tài:id 142642-SVI_Bổ sung tính năng tạo mức khấu hao theo ngày trong Kỳ đầu tiên module Tài sản cố định
            chkIsEditAnaID.Checked = .IsEditAnaID '31/8/2021, Nguyễn Thị Mỹ Lài:id 180303-Cho phép sửa khoản mục Kcode khi tính KH TSCD (màn hình D2F5012) Hùng Vương
            chkIsCalPeriodByRate.Checked = .IsCalPeriodByRate '31/3/2022, Bùi Thị Thanh Tuyền:id 214947-ORG - Phát triển khi hình thành tài sản cố định nhập tỷ lệ khấu hao (theo năm) thì tính ngược lại số kỳ, giá trị phân bổ
            chkIsObligatoryManagement.Checked = .IsObligatoryManagement
        End With

    End Sub

    Private Sub UpadateSystems()
        With D02Systems
            '.DefaultDivisionID = tdbcDivisionID.Text
            If gbCallDesktop = False Then .DefaultDivisionID = ReturnValueC1Combo(tdbcDivisionID).ToString 'ID 88532 29/06/2016
            ' TK tài sản
            .DefAssetAccountID = ComboValue(tdbcDefAssetAccountID)
            ' TK khấu hao
            .DefDepreciationAccountID = ComboValue(tdbcDefDepreciationAccountID)
            ' Nguồn vốn
            .DefSourceID = ComboValue(tdbcDefSourceID)
            ' Phân bổ KH
            .DefAssignmentID = ComboValue(tdbcDefAssignmentID)
            ' Phương pháp KH
            .MethodID = ComboValue(tdbcMethodID)
            ' Xử lý KH kỳ cuối
            .MethodEndID = ComboValue(tdbcMethodEndID)
            ' Các bút toán giảm TS
            .DecreaseAsset = chkDecreaseAsset.Checked
            ' Tạo mã tự động cho tài sản cố định
            If optAssetAuto1.Checked Then
                .AssetAuto = 1
            ElseIf optAssetAuto2.Checked Then
                .AssetAuto = 2
            Else
                .AssetAuto = 0
            End If

            ' Phân loại 1
            .AssetS1Enabled = chkAssetS1Enabled.Checked
            ' Phân loại 2
            .AssetS2Enabled = chkAssetS2Enabled.Checked
            ' Phân loại 3
            .AssetS3Enabled = chkAssetS3Enabled.Checked
            ' AssetS1Default
            .AssetS1Default = ComboValue(tdbcAssetS1Default)
            ' AssetS2Default
            .AssetS2Default = ComboValue(tdbcAssetS2Default)
            ' AssetS3Default
            .AssetS3Default = ComboValue(tdbcAssetS3Default)
            ' S1Length
            .S1Length = L3Int(txtS1Length.Text)
            ' S2Length
            .S2Length = L3Int(txtS2Length.Text)
            ' S3Length
            .S3Length = L3Int(txtS3Length.Text)
            ' Dấu phân cách
            .AssetSeperated = chkAssetSeperated.Checked
            ' Dấu phân cách
            .AssetSeperator = ComboValue(tdbcAssetSeperator)
            ' Dạng hiển thị
            .AssetOutputOrder = cboAssetOutputOrder.Text
            ' Độ dài số
            .AutoNumberLength = L3Int(updownAutoNumberLength.Value)
            ' Độ dài mã
            ' update 3/6/2013 id 56102
            .AssetOutputLength = L3Int(txtCheckAssetOutputLength.Text) '.AssetOutputLength = L3Int(txtAssetOutputLength.Text)
            .IsAssetIDForD02D43 = chkIsAssetIDForD02D43.Checked
            .UseProperty = chkUseProperty.Checked
            'Phan danh cho XDCB
            If optCIPAuto1.Checked Then
                .CIPAuto = 2
            ElseIf optCIPAuto2.Checked Then
                .CIPAuto = 1
            Else
                .CIPAuto = 0
            End If
            .CIPS1Enabled = chkCIPS1Enabled.Checked
            .CIPS2Enabled = chkCIPS2Enabled.Checked
            .CIPS3Enabled = chkCIPS3Enabled.Checked
            .CIPS1Default = ReturnValueC1Combo(tdbcCIPS1Default)
            .CIPS2Default = ReturnValueC1Combo(tdbcCIPS2Default)
            .CIPS3Default = ReturnValueC1Combo(tdbcCIPS3Default)
            .CIPOutputOrder = cboCIPOutputOrder.Text
            .CIPOutputLength = L3Int(txtCIPCheckOutputLength.Text)
            .CIPSeperated = chkCIPSeperated.Checked
            .CIPS1Length = L3Int(txtCIPS1Length.Text)
            .CIPS2Length = L3Int(txtCIPS2Length.Text)
            .CIPS3Length = L3Int(txtCIPS3Length.Text)
            .CIPSeperator = ReturnValueC1Combo(tdbcCIPSeperator)
            .CIPAutoNumberLength = L3Int(updownCIPAutoNumberLength.Value)
            .ObligatoryReceiver = chkObligatoryReceiver.Checked
            .UseD54ForCIP = L3Int(chkUseD54ForCIP.Checked)
            .UseBudgetForCIP = L3Int(chkUseBudgetForCIP.Checked)
            .CIPforPropertyProduct = chkCIPforPropertyProduct.Checked
            .IsCheckNormIDAllocated = chkIsCheckNormIDAllocated.Checked
            .AllowChangeDivision = chkAllowChangeDivision.Checked '28/3/2017, Trần Hoàng Anh: id 75367-Bổ sung tính năng điều chuyển đơn vị TSCĐ
            .IsShowFormAutoCreate = L3Bool(IIf(optShowFormAotuCreate0.Checked, 0, 1))
            .IsAllowChangeAccount = chkIsAllowChangeAccount.Checked
            .IsCalDepByDate = chkIsCalDepByDate.Checked '17/8/2020, Đặng Ngọc Tài:id 142642-SVI_Bổ sung tính năng tạo mức khấu hao theo ngày trong Kỳ đầu tiên module Tài sản cố định
            .IsEditAnaID = chkIsEditAnaID.Checked '31/8/2021, Nguyễn Thị Mỹ Lài:id 180303-Cho phép sửa khoản mục Kcode khi tính KH TSCD (màn hình D2F5012) Hùng Vương
            .IsCalPeriodByRate = chkIsCalPeriodByRate.Checked '31/3/2022, Bùi Thị Thanh Tuyền:id 214947-ORG - Phát triển khi hình thành tài sản cố định nhập tỷ lệ khấu hao (theo năm) thì tính ngược lại số kỳ, giá trị phân bổ
            .IsObligatoryManagement = chkIsObligatoryManagement.Checked '15/11/2022 - ID 250796 : Bổ sung checkbox bắt buộc nhập Bộ phận quản lý
        End With

    End Sub

    Private Sub LoadPeriodNumberAndDefaultPeriod()
        Dim sSQL As String = "Select PeriodNumber From D91T0025 WITH(NOLOCK) "
        txtPeriodNumber.Text = ReturnScalar(sSQL)
        sSQL = "Select Top 1 Replace(Str(TranMonth, 2), ' ', '0') + '/' + LTrim(Str(TranYear)) As DefaultPeriod From D02T9999 D02  WITH(NOLOCK) Where D02.DivisionID = " & SQLString(tdbcDivisionID.SelectedValue) & " Order By (TranYear * 100 + TranMonth) Desc"
        Dim dt As DataTable = ReturnDataTable(sSQL)
        If dt.Rows.Count > 0 Then
            txtDefaultPeriod.Text = dt.Rows(0).Item("DefaultPeriod").ToString
        End If
        dt.Dispose()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        bFormClosed = True
        'If _FormState = EnumFormState.FormAdd Then End
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sSQL As String = ""
        If AskSave() = Windows.Forms.DialogResult.No Then Exit Sub
        If Not AllowSave() Then Exit Sub
        Select Case _FormState
            Case EnumFormState.FormAdd
                'Dữ liệu trong bảng D02T0000 chỉ có 1 dòng duy nhất
                'Nên trước khi Insert thì xóa dữ liệu rác
                sSQL = SQLDeleteD02T0000().ToString() & vbCrLf
                sSQL &= SQLInsertD02T0000().ToString()
                sSQL &= SQLDeleteD02T0080() & vbCrLf
                sSQL &= SQLInsertD02T0080().ToString()
            Case EnumFormState.FormEdit
                sSQL = SQLUpdateD02T0000().ToString()
                sSQL &= SQLDeleteD02T0080() & vbCrLf
                sSQL &= SQLInsertD02T0080().ToString()
        End Select
        Me.Cursor = Cursors.WaitCursor
        Dim bRunSQL As Boolean = ExecuteSQL(sSQL)
        Me.Cursor = Cursors.Default
        If bRunSQL Then
            UpadateSystems()
            If _FormState = EnumFormState.FormEdit Then
                'If Convert.ToBoolean(chkDivisionLocked.Tag) <> chkDivisionLocked.Checked OrElse tdbcDivisionID.Tag.ToString <> tdbcDivisionID.SelectedValue.ToString Then
                If tdbcDivisionID.Tag.ToString <> tdbcDivisionID.SelectedValue.ToString Then
                    D99C0008.MsgSetUpDivision()
                Else
                    SaveOK()
                End If
            Else
                SaveOK()
            End If
        Else
            SaveNotOK()
        End If

        bFormClosed = True
        Me.Close()
    End Sub

    Private Function AllowSave() As Boolean
        'If tdbcDivisionID.Text = "" Then
        '    D99C0008.MsgNotYetEnter(rl3("Don_vi"))
        '    tdbcDivisionID.Focus()
        '    Return False
        'End If
        If gbCallDesktop = False AndAlso tdbcDivisionID.Text = "" Then 'ID 88532 29/06/2016
            D99C0008.MsgNotYetEnter(rL3("Don_vi"))
            tabSystem.SelectedIndex = 0
            tdbcDivisionID.Focus()
            Return False
        End If
        'Phan nay danh cho kiem tra tab tài sản
        If chkAssetAuto.Checked And optAssetAuto1.Checked Then
            If chkAssetS1Enabled.Checked Then
                If tdbcAssetS1Default.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Phan_loai") & " 1")
                    tdbcAssetS1Default.Focus()
                    Return False
                End If
                If txtS1Length.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Do_dai") & Space(1) & rL3("Phan_loai") & " 1")
                    txtS1Length.Focus()
                    Return False
                End If
                If Number(txtS1Length.Text) <= 0 Or Number(txtS1Length.Text) > 20 Then
                    D99C0008.MsgL3(rL3("MSG000009"))
                    txtS1Length.Focus()
                    Return False
                End If
            End If
            If chkAssetS2Enabled.Checked Then
                If tdbcAssetS2Default.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Phan_loai") & " 2")
                    tdbcAssetS2Default.Focus()
                    Return False
                End If
                If txtS2Length.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Do_dai") & Space(1) & rL3("Phan_loai") & " 2")
                    txtS2Length.Focus()
                    Return False
                End If
                If Number(txtS2Length.Text) <= 0 Or Number(txtS2Length.Text) > 20 Then
                    D99C0008.MsgL3(rL3("MSG000009"))
                    txtS2Length.Focus()
                    Return False
                End If
            End If
            If chkAssetS3Enabled.Checked Then
                If tdbcAssetS3Default.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Phan_loai") & " 3")
                    tdbcAssetS3Default.Focus()
                    Return False
                End If
                If txtS3Length.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Do_dai") & Space(1) & rL3("Phan_loai") & " 3")
                    txtS3Length.Focus()
                    Return False
                End If
                If Number(txtS3Length.Text) <= 0 Or Number(txtS3Length.Text) > 20 Then
                    D99C0008.MsgL3(rL3("MSG000009"))
                    txtS3Length.Focus()
                    Return False
                End If
            End If
            If chkAssetSeperated.Checked Then
                If tdbcAssetSeperator.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Dau_phan_cach"))
                    tdbcAssetSeperator.Focus()
                    Return False
                End If
            End If
            If Number(txtAssetOutputLength.Text) <= 0 Or Number(txtAssetOutputLength.Text) > 20 Then
                D99C0008.MsgL3(rL3("MSG000009"))
                txtAssetOutputLength.Focus()
                Return False
            End If
        Else
            If chkCheckAssetOutputLength.Enabled And chkCheckAssetOutputLength.Checked Then
                If Number(txtCheckAssetOutputLength.Text) <= 0 Or Number(txtCheckAssetOutputLength.Text) > 20 Then
                    D99C0008.MsgL3(rL3("MSG000009"))
                    txtCheckAssetOutputLength.Focus()
                    Return False
                End If
            End If
        End If

        'Phan nay danh cho kiem tra tab XDCB
        If chkCIPAuto.Checked And optCIPAuto1.Checked Then
            If chkCIPS1Enabled.Checked Then
                If tdbcCIPS1Default.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Phan_loai") & " 1")
                    tdbcCIPS1Default.Focus()
                    Return False
                End If
                If txtCIPS1Length.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Do_dai") & Space(1) & rL3("Phan_loai") & " 1")
                    txtCIPS1Length.Focus()
                    Return False
                End If
                If Number(txtCIPS1Length.Text) <= 0 Or Number(txtCIPS1Length.Text) > 20 Then
                    D99C0008.MsgL3(rL3("MSG000009"))
                    txtS1Length.Focus()
                    Return False
                End If
            End If
            If chkCIPS2Enabled.Checked Then
                If tdbcCIPS2Default.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Phan_loai") & " 2")
                    tdbcCIPS2Default.Focus()
                    Return False
                End If
                If txtCIPS2Length.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Do_dai") & Space(1) & rL3("Phan_loai") & " 2")
                    txtCIPS2Length.Focus()
                    Return False
                End If
                If Number(txtCIPS2Length.Text) <= 0 Or Number(txtCIPS2Length.Text) > 20 Then
                    D99C0008.MsgL3(rL3("MSG000009"))
                    txtCIPS2Length.Focus()
                    Return False
                End If
            End If
            If chkCIPS3Enabled.Checked Then
                If tdbcCIPS3Default.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Phan_loai") & " 3")
                    tdbcCIPS3Default.Focus()
                    Return False
                End If
                If txtCIPS3Length.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Do_dai") & Space(1) & rL3("Phan_loai") & " 3")
                    txtCIPS3Length.Focus()
                    Return False
                End If
                If Number(txtCIPS3Length.Text) <= 0 Or Number(txtCIPS3Length.Text) > 20 Then
                    D99C0008.MsgL3(rL3("MSG000009"))
                    txtCIPS3Length.Focus()
                    Return False
                End If
            End If
            If chkCIPSeperated.Checked Then
                If tdbcCIPSeperator.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rL3("Dau_phan_cach"))
                    tdbcCIPSeperator.Focus()
                    Return False
                End If
            End If
            If Number(txtCIPOutputLength.Text) <= 0 Or Number(txtCIPOutputLength.Text) > 20 Then
                D99C0008.MsgL3(rL3("MSG000009"))
                txtAssetOutputLength.Focus()
                Return False
            End If
        Else
            If chkCIPCheckOutputLength.Enabled And chkCIPCheckOutputLength.Checked Then
                If Number(txtCIPCheckOutputLength.Text) <= 0 Or Number(txtCIPCheckOutputLength.Text) > 20 Then
                    D99C0008.MsgL3(rL3("MSG000009"))
                    txtCIPCheckOutputLength.Focus()
                    Return False
                End If
            End If
        End If

        Return True
    End Function

    Private Sub chkAssetAuto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAssetAuto.Click
        CalAssetOutputLength()
        If chkAssetAuto.Checked Then
            optAssetAuto1.Checked = True
            If optAssetAuto1.Checked Then
                grpAssetCategories.Enabled = True
                grpAutoAssetNumbering.Enabled = True
            Else
                grpAssetCategories.Enabled = False
                grpAutoAssetNumbering.Enabled = False
            End If

            ' update 3/6/2013 id 56102
            chkCheckAssetOutputLength.Enabled = False
            chkCheckAssetOutputLength_CheckedChanged(Nothing, Nothing)
            txtCheckAssetOutputLength.Text = txtAssetOutputLength.Text

            UnReadOnlyControl(False, optAssetAuto1, optAssetAuto2)
        Else
            grpAssetCategories.Enabled = False
            grpAutoAssetNumbering.Enabled = False

            chkCheckAssetOutputLength.Enabled = True
            chkCheckAssetOutputLength.Checked = False
            chkCheckAssetOutputLength_CheckedChanged(Nothing, Nothing)
            txtCheckAssetOutputLength.Text = "0"
            ReadOnlyControl(optAssetAuto1, optAssetAuto2)
            optAssetAuto1.Checked = False
            optAssetAuto2.Checked = False
            optShowFormAotuCreate0.Checked = False
            optShowFormAotuCreate1.Checked = False
        End If
    End Sub

    ' update 3/6/2013 id 56102
    Private Sub txtCheckAssetOutputLength_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheckAssetOutputLength.KeyPress
        e.Handled = CheckKeyPress(e.KeyChar, EnumKey.Number)
    End Sub

    ' update 3/6/2013 id 56102
    Private Sub txtAssetOutputLength_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAssetOutputLength.TextChanged
        txtCheckAssetOutputLength.Text = txtAssetOutputLength.Text
    End Sub

    Private Sub txtCIPOutputLength_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCIPOutputLength.TextChanged
        txtCIPCheckOutputLength.Text = txtCIPOutputLength.Text
    End Sub

    ' update 3/6/2013 id 56102
    Private Sub chkCheckAssetOutputLength_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckAssetOutputLength.CheckedChanged
        If chkCheckAssetOutputLength.Checked And Not chkAssetAuto.Checked Then
            UnReadOnlyControl(False, txtCheckAssetOutputLength)

        Else
            If chkCheckAssetOutputLength.Enabled Then
                txtCheckAssetOutputLength.Text = "0"
            End If
            'txtCheckAssetOutputLength.Text = "0"
            ReadOnlyControl(txtCheckAssetOutputLength)
        End If
    End Sub

    Private Sub chkCIPCheckOutputLength_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCIPCheckOutputLength.CheckedChanged
        If chkCIPCheckOutputLength.Checked And Not chkCIPAuto.Checked Then
            UnReadOnlyControl(False, txtCIPCheckOutputLength)
        Else
            If chkCIPCheckOutputLength.Enabled Then
                txtCIPCheckOutputLength.Text = "0"
            End If
            'txtCIPCheckOutputLength.Text = "0"
            ReadOnlyControl(txtCIPCheckOutputLength)
        End If
    End Sub

    Private Sub chkAssetS1Enabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAssetS1Enabled.Click
        'If chkAssetS1Enabled.Checked Then
        '    UnReadOnlyControl(tdbcAssetS1Default)
        '    UnReadOnlyControl(txtS1Length)
        'Else
        '    ReadOnlyControl(tdbcAssetS1Default)
        '    ReadOnlyControl(txtS1Length)
        'End If
        'CalAssetOutputLength()
    End Sub

    Private Sub chkCIPS1Enabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCIPS1Enabled.Click
        'If chkCIPS1Enabled.Checked Then
        '    UnReadOnlyControl(tdbcCIPS1Default)
        '    UnReadOnlyControl(txtCIPS1Length)
        'Else
        '    ReadOnlyControl(tdbcCIPS1Default)
        '    ReadOnlyControl(txtCIPS1Length)
        'End If
        'CalCIPOutputLength()
    End Sub

    Private Sub chkAssetS2Enabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAssetS2Enabled.Click
        'If chkAssetS2Enabled.Checked Then
        '    UnReadOnlyControl(tdbcAssetS2Default)
        '    UnReadOnlyControl(txtS2Length)
        'Else
        '    ReadOnlyControl(tdbcAssetS2Default)
        '    ReadOnlyControl(txtS2Length)
        'End If
        'CalAssetOutputLength()
    End Sub

    Private Sub chkCIPS2Enabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCIPS2Enabled.Click
        'If chkCIPS2Enabled.Checked Then
        '    UnReadOnlyControl(tdbcCIPS2Default)
        '    UnReadOnlyControl(txtCIPS2Length)
        'Else
        '    ReadOnlyControl(tdbcCIPS2Default)
        '    ReadOnlyControl(txtCIPS2Length)
        'End If
        'CalCIPOutputLength()
    End Sub

    Private Sub chkAssetS3Enabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAssetS3Enabled.Click
        'If chkAssetS3Enabled.Checked Then
        '    UnReadOnlyControl(tdbcAssetS3Default)
        '    UnReadOnlyControl(txtS3Length)
        'Else
        '    ReadOnlyControl(tdbcAssetS3Default)
        '    ReadOnlyControl(txtS3Length)
        'End If
        'CalAssetOutputLength()
    End Sub

    Private Sub chkCIPS3Enabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCIPS3Enabled.Click
        'If chkCIPS3Enabled.Checked Then
        '    UnReadOnlyControl(tdbcCIPS3Default)
        '    UnReadOnlyControl(txtCIPS3Length)
        'Else
        '    ReadOnlyControl(tdbcCIPS3Default)
        '    ReadOnlyControl(txtCIPS3Length)
        'End If
        'CalCIPOutputLength()
    End Sub

    Private Sub chkAssetSeperated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAssetSeperated.Click
        'If chkAssetSeperated.Checked Then
        '    UnReadOnlyControl(tdbcAssetSeperator)
        'Else
        '    tdbcAssetSeperator.Text = ""
        '    ReadOnlyControl(tdbcAssetSeperator)
        'End If
    End Sub

    Private Sub chkCIPSeperated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCIPSeperated.Click
        'If chkCIPSeperated.Checked Then
        '    UnReadOnlyControl(tdbcCIPSeperator)
        'Else
        '    tdbcCIPSeperator.Text = ""
        '    ReadOnlyControl(tdbcCIPSeperator)
        'End If
    End Sub

    Private Sub txtS1Length_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtS1Length.KeyPress, txtS2Length.KeyPress, txtS3Length.KeyPress
        e.Handled = CheckKeyPress(e.KeyChar, EnumKey.Number)
    End Sub

    Private Sub txtSxLength_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtS1Length.LostFocus, txtS2Length.LostFocus, txtS3Length.LostFocus
        CalAssetOutputLength()
    End Sub

    Private Sub txtCIPS1Length_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCIPS1Length.KeyPress, txtCIPS2Length.KeyPress, txtCIPS3Length.KeyPress
        e.Handled = CheckKeyPress(e.KeyChar, EnumKey.Number)
    End Sub

    Private Sub txtCIPSxLength_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCIPS1Length.LostFocus, txtCIPS2Length.LostFocus, txtCIPS3Length.LostFocus
        CalCIPOutputLength()
    End Sub

    Private Sub updownAutoNumberLength_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles updownAutoNumberLength.ValueChanged
        CalAssetOutputLength()
    End Sub

    Private Sub updownCIPAutoNumberLength_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles updownCIPAutoNumberLength.ValueChanged
        CalCIPOutputLength()
    End Sub

    Private Sub cboAssetOutputOrder_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAssetOutputOrder.SelectedValueChanged
        CalAssetOutputLength()
    End Sub

    Private Sub cboCIPOutputOrder_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCIPOutputOrder.SelectedValueChanged
        CalCIPOutputLength()
    End Sub

    Private Sub CalAssetOutputLength()
        Dim sExample As String = ""
        Dim sAssetS1Default As String = ""
        Dim sAssetS2Default As String = ""
        Dim sAssetS3Default As String = ""
        Dim sAssetS4Default As String = ""
        Dim sAutoNumber As String = ""
        Dim sAssetSeperator As String = ComboValue(tdbcAssetSeperator)

        For i As Integer = 1 To L3Int(updownAutoNumberLength.Value) - 1
            sAutoNumber &= "0"
        Next
        sAutoNumber &= "1"

        If chkAssetS1Enabled.Checked Then
            For i As Integer = 0 To L3Int(txtS1Length.Text) - 1
                sAssetS1Default &= "X"
            Next
        End If

        If chkAssetS2Enabled.Checked Then
            For i As Integer = 0 To L3Int(txtS2Length.Text) - 1
                sAssetS2Default &= "Y"
            Next
        End If

        If chkAssetS3Enabled.Checked Then
            For i As Integer = 0 To L3Int(txtS3Length.Text) - 1
                sAssetS3Default &= "Z"
            Next
        End If


        Select Case cboAssetOutputOrder.Text
            Case "SSSN"
                If chkAssetS1Enabled.Checked Then
                    sExample &= sAssetS1Default & sAssetSeperator
                End If
                If chkAssetS2Enabled.Checked Then
                    sExample &= sAssetS2Default & sAssetSeperator
                End If
                If chkAssetS3Enabled.Checked Then
                    sExample &= sAssetS3Default & sAssetSeperator
                End If
                sExample &= sAutoNumber
            Case "SSNS"
                If chkAssetS1Enabled.Checked Then
                    sExample &= sAssetS1Default & sAssetSeperator
                End If
                If chkAssetS2Enabled.Checked Then
                    sExample &= sAssetS2Default & sAssetSeperator
                End If
                sExample &= sAutoNumber
                If chkAssetS3Enabled.Checked Then
                    sExample &= sAssetSeperator & sAssetS3Default
                End If
            Case "SNSS"
                If chkAssetS1Enabled.Checked Then
                    sExample &= sAssetS1Default & sAssetSeperator
                End If
                sExample &= sAutoNumber
                If chkAssetS2Enabled.Checked Then
                    sExample &= sAssetSeperator & sAssetS2Default
                End If
                If chkAssetS3Enabled.Checked Then
                    sExample &= sAssetSeperator & sAssetS3Default
                End If
            Case "NSSS"
                sExample &= sAutoNumber
                If chkAssetS1Enabled.Checked Then
                    sExample &= sAssetSeperator & sAssetS1Default
                End If
                If chkAssetS2Enabled.Checked Then
                    sExample &= sAssetSeperator & sAssetS2Default
                End If
                If chkAssetS3Enabled.Checked Then
                    sExample &= sAssetSeperator & sAssetS3Default
                End If
              
        End Select

        If chkAssetAuto.Checked Then
            lblExample.Text = sExample
        Else
            lblExample.Text = rL3("Khong_tao_ma_tu_dong")
        End If
        txtAssetOutputLength.Text = sExample.Length.ToString()
    End Sub


    Private Sub CalCIPOutputLength()
        Dim sExample As String = ""
        Dim sCIPS1Default As String = ""
        Dim sCIPS2Default As String = ""
        Dim sCIPS3Default As String = ""

        Dim sAutoNumber As String = ""
        Dim sCIPSeperator As String = ComboValue(tdbcCIPSeperator)

        For i As Integer = 1 To L3Int(updownCIPAutoNumberLength.Value) - 1
            sAutoNumber &= "0"
        Next
        sAutoNumber &= "1"

        If chkCIPS1Enabled.Checked Then
            For i As Integer = 0 To L3Int(txtCIPS1Length.Text) - 1
                sCIPS1Default &= "X"
            Next
        End If

        If chkCIPS2Enabled.Checked Then
            For i As Integer = 0 To L3Int(txtCIPS2Length.Text) - 1
                sCIPS2Default &= "Y"
            Next
        End If

        If chkCIPS3Enabled.Checked Then
            For i As Integer = 0 To L3Int(txtCIPS3Length.Text) - 1
                sCIPS3Default &= "Z"
            Next
        End If


        Select Case cboCIPOutputOrder.Text
            Case "SSSN"
                If chkCIPS1Enabled.Checked Then
                    sExample &= sCIPS1Default & sCIPSeperator
                End If
                If chkCIPS2Enabled.Checked Then
                    sExample &= sCIPS2Default & sCIPSeperator
                End If
                If chkCIPS3Enabled.Checked Then
                    sExample &= sCIPS3Default & sCIPSeperator
                End If
                sExample &= sAutoNumber
            Case "SSNS"
                If chkCIPS1Enabled.Checked Then
                    sExample &= sCIPS1Default & sCIPSeperator
                End If
                If chkCIPS2Enabled.Checked Then
                    sExample &= sCIPS2Default & sCIPSeperator
                End If
                sExample &= sAutoNumber
                If chkCIPS3Enabled.Checked Then
                    sExample &= sCIPSeperator & sCIPS3Default
                End If
            Case "SNSS"
                If chkCIPS1Enabled.Checked Then
                    sExample &= sCIPS1Default & sCIPSeperator
                End If
                sExample &= sAutoNumber
                If chkCIPS2Enabled.Checked Then
                    sExample &= sCIPSeperator & sCIPS2Default
                End If
                If chkCIPS3Enabled.Checked Then
                    sExample &= sCIPSeperator & sCIPS3Default
                End If

            Case "NSSS"
                sExample &= sAutoNumber
                If chkCIPS1Enabled.Checked Then
                    sExample &= sCIPSeperator & sCIPS1Default
                End If
                If chkCIPS2Enabled.Checked Then
                    sExample &= sCIPSeperator & sCIPS2Default
                End If
                If chkCIPS3Enabled.Checked Then
                    sExample &= sCIPSeperator & sCIPS3Default
                End If
        End Select

        If chkCIPAuto.Checked Then
            lblCIPExample.Text = sExample
        Else
            lblCIPExample.Text = rL3("Khong_tao_ma_tu_dong")
        End If
        txtCIPOutputLength.Text = sExample.Length.ToString()
    End Sub

#Region "Events Store"

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLInsertD02T0000
    '# Created User: Nguyễn Đức Trọng
    '# Created Date: 21/03/2011 01:39:55
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLInsertD02T0000() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Insert Into D02T0000(")
        sSQL.Append("AssetAuto, AssetS1Enabled, AssetS1Default, AssetS2Enabled, AssetS2Default, ")
        sSQL.Append("AssetS3Enabled, AssetS3Default, AssetOutputOrder, AssetOutputLength, AssetSeperated, ")
        sSQL.Append("AssetSeperator, MethodID, DefaultDivisionID, ")
        sSQL.Append("CreateUserID, CreateDate, LastModifyUserID, LastModifyDate, ")
        'sSQL.Append("DefAccountVATIn, DefAccountVATOut, NumberFormat, TransferMode1, CoefficientID, ")
        sSQL.Append("DefDepreciationAccountID, DefAssetAccountID, ")
        sSQL.Append("DefSourceID, DefAssignmentID, MethodEndID, DecreaseAsset, S1Length, ")
        sSQL.Append("S2Length, S3Length, AutoNumberLength,CIPAuto,IsAssetIDForD02D43,UseProperty,")

        sSQL.Append("CIPS1Enabled, CIPS2Enabled, CIPS3Enabled, CIPS1Default, " & vbCrLf)
        sSQL.Append("CIPS2Default, CIPS3Default, CIPOutputOrder, CIPOutputLength, CIPSeperated, " & vbCrLf)
        sSQL.Append("CIPS1Length, CIPS2Length, CIPS3Length, CIPSeperator, CIPAutoNumberLength,ObligatoryReceiver,UseD54ForCIP, " & vbCrLf)
        sSQL.Append("UseBudgetForCIP, CIPforPropertyProduct, IsCheckNormIDAllocated, AllowChangeDivision, " & vbCrLf)
        sSQL.Append("IsShowFormAutoCreate, IsAllowChangeAccount, IsCalDepByDate, IsEditAnaID, IsCalPeriodByRate, IsObligatoryManagement" & vbCrLf)
        sSQL.Append(") Values(")
        If optAssetAuto1.Checked Then
            sSQL.Append(SQLNumber(1) & COMMA) 'AssetAuto, bit, NOT NULL
        ElseIf optAssetAuto2.Checked Then
            sSQL.Append(SQLNumber(2) & COMMA) 'AssetAuto, bit, NOT NULL
        Else
            sSQL.Append(SQLNumber(0) & COMMA) 'AssetAuto, bit, NOT NULL
        End If
        sSQL.Append(SQLNumber(chkAssetS1Enabled.Checked) & COMMA) 'AssetS1Enabled, bit, NOT NULL
        sSQL.Append(SQLString(ComboValue(tdbcAssetS1Default)) & COMMA) 'AssetS1Default, varchar[20], NULL
        sSQL.Append(SQLNumber(chkAssetS2Enabled.Checked) & COMMA) 'AssetS2Enabled, bit, NOT NULL
        sSQL.Append(SQLString(ComboValue(tdbcAssetS2Default)) & COMMA) 'AssetS2Default, varchar[20], NULL
        sSQL.Append(SQLNumber(chkAssetS3Enabled.Checked) & COMMA) 'AssetS3Enabled, bit, NOT NULL
        sSQL.Append(SQLString(ComboValue(tdbcAssetS3Default)) & COMMA) 'AssetS3Default, varchar[20], NULL
        sSQL.Append(SQLString(cboAssetOutputOrder.Text) & COMMA) 'AssetOutputOrder, varchar[4], NULL
        ' UPDATE 3/6/2013 ID 56102 - Đổi thành @AssetOutputLength = Textbox chiều dài mã tài sản.Text
        '        sSQL.Append(SQLNumber(txtAssetOutputLength.Text) & COMMA) 'AssetOutputLength, tinyint, NULL
        sSQL.Append(SQLNumber(txtCheckAssetOutputLength.Text) & COMMA) 'AssetOutputLength, tinyint, NULL
        sSQL.Append(SQLNumber(chkAssetSeperated.Checked) & COMMA) 'AssetSeperated, bit, NOT NULL
        sSQL.Append(SQLString(ComboValue(tdbcAssetSeperator)) & COMMA) 'AssetSeperator, varchar[1], NULL
        sSQL.Append(SQLString(ComboValue(tdbcMethodID)) & COMMA) 'MethodID, varchar[20], NULL
        sSQL.Append(SQLString(ComboValue(tdbcDivisionID)) & COMMA) 'DefaultDivisionID, varchar[20], NULL
        sSQL.Append(SQLString(gsUserID) & COMMA) 'CreateUserID, varchar[20], NULL
        sSQL.Append("GetDate()" & COMMA) 'CreateDate, datetime, NULL
        sSQL.Append(SQLString(gsUserID) & COMMA) 'LastModifyUserID, varchar[50], NULL
        sSQL.Append("GetDate()" & COMMA) 'LastModifyDate, datetime, NULL
        sSQL.Append(SQLString(ComboValue(tdbcDefDepreciationAccountID)) & COMMA) 'DefDepreciationAccountID, varchar[20], NULL
        sSQL.Append(SQLString(ComboValue(tdbcDefAssetAccountID)) & COMMA) 'DefAssetAccountID, varchar[20], NULL
        sSQL.Append(SQLString(ComboValue(tdbcDefSourceID)) & COMMA) 'DefSourceID, varchar[20], NULL
        sSQL.Append(SQLString(ComboValue(tdbcDefAssignmentID)) & COMMA) 'DefAssignmentID, varchar[20], NULL
        sSQL.Append(SQLNumber(ComboValue(tdbcMethodEndID)) & COMMA) 'MethodEndID, tinyint, NULL
        sSQL.Append(SQLNumber(chkDecreaseAsset.Checked) & COMMA) 'DecreaseAsset, tinyint, NOT NULL
        sSQL.Append(SQLNumber(txtS1Length.Text) & COMMA) 'S1Length, tinyint, NOT NULL
        sSQL.Append(SQLNumber(txtS2Length.Text) & COMMA) 'S2Length, tinyint, NOT NULL
        sSQL.Append(SQLNumber(txtS3Length.Text) & COMMA) 'S3Length, tinyint, NOT NULL
        sSQL.Append(SQLNumber(updownAutoNumberLength.Value) & COMMA) 'AutoNumberLength, tinyint, NOT NULL
        If optCIPAuto1.Checked Then
            sSQL.Append(SQLNumber(2) & COMMA) 'CIPAuto, tinyint, NOT NULL
        ElseIf optCIPAuto2.Checked Then
            sSQL.Append(SQLNumber(1) & COMMA) 'CIPAuto, tinyint, NOT NULL 
        Else
            sSQL.Append(SQLNumber(0) & COMMA) 'CIPAuto, tinyint, NOT NULL
        End If
        sSQL.Append(SQLNumber(chkIsAssetIDForD02D43.Checked) & COMMA) ', tinyint, NOT NULL Incident 69247
        sSQL.Append(SQLNumber(chkUseProperty.Checked) & COMMA) ', tinyint, NOT NULL Incident 69247

        sSQL.Append(SQLNumber(chkCIPS1Enabled.Checked) & COMMA) 'CIPS1Enabled, int, NOT NULL
        sSQL.Append(SQLNumber(chkCIPS2Enabled.Checked) & COMMA) 'CIPS2Enabled, int, NOT NULL
        sSQL.Append(SQLNumber(chkCIPS3Enabled.Checked) & COMMA) 'CIPS3Enabled, int, NOT NULL
        sSQL.Append(SQLString(ReturnValueC1Combo(tdbcCIPS1Default)) & COMMA & vbCrLf) 'CIPS1Default, nvarchar[40], NOT NULL
        sSQL.Append(SQLString(ReturnValueC1Combo(tdbcCIPS2Default)) & COMMA) 'CIPS2Default, nvarchar[40], NOT NULL
        sSQL.Append(SQLString(ReturnValueC1Combo(tdbcCIPS3Default)) & COMMA) 'CIPS3Default, nvarchar[40], NOT NULL
        sSQL.Append(SQLString(cboCIPOutputOrder.Text) & COMMA) 'CIPOutputOrder, nvarchar[40], NOT NULL
        sSQL.Append(SQLNumber(txtCIPCheckOutputLength.Text) & COMMA & vbCrLf) 'CIPOutputLength, int, NOT NULL
        sSQL.Append(SQLNumber(chkCIPSeperated.Checked) & COMMA) 'CIPSeperated, int, NOT NULL
        sSQL.Append(SQLNumber(txtCIPS1Length.Text) & COMMA) 'CIPS1Length, int, NOT NULL
        sSQL.Append(SQLNumber(txtCIPS2Length.Text) & COMMA) 'CIPS2Length, int, NOT NULL
        sSQL.Append(SQLNumber(txtCIPS3Length.Text) & COMMA & vbCrLf) 'CIPS3Length, int, NOT NULL
        sSQL.Append(SQLString(ReturnValueC1Combo(tdbcCIPSeperator)) & COMMA) 'CIPSeperator, nvarchar[40], NOT NULL
        sSQL.Append(SQLNumber(updownCIPAutoNumberLength.Value) & COMMA) 'CIPAutoNumberLength, int, NOT NULL
        sSQL.Append(SQLNumber(chkObligatoryReceiver.Checked) & COMMA) 'ObligatoryReceiver, int, NOT NULL
        sSQL.Append(SQLNumber(chkUseD54ForCIP.Checked) & COMMA & vbCrLf) ', int, NOT NULL
        sSQL.Append(SQLNumber(chkUseBudgetForCIP.Checked) & COMMA) ', int, NOT NULL
        sSQL.Append(SQLNumber(chkCIPforPropertyProduct.Checked) & COMMA) ', int, NOT NULL
        sSQL.Append(SQLNumber(chkIsCheckNormIDAllocated.Checked) & COMMA) ', int, NOT NULL

        '28/3/2017, Trần Hoàng Anh: id 75367-Bổ sung tính năng điều chuyển đơn vị TSCĐ
        sSQL.Append(SQLNumber(chkAllowChangeDivision.Checked) & COMMA & vbCrLf) ', int, NOT NULL

        If Not optAssetAuto2.Checked Then
            sSQL.Append(SQLNumber(0)) 'ShowFormAotuCreate , int, NOT NULL
        Else
            sSQL.Append(SQLNumber(IIf(optShowFormAotuCreate0.Checked, 0, 1))) 'ShowFormAotuCreate , int, NOT NULL
        End If
        '17/5/2017, Trần Hoàng Anh: id 96202
        sSQL.Append(COMMA & SQLNumber(chkIsAllowChangeAccount.Checked) & COMMA) 'IsAllowChangeAccount, int, NOT NULL
        '17/8/2020, Đặng Ngọc Tài:id 142642-SVI_Bổ sung tính năng tạo mức khấu hao theo ngày trong Kỳ đầu tiên module Tài sản cố định
        sSQL.Append(SQLNumber(chkIsCalDepByDate.Checked) & COMMA) 'IsCalDepByDate, int, NOT NULL 
        '31/8/2021, Nguyễn Thị Mỹ Lài:id 180303-Cho phép sửa khoản mục Kcode khi tính KH TSCD (màn hình D2F5012) Hùng Vương
        sSQL.Append(SQLNumber(chkIsEditAnaID.Checked) & COMMA) 'IsEditAnaID, int, NOT NULL
        '31/3/2022, Bùi Thị Thanh Tuyền:id 214947-ORG - Phát triển khi hình thành tài sản cố định nhập tỷ lệ khấu hao (theo năm) thì tính ngược lại số kỳ, giá trị phân bổ
        sSQL.Append(SQLNumber(chkIsCalPeriodByRate.Checked) & COMMA) 'IsCalPeriodByRate, int, NOT NULL  
        '15/11/2022 - ID 250796 : Bổ sung checkbox bắt buộc nhập Bộ phận quản lý
        sSQL.Append(SQLNumber(chkIsObligatoryManagement.Checked))
        sSQL.Append(")")

        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLUpdateD02T0000
    '# Created User: Nguyễn Đức Trọng
    '# Created Date: 21/03/2011 01:58:00
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLUpdateD02T0000() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Update D02T0000 Set ")
        If optAssetAuto1.Checked Then
            sSQL.Append("AssetAuto = " & SQLNumber(1) & COMMA) 'bit, NOT NULL
        ElseIf optAssetAuto2.Checked Then
            sSQL.Append("AssetAuto = " & SQLNumber(2) & COMMA) 'bit, NOT NULL
        Else
            sSQL.Append("AssetAuto = " & SQLNumber(0) & COMMA) 'bit, NOT NULL
        End If
        sSQL.Append("AssetS1Enabled = " & SQLNumber(chkAssetS1Enabled.Checked) & COMMA) 'bit, NOT NULL
        sSQL.Append("AssetS1Default = " & SQLString(ComboValue(tdbcAssetS1Default)) & COMMA) 'varchar[20], NULL
        sSQL.Append("AssetS2Enabled = " & SQLNumber(chkAssetS2Enabled.Checked) & COMMA) 'bit, NOT NULL
        sSQL.Append("AssetS2Default = " & SQLString(ComboValue(tdbcAssetS2Default)) & COMMA) 'varchar[20], NULL
        sSQL.Append("AssetS3Enabled = " & SQLNumber(chkAssetS3Enabled.Checked) & COMMA) 'bit, NOT NULL
        sSQL.Append("AssetS3Default = " & SQLString(ComboValue(tdbcAssetS3Default)) & COMMA) 'varchar[20], NULL
        sSQL.Append("AssetOutputOrder = " & SQLString(cboAssetOutputOrder.Text) & COMMA) 'varchar[4], NULL
        ' UPDATE 3/6/2013 ID 56102 - Đổi thành @AssetOutputLength = Textbox chiều dài mã tài sản.Text
        'sSQL.Append("AssetOutputLength = " & SQLNumber(txtAssetOutputLength.Text) & COMMA) 'tinyint, NULL
        sSQL.Append("AssetOutputLength = " & SQLNumber(txtCheckAssetOutputLength.Text) & COMMA) 'tinyint, NULL
        sSQL.Append("AssetSeperated = " & SQLNumber(chkAssetSeperated.Checked) & COMMA) 'bit, NOT NULL
        sSQL.Append("AssetSeperator = " & SQLString(ComboValue(tdbcAssetSeperator)) & COMMA) 'varchar[1], NULL
        sSQL.Append("MethodID = " & SQLString(ComboValue(tdbcMethodID)) & COMMA) 'varchar[20], NULL

        If gbCallDesktop = False Then 'ID 88532 29/06/2016
            sSQL.Append("DefaultDivisionID = " & SQLString(ReturnValueC1Combo(tdbcDivisionID).ToString) & COMMA)
        End If
        'sSQL.Append("DefaultDivisionID = " & SQLString(ComboValue(tdbcDivisionID)) & COMMA) 'varchar[20], NULL
        sSQL.Append("LastModifyUserID = " & SQLString(gsUserID) & COMMA) 'varchar[50], NULL
        sSQL.Append("LastModifyDate = GetDate()" & COMMA) 'datetime, NULL
        sSQL.Append("DefDepreciationAccountID = " & SQLString(ComboValue(tdbcDefDepreciationAccountID)) & COMMA) 'varchar[20], NULL
        sSQL.Append("DefAssetAccountID = " & SQLString(ComboValue(tdbcDefAssetAccountID)) & COMMA) 'varchar[20], NULL
        sSQL.Append("DefSourceID = " & SQLString(ComboValue(tdbcDefSourceID)) & COMMA) 'varchar[20], NULL
        sSQL.Append("DefAssignmentID = " & SQLString(ComboValue(tdbcDefAssignmentID)) & COMMA) 'varchar[20], NULL
        sSQL.Append("MethodEndID = " & SQLNumber(ComboValue(tdbcMethodEndID)) & COMMA) 'tinyint, NULL
        sSQL.Append("DecreaseAsset = " & SQLNumber(chkDecreaseAsset.Checked) & COMMA) 'tinyint, NOT NULL
        sSQL.Append("S1Length = " & SQLNumber(txtS1Length.Text) & COMMA) 'tinyint, NOT NULL
        sSQL.Append("S2Length = " & SQLNumber(txtS2Length.Text) & COMMA) 'tinyint, NOT NULL
        sSQL.Append("S3Length = " & SQLNumber(txtS3Length.Text) & COMMA) 'tinyint, NOT NULL
        sSQL.Append("AutoNumberLength = " & SQLNumber(updownAutoNumberLength.Value) & COMMA) 'tinyint, NOT NULL
        If optCIPAuto1.Checked Then
            sSQL.Append("CIPAuto = " & SQLNumber(2) & COMMA) 'tinyint, NOT NULL Incident 69247
        ElseIf optCIPAuto2.Checked Then
            sSQL.Append("CIPAuto = " & SQLNumber(1) & COMMA) 'tinyint, NOT NULL Incident 69247
        Else
            sSQL.Append("CIPAuto = " & SQLNumber(0) & COMMA) 'tinyint, NOT NULL Incident 69247
        End If

        sSQL.Append("IsAssetIDForD02D43 = " & SQLNumber(chkIsAssetIDForD02D43.Checked) & COMMA) 'tinyint, NOT NULL Incident 69247
        sSQL.Append("UseProperty = " & SQLNumber(chkUseProperty.Checked) & COMMA) 'tinyint, NOT NULL Incident 69247

        sSQL.Append("CIPS1Enabled = " & SQLNumber(chkCIPS1Enabled.Checked) & COMMA) 'int, NOT NULL
        sSQL.Append("CIPS2Enabled = " & SQLNumber(chkCIPS2Enabled.Checked) & COMMA) 'int, NOT NULL
        sSQL.Append("CIPS3Enabled = " & SQLNumber(chkCIPS3Enabled.Checked) & COMMA) 'int, NOT NULL
        sSQL.Append("CIPS1Default = " & SQLString(ReturnValueC1Combo(tdbcCIPS1Default)) & COMMA) 'nvarchar[40], NOT NULL
        sSQL.Append("CIPS2Default = " & SQLString(ReturnValueC1Combo(tdbcCIPS2Default)) & COMMA) 'nvarchar[40], NOT NULL
        sSQL.Append("CIPS3Default = " & SQLString(ReturnValueC1Combo(tdbcCIPS3Default)) & COMMA) 'nvarchar[40], NOT NULL
        sSQL.Append("CIPOutputOrder = " & SQLString(cboCIPOutputOrder.Text) & COMMA) 'nvarchar[40], NOT NULL
        sSQL.Append("CIPOutputLength = " & SQLNumber(txtCIPCheckOutputLength.Text) & COMMA) 'int, NOT NULL
        sSQL.Append("CIPSeperated = " & SQLNumber(chkCIPSeperated.Checked) & COMMA) 'int, NOT NULL
        sSQL.Append("CIPS1Length = " & SQLNumber(txtCIPS1Length.Text) & COMMA) 'int, NOT NULL
        sSQL.Append("CIPS2Length = " & SQLNumber(txtCIPS2Length.Text) & COMMA) 'int, NOT NULL
        sSQL.Append("CIPS3Length = " & SQLNumber(txtCIPS3Length.Text) & COMMA) 'int, NOT NULL
        sSQL.Append("CIPSeperator = " & SQLString(ReturnValueC1Combo(tdbcCIPSeperator)) & COMMA) 'nvarchar[40], NOT NULL
        sSQL.Append("CIPAutoNumberLength = " & SQLNumber(updownCIPAutoNumberLength.Value) & COMMA) 'int, NOT NULL
        sSQL.Append("ObligatoryReceiver = " & SQLNumber(chkObligatoryReceiver.Checked) & COMMA) 'int, NOT NULL
        sSQL.Append("UseD54ForCIP = " & SQLNumber(chkUseD54ForCIP.Checked) & COMMA) 'int, NOT NULL
        sSQL.Append("UseBudgetForCIP = " & SQLNumber(chkUseBudgetForCIP.Checked) & COMMA) 'int, NOT NULL
        sSQL.Append("CIPforPropertyProduct = " & SQLNumber(chkCIPforPropertyProduct.Checked) & COMMA) 'int, NOT NULL
        sSQL.Append("IsCheckNormIDAllocated = " & SQLNumber(chkIsCheckNormIDAllocated.Checked) & COMMA)
        '28/3/2017, Trần Hoàng Anh: id 75367-Bổ sung tính năng điều chuyển đơn vị TSCĐ
        sSQL.Append("AllowChangeDivision = " & SQLNumber(chkAllowChangeDivision.Checked) & COMMA) ', int, NOT NULL
        '17/5/2017, Trần Hoàng Anh: id 96202
        sSQL.Append("IsAllowChangeAccount = " & SQLNumber(chkIsAllowChangeAccount.Checked) & COMMA) ', int, NOT NULL
        '17/8/2020, Đặng Ngọc Tài:id 142642-SVI_Bổ sung tính năng tạo mức khấu hao theo ngày trong Kỳ đầu tiên module Tài sản cố định
        sSQL.Append("IsCalDepByDate = " & SQLNumber(chkIsCalDepByDate.Checked) & COMMA) 'IsCalDepByDate, int, NOT NULL 
        '31/8/2021, Nguyễn Thị Mỹ Lài:id 180303-Cho phép sửa khoản mục Kcode khi tính KH TSCD (màn hình D2F5012) Hùng Vương
        sSQL.Append("IsEditAnaID = " & SQLNumber(chkIsEditAnaID.Checked) & COMMA) 'IsEditAnaID, int, NOT NULL

        If Not optAssetAuto2.Checked Then
            sSQL.Append("IsShowFormAutoCreate = " & SQLNumber(0)) 'ShowFormAotuCreate , int, NOT NULL
        Else
            sSQL.Append("IsShowFormAutoCreate = " & SQLNumber(IIf(optShowFormAotuCreate0.Checked, 0, 1))) 'ShowFormAotuCreate , int, NOT NULL
        End If

        '31/3/2022, Bùi Thị Thanh Tuyền:id 214947-ORG - Phát triển khi hình thành tài sản cố định nhập tỷ lệ khấu hao (theo năm) thì tính ngược lại số kỳ, giá trị phân bổ
        sSQL.Append(", IsCalPeriodByRate = " & SQLNumber(chkIsCalPeriodByRate.Checked)) 'IsCalPeriodByRate, int, NOT NULL  
        '15/11/2022 - ID 250796 : Bổ sung checkbox bắt buộc nhập Bộ phận quản lý
        sSQL.Append(", IsObligatoryManagement = " & SQLNumber(chkIsObligatoryManagement.Checked))
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLDeleteD02T0000
    '# Create User: Nguyễn Đức Trọng
    '# Create Date: 21/03/2011 02:05:00
    '# Modified User: 
    '# Modified Date: 
    '# Description:
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLDeleteD02T0000() As String
        Dim sSQL As String = ""
        sSQL &= "Delete From D02T0000"
        Return sSQL
    End Function

#End Region

    Private Sub optAssetAuto1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAssetAuto1.CheckedChanged
        If chkAssetAuto.Checked And optAssetAuto1.Checked Then
            grpAssetCategories.Enabled = True
            grpAutoAssetNumbering.Enabled = True
            grpIGE.Enabled = False
            optShowFormAotuCreate0.Checked = True
        Else
            grpAssetCategories.Enabled = False
            grpAutoAssetNumbering.Enabled = False
            grpIGE.Enabled = True

            'ClearText(grpAssetCategories)
            'ClearText(grpAutoAssetNumbering)
        End If
    End Sub

    Private Sub optCIPAuto1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCIPAuto1.CheckedChanged
        If chkCIPAuto.Checked And optCIPAuto1.Checked Then
            grpCIPCategories.Enabled = True
            grpAutoCIPNumbering.Enabled = True
        Else
            grpCIPCategories.Enabled = False
            grpAutoCIPNumbering.Enabled = False
            'ClearText(grpAssetCategories)
            'ClearText(grpAutoAssetNumbering)
        End If
    End Sub


    Private Sub chkAssetAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAssetAuto.CheckedChanged
        CalAssetOutputLength()
        If chkAssetAuto.Checked Then
            optAssetAuto1.Checked = True
            If optAssetAuto1.Checked Then
                grpAssetCategories.Enabled = True
                grpAutoAssetNumbering.Enabled = True
                grpIGE.Enabled = False
            Else
                grpAssetCategories.Enabled = False
                grpAutoAssetNumbering.Enabled = False
                grpIGE.Enabled = True
            End If

            ' update 3/6/2013 id 56102
            chkCheckAssetOutputLength.Enabled = False
            chkCheckAssetOutputLength.Checked = False
            chkCheckAssetOutputLength_CheckedChanged(Nothing, Nothing)
            txtCheckAssetOutputLength.Text = txtAssetOutputLength.Text

            UnReadOnlyControl(False, optAssetAuto1, optAssetAuto2)

        Else
            grpAssetCategories.Enabled = False
            grpAutoAssetNumbering.Enabled = False
            chkCheckAssetOutputLength.Enabled = True
            chkCheckAssetOutputLength.Checked = False
            chkCheckAssetOutputLength_CheckedChanged(Nothing, Nothing)
            txtCheckAssetOutputLength.Text = "0"
            ReadOnlyControl(optAssetAuto1, optAssetAuto2)
            optAssetAuto1.Checked = False
            optAssetAuto2.Checked = False
            grpIGE.Enabled = False
        End If
    End Sub


    Private Sub chkCIPAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCIPAuto.CheckedChanged
        CalCIPOutputLength()
        If chkCIPAuto.Checked Then
            optCIPAuto1.Checked = True
            If optCIPAuto1.Checked Then
                grpCIPCategories.Enabled = True
                grpAutoCIPNumbering.Enabled = True
            Else
                grpCIPCategories.Enabled = False
                grpAutoCIPNumbering.Enabled = False
            End If

            ' update 3/6/2013 id 56102
            chkCIPCheckOutputLength.Enabled = False
            chkCIPCheckOutputLength_CheckedChanged(Nothing, Nothing)
            txtCIPCheckOutputLength.Text = txtCIPOutputLength.Text
            UnReadOnlyControl(False, optCIPAuto1, optCIPAuto2)
        Else
            grpCIPCategories.Enabled = False
            grpAutoCIPNumbering.Enabled = False

            chkCIPCheckOutputLength.Enabled = True
            chkCIPCheckOutputLength.Checked = False
            chkCIPCheckOutputLength_CheckedChanged(Nothing, Nothing)
            txtCIPCheckOutputLength.Text = "0"
            ReadOnlyControl(optCIPAuto1, optCIPAuto2)
            optCIPAuto1.Checked = False
            optCIPAuto2.Checked = False
        End If
    End Sub

    Private Sub chkAssetSeperated_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAssetSeperated.CheckedChanged
        If chkAssetSeperated.Checked Then
            UnReadOnlyControl(tdbcAssetSeperator)
        Else
            tdbcAssetSeperator.Text = ""
            ReadOnlyControl(tdbcAssetSeperator)
        End If
    End Sub

    Private Sub chkCIPSeperated_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCIPSeperated.CheckedChanged
        If chkCIPSeperated.Checked Then
            UnReadOnlyControl(tdbcCIPSeperator)
        Else
            tdbcCIPSeperator.Text = ""
            ReadOnlyControl(tdbcCIPSeperator)
        End If
    End Sub

    Private Sub chkCIPS1Enabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCIPS1Enabled.CheckedChanged
        If chkCIPS1Enabled.Checked Then
            UnReadOnlyControl(tdbcCIPS1Default)
            UnReadOnlyControl(txtCIPS1Length)
        Else
            ReadOnlyControl(tdbcCIPS1Default)
            ReadOnlyControl(txtCIPS1Length)
        End If
        CalCIPOutputLength()
    End Sub

    Private Sub chkCIPS2Enabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCIPS2Enabled.CheckedChanged
        If chkCIPS2Enabled.Checked Then
            UnReadOnlyControl(tdbcCIPS2Default)
            UnReadOnlyControl(txtCIPS2Length)
        Else
            ReadOnlyControl(tdbcCIPS2Default)
            ReadOnlyControl(txtCIPS2Length)
        End If
        CalCIPOutputLength()
    End Sub

    Private Sub chkCIPS3Enabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCIPS3Enabled.CheckedChanged
        If chkCIPS3Enabled.Checked Then
            UnReadOnlyControl(tdbcCIPS3Default)
            UnReadOnlyControl(txtCIPS3Length)
        Else
            ReadOnlyControl(tdbcCIPS3Default)
            ReadOnlyControl(txtCIPS3Length)
        End If
        CalCIPOutputLength()
    End Sub

    Private Sub chkAssetS1Enabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAssetS1Enabled.CheckedChanged
        If chkAssetS1Enabled.Checked Then
            UnReadOnlyControl(tdbcAssetS1Default)
            UnReadOnlyControl(txtS1Length)
        Else
            ReadOnlyControl(tdbcAssetS1Default)
            ReadOnlyControl(txtS1Length)
        End If
        CalAssetOutputLength()
    End Sub

    Private Sub chkAssetS2Enabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAssetS2Enabled.CheckedChanged
        If chkAssetS2Enabled.Checked Then
            UnReadOnlyControl(tdbcAssetS2Default)
            UnReadOnlyControl(txtS2Length)
        Else
            ReadOnlyControl(tdbcAssetS2Default)
            ReadOnlyControl(txtS2Length)
        End If
        CalAssetOutputLength()
    End Sub

    Private Sub chkAssetS3Enabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAssetS3Enabled.CheckedChanged
        If chkAssetS3Enabled.Checked Then
            UnReadOnlyControl(tdbcAssetS3Default)
            UnReadOnlyControl(txtS3Length)
        Else
            ReadOnlyControl(tdbcAssetS3Default)
            ReadOnlyControl(txtS3Length)
        End If
        CalAssetOutputLength()
    End Sub

    Private Sub chkUseD54ForCIP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseD54ForCIP.CheckedChanged
        If chkUseD54ForCIP.Checked Then
            chkUseBudgetForCIP.Checked = False
        End If
    End Sub

    Private Sub chkUseBudgetForCIP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseBudgetForCIP.CheckedChanged
        If chkUseBudgetForCIP.Checked Then
            chkUseD54ForCIP.Checked = False
        End If
    End Sub


    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P0080
    '# Created User: Đặng Thanh Tùng
    '# Created Date: 13/02/2023 10:17:18
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P0080(ByVal sDataType As String) As String
        Dim sSQL As String = ""
        sSQL &= ("-- Tab 5. Thiet lap loai phieu" & vbCrLf)
        sSQL &= "Exec D02P0080 "
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[50], NOT NULL
        sSQL &= SQLString("02") & COMMA 'ModuleID, varchar[50], NOT NULL
        sSQL &= SQLString(gsLanguage) & COMMA 'Language, varchar[20], NOT NULL
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[50], NOT NULL
        sSQL &= SQLString(sDataType) 'DataType, varchar[50], NOT NULL
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLDeleteD19T0040
    '# Created User: Đặng Thanh Tùng
    '# Created Date: 10/02/2023 04:01:54
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLDeleteD02T0080() As String
        Dim sSQL As String = ""
        sSQL &= ("-- Tab5" & vbCrLf)
        sSQL &= "Delete From D02T0080"
        sSQL &= " Where "
        sSQL &= "ModuleID = " & SQLString("02")
        sSQL &= " AND DivisionID = " & SQLString(gsDivisionID)
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLInsertD19T0040
    '# Created User: Nguyễn Thị Ánh
    '# Created Date: 10/02/2023 04:02:41
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLInsertD02T0080() As StringBuilder
        Dim sRet As New StringBuilder
        For i As Integer = 0 To tdbg.RowCount - 1
            Dim sSQL As New StringBuilder
            sSQL.Append("-- tab3" & vbCrLf)
            sSQL.Append("Insert Into D02T0080(")
            sSQL.Append("DivisionID, FormID, ModuleID, VoucherTypeID")
            sSQL.Append(") Values(" & vbCrLf)
            sSQL.Append(SQLString(gsDivisionID) & COMMA) 'DivisionID, varchar[20], NOT NULL
            sSQL.Append(SQLString(tdbg(i, COL_FormID)) & COMMA) 'FormID, varchar[50], NOT NULL
            sSQL.Append(SQLString("02") & COMMA) 'ModuleID, varchar[20], NOT NULL
            sSQL.Append(SQLString(tdbg(i, COL_VoucherTypeID))) 'VoucherTypeID, varchar[50], NOT NULL
            sSQL.Append(")")
            sRet.Append(sSQL.ToString & vbCrLf)
            sSQL.Remove(0, sSQL.Length)
        Next
        Return sRet
    End Function





    Private Sub tdbg_AfterColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbg.AfterColUpdate
        Select Case e.ColIndex
            Case COL_VoucherTypeID
                If tdbg.Columns(COL_VoucherTypeID).Text <> "" Then
                    tdbg.Columns(COL_VoucherTypeName).Text = tdbdVoucherTypeID.Columns("VoucherTypeName").Text
                End If


        End Select
    End Sub
End Class