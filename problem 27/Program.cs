int count = int.Parse(Console.ReadLine());
Console.WriteLine(GetSum(count));

int GetSum(int count){
    int sum = 0;
    while(true){
        if(count == 0) break;
        count = count/10;
        sum = sum + count/10;
    }
    return sum;
}
