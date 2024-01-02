// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

// Q:讀入兩個數x和y，選出大的那一個。

//double x, y;
//Console.WriteLine("請輸入x");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入y");
//y = Convert.ToDouble(Console.ReadLine());

//if (x > y)
//{
//    Console.WriteLine($"x:{x} > y{y}");
//}
//else if (x < y)
//{
//    Console.WriteLine($"y {y} > x{x}");
//}
//else
//{
//    Console.WriteLine("兩者相同");
//}

// Q:讀入x和y，如果x>y，則回傳x-y，否則回傳y-x。

//double x, y, z;
//Console.WriteLine("請輸入x");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入y");
//y = Convert.ToDouble(Console.ReadLine());

//if (x > y)
//{
//    Console.WriteLine($"z: {x - y}");
//}

//else
//{
//    Console.WriteLine($"z : {y - x}");
//}

// Q:讀入一數字，如果是負數，就將它轉成正數。

//double x;
//Console.WriteLine("請輸入x");
//x = Convert.ToDouble(Console.ReadLine());


//if (x < 0)
//{
//    x = Math.Abs(x);
//    Console.WriteLine($"x: {x}");
//}

//else
//{
//    Console.WriteLine($"{x}");
//}

//  Q:輸入一個學生的分數，輸出該成績級別，分數級別如下：
//  90分以上: A
//  80~89分: B
//  70~79分: C
//  60~69分: D
//  60分以下: F

//int x;
//Console.WriteLine("請輸入學生分數:x");
//x = Convert.ToInt32(Console.ReadLine());
//if (x >= 90)
//{
//    Console.WriteLine("Ａ");
//}
//else if (80 <= x && x >= 89)
//{
//    Console.WriteLine("B");
//}
//else if (70 <= x && 79 >= x)
//{
//    Console.WriteLine("C");
//}
//else if (60 <= x && 69 >= x)
//{
//    Console.WriteLine("D");
//}
//else
//{
//    Console.WriteLine("F");
//}

// 使用switch改寫

//int x;
//Console.WriteLine("請輸入學生分數:x");
//x = Convert.ToInt32(Console.ReadLine());
//switch (x)
//{
//    case >= 90:

//        Console.WriteLine("Ａ");
//        break;

//    case >= 80:

//        Console.WriteLine("B");
//        break;

//    case >= 70:

//        Console.WriteLine("C");
//        break;

//    case >= 60:

//        Console.WriteLine("D");
//        break;
//    default:
//        Console.WriteLine("F");
//        break;

//}


// Q:某商店在大特價，根據購買的商品總金額決定打折的折扣，總金額越高折扣越多，折扣表如下：
//    未滿1000 : 無折扣
//    1000~4999 : 9折
//    5000~9999 : 8折
//    高於10000 : 7折
//    小數點四捨五入，印出折扣後的金額。

//double p;
//Console.WriteLine("請輸入總金額");
//p = Convert.ToDouble(Console.ReadLine());

//if (p < 1000)
//{
//    Console.WriteLine($"總價格:{p}");
//}
//else if (1000 <= p && p <= 4999)
//{
//    p = Math.Round(p * 0.9);
//    Console.WriteLine($"總價格:{p}");
//}
//else if (5000 <= p && p <= 9999)
//{
//    p = Math.Round(p * 0.8);
//    Console.WriteLine($"總價格:{p}");
//}
//else
//{
//    p = Math.Round(p * 0.7);
//    Console.WriteLine($"總價格:{p}");
//}



// Q:輸入x和y，如果xy，則列印x，否則列印y

//double x, y, z;
//Console.WriteLine("請輸入x");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入y");
//y = Convert.ToDouble(Console.ReadLine());

//if (x > y)
//{
//    z = x;
//    Console.WriteLine($"結果為：{z}");
//}
//else
//{
//    z = y;
//    Console.WriteLine($"結果為：{z}");
//}

// Q:輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0

//double x, y, z;
//Console.WriteLine("請輸入x");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入y");
//y = Convert.ToDouble(Console.ReadLine());
//if (x > y)
//{
//    z = x - y;
//    Console.WriteLine($"結果為：{z}");
//}
//else
//{
//    z = y - x;
//    Console.WriteLine($"結果為：{z}");
//}

// Q:輸入x、y、u、v，如果(x+y)>(u+v)，則令z=x-y，否則令z=u-v

//double x, y, u, v, z;
//Console.WriteLine("請輸入x");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入y");
//y = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入u");
//u = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入v");
//v = Convert.ToDouble(Console.ReadLine());

//if ((x + y) > (u + v))
//{
//    z = x + y;
//    Console.WriteLine($"結果為：{z}");
//}
//else
//{
//    z = u + v;
//    Console.WriteLine($"結果為：{z}");
//}


// Q:輸入x、y、u、v，如果，令z=x-y，否則令z=u-v。

//double x, y, u, v;
//Console.WriteLine("請輸入數字x");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入數字y");
//y = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入數字u");
//u = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入數字v");
//v = Convert.ToDouble(Console.ReadLine());


//if ((x + y) / (u - v) >= 2)
//{
//    Console.WriteLine($"答案為{x - y}");
//}
//else
//{
//    Console.WriteLine($"答案是{u - v}");
//}




// Q:輸入x和y，如果xy，令z=x2，否則令z=y^2

//double x, y, z;
//Console.WriteLine("請輸入數字x");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入數字y");
//y = Convert.ToDouble(Console.ReadLine());


//if (x >= y)
//{
//    z = Math.Pow(x, 2);
//    Console.WriteLine($"答案為{z}");
//}
//else
//{
//    z = Math.Pow(y, 2);
//    Console.WriteLine($"答案是{z}");
//}

// Q:2-6
//double income, rate, difference;
//Console.WriteLine("請輸入income");
//income = Convert.ToDouble(Console.ReadLine());

//if (income > 4090000)
//{
//    rate = 0.4;
//    difference = 721100;
//    Console.WriteLine($"答案為{income * rate - difference}");
//}
//else if (income > 2180000)
//{
//    rate = 0.3;
//    difference = 312100;
//    Console.WriteLine($"答案為{income * rate - difference}");
//}
//else if (income > 1090000)
//{
//    rate = 0.21;
//    difference = 115900;
//    Console.WriteLine($"答案為{income * rate - difference}");
//}
//else if (income > 410000)
//{
//    rate = 0.13;
//    difference = 28700;
//    Console.WriteLine($"答案為{income * rate - difference}");
//}
//else
//{
//    rate = 0.06;
//    difference = 0;
//    Console.WriteLine($"答案為{income * rate - difference}");
//}

// Q:2-7

//double x, y;
//Console.WriteLine("請輸入x");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入y");
//y = Convert.ToDouble(Console.ReadLine());
//if (x > 0)
//{
//    if (y > 0)
//    {
//        Console.WriteLine("1st quadrant\n");
//    }
//    else if (y == 0)
//    {
//        Console.WriteLine("X-axis\n");
//    }
//    else
//    {
//        Console.WriteLine("4th quadrant\n");
//    }
//}
//else if (x == 0)
//{
//    if (y == 0)
//    {
//        Console.WriteLine("Origin\n");
//    }
//    else
//    {
//        Console.WriteLine("Y-axis\n");
//    }
//}
//else
//{
//    if (y > 0)
//    {
//        Console.WriteLine("2nd quadrant\n");
//    }
//    else if (y == 0)
//    {
//        Console.WriteLine("X-axis\n");
//    }
//    else
//    {
//        Console.WriteLine("3th quadrant\n");
//    }
//}


//Q: sagit 是一位高中電腦老師，這學期正在教學生寫C++程式。他的評分標準是依照每一位學生在 ZeroJudge 系統上解出的題數，去計算出對應的得分。規則如下：
//答對題數在 0~10 者，每題給6分。
//題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
//題數在 21~40 者，從第21題開始，每題給1分。
//題數在 40 以上者，一律100分。
//請輸入答對題數，輸出統計後分數

//double x, y;
//Console.WriteLine("請輸入答對題目");
//x = Convert.ToDouble(Console.ReadLine());

//if (x < 10)
//{
//    Console.WriteLine($"分數:{x * 10}");
//}
//else if (11 <= x && x <= 20)
//{
//    Console.WriteLine($"分數:{10 * 6 + (x - 10) * 2}");
//}
//else if (21 <= x && x <= 40)
//{
//    Console.WriteLine($"分數:{10 * 6 + 10 * 2 + (x - 20) * 1}");
//}
//else
//{
//    Console.WriteLine($"分數: 100");
//}

// Q:請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。
//double height, weight, bmi;
//Console.WriteLine("請輸入身高(公分)");
//height = Convert.ToDouble(Console.ReadLine());
//height /= 100;
//Console.WriteLine("請輸入體重(公斤)");
//weight = Convert.ToDouble(Console.ReadLine());

//bmi = weight / Math.Pow(height, 2);

//if (bmi < 18.5)
//{
//    Console.WriteLine($"{bmi}:過輕");
//}
//else if (18.5 < bmi && bmi < 24)
//{
//    Console.WriteLine($"{bmi}:正常");
//}
//else
//{
//    Console.WriteLine($"{bmi}:過重");
//}



// Q:請隨意輸入三個數，請由大到小 依序印出。

//double x, y, z;
//Console.WriteLine("請輸入x");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入y");
//y = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入z");
//z = Convert.ToDouble(Console.ReadLine());

//if (x >= y && x >= z)
//{
//    if (y >= z)
//    {
//        Console.WriteLine($"{x} {y} {z}");
//    }
//    else
//    {
//        Console.WriteLine($"{x} {z} {y}");
//    }
//}
//else if (y >= x && y >= z)
//{
//    if (x >= z)
//    {
//        Console.WriteLine($"{y} {x} {z}");
//    }
//    else
//    {
//        Console.WriteLine($"{y} {z} {x}");
//    }
//}
//else
//{
//    if (x >= y)
//    {
//        Console.WriteLine($"{z} {x} {y}");
//    }
//    else
//    {
//        Console.WriteLine($"{z} {y} {x}");
//    }
//}


//Q: 企業發放的獎金根據利潤提成。利潤低於或等於10萬元時，獎金可提10%；
// 利潤高于10萬元，低於20萬元時，低於10萬元的部分按10%提成，高於10萬元的部分，可提成7.5%；20萬到40萬之間時，高於20萬元的部分，可提成5%；
// 40萬到60萬之間時高於40萬元的部分，可提成3%；
// 60萬到100萬之間時，高於60萬元的部分，可提成1.5%，高於100萬元時，超過100萬元的部分按1%提成，從鍵盤輸入當月利潤I，求應發放獎金總數？

//double profit, bonus;
//Console.WriteLine("請輸入當月利潤(萬元)");
//profit = Convert.ToDouble(Console.ReadLine());

//if (profit <= 10)
//{
//    bonus = profit * 0.1;
//    Console.WriteLine($"獎金是{bonus}萬元");
//}
//else if (profit <= 20)
//{
//    bonus = 10 * 0.1 + (profit - 10) * 0.075;
//    Console.WriteLine($"獎金是{bonus}萬元");
//}
//else if (profit <= 40)
//{
//    bonus = 10 * 0.1 + 10 * 0.075 + (profit - 20) * 0.05;
//    Console.WriteLine($"獎金是{bonus}萬元");
//}
//else if (profit <= 60)
//{
//    bonus = 10 * 0.1 + 10 * 0.075 + 20 * 0.05 + (profit - 40) * 0.03;
//    Console.WriteLine($"獎金是{bonus}萬元");
//}
//else if (profit <= 100)
//{
//    bonus = 10 * 0.1 + 10 * 0.075 + 20 * 0.05 + 20 * 0.03 + (profit - 60) * 0.015;
//    Console.WriteLine($"獎金是{bonus}萬元");
//}
//else
//{
//    bonus = 10 * 0.1 + 10 * 0.075 + 20 * 0.05 + 20 * 0.03 + 40 * 0.015 + (profit - 100) * 0.01;
//    Console.WriteLine($"獎金是{bonus}萬元");
//}

