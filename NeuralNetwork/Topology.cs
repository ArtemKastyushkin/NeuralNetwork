namespace NeuralNetwork
{
    public class Topology
    {
        public int InputNeuronsCount { get; }
        public int[] HiddenLayers { get; }
        public int OutputNeuronsCount { get; }

        public static IActivationFunction ActivationFunction { get; private set; }

        public Topology(int inputNeuronsCount, int outputNeuronsCount, IActivationFunction activationFunction, params int[] hiddenLayers)
        {
            InputNeuronsCount = inputNeuronsCount;
            OutputNeuronsCount = outputNeuronsCount;
            ActivationFunction = activationFunction;
            HiddenLayers = hiddenLayers;
        }
    }
}