using projet_ASP;

namespace projet_ASP
{
    public class GameService
    {
        private static List<Game> games = new List<Game>
        {
            new Game { Id = 1, Titre = "Dungeon Keeper", AnneeSortie = 2021, Genre = "Action", Resume = "Résumé 1" },
            new Game { Id = 2, Titre = "Dungeon Keeper 2", AnneeSortie = 2021, Genre = "Action", Resume = "Résumé 2" },
            new Game { Id = 3, Titre = "Dungeon Keeper 3", AnneeSortie = 2021, Genre = "Action", Resume = "Résumé 3" },
            new Game { Id = 4, Titre = "overwatch", AnneeSortie = 2021, Genre = "Action", Resume = "Résumé 4"},
            new Game {Id = 5, Titre = "Heroes Of Might&Magic", AnneeSortie = 1993, Genre = "Stratégie", Resume = "Résumé 5"},
            new Game { Id = 6, Titre = "Heroes Of Might&Magic 2", AnneeSortie = 1996, Genre = "Stratégie", Resume = "Résumé 6" },
            new Game { Id = 7, Titre = "Heroes Of Might&Magic 3", AnneeSortie = 1999, Genre = "Stratégie", Resume = "Résumé 7" },
            new Game { Id = 8, Titre = "Heroes Of Might&Magic 4", AnneeSortie = 2002, Genre = "Stratégie", Resume = "Résumé 8" },
            new Game { Id = 9, Titre = "Heroes Of Might&Magic 5", AnneeSortie = 2006, Genre = "Stratégie", Resume = "Résumé 9" },
            new Game { Id = 10, Titre = "Heroes Of Might&Magic 6", AnneeSortie = 2011, Genre = "Stratégie", Resume = "Résumé 10" },
            new Game { Id = 11, Titre = "Heroes Of Might&Magic 7", AnneeSortie = 2015, Genre = "Stratégie", Resume = "Résumé 11" },
            new Game { Id = 12, Titre = "Worker&Resources", AnneeSortie = 2019, Genre = "Stratégie", Resume = "Résumé 12" },
            new Game { Id = 13, Titre = "Age Of Empire", AnneeSortie = 1997, Genre = "Stratégie", Resume = "Résumé 13" },
            new Game { Id = 14, Titre = "Age Of Empire 2", AnneeSortie = 1999, Genre = "Stratégie", Resume = "Résumé 14" },
            new Game { Id = 15, Titre = "Age Of Empire 3", AnneeSortie = 2005, Genre = "Stratégie", Resume = "Résumé 15" },
            new Game { Id = 16, Titre = "Age Of Empire 4", AnneeSortie = 2021, Genre = "Stratégie", Resume = "Résumé 16" },
            new Game { Id = 17, Titre = "Age Of Mythology", AnneeSortie = 2002, Genre = "Stratégie", Resume = "Résumé 17" },
            new Game { Id = 18, Titre = "Age Of Mythology 2", AnneeSortie = 2021, Genre = "Stratégie", Resume = "Résumé 18" },
            new Game { Id = 19, Titre = "Age Of Mythology 3", AnneeSortie = 2021, Genre = "Stratégie", Resume = "Résumé 19" },
            

            


        };

        public List<Game> GetGames()
        {
            return games;
        }

        public Game GetGame(int id)
        {
            return games.FirstOrDefault(g => g.Id == id);
        }

        public void AddGame(Game game)
        {
            games.Add(game);
        }

        public void DeleteGame(int id)
        {
            var game = games.FirstOrDefault(g => g.Id == id);
            if (game != null)
            {
                games.Remove(game);
            }
        }

        public void EditGame(Game game)
        {
            var gameToEdit = games.FirstOrDefault(g => g.Id == game.Id);
            if (gameToEdit != null)
            {
                gameToEdit.Titre = game.Titre;
                gameToEdit.AnneeSortie = game.AnneeSortie;
                gameToEdit.Genre = game.Genre;
                gameToEdit.Resume = game.Resume;
            }
        }







    }
}
