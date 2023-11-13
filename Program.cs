using TransformarDateTime;

Valores valores = new Valores();
DateTime current = DateTime.Now;
int anoMesValor = valores.TransformData(current);
Console.WriteLine($"Data atual: {anoMesValor}");

