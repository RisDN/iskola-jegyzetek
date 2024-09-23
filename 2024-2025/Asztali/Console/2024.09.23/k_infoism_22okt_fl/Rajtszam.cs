

namespace k_infoism_22okt_fl
{
    class Rajtszam
    {
    

        public static string GetRajtszam(string rajtszam)
        {
            switch (rajtszam[0])
            {
                case 'M': return "Mini";
                case 'R': return "Rövid";
                case 'K': return "Közép";
                case 'H': return "Hosszú";
                case 'E': return "Pedelec";
            }
            return "Hibás rajtszám";
        }

    }

}
