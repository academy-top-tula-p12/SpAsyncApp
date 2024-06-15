var loop1 = LoopAsync();
var loop2 = LoopAsync();
var lambda = async () =>
{
    await Task.Run(() => Loop());
};
var loop3 = lambda();


Console.WriteLine("Main work");


await loop1;
await loop2;
await loop3;

async Task LoopAsync()
{
    await Task.Run(() => Loop());
}

void Loop()
{
    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Task #{Task.CurrentId} - {i}");
        Thread.Sleep(200);
    }
}
