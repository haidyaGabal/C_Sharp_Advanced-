using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Reflection
{
    public class UseReflection
    {
        public void Type()
        {
            Type type = typeof(Customer);

            var members = type.GetMembers(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static
            );

            foreach (var member in members)
            {
                Console.WriteLine($"{member.MemberType} - {member.Name}");
            }
        }
    }
}
