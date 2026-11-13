public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        var prices = new int[n];
        Array.Fill(prices , int.MaxValue);
        prices[src] = 0;

        for(int i = 0; i <= k; i++){
            var temp = new int [n];
            Array.Copy(prices, temp, n);

            foreach(var flight in flights){
                int from = flight[0];
                int to = flight[1];
                int price = flight[2];

                if (prices[from] == int.MaxValue){
                    continue;
                }
                var newPrice = price + prices[from];

                temp[to] = Math.Min(newPrice, temp[to]);
            }

            prices = temp;
        }

        return prices[dst] == int.MaxValue ? -1 : prices[dst];
    }
}
