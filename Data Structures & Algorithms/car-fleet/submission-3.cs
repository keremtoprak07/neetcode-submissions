public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {

        int[] road = new int[target];

        for(int i = 0; i < position.Length; i++){
            road[position[i]] = speed[i];
        }

        double time;
        double slowest = 0.0;
        int count = 0;

        for(int i = target - 1; i >= 0; i--){

            if(road[i] == 0){continue;}

            time = (double)(target - i) / road[i];

            if(time > slowest){count++; slowest = time;}

        }
        return count;
    }
}
