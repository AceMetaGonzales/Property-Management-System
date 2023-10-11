Module DataGridViewToDataTableConverter
    Public Function DataGridViewToDataTable(dataGridView As DataGridView) As DataTable
        Dim dataTable As New DataTable()

        ' Create columns in the DataTable based on the DataGridView columns
        For Each column As DataGridViewColumn In dataGridView.Columns
            Dim dataType As Type = If(column.ValueType IsNot Nothing, column.ValueType, GetType(Object))
            dataTable.Columns.Add(column.HeaderText, dataType)
        Next

        ' Add rows to the DataTable based on the DataGridView rows
        For Each row As DataGridViewRow In dataGridView.Rows

            Dim dataRow As DataRow = dataTable.NewRow()

            For Each cell As DataGridViewCell In row.Cells
                dataRow(cell.ColumnIndex) = cell.Value
            Next

            dataTable.Rows.Add(dataRow)
        Next

        Return dataTable
    End Function
End Module
