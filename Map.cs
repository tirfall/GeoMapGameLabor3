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
        List<string> list_country2 = new List<string>();
        string ListName = "";
        Random random = new Random();
        int randomIndex;

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
                return string.Empty;
            }

            string randomCountry;

            for (int i = 0; i <= list_country.Count; i++)
            {
                randomIndex = random.Next(list_country.Count);
                randomCountry = list_country[randomIndex];
                if (randomCountry i)
            }
            do
            {
                
            } while (list_use.Contains(randomCountry));

            // Добавляем выбранное значение в список использованных
            list_use.Add(randomCountry);

            // Если список использованных стран стал таким же, как основной список, завершаем игру
            if (list_use.Count == list_country.Count)
            {
                // Логика завершения игры (например, вывод сообщения или другие действия)
                // ...

                // Возвращаем пустую строку или другое значение по умолчанию
                return string.Empty;
            }

            // Возвращаем уникальное значение
            return randomCountry;
            
        }
        
    }
}
