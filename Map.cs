using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace GeoMapGameLabor3
{
    public class Map
    {
        
        List<string> list_country = new List<string>();
        string ListName = "";
        Random random = new Random();
        //int x = 0;

        public Map(string List_Name)
        {
            ListName = List_Name;
            
        }
        public void ListAndMap ()
        {
            try
            {
                
                using (StreamReader reader = new StreamReader(ListName))
                {
                    
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        list_country.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine(list_country);

        }
        public string ListCountryIndex(int x)
        {
            string i = list_country[x];
            //x++;
            return i;
        }
        
        public string CountryName()
        {
            if (list_country.Count == 0)
            {
                // Если список пуст, вернуть пустую строку или другое значение по умолчанию
                return string.Empty;
            }

            // Получаем случайный индекс из списка
            int randomIndex = random.Next(list_country.Count);

            // Получаем случайное значение из списка по выбранному индексу
            string randomCountry = list_country[randomIndex];

            // Удаляем выбранное значение из списка, чтобы оно не повторялось
            list_country.RemoveAt(randomIndex);

            return randomCountry;
        }
        
    }
}
