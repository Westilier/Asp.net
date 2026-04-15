using Lesson3.Models;

namespace Lesson3.Repositories;

public class CharacterRepository
{
    private readonly List<Character> _characters = [];
    private int _nextId = 1;

    public CharacterRepository()
    {
        _characters =
        [
            new Character
            {
                Id = _nextId++,
                Name = "Гарри Поттер",
                Book = "Гарри Поттер и философский камень",
                Author = "Дж. К. Роулинг",
                Role = Character.RoleType.Main,
                Description = "Мальчик-который-выжил, ученик Хогвартса"
            },
            new Character
            {
                Id = _nextId++,
                Name = "Шерлок Холмс",
                Book = "Этюд в багровых тонах",
                Author = "Артур Конан Дойл",
                Role = Character.RoleType.Main,
                Description = "Гениальный частный детектив с уникальным методом дедукции"
            },
            new Character
            {
                Id = _nextId++,
                Name = "Элизабет Беннет",
                Book = "Гордость и предубеждение",
                Author = "Джейн Остин",
                Role = Character.RoleType.Main,
                Description = "Умная и независимая молодая женщина, вторая из пяти дочерей в семье Беннет"
            },
            new Character
            {
                Id = _nextId++,
                Name = "Мистер Дарси",
                Book = "Гордость и предубеждение",
                Author = "Джейн Остин",
                Role = Character.RoleType.Secondary,
                Description = "Богатый и гордый аристократ, который влюбляется в Элизабет"
            },
            new Character
            {
                Id = _nextId++,
                Name = "Снежок",
                Book = "Скотный двор",
                Author = "Джордж Оруэлл",
                Role = Character.RoleType.Main,
                Description = "Борец за равенство, вдохновляющий других животных на революцию"
            }
        ];
    }

    public List<Character> GetAll()
    {
        return _characters;
    }

    public Character? GetById(int id)
    {
        var product = _characters.First(x => x.Id == id);

        return product;
    }
    public void Update(Character newCharacter)
    {
        var oldCharacter = _characters.FirstOrDefault(x => x.Id == newCharacter.Id);
        if (oldCharacter != null)
        {
            oldCharacter.Name = newCharacter.Name;
            oldCharacter.Book = newCharacter.Book;
            oldCharacter.Author = newCharacter.Author;
            oldCharacter.Role = newCharacter.Role;
            oldCharacter.Description = newCharacter.Description;
        }
    }

    public void Add(Character character)
    {
        character.Id = _nextId++;
        _characters.Add(character);
    }
}