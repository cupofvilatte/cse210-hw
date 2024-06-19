using System;
abstract class SmartDevice {

    protected virtual bool TurnOnAndOff() {
        return true;
    }

    protected virtual void ReportStatus() {
        if (5 > 4) {
            Console.WriteLine("The machine is on");
        } else if (5 == 5) {
            Console.WriteLine("The machine is off");
        }
    }
}