﻿'------------------------------------------------------------------------------
'  <auto-generated>
'      This code was generated by coded UI test builder.
'      Version: 10.0.0.0
'
'      Changes to this file may cause incorrect behavior and will be lost if
'      the code is regenerated.
'  </auto-generated>
' ------------------------------------------------------------------------------

Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Input
Imports Microsoft.VisualStudio.TestTools.UITest.Extension
Imports Microsoft.VisualStudio.TestTools.UITesting
Imports Microsoft.VisualStudio.TestTools.UITesting.WinControls
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard
Imports Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse
Imports MouseButtons = System.Windows.Forms.MouseButtons

Namespace TestProject2
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Partial Public Class UIMap
        
        '''<summary>
        '''RecordedMethod1
        '''</summary>
        Public Sub RecordedMethod1()
            Dim uINewupdatesareavailabButton As WinButton = Me.UINotificationAreaWindow.UINotificationAreaToolBar.UINewupdatesareavailabButton
            Dim uICloseButton As WinButton = Me.UIWindowsUpdateWindow.UIWindowsUpdateTitleBar.UICloseButton

            'Double-Click 'New updates are available' button
            Mouse.DoubleClick(uINewupdatesareavailabButton, New Point(6, 7))

            'Click 'Close' button
            Mouse.Click(uICloseButton, New Point(24, 3))
        End Sub
        
        '''<summary>
        '''RecordedMethod2
        '''</summary>
        Public Sub RecordedMethod2()
            Dim uINewupdatesareavailabButton As WinButton = Me.UINotificationAreaWindow.UINotificationAreaToolBar.UINewupdatesareavailabButton
            Dim uITeamFoundationBuildNButton As WinButton = Me.UINotificationAreaWindow.UINotificationAreaToolBar.UITeamFoundationBuildNButton
            Dim uIµTorrent31200downloaButton As WinButton = Me.UINotificationAreaWindow.UINotificationAreaToolBar.UIµTorrent31200downloaButton
            Dim uIComputerstatusProtecButton As WinButton = Me.UINotificationAreaWindow.UINotificationAreaToolBar.UIComputerstatusProtecButton
            Dim uIDellTouchpadButton As WinButton = Me.UINotificationAreaWindow.UINotificationAreaToolBar.UIDellTouchpadButton
            Dim uIMagicISOVirtualCDDVDButton As WinButton = Me.UINotificationAreaWindow.UINotificationAreaToolBar.UIMagicISOVirtualCDDVDButton
            Dim uIItem1hr04min21remainButton As WinButton = Me.UISystemControlAreaWindow.UISystemControlAreaToolBar.UIItem1hr04min21remainButton
            Dim uICurrentlyconnectedtoButton As WinButton = Me.UISystemControlAreaWindow.UISystemControlAreaToolBar.UICurrentlyconnectedtoButton
            Dim uIVolumeButton As WinButton = Me.UISystemControlAreaWindow.UISystemControlAreaToolBar.UIVolumeButton

            'Double-Click 'New updates are available' button
            Mouse.DoubleClick(uINewupdatesareavailabButton, New Point(5, 8))

            'Double-Click 'Team Foundation Build Notification' button
            Mouse.DoubleClick(uITeamFoundationBuildNButton, New Point(10, 16))

            'Double-Click 'µTorrent 3.1.20(0) downloading, 0(0) seeding0.0 kB...' button
            Mouse.DoubleClick(uIµTorrent31200downloaButton, New Point(6, 17))

            'Double-Click 'Computer status - Protected' button
            Mouse.DoubleClick(uIComputerstatusProtecButton, New Point(7, 14))

            'Double-Click 'Dell Touchpad' button
            Mouse.DoubleClick(uIDellTouchpadButton, New Point(4, 13))

            'Double-Click 'MagicISO Virtual CD/DVD Manager' button
            Mouse.DoubleClick(uIMagicISOVirtualCDDVDButton, New Point(7, 11))

            'Double-Click 'MagicISO Virtual CD/DVD Manager' button
            Mouse.DoubleClick(uIMagicISOVirtualCDDVDButton, New Point(7, 11))

            'Double-Click '1 hr 04 min (21%) remaining' button
            Mouse.DoubleClick(uIItem1hr04min21remainButton, New Point(14, 7))

            'Double-Click 'Currently connected to: chery Access:  Local only' button
            Mouse.DoubleClick(uICurrentlyconnectedtoButton, New Point(9, 8))

            'Click 'Volume' button
            Mouse.Click(uIVolumeButton, New Point(3, 10))
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UINotificationAreaWindow() As UINotificationAreaWindow
            Get
                If (Me.mUINotificationAreaWindow Is Nothing) Then
                    Me.mUINotificationAreaWindow = New UINotificationAreaWindow()
                End If
                Return Me.mUINotificationAreaWindow
            End Get
        End Property
        
        Public ReadOnly Property UIWindowsUpdateWindow() As UIWindowsUpdateWindow
            Get
                If (Me.mUIWindowsUpdateWindow Is Nothing) Then
                    Me.mUIWindowsUpdateWindow = New UIWindowsUpdateWindow()
                End If
                Return Me.mUIWindowsUpdateWindow
            End Get
        End Property
        
        Public ReadOnly Property UISystemControlAreaWindow() As UISystemControlAreaWindow
            Get
                If (Me.mUISystemControlAreaWindow Is Nothing) Then
                    Me.mUISystemControlAreaWindow = New UISystemControlAreaWindow()
                End If
                Return Me.mUISystemControlAreaWindow
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUINotificationAreaWindow As UINotificationAreaWindow
        
        Private mUIWindowsUpdateWindow As UIWindowsUpdateWindow
        
        Private mUISystemControlAreaWindow As UISystemControlAreaWindow
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UINotificationAreaWindow
        Inherits WinWindow
        
        Public Sub New()
            MyBase.New
            Me.SearchProperties(WinWindow.PropertyNames.Name) = "Notification Area"
            Me.SearchProperties(WinWindow.PropertyNames.ClassName) = "ToolbarWindow32"
            Me.WindowTitles.Add("Notification Area")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UINotificationAreaToolBar() As UINotificationAreaToolBar
            Get
                If (Me.mUINotificationAreaToolBar Is Nothing) Then
                    Me.mUINotificationAreaToolBar = New UINotificationAreaToolBar(Me)
                End If
                Return Me.mUINotificationAreaToolBar
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUINotificationAreaToolBar As UINotificationAreaToolBar
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UINotificationAreaToolBar
        Inherits WinToolBar
        
        Public Sub New(ByVal searchLimitContainer As UITestControl)
            MyBase.New(searchLimitContainer)
            Me.SearchProperties(WinToolBar.PropertyNames.Name) = "Notification Area"
            Me.WindowTitles.Add("Notification Area")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UINewupdatesareavailabButton() As WinButton
            Get
                If (Me.mUINewupdatesareavailabButton Is Nothing) Then
                    Me.mUINewupdatesareavailabButton = New WinButton(Me)
                    Me.mUINewupdatesareavailabButton.SearchProperties(WinButton.PropertyNames.Name) = "New updates are available"
                    Me.mUINewupdatesareavailabButton.WindowTitles.Add("Notification Area")
                End If
                Return Me.mUINewupdatesareavailabButton
            End Get
        End Property
        
        Public ReadOnly Property UITeamFoundationBuildNButton() As WinButton
            Get
                If (Me.mUITeamFoundationBuildNButton Is Nothing) Then
                    Me.mUITeamFoundationBuildNButton = New WinButton(Me)
                    Me.mUITeamFoundationBuildNButton.SearchProperties(WinButton.PropertyNames.Name) = "Team Foundation Build Notification"
                    Me.mUITeamFoundationBuildNButton.WindowTitles.Add("Notification Area")
                End If
                Return Me.mUITeamFoundationBuildNButton
            End Get
        End Property
        
        Public ReadOnly Property UIµTorrent31200downloaButton() As WinButton
            Get
                If (Me.mUIµTorrent31200downloaButton Is Nothing) Then
                    Me.mUIµTorrent31200downloaButton = New WinButton(Me)
                    Me.mUIµTorrent31200downloaButton.SearchProperties(WinButton.PropertyNames.Name) = "µTorrent 3.1.20(0) downloading, 0(0) seeding0.0 kB/s down, 0.0 kB/s up"
                    Me.mUIµTorrent31200downloaButton.WindowTitles.Add("Notification Area")
                End If
                Return Me.mUIµTorrent31200downloaButton
            End Get
        End Property
        
        Public ReadOnly Property UIComputerstatusProtecButton() As WinButton
            Get
                If (Me.mUIComputerstatusProtecButton Is Nothing) Then
                    Me.mUIComputerstatusProtecButton = New WinButton(Me)
                    Me.mUIComputerstatusProtecButton.SearchProperties(WinButton.PropertyNames.Name) = "Computer status - Protected"
                    Me.mUIComputerstatusProtecButton.WindowTitles.Add("Notification Area")
                End If
                Return Me.mUIComputerstatusProtecButton
            End Get
        End Property
        
        Public ReadOnly Property UIDellTouchpadButton() As WinButton
            Get
                If (Me.mUIDellTouchpadButton Is Nothing) Then
                    Me.mUIDellTouchpadButton = New WinButton(Me)
                    Me.mUIDellTouchpadButton.SearchProperties(WinButton.PropertyNames.Name) = "Dell Touchpad"
                    Me.mUIDellTouchpadButton.WindowTitles.Add("Notification Area")
                End If
                Return Me.mUIDellTouchpadButton
            End Get
        End Property
        
        Public ReadOnly Property UIMagicISOVirtualCDDVDButton() As WinButton
            Get
                If (Me.mUIMagicISOVirtualCDDVDButton Is Nothing) Then
                    Me.mUIMagicISOVirtualCDDVDButton = New WinButton(Me)
                    Me.mUIMagicISOVirtualCDDVDButton.SearchProperties(WinButton.PropertyNames.Name) = "MagicISO Virtual CD/DVD Manager"
                    Me.mUIMagicISOVirtualCDDVDButton.WindowTitles.Add("Notification Area")
                End If
                Return Me.mUIMagicISOVirtualCDDVDButton
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUINewupdatesareavailabButton As WinButton
        
        Private mUITeamFoundationBuildNButton As WinButton
        
        Private mUIµTorrent31200downloaButton As WinButton
        
        Private mUIComputerstatusProtecButton As WinButton
        
        Private mUIDellTouchpadButton As WinButton
        
        Private mUIMagicISOVirtualCDDVDButton As WinButton
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UIWindowsUpdateWindow
        Inherits WinWindow
        
        Public Sub New()
            MyBase.New
            Me.SearchProperties(WinWindow.PropertyNames.Name) = "Windows Update"
            Me.SearchProperties(WinWindow.PropertyNames.ClassName) = "CabinetWClass"
            Me.WindowTitles.Add("Windows Update")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UIWindowsUpdateTitleBar() As UIWindowsUpdateTitleBar
            Get
                If (Me.mUIWindowsUpdateTitleBar Is Nothing) Then
                    Me.mUIWindowsUpdateTitleBar = New UIWindowsUpdateTitleBar(Me)
                End If
                Return Me.mUIWindowsUpdateTitleBar
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUIWindowsUpdateTitleBar As UIWindowsUpdateTitleBar
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UIWindowsUpdateTitleBar
        Inherits WinTitleBar
        
        Public Sub New(ByVal searchLimitContainer As UITestControl)
            MyBase.New(searchLimitContainer)
            Me.WindowTitles.Add("Windows Update")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UICloseButton() As WinButton
            Get
                If (Me.mUICloseButton Is Nothing) Then
                    Me.mUICloseButton = New WinButton(Me)
                    Me.mUICloseButton.SearchProperties(WinButton.PropertyNames.Name) = "Close"
                    Me.mUICloseButton.WindowTitles.Add("Windows Update")
                End If
                Return Me.mUICloseButton
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUICloseButton As WinButton
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UISystemControlAreaWindow
        Inherits WinWindow
        
        Public Sub New()
            MyBase.New
            Me.SearchProperties(WinWindow.PropertyNames.Name) = "System Control Area"
            Me.SearchProperties(WinWindow.PropertyNames.ClassName) = "ToolbarWindow32"
            Me.WindowTitles.Add("System Control Area")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UISystemControlAreaToolBar() As UISystemControlAreaToolBar
            Get
                If (Me.mUISystemControlAreaToolBar Is Nothing) Then
                    Me.mUISystemControlAreaToolBar = New UISystemControlAreaToolBar(Me)
                End If
                Return Me.mUISystemControlAreaToolBar
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUISystemControlAreaToolBar As UISystemControlAreaToolBar
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UISystemControlAreaToolBar
        Inherits WinToolBar
        
        Public Sub New(ByVal searchLimitContainer As UITestControl)
            MyBase.New(searchLimitContainer)
            Me.SearchProperties(WinToolBar.PropertyNames.Name) = "System Control Area"
            Me.WindowTitles.Add("System Control Area")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UIItem1hr04min21remainButton() As WinButton
            Get
                If (Me.mUIItem1hr04min21remainButton Is Nothing) Then
                    Me.mUIItem1hr04min21remainButton = New WinButton(Me)
                    Me.mUIItem1hr04min21remainButton.SearchProperties(WinButton.PropertyNames.Name) = "1 hr 04 min (21%) remaining"
                    Me.mUIItem1hr04min21remainButton.WindowTitles.Add("System Control Area")
                End If
                Return Me.mUIItem1hr04min21remainButton
            End Get
        End Property
        
        Public ReadOnly Property UICurrentlyconnectedtoButton() As WinButton
            Get
                If (Me.mUICurrentlyconnectedtoButton Is Nothing) Then
                    Me.mUICurrentlyconnectedtoButton = New WinButton(Me)
                    Me.mUICurrentlyconnectedtoButton.SearchProperties(WinButton.PropertyNames.Name) = "Currently connected to: chery Access:  Local only"
                    Me.mUICurrentlyconnectedtoButton.WindowTitles.Add("System Control Area")
                End If
                Return Me.mUICurrentlyconnectedtoButton
            End Get
        End Property
        
        Public ReadOnly Property UIVolumeButton() As WinButton
            Get
                If (Me.mUIVolumeButton Is Nothing) Then
                    Me.mUIVolumeButton = New WinButton(Me)
                    Me.mUIVolumeButton.SearchProperties(WinButton.PropertyNames.Name) = "Volume"
                    Me.mUIVolumeButton.WindowTitles.Add("System Control Area")
                End If
                Return Me.mUIVolumeButton
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUIItem1hr04min21remainButton As WinButton
        
        Private mUICurrentlyconnectedtoButton As WinButton
        
        Private mUIVolumeButton As WinButton
        #End Region
    End Class
End Namespace
