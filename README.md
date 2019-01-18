# Roomba-Scheduler-Open-Interface v0.2

This is an .NET Application developed in VB.NET to bring easy acces to users who desire to run a Schedule Script on their Roomba 500 and 600 series using the Open Interface Port.

![alt text](https://github.com/PiecePaperCode/Roomba-Scheduler-Open-Interface/blob/master/Pictures/Screenshot_1.PNG)

## How To
### Download and install
Download the .zip File and run the setup.exe to install the Programm to your Computer.

[**Roomba-Scheduler-Open-Interface.zip**](https://github.com/PiecePaperCode/Roomba-Scheduler-Open-Interface/raw/master/Roomba%20Scheduler%20Open%20Interface.zip "Roomba-Scheduler-Open-Interface.zip")

### Connect your Roomba to your PC
Connect your Computer with an [FT232RL FT232 FTDI USB 3.3 v 5,5](https://www.google.com/search?q=FT232RL+FT232+FTDI+USB+3.3+v+5,5&rlz=1C1MSIM_enCH735CH735&source=lnms&tbm=isch&sa=X&ved=0ahUKEwigkMv019nfAhUQaFAKHfb6A1sQ_AUIDigB&biw=2560&bih=1329) 
and your Roomba. Look up the Schematics for the Roomba and connect the Wires to your board. 

**REMINDER** Roomba uses 5V to communicate not 3.3V.

![alt text](https://github.com/PiecePaperCode/Roomba-Scheduler-Open-Interface/blob/master/Pictures/Instruction_1.png)
![alt text](https://github.com/PiecePaperCode/Roomba-Scheduler-Open-Interface/blob/master/Pictures/Instruction_2.png)

Select the correct Series and COM Port. If you dont know your COM look it up on your Device Manager. Test your connection with the Test Button. Your Roomba will beep, confirming the connection is ready. Input your desired Schedule into the Programm and "Flash" your Schedule to your Roomba. 

## Deployment

It was developed with VB.NET on Visual Studio 17 on an WIN 10 Machine

## Versioning

0.1 Initial Release

0.2 Release

## Authors

* **PiecePaperCode** - *Initial work* 

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

None
