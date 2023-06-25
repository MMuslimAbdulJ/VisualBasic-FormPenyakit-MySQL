Imports MySql.Data.MySqlClient

Public Class FormPenyakit
    Dim conn As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim listPenyakit As New List(Of String)()
    Dim listICD As New List(Of String)()

    Private Sub FormPenyakit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database()
        AddListOfData()
        RefreshDGV()
    End Sub

    Private Sub cbICD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbICD.SelectedIndexChanged
        Select Case cbICD.SelectedItem
            Case "150.0"
                tbPenyakit.Text = listPenyakit.Item(0)
            Case "K04.1"
                tbPenyakit.Text = listPenyakit.Item(1)
            Case "N40.0"
                tbPenyakit.Text = listPenyakit.Item(2)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btBaru.Click
        tbKode.Text = ""
        cbICD.Items.Clear()
        tbPenyakit.Text = ""
        tbTotal.Text = ""
        tbKode.Focus()
        AddListOfData()
    End Sub

    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Dim sql As String = "INSERT INTO penyakitbesar (Kode, ICD, Penyakit, Total) VALUES (@Kode, @ICD, @Penyakit, @Total)"
        Dim command As New MySqlCommand(sql, conn)
        command.Parameters.AddWithValue("@Kode", tbKode.Text)
        command.Parameters.AddWithValue("@ICD", cbICD.Text)
        command.Parameters.AddWithValue("@Penyakit", tbPenyakit.Text)
        command.Parameters.AddWithValue("@Total", tbTotal.Text)
        command.ExecuteNonQuery()
        RefreshDGV()
    End Sub

    Private Sub btHapus_Click(sender As Object, e As EventArgs) Handles btHapus.Click
        Dim sql As String = "DELETE FROM penyakitbesar"
        Dim command As New MySqlCommand(sql, conn)
        command.ExecuteNonQuery()
        RefreshDGV()
    End Sub

    Private Sub btTutup_Click(sender As Object, e As EventArgs) Handles btTutup.Click
        Close()
    End Sub

    Private Sub Database()
        myConnectionString = "server=127.0.0.1;" _
            & "uid=mmuslimabdulj;" _
            & "pwd=Babang_030;" _
            & "database=visual_basic"
        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RefreshDGV()
        ' Mendapatkan data terbaru dari database
        Dim sqlSelect As String = "SELECT * FROM penyakitbesar"
        Dim commandSelect As New MySqlCommand(sqlSelect, conn)
        Dim adapter As New MySqlDataAdapter(commandSelect)
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "DGVPenyakit")
        ' Menetapkan sumber data DataGridView dengan data yang baru
        DGVPenyakit.DataSource = dataset.Tables("DGVPenyakit")
        ' Refresh DataGridView
        DGVPenyakit.Refresh()
    End Sub

    Private Sub AddListOfData()
        listPenyakit.Add("Congestive Heart Failure")
        listPenyakit.Add("Necrosis of Pulp")
        listPenyakit.Add("Hyperplasia of Prostate")
        listICD.Add("150.0")
        listICD.Add("K04.1")
        listICD.Add("N40.0")
        For Each item As String In listICD
            If Not cbICD.Items.Contains(item) Then
                cbICD.Items.Add(item)
            End If
        Next
    End Sub
End Class
