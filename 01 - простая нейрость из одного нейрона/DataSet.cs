namespace простая_нейросеть_из_одного_нейрона
{
    internal static class DataSet
    {
        //Первоначально создание переменных
        /// <summary>
        /// Входные данные в нейроны для обучения
        /// </summary>
        public static double[] вход { get; private set; } = { 2, 4, 100 };
        /// <summary>
        /// Правильные ответы, соответствующие номерам Входных данных для обучения
        /// </summary>
        public static double[] правильныеОтветы { get; private set; } = { 6, 12, 300 };
        /// <summary>
        /// Настраивается в классе "ПроверочныеДанные"
        /// </summary>
        public static double[] новыеПроверочныеДанные { get; private set; } = ПроверочныеДанные.новыеПроверочныеДанные;
    }
}
