using sphere_os.filesystem;

public abstract class command
{
    public abstract void getInfo();
    public abstract void Run(Cosmos.System.FileSystem.CosmosVFS vfs,  Dir dir, string[] input);
}
