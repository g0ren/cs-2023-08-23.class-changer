using System.Reflection;

namespace CW;

static class ClassChanger
{

    private static void ChangeField(FieldInfo field, ref object @class)
    {
        switch (field.GetValue(@class))
        {
            case string _:
                field.SetValue(@class, (field.GetValue(@class) as string ?? "") + "broken");
                break;
            case int _:
                field.SetValue(@class, (field.GetValue(@class) as int? ?? 0) + 10);
                break;
            case bool _:
                field.SetValue(@class, !(bool?)field.GetValue(@class));
                break;
        }
    } 
    public static void ChangePrivateField(object @class)
    {
        var type = @class.GetType();
        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var field in fields)
        {
           ChangeField(field, ref @class);
        }
    }
    public static void ChangePrivateFieldIfAttributeSet(object @class)
    {
        var type = @class.GetType();
        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .Where(x => Attribute.IsDefined(x, typeof(ModifyFieldAttribute)));
        foreach (var field in fields)
        {
            ChangeField(field, ref @class);
        }
    }
        
}