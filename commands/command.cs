using sphere_os.filesystem;

public abstract class command
{
    public abstract void getInfo();
    public abstract void Run(CommandInput ci);

}

public class CommandInput
{
    public Cosmos.System.FileSystem.CosmosVFS vfs;
    public Dir dir;
    public string[] input;
}