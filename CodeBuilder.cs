public class CodeBuilder
{
    private readonly Class _class = new Class();
    public CodeBuilder(string className)
    {
        _class.Name = className;
    }

    public CodeBuilder AddField(string name, string type)
    {
        var field = new Field { Name = name, Type = type };
        _class.Fields.Add(field);
        return this;
    }

    public override string ToString()
    {
        return _class.ToString();
    }
}