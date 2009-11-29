using Caelum.SeleniumDSL.Selector;

namespace Caelum.SeleniumDSL.Default.Selector
{
    public class Name
    {
        public static ISelector Contains(string value)
        {
            return new PartialNameSelector(value);
        }

        public static ISelector Is(string name)
        {
            return new FullNameSelector(name);
        }
    }

    internal class FullNameSelector : ISelector
    {
        private readonly string _name;

        public FullNameSelector(string name)
        {
            _name = name;
        }

        public string GetExpression()
        {
            return string.Format("@name='{0}'", _name);
        }
    }

    internal class PartialNameSelector : ISelector
    {
        private readonly string _value;

        public PartialNameSelector(string value)
        {
            _value = value;
        }

        public string GetExpression()
        {
            return string.Format("contains(@name, '{0}')", _value);
        }
    }
}
