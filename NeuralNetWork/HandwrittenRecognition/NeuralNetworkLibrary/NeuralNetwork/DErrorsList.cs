using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNetworkLibrary
{
    public class DErrorsList:List<double>
    {
        public DErrorsList()
        { 
        
        }
        public DErrorsList(int capacity)
            : base(capacity)
        {
            
        }
        public DErrorsList(IEnumerable<double> collection)
            : base(collection)
        {
            
        }
         
    }
}
