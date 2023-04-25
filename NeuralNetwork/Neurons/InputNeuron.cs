namespace NeuralNetwork
{
    public class InputNeuron : Neuron
    {
        public InputNeuron(int inputCount) : base(inputCount) { }

        protected override void CalculateOutput()
        {
            Output = _inputs[0];
        }
    }
}