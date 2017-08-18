namespace LakeStats
{
    class FeedResult
    {
        public double mean { get; set; }
        public double median { get; set; }
        public int count { get; set; }

        public override string ToString()
        {
            return "{Count: " + count + 
                ",Mean:" + mean + 
                ",Median:" + median + "}";
        }
    }
}
