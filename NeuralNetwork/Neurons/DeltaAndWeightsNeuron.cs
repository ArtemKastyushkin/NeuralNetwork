using System;

namespace NeuralNetwork
{
    public abstract class DeltaAndWeightsNeuron : Neuron
    {
        private readonly float Bias = 1.0f;

        protected float[] _weights;
        protected float _delta;

        public DeltaAndWeightsNeuron(int inputCount) : base(inputCount) 
        {
            _weights = new float[inputCount];
            InitWeightsWithRandomValue();

            _delta = 0.0f;
        }

        private void InitWeightsWithRandomValue()
        {
            Random random = new Random();

            for (int i = 0; i < _weights.Length; i++)
            {
                _weights[i] = (float)random.NextDouble();
            }
        }

        protected override void CalculateOutput()
        {
            float sum = 0.0f;

            for (int i = 0; i < _inputs.Length; i++)
            {
                sum += _inputs[i] * _weights[i];
            }

            Output = Topology.ActivationFunction.CalculateFunction(sum + Bias);
        }
    }
}