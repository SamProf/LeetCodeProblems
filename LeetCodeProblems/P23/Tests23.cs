using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace LeetCodeProblems.P23
{
    [TestFixture()]
    public class Tests23
    {
        [Test]
        public void Test1()
        {
            var rnd = new Random();
            Test(Enumerable.Range(0, 10).Select(i =>
                Enumerable.Range(0, 10).Select(j => rnd.Next(0, 100)).OrderBy(k => k).ToArray()
            ).ToArray());
        }


        protected void Test(int[][] arrays)
        {
            var lists = new Solution23.ListNode[arrays.Length];
            for (int i = 0; i < lists.Length; i++)
            {
                var header = new Solution23.ListNode(0);
                var current = header;
                foreach (var i1 in arrays[i])
                {
                    current.next = new Solution23.ListNode(i1);
                    current = current.next;
                }

                lists[i] = header.next;
            }

            var res = new Solution23().MergeKLists(lists);
            var resList = new List<int>();
            while (res != null)
            {
                resList.Add(res.val);
                res = res.next;
            }

            Console.Write(string.Join(", ", resList));
            Assert.AreEqual(arrays.SelectMany(i => i).OrderBy(i => i).ToArray(), resList.ToArray());
        }
    }
}