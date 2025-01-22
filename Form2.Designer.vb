<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblTajuk = New Label()
        lblNama = New Label()
        lblNotel = New Label()
        lblAlamat = New Label()
        lblNegeri = New Label()
        lblJantina = New Label()
        lblBayaran = New Label()
        lblPerisa = New Label()
        txtAlamat = New TextBox()
        txtNotel = New TextBox()
        txtNama = New TextBox()
        cbbNegeri = New ComboBox()
        rdbLelaki = New RadioButton()
        rdbPerempuan = New RadioButton()
        ckbPisang = New CheckBox()
        ckbStrawberi = New CheckBox()
        ckbCoklat = New CheckBox()
        ckbKopi = New CheckBox()
        ckbMilo = New CheckBox()
        dgvJadual = New DataGridView()
        clnBil = New DataGridViewTextBoxColumn()
        clnNama = New DataGridViewTextBoxColumn()
        clnNotel = New DataGridViewTextBoxColumn()
        BtnDelete = New Button()
        BtnUpdate = New Button()
        BtnRead = New Button()
        BtnCreate = New Button()
        rdbCashless = New RadioButton()
        rdbCash = New RadioButton()
        lblTarikh = New Label()
        DateTimePicker1 = New DateTimePicker()
        CType(dgvJadual, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTajuk
        ' 
        lblTajuk.AutoSize = True
        lblTajuk.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTajuk.Location = New Point(14, 30)
        lblTajuk.Name = "lblTajuk"
        lblTajuk.Size = New Size(402, 50)
        lblTajuk.TabIndex = 0
        lblTajuk.Text = "Maklumat Pelanggan "
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(27, 127)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(96, 32)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama : "
        ' 
        ' lblNotel
        ' 
        lblNotel.AutoSize = True
        lblNotel.Location = New Point(28, 172)
        lblNotel.Name = "lblNotel"
        lblNotel.Size = New Size(97, 32)
        lblNotel.TabIndex = 2
        lblNotel.Text = "No.tel : "
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(18, 222)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(107, 32)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "Alamat : "
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(20, 267)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(105, 32)
        lblNegeri.TabIndex = 4
        lblNegeri.Text = "Negeri : "
        ' 
        ' lblJantina
        ' 
        lblJantina.AutoSize = True
        lblJantina.Location = New Point(17, 310)
        lblJantina.Name = "lblJantina"
        lblJantina.Size = New Size(108, 32)
        lblJantina.TabIndex = 5
        lblJantina.Text = "Jantina : "
        ' 
        ' lblBayaran
        ' 
        lblBayaran.AutoSize = True
        lblBayaran.Location = New Point(12, 354)
        lblBayaran.Name = "lblBayaran"
        lblBayaran.Size = New Size(203, 32)
        lblBayaran.TabIndex = 6
        lblBayaran.Text = "Kaedah Bayaran : "
        ' 
        ' lblPerisa
        ' 
        lblPerisa.AutoSize = True
        lblPerisa.Location = New Point(29, 403)
        lblPerisa.Name = "lblPerisa"
        lblPerisa.Size = New Size(94, 32)
        lblPerisa.TabIndex = 7
        lblPerisa.Text = "Perisa : "
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(119, 222)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(540, 39)
        txtAlamat.TabIndex = 9
        ' 
        ' txtNotel
        ' 
        txtNotel.Location = New Point(119, 172)
        txtNotel.Name = "txtNotel"
        txtNotel.Size = New Size(264, 39)
        txtNotel.TabIndex = 10
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(119, 127)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(362, 39)
        txtNama.TabIndex = 11
        ' 
        ' cbbNegeri
        ' 
        cbbNegeri.FormattingEnabled = True
        cbbNegeri.Location = New Point(119, 267)
        cbbNegeri.Name = "cbbNegeri"
        cbbNegeri.Size = New Size(242, 40)
        cbbNegeri.TabIndex = 12
        ' 
        ' rdbLelaki
        ' 
        rdbLelaki.AutoSize = True
        rdbLelaki.Location = New Point(119, 315)
        rdbLelaki.Name = "rdbLelaki"
        rdbLelaki.Size = New Size(105, 36)
        rdbLelaki.TabIndex = 13
        rdbLelaki.TabStop = True
        rdbLelaki.Text = "Lelaki"
        rdbLelaki.UseVisualStyleBackColor = True
        ' 
        ' rdbPerempuan
        ' 
        rdbPerempuan.AutoSize = True
        rdbPerempuan.Location = New Point(230, 319)
        rdbPerempuan.Name = "rdbPerempuan"
        rdbPerempuan.Size = New Size(166, 36)
        rdbPerempuan.TabIndex = 14
        rdbPerempuan.TabStop = True
        rdbPerempuan.Text = "Perempuan"
        rdbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' ckbPisang
        ' 
        ckbPisang.AutoSize = True
        ckbPisang.Location = New Point(654, 399)
        ckbPisang.Name = "ckbPisang"
        ckbPisang.Size = New Size(115, 36)
        ckbPisang.TabIndex = 15
        ckbPisang.Text = "Pisang"
        ckbPisang.UseVisualStyleBackColor = True
        ' 
        ' ckbStrawberi
        ' 
        ckbStrawberi.AutoSize = True
        ckbStrawberi.Location = New Point(482, 403)
        ckbStrawberi.Name = "ckbStrawberi"
        ckbStrawberi.Size = New Size(144, 36)
        ckbStrawberi.TabIndex = 16
        ckbStrawberi.Text = "Strawberi"
        ckbStrawberi.UseVisualStyleBackColor = True
        ' 
        ' ckbCoklat
        ' 
        ckbCoklat.AutoSize = True
        ckbCoklat.Location = New Point(348, 403)
        ckbCoklat.Name = "ckbCoklat"
        ckbCoklat.Size = New Size(113, 36)
        ckbCoklat.TabIndex = 17
        ckbCoklat.Text = "Coklat"
        ckbCoklat.UseVisualStyleBackColor = True
        ' 
        ' ckbKopi
        ' 
        ckbKopi.AutoSize = True
        ckbKopi.Location = New Point(230, 403)
        ckbKopi.Name = "ckbKopi"
        ckbKopi.Size = New Size(93, 36)
        ckbKopi.TabIndex = 18
        ckbKopi.Text = "Kopi"
        ckbKopi.UseVisualStyleBackColor = True
        ' 
        ' ckbMilo
        ' 
        ckbMilo.AutoSize = True
        ckbMilo.Location = New Point(114, 403)
        ckbMilo.Name = "ckbMilo"
        ckbMilo.Size = New Size(94, 36)
        ckbMilo.TabIndex = 19
        ckbMilo.Text = "Milo"
        ckbMilo.UseVisualStyleBackColor = True
        ' 
        ' dgvJadual
        ' 
        dgvJadual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJadual.Columns.AddRange(New DataGridViewColumn() {clnBil, clnNama, clnNotel})
        dgvJadual.Location = New Point(11, 438)
        dgvJadual.Name = "dgvJadual"
        dgvJadual.RowHeadersWidth = 82
        dgvJadual.Size = New Size(758, 300)
        dgvJadual.TabIndex = 20
        ' 
        ' clnBil
        ' 
        clnBil.HeaderText = "Bilangan"
        clnBil.MinimumWidth = 10
        clnBil.Name = "clnBil"
        clnBil.Width = 200
        ' 
        ' clnNama
        ' 
        clnNama.HeaderText = "Nama"
        clnNama.MinimumWidth = 10
        clnNama.Name = "clnNama"
        clnNama.Width = 200
        ' 
        ' clnNotel
        ' 
        clnNotel.HeaderText = "No.tel"
        clnNotel.MinimumWidth = 10
        clnNotel.Name = "clnNotel"
        clnNotel.Width = 200
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(545, 761)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(150, 46)
        BtnDelete.TabIndex = 21
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(371, 761)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(150, 46)
        BtnUpdate.TabIndex = 22
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Location = New Point(196, 761)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(150, 46)
        BtnRead.TabIndex = 23
        BtnRead.Text = "Read"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' BtnCreate
        ' 
        BtnCreate.Location = New Point(20, 761)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(150, 46)
        BtnCreate.TabIndex = 24
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' rdbCashless
        ' 
        rdbCashless.AutoSize = True
        rdbCashless.Location = New Point(314, 357)
        rdbCashless.Name = "rdbCashless"
        rdbCashless.Size = New Size(135, 36)
        rdbCashless.TabIndex = 25
        rdbCashless.TabStop = True
        rdbCashless.Text = "Cashless"
        rdbCashless.UseVisualStyleBackColor = True
        ' 
        ' rdbCash
        ' 
        rdbCash.AutoSize = True
        rdbCash.Location = New Point(212, 357)
        rdbCash.Name = "rdbCash"
        rdbCash.Size = New Size(96, 36)
        rdbCash.TabIndex = 26
        rdbCash.TabStop = True
        rdbCash.Text = "Cash"
        rdbCash.UseVisualStyleBackColor = True
        ' 
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Location = New Point(762, 134)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(95, 32)
        lblTarikh.TabIndex = 27
        lblTarikh.Text = "Tarikh : "
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(849, 134)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(400, 39)
        DateTimePicker1.TabIndex = 29
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1645, 883)
        Controls.Add(DateTimePicker1)
        Controls.Add(lblTarikh)
        Controls.Add(rdbCash)
        Controls.Add(rdbCashless)
        Controls.Add(BtnCreate)
        Controls.Add(BtnRead)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnDelete)
        Controls.Add(dgvJadual)
        Controls.Add(ckbMilo)
        Controls.Add(ckbKopi)
        Controls.Add(ckbCoklat)
        Controls.Add(ckbStrawberi)
        Controls.Add(ckbPisang)
        Controls.Add(rdbPerempuan)
        Controls.Add(rdbLelaki)
        Controls.Add(cbbNegeri)
        Controls.Add(txtNama)
        Controls.Add(txtNotel)
        Controls.Add(txtAlamat)
        Controls.Add(lblPerisa)
        Controls.Add(lblBayaran)
        Controls.Add(lblJantina)
        Controls.Add(lblNegeri)
        Controls.Add(lblAlamat)
        Controls.Add(lblNotel)
        Controls.Add(lblNama)
        Controls.Add(lblTajuk)
        Name = "Form2"
        Text = "Form2"
        CType(dgvJadual, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTajuk As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNotel As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents lblJantina As Label
    Friend WithEvents lblBayaran As Label
    Friend WithEvents lblPerisa As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNotel As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbbNegeri As ComboBox
    Friend WithEvents rdbLelaki As RadioButton
    Friend WithEvents rdbPerempuan As RadioButton
    Friend WithEvents ckbPisang As CheckBox
    Friend WithEvents ckbStrawberi As CheckBox
    Friend WithEvents ckbCoklat As CheckBox
    Friend WithEvents ckbKopi As CheckBox
    Friend WithEvents ckbMilo As CheckBox
    Friend WithEvents dgvJadual As DataGridView
    Friend WithEvents clnBil As DataGridViewTextBoxColumn
    Friend WithEvents clnNama As DataGridViewTextBoxColumn
    Friend WithEvents clnNotel As DataGridViewTextBoxColumn
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents rdbCashless As RadioButton
    Friend WithEvents rdbCash As RadioButton
    Friend WithEvents lblTarikh As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
