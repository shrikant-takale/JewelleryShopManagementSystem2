<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPurchase
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShopdbDataSet5 = New JewelleryShopManagementSystem.shopdbDataSet5()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtamt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSrNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.PorderTableAdapter = New JewelleryShopManagementSystem.shopdbDataSet5TableAdapters.porderTableAdapter()
        Me.rptpurchase = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopdbDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PnoDataGridViewTextBoxColumn, Me.PdateDataGridViewTextBoxColumn, Me.PnameDataGridViewTextBoxColumn, Me.PamtDataGridViewTextBoxColumn, Me.SnoDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PorderBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(21, 391)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(846, 254)
        Me.DataGridView1.TabIndex = 31
        '
        'PnoDataGridViewTextBoxColumn
        '
        Me.PnoDataGridViewTextBoxColumn.DataPropertyName = "Pno"
        Me.PnoDataGridViewTextBoxColumn.HeaderText = "Pno"
        Me.PnoDataGridViewTextBoxColumn.Name = "PnoDataGridViewTextBoxColumn"
        '
        'PdateDataGridViewTextBoxColumn
        '
        Me.PdateDataGridViewTextBoxColumn.DataPropertyName = "Pdate"
        Me.PdateDataGridViewTextBoxColumn.HeaderText = "Pdate"
        Me.PdateDataGridViewTextBoxColumn.Name = "PdateDataGridViewTextBoxColumn"
        '
        'PnameDataGridViewTextBoxColumn
        '
        Me.PnameDataGridViewTextBoxColumn.DataPropertyName = "Pname"
        Me.PnameDataGridViewTextBoxColumn.HeaderText = "Pname"
        Me.PnameDataGridViewTextBoxColumn.Name = "PnameDataGridViewTextBoxColumn"
        '
        'PamtDataGridViewTextBoxColumn
        '
        Me.PamtDataGridViewTextBoxColumn.DataPropertyName = "Pamt"
        Me.PamtDataGridViewTextBoxColumn.HeaderText = "Pamt"
        Me.PamtDataGridViewTextBoxColumn.Name = "PamtDataGridViewTextBoxColumn"
        '
        'SnoDataGridViewTextBoxColumn
        '
        Me.SnoDataGridViewTextBoxColumn.DataPropertyName = "Sno"
        Me.SnoDataGridViewTextBoxColumn.HeaderText = "Sno"
        Me.SnoDataGridViewTextBoxColumn.Name = "SnoDataGridViewTextBoxColumn"
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "Sname"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "Sname"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'PorderBindingSource
        '
        Me.PorderBindingSource.DataMember = "porder"
        Me.PorderBindingSource.DataSource = Me.ShopdbDataSet5
        '
        'ShopdbDataSet5
        '
        Me.ShopdbDataSet5.DataSetName = "shopdbDataSet5"
        Me.ShopdbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 35)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Add Jewellery Purchase"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtamt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Add)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtItemPrice)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.txtItemId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSrNo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.pname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(861, 278)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PurcaseDetails"
        '
        'txtamt
        '
        Me.txtamt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PorderBindingSource, "Pamt", True))
        Me.txtamt.Location = New System.Drawing.Point(629, 129)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(192, 27)
        Me.txtamt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(426, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Amount"
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(25, 189)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(97, 46)
        Me.Add.TabIndex = 10
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(566, 189)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 48)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(359, 189)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 48)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(185, 189)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 48)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtItemPrice
        '
        Me.txtItemPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PorderBindingSource, "Sno", True))
        Me.txtItemPrice.Location = New System.Drawing.Point(185, 77)
        Me.txtItemPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(188, 27)
        Me.txtItemPrice.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PorderBindingSource, "Sname", True))
        Me.txtQuantity.Location = New System.Drawing.Point(634, 80)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(188, 27)
        Me.txtQuantity.TabIndex = 4
        '
        'txtItemName
        '
        Me.txtItemName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PorderBindingSource, "Pname", True))
        Me.txtItemName.Location = New System.Drawing.Point(204, 125)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(188, 27)
        Me.txtItemName.TabIndex = 5
        '
        'txtItemId
        '
        Me.txtItemId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PorderBindingSource, "Pdate", True))
        Me.txtItemId.Location = New System.Drawing.Point(634, 31)
        Me.txtItemId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(188, 27)
        Me.txtItemId.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(399, 83)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = " Supplier Name:"
        '
        'txtSrNo
        '
        Me.txtSrNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PorderBindingSource, "Pno", True))
        Me.txtSrNo.Location = New System.Drawing.Point(185, 31)
        Me.txtSrNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSrNo.Name = "txtSrNo"
        Me.txtSrNo.Size = New System.Drawing.Size(188, 27)
        Me.txtSrNo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 80)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Supplier No:"
        '
        'pname
        '
        Me.pname.AutoSize = True
        Me.pname.Location = New System.Drawing.Point(7, 125)
        Me.pname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(181, 20)
        Me.pname.TabIndex = 0
        Me.pname.Text = "  Purchase Item Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "  Purchase Order Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Po No:"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(31, 330)
        Me.search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(103, 48)
        Me.search.TabIndex = 9
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(154, 343)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(490, 22)
        Me.txtsearch.TabIndex = 30
        '
        'PorderTableAdapter
        '
        Me.PorderTableAdapter.ClearBeforeFill = True
        '
        'rptpurchase
        '
        Me.rptpurchase.Location = New System.Drawing.Point(679, 336)
        Me.rptpurchase.Name = "rptpurchase"
        Me.rptpurchase.Size = New System.Drawing.Size(135, 41)
        Me.rptpurchase.TabIndex = 32
        Me.rptpurchase.Text = "Report"
        Me.rptpurchase.UseVisualStyleBackColor = True
        '
        'frmAddPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 657)
        Me.Controls.Add(Me.rptpurchase)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtsearch)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAddPurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Purchase"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopdbDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSrNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pname As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents ShopdbDataSet5 As JewelleryShopManagementSystem.shopdbDataSet5
    Friend WithEvents PorderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PorderTableAdapter As JewelleryShopManagementSystem.shopdbDataSet5TableAdapters.porderTableAdapter
    Friend WithEvents PnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PamtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rptpurchase As System.Windows.Forms.Button
End Class
