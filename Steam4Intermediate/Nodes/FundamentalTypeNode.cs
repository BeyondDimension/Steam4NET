using Steam4Intermediate.NodeBehavior;
using System.Xml;

namespace Steam4Intermediate.Nodes
{
    class FundamentalTypeNode : LinkBehavior
    {
        public FundamentalTypeNode(XmlAttributeCollection collection)
            : base(collection)
        {
            name = GetAttribute("kind");
        }
    }
}