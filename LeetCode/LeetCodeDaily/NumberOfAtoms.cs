namespace LeetCodeDaily
{
    public class NumberOfAtoms
    {
        public static void Main()
        {
            PriorityQueue<string, string> elementHeap = new(Comparer<string>.Create(
                (a, b) => string.Compare(a, b, StringComparison.Ordinal)));

            elementHeap.Enqueue("He", "He");
            elementHeap.Enqueue("Apple", "Apple");
            elementHeap.Enqueue("ZED", "ZED");
            elementHeap.Enqueue("H", "H");
            while (elementHeap.Count != 0)
            {
                System.Console.WriteLine("Printing .... " + elementHeap.Dequeue());
            }
        }

        public string CountOfAtoms(string formula)
        {
            var frequencyMap = new Dictionary<string, int>();
            var stack = new Stack<string>();
            PriorityQueue<string, string> elementHeap = new(Comparer<string>.Create(
                (a, b) => string.Compare(a, b, StringComparison.Ordinal)));

            for (int i = 0; i < formula.Length - 1; i++)
            {
                if (formula[i] == '(')
                {
                    // push it onto a stack
                    stack.Push(formula[i] + "");
                }
                else if (formula[i] == ')')
                {
                    // pop stack until we reach a '('
                }
                else if (isLowerCase(formula[i + 1]))
                {
                    var key = formula[i] + "" + formula[i + 1];
                    var val = i + 2 < formula.Length && isANumber(formula[i + 2])
                    ? formula[i + 2]
                    : 1;
                    frequencyMap[key] = frequencyMap[key] + val;
                    i = i + 2;
                }
                else
                {
                    var key = formula[i] + "";
                    var val = i + 1 < formula.Length && isANumber(formula[i + 1])
                    ? formula[i + 1]
                    : 1;
                    frequencyMap[key] = frequencyMap[key] + val;
                    i = i + 1;
                }
            }

            return "blaj";
        }

        private bool isLowerCase(char character)
        {
            return character < 123 && character > 96;
        }

        private bool isANumber(char character)
        {
            return character < 57 && character > 47;
        }


    }

}