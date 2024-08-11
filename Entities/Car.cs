namespace CarApi_Dotnet8.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Model { get; set; }
        public required int HP { get; set; }
    }
}
