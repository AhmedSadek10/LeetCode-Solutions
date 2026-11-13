public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        int[] commonFreq = new int[26];

        foreach (char c in words[0])
        {
            commonFreq[c - 'a']++;
        }

        for (int i = 1; i < words.Length; i++)
        {
            int[] currentFreq = new int[26];

            foreach (char c in words[i])
            {
                currentFreq[c - 'a']++;
            }

            for (int j = 0; j < 26; j++)
            {
                commonFreq[j] = Math.Min(commonFreq[j], currentFreq[j]);
            }
        }

        var result = new List<string>();

        for (int i = 0; i < 26; i++)
        {
            while (commonFreq[i] > 0)
            {
                result.Add(((char)('a' + i)).ToString());
                commonFreq[i]--;
            }
        }

        return result;
    }
}
