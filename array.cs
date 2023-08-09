namespace Pattern{
    public class Hash{
        public void Hashes(int n){
            for (int i=0; i< n; i++ ){
                string num = "";
                for(int j = 0; j< n; j++){
                    if (j<=i){
                        num += "#";
                    }
                    else {
                        num += "";
                    }
                }
                System.Console.WriteLine(num);
            }
        }
    }
}
