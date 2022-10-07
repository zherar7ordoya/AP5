namespace FactoryEndgame.Samples
{
    public interface ISample2
    {
        int RandomValue { get; set; }
    }

    public class Sample2 : ISample2
    {
        public int RandomValue { get; set; }

        public Sample2()
        {
            RandomValue = new Random().Next(1, 100);
        }
    }
}
