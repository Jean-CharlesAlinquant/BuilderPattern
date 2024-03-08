
using System.Text;

public class Class
{
    public string? Name { get; set; }
    public List<Field> Fields = new List<Field>();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"public class {Name}").AppendLine("{");

        foreach (var field in Fields)
        {
            sb.AppendLine($"  {field}");
        }
        sb.AppendLine("}");
        return sb.ToString();
    }
}
