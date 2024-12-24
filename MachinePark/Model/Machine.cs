namespace MachinePark.Model
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Edited { get; set; }
        public bool Status { get; set; }
    }
}
