namespace MyQueue.Model {
    public class MyEasyQueue<T> {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;

        public MyEasyQueue() {}
        public MyEasyQueue(T data) {
            items.Add(data);
        }

        public void Enqueue(T data) {
            items.Insert(0, data);
        }

        public T Dequeue() {
            var item = Head;
            items.Remove(item);
            return item;
        }

        public T Peek() {
            return Head;
        }
    }
}