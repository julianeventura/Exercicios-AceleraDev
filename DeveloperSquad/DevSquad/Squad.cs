namespace DevSquad
{
    public class Squad
    {
        public long Id { get; set; }
        public string Name { get; set; }
        //quando é colocado um ponto de interrogação após o tiop dela 
        //quer dizer que a prop é opcional ser passado
        public long? TechLeaderId { get; set; }
    }
}
