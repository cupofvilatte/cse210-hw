using System;
class House {
    private string name;
    private List<Room> rooms;
    public House(string name) {
        this.name = name;
        rooms = new List<Room>();
    }

    public void AddRoom (Room room) {
        rooms.Add(room);
    }

    public void RemoveRoom(Room room) {
        // add later
    }
}