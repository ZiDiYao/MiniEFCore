using MiniEFCore;

namespace MiniEFCore.Playground;

public class AppDbContext : DbContext
{
    // 起步时手动创建，后续改成 => Set<TaskItem>()。
    public DbSet<TaskItem> TaskItems { get; } = new();
}
