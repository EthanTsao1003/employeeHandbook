# <center>SOLID篇</center>

遵守SOLID原则。[学习资料](https://www.jianshu.com/p/5f1dc9f7b57d) , 本篇每条的具体解释见[SOLID讲解篇](./SOLID讲解篇.md)

**SOLID五大原则、第1条、公司的使命（让天下没有难做的数学）、公司的性质定位（通信技术）要达到凌晨4点要求：假如凌晨四点老板把你摇起来，你要能马上背诵**

0. Always have a way back! 慎重做任何不可逆的操作。
1. 1. 可以重复的不能修改。
        1. String 、int 、class 等编程语言自带关键字
        2. 变量名、类名、方法名等使用的名称
        3. git 历史 
        4. 如果它必须要重复，而且有可能要修改，而且还没有办法依靠IDE做批量修改。那么给它命名的时候(砸键盘)加入一些随机乱码（我们称之为香农压缩码），方便以后做全局搜索：

            例：`soli.jpg` --> `soli__fe7b7c03661788e5674f24ef4__.jpg`
            那么以后给他改名的时候就改给人看的部分，香农压缩码部分就永远别改。
        5. 上一条不要抖机灵用hash！
    2. 可以修改的不能重复（出现一次不叫重复，出现两次及两次以上才叫重复）
        1. 实现逻辑
        2. 类的内部结构（方法、属性、变量） 父类子类可以避免类的内部结构重复这种情况
        3. ...
    3. 不修改不重复才是最好的 但不要刻意追求 一般只做到一点就够了。
    4. 所以，如果有非常必要的public改名需求，应该先专门记在待改名queue文档里，之后找个合适的时间大家一起改。所以改名是非常麻烦劳民伤财的，最好大家讨论好命名后再行动。如果是私有变量，改名可以随意一点，因为更改自己的私有变量，不影响别人调用。    
2. 你做的事情优先是给机器看懂的，实在不行才是给人看懂的。
    1. 所以不要用XXX去代表YYY，除非你教懂IDE知道XXX代表YYY。因为除了你没人会懂XXX代表YYY。即使这是一个业界常用的“代表”也不一定所有人都知道，即使所有人都知道，那IDE也知道吗？
        1. 反例：不要用```return 0;```代表成功，凭什么0就是成功？在编程语言里0代表false，1代表true，为什么false代表成功？
        2. 反例：不要用```string job="Student"```代表学生职业，你的代码会因此特别冗余，因为机器看不懂string。
        3. 正例：```class Student```，因为机器真能看懂Student代表学生类。
        4. 反例：```/*Student*/class XXXXX``` 机器看不懂注释。
        4. 反例：x[0] 代表...  x[1]代表... x[2]... 除了你谁知道这个array里装的哪个是哪个？？？？
    2. 测试同理，优先教会机器如何去做测试，那么麻烦一次以后的测试都会被机器自动做好。而出发万不得已不要偷懒手动测试。
    3. 任何带有编程属性的同理，你让机器学懂的越多，你自己需要做的就越少（长期）。
3. 代码不能出现[DRY](../DRY(不要重复)篇/DRY篇.md)（尽量什么都不要出现DRY）,可以剪切粘贴不要复制粘贴
4. 每个类只能[做一件事情](./S/S篇.md)，一个类只能有一个构造函数。一个方法也应该做一件事情。
5. 不要重复用构造函数（出现一次不叫重复，出现两次及两次以上才叫重复），因为构造函数等价于一个静态函数。只有工厂里(包括容器)才能使用构造函数. 而工厂class*通常*是其生产对象class的nested class，注意nested class不是子类 derived class.
6. 不要用全局变量.
7. 不要用静态（static,编程语言里面的静态，不是说不要有静态的思维、算法），静态的一切 (静态变量也是全局变量)
8. 不要用单例模式(单例也是全局变量)
9. 随机数生成器或许是唯一一个合理的全局变量，但是永远不要用不被控制的随机数生成器 即一定要有种子的随机数生成器并控制好他的种子 
10. 命名要好好命名，读代码的时间会是写代码时间的十倍，即使是自己写的代码，所以不仅是在照顾别人，也是在照顾自己，如果在命名上出现了困难，大概率违反了S原则。
11. 也不要在命名里面放没有意义的词，如"学生`对象`"、"学生`变量`"、x、y、z，也不要用学生`1`、学生`2`、学生`3`，用数组
12. 别缩写到别人看不懂，如魔数师写成mss、GameObject写成go
13. 不要无脑把所有变量都写上get(),set()，除非真的有必要。
14. 所有变量都不能public，但是在严格服从接口隔离(D原则)的情况下，是不是public，已经不重要了，所以可以放宽这一条要求
15. 所有的private变量都应该是protected变量或以上(public)。所有的普通函数都应该是虚函数。但是这样规定会无谓的增加代码工作量所以我们遵从现用现改原则
16. 避免else if，switch结构，转而用多态去实现，千篇一律的if结构也是一种重复，比如千篇一律的空指针检查，又比如if(这个人是男人){...... }else if(这个人是女人){......}else if(这是人妖){......}，符合某种经常会出现的，而且判别内容是一样的if else if也算是代码重复，避免if但是不禁用
17. switch就真的别轻易用了!!（这不是告诉你if else if else if...... 更好）
18. 不要重载, 用多态
19. 不要滥用继承，"是"和"有"的区别。人有手和脚，但人不应该继承手和脚，相反，男人和女人可以继承人。 通常继承不该超过一级（男人和女人继承人是一级，但是老婆婆、中年妇女、少女再去继承女人就是二级），但是如果真的很恰当的话，超过一级也可以。（严格来讲类继承类才是继承inherit，类继承接口叫implement）
20. 扩展功能不应该改变对现有功能产生副作用
21. 保证上一条最安全可靠的方法就是不要改任何旧的代码，通过新增函数、类去扩展
22. 不要轻易写注释，不要期望有人会读你的注释，更不要期望有人会更新你的注释，尽量把你写注释的时间拿来好好想想怎么命名吧。唯一允许的注释是说明特殊情况。
    1. 但是如果你写了注释（自己就是想写或者老板特殊要求）你就要负责更新你的注释和更新你的代码同步到底。
    2. 就算写注释也用//的注释，不要用/*的注释。
    3. 如果你的注释是直白的把代码翻译一遍，这个注释绝对是多余的，并且违反了DRY
23. 不要把注释代码当成删除代码来用，如果你觉得这个代码以后还可能用得到，不如做好版本控制，多commit几次，为什么？不好看，怎么解决？版本控制
24. 不要在代码里面出现数字/数据，把你需要的数字/数据注入进来
    错误示范:
    ```
    圆的面积=3.14*r*r
    ```
    正确示范:先注入pi，然后
    ```
    圆的面积=pi*r*r
    ```
25. 先想接口，再想实现
26. 不要在一个class的代码里面出现其他class的名字（接口不是class），继承是唯一可以放宽的情况，封装隔离第三方工具的时候也可以一次性违反
27. 写代码出现循环（尤其是多层循环）的时候，无论是显性的循环(多个for放在一起)还是隐形的循环(一个for里面调用了方法，该方法里面也有循环)，停下来多思考一下是不是必要的。
28. 不要用null
29. 不要用枚举(enum)
30. **不要用String去影响代码逻辑！！！！！**，除非是和第三方对接的情况下 人家已经率先使用了string （例：在数据库业务密切相关的情况下或者是远程请求密切相关的情况下），即使是这种情况，也应该做好封装与隔离，但求做到不重复违反这条原则。
在报错说明的情况，或者是在print情况下，可以用String,因为不影响代码逻辑，如果你的代码逻辑依赖到String上，那么你的代码逻辑设计有问题
一个简单的测试：如果我跑过来瞎改你string的值，会导致程序产生bug，那这个string就是非法使用的。
31. 使用任何第三方工具的时候都像第30条一样做好封装隔离，封装的时候可以一次性违反
32. 不要把print当成debug的工具，debug用断点。我也想不出你有任何其他理由需要用到print。
33. 需要什么就[注入](../../依赖注入篇/依赖注入篇.md)什么，不要自己去瞎猜。需要什么辅助工具就注入，不要自己去造轮子。只有工厂和容器才能new。 **永远假设你注入进来的东西是直接能用的（当然 该做什么具体的初始化 该设置什么具体的参数还是要自己设置），如果不能用,那是负责那个东西人的责任，自己轻松，别人也轻松。**
比如:在处理某份数据的时候，先要把数据洗干净（预处理）然后再处理，不如直接注入干净的数据，把预处理和后处理甩给其他人，别人公司鼓励大家多承担责任，我们公司鼓励大家把与自己无关的责任甩给其他人。怎么判定是否与自己有关？老板说了有关就是有关，老板没说就是没关。比如：老板只吩咐你去处理数据，没有吩咐你去预处理数据，那你就设定注入进来的数据都是预处理好的，把预处理的责任甩给其他人。任务完成后老板一看你的数据处理得很好，发现其他同事都已经被委以重任了，预处理这个任务还没有人做，让你去做预处理的任务，这个时候预处理才跟你有关。
34. 与S准则无关却必要的东西不要自己去造，不要自己去猜，注入进来。
    1. 注入你需要的东西，注入你**仅**需要的东西，注入你直接需要的东西(接口)。不要注入你不需要的东西，只是因为他跟你需要的东西绑在一起（这说明I准则没做好） [DEMETER准则](https://www.cnblogs.com/zh7791/p/7922960.html)
    2. 当你需要调用别人的方法时，注入进来，不要通过注入进来的变量调用方法，而是让自身去拥有[注入进来的变量的方法](../DRY(不要重复)篇/代码/动物答案之_BinarySerialize/2020.05.05（动物）/_把一个东西写到一个路径.cs),再去调用自身的，方便扩展
35. 如果你不想别人不按照你的意愿使用你的代码，别把该操作的接口直接或间接给他，请参考[定责篇](../../定责篇/定责篇.md)
36. 当几个程序的运行顺序很关键的时候用依赖注入去确保他们的顺序
37. 世界上的码农数每五年就会翻一倍，所以世界上一半的码农出现在五年前，另一半的码农是五年内才入行的，所以当你随机遇到一个码农，有50%的概率他的经验还不足5年，有75%的概率他的经验还不足十年，所以即使你现在是0年经验或者1年经验，你随机遇到的其他码农（无论是现实中还是网上别人发布代码），有一半是不值得你去学习的，所以谁值得你学习呢？以我们公司的[员工手册](../../员工手册.md)为准
38. 违反以上准则有不同程度的严重性：在哪违反、违反几次
    1. 接口>业务实现代码>测试>工厂>环境设置(包括容器、参数、绑定)
    2. 系统化地违反一次：做好设计，有计划的违反一次，违反一次之后就不需要再违反了并且违反这一次有一定的必要性。
    3. 不违反≈系统化地违反一次>违反一次>违反多次
39. 唯一可以在开发中违反SOLID的情况是避免过大的性能牺牲。遇到这种情况应该主动请示上级具体情况具体分析。
40. 如果方法有副作用，应该明确写出来，恰当的情况下甚至应该写到方法名里，什么是副作用？根据[最小惊奇原则](S/S篇.md),永远假设 **审阅你代码的人是个拿着斧子的精神不稳定病人，而且他还知道你家住哪儿。** 如果他不看代码实现 就猜不出会有这个作用，那这个就叫副作用。如果遵从S就很容易避免副作用。例：某人写了一个非常糟糕的排序算法，虽然能够正常排序但是调用后会造成卡顿，但是公司现在没空去优化这个问题，那么至少应该把这个函数命名或注释成`排序O_n^4`。

所有以上的规范都要在开发环境下严格执行（测试环境和配置环境不属于开发环境），其他情况下可以酌情放宽（注意我说的是稍微酌情放宽不是随意放纵自己！），原则是越可能被修改越要严格执行（配置环境Installer Container除外）。

<center> Copyright © 2020 珠海数镜空时科技有限公司 All Rights Reserved</center>