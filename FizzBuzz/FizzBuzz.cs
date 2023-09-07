namespace FizzBuzzTDD
{
    public class FizzBuzz
    {
        public string Obtener(int valor)
        {
            // if (valor % 15 == 0) return "fizzbuzz";
            // if (valor % 3 == 0) return "fizz";
            // if (valor % 5 == 0) return "buzz";
            //
            // return valor.ToString();

            var multiplos = new Dictionary<int, string>()
            {
                { 3, "fizz" },
                { 5, "buzz" }
            };
            var output = "";

            foreach (var (multiplo, word) in multiplos)
            {
                if (valor % multiplo == 0)
                {
                    output += word;
                }
            }

            return output == "" ? valor.ToString() : output;
        }
    }
}