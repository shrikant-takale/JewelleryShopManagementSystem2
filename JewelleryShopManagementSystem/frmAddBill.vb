Public Class frmAddbill

    Private Sub frmAddbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopdbDataSet.bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.ShopdbDataSet.bill)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        BillBindingSource.AddNew()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MessageBox.Show("Do want to save record", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.BillBindingSource.EndEdit()
            Me.BillTableAdapter.Update(Me.ShopdbDataSet)
            MessageBox.Show("Save Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If MessageBox.Show("Do want to update record", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.BillBindingSource.EndEdit()

            MessageBox.Show("Update Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        BillBindingSource.RemoveCurrent()
        If MessageBox.Show("Do want to delete record", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.BillBindingSource.EndEdit()
            MessageBox.Show("Delete Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total.Click
        Dim n As Integer
        n = (txtrate.Text * txtqty.Text)
        txtgst.Text = (n / 100) * 18
        bamt.Text = n + txtcredit.Text + txtgst.Text
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        BillBindingSource.Filter = "Bno='" & search.Text & "'"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptbill.Click
        Form2.Show()
    End Sub
End Class