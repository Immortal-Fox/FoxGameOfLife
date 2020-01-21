Public Class OngletPreset
    Inherits ToolStripDropDown

    Private nom As String

    ' Settings


    Sub New(ByVal _path As String, ByVal _nom As String)

        'Mise en forme
        Me.Text = _nom

    End Sub

End Class
