using System;
using System.ComponentModel;
class Room {
    private string name;
    private List<SmartDevice> devices;

    public Room(string name) {
        this.name = name;
        devices = new List<SmartDevice>();
    }

    public void ConnectNewDevice(SmartDevice device) {
        // to create a new device in a room. just adding it to the list
        devices.Add(device);
    }

    public void DisconnectDevice(SmartDevice device) {
        // handle later. in case user wants to unconnect device
    }

    public void ReportDevices() {
        foreach (var device in devices) {
            device.ReportStatus();
        }
    }

    public void TurnOnOrOffAllLights(bool turnOn) {
        foreach (var device in devices) { // this code needs to be altered to only affect lights
            if (turnOn) {
                device.TurnOnAndOff();
            } else {
                device.TurnOnAndOff();
            }
        }
    }

    public void TurnOnOrOffDevice(SmartDevice device, bool turnOn) {
        if (turnOn)
        {
            device.TurnOnAndOff();
        } else {
            device.TurnOnAndOff();
        }
    }

    public void TurnOnOrOffAllDevices(bool turnOn) {
        foreach (var device in devices) {
            if (turnOn) {
                device.TurnOnAndOff();
            } else {
                device.TurnOnAndOff();
            }
        }
    }

    public void ReportDevicesTurnedOn() {
        foreach (var device in devices) { // add conditional later to only report ON devices
                device.ReportStatus();
        }
    }

    public void ReportLongestTurnedOn() {
        // do this later using times
    }
}