namespace простая_нейросеть_из_одного_нейрона
{
    internal static class Settings
    {
        /// <summary>
        /// Включить ЛОГИ каждого шага каждого нейрона
        /// </summary>
        public const bool ЧЕНЖЛОГ_КАЖДОГО_НЕЙРОНА_ВКЛЮЧЕН = false;
        public static double размерШага { get; private set; } = 0.1;
        public static double допустимаяОшибка { get; private set; } = размерШага * 2;
    }
}
