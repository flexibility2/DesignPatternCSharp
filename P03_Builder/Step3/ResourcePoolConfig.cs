namespace P03_Builder.Step3;

public class ResourcePoolConfig
{
    private readonly string _name;
    private readonly int _maxTotal;
    private readonly int _maxIdle;
    private readonly int _minIdle;
    
    public string Name => _name;
    public int MaxTotal => _maxTotal;
    public int MaxIdle => _maxIdle;
    public int MinIdle => _minIdle;

    private ResourcePoolConfig(Builder builder)
    {
        _name = builder.Name;
        _maxTotal = builder.MaxTotal;
        _maxIdle = builder.MaxIdle;
        _minIdle = builder.MinIdle;
    }

    public class Builder
    {
        private const int DefaultMaxTotal = 8;
        private const int DefaultMaxIdle = 8;
        private const int DefaultMinIdle = 0;

        private string _name;
        private int _maxTotal = DefaultMaxTotal;
        private int _maxIdle = DefaultMaxIdle;
        private int _minIdle = DefaultMinIdle;
        
        public string Name => _name;
        public int MaxTotal => _maxTotal;
        public int MaxIdle => _maxIdle;
        public int MinIdle => _minIdle;

        public Builder SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name should not be empty.");
            }
            _name = name;

            return this;
        }

        public Builder SetMaxTotal(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("MaxTotal should be positive.");
            }
            _maxTotal = value;
            
            return this;
        }

        public Builder SetMaxIdle(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("MaxIdle should not be negative.");
            }
            _maxIdle = value;

            return this;
        }

        public Builder SetMinIdle(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("MinIdle should not be negative.");
            }
            _minIdle = value;

            return this;
        }

        public ResourcePoolConfig Build()
        {
            if (string.IsNullOrWhiteSpace(_name))
            {
                throw new ArgumentException("Name should not be empty.");
            }

            if (_maxIdle > _maxTotal)
            {
                throw new ArgumentException("MaxIdle should not be greater than MaxTotal.");
            }

            if (_minIdle > _maxTotal || _minIdle > _maxIdle)
            {
                throw new ArgumentException("MinIdle should not be greater than MaxTotal or MaxIdle.");
            }

            return new ResourcePoolConfig(this);
        }
    }
}