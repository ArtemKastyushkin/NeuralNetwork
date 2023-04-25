namespace NeuralNetwork.Neurons
{
    public class InputNeuron : Neuron
    {
        public InputNeuron(int inputCount) : base(inputCount) { }

        protected override void CalculateOutput()
        {
            _output = _inputs[0];
        }
    }
}