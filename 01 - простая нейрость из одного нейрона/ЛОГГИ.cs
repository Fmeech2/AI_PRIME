using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace простая_нейросеть_из_одного_нейрона
{
    internal static class ЛОГГИ
    {
        public static void ОтобразитьЛист(List<string> ченжлог, bool принудительныйВывод)
        {
            //Вывод процесса обучения в консоль
            if (Settings.ЧЕНЖЛОГ_КАЖДОГО_НЕЙРОНА_ВКЛЮЧЕН || принудительныйВывод)
            {
                foreach (string строка_отчёта in ченжлог)
                {
                    Console.WriteLine(строка_отчёта);
                }
            }
        }
        public static void ОтобразитьЛист(List<string> ченжлог, int принудительныйВывод)
        {
            //Вывод процесса обучения в консоль
            if (Settings.ЧЕНЖЛОГ_КАЖДОГО_НЕЙРОНА_ВКЛЮЧЕН || принудительныйВывод!=0)
            {
                foreach (string строка_отчёта in ченжлог)
                {
                    Console.WriteLine(строка_отчёта);
                }
            }
        }
    }
}
