Public Class clsInstructor
    Private strProfID As String
    Private strFN As String
    Private strLN As String
    Private strPhone As String
    Private strDepartment As String

    Public Property profID As String
        Get
            Return strProfID
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Prof_ID")) Then
                strProfID = value
            End If
        End Set
    End Property

    Public Property firstName As String
        Get
            Return strFN
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "First_Name")) Then
                strFN = value
            End If
        End Set
    End Property

    Public Property lastName As String
        Get
            Return strLN
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Last_Name")) Then
                strLN = value
            End If
        End Set
    End Property

    Public Property phone As String
        Get
            Return strPhone
        End Get
        Set(value As String)
            If (clsValidator.isValidPhone(value)) Then
                strPhone = value
            End If
        End Set
    End Property

    Public Property department As String
        Get
            Return strDepartment
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Department")) Then
                strDepartment = value
            End If
        End Set
    End Property
End Class
