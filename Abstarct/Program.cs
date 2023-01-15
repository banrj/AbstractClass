using Abstarct;

LinearClass linear = new LinearClass { Difference = 2, FirstNumber = 2, SequenceNumber = 4};

Console.WriteLine($"{linear.GetNNumber()} {linear.GetSumm()}");


ExponentialClass axponential = new ExponentialClass { Difference = 2, FirstNumber = 2, SequenceNumber = 4 };

Console.WriteLine($"{axponential.GetNNumber()} {axponential.GetSumm()}");
