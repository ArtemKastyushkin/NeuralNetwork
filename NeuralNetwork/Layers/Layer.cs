using System;

namespace NeuralNetwork
{
    public abstract class Layer
    {
        protected Neuron[] _neurons;

        public int NeuronsCount => _neurons.Length;

        public Layer(Neuron[] neurons)
        {
            _neurons = neurons;
        }

        public float[] GetSignals()
        {
            float[] signals = new float[NeuronsCount];

            for (int i = 0; i < _neurons.Length; i++)
            {
                signals[i] = _neurons[i].Output;
            }

            return signals;
        }

        public virtual void FeedForward(float[] signals) 
        {
            if (_neurons[0].InputsAmount != signals.Length)
                throw new Exception("The amount of signals and neuron inputs doesn't match!");
        }
    }
}