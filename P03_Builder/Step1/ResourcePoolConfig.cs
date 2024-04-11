namespace P03_Builder.Step1;

public class ResourcePoolConfig
{
    private const int DefaultMaxTotal = 8;
    private const int DefaultMaxIdle = 8;
    private const int DefaultMinIdle = 0;

    private readonly string _name;
    private readonly int _maxTotal = DefaultMaxTotal;
    private readonly int _maxIdle = DefaultMaxIdle;
    private readonly int _minIdle = DefaultMinIdle;
    
    public string Name => _name;
    public int MaxTotal => _maxTotal;
    public int MaxIdle => _maxIdle;
    public int MinIdle => _minIdle;

    public ResourcePoolConfig(string name, int? maxTotal, int? maxIdle, int? minIdle)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name should not be empty.", nameof(name));
        }
        _name = name;

        if (maxTotal.HasValue)
        {
            if (maxTotal.Value <= 0)
            {
                throw new ArgumentException("MaxTotal should be positive.", nameof(maxTotal));
            }
            _maxTotal = maxTotal.Value;
        }

        if (maxIdle.HasValue)
        {
            if (maxIdle.Value < 0)
            {
                throw new ArgumentException("MaxIdle should not be negative.", nameof(maxIdle));
            }
            _maxIdle = maxIdle.Value;
        }

        if (minIdle.HasValue)
        {
            if (minIdle.Value < 0)
            {
                throw new ArgumentException("MinIdle should not be negative.", nameof(minIdle));
            }
            _minIdle = minIdle.Value;
        }
    }
}