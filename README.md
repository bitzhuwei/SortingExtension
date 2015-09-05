# SortingExtension
集成了几种常用排序算法。
<p>本文尽量用简单直白通俗易懂深入浅出详实通透的手法将常见的几种排序算法的原理和代码呈现给众位，欢迎批评指教！</p>
<p>为简单起见，本文所述排序默认都以升序排序为例。（当然最后给出的源代码是升序降序都有的）</p>
<p>冒泡排序(Bubble sort)</p>
<p>冒泡排序每轮都得到数列中的最大值，同时将其置于最后，然后对剩余部分进行排序。</p>
<div class="cnblogs_code" onclick="cnblogs_code_show('dcab5552-8b65-4446-9717-69af5f6c1213')"><img id="code_img_closed_dcab5552-8b65-4446-9717-69af5f6c1213" class="code_img_closed" src="http://images.cnblogs.com/OutliningIndicators/ContractedBlock.gif" alt="" /><img id="code_img_opened_dcab5552-8b65-4446-9717-69af5f6c1213" class="code_img_opened" style="display: none;" onclick="cnblogs_code_hide('dcab5552-8b65-4446-9717-69af5f6c1213',event)" src="http://images.cnblogs.com/OutliningIndicators/ExpandedBlockStart.gif" alt="" /><span class="cnblogs_code_collapse">Bubble sort</span>
<div id="cnblogs_code_open_dcab5552-8b65-4446-9717-69af5f6c1213" class="cnblogs_code_hide">
<pre><span style="color: #008080;"> 1</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 2</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 当某轮比较没有发生移动时，就可以确定排序完成了
</span><span style="color: #008080;"> 3</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 4</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 5</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 6</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;&lt;/param&gt;</span>
<span style="color: #008080;"> 7</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> BubbleSortAscending1&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;"> 8</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 9</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">10</span>             <span style="color: #0000ff;">bool</span><span style="color: #000000;"> exchanges;
</span><span style="color: #008080;">11</span>             <span style="color: #0000ff;">do</span>
<span style="color: #008080;">12</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">13</span>                 exchanges = <span style="color: #0000ff;">false</span><span style="color: #000000;">;
</span><span style="color: #008080;">14</span>                 <span style="color: #0000ff;">for</span> (<span style="color: #0000ff;">int</span> i = <span style="color: #800080;">0</span>; i &lt; arr.Count - <span style="color: #800080;">1</span>; i++<span style="color: #000000;">)
</span><span style="color: #008080;">15</span> <span style="color: #000000;">                {
</span><span style="color: #008080;">16</span>                     <span style="color: #0000ff;">if</span> (arr[i].CompareTo(arr[i + <span style="color: #800080;">1</span>]) &gt; <span style="color: #800080;">0</span><span style="color: #000000;">)
</span><span style="color: #008080;">17</span> <span style="color: #000000;">                    {
</span><span style="color: #008080;">18</span>                         T temp =<span style="color: #000000;"> arr[i];
</span><span style="color: #008080;">19</span>                         arr[i] = arr[i + <span style="color: #800080;">1</span><span style="color: #000000;">];
</span><span style="color: #008080;">20</span>                         arr[i + <span style="color: #800080;">1</span>] =<span style="color: #000000;"> temp;
</span><span style="color: #008080;">21</span>                         <span style="color: #008000;">//</span><span style="color: #008000;">当某轮比较没有发生移动时，就可以确定排序完成了
</span><span style="color: #008080;">22</span>                         <span style="color: #008000;">//</span><span style="color: #008000;">否则应该继续排序</span>
<span style="color: #008080;">23</span>                         exchanges = <span style="color: #0000ff;">true</span><span style="color: #000000;">;
</span><span style="color: #008080;">24</span> <span style="color: #000000;">                    }
</span><span style="color: #008080;">25</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">26</span>             } <span style="color: #0000ff;">while</span><span style="color: #000000;"> (exchanges);
</span><span style="color: #008080;">27</span>         }</pre>
</div>
</div>
<p>&nbsp;</p>
<p>堆排序(Heap sort)</p>
<p>堆排序总是建立这样一个二叉树：其父结点总大于其子结点。</p>
<p>首先建堆。</p>
<p>每轮将根结点与最后一个结点互换，然后对剩余部分建堆。</p>
<div class="cnblogs_code" onclick="cnblogs_code_show('cfd145b0-f51d-4bc5-9683-108bae4e161e')"><img id="code_img_closed_cfd145b0-f51d-4bc5-9683-108bae4e161e" class="code_img_closed" src="http://images.cnblogs.com/OutliningIndicators/ContractedBlock.gif" alt="" /><img id="code_img_opened_cfd145b0-f51d-4bc5-9683-108bae4e161e" class="code_img_opened" style="display: none;" onclick="cnblogs_code_hide('cfd145b0-f51d-4bc5-9683-108bae4e161e',event)" src="http://images.cnblogs.com/OutliningIndicators/ExpandedBlockStart.gif" alt="" /><span class="cnblogs_code_collapse">Heap sort</span>
<div id="cnblogs_code_open_cfd145b0-f51d-4bc5-9683-108bae4e161e" class="cnblogs_code_hide">
<pre><span style="color: #008080;"> 1</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> HeapSortAscending1&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;"> 2</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 3</span> <span style="color: #000000;">        {
</span><span style="color: #008080;"> 4</span>             <span style="color: #0000ff;">for</span> (<span style="color: #0000ff;">int</span> i = arr.Count / <span style="color: #800080;">2</span> - <span style="color: #800080;">1</span>; i &gt;= <span style="color: #800080;">0</span>; i--<span style="color: #000000;">)
</span><span style="color: #008080;"> 5</span> <span style="color: #000000;">            {
</span><span style="color: #008080;"> 6</span> <span style="color: #000000;">                arr.HeapAdjustAscending1(i, arr.Count);
</span><span style="color: #008080;"> 7</span> <span style="color: #000000;">            }
</span><span style="color: #008080;"> 8</span>             <span style="color: #0000ff;">for</span> (<span style="color: #0000ff;">int</span> i = arr.Count - <span style="color: #800080;">1</span>; i &gt; <span style="color: #800080;">0</span>; i--<span style="color: #000000;">)
</span><span style="color: #008080;"> 9</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">10</span>                 T temp = arr[<span style="color: #800080;">0</span><span style="color: #000000;">];
</span><span style="color: #008080;">11</span>                 arr[<span style="color: #800080;">0</span>] =<span style="color: #000000;"> arr[i];
</span><span style="color: #008080;">12</span>                 arr[i] =<span style="color: #000000;"> temp;
</span><span style="color: #008080;">13</span>                 arr.HeapAdjustAscending1(<span style="color: #800080;">0</span><span style="color: #000000;">, i);
</span><span style="color: #008080;">14</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">15</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">16</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> HeapAdjustAscending1&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt; arr, <span style="color: #0000ff;">int</span> nonLeafNodeToBeAdjusted, <span style="color: #0000ff;">int</span><span style="color: #000000;"> unRangedCount)
</span><span style="color: #008080;">17</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T:IComparable
</span><span style="color: #008080;">18</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">19</span>             <span style="color: #0000ff;">int</span> leftChild = nonLeafNodeToBeAdjusted * <span style="color: #800080;">2</span> + <span style="color: #800080;">1</span><span style="color: #000000;">;
</span><span style="color: #008080;">20</span>             <span style="color: #0000ff;">int</span> rightChild = nonLeafNodeToBeAdjusted * <span style="color: #800080;">2</span> + <span style="color: #800080;">2</span><span style="color: #000000;">;
</span><span style="color: #008080;">21</span>             <span style="color: #0000ff;">int</span> max =<span style="color: #000000;"> nonLeafNodeToBeAdjusted;
</span><span style="color: #008080;">22</span>             <span style="color: #0000ff;">if</span> (nonLeafNodeToBeAdjusted &lt; unRangedCount / <span style="color: #800080;">2</span>) <span style="color: #008000;">//</span><span style="color: #008000;"> 是非叶节点</span>
<span style="color: #008080;">23</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">24</span>                 <span style="color: #0000ff;">if</span> (leftChild &lt; unRangedCount &amp;&amp; arr[leftChild].CompareTo(arr[max]) &gt; <span style="color: #800080;">0</span><span style="color: #000000;">)
</span><span style="color: #008080;">25</span>                 { max =<span style="color: #000000;"> leftChild; }
</span><span style="color: #008080;">26</span>                 <span style="color: #0000ff;">if</span> (rightChild &lt; unRangedCount &amp;&amp; arr[rightChild].CompareTo(arr[max]) &gt; <span style="color: #800080;">0</span><span style="color: #000000;">)
</span><span style="color: #008080;">27</span>                 { max =<span style="color: #000000;"> rightChild; }
</span><span style="color: #008080;">28</span>                 <span style="color: #0000ff;">if</span> (max!=<span style="color: #000000;">nonLeafNodeToBeAdjusted)
</span><span style="color: #008080;">29</span> <span style="color: #000000;">                {
</span><span style="color: #008080;">30</span>                     T temp =<span style="color: #000000;"> arr[max];
</span><span style="color: #008080;">31</span>                     arr[max] =<span style="color: #000000;"> arr[nonLeafNodeToBeAdjusted];
</span><span style="color: #008080;">32</span>                     arr[nonLeafNodeToBeAdjusted] =<span style="color: #000000;"> temp;
</span><span style="color: #008080;">33</span> <span style="color: #000000;">                    arr.HeapAdjustAscending1(max, unRangedCount);
</span><span style="color: #008080;">34</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">35</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">36</span>         }</pre>
</div>
</div>
<p>&nbsp;</p>
<p>插入排序(Insertion sort)</p>
<p>每轮将数列未排序部分的第一个数字插入已排好的部分。</p>
<div class="cnblogs_code" onclick="cnblogs_code_show('a8c9632e-c1d1-45f2-a8b5-58a9f4c6114b')"><img id="code_img_closed_a8c9632e-c1d1-45f2-a8b5-58a9f4c6114b" class="code_img_closed" src="http://images.cnblogs.com/OutliningIndicators/ContractedBlock.gif" alt="" /><img id="code_img_opened_a8c9632e-c1d1-45f2-a8b5-58a9f4c6114b" class="code_img_opened" style="display: none;" onclick="cnblogs_code_hide('a8c9632e-c1d1-45f2-a8b5-58a9f4c6114b',event)" src="http://images.cnblogs.com/OutliningIndicators/ExpandedBlockStart.gif" alt="" /><span class="cnblogs_code_collapse">Insertion sort</span>
<div id="cnblogs_code_open_a8c9632e-c1d1-45f2-a8b5-58a9f4c6114b" class="cnblogs_code_hide">
<pre><span style="color: #008080;"> 1</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 2</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 插入排序算法
</span><span style="color: #008080;"> 3</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 4</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 5</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 6</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;&lt;/param&gt;</span>
<span style="color: #008080;"> 7</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> InsertionSortAscending1&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;"> 8</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 9</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">10</span>             <span style="color: #0000ff;">for</span> (<span style="color: #0000ff;">int</span> i = <span style="color: #800080;">1</span>; i &lt; arr.Count; i++<span style="color: #000000;">)
</span><span style="color: #008080;">11</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">12</span>                 T temp =<span style="color: #000000;"> arr[i];
</span><span style="color: #008080;">13</span>                 <span style="color: #0000ff;">int</span> j =<span style="color: #000000;"> i;
</span><span style="color: #008080;">14</span>                 <span style="color: #0000ff;">while</span> ((j &gt; <span style="color: #800080;">0</span>) &amp;&amp; (temp.CompareTo(arr[j - <span style="color: #800080;">1</span>]) &lt; <span style="color: #800080;">0</span><span style="color: #000000;">))
</span><span style="color: #008080;">15</span> <span style="color: #000000;">                {
</span><span style="color: #008080;">16</span>                     arr[j] = arr[j - <span style="color: #800080;">1</span><span style="color: #000000;">];
</span><span style="color: #008080;">17</span>                     j--<span style="color: #000000;">;
</span><span style="color: #008080;">18</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">19</span>                 arr[j] =<span style="color: #000000;"> temp;
</span><span style="color: #008080;">20</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">21</span>         }</pre>
</div>
</div>
<p>&nbsp;</p>
<p>归并排序(Merge sort)</p>
<p>递归方法。将数列均分为前后两部分，分别对其进行归并排序，然后将分别完成排序的前后两部分归并。</p>
<div class="cnblogs_code" onclick="cnblogs_code_show('7021ff7d-1d09-4eee-ac0d-32784fffa0ee')"><img id="code_img_closed_7021ff7d-1d09-4eee-ac0d-32784fffa0ee" class="code_img_closed" src="http://images.cnblogs.com/OutliningIndicators/ContractedBlock.gif" alt="" /><img id="code_img_opened_7021ff7d-1d09-4eee-ac0d-32784fffa0ee" class="code_img_opened" style="display: none;" onclick="cnblogs_code_hide('7021ff7d-1d09-4eee-ac0d-32784fffa0ee',event)" src="http://images.cnblogs.com/OutliningIndicators/ExpandedBlockStart.gif" alt="" /><span class="cnblogs_code_collapse">Merge sort</span>
<div id="cnblogs_code_open_7021ff7d-1d09-4eee-ac0d-32784fffa0ee" class="cnblogs_code_hide">
<pre><span style="color: #008080;"> 1</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 2</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 归并排序，自顶向下的方法
</span><span style="color: #008080;"> 3</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 4</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 5</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 6</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;&lt;/param&gt;</span>
<span style="color: #008080;"> 7</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> MergeSortAscending1&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;"> 8</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 9</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">10</span>             MergeSortAscending1_Split(arr, <span style="color: #800080;">0</span>, arr.Count - <span style="color: #800080;">1</span><span style="color: #000000;">);
</span><span style="color: #008080;">11</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">12</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> MergeSortAscending1_Split&lt;T&gt;(IList&lt;T&gt; arr, <span style="color: #0000ff;">int</span> first, <span style="color: #0000ff;">int</span><span style="color: #000000;"> last)
</span><span style="color: #008080;">13</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">14</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">15</span>             <span style="color: #0000ff;">if</span> (first &lt;<span style="color: #000000;"> last)
</span><span style="color: #008080;">16</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">17</span>                 <span style="color: #0000ff;">int</span> mid = (first + last) / <span style="color: #800080;">2</span><span style="color: #000000;">;
</span><span style="color: #008080;">18</span> <span style="color: #000000;">                MergeSortAscending1_Split(arr, first, mid);
</span><span style="color: #008080;">19</span>                 MergeSortAscending1_Split(arr, mid + <span style="color: #800080;">1</span><span style="color: #000000;">, last);
</span><span style="color: #008080;">20</span> <span style="color: #000000;">                MergeSortAscending1_Combine(arr, first, mid, last);
</span><span style="color: #008080;">21</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">22</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">23</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">24</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 将两个有序的左右子表（以mid区分），合并成一个有序的表
</span><span style="color: #008080;">25</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">26</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">27</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;&lt;/param&gt;</span>
<span style="color: #008080;">28</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="first"&gt;&lt;/param&gt;</span>
<span style="color: #008080;">29</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="mid"&gt;&lt;/param&gt;</span>
<span style="color: #008080;">30</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="last"&gt;&lt;/param&gt;</span>
<span style="color: #008080;">31</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> MergeSortAscending1_Combine&lt;T&gt;(IList&lt;T&gt; arr, <span style="color: #0000ff;">int</span> first, <span style="color: #0000ff;">int</span> mid, <span style="color: #0000ff;">int</span><span style="color: #000000;"> last)
</span><span style="color: #008080;">32</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">33</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">34</span>             <span style="color: #0000ff;">int</span> indexA = first;<span style="color: #008000;">//</span><span style="color: #008000;">左侧子表的起始位置</span>
<span style="color: #008080;">35</span>             <span style="color: #0000ff;">int</span> indexB = mid + <span style="color: #800080;">1</span>;<span style="color: #008000;">//</span><span style="color: #008000;">右侧子表的起始位置
</span><span style="color: #008080;">36</span>             <span style="color: #008000;">//</span><span style="color: #008000;">声明数组（暂存左右子表的所有有序数列）
</span><span style="color: #008080;">37</span>             <span style="color: #008000;">//</span><span style="color: #008000;">长度等于左右子表的长度之和。</span>
<span style="color: #008080;">38</span>             IList&lt;T&gt; tempList = <span style="color: #0000ff;">new</span> List&lt;T&gt;<span style="color: #000000;">(arr.AsEnumerable());
</span><span style="color: #008080;">39</span> 
<span style="color: #008080;">40</span>             <span style="color: #0000ff;">int</span> tempIndex = <span style="color: #800080;">0</span><span style="color: #000000;">;
</span><span style="color: #008080;">41</span>             <span style="color: #008000;">//</span><span style="color: #008000;">进行左右子表的遍历，如果其中有一个子表遍历完，则跳出循环</span>
<span style="color: #008080;">42</span>             <span style="color: #0000ff;">while</span> (indexA &lt;= mid &amp;&amp; indexB &lt;=<span style="color: #000000;"> last)
</span><span style="color: #008080;">43</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">44</span>                 <span style="color: #008000;">//</span><span style="color: #008000;">此时左子表的数 &lt;= 右子表的数</span>
<span style="color: #008080;">45</span>                 <span style="color: #0000ff;">if</span> (arr[indexA].CompareTo(arr[indexB]) &lt;= <span style="color: #800080;">0</span><span style="color: #000000;">)
</span><span style="color: #008080;">46</span>                 {<span style="color: #008000;">//</span><span style="color: #008000;">将左子表的数放入暂存数组中，遍历左子表下标++</span>
<span style="color: #008080;">47</span>                     tempList[tempIndex++] = arr[indexA++<span style="color: #000000;">];
</span><span style="color: #008080;">48</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">49</span>                 <span style="color: #0000ff;">else</span><span style="color: #008000;">//</span><span style="color: #008000;">此时左子表的数 &gt; 右子表的数</span>
<span style="color: #008080;">50</span>                 {<span style="color: #008000;">//</span><span style="color: #008000;">将右子表的数放入暂存数组中，遍历右子表下标++</span>
<span style="color: #008080;">51</span>                     tempList[tempIndex++] = arr[indexB++<span style="color: #000000;">];
</span><span style="color: #008080;">52</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">53</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">54</span>             <span style="color: #008000;">//</span><span style="color: #008000;">有一侧子表遍历完后，跳出循环，
</span><span style="color: #008080;">55</span>             <span style="color: #008000;">//</span><span style="color: #008000;">将另外一侧子表剩下的数一次放入暂存数组中（有序）</span>
<span style="color: #008080;">56</span>             <span style="color: #0000ff;">while</span> (indexA &lt;=<span style="color: #000000;"> mid)
</span><span style="color: #008080;">57</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">58</span>                 tempList[tempIndex++] = arr[indexA++<span style="color: #000000;">];
</span><span style="color: #008080;">59</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">60</span>             <span style="color: #0000ff;">while</span> (indexB &lt;=<span style="color: #000000;"> last)
</span><span style="color: #008080;">61</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">62</span>                 tempList[tempIndex++] = arr[indexB++<span style="color: #000000;">];
</span><span style="color: #008080;">63</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">64</span>             <span style="color: #008000;">//</span><span style="color: #008000;">将暂存数组中有序的数列写入目标数组的指定位置，
</span><span style="color: #008080;">65</span>             <span style="color: #008000;">//</span><span style="color: #008000;">使进行归并的数组段有序</span>
<span style="color: #008080;">66</span>             tempIndex = <span style="color: #800080;">0</span><span style="color: #000000;">;
</span><span style="color: #008080;">67</span>             <span style="color: #0000ff;">for</span> (<span style="color: #0000ff;">int</span> i = first; i &lt;= last; i++<span style="color: #000000;">)
</span><span style="color: #008080;">68</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">69</span>                 arr[i] = tempList[tempIndex++<span style="color: #000000;">];
</span><span style="color: #008080;">70</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">71</span>         }</pre>
</div>
</div>
<p>&nbsp;</p>
<p>快速排序(Quick sort)</p>
<p>选择一个数（比如第一个），依次右、左、右、左地将它右侧比它小的与之互换，将它左侧比它大的与之互换，最后这个数就排好了。</p>
<p>分别对这个数左右两部分进行快速排序。</p>
<div class="cnblogs_code" onclick="cnblogs_code_show('77a3b70c-76cc-4657-90e1-b2a4ac043993')"><img id="code_img_closed_77a3b70c-76cc-4657-90e1-b2a4ac043993" class="code_img_closed" src="http://images.cnblogs.com/OutliningIndicators/ContractedBlock.gif" alt="" /><img id="code_img_opened_77a3b70c-76cc-4657-90e1-b2a4ac043993" class="code_img_opened" style="display: none;" onclick="cnblogs_code_hide('77a3b70c-76cc-4657-90e1-b2a4ac043993',event)" src="http://images.cnblogs.com/OutliningIndicators/ExpandedBlockStart.gif" alt="" /><span class="cnblogs_code_collapse">Quick sort</span>
<div id="cnblogs_code_open_77a3b70c-76cc-4657-90e1-b2a4ac043993" class="cnblogs_code_hide">
<pre><span style="color: #008080;"> 1</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 2</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 快速排序算法
</span><span style="color: #008080;"> 3</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 4</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 5</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 6</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;&lt;/param&gt;</span>
<span style="color: #008080;"> 7</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> QuickSortAscending1&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;"> 8</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 9</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">10</span>             QuickSortAscending1_Do(arr, <span style="color: #800080;">0</span>, <span style="color: #800080;">0</span>, arr.Count - <span style="color: #800080;">1</span><span style="color: #000000;">);
</span><span style="color: #008080;">11</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">12</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> QuickSortAscending1_Do&lt;T&gt;(IList&lt;T&gt; arr, <span style="color: #0000ff;">int</span> indexOfRightPlaceToFind, <span style="color: #0000ff;">int</span> first, <span style="color: #0000ff;">int</span><span style="color: #000000;"> last)
</span><span style="color: #008080;">13</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">14</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">15</span>             <span style="color: #0000ff;">if</span> (first &lt;<span style="color: #000000;"> last)
</span><span style="color: #008080;">16</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">17</span>                 <span style="color: #0000ff;">int</span> rightPlace =<span style="color: #000000;"> QuickSortAscending1_Find(indexOfRightPlaceToFind, arr, first, last);
</span><span style="color: #008080;">18</span>                 <span style="color: #0000ff;">if</span> (first + <span style="color: #800080;">1</span> &lt;<span style="color: #000000;"> last)
</span><span style="color: #008080;">19</span> <span style="color: #000000;">                {
</span><span style="color: #008080;">20</span>                     QuickSortAscending1_Do(arr, first, first, rightPlace - <span style="color: #800080;">1</span><span style="color: #000000;">);
</span><span style="color: #008080;">21</span>                     QuickSortAscending1_Do(arr, rightPlace + <span style="color: #800080;">1</span>, rightPlace + <span style="color: #800080;">1</span><span style="color: #000000;">, last);
</span><span style="color: #008080;">22</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">23</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">24</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">25</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">int</span> QuickSortAscending1_Find&lt;T&gt;(<span style="color: #0000ff;">int</span> indexOfRightPlaceToFind, IList&lt;T&gt; arr, <span style="color: #0000ff;">int</span> first, <span style="color: #0000ff;">int</span><span style="color: #000000;"> last)
</span><span style="color: #008080;">26</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">27</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">28</span>             <span style="color: #0000ff;">bool</span> searchRight = <span style="color: #0000ff;">true</span><span style="color: #000000;">;
</span><span style="color: #008080;">29</span>             <span style="color: #0000ff;">int</span> indexOfLeftSearch =<span style="color: #000000;"> first;
</span><span style="color: #008080;">30</span>             <span style="color: #0000ff;">int</span> indexOfRightSearch =<span style="color: #000000;"> last;
</span><span style="color: #008080;">31</span>             <span style="color: #0000ff;">do</span>
<span style="color: #008080;">32</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">33</span>                 <span style="color: #0000ff;">if</span><span style="color: #000000;"> (searchRight)
</span><span style="color: #008080;">34</span> <span style="color: #000000;">                {
</span><span style="color: #008080;">35</span>                     <span style="color: #0000ff;">while</span> (arr[indexOfRightPlaceToFind].CompareTo(arr[indexOfRightSearch]) &lt;= <span style="color: #800080;">0</span><span style="color: #000000;">)
</span><span style="color: #008080;">36</span> <span style="color: #000000;">                    {
</span><span style="color: #008080;">37</span>                         indexOfRightSearch--<span style="color: #000000;">;
</span><span style="color: #008080;">38</span>                         <span style="color: #0000ff;">if</span> (indexOfRightPlaceToFind ==<span style="color: #000000;"> indexOfRightSearch)
</span><span style="color: #008080;">39</span> <span style="color: #000000;">                        {
</span><span style="color: #008080;">40</span>                             searchRight = <span style="color: #0000ff;">false</span><span style="color: #000000;">;
</span><span style="color: #008080;">41</span>                             <span style="color: #0000ff;">break</span><span style="color: #000000;">;
</span><span style="color: #008080;">42</span> <span style="color: #000000;">                        }
</span><span style="color: #008080;">43</span> <span style="color: #000000;">                    }
</span><span style="color: #008080;">44</span>                     <span style="color: #0000ff;">if</span><span style="color: #000000;"> (searchRight)
</span><span style="color: #008080;">45</span> <span style="color: #000000;">                    {
</span><span style="color: #008080;">46</span>                         T temp =<span style="color: #000000;"> arr[indexOfRightPlaceToFind];
</span><span style="color: #008080;">47</span>                         arr[indexOfRightPlaceToFind] =<span style="color: #000000;"> arr[indexOfRightSearch];
</span><span style="color: #008080;">48</span>                         arr[indexOfRightSearch] =<span style="color: #000000;"> temp;
</span><span style="color: #008080;">49</span>                         indexOfRightPlaceToFind =<span style="color: #000000;"> indexOfRightSearch;
</span><span style="color: #008080;">50</span>                         searchRight = <span style="color: #0000ff;">false</span><span style="color: #000000;">;
</span><span style="color: #008080;">51</span> <span style="color: #000000;">                    }
</span><span style="color: #008080;">52</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">53</span>                 <span style="color: #0000ff;">else</span>
<span style="color: #008080;">54</span> <span style="color: #000000;">                {
</span><span style="color: #008080;">55</span>                     <span style="color: #0000ff;">while</span> (arr[indexOfRightPlaceToFind].CompareTo(arr[indexOfLeftSearch]) &gt;= <span style="color: #800080;">0</span><span style="color: #000000;">)
</span><span style="color: #008080;">56</span> <span style="color: #000000;">                    {
</span><span style="color: #008080;">57</span>                         indexOfLeftSearch++<span style="color: #000000;">;
</span><span style="color: #008080;">58</span>                         <span style="color: #0000ff;">if</span> (indexOfRightPlaceToFind ==<span style="color: #000000;"> indexOfLeftSearch)
</span><span style="color: #008080;">59</span> <span style="color: #000000;">                        {
</span><span style="color: #008080;">60</span>                             searchRight = <span style="color: #0000ff;">true</span><span style="color: #000000;">;
</span><span style="color: #008080;">61</span>                             <span style="color: #0000ff;">break</span><span style="color: #000000;">;
</span><span style="color: #008080;">62</span> <span style="color: #000000;">                        }
</span><span style="color: #008080;">63</span> <span style="color: #000000;">                    }
</span><span style="color: #008080;">64</span>                     <span style="color: #0000ff;">if</span> (!<span style="color: #000000;">searchRight)
</span><span style="color: #008080;">65</span> <span style="color: #000000;">                    {
</span><span style="color: #008080;">66</span>                         T temp =<span style="color: #000000;"> arr[indexOfRightPlaceToFind];
</span><span style="color: #008080;">67</span>                         arr[indexOfRightPlaceToFind] =<span style="color: #000000;"> arr[indexOfLeftSearch];
</span><span style="color: #008080;">68</span>                         arr[indexOfLeftSearch] =<span style="color: #000000;"> temp;
</span><span style="color: #008080;">69</span>                         indexOfRightPlaceToFind =<span style="color: #000000;"> indexOfLeftSearch;
</span><span style="color: #008080;">70</span>                         searchRight = <span style="color: #0000ff;">true</span><span style="color: #000000;">;
</span><span style="color: #008080;">71</span> <span style="color: #000000;">                    }
</span><span style="color: #008080;">72</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">73</span>             } <span style="color: #0000ff;">while</span> (indexOfLeftSearch &lt; indexOfRightPlaceToFind || indexOfRightPlaceToFind &lt;<span style="color: #000000;"> indexOfRightSearch);
</span><span style="color: #008080;">74</span>             <span style="color: #0000ff;">return</span><span style="color: #000000;"> indexOfRightPlaceToFind;
</span><span style="color: #008080;">75</span>         }</pre>
</div>
</div>
<p>&nbsp;</p>
<p>选择排序(Selection sort)</p>
<p>每轮找到最小的数，与未排序部分的第一个互换。</p>
<div class="cnblogs_code" onclick="cnblogs_code_show('6fa8f779-25c4-44c3-adb4-9b55487f83ed')"><img id="code_img_closed_6fa8f779-25c4-44c3-adb4-9b55487f83ed" class="code_img_closed" src="http://images.cnblogs.com/OutliningIndicators/ContractedBlock.gif" alt="" /><img id="code_img_opened_6fa8f779-25c4-44c3-adb4-9b55487f83ed" class="code_img_opened" style="display: none;" onclick="cnblogs_code_hide('6fa8f779-25c4-44c3-adb4-9b55487f83ed',event)" src="http://images.cnblogs.com/OutliningIndicators/ExpandedBlockStart.gif" alt="" /><span class="cnblogs_code_collapse">Selection sort</span>
<div id="cnblogs_code_open_6fa8f779-25c4-44c3-adb4-9b55487f83ed" class="cnblogs_code_hide">
<pre><span style="color: #008080;"> 1</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 2</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 选择排序算法
</span><span style="color: #008080;"> 3</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 4</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 5</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 6</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;&lt;/param&gt;</span>
<span style="color: #008080;"> 7</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> SelectionSortAscending1&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;"> 8</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 9</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">10</span>             <span style="color: #0000ff;">for</span> (<span style="color: #0000ff;">int</span> i = <span style="color: #800080;">0</span>; i &lt; arr.Count - <span style="color: #800080;">1</span>; i++<span style="color: #000000;">)
</span><span style="color: #008080;">11</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">12</span>                 <span style="color: #0000ff;">int</span> min =<span style="color: #000000;"> i;
</span><span style="color: #008080;">13</span>                 <span style="color: #0000ff;">for</span> (<span style="color: #0000ff;">int</span> j = i + <span style="color: #800080;">1</span>; j &lt; arr.Count; j++<span style="color: #000000;">)
</span><span style="color: #008080;">14</span> <span style="color: #000000;">                {
</span><span style="color: #008080;">15</span>                     <span style="color: #0000ff;">if</span> (arr[j].CompareTo(arr[min]) &lt; <span style="color: #800080;">0</span><span style="color: #000000;">)
</span><span style="color: #008080;">16</span> <span style="color: #000000;">                    {
</span><span style="color: #008080;">17</span>                         min =<span style="color: #000000;"> j;
</span><span style="color: #008080;">18</span> <span style="color: #000000;">                    }
</span><span style="color: #008080;">19</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">20</span>                 <span style="color: #0000ff;">if</span> (min !=<span style="color: #000000;"> i)
</span><span style="color: #008080;">21</span> <span style="color: #000000;">                {
</span><span style="color: #008080;">22</span>                     T temp =<span style="color: #000000;"> arr[i];
</span><span style="color: #008080;">23</span>                     arr[i] =<span style="color: #000000;"> arr[min];
</span><span style="color: #008080;">24</span>                     arr[min] =<span style="color: #000000;"> temp;
</span><span style="color: #008080;">25</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">26</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">27</span>         }</pre>
</div>
</div>
<p>&nbsp;</p>
<p>希尔排序(Shell sort)</p>
<p>缩小增量法。从大到1设置一系列增量，将序号之差等于增量的数字进行之间插入排序。</p>
<div class="cnblogs_code" onclick="cnblogs_code_show('6602abcb-d19c-4946-9149-88791b165dff')"><img id="code_img_closed_6602abcb-d19c-4946-9149-88791b165dff" class="code_img_closed" src="http://images.cnblogs.com/OutliningIndicators/ContractedBlock.gif" alt="" /><img id="code_img_opened_6602abcb-d19c-4946-9149-88791b165dff" class="code_img_opened" style="display: none;" onclick="cnblogs_code_hide('6602abcb-d19c-4946-9149-88791b165dff',event)" src="http://images.cnblogs.com/OutliningIndicators/ExpandedBlockStart.gif" alt="" /><span class="cnblogs_code_collapse">Shell sort</span>
<div id="cnblogs_code_open_6602abcb-d19c-4946-9149-88791b165dff" class="cnblogs_code_hide">
<pre><span style="color: #008080;"> 1</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 2</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 希尔排序算法
</span><span style="color: #008080;"> 3</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 4</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 5</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 6</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;&lt;/param&gt;</span>
<span style="color: #008080;"> 7</span>         <span style="color: #0000ff;">private</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> ShellSortAscending1&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;"> 8</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 9</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">10</span>             <span style="color: #0000ff;">int</span><span style="color: #000000;"> inc;
</span><span style="color: #008080;">11</span>             <span style="color: #0000ff;">for</span> (inc = <span style="color: #800080;">1</span>; inc &lt;= arr.Count / <span style="color: #800080;">9</span>; inc = <span style="color: #800080;">3</span> * inc + <span style="color: #800080;">1</span><span style="color: #000000;">) ;
</span><span style="color: #008080;">12</span>             <span style="color: #0000ff;">for</span> (; inc &gt; <span style="color: #800080;">0</span>; inc /= <span style="color: #800080;">3</span><span style="color: #000000;">)
</span><span style="color: #008080;">13</span> <span style="color: #000000;">            {
</span><span style="color: #008080;">14</span>                 <span style="color: #0000ff;">for</span> (<span style="color: #0000ff;">int</span> i = inc + <span style="color: #800080;">1</span>; i &lt;= arr.Count; i +=<span style="color: #000000;"> inc)
</span><span style="color: #008080;">15</span> <span style="color: #000000;">                {
</span><span style="color: #008080;">16</span>                     T temp = arr[i - <span style="color: #800080;">1</span><span style="color: #000000;">];
</span><span style="color: #008080;">17</span>                     <span style="color: #0000ff;">int</span> j =<span style="color: #000000;"> i;
</span><span style="color: #008080;">18</span>                     <span style="color: #0000ff;">while</span> ((j &gt; inc) &amp;&amp; (temp.CompareTo(arr[j - inc - <span style="color: #800080;">1</span>]) &lt; <span style="color: #800080;">0</span><span style="color: #000000;">))
</span><span style="color: #008080;">19</span> <span style="color: #000000;">                    {
</span><span style="color: #008080;">20</span>                         arr[j - <span style="color: #800080;">1</span>] = arr[j - inc - <span style="color: #800080;">1</span><span style="color: #000000;">];
</span><span style="color: #008080;">21</span>                         j -=<span style="color: #000000;"> inc;
</span><span style="color: #008080;">22</span> <span style="color: #000000;">                    }
</span><span style="color: #008080;">23</span>                     arr[j - <span style="color: #800080;">1</span>] =<span style="color: #000000;"> temp;
</span><span style="color: #008080;">24</span> <span style="color: #000000;">                }
</span><span style="color: #008080;">25</span> <span style="color: #000000;">            }
</span><span style="color: #008080;">26</span>         }</pre>
</div>
</div>
<p>&nbsp;</p>
<p>为了使用方便，我用如下的方式进行包装，这样就尽可能多的自动成为了可排序类型的扩展方法，并且不需要写 "using ...;"之类的东西，只需引用此类库就行了。</p>
<div class="cnblogs_code" onclick="cnblogs_code_show('7ed07a04-687e-499e-87ac-b0fdc174c90e')"><img id="code_img_closed_7ed07a04-687e-499e-87ac-b0fdc174c90e" class="code_img_closed" src="http://images.cnblogs.com/OutliningIndicators/ContractedBlock.gif" alt="" /><img id="code_img_opened_7ed07a04-687e-499e-87ac-b0fdc174c90e" class="code_img_opened" style="display: none;" onclick="cnblogs_code_hide('7ed07a04-687e-499e-87ac-b0fdc174c90e',event)" src="http://images.cnblogs.com/OutliningIndicators/ExpandedBlockStart.gif" alt="" /><span class="cnblogs_code_collapse">namespace System下的扩展排序算法</span>
<div id="cnblogs_code_open_7ed07a04-687e-499e-87ac-b0fdc174c90e" class="cnblogs_code_hide">
<pre><span style="color: #008080;">  1</span> <span style="color: #0000ff;">using</span><span style="color: #000000;"> System;
</span><span style="color: #008080;">  2</span> <span style="color: #0000ff;">using</span><span style="color: #000000;"> System.Collections.Generic;
</span><span style="color: #008080;">  3</span> <span style="color: #0000ff;">using</span><span style="color: #000000;"> System.Linq;
</span><span style="color: #008080;">  4</span> <span style="color: #0000ff;">using</span><span style="color: #000000;"> System.Text;
</span><span style="color: #008080;">  5</span> <span style="color: #0000ff;">using</span><span style="color: #000000;"> System.Collections; 
</span><span style="color: #008080;">  6</span> 
<span style="color: #008080;">  7</span> <span style="color: #0000ff;">namespace</span><span style="color: #000000;"> System
</span><span style="color: #008080;">  8</span> <span style="color: #000000;">{
</span><span style="color: #008080;">  9</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 10</span>     <span style="color: #808080;">///</span><span style="color: #008000;"> 冒泡排序算法
</span><span style="color: #008080;"> 11</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 12</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 13</span>     <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">partial</span> <span style="color: #0000ff;">class</span><span style="color: #000000;"> _BubbleSort
</span><span style="color: #008080;"> 14</span> <span style="color: #000000;">    {
</span><span style="color: #008080;"> 15</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 16</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 冒泡排序（降序）
</span><span style="color: #008080;"> 17</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;"> 18</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 19</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">冒泡排序（降序）原理：</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 20</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">从左到右以此比较两个相邻的数，若左小右大顺序则交换一下。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 21</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">这样，当一轮比较结束，最小的数就排在了最右边。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 22</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">下一轮比较前N-1个数即可。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 23</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">经过N-1轮比较，数列就是大-&gt;小排序的了。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 24</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">改进的冒泡排序：当某轮比较没有发生移动时，就可以确定排序完成了，从而减少了排序的轮数。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 25</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 26</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 27</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;"> 28</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> BubbleSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;"> 29</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 30</span> <span style="color: #000000;">        {
</span><span style="color: #008080;"> 31</span> <span style="color: #000000;">            arr.BubbleSortDescending();
</span><span style="color: #008080;"> 32</span> <span style="color: #000000;">        }
</span><span style="color: #008080;"> 33</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 34</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 冒泡排序
</span><span style="color: #008080;"> 35</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;"> 36</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 37</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">冒泡排序（降序）原理：</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 38</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">从左到右以此比较两个相邻的数，若左小右大顺序则交换一下。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 39</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">这样，当一轮比较结束，最小的数就排在了最右边。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 40</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">下一轮比较前N-1个数即可。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 41</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">经过N-1轮比较，数列就是大-&gt;小排序的了。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 42</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">改进的冒泡排序：当某轮比较没有发生移动时，就可以确定排序完成了，从而减少了排序的轮数。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 43</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 44</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 45</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;"> 46</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="descending"&gt;</span><span style="color: #008000;">true为降序排序，false为升序排序</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;"> 47</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> BubbleSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt; arr, <span style="color: #0000ff;">bool</span><span style="color: #000000;"> descending)
</span><span style="color: #008080;"> 48</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 49</span> <span style="color: #000000;">        {
</span><span style="color: #008080;"> 50</span>             <span style="color: #0000ff;">if</span><span style="color: #000000;"> (descending)
</span><span style="color: #008080;"> 51</span> <span style="color: #000000;">                arr.BubbleSortDescending();
</span><span style="color: #008080;"> 52</span>             <span style="color: #0000ff;">else</span>
<span style="color: #008080;"> 53</span> <span style="color: #000000;">                arr.BubbleSortAscending();
</span><span style="color: #008080;"> 54</span> <span style="color: #000000;">        }
</span><span style="color: #008080;"> 55</span> <span style="color: #000000;">    }
</span><span style="color: #008080;"> 56</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 57</span>     <span style="color: #808080;">///</span><span style="color: #008000;"> 插入排序算法
</span><span style="color: #008080;"> 58</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 59</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 60</span>     <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">partial</span> <span style="color: #0000ff;">class</span><span style="color: #000000;"> _InsertionSort
</span><span style="color: #008080;"> 61</span> <span style="color: #000000;">    {
</span><span style="color: #008080;"> 62</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 63</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 插入排序（降序）
</span><span style="color: #008080;"> 64</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;"> 65</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 66</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">插入排序（降序）原理：</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 67</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">这是玩扑克牌的排序方法。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 68</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">一张一张地拿牌，拿到一张新牌时，就跟之前手里的牌从右到左地比较。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 69</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">若新牌大，则将此处的旧牌向右移动，原位置空了出来。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 70</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">当新牌不再大时，插入空位。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 71</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">当全部牌拿完，顺序就排好了。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 72</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 73</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 74</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;"> 75</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> InsertionSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;"> 76</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 77</span> <span style="color: #000000;">        {
</span><span style="color: #008080;"> 78</span> <span style="color: #000000;">            arr.InsertionSortDescending();
</span><span style="color: #008080;"> 79</span> <span style="color: #000000;">        }
</span><span style="color: #008080;"> 80</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;"> 81</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 插入排序
</span><span style="color: #008080;"> 82</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;"> 83</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 84</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">插入排序（降序）原理：</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 85</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">这是玩扑克牌的排序方法。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 86</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">一张一张地拿牌，拿到一张新牌时，就跟之前手里的牌从右到左地比较。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 87</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">若新牌大，则将此处的旧牌向右移动，原位置空了出来。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 88</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">当新牌不再大时，插入空位。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 89</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">当全部牌拿完，顺序就排好了。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;"> 90</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;"> 91</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;"> 92</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;"> 93</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="descending"&gt;</span><span style="color: #008000;">true为降序排序，false为升序排序</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;"> 94</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> InsertionSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt; arr, <span style="color: #0000ff;">bool</span><span style="color: #000000;"> descending)
</span><span style="color: #008080;"> 95</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;"> 96</span> <span style="color: #000000;">        {
</span><span style="color: #008080;"> 97</span>             <span style="color: #0000ff;">if</span><span style="color: #000000;"> (descending)
</span><span style="color: #008080;"> 98</span> <span style="color: #000000;">                arr.InsertionSortDescending();
</span><span style="color: #008080;"> 99</span>             <span style="color: #0000ff;">else</span>
<span style="color: #008080;">100</span> <span style="color: #000000;">                arr.InsertionSortAscending();
</span><span style="color: #008080;">101</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">102</span> <span style="color: #000000;">    }
</span><span style="color: #008080;">103</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">104</span>     <span style="color: #808080;">///</span><span style="color: #008000;"> 归并排序算法
</span><span style="color: #008080;">105</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">106</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">107</span>     <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">partial</span> <span style="color: #0000ff;">class</span><span style="color: #000000;"> _MergeSort
</span><span style="color: #008080;">108</span> <span style="color: #000000;">    {
</span><span style="color: #008080;">109</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">110</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 归并排序（降序）
</span><span style="color: #008080;">111</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">112</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">113</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">归并排序（降序）原理：</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">114</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">利用了递归进行排序的方法。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">115</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">将数列等分为左右两部分，先分别对其排序，再将分别排好的两个数列归并为一个排好的序列。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">116</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">循环之，直到这部分只有1个数，那么这部分已经排好序了。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">117</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">归并过程，将排好的两部分列队，从第一个数开始比较，将较大的放到最终要排的数列。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">118</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">若最后剩下一些数，直接接到数列最后即可。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">119</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">120</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">121</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">122</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> MergeSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;">123</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">124</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">125</span> <span style="color: #000000;">            arr.MergeSortDescending();
</span><span style="color: #008080;">126</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">127</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">128</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 归并排序
</span><span style="color: #008080;">129</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">130</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">131</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">归并排序（降序）原理：</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">132</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">利用了递归进行排序的方法。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">133</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">将数列等分为左右两部分，先分别对其排序，再将分别排好的两个数列归并为一个排好的序列。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">134</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">循环之，直到这部分只有1个数，那么这部分已经排好序了。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">135</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">归并过程，将排好的两部分列队，从第一个数开始比较，将较大的放到最终要排的数列。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">136</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">若最后剩下一些数，直接接到数列最后即可。</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">137</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">138</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">139</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">140</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="descending"&gt;</span><span style="color: #008000;">true为降序排序，false为升序排序</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">141</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> MergeSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt; arr, <span style="color: #0000ff;">bool</span><span style="color: #000000;"> descending)
</span><span style="color: #008080;">142</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">143</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">144</span>             <span style="color: #0000ff;">if</span><span style="color: #000000;"> (descending)
</span><span style="color: #008080;">145</span> <span style="color: #000000;">                arr.MergeSortDescending();
</span><span style="color: #008080;">146</span>             <span style="color: #0000ff;">else</span>
<span style="color: #008080;">147</span> <span style="color: #000000;">                arr.MergeSortAscending();
</span><span style="color: #008080;">148</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">149</span> <span style="color: #000000;">    }
</span><span style="color: #008080;">150</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">151</span>     <span style="color: #808080;">///</span><span style="color: #008000;"> 快速排序算法
</span><span style="color: #008080;">152</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">153</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">154</span>     <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">partial</span> <span style="color: #0000ff;">class</span><span style="color: #000000;"> _QuickSort
</span><span style="color: #008080;">155</span> <span style="color: #000000;">    {
</span><span style="color: #008080;">156</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">157</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 快速排序（降序）
</span><span style="color: #008080;">158</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">159</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">160</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">161</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">162</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">163</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> QuickSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;">164</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">165</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">166</span> <span style="color: #000000;">            arr.QuickSortDescending();
</span><span style="color: #008080;">167</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">168</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">169</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 快速排序
</span><span style="color: #008080;">170</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">171</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">172</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">173</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">174</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">175</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="descending"&gt;</span><span style="color: #008000;">true为降序排序，false为升序排序</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">176</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> QuickSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt; arr, <span style="color: #0000ff;">bool</span><span style="color: #000000;"> descending)
</span><span style="color: #008080;">177</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">178</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">179</span>             <span style="color: #0000ff;">if</span><span style="color: #000000;"> (descending)
</span><span style="color: #008080;">180</span> <span style="color: #000000;">                arr.QuickSortDescending();
</span><span style="color: #008080;">181</span>             <span style="color: #0000ff;">else</span>
<span style="color: #008080;">182</span> <span style="color: #000000;">                arr.QuickSortAscending();
</span><span style="color: #008080;">183</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">184</span> <span style="color: #000000;">    }
</span><span style="color: #008080;">185</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">186</span>     <span style="color: #808080;">///</span><span style="color: #008000;"> 选择排序算法
</span><span style="color: #008080;">187</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">188</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">189</span>     <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">partial</span> <span style="color: #0000ff;">class</span><span style="color: #000000;"> _SelectionSort
</span><span style="color: #008080;">190</span> <span style="color: #000000;">    {
</span><span style="color: #008080;">191</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">192</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 选择排序（降序）
</span><span style="color: #008080;">193</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">194</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">195</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">196</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">197</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">198</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> SelectionSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;">199</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">200</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">201</span> <span style="color: #000000;">            arr.SelectionSortDescending();
</span><span style="color: #008080;">202</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">203</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">204</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 选择排序
</span><span style="color: #008080;">205</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">206</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">207</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">208</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">209</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">210</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="descending"&gt;</span><span style="color: #008000;">true为降序排序，false为升序排序</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">211</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> SelectionSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt; arr, <span style="color: #0000ff;">bool</span><span style="color: #000000;"> descending)
</span><span style="color: #008080;">212</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">213</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">214</span>             <span style="color: #0000ff;">if</span><span style="color: #000000;"> (descending)
</span><span style="color: #008080;">215</span> <span style="color: #000000;">                arr.SelectionSortDescending();
</span><span style="color: #008080;">216</span>             <span style="color: #0000ff;">else</span>
<span style="color: #008080;">217</span> <span style="color: #000000;">                arr.SelectionSortAscending();
</span><span style="color: #008080;">218</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">219</span> <span style="color: #000000;">    }
</span><span style="color: #008080;">220</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">221</span>     <span style="color: #808080;">///</span><span style="color: #008000;"> 希尔排序算法
</span><span style="color: #008080;">222</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">223</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">224</span>     <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">partial</span> <span style="color: #0000ff;">class</span><span style="color: #000000;"> _ShellSort
</span><span style="color: #008080;">225</span> <span style="color: #000000;">    {
</span><span style="color: #008080;">226</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">227</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 希尔排序（降序）
</span><span style="color: #008080;">228</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">229</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">230</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">231</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">232</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">233</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> ShellSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;">234</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">235</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">236</span> <span style="color: #000000;">            arr.ShellSortDescending();
</span><span style="color: #008080;">237</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">238</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">239</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 希尔排序
</span><span style="color: #008080;">240</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">241</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">242</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">243</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">244</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">245</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="descending"&gt;</span><span style="color: #008000;">true为降序排序，false为升序排序</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">246</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> ShellSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt; arr, <span style="color: #0000ff;">bool</span><span style="color: #000000;"> descending)
</span><span style="color: #008080;">247</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">248</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">249</span>             <span style="color: #0000ff;">if</span><span style="color: #000000;"> (descending)
</span><span style="color: #008080;">250</span> <span style="color: #000000;">                arr.ShellSortDescending();
</span><span style="color: #008080;">251</span>             <span style="color: #0000ff;">else</span>
<span style="color: #008080;">252</span> <span style="color: #000000;">                arr.ShellSortAscending();
</span><span style="color: #008080;">253</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">254</span> <span style="color: #000000;">    }
</span><span style="color: #008080;">255</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">256</span>     <span style="color: #808080;">///</span><span style="color: #008000;"> 堆排序算法
</span><span style="color: #008080;">257</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">258</span>     <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">259</span>     <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">partial</span> <span style="color: #0000ff;">class</span><span style="color: #000000;"> _HeapSort
</span><span style="color: #008080;">260</span> <span style="color: #000000;">    {
</span><span style="color: #008080;">261</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">262</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 堆排序（降序）
</span><span style="color: #008080;">263</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">264</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">265</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">266</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">267</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">268</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> HeapSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt;<span style="color: #000000;"> arr)
</span><span style="color: #008080;">269</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">270</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">271</span> <span style="color: #000000;">            arr.HeapSortDescending();
</span><span style="color: #008080;">272</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">273</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;summary&gt;</span>
<span style="color: #008080;">274</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 堆排序
</span><span style="color: #008080;">275</span>         <span style="color: #808080;">///</span><span style="color: #008000;"> 请勿传null给本函数，否则将发生异常
</span><span style="color: #008080;">276</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">不稳定排序</span><span style="color: #808080;">&lt;/para&gt;</span>
<span style="color: #008080;">277</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;/summary&gt;</span>
<span style="color: #008080;">278</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;typeparam name="T"&gt;</span><span style="color: #008000;">实现了IComparable的类型</span><span style="color: #808080;">&lt;para&gt;</span><span style="color: #008000;">例如int</span><span style="color: #808080;">&lt;/para&gt;&lt;/typeparam&gt;</span>
<span style="color: #008080;">279</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="arr"&gt;</span><span style="color: #008000;">请勿传null给本参数，否则将发生异常</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">280</span>         <span style="color: #808080;">///</span> <span style="color: #808080;">&lt;param name="descending"&gt;</span><span style="color: #008000;">true为降序排序，false为升序排序</span><span style="color: #808080;">&lt;/param&gt;</span>
<span style="color: #008080;">281</span>         <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">static</span> <span style="color: #0000ff;">void</span> HeapSort&lt;T&gt;(<span style="color: #0000ff;">this</span> IList&lt;T&gt; arr, <span style="color: #0000ff;">bool</span><span style="color: #000000;"> descending)
</span><span style="color: #008080;">282</span>             <span style="color: #0000ff;">where</span><span style="color: #000000;"> T : IComparable
</span><span style="color: #008080;">283</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">284</span>             <span style="color: #0000ff;">if</span><span style="color: #000000;"> (descending)
</span><span style="color: #008080;">285</span> <span style="color: #000000;">                arr.HeapSortDescending();
</span><span style="color: #008080;">286</span>             <span style="color: #0000ff;">else</span>
<span style="color: #008080;">287</span> <span style="color: #000000;">                arr.HeapSortAscending();
</span><span style="color: #008080;">288</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">289</span> <span style="color: #000000;">    }
</span><span style="color: #008080;">290</span> }</pre>
</div>
</div>
<p>&nbsp;</p>
