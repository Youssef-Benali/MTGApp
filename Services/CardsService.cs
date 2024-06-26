using Microsoft.EntityFrameworkCore;
using MTGApp.Models;

namespace MTGApp.Services
{
    public class CardsService : MTGData
    {
        private readonly DBContext _context;

        public CardsService(DBContext context)
        {
            _context = context;
        }
        private const int pageSize = 6;

        public async Task<List<Card>> GetAllCards(int pageNumber)
        {
            var cards = await _context.Cards
                                        .OrderBy(e => e.Id)
                                        .Skip((pageNumber - 1) * pageSize)
                                        .Take(pageSize)
                                        .ToListAsync();
            return cards;
        }

        public async Task<List<Card>> GetCardsByName(string name)
        {
            var cards = await _context.Cards
            .Where(card => card.Name.ToLower().Contains(name.ToLower()))
            .Where(card => card.OriginalImageUrl != null)
            .GroupBy(card => card.Name)
            .Select(card => card.First())
            .Take(10)
            .ToListAsync();

            return cards;
        }

        public async Task<Card> GetCardById(long id)
        {
            var card = await _context.Cards
            .OrderBy(e => e.Id)
            .Where(card => card.Id == id)
            .FirstAsync();

            return card;
        }

        public async Task<List<Card>> GetLikedCard()
        {
            var cards = await _context.Cards
            .Where(c => c.Liked == true)
            .ToListAsync();

            return cards;
        }

        public async Task LikeCard(long id)
        {
            var card = await _context.Cards.Where(c => c.Id == id).FirstAsync();

            if (card.Liked == null || card.Liked == false)
            {
                card.Liked = true;
            }
            else
            {
                card.Liked = false;
            }

            await _context.SaveChangesAsync();
            Console.WriteLine($"changes saved to the database.");
        }
    }
}