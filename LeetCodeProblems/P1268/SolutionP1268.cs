using System;
using System.Collections.Generic;

namespace LeetCodeProblems.P1268
{
    public class SolutionP1268 : ISolutionP1268
    {
        class TreeNode
        {
            public List<int> ProductIndex = new List<int>();
            public TreeNode[] Children = new TreeNode['z' - 'a' + 1];
        }

        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);

            var root = new TreeNode();

            for (int i = 0; i < products.Length; i++)
            {
                var p = products[i];
                var node = root;
                for (int j = 0; j < p.Length && j<searchWord.Length; j++)
                {
                    var chCode = p[j] - 'a';
                    var nextNode = node.Children[chCode];
                    if (nextNode == null)
                    {
                        nextNode = node.Children[chCode] = new TreeNode();
                    }

                    node = nextNode;
                    node.ProductIndex.Add(i);
                }
            }

            var result = new List<IList<string>>();

            var node2 = root;
            for (var j = 0; j < searchWord.Length; j++)
            {
                var chCode = searchWord[j] - 'a';
                var resultItem = new List<string>();
                if (node2 != null)
                {
                    node2 = node2.Children[chCode];

                    if (node2 != null)
                    {
                        for (var i = 0; i < 3 && i < node2.ProductIndex.Count; i++)
                        {
                            resultItem.Add(products[node2.ProductIndex[i]]);
                        }
                    }
                }

                result.Add(resultItem);
            }


            return result;
        }
    }
}