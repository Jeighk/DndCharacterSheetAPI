namespace DndCharacterSheetAPI.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public int MaxHitPoints { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constituion { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Alignment { get; set; }
        public string Name { get; set; }            
        public string Class { get; set; }
        public string Race { get; set; }
        public string Background { get; set; }
        public decimal Gold { get; set; }
        public int Speed { get; set; }
    }
}
