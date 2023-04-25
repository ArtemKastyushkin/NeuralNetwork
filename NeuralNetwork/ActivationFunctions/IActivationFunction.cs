﻿namespace NeuralNetwork.ActivationFunctions
{
    public interface IActivationFunction
    {
        float CalculateFunction(float x);
        float CalculateFunctionDerivative(float x);
    }
}