using MiniEFCore.Playground;

var context = new AppDbContext();

Console.WriteLine($"Context: {context.GetType().Name}");
Console.WriteLine("第一步：通过反射找出 AppDbContext 中的 DbSet<T> 属性。");
Console.WriteLine("打印属性名和实体类型，预期结果：TaskItems -> TaskItem。");

// TODO: 在这里开始实验，随后把通用逻辑提取到 MiniEFCore 类库。
