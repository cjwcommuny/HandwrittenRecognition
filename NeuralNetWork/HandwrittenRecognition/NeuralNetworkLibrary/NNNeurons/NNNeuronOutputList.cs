using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNetworkLibrary
{
    public class NNNeuronOutputsList:List<NNNeuronOutputs>
    {
        public NNNeuronOutputsList()
       {
       
       }
        public NNNeuronOutputsList(int capacity)
            : base(capacity)
        {
            
        }
        public NNNeuronOutputsList(IEnumerable<NNNeuronOutputs> collection)
            : base(collection)
        {
            
        }
        
    }
}
