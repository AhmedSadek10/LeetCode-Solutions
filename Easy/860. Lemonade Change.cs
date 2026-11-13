public class Solution {
    public bool LemonadeChange(int[] bills) {
        
        int countOfFives = 0;
        int countOfTens = 0;

        for (int i = 0; i < bills.Length; i++){
            if (bills[i] == 5){
                countOfFives++;
            }
            if (bills[i] == 10){
                if (countOfFives == 0){
                    return false;
                }
                countOfTens++;
                countOfFives--;
            }
            if(bills[i] == 20){
                if (countOfTens > 0 && countOfFives > 0 ){
                    countOfTens--;
                    countOfFives--;
                }
                else if (countOfFives > 2){
                    countOfFives = countOfFives - 3;
                }
                else {
                    return false;
                }
            }
        }

        return true;
    }
}
