using FootyAPI.Models;

namespace FootyAPI.Logic
{
    public interface IDbManager
    {
        void AddPlayer(Player player);
        void AddMatch(Match match);
    }
}