namespace LegoMinifigureHub
{
    public interface IMinifigure
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        Minifigure.MinifigureTheme Theme { get; set; }
    }
}