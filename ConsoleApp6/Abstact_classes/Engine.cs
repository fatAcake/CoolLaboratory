using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Abstact_classes
{
    abstract internal class Engine
    {
        protected float _i;//момент инерции двигателя
        protected List<int> _m;//Кусочно-линейная зависимость
        protected List<int> _v;// Крутящий момент
        protected float _t;//Температура перегрева
        protected float _hm;//Коэффициент зависимости скорости от крутящего момента
        protected float _hv; //Коэффициент зависимости скорости нагрева от скорости вращения коленвала
        protected float _c; //оэффициент зависимости скорости охлаждения от температуры двигателя и окружающей среды
        
        
        public abstract float EngineTemp {  get; }//Температура двигаетля
        public abstract float MaxTemp { get; } //Температура перегрева
        public abstract bool EngineStatus {  get; }//Работа двигаетля
        public abstract void Start(float TAir);//Момент запуска
        public abstract void Stop();//Момент остановки
    }
}
