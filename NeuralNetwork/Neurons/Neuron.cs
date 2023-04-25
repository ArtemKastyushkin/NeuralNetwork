using System;

namespace NeuralNetwork
{
    public abstract class Neuron
    {
        protected float[] _inputs;

        public int InputsAmount => _inputs.Length;
        public float Output { get; protected set; }

        public Neuron(int inputCount)
        {
            _inputs = new float[inputCount];
            Output = 0.0f;
        }

        private void FillInputs(float[] inputs)
        {
            if (_inputs.Length != inputs.Length)
                throw new Exception("The amount of inputs and signals doesn't match!");

            for (int i = 0; i < _inputs.Length; i++)
            {
                _inputs[i] = inputs[i];
            }
        }

        protected virtual void CalculateOutput() { }

        public void FeedForward(float[] inputs)
        {
            FillInputs(inputs);

            CalculateOutput();
        }
    }
}