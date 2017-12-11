using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _接口小练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 接口小练习

            // 什么时候用虚方法实现多态？   
            // ->
            // 什么时候用抽象类来实现多态？
            // ->
            // 什么时候用接口来实现多态？
            // ->


            // 真的鸭子会游泳， 木头鸭子不会游泳， 橡皮鸭子会游泳
            RealDuck realDuck = new RealDuck();
            WoodDuck woodDuck = new WoodDuck();
            EreaserDuck ereaserDuck = new EreaserDuck();

            realDuck.CanSwimMing();
            ereaserDuck.CanSwimMing();

            Console.ReadKey();
        }
    }


    public class RealDuck : ICanSwimming
    {
        public void CanSwimMing()
        {
            Console.WriteLine("真的鸭子会游泳");
        }
    }

    public class EreaserDuck : ICanSwimming
    {
        public void CanSwimMing()
        {
            Console.WriteLine("橡皮鸭子漂着游泳");
        }
    }

    public class WoodDuck 
    {

    }

    public interface ICanSwimming
    {
        void CanSwimMing();
    }


}
