# Trees To Do 1

Let’s build a basic Binary Search Tree. These challenges start with the following reference definitions:

```
class BTNode {
    constructor(value) {
        this.val = value;
        this.left = null;
        this.right = null;
    }
}
class BST {
    constructor() {
        this.root = null;
    }
    // add methods here...
}
```

## BST: Add
Create an **add(val)** method on the BST object to add new value to the tree. This entails creating a **BTNode** with this value and connecting it at the appropriate place in the tree. Unless specified otherwise, BSTs can contain duplicate values.



## BST: Contains
Create a **contains(val)** method on **BST** that returns whether the tree contains a given value. Take advantage of the BST structure to make this a much more rapid operation than **SList.contains()** would be.



## BST: Min
Create a **min()** method on the BST class that returns the smallest value found in the **BST**.



## BST: Max
Create a **max()** BST method that returns the largest value contained in the binary search tree.



## BST: Size
Write a **size()** method that returns the number of nodes (values) contained in the tree.



## BST: Is Empty
Create an **isEmpty()** method to return whether the BST is empty (whether it contains no values).

