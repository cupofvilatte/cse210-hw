using System;
abstract class SmartDevice {

    private string name;
    private bool isOn;

    public SmartDevice(string name) {
        this.name = name;
        this.isOn = false;
    }

    public virtual bool TurnOnAndOff() {
        if (isOn) {
            isOn = false;
            // later add code for setting the time turned off to null
            Console.WriteLine("Your device is now off.");
        } else {
            isOn = true;
            // save the time that it was turned on
            Console.WriteLine("Your device is now on.");
        }
        return isOn;
    }

    public virtual void ReportStatus() {
        if (isOn) {
            Console.WriteLine("The device is on");
        } else {
            Console.WriteLine("The device is off");
        }
    }

    public int timeOnFor() { // later edit return type to not be int
        // handle later
        // save the time turned on. subtract current time from when it was turned on
        // return that number
        return 0;
    }
}