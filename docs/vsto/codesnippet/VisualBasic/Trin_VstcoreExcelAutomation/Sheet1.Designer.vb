'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17348
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''
<Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(1), _
 Global.System.Security.Permissions.PermissionSetAttribute(Global.System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")> _
Partial Public NotInheritable Class Sheet1
    Inherits Microsoft.Office.Tools.Excel.WorksheetBase

    Friend WithEvents defaultSavePath As Microsoft.Office.Tools.Excel.NamedRange

    Friend WithEvents dateComment As Microsoft.Office.Tools.Excel.NamedRange

    Friend WithEvents data2001 As Microsoft.Office.Tools.Excel.NamedRange

    Friend WithEvents data2002 As Microsoft.Office.Tools.Excel.NamedRange

    Friend WithEvents dataAll As Microsoft.Office.Tools.Excel.NamedRange

    Friend WithEvents rangeStyles As Microsoft.Office.Tools.Excel.NamedRange

    Friend WithEvents Fruits As Microsoft.Office.Tools.Excel.NamedRange

    Friend WithEvents message As Microsoft.Office.Tools.Excel.NamedRange

    Friend WithEvents fruitList As Microsoft.Office.Tools.Excel.ListObject

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Public Sub New(ByVal factory As Global.Microsoft.Office.Tools.Excel.Factory, ByVal serviceProvider As Global.System.IServiceProvider)
        MyBase.New(factory, serviceProvider, "Sheet1", "Sheet1")
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        Globals.Sheet1 = Me
        Global.System.Windows.Forms.Application.EnableVisualStyles()
        Me.InitializeCachedData()
        Me.InitializeControls()
        Me.InitializeComponents()
        Me.InitializeData()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub FinishInitialization()
        Me.OnStartup()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub InitializeDataBindings()
        Me.BeginInitialization()
        Me.BindToData()
        Me.EndInitialization()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeCachedData()
        If (Me.DataHost Is Nothing) Then
            Return
        End If
        If Me.DataHost.IsCacheInitialized Then
            Me.DataHost.FillCachedData(Me)
        End If
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeData()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub BindToData()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Sub StartCaching(ByVal MemberName As String)
        Me.DataHost.StartCaching(Me, MemberName)
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Sub StopCaching(ByVal MemberName As String)
        Me.DataHost.StopCaching(Me, MemberName)
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Function IsCached(ByVal MemberName As String) As Boolean
        Return Me.DataHost.IsCached(Me, MemberName)
    End Function

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub BeginInitialization()
        Me.BeginInit()
        Me.defaultSavePath.BeginInit()
        Me.dateComment.BeginInit()
        Me.data2001.BeginInit()
        Me.data2002.BeginInit()
        Me.dataAll.BeginInit()
        Me.rangeStyles.BeginInit()
        Me.Fruits.BeginInit()
        Me.message.BeginInit()
        Me.fruitList.BeginInit()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub EndInitialization()
        Me.fruitList.EndInit()
        Me.message.EndInit()
        Me.Fruits.EndInit()
        Me.rangeStyles.EndInit()
        Me.dataAll.EndInit()
        Me.data2002.EndInit()
        Me.data2001.EndInit()
        Me.dateComment.EndInit()
        Me.defaultSavePath.EndInit()
        Me.EndInit()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeControls()
        Me.defaultSavePath = Globals.Factory.CreateNamedRange(Nothing, Nothing, "defaultSavePath", "defaultSavePath", Me)
        Me.dateComment = Globals.Factory.CreateNamedRange(Nothing, Nothing, "dateComment", "dateComment", Me)
        Me.data2001 = Globals.Factory.CreateNamedRange(Nothing, Nothing, "data2001", "data2001", Me)
        Me.data2002 = Globals.Factory.CreateNamedRange(Nothing, Nothing, "data2002", "data2002", Me)
        Me.dataAll = Globals.Factory.CreateNamedRange(Nothing, Nothing, "dataAll", "dataAll", Me)
        Me.rangeStyles = Globals.Factory.CreateNamedRange(Nothing, Nothing, "rangeStyles", "rangeStyles", Me)
        Me.Fruits = Globals.Factory.CreateNamedRange(Nothing, Nothing, "Fruits", "Fruits", Me)
        Me.message = Globals.Factory.CreateNamedRange(Nothing, Nothing, "message", "message", Me)
        Me.fruitList = Globals.Factory.CreateListObject(Nothing, Nothing, "Sheet1:fruitList", "fruitList", Me)
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeComponents()
        CType(Me.defaultSavePath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data2001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data2002, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rangeStyles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fruits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.message, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fruitList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Sheet1
        '
        CType(Me.defaultSavePath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data2001, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data2002, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rangeStyles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fruits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.message, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fruitList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Function NeedsFill(ByVal MemberName As String) As Boolean
        Return Me.DataHost.NeedsFill(Me, MemberName)
    End Function

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub OnShutdown()
        Me.fruitList.Dispose()
        Me.message.Dispose()
        Me.Fruits.Dispose()
        Me.rangeStyles.Dispose()
        Me.dataAll.Dispose()
        Me.data2002.Dispose()
        Me.data2001.Dispose()
        Me.dateComment.Dispose()
        Me.defaultSavePath.Dispose()
        MyBase.OnShutdown()
    End Sub
End Class

Partial Friend NotInheritable Class Globals

    Private Shared _Sheet1 As Sheet1

    Friend Shared Property Sheet1() As Sheet1
        Get
            Return _Sheet1
        End Get
        Set(value As Sheet1)
            If (_Sheet1 Is Nothing) Then
                _Sheet1 = value
            Else
                Throw New System.NotSupportedException()
            End If
        End Set
    End Property
End Class