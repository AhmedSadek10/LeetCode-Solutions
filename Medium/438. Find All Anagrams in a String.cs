public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var result = new List<int>();

        if (p.Length > s.Length)
        {
            return result;
        }

        var pFreq = CreateFrequencyMap(p);
        var windowFreq = CreateFrequencyMap(s.Substring(0, p.Length));

        if (AreFrequencyMapsEqual(windowFreq, pFreq))
        {
            result.Add(0);
        }

        for (int i = 0; i < s.Length - p.Length; i++)
        {
            RemoveChar(windowFreq, s[i]);
            AddChar(windowFreq, s[i + p.Length]);

            if (AreFrequencyMapsEqual(windowFreq, pFreq))
            {
                result.Add(i + 1);
            }
        }

        return result;
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
