class Solution {
    public int numJewelsInStones(String jewels, String stones) {
        HashSet<Character> set = new HashSet <>();
        int res = 0;
        for(char c : jewels.toCharArray()){
            set.add(c);
        }
        for (char c : stones.toCharArray()){
            if (set.contains(c))
                res++;
        }
        return res;
    }
}
