using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Zinc
{
    public class ZincListener : ZincBaseListener
    {
        public HaystackGrid _grid = new HaystackGrid();

        public override void EnterGridMeta(ZincParser.GridMetaContext context)
        {
            string version = context.ver().STR().GetText();
            _grid.Version = version;
        }
    }

    public class HaystackGrid
    {
        public string Version;
        public HaystackDict Meta = new HaystackDict();
        public List<HaystackDict> Dicts = new List<HaystackDict>();
    }


    public class HaystackDict
    {
        private Dictionary<string, HaystackValue> Tags = new Dictionary<string, HaystackValue>();


    }

    public class HaystackList : HaystackValue
    {
        private readonly List<HaystackValue> _values;

        public HaystackList(List<HaystackValue> values)
        {
            _values = values;
        }

        public override string ToString()
        {
            return "[" + string.Join(",", _values.Select(value => value.ToString())) + "]";
        }
    }


    public abstract class HaystackValue
    {

    }


    public abstract class HaystackScalar
    {

    }

    public class HaystackString : HaystackScalar
    {
        private string _value;
        public HaystackString(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return $"\"{_value}\"";
        }
    }


    public class HaystackMarker : HaystackScalar
    {
        public const string MarkerString = "M";
        public override string ToString() => MarkerString;
    }

    public class HaystackNull : HaystackScalar
    {
        public const string NullString = "N";
        public override string ToString() => NullString;
    }

    public class HaystackRemove : HaystackScalar
    {
        public const string RemoveString = "R";
        public override string ToString() => RemoveString;
    }

    public class HaystackNA : HaystackScalar
    {
        public const string NAString = "NA";
        public override string ToString() => NAString;
    }


    public class HaystackBool : HaystackScalar
    {
        private readonly bool _value;

        public HaystackBool(bool value)
        {
            _value = value;
        }

        public override string ToString() => _value ? "T" : "F";
    }

    public class HaystackRef : HaystackScalar
    {
        private readonly string _reference;

        public HaystackRef(string reference)
        {
            _reference = reference;
        }
        public override string ToString() => _reference;
    }

    public class HaystackNumber : HaystackScalar
    {
        private readonly double _value;
        private readonly string _unit;

        public HaystackNumber(double value, string unit)
        {
            _value = value;
            _unit = unit;
        }

        public override string ToString() => $"{_value:g6}{_unit}";
    }
}
