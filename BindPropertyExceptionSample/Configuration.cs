namespace BindPropertyExceptionSample;

public class Configuration
{
    public IEnumerable<int> FilteredConfigValues => ConfigValues.Where(p => p > 10);
    public IEnumerable<int> ConfigValues { get; set; } = null!;
}
