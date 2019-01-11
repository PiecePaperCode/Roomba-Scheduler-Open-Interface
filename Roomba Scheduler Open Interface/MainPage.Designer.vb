<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Series_Combobox = New System.Windows.Forms.ComboBox()
        Me.COM_Port_Combobox = New System.Windows.Forms.ComboBox()
        Me.TestConnection_Button = New System.Windows.Forms.Button()
        Me.SystemTime_Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Monday_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tuesday_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Wednesday_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Thursday_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Friday_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Saturday_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Sunday_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Monday_h_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Monday_min_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Tuesday_min_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Tuesday_h_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Wednesday_min_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Wednesday_h_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Thursday_min_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Thursday_h_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Friday_min_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Friday_h_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Saturday_min_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Saturday_h_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Sunday_min_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Sunday_h_NumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FlashOutput_Label = New System.Windows.Forms.Label()
        Me.Flash_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Exit_Button = New System.Windows.Forms.Button()
        CType(Me.Monday_h_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Monday_min_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tuesday_min_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tuesday_h_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wednesday_min_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wednesday_h_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thursday_min_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thursday_h_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Friday_min_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Friday_h_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Saturday_min_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Saturday_h_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sunday_min_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sunday_h_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(675, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roomba Scheduler Open Interface v0.2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Roomba Model"
        '
        'Series_Combobox
        '
        Me.Series_Combobox.FormattingEnabled = True
        Me.Series_Combobox.Location = New System.Drawing.Point(184, 72)
        Me.Series_Combobox.Name = "Series_Combobox"
        Me.Series_Combobox.Size = New System.Drawing.Size(113, 21)
        Me.Series_Combobox.TabIndex = 2
        '
        'COM_Port_Combobox
        '
        Me.COM_Port_Combobox.FormattingEnabled = True
        Me.COM_Port_Combobox.Location = New System.Drawing.Point(303, 72)
        Me.COM_Port_Combobox.Name = "COM_Port_Combobox"
        Me.COM_Port_Combobox.Size = New System.Drawing.Size(113, 21)
        Me.COM_Port_Combobox.TabIndex = 3
        '
        'TestConnection_Button
        '
        Me.TestConnection_Button.Location = New System.Drawing.Point(368, 267)
        Me.TestConnection_Button.Name = "TestConnection_Button"
        Me.TestConnection_Button.Size = New System.Drawing.Size(145, 39)
        Me.TestConnection_Button.TabIndex = 4
        Me.TestConnection_Button.Text = "Test Connection"
        Me.TestConnection_Button.UseVisualStyleBackColor = True
        '
        'SystemTime_Label
        '
        Me.SystemTime_Label.AutoSize = True
        Me.SystemTime_Label.Location = New System.Drawing.Point(91, 296)
        Me.SystemTime_Label.Name = "SystemTime_Label"
        Me.SystemTime_Label.Size = New System.Drawing.Size(67, 13)
        Me.SystemTime_Label.TabIndex = 5
        Me.SystemTime_Label.Text = "System Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "System Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Scheduling"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Monday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tuesday"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(192, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Wednesday"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(318, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Thursday"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(464, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 20)
        Me.Label9.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(424, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Friday"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(526, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Saturday"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(634, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Sunday"
        '
        'Monday_Checkbox
        '
        Me.Monday_Checkbox.AutoSize = True
        Me.Monday_Checkbox.Location = New System.Drawing.Point(21, 158)
        Me.Monday_Checkbox.Name = "Monday_Checkbox"
        Me.Monday_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Monday_Checkbox.TabIndex = 16
        Me.Monday_Checkbox.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(705, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Active"
        '
        'Tuesday_Checkbox
        '
        Me.Tuesday_Checkbox.AutoSize = True
        Me.Tuesday_Checkbox.Location = New System.Drawing.Point(105, 158)
        Me.Tuesday_Checkbox.Name = "Tuesday_Checkbox"
        Me.Tuesday_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Tuesday_Checkbox.TabIndex = 18
        Me.Tuesday_Checkbox.UseVisualStyleBackColor = True
        '
        'Wednesday_Checkbox
        '
        Me.Wednesday_Checkbox.AutoSize = True
        Me.Wednesday_Checkbox.Location = New System.Drawing.Point(196, 158)
        Me.Wednesday_Checkbox.Name = "Wednesday_Checkbox"
        Me.Wednesday_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Wednesday_Checkbox.TabIndex = 19
        Me.Wednesday_Checkbox.UseVisualStyleBackColor = True
        '
        'Thursday_Checkbox
        '
        Me.Thursday_Checkbox.AutoSize = True
        Me.Thursday_Checkbox.Location = New System.Drawing.Point(322, 158)
        Me.Thursday_Checkbox.Name = "Thursday_Checkbox"
        Me.Thursday_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Thursday_Checkbox.TabIndex = 20
        Me.Thursday_Checkbox.UseVisualStyleBackColor = True
        '
        'Friday_Checkbox
        '
        Me.Friday_Checkbox.AutoSize = True
        Me.Friday_Checkbox.Location = New System.Drawing.Point(428, 158)
        Me.Friday_Checkbox.Name = "Friday_Checkbox"
        Me.Friday_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Friday_Checkbox.TabIndex = 21
        Me.Friday_Checkbox.UseVisualStyleBackColor = True
        '
        'Saturday_Checkbox
        '
        Me.Saturday_Checkbox.AutoSize = True
        Me.Saturday_Checkbox.Location = New System.Drawing.Point(530, 158)
        Me.Saturday_Checkbox.Name = "Saturday_Checkbox"
        Me.Saturday_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Saturday_Checkbox.TabIndex = 22
        Me.Saturday_Checkbox.UseVisualStyleBackColor = True
        '
        'Sunday_Checkbox
        '
        Me.Sunday_Checkbox.AutoSize = True
        Me.Sunday_Checkbox.Location = New System.Drawing.Point(638, 158)
        Me.Sunday_Checkbox.Name = "Sunday_Checkbox"
        Me.Sunday_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Sunday_Checkbox.TabIndex = 23
        Me.Sunday_Checkbox.UseVisualStyleBackColor = True
        '
        'Monday_h_NumUpDown
        '
        Me.Monday_h_NumUpDown.Location = New System.Drawing.Point(21, 175)
        Me.Monday_h_NumUpDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.Monday_h_NumUpDown.Name = "Monday_h_NumUpDown"
        Me.Monday_h_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Monday_h_NumUpDown.TabIndex = 24
        '
        'Monday_min_NumUpDown
        '
        Me.Monday_min_NumUpDown.Location = New System.Drawing.Point(21, 197)
        Me.Monday_min_NumUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Monday_min_NumUpDown.Name = "Monday_min_NumUpDown"
        Me.Monday_min_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Monday_min_NumUpDown.TabIndex = 25
        '
        'Tuesday_min_NumUpDown
        '
        Me.Tuesday_min_NumUpDown.Location = New System.Drawing.Point(105, 197)
        Me.Tuesday_min_NumUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Tuesday_min_NumUpDown.Name = "Tuesday_min_NumUpDown"
        Me.Tuesday_min_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Tuesday_min_NumUpDown.TabIndex = 27
        '
        'Tuesday_h_NumUpDown
        '
        Me.Tuesday_h_NumUpDown.Location = New System.Drawing.Point(105, 175)
        Me.Tuesday_h_NumUpDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.Tuesday_h_NumUpDown.Name = "Tuesday_h_NumUpDown"
        Me.Tuesday_h_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Tuesday_h_NumUpDown.TabIndex = 26
        '
        'Wednesday_min_NumUpDown
        '
        Me.Wednesday_min_NumUpDown.Location = New System.Drawing.Point(196, 197)
        Me.Wednesday_min_NumUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Wednesday_min_NumUpDown.Name = "Wednesday_min_NumUpDown"
        Me.Wednesday_min_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Wednesday_min_NumUpDown.TabIndex = 29
        '
        'Wednesday_h_NumUpDown
        '
        Me.Wednesday_h_NumUpDown.Location = New System.Drawing.Point(196, 175)
        Me.Wednesday_h_NumUpDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.Wednesday_h_NumUpDown.Name = "Wednesday_h_NumUpDown"
        Me.Wednesday_h_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Wednesday_h_NumUpDown.TabIndex = 28
        '
        'Thursday_min_NumUpDown
        '
        Me.Thursday_min_NumUpDown.Location = New System.Drawing.Point(322, 197)
        Me.Thursday_min_NumUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Thursday_min_NumUpDown.Name = "Thursday_min_NumUpDown"
        Me.Thursday_min_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Thursday_min_NumUpDown.TabIndex = 31
        '
        'Thursday_h_NumUpDown
        '
        Me.Thursday_h_NumUpDown.Location = New System.Drawing.Point(322, 175)
        Me.Thursday_h_NumUpDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.Thursday_h_NumUpDown.Name = "Thursday_h_NumUpDown"
        Me.Thursday_h_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Thursday_h_NumUpDown.TabIndex = 30
        '
        'Friday_min_NumUpDown
        '
        Me.Friday_min_NumUpDown.Location = New System.Drawing.Point(428, 197)
        Me.Friday_min_NumUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Friday_min_NumUpDown.Name = "Friday_min_NumUpDown"
        Me.Friday_min_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Friday_min_NumUpDown.TabIndex = 33
        '
        'Friday_h_NumUpDown
        '
        Me.Friday_h_NumUpDown.Location = New System.Drawing.Point(428, 175)
        Me.Friday_h_NumUpDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.Friday_h_NumUpDown.Name = "Friday_h_NumUpDown"
        Me.Friday_h_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Friday_h_NumUpDown.TabIndex = 32
        '
        'Saturday_min_NumUpDown
        '
        Me.Saturday_min_NumUpDown.Location = New System.Drawing.Point(530, 197)
        Me.Saturday_min_NumUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Saturday_min_NumUpDown.Name = "Saturday_min_NumUpDown"
        Me.Saturday_min_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Saturday_min_NumUpDown.TabIndex = 35
        '
        'Saturday_h_NumUpDown
        '
        Me.Saturday_h_NumUpDown.Location = New System.Drawing.Point(530, 175)
        Me.Saturday_h_NumUpDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.Saturday_h_NumUpDown.Name = "Saturday_h_NumUpDown"
        Me.Saturday_h_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Saturday_h_NumUpDown.TabIndex = 34
        '
        'Sunday_min_NumUpDown
        '
        Me.Sunday_min_NumUpDown.Location = New System.Drawing.Point(638, 197)
        Me.Sunday_min_NumUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Sunday_min_NumUpDown.Name = "Sunday_min_NumUpDown"
        Me.Sunday_min_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Sunday_min_NumUpDown.TabIndex = 37
        '
        'Sunday_h_NumUpDown
        '
        Me.Sunday_h_NumUpDown.Location = New System.Drawing.Point(638, 175)
        Me.Sunday_h_NumUpDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.Sunday_h_NumUpDown.Name = "Sunday_h_NumUpDown"
        Me.Sunday_h_NumUpDown.Size = New System.Drawing.Size(42, 20)
        Me.Sunday_h_NumUpDown.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(705, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 16)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "h"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(705, 205)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 16)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "min"
        '
        'FlashOutput_Label
        '
        Me.FlashOutput_Label.AutoSize = True
        Me.FlashOutput_Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FlashOutput_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FlashOutput_Label.Location = New System.Drawing.Point(18, 229)
        Me.FlashOutput_Label.Name = "FlashOutput_Label"
        Me.FlashOutput_Label.Size = New System.Drawing.Size(32, 13)
        Me.FlashOutput_Label.TabIndex = 40
        Me.FlashOutput_Label.Text = "Flash"
        '
        'Flash_Button
        '
        Me.Flash_Button.Location = New System.Drawing.Point(519, 267)
        Me.Flash_Button.Name = "Flash_Button"
        Me.Flash_Button.Size = New System.Drawing.Size(145, 39)
        Me.Flash_Button.TabIndex = 41
        Me.Flash_Button.Text = "Flash Roomba"
        Me.Flash_Button.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(670, 267)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(86, 39)
        Me.Exit_Button.TabIndex = 42
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 318)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Flash_Button)
        Me.Controls.Add(Me.FlashOutput_Label)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Sunday_min_NumUpDown)
        Me.Controls.Add(Me.Sunday_h_NumUpDown)
        Me.Controls.Add(Me.Saturday_min_NumUpDown)
        Me.Controls.Add(Me.Saturday_h_NumUpDown)
        Me.Controls.Add(Me.Friday_min_NumUpDown)
        Me.Controls.Add(Me.Friday_h_NumUpDown)
        Me.Controls.Add(Me.Thursday_min_NumUpDown)
        Me.Controls.Add(Me.Thursday_h_NumUpDown)
        Me.Controls.Add(Me.Wednesday_min_NumUpDown)
        Me.Controls.Add(Me.Wednesday_h_NumUpDown)
        Me.Controls.Add(Me.Tuesday_min_NumUpDown)
        Me.Controls.Add(Me.Tuesday_h_NumUpDown)
        Me.Controls.Add(Me.Monday_min_NumUpDown)
        Me.Controls.Add(Me.Monday_h_NumUpDown)
        Me.Controls.Add(Me.Sunday_Checkbox)
        Me.Controls.Add(Me.Saturday_Checkbox)
        Me.Controls.Add(Me.Friday_Checkbox)
        Me.Controls.Add(Me.Thursday_Checkbox)
        Me.Controls.Add(Me.Wednesday_Checkbox)
        Me.Controls.Add(Me.Tuesday_Checkbox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Monday_Checkbox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SystemTime_Label)
        Me.Controls.Add(Me.TestConnection_Button)
        Me.Controls.Add(Me.COM_Port_Combobox)
        Me.Controls.Add(Me.Series_Combobox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainPage"
        Me.Text = "Main"
        CType(Me.Monday_h_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Monday_min_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tuesday_min_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tuesday_h_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wednesday_min_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wednesday_h_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thursday_min_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thursday_h_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Friday_min_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Friday_h_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Saturday_min_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Saturday_h_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sunday_min_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sunday_h_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Series_Combobox As ComboBox
    Friend WithEvents COM_Port_Combobox As ComboBox
    Friend WithEvents TestConnection_Button As Button
    Friend WithEvents SystemTime_Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Monday_Checkbox As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Tuesday_Checkbox As CheckBox
    Friend WithEvents Wednesday_Checkbox As CheckBox
    Friend WithEvents Thursday_Checkbox As CheckBox
    Friend WithEvents Friday_Checkbox As CheckBox
    Friend WithEvents Saturday_Checkbox As CheckBox
    Friend WithEvents Sunday_Checkbox As CheckBox
    Friend WithEvents Monday_h_NumUpDown As NumericUpDown
    Friend WithEvents Monday_min_NumUpDown As NumericUpDown
    Friend WithEvents Tuesday_min_NumUpDown As NumericUpDown
    Friend WithEvents Tuesday_h_NumUpDown As NumericUpDown
    Friend WithEvents Wednesday_min_NumUpDown As NumericUpDown
    Friend WithEvents Wednesday_h_NumUpDown As NumericUpDown
    Friend WithEvents Thursday_min_NumUpDown As NumericUpDown
    Friend WithEvents Thursday_h_NumUpDown As NumericUpDown
    Friend WithEvents Friday_min_NumUpDown As NumericUpDown
    Friend WithEvents Friday_h_NumUpDown As NumericUpDown
    Friend WithEvents Saturday_min_NumUpDown As NumericUpDown
    Friend WithEvents Saturday_h_NumUpDown As NumericUpDown
    Friend WithEvents Sunday_min_NumUpDown As NumericUpDown
    Friend WithEvents Sunday_h_NumUpDown As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents FlashOutput_Label As Label
    Friend WithEvents Flash_Button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Exit_Button As Button
End Class
