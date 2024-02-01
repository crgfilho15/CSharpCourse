using System;
using System.Collections; // Precisa desse import para utilizar o ArrayList

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            // Não pe recomendado criar Lists/ArrayLists com múltiplos tipos, exceto em casos que realmente seja necessários por algum motivo
            var arraylist = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);
            Console.WriteLine(arraylist.Count);

            foreach(var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
