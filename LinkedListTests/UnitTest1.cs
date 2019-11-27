using NUnit.Framework;
using Exercises;
using System;
using System.Collections.Generic;


namespace Tests
{
    public class Tests
    {
        LinkedList ll;
        private string[] data = {"asdf", "zxcv", "qwerty", "abc", "xyz", "aeiou", "foo", "bar", "hello", "world"};
    
        [SetUp]
        public void Init() {

            ll = new LinkedList();
            foreach (var s in data) {
                ll.AddToEnd(s);
            }
        }

        [TestCase("asdf", true)]
        [TestCase("foo", true)]
        [TestCase("world", true)]
        [TestCase("false", false)]
        public void Find(string searchTerm, bool ans) {
            Assert.AreEqual(ans, ll.Find(searchTerm));
        }
        
        [TestCase(2,"qwerty")]
        [TestCase(-1, null)]
        [TestCase(10, null)]
        public void GetNodeAt(int nodeNum, string ans) {
            if (ans != null) {
                Assert.AreEqual(ans, ll.GetNodeAt(nodeNum).Data);
            } else {
                var node = ll.GetNodeAt(nodeNum);
                if (node == null) {
                    Assert.Pass();
                } else {
                    Assert.Fail();
                }
            }
        }

        
        
        [TestCase(10)]
        public void Count(int ans) {
            Assert.AreEqual(ans, ll.Count());
        }

        [Test]
        public void AddToStart() {
            ll.AddToStart("start");

            Assert.AreEqual(11, ll.Count());
            Assert.AreEqual("start", ll.GetNodeAt(0).Data);
        }

        [Test]
        public void AddToEnd() {
            ll.AddToEnd("end");
            
            Assert.AreEqual(11, ll.Count());
            Assert.AreEqual("end", ll.GetNodeAt(10).Data);
        }

        [TestCase("indexFour", 4, 4, 6, "indexFour", "aeiou")]
        [TestCase("indexTwelve", 12, 12, 10, "indexTwelve", null)]
        [TestCase("indexNegative", -1, 4, 6, "xyz", "foo")]
        public void AddNodeAt(string data, int index, int check1, int check2, string dataCheck1, string dataCheck2) {
            ll.AddNodeAt(data, index);
            
            if (dataCheck1 != null) {
                Assert.AreEqual(dataCheck1, ll.GetNodeAt(check1).Data);
            } else {
                var node = ll.GetNodeAt(check1);
                if (node.Data == null) {
                    Assert.Pass();
                } else {
                    Assert.Fail();
                }
            }

            if (dataCheck2 != null) {
                Assert.AreEqual(dataCheck2, ll.GetNodeAt(check2).Data);
            } else {
                var node = ll.GetNodeAt(check2);
                if (node.Data == null) {
                    Assert.Pass();
                } else {
                    Assert.Fail();
                }
            }
        }
        
        [Test]
        public void DeleteNodeAt() {
            ll.DeleteNodeAt(4);
            ll.DeleteNodeAt(100);


            Assert.AreEqual(false, ll.Find("xyz"));
            Assert.AreEqual("aeiou", ll.GetNodeAt(4).Data);
            
        }
    }
    
}
