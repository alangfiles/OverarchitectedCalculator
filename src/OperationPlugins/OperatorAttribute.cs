using System;

namespace OperationPlugins
{
    class OperatorAttribute : Attribute
    {
        public string Symbol {get;}

        public OperatorAttribute(string symbol)
        {
            Symbol = symbol;
        }
    }
}