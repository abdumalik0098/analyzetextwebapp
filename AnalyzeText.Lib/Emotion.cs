namespace AnalyzeText.Lib
{
    public class Emotion
    {
        public string[] Positive = new string[]
        {
            "well",
            "good",
            "quickly",
            "happy"
        };
        public string[] Negative = new string[]
        {
            "unhappy",
            "sadly",
            "scary",
            "bad"
        };

        public string IsEmotion(string text)
        {
            string res = "";
            int CountPos = 0;
            int CountNeg = 0;
            string text2 = text.ToLower();

            foreach (var item in Positive)
            {
                if (text2.Contains(item))
                {
                    CountPos++;
                }
            }
            foreach (var item in Negative)
            {
                if (text2.Contains(item))
                {
                    CountNeg++;
                }
            }
            if (CountPos > CountNeg)
            {
                res = "POSITIVE";
            }
            else if (CountNeg > CountPos)
            {
                res = "Negative";
            }
            else
            {
                res = "Noun";
            }
            return res;
        }
    }
}