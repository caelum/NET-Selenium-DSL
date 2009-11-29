using Caelum.SeleniumDSL.Selector;

namespace Caelum.SeleniumDSL.Default.Selector
{
    public class Id
    {
        public static ISelector Is(string id)
        {
            return new FullIdSelector(id);
        }

        public static ISelector Contains(string value)
        {
            return new PartialIdSelector(value);
        }
    }

    internal class PartialIdSelector : ISelector
    {
        private readonly string _value;

        public PartialIdSelector(string value)
        {
            _value = value;
        }

        public string GetExpression()
        {
            return string.Format("[contains(@id, '{0}')]", _value);
        }
    }

    internal class FullIdSelector : ISelector
    {
        private readonly string _id;

        public FullIdSelector(string id)
        {
            _id = id;
        }

        public string GetExpression()
        {
            return string.Format("[@id='{0}']", _id);
        }
    }
}
