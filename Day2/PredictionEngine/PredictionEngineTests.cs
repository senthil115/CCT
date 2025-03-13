using Moq;

namespace PredictionEngine.Tests;

public class PredictionEngineTests
{

    [TestCase("How are y", "y")]
    [TestCase("How are you doing", "doing")]
    [TestCase("", "")]
    public void ShouldCallUnigramWhenInputEndsWithPartial(string input, string lastWord)
    {
        var mock = new Mock<ILanguageModelAlgo>();
        PredictionEngine predictionEngine = new PredictionEngine(mock.Object);

        predictionEngine.Predict(input);
        mock.Verify(p => p.predictUsingMonogram(lastWord), Times.Once());
    }

    [TestCase("How are you doing ", "doing")]
    [TestCase(" ", "")]
    public void ShouldCallBigramWhenInputEndsWithPartial(string input, string lastWord)
    {
        var mock = new Mock<ILanguageModelAlgo>();
        PredictionEngine predictionEngine = new PredictionEngine(mock.Object);

        predictionEngine.Predict(input);
        mock.Verify(p => p.predictUsingBigram(lastWord), Times.Once());
    }
}