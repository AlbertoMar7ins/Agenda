Public Class Form1

    Private Sub AgendaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AgendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AgendaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AgendaDataSet.Agenda' table. You can move, or remove it, as needed.
        Me.AgendaTableAdapter.Fill(Me.AgendaDataSet.Agenda)

    End Sub

    Private Sub AgendaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AgendaDataGridView.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
