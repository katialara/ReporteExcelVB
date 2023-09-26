Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CapacitacionDataSet1.Instructor' Puede moverla o quitarla según sea necesario.
        Me.InstructorTableAdapter.Fill(Me.CapacitacionDataSet1.Instructor)
        Dim m_Excel As Microsoft.Office.Interop.Excel.Application
        Dim aPath As String = My.Application.Info.DirectoryPath
        Dim ruta As String = "C:\Users\pauli\OneDrive\Desktop\ExcelPI_VB.xlsx"
        m_Excel = New Microsoft.Office.Interop.Excel.Application
        m_Excel.Visible = True
        Dim objLibroExcel As Microsoft.Office.Interop.Excel.Workbook
        Dim objHojaExcel As Microsoft.Office.Interop.Excel.Worksheet
        objLibroExcel = m_Excel.Workbooks.Open(ruta)
        Dim objSQLconect As New System.Data.OleDb.OleDbConnection("Provider=SQLOLEdb; data source= LAPTOP-HAO3D8QC\SQLEXPRESS; initial catalog = capacitacion; integrated security=SSPI; persist security info = false; trusted_conection = yes;")


        Query = "SELECT Id_Instructor, Nombre, Tipo FROM Instructor
                     WHERE Tipo='E' AND Id_Instructor IN (
                     SELECT Id_Instructor FROM Ctr_Cursos
                     WHERE EstatuCurso IN ('A', 'P'))"

        Dim objSQLAdapter As New OleDb.OleDbDataAdapter(Query, objSQLconect)
        Dim objDataSet As New DataSet("ExcelTest")
        objSQLAdapter.Fill(objDataSet, "Instructor")

        'Creamos una variable para guardar la cultura actual
        Dim OldcultureInfo As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

        'Crear una cultura standar (en-US) ingles estados unidos
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")


        'Creamos una instancia de la primera hoja de trabajo de Excel
        objHojaExcel = objLibroExcel.Worksheets(1)
        ' objHojaExcel.Visible = Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Cells(, "J") = ""

        i = 6
        For Each objrow As DataRow In objDataSet.Tables(0).Rows
            'Asignar los valores de los registros a las celdas
            objHojaExcel.Cells(i, "D") = objrow.Item("Id_Curso")
            objHojaExcel.Cells(i, "E") = objrow.Item("Nombre")
            objHojaExcel.Cells(i, "F") = objrow.Item("Tipo")


            'Avanzamos una fila
            i += 1
        Next
        MsgBox("Reporte realizado correctamente")
    End Sub
End Class
