using Newtonsoft.Json;

namespace DP.DesignPatterns.Structural.Facade.I
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person { FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now.AddYears(-23) };

            /*var settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            settings.DateFormatString = "yy MMM d";

            var json = JsonConvert.SerializeObject(person, settings);*/

            var json = SerializeFacade.Serialize(person);

            Console.WriteLine(json);


            person = SerializeFacade.Deserialize<Person>(json);
        }
    }
}
