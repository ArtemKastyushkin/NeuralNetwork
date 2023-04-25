﻿using System.Collections.Generic;
using System.Linq;

namespace NeuralNetwork
{
    public class NeuralNetwork
    {
        private Topology _topology;
        private List<Layer> _layers;

        public NeuralNetwork(Topology topology)
        {
            _topology = topology;
            _layers = new List<Layer>();

            _layers.Add(CreateInputLayer());
            _layers.AddRange(CreateHiddenLayers());
            _layers.Add(CreateOutputLayer());
        }

        private Layer CreateInputLayer()
        {
            Neuron[] inputNeurons = new Neuron[_topology.InputNeuronsCount];

            for (int i = 0; i < inputNeurons.Length; i++)
            {
                inputNeurons[i] = new InputNeuron(1);
            }

            return new Layer(inputNeurons);
        }

        private List<Layer> CreateHiddenLayers()
        {
            List<Layer> hiddenLayers = new List<Layer>();

            for (int i = 0; i < _topology.HiddenLayers.Length; i++)
            {
                Neuron[] hiddenNeurons = new Neuron[_topology.HiddenLayers[i]];

                Layer lastLayer = _layers.Last();

                for (int j = 0; j < _topology.HiddenLayers[i]; i++)
                {
                    hiddenNeurons[j] = new HiddenNeuron(lastLayer.NeuronsCount);
                }

                hiddenLayers.Add(new Layer(hiddenNeurons));
            }

            return hiddenLayers;
        }

        private Layer CreateOutputLayer()
        {
            Neuron[] outputNeurons = new Neuron[_topology.OutputNeuronsCount];

            Layer lastLayer = _layers.Last();

            for (int i = 0; i < outputNeurons.Length; i++)
            {
                outputNeurons[i] = new OutputNeuron(lastLayer.NeuronsCount);
            }

            return new Layer(outputNeurons);
        }
    }
}