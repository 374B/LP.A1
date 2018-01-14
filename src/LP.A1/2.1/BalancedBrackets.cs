namespace LP.A1._2._1
{
    public class BalancedBrackets
    {
        private const string Braces = "{}";
        private const string Brackets = "[]";
        private const string Parentheses = "()";
        
        /// <summary>
        /// Returns true if the string is balanced, false if it is not
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool Balanced(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return true;

            //If the string doesn't have an even number of chars it can't be balanced
            if (input.Length % 2 != 0) return false;

            while (input.Length > 0)
            {
                var l = input.Length;

                input = input.Replace(Braces, "");
                input = input.Replace(Brackets, "");
                input = input.Replace(Parentheses, "");

                //Nothing replaced, break
                if (l == input.Length)
                    break;

            }

            //If we have a balanced string, the length will now be zero
            var balanced = input.Length == 0;

            return balanced;

        }
    }
}
