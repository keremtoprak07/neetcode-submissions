public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        /*positionları sırasıyla al ve timelarını elde et diğer speed arrayini de kullanrak ardından position sıralarını kaybetmeden ilk elemandan başlayarak onu stack a ekle ve diğer 1. indexteki elemanla karşılatır .1. indexteki elemanın pozisyonu daha önde olduğundan eğer timeı daha düşük ise 0. indeteki ile ayrı filo olmak zorundalar onu da stacka ekle ve countu 1 artır .Değilse stacka ekleme sonraki elemana geç.BAşlayalım ilk önce çift for döngüsü ile belirle bakalım.

        */

        Stack<double> s=new Stack<double>();
        List<double> sortedtime=new List<double>();
        Array.Sort(position,speed);

        int length=position.Length;
        for(int i=length-1;i>=0;i--){
            int position1=position[i];
            int speed1=speed[i];
            double time=((double)(target-position1)/speed1);
            sortedtime.Add(time);
            
            }

        s.Push(sortedtime[0]);
        for(int i=1;i<length;i++){
            
            
            if(s.Peek()>=sortedtime[i]){
                continue;

                    



            }
            else{
                s.Push(sortedtime[i]);
            }

            
            
            
        }
        return s.Count;


        }
        
    }

