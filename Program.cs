int N = InputInt("введите число: ");

PrintNum(N);

void PrintNum(int N){
	if(0 < N){
		Console.Write(N + " ");
        PrintNum(N - 1);
		
	}
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}