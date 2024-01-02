// See https://aka.ms/new-console-template for more information


// Q: 導入五個整數，求這五個整數的和

//int sum = 0;
//for (int i = 0; i < 5; i++) {
//    int input;
//    Console.WriteLine($"請輸入變數{i+1}");
//       input = Convert.ToInt32(Console.ReadLine());
//    sum += input;
//}
//Console.WriteLine($"總和是：{sum}");
//Console.ReadKey();

// Q: 導入五個整數，求這五個整數的和 (While寫法)

//int times = 0;
//int sum = 0;
//while (times < 5) {
//    int cur;
//    Console.WriteLine($"請輸入變數{times+1}");
//    times++;

//    cur = Convert.ToInt32(Console.ReadLine());
//    sum += cur;
//}
//Console.WriteLine($"總和是:{sum}");
//Console.ReadKey();


// Q: 求N個整數和，N由使用者輸入

//int total;
//int sum = 0;
//Console.WriteLine("請輸入總數量");
//total = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < total; i++) {
//    int cur;
//    Console.WriteLine($"請輸入數值{i+1}");
//    cur = Convert.ToInt32(Console.ReadLine());
//    sum += cur;
//}
//Console.WriteLine($"結果為{sum}");
//Console.ReadKey();

// Q: 求N個整數和，N由使用者輸入 (While寫法)

//int total;
//Console.WriteLine($"請輸入總數量：");
//total = Convert.ToInt32(Console.ReadLine());
//int i = 0;
//int sum = 0;
//while (i < total) {
//    int cur;
//    Console.WriteLine($"請輸入數值{i+1}");
//    cur = Convert.ToInt32(Console.ReadLine());
//    i++;
//    sum += cur;
//}
//Console.WriteLine($"結果為{sum}");
//Console.ReadKey();

// Q: 假設有N個正整數，求其中的最大值。

//int total;
//int max;
//Console.WriteLine("請輸入總數量：");
//total = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入數值1");
//max = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i < total; i++) {
//    Console.WriteLine($"請輸入數值{i+1}");
//    int cur;
//    cur = Convert.ToInt32(Console.ReadLine());
//    if (cur > max) {
//        max = cur;
//    }
//}
//Console.WriteLine($"最大值是{max}");
//Console.ReadLine();

// Q: 假設有N個正整數，求其中的最大值。(While寫法)

//int total;
//int max;
//Console.WriteLine("請輸入總數量：");
//total = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入數值1");
//max = Convert.ToInt32(Console.ReadLine());
//int time = 1;
//while (time < total) {
//    int cur;
//    Console.WriteLine($"請輸入數值{time+1}");
//    cur = Convert.ToInt32(Console.ReadLine());
//    time++;
//    if (cur > max) {
//        max = cur;
//    }
//}
//Console.WriteLine($"最大值為{max}");


// Q:Nested loop (9X9)
//for (int i = 1; i < 10; i++) {
//    for (int j = 1; j < 10; j++) {
//        Console.WriteLine($"{i}*{j}為{i*j}");
//    }
//}


// 假設有N個正整數，求最大奇數值
//int total;
//int max;
//Console.WriteLine("請輸入總數量：");
//total = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入數值1");
//max = Convert.ToInt32(Console.ReadLine());
//if (max % 2 == 0) {
//    max = 0;
//}
//for (int i = 1; i < total; i++) {
//    int cur;
//    Console.WriteLine($"請輸入數值{i + 1}");
//    cur = Convert.ToInt32(Console.ReadLine());
//    // Check if cur value if odd or even
//    if (cur % 2 == 1) {
//        if (cur > max) {
//            max = cur;
//        }
//    }
//}

//Console.WriteLine($"最大奇數為{max}");
//Console.ReadKey();

// 假設有N個正整數，求最大奇數值 (While語法)

//int total;
//int max;
//int time = 1;
//Console.WriteLine("請輸入總數量：");
//total = Convert.ToInt32(Console.ReadLine());
////輸入數值1，若為偶數則max為0
//Console.WriteLine("請輸入數值1");
//max = Convert.ToInt32(Console.ReadLine());
//if (max % 2 == 0)
//{
//    max = 0;
//}

//while (time < total) {
//    int cur;

//    Console.WriteLine($"請輸入數值{time+1}");
//    cur = Convert.ToInt32(Console.ReadLine());
//    time++;
//    // Check if cur value if odd or even
//    if (cur % 2 == 1)
//    {
//        if (cur > max)
//        {
//            max = cur;
//        }
//    }

//}
//Console.WriteLine($"最大奇數為{max}");
//Console.ReadKey();

// Q: 求N階層，即求1￼2￼3￼…￼N。

//int answer = 1;
//int maxLevel;

//Console.WriteLine("請輸入階層數");
//maxLevel = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= maxLevel; i++) {
//    answer *= i;
//}
//Console.WriteLine($"結果為{answer}");

// Q: 求N階層，即求1￼2￼3￼…￼N。 (While寫法)

//int answer = 1;
//int maxLevel;
//int time = 1;

//Console.WriteLine("請輸入階層數");
//maxLevel = Convert.ToInt32(Console.ReadLine());
//while(time <= maxLevel)
//{
//    answer *= time;
//    time++;
//}
//Console.WriteLine($"結果為{answer}");

// Q: 輸出一個九九乘法表。

//Console.WriteLine("開始輸出99乘法表");
//for (int i = 1; i < 10; i++) {
//    for (int j = 1; j < 10; j++)
//    {
//        Console.WriteLine($"{i} * {j} : {i*j}");
//    }
//}
//Console.ReadKey();

// Q: 輸出一個九九乘法表。 (While寫法)

//Console.WriteLine("開始輸出99乘法表");
//int innerLoop = 1;
//int outerLoop = 1;
//while (outerLoop < 10) {
//    while (innerLoop < 10) {
//        Console.WriteLine($"{outerLoop} * {innerLoop} : {outerLoop*innerLoop} ");
//        innerLoop++;

//    }
//    innerLoop = 1;
//    outerLoop++;
//}


//Q: 輸出一個九九乘法表。（矩陣輸出形式）

//for (int i = 1; i < 10; i += 3)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        for (int k = 0; k < 3; k++)
//        {
//            Console.Write($"{i + k} * {j} : {(i + k) * j}\t");
//        }
//        Console.WriteLine();
//    }

//    Console.WriteLine();
//}

//Console.ReadKey();

//Q: 輸出一個九九乘法表。（矩陣輸出形式 - While語法）

//int i = 1;
//int j = 1;
//int k = 0;
//while (i < 10)
//{

//    while (j < 10)
//    {
//        while (k < 3)
//        {
//            Console.Write($"{i + k} * {j} : {(i + k) * j}\t");
//            k++;
//        }
//        Console.WriteLine();
//        k = 0;
//        j++;
//    }
//    j = 1;
//    Console.WriteLine();
//    i += 3;
//}


// Q: 3-1.寫一程式，輸入10個整數，求其最小值。

//int min;
//Console.WriteLine("請輸入整數");
//min = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < 9; i++)
//{
//    int cur;
//    Console.WriteLine("請輸入整數");

//    cur = Convert.ToInt32(Console.ReadLine());
//    if (min > cur) {
//        min = cur;
//    }
//}
//Console.WriteLine($"最小整數{min}");
//Console.ReadKey();

// Q: 3-1.寫一程式，輸入10個整數，求其最小值。(While寫法)

//int min;
//Console.WriteLine("請輸入整數");
//min = Convert.ToInt32(Console.ReadLine());
//int i = 1;
//while (i < 10){
//    int cur;
//    Console.WriteLine("請輸入整數");
//    cur = Convert.ToInt32(Console.ReadLine());
//    i++;
//    if (cur < min) {
//        min = cur;
//    }
//}
//Console.WriteLine($"最小數值為{min}");





//Q: 3 - 2.寫一程式，輸入N個整數，求其最小值。

//int number;
//Console.WriteLine("請輸入處理整數數量");
//number = Convert.ToInt32(Console.ReadLine());
//int min;
//Console.WriteLine("請輸入整數");
//min = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < number-1; i++)
//{
//    int cur;
//    Console.WriteLine("請輸入整數");

//    cur = Convert.ToInt32(Console.ReadLine());
//    if (min > cur)
//    {
//        min = cur;
//    }
//}
//Console.WriteLine($"最小整數{min}");
//Console.ReadKey();


//Q: 3 - 2.寫一程式，輸入N個整數，求其最小值。(While寫法)

//int number;
//Console.WriteLine("請輸入處理整數數量");
//number = Convert.ToInt32(Console.ReadLine());
//int min;
//Console.WriteLine("請輸入整數");
//min = Convert.ToInt32(Console.ReadLine());
//int i = 1;
//while (i < number)
//{
//    int cur;
//    Console.WriteLine("請輸入整數");
//    cur = Convert.ToInt32(Console.ReadLine());
//    i++;
//    if (cur < min)
//    {
//        min = cur;
//    }
//}
//Console.WriteLine($"最小數值為{min}");




// Q: 3-3.寫一程式，輸入10個整數，列出其中所有大於12的數字。

//int min = 12;
//string answer = " ";
//for (int i = 0; i < 10; i++)
//{
//    int cur;
//    Console.WriteLine("請輸入整數");
//    cur = Convert.ToInt32(Console.ReadLine());
//    if (cur > min)
//    {
//        answer += cur.ToString()+ " ";
//    }
//}
//Console.WriteLine($"{answer}");
//Console.ReadKey();

// Q: 3-3.寫一程式，輸入10個整數，列出其中所有大於12的數字。 （While寫法）

//int min = 12;
//string answer = " ";
//int index = 0;
//while (index < 10) {
//    index++;
//    int cur;
//    Console.WriteLine("請輸入整數");
//    cur = Convert.ToInt32(Console.ReadLine());
//    if (cur > min)
//    {
//        answer += cur.ToString() + " ";
//    }
//}

//Console.WriteLine($"{answer}");
//Console.ReadKey();





// Q: 3-4.寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。

//int sum = 0;
//int min = 12;
//for (int i = 0; i < 10; i++)
//{
//    int cur;
//    Console.WriteLine("請輸入整數");
//    cur = Convert.ToInt32(Console.ReadLine());
//    if (cur > min)
//    {
//        sum += cur;
//    }
//}
//Console.WriteLine($"所有大於12的數字的總和: {sum}");
//Console.ReadKey();

// Q: 3-4.寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。(While寫法)

//int min = 12;
//int index = 0;
//int sum = 0;
//while (index < 10)
//{
//    index++;
//    int cur;
//    Console.WriteLine("請輸入整數");
//    cur = Convert.ToInt32(Console.ReadLine());
//    if (cur > min)
//    {
//        sum += cur;
//    }
//}

//Console.WriteLine($"所有大於12的數字的總和: {sum}");
//Console.ReadKey();

// 3-5.寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。

//先判斷奇數，再取其中最大值
//int num;
//Console.WriteLine("請設定處理數字數量：");
//num = Convert.ToInt32(Console.ReadLine());
//int max = int.MinValue;

//for (int i = 0; i < num; i++)
//{
//    int cur;
//    Console.WriteLine("請輸入數字");
//    cur = Convert.ToInt32(Console.ReadLine());
//    if (cur % 2 != 0)
//    {
//        if (cur > max)
//        {
//            max = cur;
//        }
//    }
//}
//if (max == int.MinValue)
//{
//    Console.WriteLine("未輸入奇數");
//}
//else
//{
//    Console.WriteLine($"最大奇數為{max}");
//}

// 3-5.寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。(While寫法)

//int num;
//Console.WriteLine("請設定處理數字數量：");
//num = Convert.ToInt32(Console.ReadLine());
//int max = int.MinValue;
//int time = 0;
//while (time < num) {
//    int cur;
//    Console.WriteLine("請輸入數字");
//    cur = Convert.ToInt32(Console.ReadLine());
//    time++;
//    if (cur % 2 != 0)
//    {
//        if (cur > max)
//        {
//            max = cur;
//        }
//    }
//}

//if (max == int.MinValue)
//{
//    Console.WriteLine("未輸入奇數");
//}
//else
//{
//    Console.WriteLine($"最大奇數為{max}");
//}

// Q;寫一程式，輸入N個數字，求其所有正數之平方的加總。

//int num;
//double cur;
//double sum = 0;
//Console.WriteLine("請輸入處理數字數量：");
//num = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < num; i++)
//{

//    Console.WriteLine($"請輸入數字{i+1}：");
//    cur = Convert.ToDouble(Console.ReadLine());
//    if (cur > 0) {
//        sum += Math.Pow(cur, 2);
//    }
//}
//Console.WriteLine($"總合為：{sum}");


// Q;寫一程式，輸入N個數字，求其所有正數之平方的加總。 Pg 46. (While語法)

//int num;
//double cur;
//double sum = 0;
//int time = 0;
//Console.WriteLine("請輸入處理數字數量：");
//num = Convert.ToInt32(Console.ReadLine());
//while (time < num) {
//    Console.WriteLine($"請輸入數字{time + 1}：");
//    cur = Convert.ToDouble(Console.ReadLine());
//    time++;
//    if (cur > 0)
//    {
//        sum += Math.Pow(cur, 2);
//    }
//}

//Console.WriteLine($"總合為：{sum}");


//Q: 寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數

//int num;
//double cur;
//string ans = "";
//Console.WriteLine("請輸入處理數字數量：");
//num = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < num; i++)
//{

//    Console.WriteLine($"請輸入數字{i + 1}：");
//    cur = Convert.ToDouble(Console.ReadLine());
//    if (cur < 0)
//    {
//        ans += " " + Convert.ToString(-cur);
//    }
//    else {
//        ans += " "+Convert.ToString(cur);
//    }
//}
//Console.WriteLine($"處理後結果為：{ans}");

//Q: 寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數(While語法)

//int num;
//double cur;
//string ans = "";
//int time = 0;
//Console.WriteLine("請輸入處理數字數量：");
//num = Convert.ToInt32(Console.ReadLine());
//while (time < num) {
//    Console.WriteLine($"請輸入數字{time + 1}：");
//    cur = Convert.ToDouble(Console.ReadLine());
//    time++;
//    if (cur < 0)
//    {
//        ans += " " + Convert.ToString(-cur);
//    }
//    else
//    {
//        ans += " " + Convert.ToString(cur);
//    }

//}

//Console.WriteLine($"處理後結果為：{ans}");

// Q:判斷101-200之間有多少個質數，並輸出所有質數

/* 邏輯： 
 1.  <= 1不算質數
 2. 使用for loop查看，若從2 ~ 平方根(最大公約數)都無整數可整除，即可判斷為質數
	2-1. 使用break，因只要可被整除即可判定為非質數，減少不必要檢查導致降低效能
 */

//int lower;
//int upper;
//Console.WriteLine("請輸入下限");
//lower = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入上限");
//upper = Convert.ToInt32(Console.ReadLine());
//int sumPrimeNumber = 0;
////
//bool isPrime = true;
//string eachPrime = "";
//for (int i = lower; i <= upper; i++)
//{
//    if (i >= 2) {
//        for (int j = 2; j <= Math.Floor(Math.Sqrt(i)); j++)
//        {
//            if (i % j == 0)
//            {
//                isPrime = false;
//                break;

//            }
//        }
//        if (isPrime)
//        {
//            sumPrimeNumber++;
//            eachPrime += $"{i} ";
//        }

//    }
//}
//Console.WriteLine($"個別質數為：{eachPrime}");
//Console.WriteLine($"總共的質數為{sumPrimeNumber}");

// Q:判斷101-200之間有多少個質數，並輸出所有質數(While寫法)

// 重點在reset

//int lower;
//int upper;
//Console.WriteLine("請輸入下限");
//lower = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入上限");
//upper = Convert.ToInt32(Console.ReadLine());
//int sumPrimeNumber = 0;
////
//bool isPrime = true;
//string eachPrime = "";

//while (lower <= upper) {
//    int checkedNumber = 2;
//    isPrime = true;


//    if (lower >= 2) {

//        while (checkedNumber <= Math.Sqrt(lower)) {
//            if (lower % checkedNumber == 0) {
//                isPrime = false;
//                break;
//            }
//            checkedNumber++;

//        }
//        if (isPrime) {
//            sumPrimeNumber++;
//            eachPrime += $"{lower} ";

//        }
//    }
//    lower++;

//}
//Console.WriteLine($"個別質數為：{eachPrime}");
//Console.WriteLine($"總共的質數為{sumPrimeNumber}");


// Q:輸入一個數，輸出其質因數
//int input;
//Console.WriteLine("請輸入數值");
//input = Convert.ToInt32(Console.ReadLine());
//string ans = "";
//bool isPrime = true;


//for (int i = 2; i <= input; i++)
//{
//    if (input % i == 0) {
//        // 查看因數是否為質數
//        for (int j = 2; j <= Math.Sqrt(i); j++)
//        {
//            isPrime = true;
//            if (i % j == 0) {
//                isPrime = false;
//                break;
//            }
//        }
//        if (isPrime) {      
//            ans += $"{i} ";
//        }
//    }
//}
//Console.WriteLine($"質因數有: {ans}");

// Q:輸入一個數，輸出其質因數(While寫法)

//int input;
//Console.WriteLine("請輸入數值");
//input = Convert.ToInt32(Console.ReadLine());
//string ans = "";
//bool isPrime = true;
//int time = 2;
//int checkedTime = 2;

//while (time <= input) {
//    //查看是否為因數
//    if (input % time == 0) {
//        // 查看是否為質數
//        checkedTime = 2;
//        while (checkedTime <= Math.Sqrt(time)){
//            isPrime = true;
//            if (time % checkedTime == 0) {
//                isPrime = false;
//                break;
//            }
//            checkedTime++;
//        }
//        if (isPrime) {
//            ans += $"{time} ";
//        }
//    }
//    time++;
//}

//Console.WriteLine($"質因數有: {ans}");


// Q:求100到300中可以被3與7整除的個數。

//int upper;
//int lower;
//Console.WriteLine("請輸入範圍下限");
//lower = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入範圍上限");
//upper = Convert.ToInt32(Console.ReadLine());
//int number = 0;
//string ans = "";

//for (int i = lower; i <= upper; i++)
//{
//    if (i % 3 == 0 )
//    {
//        number++;
//        ans += $"{i} ";
//    }
//    else if (i % 7 == 0) {
//        number++;
//        ans += $"{i} ";
//    }
//}
//Console.WriteLine(ans);
//Console.WriteLine($"總數有：{number}");




// Q:求100到300中可以被3與7整除的個數。(While寫法)

//int upper;
//int lower;
//Console.WriteLine("請輸入範圍下限");
//lower = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入範圍上限");
//upper = Convert.ToInt32(Console.ReadLine());
//int number = 0;
//string ans = "";

//while (lower <= upper) {
//	if (lower % 3 == 0)
//	{
//		number++;
//		ans += $"{lower} ";
//	}
//	else if (lower % 7 == 0) {
//		number++;
//		ans += $"{lower} ";
//	}
//	lower++;
//}
//Console.WriteLine(ans);
//Console.WriteLine($"總數有：{number}");

// Q:Ch4. 輸入2個數，求最大公約數 Pg69.

//int number1;
//int number2;
//Console.WriteLine("請輸入數字1:");
//number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入數字2:");
//number2 = Convert.ToInt32(Console.ReadLine());
//int maxCommon = 1;
//// 因數 --> 公因數 --> 最大公因數
//for (int i = 1; i <= number1; i++)
//{
//	// 查看是否為因數
//	if (number1 % i == 0) {
//		if (number2 % i == 0) {
//			if (i > maxCommon) {
//				maxCommon = i;
//			}
//		}
//	}
//}
//Console.WriteLine($"最大公因數為：{maxCommon}");

// Q:Ch4. 輸入2個數，求最大公約數 (While寫法)
//int number1;
//int number2;
//Console.WriteLine("請輸入數字1:");
//number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入數字2:");
//number2 = Convert.ToInt32(Console.ReadLine());
//int maxCommon = 1;
//int time = 1;
//// 因數 --> 公因數 --> 最大公因數

//while (time <= number1)
//{
//    // 查看是否為因數
//    if (number1 % time == 0)
//    {
//        if (number2 % time == 0)
//        {
//            if (time > maxCommon)
//            {
//                maxCommon = time;
//            }
//        }
//    }
//    time++;
//}

//Console.WriteLine($"最大公因數為：{maxCommon}");

// Q: 利用while寫一程式求N個數字的最大值

//int number;
//int time = 2;
//double max;
//Console.WriteLine("請輸入處理數字數量");
//number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入數字1");
//max = Convert.ToDouble(Console.ReadLine());
//double cur;
//while (time <= number) {
//	Console.WriteLine($"請輸入數字{time}");
//	cur = Convert.ToDouble(Console.ReadLine());
//	if (cur > max) {
//		max = cur;
//	}
//	time++;
//}
//Console.WriteLine($"最大值{max}");

// Q: 利用while寫一程式求一個等差級數數字的和，一共有N個數字，

//double init;
//double difference;
//int number;
//double max;
//double sum = 0;
//Console.WriteLine("請輸入初始值");
//init = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("請輸入數字數量");
//number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("請輸入差值");
//difference = Convert.ToDouble(Console.ReadLine());
//max = init + (number - 1) * difference;
//while (init <= max)
//{
//    sum += init;
//    init += difference;
//}
//Console.WriteLine($"等差級數合為：{sum}");



// Q: 利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和

//int number;
//Console.WriteLine("請輸入數字數量");
//number = Convert.ToInt32(Console.ReadLine());
//int time = 1;
//double sum = 0;
//double cur;
//while (time <= number) {
//	Console.WriteLine($"請輸入數字{time}");
//	cur = Convert.ToDouble(Console.ReadLine());
//	if (cur < 13) {
//		sum += cur;
//	}
//	time++;
//}
//Console.WriteLine($"總和是：{sum}");

// Q: 用while，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且印出這個數字。

//int number;
//Console.WriteLine("請輸入數字數量");
//number = Convert.ToInt32(Console.ReadLine());
//int time = 1;
//double cur;
//while (time <= number)
//{
//    Console.WriteLine($"請輸入數字{time}");
//    cur = Convert.ToDouble(Console.ReadLine());
//    if (cur > 7 && cur < 10)
//    {
//        Console.WriteLine($"符合區間數值：{cur}");
//        break;
//    }
//    time++;
//}
//if (time > number)
//{
//    Console.WriteLine("沒有數值符合區間");
//}

// Q;用while，讀入a1~a5和b1~b5。找到第一個ai>bi，即停止，並列印出ai及bi。

//int time = 1;
//double aCur;
//double bCur;
//while (time <= 5) {
//	Console.WriteLine($"請輸入a{time}");
//	aCur = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine($"請輸入b{time}");
//    bCur = Convert.ToDouble(Console.ReadLine());
//	if (aCur > bCur) {
//		Console.WriteLine($"a{time}:{aCur}大於b{time}:{bCur}");
//		break;
//	}
//	time++;
//}
//if (time > 5) {
//	Console.WriteLine("沒有任何ai>bi情形");
//}

// Q:Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他
// 決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
// 假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。

//Console.WriteLine("請輸入預計吃漢堡時間(分鐘)：");
//double timePeriod = Convert.ToDouble(Console.ReadLine());
//int timeEat = 1;
//for (int i = 0; i <= timePeriod; i+=5)
//{
//	Console.WriteLine($"Eric於{i}分鐘時吃第{timeEat}次『39元』漢堡");
//	timeEat++;
//}

// Q:小明貸款買房花560萬，每個月可還4萬，
// 每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清

//int loanPaymentTime = 0;
//int loanTotal = 560;
//int loanPayment = 4;
//int times = 0;

//for (int i = 0; 0 < loanTotal; i++)
//{
//	loanTotal -= loanPayment;
//	times++;
//    loanPaymentTime++;
//	if (loanPaymentTime % 12 == 0) {
//		loanPayment++;
//	}
//}
//Console.WriteLine($"小明於第{times}次還清房貸");

// Q:系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！
// 需提示是比較大還是比較小

////使用random class
//Random rnd = new Random();
//int randomNumber = rnd.Next(1, 100);
//int userinput;

//////由於不確定運作次數，使用while loop
//////怕userinput剛好等於randomNumber因此使用do while loop

//do
//{
//    Console.WriteLine("");
//    Console.WriteLine("請輸入數字1~100");
//    userinput = Convert.ToInt32(Console.ReadLine());
//    if (userinput == randomNumber)
//    {
//        Console.WriteLine($"答案為{randomNumber}");
//        break;
//    }
//    else if (userinput < randomNumber)
//    {
//        Console.WriteLine("答案比較大");
//    }

//    else
//    {
//        Console.WriteLine("答案比較小");
//    }
//}

//while (userinput != randomNumber);




