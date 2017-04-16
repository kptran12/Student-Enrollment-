Public Class clsStudent
    Private strBroncoId As String
    Private strFirstName As String
    Private strLastName As String
    Private strPhone As String
    Private strEmail As String

    Public Property broncoID As String
        Get
            Return strBroncoId
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Bronco_ID")) Then
                strBroncoId = value
            End If
        End Set
    End Property

    Public Property firstName As String
        Get
            Return strFirstName
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "First_Name")) Then
                strFirstName = value
            End If
        End Set
    End Property

    Public Property lastName As String
        Get
            Return strLastName
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Last_Name")) Then
                strLastName = value
            End If
        End Set
    End Property

    Public Property phone As String
        Get
            Return strPhone
        End Get
        Set(value As String)
            If clsValidator.isValidPhone(value) = True Then
                strPhone = value
            End If
        End Set
    End Property

    Public Property email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            If clsValidator.IsValidEmail(value) = True Then
                strEmail = value
            End If
        End Set
    End Property


End Class
