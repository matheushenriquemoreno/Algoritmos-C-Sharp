using System;

namespace tipo_referencia_tipo_valor {
    class Program {
        static void Main(string[] args) {
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);


        }
    }
}
