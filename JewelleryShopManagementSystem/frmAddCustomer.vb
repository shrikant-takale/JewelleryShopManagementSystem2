Imports System.Data.OleDb
Imports System.Data

Public Class frmAddCustomer

    Private Sub frmAddCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopdbDataSet1.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.ShopdbDataSet1.customer)
       

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        CustomerBindingSource.RemoveCurrent()
        If MessageBox.Show("Do you want delete this record?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.CustomerBindingSource.EndEdit()
            MessageBox.Show("Delete Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        CustomerBindingSource.AddNew()

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        CustomerBindingSource.Filter = "Cname='" & search.Text & "'"
    End Sub
    
   
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MessageBox.Show("Do want to save record", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.CustomerBindingSource.EndEdit()
            Me.CustomerTableAdapter.Update(Me.ShopdbDataSet1)
            MessageBox.Show("Save Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If MessageBox.Show("Do want to update record", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.CustomerBindingSource.EndEdit()

            MessageBox.Show("Update Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

   
    Private Sub rtpcust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtpcust.Click
        Form1.Show()
    End Sub
End Class