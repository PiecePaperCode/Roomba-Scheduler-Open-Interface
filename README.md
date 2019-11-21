# Roomba-Scheduler-Open-Interface v0.2

This is an .NET Application developed in VB.NET to bring easy acces to users who desire to run a Schedule Script on their Roomba 500 and 600 series using the Open Interface Port.

This is useful for those don't want to use arduino or other ESP8266 modules: you need only PC and FTDI USB module:  Arduino - - FTDI GND to Roomba ground (pin 6 or other pin of ESP)
- FTDI TX to Roomba RX (pin 3)

Now, the moment of truth. Press the "CLEAN" button on the Roomba, the light should go on. Plug in the USB for the Arduino. The Roomba light should turn off briefly, and after a few seconds the Arduino should blink it's LED. The schedule is now programmed, all done!

![alt text](https://github.com/PiecePaperCode/Roomba-Scheduler-Open-Interface/blob/master/Pictures/Screenshot_1.PNG)

## How To
### Download and install
Download the .zip File and run the setup.exe to install the Programm to your Computer.

[**Roomba-Scheduler-Open-Interface.zip**](https://github.com/PiecePaperCode/Roomba-Scheduler-Open-Interface/raw/master/Roomba%20Scheduler%20Open%20Interface.zip "Roomba-Scheduler-Open-Interface.zip")

### Connect your Roomba to your PC
Connect your Computer with an [FT232RL FT232 FTDI USB 3.3 v 5,5](https://www.google.com/search?q=FT232RL+FT232+FTDI+USB+3.3+v+5,5&rlz=1C1MSIM_enCH735CH735&source=lnms&tbm=isch&sa=X&ved=0ahUKEwigkMv019nfAhUQaFAKHfb6A1sQ_AUIDigB&biw=2560&bih=1329) 
and your Roomba. Look up the Schematics for the Roomba and connect the Wires to your board. 

YOU HAVE TO CONNECT ONLY GND AND RX PIN OF ROOMBA!

**REMINDER** Roomba uses 5V to communicate not 3.3V.

![alt text](https://github.com/PiecePaperCode/Roomba-Scheduler-Open-Interface/blob/master/Pictures/Instruction_1.png)
![alt text](https://github.com/PiecePaperCode/Roomba-Scheduler-Open-Interface/blob/master/Pictures/Instruction_2.png)

Select the correct Series and COM Port. If you dont know your COM look it up on your Device Manager. Test your connection with the Test Button. Your Roomba will beep, confirming the connection is ready. Input your desired Schedule into the Programm and "Flash" your Schedule to your Roomba. 

## Deployment

It was developed with VB.NET on Visual Studio 17 on an WIN 10 Machine (I don't be able to find right .NET  package for WIN 10)

## Versioning

0.1 Initial Release

0.2 Release

## Authors

* **PiecePaperCode** - *Initial work* 

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

None
