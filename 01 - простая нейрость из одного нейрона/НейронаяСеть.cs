using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace простая_нейросеть_из_одного_нейрона
{
    internal class НейронаяСеть
    {
        public static Neuron[] нейроны { get; private set; } =
            {
                new Neuron(3, 2),
                new Neuron(3, 0),
            };
    public static int колвоНейронов = нейроны.Length;
    }
}
