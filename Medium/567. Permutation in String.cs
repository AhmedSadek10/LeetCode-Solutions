public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        var s1Freq = CreateFrequencyMap(s1);
        var windowFreq = CreateFrequencyMap(s2.Substring(0, s1.Length));

        if (AreFrequencyMapsEqual(s1Freq, windowFreq))
        {
            return true;
        }

        for (int i = 0; i < s2.Length - s1.Length; i++)
        {
            RemoveChar(windowFreq, s2[i]);
            AddChar(windowFreq, s2[i + s1.Length]);

            if (AreFrequencyMapsEqual(s1Freq, windowFreq))
            {
                return true;
            }
        }

        return false;
    }

    private Dictionary<char, int> CreateFrequencyMap(string text)
    {
        var frequencyMap = new Dictionary<char, int>();

        foreach (char c in text)
        {
            AddChar(frequencyMap, c);
        }

        return frequencyMap;
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

    private bool AreFrequencyMapsEqual(
        Dictionary<char, int> first,
        Dictionary<char, int> second)
    {
        if (first.Count != second.Count)
        {
            return false;
        }

        foreach (var item in first)
        {
            if (!second.TryGetValue(item.Key, out int count) || count != item.Value)
            {
                return false;
            }
        }

        return true;
    }
}
