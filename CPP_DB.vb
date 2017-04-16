Imports System.Data.SqlClient
Public Class CPP_DB
    Private Shared cn As SqlConnection
    Private Shared strError As String



    Public Shared Function loadStudents() As List(Of clsStudent)
        'List of students that will be returned
        Dim studentList As New List(Of clsStudent)

        'DB variables
        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader

        'clear the errors
        strError = ""

        Try
            strSQL = "Select * From CPP_STUDENTS"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text
            rdr = cmd.ExecuteReader()

            Do While rdr.Read()
                'Add basic student information
                Dim aStudent As New clsStudent
                aStudent.broncoID = rdr("BRONCO_ID")
                aStudent.firstName = rdr("FIRST_NAME")
                aStudent.lastName = rdr("LAST_NAME")
                aStudent.email = rdr("EMAIL")
                aStudent.phone = rdr("PHONE")

                studentList.Add(aStudent)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try
        Return studentList
    End Function

    Public Shared Function deleteStudent(strStudentID As String) As Integer
        'Result that will be returned
        Dim intResult As Integer = 0

        'DB variables
        Dim cmd As New SqlCommand
        Dim strSQL As String

        'Clear errors
        strError = ""

        'Delete from database
        Try
            strSQL = "Delete from CPP_STUDENTS where BRONCO_ID = '" & strStudentID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            If (intResult < 1) Then
                dbAddError("DELETE Failed, Student id " & strStudentID & " was not found!")
            End If

            dbClose()
        Catch ex As Exception
            dbAddError("DELETE Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Sub updateStudent(aStudent As clsStudent)
        strError = ""

        'To update we remove old student and add new student
        'there are other ways to do this as well using the update statement
        deleteStudent(aStudent.broncoID)
        insertStudent(aStudent)

        If strError <> "" Then
            strError = "Could not Update student " & aStudent.broncoID & vbCrLf & vbCrLf & strError
        End If
    End Sub

    Public Shared Function insertStudent(aStudent As clsStudent) As Integer
        'Result that will be returned
        Dim intResult As Integer = 0

        'DB variables
        Dim cmd As New SqlCommand
        Dim strStudentSQL As String

        'clear the errors
        strError = ""

        'insert into database
        Try
            dbConnect()
            strStudentSQL = "INSERT INTO CPP_STUDENTS (BRONCO_ID, FIRST_NAME, LAST_NAME, PHONE, EMAIL) " & _
                            "values('" & aStudent.broncoID & "','" & aStudent.firstName & "','" & aStudent.lastName & "','" & aStudent.phone & "', '" & _
                            aStudent.email & "')"

            cmd.Connection = cn
            cmd.CommandText = strStudentSQL
            cmd.ExecuteNonQuery()

            dbClose()
        Catch ex As Exception
            dbAddError("Insert Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Function findStudent(strStudentID As String) As clsStudent
        'student that will be returned
        Dim aStudent As clsStudent = New clsStudent

        'db variables
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader
        Dim strSQL As String

        'clear error
        strError = ""

        Try
            Dim MyData As New ArrayList

            strSQL = "Select * From CPP_STUDENT Where ID = '" & strStudentID & "'"
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text

            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                aStudent.broncoID = rdr("BRONCO_ID")
                aStudent.firstName = rdr("FIRST_NAME")
                aStudent.lastName = rdr("LAST_NAME")
                aStudent.email = rdr("EMAIL")
                aStudent.phone = rdr("PHONE")
            Else
                dbAddError("Student not found")
            End If

        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try

        Return aStudent
    End Function

    'Instructor Functions
    'Load Instructor's table
    Public Shared Function loadInstructors() As List(Of clsInstructor)
        Dim instructorList As New List(Of clsInstructor)

        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        strError = ""

        Try
            strSQL = "SELECT * FROM CPP_INSTRUCTORS"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                Dim aInstructor As New clsInstructor
                aInstructor.profID = reader("PROF_ID")
                aInstructor.firstName = reader("FIRST_NAME")
                aInstructor.lastName = reader("LAST_NAME")
                aInstructor.phone = reader("PHONE")
                aInstructor.department = reader("DEPARTMENT")

                instructorList.Add(aInstructor)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try

        Return instructorList
    End Function


    'Insert new instructor
    Public Shared Function insertInstructor(aInstructor As clsInstructor) As Integer
        Dim intResult As Integer = 0
        Dim cmd As New SqlCommand

        Dim strInstructSQL As String

        strError = ""

        Try
            dbConnect()
            strInstructSQL = "INSERT INTO CPP_INSTRUCTORS (PROF_ID, FIRST_NAME, LAST_NAME, PHONE, DEPARTMENT)" & "values('" & aInstructor.profID & "','" & aInstructor.firstName & "','" & aInstructor.lastName & "','" & aInstructor.phone & "','" & aInstructor.department & "')"
            cmd.Connection = cn
            cmd.CommandText = strInstructSQL
            cmd.ExecuteNonQuery()

            dbClose()

        Catch ex As Exception
            dbAddError("Inserting a new instructor failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    'Delete an instructor
    Public Shared Function deleteInstructor(strInstructorID As String) As Integer
        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strSQL As String

        strError = ""

        Try
            strSQL = "DELETE FROM CPP_INSTRUCTORS WHERE PROF_ID = '" & strInstructorID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            'If the result of the query comes out to zero then give an error
            If (intResult < 1) Then
                dbAddError("Deletion has failed: Instructor's ID, " & strInstructorID & "wasn't found!")
            End If

            dbClose()


        Catch ex As Exception
            dbAddError("Deletion has failed" & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function


    'Update an already existing instructor

    Public Shared Sub updateInstructor(aInstructor As clsInstructor)
        strError = ""

        deleteInstructor(aInstructor.profID)
        insertInstructor(aInstructor)

        If strError <> "" Then
            strError = "Couldn't update Instructor information for " & aInstructor.profID & vbCrLf & vbCrLf & strError
        End If
    End Sub

    'Course Functions
    Public Shared Function loadCourses() As List(Of clsCourse)
        Dim courseList As New List(Of clsCourse)

        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        strError = ""

        Try
            strSQL = "SELECT * FROM CPP_COURSES"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text

            reader = cmd.ExecuteReader()

            Do While reader.Read()
                Dim aCourse As New clsCourse
                aCourse.courseID = reader("COURSE_ID")
                aCourse.desc = reader("DESCRIPTION")
                aCourse.units = reader("UNITS")

                courseList.Add(aCourse)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)

        End Try

        Return courseList
    End Function

    Public Shared Function insertCourse(aCourse As clsCourse) As Integer
        Dim intResult As Integer = 0
        Dim cmd As New SqlCommand

        Dim strCourseSQL As String

        strError = ""

        Try
            dbConnect()
            strCourseSQL = "INSERT INTO CPP_COURSES (COURSE_ID, DESCRIPTION, UNITS)" & "values('" & aCourse.courseID & "','" & aCourse.desc & "','" & aCourse.units & "')"
            cmd.Connection = cn
            cmd.CommandText = strCourseSQL
            cmd.ExecuteNonQuery()

            dbClose()

        Catch ex As Exception
            dbAddError("Inserting a new course failed: " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Function deleteCourse(strCourseID As String) As Integer
        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strSQL As String

        strError = ""

        Try
            strSQL = "DELETE FROM CPP_COURSES WHERE COURSE_ID = '" & strCourseID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            If (intResult < 1) Then
                dbAddError("Deletion has failed: Course ID, " & strCourseID & "wasn't found!")
            End If

            dbClose()

        Catch ex As Exception
            dbAddError("Deletion has failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Sub updateCourse(aCourse As clsCourse)
        strError = ""
        deleteCourse(aCourse.courseID)
        insertCourse(aCourse)

        If strError <> "" Then
            strError = "Couldn't update Course information for " & aCourse.courseID & vbCrLf & vbCrLf & strError
        End If

    End Sub

    'Catalog Functions
    Public Shared Function loadCatalog() As List(Of clsCatalog)
        Dim catalogList As New List(Of clsCatalog)

        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        strError = ""

        Try
            strSQL = "SELECT * FROM CPP_CATALOG"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                Dim aCatalog As New clsCatalog
                aCatalog.catalogID = reader("CATALOG_ID")
                aCatalog.year = reader("YEAR")
                aCatalog.quarter = reader("QUARTER")
                aCatalog.courseId = reader("COURSE_ID")
                aCatalog.profId = reader("PROF_ID")

                catalogList.Add(aCatalog)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try
        Return catalogList
    End Function

    Public Shared Function insertCatalog(aCatalog As clsCatalog) As Integer
        Dim intResult As Integer = 0
        Dim cmd As New SqlCommand

        Dim strCatalogSQL As String

        strError = ""

        Try
            dbConnect()
            strCatalogSQL = "INSERT INTO CPP_CATALOG (CATALOG_ID, YEAR, QUARTER, COURSE_ID, PROF_ID)" & "values('" & aCatalog.catalogID & "','" & aCatalog.year & "','" & aCatalog.quarter & "','" & aCatalog.courseId & "','" & aCatalog.profId & "')"
            cmd.Connection = cn
            cmd.CommandText = strCatalogSQL
            cmd.ExecuteNonQuery()

            dbClose()
        Catch ex As Exception
            dbAddError("Inserting a new catalog entry has failed" & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Function deleteCatalog(strCatalogID As String) As Integer
        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strSQL As String

        strError = ""

        Try
            strSQL = "DELETE FROM CPP_CATALOG WHERE CATALOG_ID = '" & strCatalogID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            If (intResult < 1) Then
                dbAddError("Deletion has failed: Catalog ID, " & strCatalogID & " wasn't found!")
            End If

            dbClose()
        Catch ex As Exception
            dbAddError("Deletion has failed. " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Sub updateCatalog(aCatalog As clsCatalog)
        strError = ""

        deleteCatalog(aCatalog.catalogID)
        insertCatalog(aCatalog)

        If strError <> "" Then
            strError = "Could not update the current catalog entry's information."
        End If
    End Sub

    'Enrollment Functions
    'Load Enrollment
    Public Shared Function loadEnroll() As List(Of clsEnrollment)
        Dim enrollList As New List(Of clsEnrollment)

        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        strError = ""

        Try
            strSQL = "SELECT * FROM CPP_ENROLLMENT"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                Dim aEnrollment As New clsEnrollment
                aEnrollment.broncoId = reader("BRONCO_ID")
                aEnrollment.catalogID = reader("CATALOG_ID")

                enrollList.Add(aEnrollment)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try
        Return enrollList
    End Function

    'Insert a new enrollment entry
    Public Shared Function insertEnroll(aEnrollment As clsEnrollment) As Integer
        Dim intresult As Integer = 0
        Dim cmd As New SqlCommand

        Dim strEnrollSQL As String

        strError = ""

        Try
            dbConnect()
            strEnrollSQL = "INSERT INTO CPP_ENROLLMENT (BRONCO_ID, CATALOG_ID)" & "values('" & aEnrollment.broncoId & "','" & aEnrollment.catalogID & "')"
            cmd.Connection = cn
            cmd.CommandText = strEnrollSQL
            cmd.ExecuteNonQuery()

            dbClose()
        Catch ex As Exception
            dbAddError("Inserting a new enrollment entry has failed" & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intresult
    End Function

    'Delete a selected enrollment entry
    Public Shared Function deleteEnroll(strBroncoID As String, strCourseID As String) As Integer
        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strSQL As String

        strError = ""

        Try
            strSQL = "DELETE FROM CPP_ENROLLMENT WHERE BRONCO_ID = '" & strBroncoID & " AND COURSE_ID =" & strCourseID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            'If the result of the query gives nothing, give an error
            If (intResult < 1) Then
                dbAddError("Deletion has failed. A match wasn't found!")
            End If

            dbClose()

        Catch ex As Exception
            dbAddError("Deletion has failed" & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Sub updateEnroll(aEnrollment As clsEnrollment)
        strError = ""
        deleteEnroll(aEnrollment.broncoId, aEnrollment.catalogID)
        insertEnroll(aEnrollment)

        If strError <> "" Then
            strError = "Could not update enrollment information. Please try again" & vbCrLf & vbCrLf & strError
        End If
    End Sub

    'Combobox loads
    Public Shared Function loadCourseCB() As List(Of clsCourse)
        Dim courseList As New List(Of clsCourse)

        Dim strSql As String
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        strError = ""

        Try
            strSql = "SELECT COURSE_ID, DESCRIPTION, CAST(COURSE_ID AS nvarchar(20)) + '-' + DESCRIPTION AS COURSEID_DESC FROM CPP_COURSES"

            dbConnect()
            cmd = New SqlCommand(strSql, cn)
            cmd.CommandType = CommandType.Text
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                Dim aCourse As New clsCourse
                aCourse.courseID = reader("COURSE_ID")
                aCourse.desc = reader("DESCRIPTION")

                courseList.Add(aCourse)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try
        Return courseList
    End Function

    Public Shared Sub dbOpen()
        'Only assign one reference to the connection
        If IsNothing(cn) Then
            cn = New SqlConnection
            'EXAMPLE OF CONNECTION STRING TO A SQL SERVER INSTANCE
            'cn.ConnectionString = "Data Source=SKYNET\SQLEXPRESS;Initial Catalog=CPP;Integrated Security=True"

            'EXAMPLE OF CONNECTION TO A LOCAL DATABASE FILE. YOU MIGHT NEED TO ADJUST THE CONNECTION STRING
            'BASED ON YOUR PROJECT DATABASE VERSION. 
            cn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CPP.mdf;Integrated Security=True"

        End If
    End Sub

    Public Shared Sub dbConnect()
        'Only open if connection is closed
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub

    Public Shared Sub dbClose()
        'Only close if open
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub

    Private Shared Sub dbAddError(ByVal s As String)
        'build error
        If strError = "" Then
            strError = s
        Else
            strError += vbCrLf & s
        End If
    End Sub

    Public Shared Function dbGetError() As String
        'return error
        Return strError
    End Function
End Class
