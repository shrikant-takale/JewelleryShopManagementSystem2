<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddbill
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShopdbDataSet = New JewelleryShopManagementSystem.shopdbDataSet()
        Me.txtcredit = New System.Windows.Forms.TextBox()
        Me.ccredit = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Button()
        Me.amt = New System.Windows.Forms.Label()
        Me.bamt = New System.Windows.Forms.TextBox()
        Me.GST = New System.Windows.Forms.Label()
        Me.txtgst = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Itemqty = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.itemreate = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtbno = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillTableAdapter = New JewelleryShopManagementSystem.shopdbDataSetTableAdapters.billTableAdapter()
        Me.rptbill = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 35)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Add Customer Bill"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.txtcredit)
        Me.GroupBox1.Controls.Add(Me.ccredit)
        Me.GroupBox1.Controls.Add(Me.total)
        Me.GroupBox1.Controls.Add(Me.amt)
        Me.GroupBox1.Controls.Add(Me.bamt)
        Me.GroupBox1.Controls.Add(Me.GST)
        Me.GroupBox1.Controls.Add(Me.txtgst)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.Itemqty)
        Me.GroupBox1.Controls.Add(Me.txtrate)
        Me.GroupBox1.Controls.Add(Me.itemreate)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.txtbno)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(914, 351)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Biil Details"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Bdate", True))
        Me.TextBox4.Location = New System.Drawing.Point(628, 52)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(219, 27)
        Me.TextBox4.TabIndex = 2
        '
        'BillBindingSource
        '
        Me.BillBindingSource.DataMember = "bill"
        Me.BillBindingSource.DataSource = Me.ShopdbDataSet
        '
        'ShopdbDataSet
        '
        Me.ShopdbDataSet.DataSetName = "shopdbDataSet"
        Me.ShopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtcredit
        '
        Me.txtcredit.Location = New System.Drawing.Point(183, 259)
        Me.txtcredit.Name = "txtcredit"
        Me.txtcredit.Size = New System.Drawing.Size(216, 27)
        Me.txtcredit.TabIndex = 8
        '
        'ccredit
        '
        Me.ccredit.AutoSize = True
        Me.ccredit.Location = New System.Drawing.Point(10, 259)
        Me.ccredit.Name = "ccredit"
        Me.ccredit.Size = New System.Drawing.Size(132, 20)
        Me.ccredit.TabIndex = 25
        Me.ccredit.Text = "Customer Credit"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(700, 304)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(115, 40)
        Me.total.TabIndex = 24
        Me.total.Text = "Total"
        Me.total.UseVisualStyleBackColor = True
        '
        'amt
        '
        Me.amt.AutoSize = True
        Me.amt.Location = New System.Drawing.Point(469, 252)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(95, 20)
        Me.amt.TabIndex = 23
        Me.amt.Text = "Bill Amount"
        '
        'bamt
        '
        Me.bamt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Bamt", True))
        Me.bamt.Location = New System.Drawing.Point(625, 252)
        Me.bamt.Name = "bamt"
        Me.bamt.Size = New System.Drawing.Size(222, 27)
        Me.bamt.TabIndex = 9
        '
        'GST
        '
        Me.GST.AutoSize = True
        Me.GST.Location = New System.Drawing.Point(24, 217)
        Me.GST.Name = "GST"
        Me.GST.Size = New System.Drawing.Size(43, 20)
        Me.GST.TabIndex = 21
        Me.GST.Text = "GST"
        '
        'txtgst
        '
        Me.txtgst.Enabled = False
        Me.txtgst.Location = New System.Drawing.Point(183, 210)
        Me.txtgst.Name = "txtgst"
        Me.txtgst.Size = New System.Drawing.Size(222, 27)
        Me.txtgst.TabIndex = 20
        Me.txtgst.Text = "18"
        '
        'txtqty
        '
        Me.txtqty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Iqty", True))
        Me.txtqty.Location = New System.Drawing.Point(625, 210)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(223, 27)
        Me.txtqty.TabIndex = 7
        '
        'Itemqty
        '
        Me.Itemqty.AutoSize = True
        Me.Itemqty.Location = New System.Drawing.Point(469, 210)
        Me.Itemqty.Name = "Itemqty"
        Me.Itemqty.Size = New System.Drawing.Size(108, 20)
        Me.Itemqty.TabIndex = 18
        Me.Itemqty.Text = "Item Quantity"
        '
        'txtrate
        '
        Me.txtrate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Irate", True))
        Me.txtrate.Location = New System.Drawing.Point(183, 154)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(219, 27)
        Me.txtrate.TabIndex = 5
        '
        'itemreate
        '
        Me.itemreate.AutoSize = True
        Me.itemreate.Location = New System.Drawing.Point(24, 161)
        Me.itemreate.Name = "itemreate"
        Me.itemreate.Size = New System.Drawing.Size(81, 20)
        Me.itemreate.TabIndex = 16
        Me.itemreate.Text = "Item Rate"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(526, 304)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(103, 40)
        Me.btndelete.TabIndex = 15
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(353, 304)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(123, 40)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(189, 304)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(123, 40)
        Me.btnsave.TabIndex = 13
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(19, 304)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(123, 40)
        Me.btnadd.TabIndex = 12
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtbno
        '
        Me.txtbno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Bno", True))
        Me.txtbno.Location = New System.Drawing.Point(180, 45)
        Me.txtbno.Name = "txtbno"
        Me.txtbno.Size = New System.Drawing.Size(222, 27)
        Me.txtbno.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "cno", True))
        Me.TextBox3.Location = New System.Drawing.Point(183, 100)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(222, 27)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Iname", True))
        Me.TextBox2.Location = New System.Drawing.Point(626, 154)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(222, 27)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Cname", True))
        Me.TextBox1.Location = New System.Drawing.Point(626, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 27)
        Me.TextBox1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(469, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Item Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cusomer No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(466, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Bill Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(466, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill No"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(32, 439)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(123, 40)
        Me.btnsearch.TabIndex = 16
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(212, 446)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(360, 27)
        Me.search.TabIndex = 25
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.InameDataGridViewTextBoxColumn, Me.IrateDataGridViewTextBoxColumn, Me.IqtyDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn5})
        Me.DataGridView1.DataSource = Me.BillBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 493)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(911, 187)
        Me.DataGridView1.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Bno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bdate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bdate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cno"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'InameDataGridViewTextBoxColumn
        '
        Me.InameDataGridViewTextBoxColumn.DataPropertyName = "Iname"
        Me.InameDataGridViewTextBoxColumn.HeaderText = "Iname"
        Me.InameDataGridViewTextBoxColumn.Name = "InameDataGridViewTextBoxColumn"
        '
        'IrateDataGridViewTextBoxColumn
        '
        Me.IrateDataGridViewTextBoxColumn.DataPropertyName = "Irate"
        Me.IrateDataGridViewTextBoxColumn.HeaderText = "Irate"
        Me.IrateDataGridViewTextBoxColumn.Name = "IrateDataGridViewTextBoxColumn"
        '
        'IqtyDataGridViewTextBoxColumn
        '
        Me.IqtyDataGridViewTextBoxColumn.DataPropertyName = "Iqty"
        Me.IqtyDataGridViewTextBoxColumn.HeaderText = "Iqty"
        Me.IqtyDataGridViewTextBoxColumn.Name = "IqtyDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Bamt"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Bamt"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'BillTableAdapter
        '
        Me.BillTableAdapter.ClearBeforeFill = True
        '
        'rptbill
        '
        Me.rptbill.Location = New System.Drawing.Point(639, 443)
        Me.rptbill.Name = "rptbill"
        Me.rptbill.Size = New System.Drawing.Size(153, 33)
        Me.rptbill.TabIndex = 27
        Me.rptbill.Text = "Report"
        Me.rptbill.UseVisualStyleBackColor = True
        '
        'frmAddbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 692)
        Me.Controls.Add(Me.rptbill)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "frmAddbill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Bill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtbno As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView


    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Itemqty As System.Windows.Forms.Label
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents itemreate As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Button
    Friend WithEvents amt As System.Windows.Forms.Label
    Friend WithEvents bamt As System.Windows.Forms.TextBox
    Friend WithEvents GST As System.Windows.Forms.Label
    Friend WithEvents txtgst As System.Windows.Forms.TextBox
    Friend WithEvents BnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BamtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShopdbDataSet As JewelleryShopManagementSystem.shopdbDataSet
    Friend WithEvents BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillTableAdapter As JewelleryShopManagementSystem.shopdbDataSetTableAdapters.billTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IrateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtcredit As System.Windows.Forms.TextBox
    Friend WithEvents ccredit As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents rptbill As System.Windows.Forms.Button
End Class
