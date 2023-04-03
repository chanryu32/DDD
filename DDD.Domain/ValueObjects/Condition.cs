namespace DDD.Domain.ValueObjects
{
    public sealed class Condition : ValueObject<Condition>
    {
        /// <summary>
        /// 不明
        /// </summary>
        public static readonly Condition None = new(0);

        /// <summary>
        /// 晴れ
        /// </summary>
        public static readonly Condition Sunny = new(1);

        /// <summary>
        /// 曇り
        /// </summary>
        public static readonly Condition Cloudy = new(2);

        /// <summary>
        /// 雨
        /// </summary>
        public static readonly Condition Rainy = new(3);

        public Condition(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public string DisplayValue
        {
            get
            {

                if (this == Sunny)
                {
                    return "晴れ";
                }
                if (this == Cloudy)
                {
                    return "曇り";
                }
                if (this == Rainy)
                {
                    return "雨";
                }
                return "不明";

            }

        }

        /// <summary>
        /// 同じValueのインスタンスはイコールとする
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        protected override bool EqualsCore(Condition other)
        {
            return Value == other.Value;
        }

        public static IList<Condition> ToList()
        {
            return new List<Condition>
            {
                None,
                Sunny,
                Cloudy,
                Rainy
            };
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }
    }
}
