namespace NeuralNetwork
{
    public abstract class LearningLayer : Layer
    {
        public LearningLayer(Neuron[] neurons) : base(neurons) { }

        public override void FeedForward(float[] signals)
        {
            base.FeedForward(signals);

            for (int i = 0; i < _neurons.Length; i++)
            {
                _neurons[i].FeedForward(signals);
            }
        }
    }
}