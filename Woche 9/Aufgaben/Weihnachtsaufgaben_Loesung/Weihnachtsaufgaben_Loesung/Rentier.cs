namespace Weihnachtsaufgaben_Loesung
{
    public class Rentier
    {
        private string name;
        private int alter;
        private bool roteNase;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Alter
        {
            get => alter;
            set => alter = value;
        }

        public bool RoteNase
        {
            get => roteNase;
            set => roteNase = value;
        }

        public string SchoeneAusgabe
        {
            get
            {
                return $"{Name} ist {Alter} und hat {(RoteNase ? "eine" : "keine")} rote Nase\n";
            }
        }

        public Rentier(string name, int alter, bool roteNase)
        {
            // Anstatt mit this. kann auch über die Getter gearbeitet werden
            this.name = name;
            this.alter = alter;
            this.roteNase = roteNase;
        }
    }
}