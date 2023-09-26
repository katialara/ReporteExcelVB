Module Variable
    Public Query As String
    Public i As Integer
    Public conexion As New SqlClient.SqlConnection("data source=LAPTOP-HAO3D8QC\SQLEXPRESS; initial catalog =Capacitacion; integrated security=SSPI; persist security info = false; trusted_connection = yes;")
    Public cmd As SqlClient.SqlCommand
    Public sqlread As SqlClient.SqlDataReader
End Module
