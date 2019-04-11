using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm {

  [TestClass]
  public class LinkedListTest {

    [TestMethod]
    public void crud() {
      var list = new LinkedList<int>(0,1,2,3,4);
      Assert.AreEqual(1, ++list[0]);
      list.insert(0, 0);
      Assert.AreEqual(6, list.count);
      list.delete(1);
      Assert.AreEqual(5, list.count);
    }

    [TestMethod]
    public void queue() {
      var data = new char[]{'a','b','c'};
      var queue = new LinkedList<char>();
      foreach (var datum in data) {
        queue.enqueue(datum);
      }
      for(int i = 0; i < 3; i++) {
        data[i] = queue.dequeue();
      }
      Assert.AreEqual('a', data[0]);
    }

    [TestMethod]
    public void stack() {
      var data = new char[]{'a','b','c'};
      var stack = new LinkedList<char>();
      foreach (var datum in data) {
        stack.push(datum);
      }
      for(int i = 0; i < 3; i++) {
        data[i] = stack.pop();
      }
      Assert.AreEqual('c', data[0]);
    }
  }
}
