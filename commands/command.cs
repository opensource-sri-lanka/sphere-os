public abstract class command
{
    public abstract void getInfo();
    public abstract void run(
        Cosmos.System.FileSystem.CosmosVFS vfs
   );
}
