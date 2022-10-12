GameState G = new GameState();
Room CurrentRoom = new Room();
CurrentRoom.Name = $"Room{G.cordinats}";
while(true) {
    Console.WriteLine($"Du befinner dig i rum {CurrentRoom.Name}");
    G.ParseUserInput();
}