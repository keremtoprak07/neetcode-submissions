public class LRUCache {
    private int _capacity;
    // DÜZELTME 1: LinkedList yerine LinkedListNode yapıldı
    private Dictionary<int, LinkedListNode<(int key, int value)>> map; 
    private LinkedList<(int key ,int value)> l;

    public LRUCache(int capacity) {
        _capacity = capacity;
        // DÜZELTME 1 Devamı:
        map = new Dictionary<int, LinkedListNode<(int key,int value)>>(capacity);
        l = new LinkedList<(int key,int value)>();  
    }
    
    public int Get(int key) {
        // DÜZELTME 2: Get içindeki out parametresi de LinkedListNode yapıldı
        if(map.TryGetValue(key, out LinkedListNode<(int key,int value)> node)) {
            l.Remove(node);
            l.AddFirst(node);
            return node.Value.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (map.TryGetValue(key, out LinkedListNode<(int key, int value)> node)) {
            node.Value = (key, value);
            l.Remove(node);
            l.AddFirst(node);
        }
        else {
            if (map.Count >= _capacity) {
                // DÜZELTME 3: Sınıftaki liste (l) ile karışmaması için adı lastNode yapıldı
                var lastNode = l.Last; 
                
                map.Remove(lastNode.Value.key);
                l.RemoveLast();
            }
            
            var newNode = new LinkedListNode<(int key, int value)>((key, value));
            l.AddFirst(newNode);
            map[key] = newNode;
        }
    }
}