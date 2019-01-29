Option Strict On

Public Class Car

    Private Shared carCount As Integer

    Private carIdentificationNumber As Integer = 0

    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get

    End Property

    Private carMake As String
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property


    Private carModel As String
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property


    Private carYear As Integer
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(ByVal value As Integer)
            carYear = value
        End Set
    End Property


    Private carPrice As Decimal
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(ByVal value As Decimal)
            carPrice = value
        End Set
    End Property

    Private isNew As Boolean
    Public Property carNew() As Boolean
        Get
            Return isNew
        End Get
        Set(ByVal value As Boolean)
            isNew = value
        End Set
    End Property

    Public Sub New()

        carCount += 1
        carIdentificationNumber = carCount

    End Sub

    Public Sub New(make As String, model As String, year As Integer, price As Decimal, isNew As Boolean)

        Me.New()

        carMake = make
        carModel = model
        carYear = year
        carPrice = price
        carNew = isNew

    End Sub

    Public Function GetSalutation() As String

        Return "Make: " & carMake & vbCrLf &
               "Model: " & carModel & vbCrLf &
               "Year: " & carYear & vbCrLf &
               "Price: " & FormatNumber(carPrice, 2) & vbCrLf &
               "Condition: " & IIf(carNew = True, "NEW", "OLD").ToString()
    End Function

End Class
