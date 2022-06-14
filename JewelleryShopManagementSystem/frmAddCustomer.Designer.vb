<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CcreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CphnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShopdbDataSet1 = New JewelleryShopManagementSystem.shopdbDataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtcname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.CustomerTableAdapter = New JewelleryShopManagementSystem.shopdbDataSet1TableAdapters.customerTableAdapter()
        Me.rtpcust = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CnoDataGridViewTextBoxColumn, Me.CnameDataGridViewTextBoxColumn, Me.CaddrDataGridViewTextBoxColumn, Me.CemailDataGridViewTextBoxColumn, Me.CcreditDataGridViewTextBoxColumn, Me.CphnoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 428)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(848, 265)
        Me.DataGridView1.TabIndex = 16
        '
        'CnoDataGridViewTextBoxColumn
        '
        Me.CnoDataGridViewTextBoxColumn.DataPropertyName = "Cno"
        Me.CnoDataGridViewTextBoxColumn.HeaderText = "Cno"
        Me.CnoDataGridViewTextBoxColumn.Name = "CnoDataGridViewTextBoxColumn"
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "Cname"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "Cname"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        '
        'CaddrDataGridViewTextBoxColumn
        '
        Me.CaddrDataGridViewTextBoxColumn.DataPropertyName = "Caddr"
        Me.CaddrDataGridViewTextBoxColumn.HeaderText = "Caddr"
        Me.CaddrDataGridViewTextBoxColumn.Name = "CaddrDataGridViewTextBoxColumn"
        '
        'CemailDataGridViewTextBoxColumn
        '
        Me.CemailDataGridViewTextBoxColumn.DataPropertyName = "Cemail"
        Me.CemailDataGridViewTextBoxColumn.HeaderText = "Cemail"
        Me.CemailDataGridViewTextBoxColumn.Name = "CemailDataGridViewTextBoxColumn"
        '
        'CcreditDataGridViewTextBoxColumn
        '
        Me.CcreditDataGridViewTextBoxColumn.DataPropertyName = "Ccredit"
        Me.CcreditDataGridViewTextBoxColumn.HeaderText = "Ccredit"
        Me.CcreditDataGridViewTextBoxColumn.Name = "CcreditDataGridViewTextBoxColumn"
        '
        'CphnoDataGridViewTextBoxColumn
        '
        Me.CphnoDataGridViewTextBoxColumn.DataPropertyName = "Cphno"
        Me.CphnoDataGridViewTextBoxColumn.HeaderText = "Cphno"
        Me.CphnoDataGridViewTextBoxColumn.Name = "CphnoDataGridViewTextBoxColumn"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.ShopdbDataSet1
        '
        'ShopdbDataSet1
        '
        Me.ShopdbDataSet1.DataSetName = "shopdbDataSet1"
        Me.ShopdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 35)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Add Jewellery Customer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.txtItemPrice)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.txtcname)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtItemId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(874, 261)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CustomerDetails"
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(410, 193)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(118, 55)
        Me.btnupdate.TabIndex = 13
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(239, 193)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(103, 55)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cemail", True))
        Me.TextBox2.Location = New System.Drawing.Point(137, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(205, 27)
        Me.TextBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Customer email"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(34, 188)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(124, 60)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(616, 188)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 60)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtItemPrice
        '
        Me.txtItemPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cphno", True))
        Me.txtItemPrice.Location = New System.Drawing.Point(137, 121)
        Me.txtItemPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(212, 27)
        Me.txtItemPrice.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Ccredit", True))
        Me.TextBox1.Location = New System.Drawing.Point(520, 121)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 27)
        Me.TextBox1.TabIndex = 6
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Caddr", True))
        Me.txtQuantity.Location = New System.Drawing.Point(520, 79)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(212, 27)
        Me.txtQuantity.TabIndex = 4
        '
        'txtcname
        '
        Me.txtcname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cname", True))
        Me.txtcname.Location = New System.Drawing.Point(520, 38)
        Me.txtcname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(212, 27)
        Me.txtcname.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(365, 127)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = " Customer Credit:"
        '
        'txtItemId
        '
        Me.txtItemId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cno", True))
        Me.txtItemId.Location = New System.Drawing.Point(137, 44)
        Me.txtItemId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(212, 27)
        Me.txtItemId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(365, 84)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "  Customer Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 127)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "  Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "  Customer Id:"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(159, 352)
        Me.search.Margin = New System.Windows.Forms.Padding(4)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(540, 23)
        Me.search.TabIndex = 15
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(24, 343)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(110, 41)
        Me.btnsearch.TabIndex = 17
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'rtpcust
        '
        Me.rtpcust.Location = New System.Drawing.Point(722, 344)
        Me.rtpcust.Name = "rtpcust"
        Me.rtpcust.Size = New System.Drawing.Size(108, 40)
        Me.rtpcust.TabIndex = 18
        Me.rtpcust.Text = "Report"
        Me.rtpcust.UseVisualStyleBackColor = True
        '
        'frmAddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 697)
        Me.Controls.Add(Me.rtpcust)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.search)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtcname As System.Windows.Forms.TextBox
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShopdbDataSet1 As JewelleryShopManagementSystem.shopdbDataSet1
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As JewelleryShopManagementSystem.shopdbDataSet1TableAdapters.customerTableAdapter
    Friend WithEvents CnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaddrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CemailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CcreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CphnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents rtpcust As System.Windows.Forms.Button
End Class
