


namespace string_r
{
    public class string_r
    {
        
        public static string num_s = "234";
        public static void is_Int(string stringNumber){

            int numericValue;
            bool isNumber = int.TryParse(stringNumber, out numericValue);

            //isNumber is true and numericValue=123
            // System.Console.WriteLine(isNumber);
            System.Console.WriteLine($"is number? {numericValue} -> {isNumber}");
        }

        public static void is_Double(string stringNumber){

            double numericValue;
            bool isNumber = double.TryParse(stringNumber, out numericValue);

            //isNumber is true and numericValue=123
            // System.Console.WriteLine(isNumber);
            System.Console.WriteLine($"is number? {numericValue} -> {isNumber}");
        }

        public static void test(){
            string df = num_s.Insert(1, "__inserted__");
            System.Console.WriteLine(df); // ******************************2__inserted__34

            string df1 = df.PadRight(45, '*');
            System.Console.WriteLine(df1); // 2__inserted__34******************************
            
            df1 = df.PadLeft(45, '*');
            System.Console.WriteLine(df1); // ******************************2__inserted__34

        }
    }
}





