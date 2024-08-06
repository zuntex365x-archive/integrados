Public Class pt
    Private Shared cajat As String
    Private Shared cortet As String
    Private Shared tallat As String
    Private Shared tipot As String
    Private Shared ubicaciont As String
    Private Shared unidades_it As Decimal
    Private Shared unidadest As Decimal
    Private Shared fechat As Date
    Private Shared estadot As String
    Private Shared usuariot As String
    Private Shared clientet As String
    Private Shared escalat As String
    Private Shared ordent As String

    Public Property caja() As String
        Get
            Return cajat
        End Get

        Set(ByVal Value As String)
            cajat = Value
        End Set

    End Property

    Public Property corte() As String
        Get
            Return cortet
        End Get


        Set(ByVal Value As String)
            cortet = Value
        End Set
    End Property

    Public Property talla() As String
        Get
            Return tallat
        End Get


        Set(ByVal Value As String)
            tallat = Value
        End Set
    End Property


    Public Property tipo() As String
        Get
            Return tipot
        End Get

        Set(ByVal Value As String)
            tipot = Value
        End Set
    End Property

    Public Property unidades_i() As Decimal
        Get
            Return unidades_it
        End Get

        Set(ByVal Value As Decimal)
            unidades_it = Value
        End Set
    End Property

    Public Property unidades() As Decimal
        Get
            Return unidadest
        End Get

        Set(ByVal Value As Decimal)
            unidadest = Value
        End Set
    End Property

    Public Property fecha() As Date
        Get
            Return fechat
        End Get

        Set(ByVal Value As Date)
            fechat = Value
        End Set
    End Property

    Public Property estado() As String
        Get
            Return estadot
        End Get

        Set(ByVal Value As String)
            estadot = Value
        End Set
    End Property

    Public Property usuario() As String
        Get
            Return usuariot
        End Get

        Set(ByVal Value As String)
            usuariot = Value
        End Set
    End Property

    Public Property cliente() As String
        Get
            Return clientet
        End Get

        Set(ByVal Value As String)
            clientet = Value
        End Set
    End Property

    Public Property escala() As String
        Get
            Return escalat
        End Get

        Set(ByVal Value As String)
            escalat = Value
        End Set
    End Property

    Public Property orden() As String
        Get
            Return ordent
        End Get

        Set(ByVal Value As String)
            ordent = Value
        End Set

    End Property

End Class
