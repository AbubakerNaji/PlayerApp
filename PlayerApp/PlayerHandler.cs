namespace PlayerApp
{
    public static class PlayerHandler
    {
        private static List<Player>  players = new List<Player>
        {
            new Player { Id = 1, Name = "Messi", Team = "Barcelona" },
            new Player { Id = 2, Name = "Ronaldo", Team = "Juventus" },
            new Player { Id = 3, Name = "Neymar", Team = "PSG" }
        };
        public static Player? GetPlayer(int id)
        {
            return players.FirstOrDefault(p => p.Id == id);
        }
        public static List<Player> GetPlayers()
        {
            return players;
        }

    }
}
