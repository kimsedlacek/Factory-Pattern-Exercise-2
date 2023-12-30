namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? Please select List, SQL or Mongo");
            var userAnswer = Console.ReadLine();

            var dataType = DataAccessFactory.GetDataAccessType(userAnswer);

            var products = dataType.LoadData();
            dataType.SaveData();
        }

    }
}
