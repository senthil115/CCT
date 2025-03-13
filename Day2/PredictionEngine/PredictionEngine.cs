namespace PredictionEngine
{
    public class PredictionEngine
    {
        private ILanguageModelAlgo languageModelAlgo;

        public PredictionEngine(ILanguageModelAlgo languageModelAlgo)
        {
            this.languageModelAlgo = languageModelAlgo;
        }

        public string Predict(string inputPhrase)
        {
            string lastWord = GetLastWord(inputPhrase);

            if(inputPhrase.EndsWith(" "))
                return languageModelAlgo.predictUsingBigram(lastWord);
            
            return languageModelAlgo.predictUsingMonogram(lastWord);
        }

        private string GetLastWord(string input)
        {
            string lastWord = input.Trim().Split(" ").Last();
            return lastWord;
        }

    }
}
