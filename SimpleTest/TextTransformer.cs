using TextABCReader.Interfaces;

namespace TextABCReader
{
    public class TextTransformer : ITextTransformer
    {
        public string TransformText(string someInput)
        {         
            var charsToRemove = new string[] { ".", ",", ";" };

            foreach (var c in charsToRemove)
            {
                someInput = someInput.Replace(c, string.Empty);
            }
       
            var splitedOutput = someInput.Split(" ").ToList();

            var orderedOutput = splitedOutput.OrderBy(x => x, StringComparer.OrdinalIgnoreCase)
             .ThenBy(x => x, StringComparer.Ordinal);

            var result = string.Join(" ", orderedOutput);

            return result;
        }
    }
}
