using System;

namespace NeuralNetwork
{
    public class Sigmoid : IActivationFunction
    {
        public float CalculateFunction(float x)
        {
            return 1.0f / (1.0f + (float)Math.Exp(-x));
        }

        public float CalculateFunctionDerivative(float x)
        {
            float sigmoid = CalculateFunction(x);

            return sigmoid / (1.0f - sigmoid);
        }
    }
}
