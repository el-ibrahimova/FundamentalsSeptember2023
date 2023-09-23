namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
            string biggestKegModel = "";
            decimal biggestKegVolume = 0;

            for (int i = 1; i <= kegsCount; i++)
            {
                string kegModel = Console.ReadLine();
                decimal kegRadius = decimal.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                decimal kegVolume = (decimal)Math.PI * (kegRadius * kegRadius) * kegHeight;


                if (kegVolume > biggestKegVolume)
                {
                    biggestKegVolume = kegVolume;
                    biggestKegModel = kegModel;
                }
            }
            
            Console.WriteLine(biggestKegModel);
        }
    }
}