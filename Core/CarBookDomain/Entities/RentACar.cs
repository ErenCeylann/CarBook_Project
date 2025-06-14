namespace CarBookDomain.Entities
{
    public class RentACar
    {
        public int RentACarId { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }

        public bool Avaiable { get; set; }
    }
}
