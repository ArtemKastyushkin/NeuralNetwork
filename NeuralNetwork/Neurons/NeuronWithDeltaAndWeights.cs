using NeuralNetwork.ActivationFunctions;

namespace NeuralNetwork.Neurons
{
    public abstract class NeuronWithDeltaAndWeights : Neuron
    {
        private readonly float Bias = 1.0f;

        protected float[] _weights;
        protected float _delta;

        public NeuronWithDeltaAndWeights(int inputCount) : base(inputCount) 
        {
            _weights = new float[inputCount];
            _delta = 0.0f;
        }

        protected override void CalculateOutput()
        {
            float sum = 0.0f;

            for (int i = 0; i < _inputs.Length; i++)
            {
                sum += _inputs[i] * _weights[i];
            }

            IActivationFunction activationFunction = new Sigmoid();

            _output = activationFunction.CalculateFunction(sum + Bias);
        }
    }
}