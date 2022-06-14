<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdditem
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShopdbDataSet3 = New JewelleryShopManagementSystem.shopdbDataSet3()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchItemName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemTableAdapter = New JewelleryShopManagementSystem.shopdbDataSet3TableAdapters.itemTableAdapter()
        Me.Search = New System.Windows.Forms.Button()
        Me.rptitem = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopdbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 273)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Add Jewellery Items"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtItemPrice)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.txtItemId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 50)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(821, 211)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items Details"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(67, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 48)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(483, 142)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(103, 48)
        Me.btnupdate.TabIndex = 10
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(356, 142)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 48)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(229, 142)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 48)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtItemPrice
        '
        Me.txtItemPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemBindingSource, "Iprice", True))
        Me.txtItemPrice.Location = New System.Drawing.Point(601, 87)
        Me.txtItemPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(206, 27)
        Me.txtItemPrice.TabIndex = 4
        '
        'ItemBindingSource
        '
        Me.ItemBindingSource.DataMember = "item"
        Me.ItemBindingSource.DataSource = Me.ShopdbDataSet3
        '
        'ShopdbDataSet3
        '
        Me.ShopdbDataSet3.DataSetName = "shopdbDataSet3"
        Me.ShopdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemBindingSource, "Iqty", True))
        Me.txtQuantity.Location = New System.Drawing.Point(601, 32)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(206, 27)
        Me.txtQuantity.TabIndex = 2
        '
        'txtItemName
        '
        Me.txtItemName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemBindingSource, "Iname", True))
        Me.txtItemName.Location = New System.Drawing.Point(170, 82)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(206, 27)
        Me.txtItemName.TabIndex = 3
        '
        'txtItemId
        '
        Me.txtItemId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemBindingSource, "Ino", True))
        Me.txtItemId.Location = New System.Drawing.Point(170, 30)
        Me.txtItemId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(206, 27)
        Me.txtItemId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(479, 39)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Quantity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(479, 87)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Items Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Items Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Items Id:"
        '
        'txtSearchItemName
        '
        Me.txtSearchItemName.Location = New System.Drawing.Point(183, 286)
        Me.txtSearchItemName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSearchItemName.Name = "txtSearchItemName"
        Me.txtSearchItemName.Size = New System.Drawing.Size(380, 22)
        Me.txtSearchItemName.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InoDataGridViewTextBoxColumn, Me.InameDataGridViewTextBoxColumn, Me.IqtyDataGridViewTextBoxColumn, Me.IpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 349)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(819, 347)
        Me.DataGridView1.TabIndex = 11
        '
        'InoDataGridViewTextBoxColumn
        '
        Me.InoDataGridViewTextBoxColumn.DataPropertyName = "Ino"
        Me.InoDataGridViewTextBoxColumn.HeaderText = "Ino"
        Me.InoDataGridViewTextBoxColumn.Name = "InoDataGridViewTextBoxColumn"
        '
        'InameDataGridViewTextBoxColumn
        '
        Me.InameDataGridViewTextBoxColumn.DataPropertyName = "Iname"
        Me.InameDataGridViewTextBoxColumn.HeaderText = "Iname"
        Me.InameDataGridViewTextBoxColumn.Name = "InameDataGridViewTextBoxColumn"
        '
        'IqtyDataGridViewTextBoxColumn
        '
        Me.IqtyDataGridViewTextBoxColumn.DataPropertyName = "Iqty"
        Me.IqtyDataGridViewTextBoxColumn.HeaderText = "Iqty"
        Me.IqtyDataGridViewTextBoxColumn.Name = "IqtyDataGridViewTextBoxColumn"
        '
        'IpriceDataGridViewTextBoxColumn
        '
        Me.IpriceDataGridViewTextBoxColumn.DataPropertyName = "Iprice"
        Me.IpriceDataGridViewTextBoxColumn.HeaderText = "Iprice"
        Me.IpriceDataGridViewTextBoxColumn.Name = "IpriceDataGridViewTextBoxColumn"
        '
        'ItemTableAdapter
        '
        Me.ItemTableAdapter.ClearBeforeFill = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(42, 273)
        Me.Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(103, 48)
        Me.Search.TabIndex = 12
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'rptitem
        '
        Me.rptitem.Location = New System.Drawing.Point(605, 269)
        Me.rptitem.Name = "rptitem"
        Me.rptitem.Size = New System.Drawing.Size(128, 51)
        Me.rptitem.TabIndex = 13
        Me.rptitem.Text = "Report"
        Me.rptitem.UseVisualStyleBackColor = True
        '
        'frmAdditem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 754)
        Me.Controls.Add(Me.rptitem)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSearchItemName)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(758, 801)
        Me.Name = "frmAdditem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Items"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopdbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSearchItemName As System.Windows.Forms.TextBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ShopdbDataSet3 As JewelleryShopManagementSystem.shopdbDataSet3
    Friend WithEvents ItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemTableAdapter As JewelleryShopManagementSystem.shopdbDataSet3TableAdapters.itemTableAdapter
    Friend WithEvents InoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents rptitem As System.Windows.Forms.Button
End Class
