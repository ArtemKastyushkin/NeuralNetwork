using System;

namespace NeuralNetwork.ActivationFunctions
{
    public class Sigmoid : IActivationFunction
    {
        public float CalculateFunction(float x)
        {
            return 1.0f / (1.0f + (float)Math.Exp(-x));
        }

        public float CalculateFunctionDerivative(float x)
        {
            throw new System.NotImplementedException();
        }
    }
}
