internal class Exam
{
    public string Type { get; }
    public double Weight { get; }

    public Exam(string type, double weight)
    {
        Type = type.ToLower();
        Weight = weight;
    }

    public double Activity()
    {
        if (Type.Contains("coeur"))
            return (1.25 * (Weight - 70) + 720) / 37.0;

        if (Type.Contains("osseuse"))
            return (1.8 * (Weight - 70) + 740) / 37.0;

        if (Type.Contains("ventriculographie"))
            return 25.0;

        return 0;
    }
}
