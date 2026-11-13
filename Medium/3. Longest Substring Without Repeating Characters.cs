public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var windowFreq = new Dictionary<char, int>();

        int left = 0;
        int res = 0;

        for (int right = 0; right < s.Length; right++)
        {
            AddChar(windowFreq, s[right]);

            while (windowFreq[s[right]] > 1)
            {
                RemoveChar(windowFreq, s[left]);
                left++;
            }

            res = Math.Max(res, right - left + 1);
        }

        return res;
    }

    private void AddChar(Dictionary<char, int> frequencyMap, char c)
    {
        if (!frequencyMap.ContainsKey(c))
        {
            frequencyMap[c] = 0;
        }

        frequencyMap[c]++;
    }

    private void RemoveChar(Dictionary<char, int> frequencyMap, char c)
    {
        frequencyMap[c]--;

        if (frequencyMap[c] == 0)
        {
            frequencyMap.Remove(c);
        }
    }
}
