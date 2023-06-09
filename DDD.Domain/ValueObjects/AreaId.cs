﻿namespace DDD.Domain.ValueObjects
{
    public sealed class AreaId : ValueObject<AreaId>
    {
        public AreaId(int value)
        {
            Value = value;
        }
        public int Value { get; }

        protected override bool EqualsCore(AreaId other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }

        public string DisplayValue
        {
            get
            {
                return Value.ToString().PadLeft(4, '0');
            }
        }
    }
}
