using System.Linq;

namespace StringCalculator.Kata._12082013 {
    /// <summary>
    /// Clase que realiza cálculos de strings 
    /// </summary>
    public static class StringCalculator {
        
        public static int Add(string numbers) {
            if (IsEmptyString(numbers)) {
                return ManageEmptyString();
            }
            return IsOneNumberString(numbers) ? ManageOneNumberString(numbers) : ManyNumbersString(numbers);
        }

        private static int ManyNumbersString(string numbers) {
            var number = numbers.Split(',');
            return number.Sum(numberExtracted => int.Parse(numberExtracted));
        }

        private static int ManageOneNumberString(string numbers) {
            return int.Parse(numbers);
        }

        private static bool IsOneNumberString(string numbers) {
            return numbers.IndexOf(',') < 0;
        }

        private static int ManageEmptyString() {
            return 0;
        }

        private static bool IsEmptyString(string numbers) {
            return string.IsNullOrEmpty(numbers);
        }
    }
}
