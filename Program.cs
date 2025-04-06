double h, kWhm, cm;

Console.Clear();

Console.Write("Por quanto tempo o seu aparelho fica ligado por dia (h)? : ");
h = double.Parse(Console.ReadLine()!);

Console.WriteLine("Qual o consumo de energia do seu aparelho em (kwh/m) ? : ");
kWhm = double.Parse(Console.ReadLine()!);

cm = h * kWhm * 0.62258;

Console.Write($"{cm:C2}");