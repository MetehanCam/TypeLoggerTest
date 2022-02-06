using System.Text;

namespace BilgeAdam.TypeLogger
{
    public class Helper
    {
        public static string TypeLogger<T>()
        {
            var sb = new StringBuilder();
            Type type = typeof(T);
            var interfaces = type.GetInterfaces();
            foreach (var iface in interfaces)
            {
                sb.Append($"{iface.FullName}, ");
            }
            sb.Append($"{type.FullName}, ");
            sb.Append($"{type.Name}, ");
            sb.Append($"{type.BaseType} ");
            if (type.IsAbstract)
            {
                sb.Append($"Abstract");

            }
            if (type.IsEnum)
            {
                sb.Append($"Enum");

            }
            if (type.IsPrimitive)
            {
                sb.Append($"Primitve");

            }
            if (type.IsClass)
            {
                sb.Append($"Class");

            }
            if (type.IsInterface)
            {
                sb.Append($"Interface");

            }
            if (type.IsValueType)
            {
                sb.Append($"ValueType");

            }

            return sb.ToString();
        }
    }


    public abstract class EnemyMethods
    {
        public static void Attack(){}
    }
    public interface IMonster
    {
        public int Hp { get; set; }
        public int Dmg { get; set; }
    }
    public class skeleton : EnemyMethods , IMonster
    {
        public int ArrowDmg { get; set; }
        public int Hp { get; set; } = 100;
        public int Dmg { get; set; } = 5;
    }

    public class Zombie : IMonster
    {
        public int Hp { get; set; } = 250;
        public int Dmg { get; set; } = 20;
    }
}