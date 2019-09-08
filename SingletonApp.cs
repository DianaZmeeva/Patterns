using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    public sealed class Singleton
    {
        private Singleton() { }

        public static Singleton Instance { get { return SingletonCreator.instance; } }

        private class SingletonCreator 
        {
            static SingletonCreator()
            {
            }

            internal static readonly Singleton instance = new Singleton();  
        }

    }

    //1. В зависимости от контекста  задачи: можно оставить класс public sealed или просто public. В данной реализации выбран sealed  - дополнительная возможность избежать изменений, которые могут внести вложенные классы-наследники. + По некоторым статьям это позволяет JIT-компилятору улучшить оптимизацию
    //2. Использование внутреннего класса SingletonCreator и его конструктора static SingletonCreator() позволяет инициализировать статический объект  instance только при обращении к нему.Это может быть полезно, если в дальнейшем в классе будут использованы другие статические переменные
    //3. Реализация потокобезопасна

}
