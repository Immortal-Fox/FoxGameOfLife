Public Class NotesVersion


    Private Sub NotesVersion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtb_versionCourante.Dock = DockStyle.Fill
        txtb_anciennesVersions.Dock = DockStyle.Fill
    End Sub

    Private Sub bt_versionCourante_Click(sender As Object, e As EventArgs) Handles bt_versionCourante.Click
        bt_anciennesVersions.Dock = DockStyle.Bottom
        txtb_versionCourante.Visible = True
        txtb_versionCourante.Dock = DockStyle.Fill
        txtb_anciennesVersions.Visible = False
    End Sub

    Private Sub bt_anciennesVersions_Click(sender As Object, e As EventArgs) Handles bt_anciennesVersions.Click
        bt_anciennesVersions.Dock = DockStyle.Top
        txtb_versionCourante.Visible = False
        txtb_anciennesVersions.Visible = True
    End Sub
End Class