namespace Namespace;
public class Exercice1
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

        /// <summary>
        /// le caractere à modifier
        /// pour une fonction qui fait du modulo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
         public  static void ComputeAndDisplay(int a, int b)
         {
           var res = a % b;
           Console.WriteLine(res);
         }
         
        /// <summary>
        /// Convertir un variable en un autre
        /// de type
        /// </summary>
        /// <returns></returns>
        public static Tuple<int, bool, string> GetConvert()
        {
            var myInt = "17";
            var myBool = "False";
            var myString = 100;
            var myIntConverted = int.Parse(myInt);
            var myBoolConverted = bool.Parse(myBool);
            var myStringConverted = myString.ToString();
            return new Tuple<int, bool, string>
                (myIntConverted, myBoolConverted, myStringConverted);
         } 

        /// <summary>
        /// Problème de Typage
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Divide(int a, int b)
        {
            return  (float) a / b;
        }

        /// <summary>
        /// Condition qui
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public static string CheckAge(int age)
        {
            // Ne pas toucher cette ligne.
            string message = "";
            if(age<18)
            {
                message = string.Format($"vous êtes mineur(e)");
            }
            if(age >=18 && age< 20)
            {
                message = string.Format($"vous êtes juste majeur(e)");

            }

            if(age >=20)
            {
                message = string.Format($"vous êtes majeur(e)");

            }
            // Ecrire la condition "if" qui permet de répondre à l'exercice.
            // l'âge est stockée dans la variable "age".
            // Vous devez enregistrer le message dans la variable "message".
            
            // Ne pas toucher ces lignes.
            Console.WriteLine(message);
            return message;
        }

}
