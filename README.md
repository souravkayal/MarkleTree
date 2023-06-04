# MarkleTree

<br/>
<img src='https://github.com/souravkayal/MarkleTree/assets/6651731/5d281958-2ac5-455e-910d-05d7e46dd3e5'/>
<br/>

A simple Merkle tree implementation using c#. <br/>

A merkle tree is hash based tree invented by Ralph Merkle in 1979. It is also known as hash tree because the leaf node of tree holds the actual data where non leaf node holds hash of it's children node. It's a binary tree in nature and has wide usage in various fields of computer science and cryptography.

# Few real use case of Merkle tree <br/>
<b> Cryptocurrency </b> <br/><br/>
Cryptocurrency hevily use Merkle tree to generate hash to a certain blocks in blockchain. Here is one implementation of Merkle tree in Neo blockchain - <br/>
https://github.com/neo-project/neo/blob/master/src/Neo/Cryptography/MerkleTree.cs

<br/><br/>
<b> Integrity verification </b><br/><br/>
Merkle trees provide a way to efficiently verify the integrity of data by comparing hash values. By comparing only a few hash values at the top of the tree (root), one can determine if the entire dataset is consistent and unchanged.

<br/><br/>
<b> To find difference in Git </b> <br/><br/>
Git uses merkle tree to detect and identify the differences. The concept of finding difference can be follow here - https://www.youtube.com/watch?v=P6jD966jzlk

# How to use !
Just call the Merkle tree object by passing a list of string which will act as data node of tree
```cs

public static void Main(String[]args)
{
            var items = new List<string> 
            {
                "item-1",
                "item-2",
                "item-3",
                "item-4"
            };

            MerkleTree tree = new MerkleTree(items);

            Console.WriteLine($"Hash of the root node- {tree.Root.Hash}");

            Console.ReadLine();
}

```        
<b> Output </b> <br/>

![image](https://github.com/souravkayal/MarkleTree/assets/6651731/446c4dec-bdbb-413c-acec-8a0947e532e1)
       







