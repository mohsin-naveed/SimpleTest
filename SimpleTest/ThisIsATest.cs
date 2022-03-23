using TextABCReader;
using TextABCReader.Interfaces;

namespace SimpleTest
{
    public class MyTest
    {
        private readonly ITextTransformer _textTransformer;
        private readonly ILogger _logger;

        public MyTest(ITextTransformer textTransformer, ILogger logger)
        {
            _textTransformer = textTransformer;
            _logger = logger;
        }

        public string TransformText(string someInput)
        {
            if (someInput == null)
            {
                throw new DataMisalignedException("data not correct");
            }

            _logger.Log("start TransformText");


            var transformedText = _textTransformer.TransformText(someInput);


            _logger.Log("end TransformText");


            return transformedText;

        }
    }
}
