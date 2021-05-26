public class Program
    {
        /*
         * This program takes a file name as argument and an operation (+ or *)
         * it parses the file
         * in this file, each line of the file should hopefully have a valid number
         * it should take each number and print the operation, along with the intermediary result
         * it should print at the end the total result of the defined operation applied to
         * all numbers found in this file (along with the text name of the operation)
         * ex:
         * 1
         * +2 (=3)
         * +3 (=6)
         * -------
         * total = 6 (addition)
         */
        public static void Main(string[] args)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("hhmmss:ffffff")}][log] started");

            string ns = File.ReadAllText(args[0]);
            string o = args[1];
            int t = 0;
            int ln = 0;

            Console.WriteLine($"[{DateTime.Now.ToString("hhmmss:ffffff")}][log] applying operation {operationType(o)}");
            
            foreach (string s in ns.Split(Environment.NewLine))
            {
                int val = int.Parse(s);
                printOperation(val);
                Console.Write(ln == 0 ? val.ToString() : o + val.ToString());

                if (ln == 0) Console.WriteLine();
                else Console.WriteLine($" (= {t.ToString()})");

                if (operationType == "addition") t+= val;
                else if (operationType == "multiplication") t*= val;

                ln++;
                Console.WriteLine($"[{DateTime.Now.ToString("hhmmss:ffffff")}][log] accumulation : {t} on line {ln}");
            }
            printTotal(t);
        }

        public void printOperation(int value) {
            Console.WriteLine($"[{DateTime.Now.ToString("hhmmss:ffffff")}][log] parsed value = {value}");
        }

        public string operationType(string type) {
            return type == "+" ? "addition" : type == "*" ? "multiplication" : "unknown";
        }

        public void printTotal(int total) {
            Console.WriteLine("--------------");
            Console.WriteLine("Total = " + total.ToString());
            Console.WriteLine($"[{DateTime.Now.ToString("hhmmss:ffffff")}][log] end of program");
        }

        public void calculate() {

        }
    }