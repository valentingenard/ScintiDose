internal class Exam
{
    public string Type { get; set; }
    public double Weight { get; set; }

    public Exam(string type, double weight)
    {
        Type = type.ToLower();
        Weight = weight;
    }

    public double Activity()
    {
        double activityValue;

        if (Type.Contains("coeur"))
            activityValue = (1.25 * (Weight - 70) + 720) / 37.0;

        else if (Type.Contains("osseuse"))
            activityValue = (1.8 * (Weight - 70) + 740) / 37.0;

        else if (Type.Contains("ventriculographie"))
            activityValue = 25.0;

        else
            throw new ArgumentException("Exam type must contain coeur, osseuse or ventriculographie.");

        if (activityValue > 25)
            activityValue = 25;
        
        return activityValue;


    }
}
