internal class Exam
{
    public string Type { get; }
    public double Weight { get; }

    public Exam(string type, double weight)
    {
        Type = type.ToLower();
        Weight = weight;
    }

    public double ActivityP50()
    {
        double activityValue;

        if (Type.Contains("coeur"))
            activityValue = (1.25 * (Weight - 70) + 720) / 37.0;

        else if (Type.Contains("osseuse"))
            activityValue = (1.8 * (Weight - 70) + 740) / 37.0;

        else if (Type.Contains("ventriculographie"))
            activityValue = 25.0;

        else
            throw new ArgumentException("Exam: -- ignored --");

        if (activityValue > 25)
            activityValue = 25;
        
        return activityValue;


    }

    public double ActivityP25()
    {
        double activityValue;

        if (Type.Contains("coeur"))
            activityValue = (1 * (Weight - 70) + 666) / 37.0;

        else if (Type.Contains("osseuse"))
            activityValue = (1.6 * (Weight - 70) + 700) / 37.0;

        else if (Type.Contains("ventriculographie"))
            activityValue = 25.0;

        else
            throw new ArgumentException("Exam: -- ignored --");

        if (activityValue > 25)
            activityValue = 25;

        return activityValue;
    }

    public double ActivityP75()
    {
        double activityValue;

        if (Type.Contains("coeur"))
            activityValue = (1.5 * (Weight - 70) + 777) / 37.0;

        else if (Type.Contains("osseuse"))
            activityValue = (2 * (Weight - 70) + 770) / 37.0;

        else if (Type.Contains("ventriculographie"))
            activityValue = 25.0;

        else
            throw new ArgumentException("Exam: -- ignored --");

        if (activityValue > 25)
            activityValue = 25;

        return activityValue;
    }


}
