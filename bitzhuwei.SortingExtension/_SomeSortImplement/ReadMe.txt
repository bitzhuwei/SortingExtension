排序原则
	当两数相等时，不改变其先后顺序
实现原则
	用扩展方法的方式实现对IList<T>（泛型）类型的数列进行排序。
	公共接口与具体实现分离，用partial关键字放到不同的源文件。
	为求效率，不对数列进行是否为null的检查。建议使用list.SomeSort()的方式调用此类库。
排序算法的稳定性：
如果对于数组中出现的任意a[i],a[j](i<j),其中a[i]==a[j]，在进行排序以后a[i]一定出现在a[j]之前，则认为该排序是稳定的。

_BubbleSortImplement.cs
复杂度：O(N^2)
适用情况：
稳定排序：是
递归实现：否
特点：每轮排序，都把最大（小）的数字排到最终的位置。第x（1,2,...,N）轮排序后，索引为N-x的位置已经排好。

_HeapSortImplement.cs
复杂度：O(N log2(N))
适用情况：
稳定排序：否
递归实现：是
特点：

_InsertionSortImplement.cs
复杂度：
适用情况：
稳定排序：是
递归实现：否
特点：

_MergeSortImplement.cs
复杂度：
适用情况：
稳定排序：是
递归实现：是
特点：

_QuickSortImplement.cs
复杂度：O(N log2(N))
适用情况：
稳定排序：否
递归实现：是
特点：每轮排序，把一个数字放到最终的位置

_SelectionSortImplement.cs
复杂度：
适用情况：
稳定排序：否
递归实现：否
特点：

_ShellSortImplement.cs
复杂度：
适用情况：
稳定排序：否
递归实现：否
特点：


