namespace Namespace;
public class Exercice2
{
        /// <summary>
        ///  Utilisation de Tuple
        /// </summary>
        /// <returns></returns>
        public static Tuple<string, int, float,bool,string[]> Main()
        {
            // TODO
            var name = "John";
            var age = 25;
            var weight =78.4;
            var isHuman = true;
            var friends =  new string[]{"Paul", "Sam","David"};
            
            return new Tuple<string, int, float,bool,string[]>
                (name, age, (float) weight, isHuman, friends);
        }

}
