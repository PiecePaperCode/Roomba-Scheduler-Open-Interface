Imports System          'To Access Console.WriteLine()
Imports System.IO.Ports 'To Access the SerialPort Object

Public Class MainPage
    '<Global Header>
    Public MyCOMPort As SerialPort
    Public Baudrate As String

    '<Form Load> Initialise the Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add Items to Series_Combobox
        Series_Combobox.Items.Add("500 Series")
        Series_Combobox.Items.Add("600 Series")
        'Add Items to COM_Port_Combobox
        COM_Port_Combobox.Items.Add("COM1")
        COM_Port_Combobox.Items.Add("COM2")
        COM_Port_Combobox.Items.Add("COM3")
        COM_Port_Combobox.Items.Add("COM4")
        COM_Port_Combobox.Items.Add("COM5")
        COM_Port_Combobox.Items.Add("COM6")
        'Define Stuff inside the Combobox to avoid Try Stetement
        COM_Port_Combobox.SelectedItem = "COM1"
        Series_Combobox.SelectedItem = "500 Series"
    End Sub

    '<Define FirstDayOfWeek>
    Public Enum FirstDayOfWeek
        Sunday
    End Enum

    '<COMPORT Initialise>
    Function InitialiseCOMPORT()
        If Series_Combobox.SelectedItem = "500 Series" Then Baudrate = 115200
        If Series_Combobox.SelectedItem = "600 Series" Then Baudrate = 115200
        '<Define Serial Port>
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = COM_Port_Combobox.SelectedItem         'Assign the port name to the MyCOMPort object
        MyCOMPort.BaudRate = Baudrate                               'Assign the Baudrate to the MyCOMPort object
        MyCOMPort.Parity = Parity.None                              'Parity bits = none  
        MyCOMPort.DataBits = 8                                      'No of Data bits = 8
        MyCOMPort.StopBits = StopBits.One                           'No of Stop bits = 1
    End Function
    '<Test Connection>
    Public Sub TestConnection_Button_Click(sender As Object, e As EventArgs) Handles TestConnection_Button.Click
        Call InitialiseCOMPORT()
        ' Hex Values to Send to Start a BeeP Test Song
        Dim HexBeep As Byte() = {&H80, &H83, &H8C, &H1, &H1, &H55, &H20, &H8D, &H1}

        Try
            MyCOMPort.Open()                            ' Open the port
            MyCOMPort.Write(HexBeep, 0, 9)              ' Write "Beep 9 Hex Signals"
            Threading.Thread.Sleep(100)
            MyCOMPort.Write(HexBeep, 0, 9)
            MyCOMPort.Close()                           ' Close port
            'Reset Roomba to Passive Mode 128 After 1 Sec for futher use
            Threading.Thread.Sleep(1000)
            Dim HexReset As Byte() = {&H80}
            MyCOMPort.Open()                            ' Open the port
            MyCOMPort.Write(HexReset, 0, 1)             ' Write "Reset 128 in Hex"
            MyCOMPort.Close()                           ' Close port
        Catch ex As Exception
            MessageBox.Show("unable to connect to the selected COM Port", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '<System Time> Show and Update System Time to the Programm
    Private Sub SystemZeitTimer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SystemTime_Label.Text = DateTime.Now
    End Sub

    '<Flash Button> This is the Main Part where the selected Schedule is applyed to the Roomba
    Public Sub Flash_Button_Click(sender As Object, e As EventArgs) Handles Flash_Button.Click
        Call InitialiseCOMPORT()
        '<Set Roombas System Time> Update Roombas internal Time to the System Time
        Dim DaySetHex As String = &H0
        If DateTime.Now.DayOfWeek.ToString = "Sunday" Then DaySetHex = &H0
        If DateTime.Now.DayOfWeek.ToString = "Monday" Then DaySetHex = &H1
        If DateTime.Now.DayOfWeek.ToString = "Tuesday" Then DaySetHex = &H2
        If DateTime.Now.DayOfWeek.ToString = "Wednesday" Then DaySetHex = &H3
        If DateTime.Now.DayOfWeek.ToString = "Thursday" Then DaySetHex = &H4
        If DateTime.Now.DayOfWeek.ToString = "Friday" Then DaySetHex = &H5
        If DateTime.Now.DayOfWeek.ToString = "Saturday" Then DaySetHex = &H6
        Dim HourSet As Integer = TimeOfDay.Hour
        Dim MinuteSet As Integer = TimeOfDay.Minute
        Dim HexHourSet As String = "&H" & Hex(HourSet)
        Dim HexMinuteSet As String = "&H" & Hex(MinuteSet)
        Dim SetDate As Byte() = {&H80, &HA8, DaySetHex, HexHourSet, HexMinuteSet}
        MyCOMPort.Open()                          ' Open the port
        MyCOMPort.Write(SetDate, 0, 5)            ' Write Actual Time to Serial"
        MyCOMPort.Close()                         ' Close port

        'Roomba Documentation Speeks of Days as Values who needs to be added to determine on Wich Days the Roomba Robot would work
        ' Value | For each Day 
        '1 | Sunday 
        '2 | Monday 
        '4 | Tuesday 
        '8 | Wednesday 
        '16 | Thursday 
        '32 | Friday 
        '64 | Saturday 
        Dim Sonntag, Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Days As Integer
        If Sunday_Checkbox.Checked Then Sonntag = 1 Else Sonntag = 0
        If Monday_Checkbox.Checked Then Montag = 2 Else Montag = 0
        If Tuesday_Checkbox.Checked Then Dienstag = 4 Else Dienstag = 0
        If Wednesday_Checkbox.Checked Then Mittwoch = 8 Else Mittwoch = 0
        If Thursday_Checkbox.Checked Then Donnerstag = 16 Else Donnerstag = 0
        If Friday_Checkbox.Checked Then Freitag = 32 Else Freitag = 0
        If Saturday_Checkbox.Checked Then Samstag = 64 Else Samstag = 0

        'Add The Day Values to tell the Roomba on How Many Days the Roomba would be Active
        Days = Sonntag + Montag + Dienstag + Mittwoch + Donnerstag + Freitag + Samstag
        Dim DaysHex As String = "&H" & Hex(Days)

        '[167] [Days] [Sun Hour] [Sun Minute] [Mon Hour] [Mon Minute] [Tue Hour] [Tue
        'Minute()] [Wed Hour] [Wed Minute] [Thu Hour] [Thu Minute] [Fri Hour] [Fri Minute] [Sat Hour] [Sat
        'Minute()] 

        'Convert all Days User set Time hours and Minutes to Theyre Hex Values
        'Sunday
        Dim SonntagHHex, SonntagMinHex As String
        SonntagHHex = "&H" & Hex(Sunday_h_NumUpDown.Value)
        SonntagMinHex = "&H" & Hex(Sunday_min_NumUpDown.Value)
        'Monday
        Dim MontagHHex, MontagMinHex As String
        MontagHHex = "&H" & Hex(Monday_h_NumUpDown.Value)
        MontagMinHex = "&H" & Hex(Monday_min_NumUpDown.Value)
        'Tuesday
        Dim DienstagHHex, DienstagMinHex As String
        DienstagHHex = "&H" & Hex(Tuesday_h_NumUpDown.Value)
        DienstagMinHex = "&H" & Hex(Tuesday_min_NumUpDown.Value)
        'Wednesday
        Dim MittwochHHex, MittwochMinHex As String
        MittwochHHex = "&H" & Hex(Wednesday_h_NumUpDown.Value)
        MittwochMinHex = "&H" & Hex(Wednesday_min_NumUpDown.Value)
        'Thursday
        Dim DonnerstagHHex, DonnerstagMinHex As String
        DonnerstagHHex = "&H" & Hex(Thursday_h_NumUpDown.Value)
        DonnerstagMinHex = "&H" & Hex(Thursday_min_NumUpDown.Value)
        'Friday
        Dim FreitagHHex, FreitagMinHex As String
        FreitagHHex = "&H" & Hex(Friday_h_NumUpDown.Value)
        FreitagMinHex = "&H" & Hex(Friday_min_NumUpDown.Value)
        'Saturday
        Dim SamstagHHex, SamstagMinHex As String
        SamstagHHex = "&H" & Hex(Saturday_h_NumUpDown.Value)
        SamstagMinHex = "&H" & Hex(Saturday_min_NumUpDown.Value)

        'Collect the and arranging all the Values to be send as Hex Values to the Roomba
        Dim SetSchedule As Byte() = {&H80, &HA7, DaysHex, SonntagHHex}
        Dim SetSchedule2 As Byte() = {SonntagMinHex, MontagHHex, MontagMinHex, DienstagHHex}
        Dim SetSchedule3 As Byte() = {DienstagMinHex, MittwochHHex, MittwochMinHex, DonnerstagHHex}
        Dim SetSchedule4 As Byte() = {DonnerstagMinHex, FreitagHHex, FreitagMinHex, SamstagHHex, SamstagMinHex}

        'Actual Write to Serial Port
        MyCOMPort.Open()                             ' Open the port
        MyCOMPort.Write(SetSchedule, 0, 4)           ' Write the Schedule to Serial"
        MyCOMPort.Write(SetSchedule2, 0, 4)          ' Write the Schedule to Serial"
        MyCOMPort.Write(SetSchedule3, 0, 4)          ' Write the Schedule to Serial"
        MyCOMPort.Write(SetSchedule4, 0, 5)          ' Write the Schedule to Serial"
        MyCOMPort.Close()

        'Converting to HEX DRY Note remove it and write the definitive 
        Dim HexHourSetLabel As String = Hex(HourSet)
        Dim HexMinuteSetLabel As String = Hex(MinuteSet)

        '<Format THe OutPut> Note use String.Join in the Future
        FlashOutput_Label.Text = "HEX" & vbCrLf & "80 " & "A8 " & DaySetHex &
            " " & HexHourSetLabel & " " & HexMinuteSetLabel & " 80 A8 A7 " &
            Hex(Days) & " " & Hex(Sunday_h_NumUpDown.Value) & " " & Hex(Sunday_min_NumUpDown.Value) & " " & Hex(Monday_h_NumUpDown.Value) &
            " " & Hex(Monday_min_NumUpDown.Value) & " " & Hex(Tuesday_h_NumUpDown.Value) & " " & Hex(Tuesday_min_NumUpDown.Value) &
            " " & Hex(Wednesday_h_NumUpDown.Value) & " " & Hex(Wednesday_min_NumUpDown.Value) & " " & Hex(Thursday_h_NumUpDown.Value) &
            " " & Hex(Thursday_min_NumUpDown.Value) & " " & Hex(Friday_h_NumUpDown.Value) &
            " " & Hex(Friday_min_NumUpDown.Value) & " " & Hex(Saturday_h_NumUpDown.Value) & " " & Hex(Saturday_min_NumUpDown.Value)
    End Sub

    'Close the Application
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
End Class
