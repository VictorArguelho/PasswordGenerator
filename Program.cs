namespace PasswordGenerator
{
    internal static class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.Write(new string('=', Console.WindowWidth));
                var inputs = GetInputs();
                Console.WriteLine($"Senha: {(inputs.Item2 ? "@hard" : "")}{GeneratePassword(inputs.Item1)}");
            }
        }

        private static (string, bool) GetInputs()
        {
            Console.WriteLine("Nome da plataforma: ");
            var app = Console.ReadLine()!;

            Console.WriteLine("Senha forte? (s/n): ");
            var strongString = Console.ReadLine()!;
            var isStrong = strongString.ToLower() == "s";

            return(app, isStrong);
        }

        private static string GeneratePassword(string app)
        {
            var utilApp = GetUtilApp(app);
            var password = new char[8];

            password[0] = char.ToUpper(GetBackChar(utilApp[0], 2));
            password[1] = GetBackChar(utilApp[1], 4);
            password[2] = GetBackChar(utilApp[2], 6);

            password[3] = '@';

            for (var i = 0; i < 4; i++)
                password[4 + i] = (char)(GetCharNumber(utilApp[i]) + '0');

            return new string(password);
        }

        private static string GetUtilApp(string app)
        {
            var utilApp = app;
            while (utilApp.Length < 4)
                utilApp += app;
            return utilApp.ToLower();
        }

        private static char GetBackChar(char chr, int amount)
        {
            var newChr = chr - 'a' - amount;
            return (char)('a' + ((newChr % 26 + 26) % 26));
        }

        private static int GetCharNumber(char chr)
        {
            var num = chr - 'a' + 1;

            if (num < 10)
                return num;

            var digits = num.ToString();

            var result = 1;

            foreach (var digit in digits)
                result *= digit - '0';

            return int.Parse(result.ToString()[0].ToString());
        }
    }
}