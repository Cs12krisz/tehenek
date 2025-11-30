namespace tehenek
{
    public class Program
    {
        static List<Tehen> happyCows = new List<Tehen>();

        static void Main(string[] args)
        {

            Beolvasas("hozam.txt");
            Feladat_3();
            Feladat_6("joltejelok.txt");
            Feladat_7();
        }

        private static void Feladat_3()
        {
            Console.WriteLine("3. feladat");
            Console.WriteLine("Az állomány " + happyCows.Count + " tehén adatait tartalmazza.");
        }

        private static void Feladat_6(string kimenetNev)
        {
            Console.WriteLine("6. feladat");
            var joTejelok = happyCows.Where(cow => cow.hetiAtlag() != -1);
            using (StreamWriter sw = new StreamWriter(kimenetNev))
            {
                foreach (var tehen in joTejelok)
                {
                    sw.WriteLine($"{tehen.Id} {tehen.hetiAtlag()}");
                }
            }
            Console.WriteLine($"{joTejelok.Count()} db sort írtam az állományba.");
        }

        private static void Feladat_7()
        {
            Console.WriteLine("7. feladat");
            Console.WriteLine("Kérem adja meg egy tehén azonosítóját!");
            string tehenId = Console.ReadLine();
            var leszarmazottTehenek = happyCows.Where(cow => cow.Id.StartsWith(tehenId) && cow.Id != tehenId);
            Console.WriteLine($"A leszármazottak száma: {leszarmazottTehenek.Count()}");
            

        }

        public static void Beolvasas(string fajlut)
        {
            StreamReader sr = new StreamReader(fajlut);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string id = sor.Split(';')[0];
                string nap = sor.Split(";")[1];
                string mennyiseg = sor.Split(";")[2];
                Tehen aktTehen = new Tehen(id);

                if (!happyCows.Contains(aktTehen))
                {
                    happyCows.Add(aktTehen);

                }
                int index = happyCows.IndexOf(aktTehen);
                happyCows[index].EredmenytRogzit(nap, mennyiseg);

            }
            sr.Close();
        }
    }
}
