using Steam4Intermediate.NodeBehavior;
using System.Xml;

namespace Steam4Intermediate.Nodes
{
    class BaseNode : LinkBehavior
    {
        public BaseNode(XmlAttributeCollection collection)
            : base(collection)
        {
        }
    }
}