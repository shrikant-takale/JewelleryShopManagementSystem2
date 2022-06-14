Public Class frmAddEmployee

    Private Sub frmAddEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopdbDataSet2.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.ShopdbDataSet2.employee)
       

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        EmployeeBindingSource.AddNew()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Do want to save ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.ShopdbDataSet2)
            MessageBox.Show("Save Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If MessageBox.Show("Do want to update ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            MessageBox.Show("Update Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        EmployeeBindingSource.RemoveCurrent()
        If MessageBox.Show("Do want to delete ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()

            MessageBox.Show("Delete Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    
    Private Sub Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.Click
        EmployeeBindingSource.Filter = "Eno='" & txtsearch.Text & "'"
    End Sub

  
    Private Sub rptemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptemp.Click
        Form3.Show()
    End Sub
End Class