using System;

namespace NeuralNetwork
{
    public class InputLayer : Layer
    {
        public InputLayer(Neuron[] neurons) :base(neurons) { }

        public override void FeedForward(float[] signals)
        {
            if (_neurons.Length != signals.Length)
                throw new Exception("The amount of signals and Input neurons doesn't match!");

            for (int i = 0; i < _neurons.Length; i++)
            {
                _neurons[i].FeedForward(new float[] {signals[i] });
            }
        }
    }
}