namespace MyQueue.Model {
    public class MyEasyDeque<T> {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;

        public MyEasyDeque() {}

        public MyEasyDeque(T data) {
            items.Add(data);
        }

        public void PushBack(T data) {
            items.Insert(0, data);
        }

        public void PushFront(T data) {
            items.Add(data);
        }

        public T PopBack() {
            var item = Tail;
            items.Remove(item);
            return item;
        }

        public T PopFront() {
            var item = Head;
            items.Remove(item);
            return item;
        }

        public T PeekBack() {
            return Tail;
        }

        public T PeekFront() {
            return Head;
        }
    }
}