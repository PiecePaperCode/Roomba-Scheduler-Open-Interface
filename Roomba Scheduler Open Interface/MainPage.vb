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
        COM_Port_Combobox.Items.Add("COM7")
        COM_Port_Combobox.Items.Add("COM8")
        'Define Stuff inside the Combobox to avoid Try Statement
        COM_Port_Combobox.SelectedItem = "COM1"
        Series_Combobox.SelectedItem = "500 Series"
    End Sub

    '<Define FirstDayOfWeek> Define Sunday as First Day of the Week
    Public Enum FirstDayOfWeek
        Sunday
    End Enum

    '<System Time> Show and Update System Time to the Programm
    Private Sub SystemZeitTimer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SystemTime_Label.Text = DateTime.Now
    End Sub

    '<Function> InitialiseCOMPORT
    Function Initialise_COMPORT()
        If Series_Combobox.SelectedItem = "500 Series" Then Baudrate = 115200
        If Series_Combobox.SelectedItem = "600 Series" Then Baudrate = 115200 'Here it would be possible to add new models
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = COM_Port_Combobox.SelectedItem         'Assign the port name/number to the MyCOMPort object
        MyCOMPort.BaudRate = Baudrate                               'Assign the Baudrate to the MyCOMPort object
        MyCOMPort.Parity = Parity.None                              'Parity bits = none  
        MyCOMPort.DataBits = 8                                      'No of Data bits = 8
        MyCOMPort.StopBits = StopBits.One                           'No of Stop bits = 1
    End Function

    '<Function> 'DayoftheWeek in Hex for Roomba
    Function DayofWeek_to_Roomba()
        Dim DaySetHex As String = &H0
        If DateTime.Now.DayOfWeek.ToString = "Sunday" Then DaySetHex = &H0
        If DateTime.Now.DayOfWeek.ToString = "Monday" Then DaySetHex = &H1
        If DateTime.Now.DayOfWeek.ToString = "Tuesday" Then DaySetHex = &H2
        If DateTime.Now.DayOfWeek.ToString = "Wednesday" Then DaySetHex = &H3
        If DateTime.Now.DayOfWeek.ToString = "Thursday" Then DaySetHex = &H4
        If DateTime.Now.DayOfWeek.ToString = "Friday" Then DaySetHex = &H5
        If DateTime.Now.DayOfWeek.ToString = "Saturday" Then DaySetHex = &H6
        Return DaySetHex
    End Function

    '<Function> Add the Selected Active Days
    Function Selected_Active_Days_Hex()
        'Roomba Documentation Speeks of Days as Values who needs to be added to determine on Wich Days the Roomba Robot would clean
        ' Value | For each Day Who need to be added 0 if it is not selected
        '1  | Sunday 
        '2  | Monday 
        '4  | Tuesday 
        '8  | Wednesday 
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
        Return DaysHex
    End Function

    '<Funktion> 'Actual Time to Roomba in Format [Wake Up, Change-Time, Day, Hour, Minute] as HEX Values
    Function Write_Actual_Time_to_Roomba()
        Dim DaySetHex As String = DayofWeek_to_Roomba()                                 'Function to call DayofWeek in Rommba Hex
        Dim HexHourSet As String = "&H" & Hex(TimeOfDay.Hour)                           'TimeofDay.Hour in Hex Format
        Dim HexMinuteSet As String = "&H" & Hex(TimeOfDay.Minute)                       'TimeofDay.Minute in Hex Format
        Dim SetDateHEX As Byte() = {&H80, &HA8, DaySetHex, HexHourSet, HexMinuteSet}    'Time to Roomba in Format [Wake Up, Change-Time, Day, Hour, Minute] as HEX Values
        MyCOMPort.Open()                                                                'Open the port
        MyCOMPort.Write(SetDateHEX, 0, 5)                                               'Write Actual Time to Serial"
        MyCOMPort.Close()                                                               'Close port
        FlashOutput_Label.Text = "HEX: " & vbCrLf &
            String.Join(" ", "80", "A8", DaySetHex, HexHourSet, HexMinuteSet).Replace("H", "")            'Display Written Bytes As Hex Values to the User
    End Function

    '<Test Connection>
    Public Sub TestConnection_Button_Click(sender As Object, e As EventArgs) Handles TestConnection_Button.Click
        Call Initialise_COMPORT()
        Dim HexBeep As Byte() = {&H80, &H83, &H8C, &H1, &H1, &H55, &H20, &H8D, &H1}         ' Hex Values to Send to Start a BeeP TesT
        Try
            MyCOMPort.Open()                                        'Open the port
            MyCOMPort.Write(HexBeep, 0, 9)                          'Write "Beep 9 Hex Signals
            Threading.Thread.Sleep(100)                             'Sleep for Beep to be Heard
            MyCOMPort.Write(HexBeep, 0, 9)                          'Write "Beep 9 Hex Signals 2nd Time to Hear the Actual Bee
            MyCOMPort.Close()                                       'Close port
            Threading.Thread.Sleep(1000)                            'Sleep for Beep to be Heard
            Dim HexReset As Byte() = {&H80}                         'Reset Roomba to Passive Mode 128 After 1 Sec for futher use
            MyCOMPort.Open()                                        'Open the port
            MyCOMPort.Write(HexReset, 0, 1)                         'Write "Reset 128 in Hex"
            MyCOMPort.Close()                                       'Close port
            FlashOutput_Label.Text = "HEX: " & vbCrLf & String.Join(" ", "80", "83", "8C", "1", "1", "55", "20", "8D", "1")
        Catch ex As Exception
            MessageBox.Show("unable to connect to the selected COM Port", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '<Flash Button> This is the Main Part where the selected Schedule is applyed to the Roomba
    Public Sub Flash_Button_Click(sender As Object, e As EventArgs) Handles Flash_Button.Click
        Call Initialise_COMPORT()                                   'Initialise COMPORT
        Call Write_Actual_Time_to_Roomba()                          'Write Time to Roomba in Format [Wake Up, Change-Time, Day, Hour, Minute] as HEX Values
        Dim DaysHEX As String = Selected_Active_Days_Hex()          'Add the Selected Active Days to know on wich day the Roomba would clean

        'Nummeric Updown As New List to Collect all the Userinputs from the User
        Dim Selected_Hour_Minutes As New List(Of NumericUpDown)() From {
            Sunday_h_NumUpDown, Sunday_min_NumUpDown,
            Monday_h_NumUpDown, Monday_min_NumUpDown,
            Tuesday_h_NumUpDown, Tuesday_min_NumUpDown,
            Wednesday_h_NumUpDown, Wednesday_min_NumUpDown,
            Thursday_h_NumUpDown, Thursday_min_NumUpDown,
            Friday_h_NumUpDown, Friday_min_NumUpDown,
            Saturday_h_NumUpDown, Saturday_min_NumUpDown}

        'Convert all Days User set Time hours and Minutes to Theyre Hex Values And use an Array to make Things Simpler
        Dim Selected_Hour_Minutes_HEX(13) As String
        Dim i As Integer = 0
        For Each St As NumericUpDown In Selected_Hour_Minutes
            Selected_Hour_Minutes_HEX(i) = "&H" & Hex(St.Value)
            i = i + 1
        Next

        '[167] [Days] [Sun Hour] [Sun Minute] [Mon Hour] [Mon Minute] [Tue Hour] [Tue
        'Minute()] [Wed Hour] [Wed Minute] [Thu Hour] [Thu Minute] [Fri Hour] [Fri Minute] [Sat Hour] [Sat
        'Minute()] 
        'Collect the and arranging all the Values to be send as Hex Values to the Roomba
        Dim SetSchedule As Byte() = {&H80, &HA7, DaysHEX, Selected_Hour_Minutes_HEX(0)}
        Dim SetSchedule2 As Byte() = {Selected_Hour_Minutes_HEX(1), Selected_Hour_Minutes_HEX(2), Selected_Hour_Minutes_HEX(3), Selected_Hour_Minutes_HEX(4)}
        Dim SetSchedule3 As Byte() = {Selected_Hour_Minutes_HEX(5), Selected_Hour_Minutes_HEX(6), Selected_Hour_Minutes_HEX(7), Selected_Hour_Minutes_HEX(8)}
        Dim SetSchedule4 As Byte() = {Selected_Hour_Minutes_HEX(9), Selected_Hour_Minutes_HEX(10), Selected_Hour_Minutes_HEX(11), Selected_Hour_Minutes_HEX(12), Selected_Hour_Minutes_HEX(13)}

        Try
            'Actual Write to Serial Port
            MyCOMPort.Open()                             ' Open the port
            MyCOMPort.Write(SetSchedule, 0, 4)           ' Write the Schedule to Serial"
            MyCOMPort.Write(SetSchedule2, 0, 4)          ' Write the Schedule to Serial"
            MyCOMPort.Write(SetSchedule3, 0, 4)          ' Write the Schedule to Serial"
            MyCOMPort.Write(SetSchedule4, 0, 5)          ' Write the Schedule to Serial"
            MyCOMPort.Close()
        Catch ex As Exception
            MessageBox.Show("unable to connect to the selected COM Port", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'User Feedback Beep for Successfully Inserting a Schedule
        Me.TestConnection_Button_Click(sender, New System.EventArgs())

        '<Format THe OutPut> To Display to the User
        Dim Text_Output_Text As String = String.Join(" ", "80", "A7", DaysHEX, Selected_Hour_Minutes_HEX(0),
                                                        Selected_Hour_Minutes_HEX(1), Selected_Hour_Minutes_HEX(2), Selected_Hour_Minutes_HEX(3), Selected_Hour_Minutes_HEX(4),
                                                        Selected_Hour_Minutes_HEX(5), Selected_Hour_Minutes_HEX(6), Selected_Hour_Minutes_HEX(7), Selected_Hour_Minutes_HEX(8),
                                                        Selected_Hour_Minutes_HEX(9), Selected_Hour_Minutes_HEX(10), Selected_Hour_Minutes_HEX(11), Selected_Hour_Minutes_HEX(12),
                                                        Selected_Hour_Minutes_HEX(13))
        FlashOutput_Label.Text += vbCrLf & Text_Output_Text.Replace("H", "")
    End Sub

    'Close the Application
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
End Class
