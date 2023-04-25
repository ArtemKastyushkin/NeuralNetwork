namespace NeuralNetwork
{
    public class Layer
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
    }
}