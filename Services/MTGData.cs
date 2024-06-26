using MTGApp.Models;

namespace MTGApp.Services
{
    public interface MTGData
    {
        Task<List<Card>> GetAllCards(int amount);
        Task<List<Card>> GetCardsByName(string name);
        Task<Card> GetCardById(long id);
        Task<List<Card>> GetLikedCard();

        Task LikeCard(long id);
    }
}