public class RandomizedSet {
    public Random random = new Random();
    Dictionary<int,int> dict= new Dictionary<int, int>();
    List<int> list=new List<int>();
    public RandomizedSet() {
        
        
    }
    
    public bool Insert(int value) {
        if(dict.ContainsKey(value))
        {
            return false;
        }
        else 
        {
            list.Add(value);
            dict[value]=list.Count-1;
            return true;
        }
    }
    
    public bool Remove(int value) {
        if(!dict.ContainsKey(value))
        {
            return false;
        }
        else
        {
            int index=dict[value];
            int lastValue=list[list.Count-1];
            list[index]=lastValue;
            dict[lastValue]=index;
            list.RemoveAt(list.Count-1);
            dict.Remove(value);
            return true;
        }
    }
    
    public int GetRandom() {
         int randomIndex=random.Next(0,list.Count);
        return list[randomIndex];
    }
}
