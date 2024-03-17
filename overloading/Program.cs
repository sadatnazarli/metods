// Task - 1
//IsPrime metodu - parametr olaraq integer value qəbul edir. Göndərilmiş integer dəyərin sadə olub olmadığını qaytarır.Ədəd sadədirsə true, deyilsə false qayıtmalıdır
//internal class Program
//{
//    public static bool IsPrime(int value)
//    {
//        if (value < 2)
//        {
//            return false;
//        }
//        for (int i = 2; i <= Math.Sqrt(value); i++)
//        {
//            if (value % i == 0)
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}

// task --2   --- CalcAvg metodu - Göndərilmiş imtahanlar qiyməti siyahısına (integer array) əsasən həmin qiymətlərin ortalamasını qaytaran metod yazın. Main metodunda bu metodu call edib, burdan qayıdan dəyərə əsasən ortalama 60-dan böyükdürsə console-da "Mezun oldunuz" əks halda "Mezun ola bilmediniz" yazısı yazdırın
internal class Program
{
    public static double CalcAvg(int[] marks)
    {
        double sum = 0;
        foreach (var mark in marks)
        {
            sum += mark;
        }
        return sum / marks.Length;
    }
    public static void Main()
    {
        int[] marks = { 50, 60, 70, 80, 90 };
        double avg = CalcAvg(marks);
        if (avg >= 60)
        {
            Console.WriteLine("Mezun oldunuz");
        }
        else
        {
            Console.WriteLine("Mezun ola bilmediniz");
        }
    }
}