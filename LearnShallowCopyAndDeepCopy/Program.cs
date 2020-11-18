using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LearnShallowCopyAndDeepCopy
{
    [Serializable]
    public class Person : ICloneable
    {
        public object Clone()
        {
            using (MemoryStream ms = new MemoryStream(1000))
            {
                object CloneObject;
                BinaryFormatter bf = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
                bf.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                // 反序列化至另一个对象(即创建了一个原对象的深表副本) 
                CloneObject = bf.Deserialize(ms);
                // 关闭流 
                ms.Close();
                return CloneObject;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p1 = (Person) p.Clone();
            Console.WriteLine(p == p1);
            Console.WriteLine(ReferenceEquals(p,p1));
        }
    }
}