class FeedResult
{
    public double mean { get; set; }
    public double median { get; set; }

    public override string ToString()
    {
        //Hand-coded JSON format; you could also use a Dictionary and JSON serializer
        return "{" + "Mean:" + mean + ",Median:" + median + "}";
    }
}
